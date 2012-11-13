 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FitBit_Dashboard
{
    public class Height
    {
        public Image picture {get; set;}
        public String name { get; set; }
        public double feet { get; set; }

        public Height(String filepath, String name, double feet)
        {
            this.picture = Image.FromFile(filepath);
            this.name = name;
            this.feet = feet;
        }
    }
}
