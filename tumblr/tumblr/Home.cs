using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DontPanic.TumblrSharp;
using DontPanic.TumblrSharp.Client;

namespace tumblr
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1800000;
            timer1_Tick(sender, e);
            //foreach (var message in inbox)
            //{
            //    var msg = (AnswerPost)message;

            //    //Tumblr.Client.EditPostAsync(
            //    //    Tumblr.BlogName, msg.Id, PostData.CreateAnswer(
            //    //        "hello", 175168455559, PostCreationState.Published));
            //}
            //Hub a = new Hub();
            //a.Photo_Posts();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Post post = new Post();
            post.PostImg();
        }
        private void Home_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

       
    }
}
