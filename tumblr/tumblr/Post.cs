using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontPanic.TumblrSharp;
using DontPanic.TumblrSharp.Client;
using System.Windows.Forms;
using System.Threading;

namespace tumblr
{
    class Post
    {
        public void PostImg(){
            
            Query query = new Query();
            var imgs = query.Get_Image();
            foreach(var i in imgs){
                Tumblr.Client.CreatePostAsync(
                 Tumblr.BlogName, PostData.CreatePhoto(i.photos, i.title, "ursimple.com", i.tags, PostCreationState.Published)
                 );
                var inbox = Tumblr.Client.GetSubmissionPostsAsync(Tumblr.BlogName).Result;
                query.Insert_Posted(i.id);
                Application.DoEvents();
                Thread.Sleep(10000);
            }
            
        }
    }
}
