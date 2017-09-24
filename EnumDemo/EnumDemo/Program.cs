using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumDemo
{
    class EnumDemo
    {
        enum IIMCA
        {GODWIN,ALEX,JEYA,PRASANNA}
        public static void Main(string[] args)
        {
            string name1=Convert.ToString( IIMCA.ALEX);
            string name2=Convert.ToString(IIMCA.GODWIN);
            Console.WriteLine(name1);
            Console.WriteLine(name2);
            Console.ReadLine();
        }
    }
}
