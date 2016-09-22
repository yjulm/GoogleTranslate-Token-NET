using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoogleTranslateToken;

namespace GoogleTranslate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new Token().Xi(408495, "+-3^+b+-f"));
            //Console.WriteLine(new TKK().GetTKK());  //408495.273569019

            Console.WriteLine(new Token().GetToken("time", new TKK().GetTKK()));
            Console.ReadLine();
        }
    }
}
