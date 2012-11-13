using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;
using System.Collections;
using FitBit_Dashboard;
using System.Net;
using System.IO;
using System.Xml;
using Fitbit.Api;
using Fitbit.Models;

namespace FitBit_Dashboard
{
    public partial class Dashboard : Form
    {
        public static double feetToMeters = 0.3048;
        public static double feetToMiles = 0.000189394;
        public static double strideLength = 2.455;

        public Hashtable users;
        public Hashtable groups {get; set;}
        public List<Food> foods { get; set; }
        public List<Height> heights { get; set; }
        public List<Distance> distances { get; set; }
        public Dictionary<String, String> facebookUser { get; set; }
        public UserProfile loggedInUser { get; set; }
        public String access_token { get; set; }
        public String fitbit_access_token { get; set; }
        public String oauth_verifier { get; set; }
        public String oauth_token { get; set; }
        public String oauth_token_secret { get; set; }
        public String user_id { get; set; }
        public String consumerKey { get; set; } 
        public String consumerSecret { get; set; }
    
        public Dashboard()
        {
            InitializeComponent();
            users = new Hashtable();
            groups = new Hashtable();
            foods = new List<Food>();
            heights = new List<Height>();
            distances = new List<Distance>();
            loggedInUser = null;
            access_token = "";
            fitbit_access_token = "";
            user_id = "";
            consumerKey = "84c3fd4c63f04ab88dff2ec80e7690a9";
            consumerSecret = "5d8fe7b6849f4b0b8bf10261038ed836";
            generateUserStubs();
        }

