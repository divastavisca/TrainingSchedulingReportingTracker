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
            TaskOperations tOperations = new TaskOperations(); //Supports different task operations
            {
                while (true)
                {
                    Console.WriteLine("Enter your choice");
                    Console.WriteLine("(1)Tasks\n(2)Schedulling\n(3)Reporting\n(4)Exit");
                    int choice, innerchoice;
                    bool brk;
                    if (Int32.TryParse(Console.ReadLine(), out choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                {
                                    brk = true;
                                    while (brk)
                                    {
                                        Console.WriteLine("(1)Register a new task\n(2)View tasks (Track)\n(3)Modify a task\n(4)Go back");
                                        if (Int32.TryParse(Console.ReadLine(), out innerchoice))
                                        {
                                            switch (innerchoice)
                                            {
                                                case 1:
                                                    tOperations.registerTask();
                                                    break;
                                                case 2:
                                                    tOperations.viewTasks();
                                                    break;
                                                case 3:
                                                    tOperations.modifyTask();
                                                    break;
                                                case 4:
                                                    brk = false;
                                                    break;
                                                default:
                                                    Console.WriteLine("Enter a valid choice\n");
                                                    break;
                                            }
                                        }
                                        else Console.WriteLine("Enter a valid choice\n");
                                    }
                                }
                                break;
                            case 2:
                                {

                                }
                                break;
                            case 3:
                                {

                                }
                                break;
                            case 4:
                                {
                                    Environment.Exit(1);
                                }
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
}
