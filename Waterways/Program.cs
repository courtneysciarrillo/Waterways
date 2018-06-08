using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterways
{
    class Program
    {
        static void Main(string[] args)
        {
            River ohio = new River("Ohio", 35, 3);
            Console.WriteLine("Welcome to Waterways Management Console");
            Console.WriteLine("Please type Yes to manage the {0} river?", ohio.Name);
            string userResponse = Console.ReadLine().ToLower();
            while (userResponse.Equals("yes"))
            {
                Console.WriteLine("Please select from the following to manage the {0} river", ohio.Name);

                Console.WriteLine("Select 1 to get the status of the {0} river", ohio.Name);
                Console.WriteLine("Select 2 to change the depth of the {0} river", ohio.Name);
                Console.WriteLine("Select 3 to clean the {0} river", ohio.Name);
                int userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        ohio.GetStatus();
                        if (ohio.DepthAlert)
                        {
                            Console.WriteLine("The {0} river is {1} deep and needs to be drained.", ohio.Name, ohio.Depth);
                            Console.WriteLine("Please enter a new depth for the {0} river", ohio.Name);
                            int newDepth = int.Parse(Console.ReadLine());
                            ohio.SetDepth(newDepth);

                        }
                        if (ohio.PolAlert)
                        {
                            Console.WriteLine("The {0} river is above safe pollution standards and need to be cleaned.", ohio.Name);
                            Console.WriteLine("Please enter a new pollutution level for the {0} river", ohio.Name);
                            //int pollLevel = int.Parse(Console.ReadLine());
                            ohio.SetPol(int.Parse(Console.ReadLine()));

                        }
                        Console.WriteLine("The {0} river is {1} deep and has a pollution level of {2} ppm", ohio.Name, ohio.Depth, ohio.Pollution);

                        break;
                    case 2:
                        Console.WriteLine("Enter a new depth.");
                        int depth = int.Parse(Console.ReadLine());
                        ohio.SetDepth(depth);
                        Console.WriteLine("The new depth of the {0} river is {1}", ohio.Name, ohio.Depth);
                        break;
                    case 3:
                        Console.WriteLine("Enter a new pollution level.");
                        int pollution = int.Parse(Console.ReadLine());
                        ohio.SetPol(pollution);
                        Console.WriteLine("The new pollution level of the {0} river is {1}", ohio.Name, ohio.Pollution);
                        break;
                    default:
                        break;

                }
                Console.WriteLine("Please type Yes to manage the {0} river?", ohio.Name);
                userResponse = Console.ReadLine().ToLower();
            }



        }
    }
}
