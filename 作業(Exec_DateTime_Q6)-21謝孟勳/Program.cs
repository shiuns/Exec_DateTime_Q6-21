using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作業_Exec_DateTime_Q6__21謝孟勳
{
    //根據日期, 傳回今天是本月的上旬, 中旬或下旬
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now= DateTime.Now;
            int day = now.Day;
            if (day >=1 && day< 11)
            {
                Console.WriteLine("上旬");
            }
            if (day >= 11 && day < 21)
            {
                Console.WriteLine("中旬");
            }
            else
            {
                Console.WriteLine("下旬");
            }
        }
    }
}
