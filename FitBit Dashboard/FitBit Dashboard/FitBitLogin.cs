using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Fitbit.Api;
using System.Collections;
using Fitbit.Models;


namespace FitBit_Dashboard
{
    public partial class FitBitLogin : Form
    {
        Dashboard dash;

        public FitBitLogin(Dashboard dashboard)
        {
            InitializeComponent();
            this.dash = dashboard;
        }

        private void FitBitLogin_Load(object sender, EventArgs e)
        {
            //make sure you've set these up in Web.Config under <appSettings>:
            string ConsumerKey = "84c3fd4c63f04ab88dff2ec80e7690a9";
            string ConsumerSecret = "5d8fe7b6849f4b0b8bf10261038ed836";


            Fitbit.Api.Authenticator authenticator = new Fitbit.Api.Authenticator(ConsumerKey,
                                                                                    ConsumerSecret,
                                                                                    "http://api.fitbit.com/oauth/request_token",
                                                                                    "http://api.fitbit.com/oauth/access_token",
                                                                                    "http://api.fitbit.com/oauth/authorize");
            string authUrl = authenticator.GetAuthUrlToken();

            webBrowser1.Url = new Uri(authUrl);
        //Final step. Take this authorization information and use it in the app
            dash.oauth_token = authUrl.Substring(authUrl.IndexOf("oauth_token=") +12);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConsumerKey = "84c3fd4c63f04ab88dff2ec80e7690a9";
            string ConsumerSecret = "5d8fe7b6849f4b0b8bf10261038ed836";
            Fitbit.Api.Authenticator authenticator = new Fitbit.Api.Authenticator(ConsumerKey,
                                                                                    ConsumerSecret,
                                                                                    "http://api.fitbit.com/oauth/request_token",
                                                                                    "http://api.fitbit.com/oauth/access_token",
                                                                                    "http://api.fitbit.com/oauth/authorize");
            dash.oauth_verifier = textBox1.Text.ToString();
            AuthCredential credential = authenticator.ProcessApprovedAuthCallback(dash.oauth_token, dash.oauth_verifier);
            dash.oauth_token = credential.AuthToken;
            dash.oauth_token_secret = credential.AuthTokenSecret;
            dash.user_id = credential.UserId;
            this.Close();
        }

        private void FitBitLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            FitbitClient client = new FitbitClient(dash.consumerKey, dash.consumerSecret, dash.oauth_token, dash.oauth_token_secret);
            List<UserProfile> profiles = client.GetFriends();
            dash.loggedInUser = client.GetUserProfile(dash.user_id);
            profiles.Add(dash.loggedInUser);
            foreach (UserProfile temp in profiles)
            {
                foreach (DictionaryEntry tempUser in dash.users)
                {
                    User theUser = (User)tempUser.Value;
                    if (theUser.firstName.Equals(temp.DisplayName.ToString()))
                    {
                        theUser.id = temp.EncodedId.ToString();
                        DateTime today = DateTime.Today;
                        ActivitySummary summary = client.GetSpecificUserDayActivitySummary(theUser.id, today);
                       theUser.statistics["Steps Taken"] = summary.Steps;
                       theUser.statistics["Stairs Climbed"] = summary.Floors;
                       theUser.statistics["Calories Burned"] = summary.CaloriesOut;
                       break;
                    }
                }
            }
        }
    }
}
