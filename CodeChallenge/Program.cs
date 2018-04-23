using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            PalChecker palcheck = new PalChecker();
            Console.WriteLine(palcheck.isPal("racecar"));
            Console.ReadLine();
        }
    }

    public class PalChecker
    {
        public bool isPal(string myString)
        {


            //string[] data = { "", "/", ",", ".", "!", "?" };
            //List<char> chars = new List<char>();
            //chars.AddRange(data.Select(d => d.ToString);

            List<string> chars = new List<string> { "", "/", ",", ".", "!", "?" };

            int min = 0;
            int max = myString.Length - 1;

            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = myString[min];
                char b = myString[max];


                // never going to equal char because is comparing against string 
                foreach (string str in chars)
                {
                    if (a.Equals(str))
                    {
                        Console.WriteLine("incrementing min");
                        min += 1;
                    }
                    else if (b.Equals(str))
                    {
                        Console.WriteLine("decrementing max");
                        max -= 1;
                    }
                    else if (char.ToLower(a) != char.ToLower(b))
                    {
                        return false;
                    }
                }

                min += 1;
                max -= 1;
            }
        }
    }
}
