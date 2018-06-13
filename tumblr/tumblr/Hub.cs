using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumblr
{
    class Hub
    {
        public string Img(string boardname, string note, string image, string link, int type)
        {
            boardname = boardname.Replace(" ", "-");
            string url = "https://api.pinterest.com/v1/pins/?access_token=Ab1rhweqeChC5tmKgfILFrE6t-TYFNwv7w_soZhELMu2AwBCWQAAAAA&fields=id%2Clink%2Cnote%2Curl";

            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(boardname))
                sb.Append("&board=" + HttpUtility.UrlEncode("besttshirtsusa/" + boardname));
            if (!string.IsNullOrEmpty(link))
            {
                if (type == 2)
                    sb.Append("&link=" + HttpUtility.UrlEncode(link));
                else
                    sb.Append("&link=" + HttpUtility.UrlEncode("https://besttshirtusa.com/product" + link));
            }
            sb.Append("&note=" + HttpUtility.UrlEncode(note));
            if (!string.IsNullOrEmpty(image))
                sb.Append("&image_url=" + HttpUtility.UrlEncode("https:" + image.Replace("https:", "")));

            string data = sb.ToString().Substring(1);
            CallApi call = new CallApi();
            return call.Post(url, data);
        }
    }
}
