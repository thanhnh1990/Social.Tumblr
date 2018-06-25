using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Data.Linq;
using System.IO;
using DontPanic.TumblrSharp;
namespace tumblr
{
    class Data
    {
        public int id { get; set; }
        public IEnumerable<BinaryFile> photos { get; set; }
        public string title { get; set; }

        public IEnumerable<string> tags { get; set; }
        
        public byte[] CovertImgUrl(string url)
        {
            byte[] raw = null;
            try
            {
                using (var client = new WebClient())
                {
                    raw = client.DownloadData(url);
                }
            }catch(Exception ex)
            {

            }

            return raw;

        }

        public string[] ConvertTags(string tag)
        {
            List<string> tags = new List<string>();
            string[] words = new string[] { "a", "are", "an", "the", "is", "to", "it", "us", "i", "you", "of", "with", "on", "at", "be", "for", "as", "s", "has", "have", "had", "this", "that", "and", "got", "what", "where", "when", "so", "much", "not", "no", "those", "me", "will", "ll", "can", "t", "don" };
            string modifiedRemove = String.Join("", tag.Split('@', ',', '.', ';', '\''));
            string[] replaceChar = modifiedRemove.Split(' ');
            for (int i = 0; i < replaceChar.Count(); i++)
            {
                if (replaceChar[i] != "")
                {
                    if (!words.Contains(replaceChar[i]))
                    {
                        tags.Add("#" + replaceChar[i].Trim());
                    }
                }
            }
            return tags.ToArray();

        }
    }
}
