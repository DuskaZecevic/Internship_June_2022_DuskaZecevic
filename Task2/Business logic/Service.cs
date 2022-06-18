using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Business_logic
{
    public class Service
    {
        public static int howManyWords(string str)
        {
            int count = 1;
            foreach (char c in str)
                if (char.IsUpper(c))
                    count++;
            return count;
        }
    }
}