        public void generateUserStubs()
        {
            //User temp1 = new User("Emily", "Bichler", "AXO");
            User temp2 = new User("Brad", "Wethington", "FitBit Users");
            //User temp3 = new User("David", "Garrett", "FIJI");
            //User temp4 = new User("Botong", "Sui", "None");
            //User temp5 = new User("Mengxiao", "Han", "None");
            User temp6 = new User("Lily", "Robles", "FitBit Users");
            User temp7 = new User("Dave", "Berque", "dberque", "FitBit Users");
            //addUser(temp1);
            addUser(temp2);
            //addUser(temp3);
            //addUser(temp4);
            //addUser(temp5);
            addUser(temp6);
            addUser(temp7);
            /*Hashtable hash = new Hashtable();
            hash.Add("Calories Burned", 1028);
            hash.Add("Steps Taken", 10756);
            hash.Add("Stairs Climbed", 11);
            temp1.updateStats(hash);*/
            Hashtable hash1 = new Hashtable();
            hash1.Add("Calories Burned", 0);
            hash1.Add("Steps Taken", 0);
            hash1.Add("Stairs Climbed", 0);
            temp2.updateStats(hash1);
            /*Hashtable hash2 = new Hashtable();
            hash2.Add("Calories Burned", 1789);
            hash2.Add("Steps Taken", 4893);
            hash2.Add("Stairs Climbed", 3);
            temp3.updateStats(hash2);
            Hashtable hash3 = new Hashtable();
            hash3.Add("Calories Burned", 837);
            hash3.Add("Steps Taken", 679);
            hash3.Add("Stairs Climbed", 11);
            temp4.updateStats(hash3);
            Hashtable hash4 = new Hashtable();
            hash4.Add("Calories Burned", 0);
            hash4.Add("Steps Taken", 0);
            hash4.Add("Stairs Climbed", 0);
            temp5.updateStats(hash5);*/
            Hashtable hash5 = new Hashtable();
            hash5.Add("Calories Burned", 0);
            hash5.Add("Steps Taken", 0);
            hash5.Add("Stairs Climbed", 0);
            temp6.updateStats(hash5);
            Hashtable hash6 = new Hashtable();
            hash6.Add("Calories Burned", 0);
            hash6.Add("Steps Taken", 0);
            hash6.Add("Stairs Climbed", 0);
            temp7.updateStats(hash6);
            addGroup(new Group("AXO"));
            addGroup(new Group("PDT"));
            addGroup(new Group("FIJI"));
            addGroup(new Group("FitBit Users"));
            foods.Add(new Food("apple.jpg", "Medium Apple", 80));
            foods.Add(new Food("cheesecake.jpg", "Cheesecake Factory's Original Cheesecake", 710));
            foods.Add(new Food("big mac.jpg", "McDonald's Big Mac", 550));
            foods.Add(new Food("blue moon.jpg", "Blue Moon Beer", 171));
            foods.Add(new Food("cherry garcia.jpg", "Ben & Jerry's Cherry Garcia Ice-Cream", 250));
            foods.Add(new Food("chicken quesadilla.jpg", "Taco Bell's Chicken Quesadilla", 520)); 
            foods.Add(new Food("chocolate chip cookie.jpg", "Mrs. Field's Chocolate Chip Cookie", 210));
            foods.Add(new Food("chocolate milk.jpg", "TruMoo Chocolate Milk", 150));
            foods.Add(new Food("chocolate chip cookie.jpg", "Mrs. Field's Chocolate Chip Cookie", 210));
            foods.Add(new Food("jif.jpg", "Jif Creamy Peanut Butter", 190));
            foods.Add(new Food("pepperoni pizza.jpg", "Papa John's Pepperoni Pizza", 330));
            heights.Add(new Height("big ben.jpg", "Big Ben", 316));
            heights.Add(new Height("effiel tower.jpg", "Effiel Tower", 316));
            heights.Add(new Height("mount rushmore.jpg", "Mount Rushmore Busts", 60));
            heights.Add(new Height("redwood.jpg", "World's Tallest Tree - Redwood", 379.1));
            heights.Add(new Height("sears tower.jpg", "Sear's Tower", 1729));
            heights.Add(new Height("space needle.jpg", "Space Needle", 316));
            heights.Add(new Height("st peters.jpg", "St. Peter's Basilica", 452));
            heights.Add(new Height("statue of liberty.jpg", "Statue of Liberty", 305));
            heights.Add(new Height("tower of pisa.jpg", "Leaning Tower of Pisa", 186));
            heights.Add(new Height("washington monument.jpg", "Washington Monument", 555));
            distances.Add(new Distance("brooklyn bridge.jpg", "Brooklyn Bridge", 5988));
            distances.Add(new Distance("english channel.jpg", "English Channel - Strait of Dover", 110880));
            distances.Add(new Distance("golden gate.jpg", "Golden Gate Bridge", 8980));
            distances.Add(new Distance("mall of america.jpg", "Mall of America - Trip Around 1 Floor", 3010));
            distances.Add(new Distance("millau bridge.jpg", "Millau Bridge", 8071));
            distances.Add(new Distance("monon bell.jpg", "Distance From DePauw to Wabash", 151008));
            distances.Add(new Distance("national mall.jpg", "National Mall - Washington, D.C.", 10032));
            distances.Add(new Distance("the beast.jpg", "The Beast - World's Longest Wooden Roller Coaster", 7359));
            distances.Add(new Distance("tower bridge.jpg", "Tower Bridge", 801));
            distances.Add(new Distance("traffic jam.jpg", "World's Longest Traffic Jam", 316800));
        }

