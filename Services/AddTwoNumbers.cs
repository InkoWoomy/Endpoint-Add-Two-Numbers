using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CombineMini2.Services
{
    public class AddTwoNumbers : IAddTwoNumbers
    {
        public string TwoNumbers(int num1, int num2)
        {
            return num1 + " + " + num2 + " = " + (num1 + num2) + ".";
        }
    }
}