using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace tumblr
{
    class Call
    {
        const string consumerKey = "r1zitsw5SNu2e9ay9DKoghwTeHbC1WShb6XJBt4CVPrdjZ6eyy";
        const string consumerSecret = "e64Mc86prFNi0vGjCC8JvwzVYuWq7aaFL3KyEkp0ST2Ak9XXvU";
        const string tokenSecret = "AJd6tquWfU3jNUC5nmYDAraZWQnSQNDtpNzmHhB2CeBg7bZmnR";
        const string tokenValue = "zFAfccuvSIalcSzGm0bXiy9YIr89vF2WLCTvtNPpOSmqFb2dQg";
        const string url = "https://api.tumblr.com/v2/blog/ibestsimple/post";
        string Escape(string s)
        {
            var charsToEscape = new[] { "!", "*", "'", "(", ")" };
            var escaped = new StringBuilder(Uri.EscapeDataString(s));
            foreach (var t in charsToEscape)
            {
                escaped.Replace(t, Uri.HexEscape(t[0]));
            }
            return escaped.ToString();
        }

        string SimpleQuote(string s) {
            return '"' + s + '"';
        } 
        public string Post(string data, string authHeaders)
        {
            string json = null;
            Logs log = new Logs();
            try
            {

                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "POST";

                var timeStamp = ((int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds).ToString();
                var nonce = Convert.ToBase64String(Encoding.UTF8.GetBytes(timeStamp));

                var signatureBaseString = Escape(req.Method.ToUpper()) + "&";
                signatureBaseString += Uri.EscapeDataString(url.ToLower()) + "&";
                signatureBaseString += Uri.EscapeDataString(
                    "oauth_consumer_key=" + Uri.EscapeDataString(consumerKey) + "&" +
                    "oauth_nonce=" + Uri.EscapeDataString(nonce) + "&" +
                    "oauth_signature_method=" + Uri.EscapeDataString("HMAC-SHA1") + "&" +
                    "oauth_timestamp=" + Uri.EscapeDataString(timeStamp) + "&" +
                    "oauth_token=" + Uri.EscapeDataString(tokenValue) + "&" +
                    "oauth_version=" + Uri.EscapeDataString("1.0"));

                var key = Uri.EscapeDataString(consumerSecret) + "&" + Uri.EscapeDataString(tokenSecret);

                var signatureEncoding = new ASCIIEncoding();
                var keyBytes = signatureEncoding.GetBytes(key);
                var signatureBaseBytes = signatureEncoding.GetBytes(signatureBaseString);
                string signatureString;
                using (var hmacsha1 = new HMACSHA1(keyBytes))
                {
                    var hashBytes = hmacsha1.ComputeHash(signatureBaseBytes);
                    signatureString = Convert.ToBase64String(hashBytes);
                }
                signatureString = Uri.EscapeDataString(signatureString);

               
                var header =
                    "OAuth realm=" + SimpleQuote("") + "," +
                    "oauth_consumer_key=" + SimpleQuote(consumerKey) + "," +
                    "oauth_nonce=" + SimpleQuote(nonce) + "," +
                    "oauth_signature_method=" + SimpleQuote("HMAC-SHA1") + "," +
                    "oauth_timestamp=" + SimpleQuote(timeStamp) + "," +
                    "oauth_token=" + SimpleQuote(tokenValue) + "," +
                    "oauth_version=" + SimpleQuote("1.0") + "," +
                    "oauth_signature= " + SimpleQuote(signatureString);

                req.ContentType = "application/x-www-form-urlencoded";
                req.Headers.Add(HttpRequestHeader.Authorization, header);

                using (var stream = req.GetRequestStream())
                {
                    byte[] bindata = Encoding.ASCII.GetBytes(data);
                    stream.Write(bindata, 0, bindata.Length);
                }
                var resp = (HttpWebResponse)req.GetResponse();
                var characterSet = ((HttpWebResponse)resp).CharacterSet;
                var responseEncoding = characterSet == ""
                    ? Encoding.UTF8
                    : Encoding.GetEncoding(characterSet ?? "utf-8");
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
