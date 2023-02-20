using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ReadData
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] lines = File.ReadAllLines(@"C:\Users\NameUser\Documents\Input\emails.txt");

                int countLines = 0;
                
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\NameUser\Documents\Output\Result.txt"))
                {
                    foreach (var item in lines)
                    {
                        if (item.Contains("@company.com.br"))
                        {
                            System.Console.WriteLine(" ");
                            System.Console.WriteLine(" --- Are company --- ");
                            System.Console.WriteLine(item);

                            if (item != "")
                                file.WriteLine(item);
                        }
                        else if (!item.Contains("@company.com.br"))
                        {
                            System.Console.WriteLine(" ");
                            System.Console.WriteLine(" --- Not Are company --- ");
                            System.Console.WriteLine(item);
                        }
                        countLines++;
                    }
                }
                Console.WriteLine("Count: {0}", countLines);
                Console.ReadLine();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("[File of data not found!] {0}", e);
                Console.ReadLine();
            }
            
        }
    }
}
