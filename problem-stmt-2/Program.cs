using System;
using Business.Rule.Engine;
namespace MearskSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = default(int);
            Console.WriteLine("enter the choice");
            Console.WriteLine("1-Physical product");
            Console.WriteLine("2-Book");
            Console.WriteLine("3-Membership");
            Console.WriteLine("4-Upgrade to a membership");
            Console.WriteLine("5-Membership or upgrade");
            Console.WriteLine("6- Video -Learning to Ski");
            Console.WriteLine("7-Physical product or a book");

           
            var conversionesult = Int32.TryParse(Console.ReadLine(), out choice);
            if (conversionesult)
            {
                try
                {
                    RuleEngineFactory factory = new RuleEngineFactory();
                    factory.ExecuteRule(choice);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            else
            {
                Console.WriteLine("Please enter the choice in number format.");
            }
            Console.ReadLine();

        }
    }
}
