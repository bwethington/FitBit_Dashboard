using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace FitBit_Dashboard
{
    public class Group
    {
        public String name { get; set; }
        public int numMembers { get; set; }
        public Hashtable usersInGroup { get; set; }

        public Group(String name)
        {
            this.name = name;
            numMembers = 0;
            usersInGroup = new Hashtable();
        }

        public void addMember(User user)
        {
            if (usersInGroup.ContainsKey(user.name) == false)
            {
                usersInGroup.Add(user.name, user.group);
                numMembers++;
            }
        }
    }
}
