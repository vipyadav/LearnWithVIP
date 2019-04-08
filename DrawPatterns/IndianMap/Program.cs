using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianMap
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawIndianMap();
        }

        private static void DrawIndianMap()
        {
            int s = 10, i = 0, c = 10;
            // The encoded string after removing first 31 characters 
            // Its individual characters determine how many spaces 
            // or exclamation marks to draw consecutively. 
            const string str = "TFy!QJu ROo TNn(ROo)SLq SLq ULo+UHs UJq " +
                               "TNn*RPn/QPbEWS_JSWQAIJO^NBELPeHBFHT}TnALVlBL" +
                               "OFAkHFOuFETpHCStHAUFAgcEAelclcn^r^r\\tZvYxXyT|S~Pn SPm " +
                               "SOn TNn ULo0ULo#ULo-WHq!WFs XDt!";

            while (s != 0 && i < str.Length)
            {
                // read each character of encoded string 
                s = str[i++];
                while (s-- > 64)
                {
                    if (++c == 90) // 'Z' is 90 in ascii 
                    {
                        Console.Write(Environment.NewLine);
                    }
                    else
                    {
                        // draw the appropriate character depending on whether i is even or odd 
                        Console.Write(i % 2 == 0 ? "!" : " ");
                    }
                }
            }
        }
    }
}
