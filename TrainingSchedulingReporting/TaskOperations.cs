using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSchedulingReporting
{
    public class TaskOperations
    {
        public Dictionary<int, Task> RegisteredTasks = new Dictionary<int, Task>();
        public int LatestTaskID = 0;
        
        public void RegisterTask(string TaskInfo,DateTime TaskDate,int Duration)
        {
            Task NewTask = new Task(TaskInfo, TaskDate.Date, Duration);
            RegisteredTasks.Add(++LatestTaskID, NewTask);
        }

        public void ViewTasks()
        {
            if (RegisteredTasks.Count == 0)
                Console.WriteLine("No Tasks found");
            else
            {
                Console.WriteLine("TaskID\tTask Info\tTask Date\tTask Duration\tTask Status");
                Console.WriteLine("-------------------------------------------------------------------------------");
                foreach (KeyValuePair<int, Task> Pair in RegisteredTasks)
                {
                    Task PointedTask = Pair.Value;
                    Console.WriteLine(Pair.Key + "\t" + PointedTask.TaskInfo + "\t" + PointedTask.TaskDate.Date + "\t" + PointedTask.TaskDuration + "\t" + PointedTask.Status);
                }

            }
        }


        public void ModifyTask()
        {
            int taskID;
            ViewTasks();
            Console.WriteLine("Enter the task ID for the task you want to modify");
            if(Int32.TryParse(Console.ReadLine(),out taskID))
            {
                Task TaskToBeModified;
                if (RegisteredTasks.TryGetValue(taskID, out TaskToBeModified))
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
                                    TaskToBeModified.TaskInfo = Console.ReadLine();
                                    brk = false;
                                    break;
                                case 2:
                                    Console.WriteLine("Enter new date");
                                    DateTime newDate;
                                    if(DateTime.TryParse(Console.ReadLine(),out newDate))
                                    {
                                        TaskToBeModified.TaskDate = newDate;
                                        brk = false;
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Enter new duration");
                                    int newDuration;
                                    if(Int32.TryParse(Console.ReadLine(),out newDuration))
                                    {
                                        TaskToBeModified.TaskDuration = newDuration;
                                        brk = false;
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Enter new status code");
                                    int newStatusCode;
                                    if (Int32.TryParse(Console.ReadLine(), out newStatusCode))
                                    {
                                        TaskToBeModified.StatusCode = newStatusCode;
                                        brk = false;
                                    }
                                    break;
                                case 5:
                                    Console.Write("Enter the name of new trainer");
                                    TaskToBeModified.TrainerAssigned.Name = Console.ReadLine();
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
                    RegisteredTasks.Remove(taskID);
                    RegisteredTasks.Add(taskID, TaskToBeModified);
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
