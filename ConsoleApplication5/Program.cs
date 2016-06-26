using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = "input.txt";
            String uri = "https://github.com/fsoul/csharp/blob/master/input.txt";
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(uri);
            
            try
            {
                using (StreamReader sr = new StreamReader(stream))
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
                        Console.WriteLine(i);
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
