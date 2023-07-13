using System;
using System.CodeDom;
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
            bool lastArg = false;

            for (int i = 0; i < args.Length-1; i++)
            {
                if (NoRange(args, i))
                {
                    AddArg(args, sb, i);
                }
                else if (IsRange(args, i))
                {
                    AddRange(args, sb, ref lastArg, ref i);
                }
                else AddArg(args, sb, i);
            }
            if (!lastArg) sb.Append(LastArg(args));

            return sb.ToString();
        }

        private static int LastArg(int[] args)
        {
            return args[args.Length-1];
        }

        private static void AddRange(int[] args, StringBuilder sb, ref bool lastArg, ref int i)
        {
            int startRange = args[i];
            for (i +=2; i<args.Length; i++)
            {
                if (EndOfArgs(args, i))
                {
                    AddRangeArg(args, sb, i, startRange);
                    lastArg = true;
                    break;
                }
                else if (SameArg(args, i))
                {
                    AddRangeArg(args, sb, i, startRange);
                    sb.Append(",");
                    i++;
                    break;
                }
                else if (NoRange(args, i))
                {
                    AddRangeArg(args, sb, i, startRange);
                    sb.Append(",");
                    break;
                }
            }
        }

        private static bool SameArg(int[] args, int i)
        {
            return args[i] == args[i+1];
        }

        private static bool EndOfArgs(int[] args, int i)
        {
            return args.Length == i+1;
        }

        private static bool IsRange(int[] args, int i)
        {
            return args.Length != i+2 && args[i+1] == args[i+2]-1;
        }

        private static bool NoRange(int[] args, int i)
        {
            return args[i] != args[i+1]-1;
        }

        private static void AddRangeArg(int[] args, StringBuilder sb, int i, int startRange)
        {
            sb.Append(startRange);
            sb.Append("-");
            sb.Append(args[i]);
        }

        private static void AddArg(int[] args, StringBuilder sb, int i)
        {
            sb.Append(args[i]);
            sb.Append(",");
        }
    }
}
