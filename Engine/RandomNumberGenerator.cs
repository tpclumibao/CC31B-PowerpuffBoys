using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // This is the more complex version
    public static class RandomNumberGenerator
    {
        // Simple version, with less randomness.
        //
        // If you want to use this version, 
        // you can delete (or comment out) the NumberBetween function above,
        // and rename this from SimpleNumberBetween to NumberBetween
        private static readonly Random _simpleGenerator = new Random();
        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            return _simpleGenerator.Next(minimumValue, maximumValue + 1);
        }
    }
}
