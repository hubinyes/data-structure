using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string str = Console.ReadLine();
            Console.WriteLine(p.MyAtoi(str));
        }

        char[] cs    = null;
        int len      = 0;
        int pnt      = 0;
        long result  = 0;
        int neg      = 1;

        public int MyAtoi(String str)
        {
            if (str == null || str.Length == 0)
                return 0;

            cs = str.ToCharArray();
            len = str.Length;
            pnt = 0;
            result = 0;

            ProcessSpace();

            if (!ProcessMinus())
                return 0;
            if (!ProcessNumber())
                return 0;

            int ret = GetResult();

            return ret;
        }
        private bool ProcessSpace()
        {
            while (pnt < len && cs[pnt] == ' ')
                pnt++;
            return true;
        }

        private bool ProcessMinus()
        {
            if (pnt >= len)
                return false;

            if (cs[pnt] == '-')
            {
                neg = -1;
                pnt++;
            }
            else if (cs[pnt] == '+')
            {
                neg = 1;
                pnt++;
            }

            return true;
        }

        private bool ProcessNumber()
        {
            if (pnt >= len)
                return false;
            
            if (cs[pnt] < '0' || cs[pnt] > '9') return false;

            while (pnt < len && (cs[pnt] >= '0' && cs[pnt] <= '9'))
            {
                int k = cs[pnt] - '0';
                result = result * 10 + k;
                long r = result * neg;
                if (r > Int32.MaxValue || r < Int32.MinValue)
                {
                    return true;
                }
                pnt++;
            }

            return true;
        }
        private int GetResult()
        {
            long r = result * neg;
            if (r > Int32.MaxValue)
                return Int32.MaxValue;
            if (r < Int32.MinValue)
                return Int32.MinValue;

            return (int)r;
        }

    }
}
