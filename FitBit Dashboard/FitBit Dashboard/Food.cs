using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FitBit_Dashboard
{
    public class Food
    {
        public Image picture {get; set;}
        public String name { get; set; }
        public int calories { get; set; }

        public Food(String filepath, String name, int calories)
        {
            this.picture = Image.FromFile(filepath);
            this.calories = calories;
            this.name = name;
        }
    }
}
