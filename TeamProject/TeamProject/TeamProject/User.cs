using System;
using System.Collections.Generic;
using System.Text;

namespace TeamProject
{
    class User
    {
        public int? Age { get; set; }
        public double? Weight { get; set; }
        public string Sex { get; set; }
        public double? WidmarK { get; set; }

        public User(int? age, double? weight, string sex, double? widmarK)
        {
            Age = age;
            Weight = weight;
            Sex = sex;
            WidmarK = widmarK;
        }
    }
}
