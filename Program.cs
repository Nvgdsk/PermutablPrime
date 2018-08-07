using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckPrime check = new CheckPrime();
            int numb;
            while (true)
            {
                
                Console.WriteLine("Input number: ");
                numb = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(check.Finalcheck(check.CheckNumb(numb),numb));
            }
        }
    }
}
