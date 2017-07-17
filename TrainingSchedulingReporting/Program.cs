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
                Console.WriteLine("Enter\n(1)Admin\n(2)Trainer\n(3)Trainee\n");
                if (Int32.TryParse(Console.ReadLine(), out int outerchoice))
                { 
                    switch(outerchoice)
                    {
                        case 1:
                            
                            {
                                Admin Administrator = new Admin("Pankaj Kawale", "pankaj", "kawale");
                                Console.WriteLine("Enter Username");
                                string Username = Console.ReadLine();
                                Console.WriteLine("Enter Password");
                                string Password = Console.ReadLine();
                                if (Administrator.IsAuthorized(Username, Password))
                                {
                                    Console.WriteLine("Welcome " + Administrator.Name);
                                    bool brkd = true;
                                    while (brkd)
                                    {
                                        Console.WriteLine("Enter your choice");
                                        Console.WriteLine("(1)Task Handling operations\n(2)Schedulling\n(3)Reporting\n(4)Exit");
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
                                                                        Console.WriteLine("Enter the task information");
                                                                        string taskInfo = Console.ReadLine();
                                                                        DateTime taskDate;
                                                                        Console.WriteLine("Enter the schedulled date");
                                                                        if (DateTime.TryParse(Console.ReadLine(), out taskDate))
                                                                        {
                                                                            int duration;
                                                                            Console.WriteLine("Enter the task duration");
                                                                            if (Int32.TryParse(Console.ReadLine(), out duration))
                                                                            {
                                                                                tOperations.RegisterTask(taskInfo, taskDate.Date, duration);
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Invalid input");
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("Invalid input");
                                                                        }
                                                                        break;
                                                                    case 2:
                                                                        tOperations.ViewTasks();
                                                                        break;
                                                                    case 3:
                                                                        tOperations.ModifyTask();
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
                                                        brkd = false;
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
                                else Console.WriteLine("Wrong Username or password");
                            }
                            break;
                        case 2:
                            {
                                Trainer TaskTrainer = new Trainer("Tushar Maini", "tushar", "maini");
                                Console.WriteLine("Enter Username");
                                string Username = Console.ReadLine();
                                Console.WriteLine("Enter Password");
                                string Password = Console.ReadLine();
                                if (TaskTrainer.IsAuthorized(Username, Password))
                                {
                                    Console.WriteLine("Welcome " + TaskTrainer.Name);
                                }
                                else Console.WriteLine("Wrong Username or password");
                            }
                            break;
                        case 3:
                            {
                                Trainee Student = new Trainee("Divas Agarwal", "divas", "agarwal");
                                Console.WriteLine("Enter Username");
                                string Username = Console.ReadLine();
                                Console.WriteLine("Enter Password");
                                string Password = Console.ReadLine();
                                if (Student.IsAuthorized(Username, Password))
                                {
                                    Console.WriteLine("Welcome " + Student.Name);
                                }
                                else Console.WriteLine("Wrong Username or password");
                            }
                            break;
                        default:
                            break;
                    }
                    Console.ReadKey();
                }
                else Console.WriteLine("Select a valid choice");
            }
        }
        
        
    }
}
