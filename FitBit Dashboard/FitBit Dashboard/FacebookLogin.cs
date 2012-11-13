using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.IO;

namespace FitBit_Dashboard
{
    public partial class FacebookLogin : Form
    {
        Dashboard dash;
        public FacebookLogin(Dashboard dash)
        {
            InitializeComponent();
            this.dash = dash;
        }

        private void FacebookLogin_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (sender.Equals(dash.logoutButton) == false)
                webBrowser1.Url = new Uri("https://www.facebook.com/dialog/oauth?client_id=453257974725971&redirect_uri=https://www.facebook.com/connect/login_success.html&response_type=token");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (webBrowser1 != null && webBrowser1.Url != null && webBrowser1.Url.ToString().Contains("#"))
            {
                int begIndex = webBrowser1.Url.ToString().IndexOf("token=") + 6;
                int endIndex = webBrowser1.Url.ToString().IndexOf("&expires");
                dash.access_token = webBrowser1.Url.ToString().Substring(begIndex, endIndex - begIndex);
            }
        }

        public void logoutButton_Click(object sender, EventArgs e)
        {
           WebRequest request = WebRequest.Create("https://www.facebook.com/logout.php?next=http://www.depauw.edu&access_token=" + dash.access_token);
            //WebRequest request = WebRequest.Create("https://graph.facebook.com/me?fields=name&access_token=" + dash.access_token);
           webBrowser1.Url = new Uri("http://www.yahoo.com");
            //webBrowser1.Url = new Uri("https://www.facebook.com/dialog/oauth?client_id=453257974725971&redirect_uri=https://www.facebook.com/connect/login_success.html&response_type=token");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("https://graph.facebook.com/me?fields=name&access_token=" + dash.access_token);
            Console.WriteLine(dash.access_token);
            request.ContentType = "application/json; charset=utf-8";
            String text;
            if (request != null)
            {
                var response = (HttpWebResponse)request.GetResponse();
                if (response != null)
                {
                    using (var sr = new StreamReader(response.GetResponseStream()))
                    {
                        text = sr.ReadToEnd();
                    }
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    Dictionary<String, String> values = js.Deserialize<Dictionary<String, String>>(text);
                    dash.facebookUser = values;
                    if (dash.users.Contains(values["name"]) == false)
                    {
                        String name = values["name"];
                        int index = name.IndexOf(' ');
                        String firstName = name.Substring(0, index);
                        String lastName = name.Substring(index);
                        dash.addUser(new User(firstName, lastName, "None"));
                    }
                    dash.populateMyGroupTab();
                    dash.populateMyStuffTab();
                }
            }
            timer1.Stop();
            this.Visible = false;
        }
    }
}
