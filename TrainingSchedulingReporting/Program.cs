using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSchedulingReporting
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("(1)Tasks\n(2)Schedulling\n(3)Reporting\n(4)Exit");
                int choice;
                if (Int32.TryParse(Console.ReadLine(), out choice))
                {
                    switch(choice)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            Environment.Exit(1);
                            break;
                        default:
                            Console.WriteLine("Wrong choice");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong Choice pls enter an integer choice");
                    Console.ReadKey();
                }
            }
        }
    }
}
