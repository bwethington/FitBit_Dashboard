using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace FitBit_Dashboard
{
    public class User
    {
        public String firstName {get; set;}
        public String lastName { get; set; }
        public String displayName {get; set;}
        public String name { get; set; }
        public String group {get; set;}
        public String id {get; set;}
        public Hashtable statistics { get; set; }

        public User(String firstName, String lastName, String displayName,  String group)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.name = firstName + " " + lastName;
            this.group = group;
            this.displayName = displayName;
            statistics = new Hashtable();
            this.id = "";
        }

        //Constructor for if the displayname is not set, it is set to the person's first name by default
        public User(String firstName, String lastName, String group)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.name = firstName + " " + lastName;
            this.group = group;
            this.displayName = firstName;
            statistics = new Hashtable();
            this.id = "";
        }

        public void updateStats(Hashtable stats)
        {
            this.statistics = stats;
        }
    }
}
