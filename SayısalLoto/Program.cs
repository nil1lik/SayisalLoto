using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SayısalLoto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("How many columns? ");
                    int columnCount = Convert.ToInt32(Console.ReadLine());

                    if (columnCount <= 8 && columnCount > 0)
                    {
                        Random rndNum = new Random();
                        int[] rndArray = new int[6];
                        for (int i = 1; i < columnCount+1; i++)
                        {
                            Console.Write("{0}. Column: ",i);
                            for (int j = 0; j < rndArray.Length; j++)
                            {
                                rndArray[j] = rndNum.Next(1, 50);
                                Console.Write(rndArray[j]);

                                if (j < rndArray.Length - 1) // Son elemandan sonra tekrar virgül eklememek için bir kontrol yapıyoruz.
                                {
                                    Console.Write(",");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
                    else if (columnCount > 8 || columnCount <= 0)
                    {
                        Console.WriteLine("Please enter a value greater than 0 and less than 6.");
                    }
                }
                catch(System.FormatException)
                {
                    Console.WriteLine("Please enter a numeric value.");
                }
            }
            Console.ReadLine();
        }
    }
}
