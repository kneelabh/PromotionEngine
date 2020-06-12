using PromotionEngine.Domain;
using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Enter SKU followed by space and count (e.g.: A 10); Press | once you are done.");
                List<string> rawList = new List<string>();

                while (true)
                {
                    var inpt = Console.ReadLine();
                    if (inpt == "|")
                        break;
                    rawList.Add(inpt);
                }
                InputParser ipr = new InputParser();
                var listSKUs = ipr.ParseList(rawList.ToArray());

                System.Console.WriteLine("----------------------------");
                Engine engine = new Engine();
                System.Console.WriteLine("Total Cost: " + engine.ParseCost(listSKUs));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
