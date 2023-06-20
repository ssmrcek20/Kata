using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.RangeExtraction
{
    public class RangeExtraction
    {
        public string Extract(int[] args)
        {
            StringBuilder sb = new StringBuilder();
            bool inRange = false;
            for(int i = 1; i < args.Length-1; i++)
            {
                if(i > 2 && args[i-1] == args[i-2])
                {

                }
                else if (args[i] != args[i-1]+1)
                {
                    sb.Append(args[i-1]);
                    sb.Append(",");
                }
                else if(!inRange && args[i] == args[i+1]-1)
                {
                    sb.Append(args[i-1]);
                    sb.Append("-");
                    inRange = true;
                }
                else if(inRange && args[i] != args[i+1]-1)
                {
                    sb.Append(args[i]);
                    sb.Append(",");
                    inRange = false; 
                    i++;
                }
                else if(!inRange)
                {
                    sb.Append(args[i-1]);
                    sb.Append(",");
                }
            }
            if(args.Length == 2)
            {
                sb.Append(args[0]);
                sb.Append(",");
            }
            else if (!inRange && args[args.Length-2] != args[args.Length-3])
            {
                sb.Append(args[args.Length-2]);
                sb.Append(",");
            }
            sb.Append(args[args.Length-1]);
            return sb.ToString();
        }
    }
}
