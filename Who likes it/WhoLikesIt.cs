using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Who_likes_it
{
    public class WhoLikesIt
    {
        public string GetDisplayText(string[] names)
        {
            switch (names.Length)
            {
                case 0: return "no one likes this";
                case 1: return names[0] + " likes this";
                case 2: return names[0] + " and " + names[1] + " like this";
                case 3: return names[0] + ", " + names[1] + " and " + names[2] + " like this";
                default: return names[0] + ", " + names[1] + " and " + GetNumberOfPeopele(names) + " others like this";
            }
        }

        private string GetNumberOfPeopele(string[] names)
        {
            int number = names.Count() -2;
            return number.ToString();
        }
    }
}