        private void generateImage()
        {
            Random r = new Random();
            int i = r.Next(0, 10);
            int j = r.Next(0, 10);
            int k = r.Next(0, 10);
            User temp = (User)users[(String)facebookUser["name"]];
            //Food
            foodImage.Image = foods[i].picture;
            int value =  (int)temp.statistics["Calories Burned"] / foods[i].calories;
            foodTextBox.Text = "You burned the same amount of calories as in " + value + " " + foods[i].name + "(s)!";
            //Distance Climbed
            distanceClimbedImage.Image = heights[j].picture;
            int theInt =  (int)temp.statistics["Stairs Climbed"];
            double  theDouble = theInt * 10;
            double percent = theDouble / heights[j].feet;
            percent = percent * 100;
            distanceClimbedTextBox.Text = "You climbed " + (int)percent  + "% of the " + heights[j].name + "!";
            //Distance Traveled
            distanceImage.Image = distances[k].picture;
            value =  (int)temp.statistics["Steps Taken"];
            theDouble = (double)value;
            double distanceTraveled = theDouble * strideLength;
            if (distanceTraveled > distances[k].feet)
            {
                value = (int)distanceTraveled / (int)distances[k].feet;
                distanceTextBox.Text = "You could have traveled the distance of the " + distances[k].name + " over " + value + " times!";
            }
            else
            {
                theDouble = distanceTraveled / distances[k].feet * 100;
                value = (int)theDouble;
                distanceTextBox.Text = "You traveled " + value + "% of the " + distances[k].name + "!";
            }

             foodImage.SizeMode = PictureBoxSizeMode.CenterImage;
            distanceClimbedImage.SizeMode = PictureBoxSizeMode.CenterImage;
            distanceImage.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void tabs_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (competitionTab.SelectedTab.Text.ToString().Equals("Groups"))
            {
                groupsListBox.Items.Clear();
                populateGroupsComboBox();
                populateUsersListBox();
            }
            else if (competitionTab.SelectedTab.Text.ToString().Equals("My Group"))
            {
                populateMyGroupTab();
            }
            else if (competitionTab.SelectedTab.Text.ToString().Equals("Users"))
            {
            }
            else if (competitionTab.SelectedTab.Text.ToString().Equals("My Stuff")) 
            {
                populateMyStuffTab();
            }
            else if(competitionTab.SelectedTab.Text.ToString().Equals("Leaderboard"))
            {
                populateLeaderboard();
            }
        }
        public void populateMyStuffTab()
        {
            myStatsTextBox.Text = "";
            User temp = (User)users[(String)facebookUser["name"]];
            foreach (DictionaryEntry item in temp.statistics)
            {
                myStatsTextBox.AppendText(item.Key.ToString() + "\n");
                myStatsTextBox.AppendText(item.Value.ToString() + "\n");
                myStatsTextBox.AppendText("\n");
            }
            myStatsTextBox.Select(0, 0);
            generateImage();
        }
        public void populateMyGroupTab()
        {
            if (facebookUser != null)
            {
                User temp = (User)users[(String)facebookUser["name"]];
                statsTextBox.Text = "";
                myGroupTextBox.Text = temp.group;
                nameLabel.Text = facebookUser["name"] + "'s Group";
                String sessionUserGroup = temp.group;
                teammatesListBox.Items.Clear();
                if (temp.group.Equals("None") == false)
                {
                    foreach (DictionaryEntry item in users)
                    {
                        User theUser = (User)item.Value;
                        if (theUser.group.Equals(sessionUserGroup) && item.Key.ToString().Equals((String)facebookUser["name"]) == false)
                            teammatesListBox.Items.Add(item.Key.ToString());
                    }
                }
                groupStatsTextBox.Text = "";
                Hashtable hash = new Hashtable();
                foreach (DictionaryEntry user in users)
                {
                    User theUser = (User)user.Value;
                    if (temp.group.Equals(theUser.group))
                    {
                        foreach (DictionaryEntry item in theUser.statistics)
                        {
                            if (hash.ContainsKey(item.Key.ToString()) == false)
                                hash.Add(item.Key.ToString(), item.Value);
                            else
                                hash[item.Key.ToString()] = (int)hash[item.Key.ToString()] + (int)item.Value;
                        }
                    }
                }
                foreach (DictionaryEntry item in hash)
                {
                        groupStatsTextBox.AppendText(item.Key.ToString() + "\n");
                        groupStatsTextBox.AppendText(item.Value.ToString() + "\n");
                        groupStatsTextBox.AppendText("\n");
                }
                groupStatsTextBox.Select(0, 0);
            }
        }

        public void populateGroupLeaderboard()
        {
            Hashtable hash = new Hashtable();
            List<Object[]> theGroups = new List<Object[]>();
            int rank = 1;
            groupLeaderboard.Rows.Clear();
            foreach (DictionaryEntry item in groups)
            {
                hash.Clear();
                int num = 0;
                foreach (DictionaryEntry thing in users)
                {
                    User user = (User)thing.Value;
                    if (user.group.ToString().Equals(item.Key.ToString()))
                    {
                        num++;
                        foreach (DictionaryEntry stat in user.statistics)
                        {
                            if (hash.ContainsKey(stat.Key.ToString()) == false)
                                hash.Add(stat.Key.ToString(), stat.Value);
                            else
                                hash[stat.Key.ToString()] = (int)hash[stat.Key.ToString()] + (int)stat.Value;
                        }
                    }
                }
                if (num != 0)
                {
                    Object[] arr = new Object[5];
                    arr[1] = item.Key.ToString();
                    foreach (DictionaryEntry stat in hash)
                    {
                        if (stat.Key.ToString().Equals("Steps Taken"))
                            arr[2] = stat.Value;
                        else if (stat.Key.ToString().Equals("Stairs Climbed"))
                            arr[3] = stat.Value;
                        else if (stat.Key.ToString().Equals("Calories Burned"))
                            arr[4] = stat.Value;
                    }
                    theGroups.Add(arr);
                }
            }
            IEnumerable<Object[]> sorted = theGroups.OrderByDescending(s => s[2]);
            foreach (Object[] g in sorted)
            {
                g[0] = rank;
                rank++;
                groupLeaderboard.Rows.Add(g);
            }
        }

