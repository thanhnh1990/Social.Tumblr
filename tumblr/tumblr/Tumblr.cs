using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontPanic.TumblrSharp;
using DontPanic.TumblrSharp.Client;

namespace tumblr
{
    public static class Tumblr
    {
        const string CONSUMER_KEY = "r1zitsw5SNu2e9ay9DKoghwTeHbC1WShb6XJBt4CVPrdjZ6eyy";
        const string CONSUMER_SECRET = "e64Mc86prFNi0vGjCC8JvwzVYuWq7aaFL3KyEkp0ST2Ak9XXvU";
        const string OAUTH_TOKEN = "zFAfccuvSIalcSzGm0bXiy9YIr89vF2WLCTvtNPpOSmqFb2dQg";
        const string OAUTH_TOKEN_SECRET = "AJd6tquWfU3jNUC5nmYDAraZWQnSQNDtpNzmHhB2CeBg7bZmnR";
        
        static public TumblrClient Client;
        static public string BlogName { get; set; } 
       
        static Tumblr()
        {
            BlogName = "ibestsimple";
            Client = new TumblrClientFactory().Create<TumblrClient>(
        CONSUMER_KEY,
        CONSUMER_SECRET,
        new DontPanic.TumblrSharp.OAuth.Token(
            OAUTH_TOKEN, OAUTH_TOKEN_SECRET));
        }
    }
}
