using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2_Reversing_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = {10,20,30,40,50,60,70,80,90,100};
            int[] reversed = new int[number.Length];
            for (int i = 0; i < number.Length; i++) 
            {
                 reversed[number.Length -1 -i]= number[i];
            }
            Console.WriteLine("Reversed Number");
            foreach (int item in reversed)
            {
                Console.Write($" {item} ");
            }
        }
    }
}