        public void populateIndividualLeaderboard()
        {
            individualLeaderboard.Rows.Clear();
            List<Object[]> list = new List<Object[]>();
            int rank = 1;
            foreach (DictionaryEntry theUser in users)
            {
                User user = (User)theUser.Value;
                Object[] arr = new Object[5];
                arr[1] = user.name.ToString();
                foreach (DictionaryEntry stat in user.statistics)
                {
                    if (stat.Key.ToString().Equals("Steps Taken"))
                        arr[2] = stat.Value;
                    else if (stat.Key.ToString().Equals("Stairs Climbed"))
                        arr[3] = stat.Value;
                    else if (stat.Key.ToString().Equals("Calories Burned"))
                        arr[4] = stat.Value;
                }
                if (user.statistics.Count == 0)
                {
                    arr[2] = arr[3] = arr[4] = 0;
                }
                list.Add(arr);
            }
            //IEnumerable<String[]> sorted = list.OrderByDescending(s => int.Parse(s[2]));
            IEnumerable<Object[]> sorted = list.OrderByDescending(s => s[2]);
            foreach (Object[] person in sorted)
            {
                person[0] = rank;
                rank++;
                individualLeaderboard.Rows.Add(person);
            }
        }

        public void populateLeaderboard()
        {
            populateGroupLeaderboard();
            populateIndividualLeaderboard();
        }

        public void populateUsersListBox()
        {
            usersListBox.Items.Clear();
            foreach (DictionaryEntry item in users)
            {
                User temp = (User)item.Value;
                if (temp.group.Equals("None"))
                    usersListBox.Items.Add(item.Key.ToString());
            }
        }

        public void populateGroupsComboBox()
        {
            groupsComboBox.Items.Clear();
            foreach (DictionaryEntry item in groups)
            {
                groupsComboBox.Items.Add(item.Key.ToString());
            }
        }

        private void add_user_button_Click(object sender, EventArgs e)
        {
            add_user_form addUserForm = new add_user_form();
            addUserForm.Show();
            addUserForm.start(this);
        }

        public void addUser(User theUser)
        {
            if (users.ContainsKey(theUser.name) == false)
                users.Add(theUser.name, theUser);
            else
                MessageBox.Show("A user already exists with this name.");
        }

        public void addGroup(Group theGroup)
        {
            if (groups.ContainsKey(theGroup.name) == false)
                groups.Add(theGroup.name, theGroup.usersInGroup);
            else
                MessageBox.Show("A group already exists with this name.");
        }

        private void addGroupButton_Click(object sender, EventArgs e)
        {
            AddGroupForm addGroupForm = new AddGroupForm(this);
            addGroupForm.Show();
        }

        private void groupsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupsListBox.Items.Clear();
            foreach (DictionaryEntry item in users)
            {
                User temp = (User)item.Value;
                if (temp.group.Equals(groupsComboBox.SelectedItem.ToString()))
                    groupsListBox.Items.Add(item.Key.ToString());
            }
        }

        private void addToGroup_Click(object sender, EventArgs e)
        {
            if (groupsComboBox.SelectedItem != null && usersListBox.SelectedItem != null)
            {
                User temp = (User)users[usersListBox.SelectedItem.ToString()];
                temp.group = groupsComboBox.SelectedItem.ToString();
                groupsListBox.Items.Add(temp.name);
                usersListBox.Items.Remove(temp.name);
            }
        }

