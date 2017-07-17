using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSchedulingReporting
{
    public class Task
    {
        public string TaskInfo;
        public DateTime TaskDate;
        public int TaskDuration;
        public string Status;
        public int StatusCode;
        public Trainer TrainerAssigned;

        public Task(string Info,DateTime ScheduledDate,int Duration,Trainer TrainerAssigned)
        {
            TaskInfo = Info;
            TaskDate = ScheduledDate;
            TaskDuration = Duration;
            StatusCode = 0;
            this.TrainerAssigned=TrainerAssigned;
            SetStatus();
        }

        public Task(string info, DateTime scheduledDate, int duration)
        {
            TaskInfo = info;
            TaskDate = scheduledDate;
            TaskDuration = duration;
            StatusCode = 0;
            SetStatus();
        }

        public void SetStatus()
        {
            if (StatusCode == 0)
                Status = "Not completed";
            else if (StatusCode == 1)
                Status = "Completed";
        }
    }
}
