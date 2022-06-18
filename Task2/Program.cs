using System;
using System.Collections;
using System.Linq;
using System.Text;
using Task2.Business_logic;

namespace Task2
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            string str = "oneTwoThree";
            Console.WriteLine("The concatenation is: " + str);
            Console.WriteLine("In this concatenation we have " + Service.howManyWords(str) + " words.");
        }
    }
}