        private void removeFromGroup_Click(object sender, EventArgs e)
        {
            if (groupsListBox.SelectedItem != null)
            {
                String itemRemoved = groupsListBox.SelectedItem.ToString();
                User temp = (User)users[itemRemoved];
                temp.group = "None";
                groupsListBox.Items.Remove(itemRemoved);
                usersListBox.Items.Add(itemRemoved);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            FacebookLogin fbForm = new FacebookLogin(this);
            fbForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            FacebookLogin fbForm = new FacebookLogin(this);
            fbForm.Show();
            fbForm.logoutButton_Click(sender, e);
        }

        private void teammatesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teammatesListBox.SelectedItem != null)
            {
                statsTextBox.Text = "";
                User userStats = (User)users[(String)teammatesListBox.SelectedItem.ToString()];
                foreach (DictionaryEntry item in userStats.statistics)
                {
                    statsTextBox.AppendText(item.Key.ToString() + "\n");
                    statsTextBox.AppendText(item.Value.ToString() + "\n");
                    statsTextBox.AppendText("\n");
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (user_id.Equals("") == false) 
                refreshFitbitApi();
            populateLeaderboard();
        }

        private void refreshFitbitApi()
        {
            if (leaderboardComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a time frame from the dropdown.");
                return;
            }
            FitbitClient client = new FitbitClient(consumerKey, consumerSecret, oauth_token, oauth_token_secret);
            List<UserProfile> profiles = client.GetFriends();
            profiles.Add(loggedInUser);
            DateTime endDate = DateTime.Today;
            DateTime startDate = DateTime.Today;
            if (leaderboardComboBox.SelectedItem.Equals("Day"))
            {
                DateTime today = DateTime.Today;
                foreach (UserProfile temp in profiles)
                {
                    foreach (DictionaryEntry tempUser in users)
                    {
                        User theUser = (User)tempUser.Value;
                        if (theUser.displayName.Equals(temp.DisplayName.ToString()))
                        {
                            theUser.id = temp.EncodedId.ToString();
                            ActivitySummary summary = client.GetSpecificUserDayActivitySummary(theUser.id, today);
                            theUser.statistics["Steps Taken"] = summary.Steps;
                            theUser.statistics["Stairs Climbed"] = summary.Floors;
                            theUser.statistics["Calories Burned"] = summary.CaloriesOut;
                            break;
                        }
                    }
                }
                return;
            }
            else if (leaderboardComboBox.SelectedItem.Equals("Week"))
            {
                endDate = DateTime.Today;
                startDate = endDate.Subtract(TimeSpan.FromDays(6));
            }
            else if (leaderboardComboBox.SelectedItem.Equals("Month"))
            {
                endDate = DateTime.Today;
                startDate = endDate.Subtract(TimeSpan.FromDays(29));
            }
            else if (leaderboardComboBox.SelectedItem.Equals("Competition"))
            {
                startDate = startDateTimePicker.Value;
                endDate = DateTime.Today;
            }
            foreach (UserProfile temp in profiles)
            {
                foreach (DictionaryEntry tempUser in users)
                {
                    User theUser = (User)tempUser.Value;
                    if (theUser.displayName.Equals(temp.DisplayName.ToString()))
                    {
                        theUser.id = temp.EncodedId.ToString();
                        TimeSeriesDataListInt steps = client.GetTimeSeriesInt(TimeSeriesResourceType.StepsTracker, startDate, endDate, theUser.id);
                        TimeSeriesDataListInt floors = client.GetTimeSeriesInt(TimeSeriesResourceType.FloorsTracker, startDate, endDate, theUser.id);
                        TimeSeriesDataListInt calories= client.GetTimeSeriesInt(TimeSeriesResourceType.CaloriesOutTracker, startDate, endDate, theUser.id);
                        int totalSteps = 0, totalFloors = 0, totalCalories = 0;
                        for (int i = 0; i < steps.DataList.Count; i++)
                        {
                           totalSteps += steps.DataList[i].Value;
                           totalFloors += floors.DataList[i].Value;
                           totalCalories += calories.DataList[i].Value;
                        }
                        theUser.statistics["Steps Taken"] = totalSteps;
                        theUser.statistics["Stairs Climbed"] = totalFloors;
                        theUser.statistics["Calories Burned"] = totalCalories;
                        break;
                    }
                }
            }
        }

        private void fitbitLoginButton_Click(object sender, EventArgs e)
        {
            FitBitLogin fitBitForm = new FitBitLogin(this);
            fitBitForm.Show();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            //refreshFitbitApi();
            populateLeaderboard();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
        }
    }
}
