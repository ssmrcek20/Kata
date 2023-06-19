using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Human_Readable_Time
{
    public class HumanReadableTime
    {
        public string GetRedableTime(int seconds)
        {
            int hours = seconds / 3600;
            int minutes = (seconds / 60) % 60;
            int remainingSeconds = seconds % 60;
            return $"{hours:D2}:{minutes:D2}:{remainingSeconds:D2}";
        }
    }
}
