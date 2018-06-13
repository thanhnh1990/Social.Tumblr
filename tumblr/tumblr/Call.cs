using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace tumblr
{
    class Call
    {
        public string Post(string url, string data)
        {
            string json = null;
            Logs log = new Logs();
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "POST";
                req.ContentType = "application/x-www-form-urlencoded";
                //  req.Accept = "application/json";
                using (var stream = req.GetRequestStream())
                {
                    byte[] bindata = Encoding.ASCII.GetBytes(data);
                    stream.Write(bindata, 0, bindata.Length);
                }
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                string response = new StreamReader(resp.GetResponseStream()).ReadToEnd();

                return response;
            }
            catch (WebException wex)
            {
                if (wex.Response != null)
                {
                    using (var errorResponse = (HttpWebResponse)wex.Response)
                    {
                        using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                        {
                            var a = reader.ReadToEnd().ToString();
                            log.IErrors(url + " : " + data + " :::: " + a, "Post");
                            if (a == "{\"data\": null}")
                                return null;
                            if (a.Contains("Sorry") || a == "{\"message\": \"Sorry! This site doesn't allow you to save Pins.\", \"type\": \"api\"}" || a == "{\"message\": \"Your image is too small. Please choose a larger image and try again.\", \"type\": \"api\"}")
                                return "Sorry";
                            if (a == "{\n  \"message\": \"You have exceeded your rate limit. Try again later.\",\n  \"type\": \"api\"\n}")
                                return "limit";
                            return json;
                        }
                    }
                }
                return json;
            }
        }

        public string Get(string url)
        {
            string json = null;
            Logs log = new Logs();
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "GET";
                req.Accept = "application/json";

                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                json = new StreamReader(resp.GetResponseStream()).ReadToEnd();

                return json;
            }
            catch (WebException wex)
            {
                if (wex.Response != null)
                {
                    using (var errorResponse = (HttpWebResponse)wex.Response)
                    {
                        using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                        {
                            string error = reader.ReadToEnd().ToString();
                            log.IErrors(url + " : " + error, "Get");
                            if (error == "{\"data\": null}")
                                return null;
                            if (error == "{\"status\": \"failure\", \"message\": \"Board not found.\", \"code\": 40, \"data\": null, \"error\": {\"message\": \"None\"}}")
                                return "Board not found";
                            if (error == "{\"status\": \"failure\", \"message\": \"User not found.\", \"code\": 30, \"data\": null, \"error\": {\"message\": \"None\"}}")
                                return "Board not found";
                            if (error == "{\n  \"message\": \"You have exceeded your rate limit. Try again later.\",\n  \"type\": \"api\"\n}")
                                return "limit";
                            return json;

                        }
                    }
                }
            }
            return json;
        }
    }
}
