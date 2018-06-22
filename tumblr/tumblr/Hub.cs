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
        public string Photo_Posts()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("&type=link&tags=" + Uri.EscapeDataString("text,my first post"));
            sb.Append("&title="+ Uri.EscapeDataString("The title of the page the link points to, HTML entities should be escaped"));
            sb.Append("&url=" + Uri.EscapeDataString("https://ursimple.com"));
            sb.Append("&description=" + Uri.EscapeDataString("A user-supplied description, HTML allowed"));
            sb.Append("&thumbnail=" + Uri.EscapeDataString("https://cdn0-a.production.images.static6.com/n9JN76r8ZI1_o-ioRHkAIRFygzw=/640x360/smart/filters:quality(90)/vidio-media-production/uploads/1169411/images/beautiful-20in-20white-20-20westlife-20-shane-20filan-20with-20lyric-c7aa-640x360-00007.jpg"));
            sb.Append("&excerpt=" + Uri.EscapeDataString("An excerpt from the page the link points to, HTML entities should be escaped")); 
            sb.Append("&author=" + Uri.EscapeDataString("hackga")); 
            //if (!string.IsNullOrEmpty(link))
            //{
            //    if (type == 2)
            //        sb.Append("&link=" + HttpUtility.UrlEncode(link));
            //    else
            //        sb.Append("&link=" + HttpUtility.UrlEncode("https://ursimple.com/" + link));
            //}
            //sb.Append("&note=" + HttpUtility.UrlEncode(note));
            //if (!string.IsNullOrEmpty(image))
            //    sb.Append("&image_url=" + HttpUtility.UrlEncode("https:" + image.Replace("https:", "")));

            string data = sb.ToString().Substring(1);
            Call call = new Call();
            string auth = "";
            auth = "OAuth oauth_consumer_key=\"r1zitsw5SNu2e9ay9DKoghwTeHbC1WShb6XJBt4CVPrdjZ6eyy\",oauth_token=\"zFAfccuvSIalcSzGm0bXiy9YIr89vF2WLCTvtNPpOSmqFb2dQg\",oauth_signature_method=\"HMAC - SHA1\",oauth_timestamp=\"1529652140\",oauth_nonce=\"bW7nkuC4gG1\",oauth_version=\"1.0\",oauth_signature=\"nAChFlSfNdEI4Kaj9VFfAK7Vvfo % 3D\"";
            byte[] bytes = Encoding.ASCII.GetBytes(auth);
            string base64 = Convert.ToBase64String(bytes);
            string authorization = String.Concat("Basic ", base64);




            return call.Post(data, authorization);
        }
    }
}
