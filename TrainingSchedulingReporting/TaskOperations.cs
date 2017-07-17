using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSchedulingReporting
{
    public class TaskOperations
    {
        public Dictionary<int, Task> registeredTasks = new Dictionary<int, Task>();
        public int latestTaskID = 0;
        
        public void RegisterTask(string taskInfo,DateTime taskDate,int duration)
        {
            Task newTask = new Task(taskInfo, taskDate.Date, duration);
            registeredTasks.Add(++latestTaskID, newTask);
        }

        public void viewTasks()
        {
            if (registeredTasks.Count == 0)
                Console.WriteLine("No Tasks found");
            else
            {
                Console.WriteLine("TaskID\tTask Info\tTask Date\tTask Duration\tTask Status");
                Console.WriteLine("-------------------------------------------------------------------------------");
                foreach (KeyValuePair<int, Task> pair in registeredTasks)
                {
                    Task pointedTask = pair.Value;
                    Console.WriteLine(pair.Key + "\t" + pointedTask.taskInfo + "\t" + pointedTask.taskDate.Date + "\t" + pointedTask.taskDuration + "\t" + pointedTask.status);
                }

            }
        }


        public void modifyTask()
        {
            int taskID;
            viewTasks();
            Console.WriteLine("Enter the task ID for the task you want to modify");
            if(Int32.TryParse(Console.ReadLine(),out taskID))
            {
                Task taskToBeModified;
                if (registeredTasks.TryGetValue(taskID, out taskToBeModified))
                {
                    int choice;
                    bool brk = true;
                    while (brk)
                    {
                        Console.WriteLine("(1)Modify Info\n(2)Modify Date\n(3)Modify Duration\n(4)Modify Status\n(5)Modify Trainer\n(6)Cancel\n");
                        if (Int32.TryParse(Console.ReadLine(), out choice))
                        {
                            switch(choice)
                            {
                                case 1:
                                    Console.WriteLine("Enter new info");
                                    taskToBeModified.taskInfo = Console.ReadLine();
                                    brk = false;
                                    break;
                                case 2:
                                    Console.WriteLine("Enter new date");
                                    DateTime newDate;
                                    if(DateTime.TryParse(Console.ReadLine(),out newDate))
                                    {
                                        taskToBeModified.taskDate = newDate;
                                        brk = false;
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Enter new duration");
                                    int newDuration;
                                    if(Int32.TryParse(Console.ReadLine(),out newDuration))
                                    {
                                        taskToBeModified.taskDuration = newDuration;
                                        brk = false;
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Enter new status code");
                                    int newStatusCode;
                                    if (Int32.TryParse(Console.ReadLine(), out newStatusCode))
                                    {
                                        taskToBeModified.statusCode = newStatusCode;
                                        brk = false;
                                    }
                                    break;
                                case 5:
                                    Console.Write("Enter the name of new trainer");
                                    taskToBeModified.trainer.name = Console.ReadLine();
                                    brk = false;
                                    break;
                                case 6:
                                    brk = false;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    registeredTasks.Remove(taskID);
                    registeredTasks.Add(taskID, taskToBeModified);
                }
                else Console.WriteLine("Entered Task ID does not exist");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
