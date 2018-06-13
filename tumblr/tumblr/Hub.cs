using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace tumblr
{
    class Hub
    {
        public string Photo_Posts(string boardname, string note, string image, string link, int type)
        {
            boardname = boardname.Replace(" ", "-");
            string url = "";

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
            Call call = new Call();
            return call.Post(url, data);
        }
    }
}
