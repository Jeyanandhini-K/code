using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a;
            int[] cars = { 10, 20, 60, 45, 748 };
           Console.Write("Enter the index number");

            a = int.Parse(Console.ReadLine());
            for (int i = 0; i <= cars.Length; i++)
           
            {

                Console.WriteLine(i);
                
            }
            

        }
    }
}
