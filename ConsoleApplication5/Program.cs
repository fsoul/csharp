using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "input.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line = sr.ReadToEnd();
                    char[] str = line.ToCharArray();
                    int max = 0;
                    int c = 0;
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == '1')
                        {
                            c++;
                        }
                        else
                        {
                            c = 0;
                        }
                        if (c > max)
                        {
                            max = c;
                        }
                    }
                    Console.WriteLine(max);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }
    }
}
