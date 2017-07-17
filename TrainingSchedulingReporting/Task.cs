using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSchedulingReporting
{
    public class Task
    {
        public string taskInfo;
        public DateTime taskDate;
        public int taskDuration;
        public string status;
        public int statusCode;
        public Trainer trainer;

        public Task(string info,DateTime scheduledDate,int duration,Trainer trainer)
        {
            taskInfo = info;
            taskDate = scheduledDate;
            taskDuration = duration;
            statusCode = 0;
            this.trainer=trainer;
            setStatus();
        }

        public Task(string info, DateTime scheduledDate, int duration)
        {
            taskInfo = info;
            taskDate = scheduledDate;
            taskDuration = duration;
            statusCode = 0;
            setStatus();
        }

        public void setStatus()
        {
            if (statusCode == 0)
                status = "Not completed";
            else if (statusCode == 1)
                status = "Completed";
        }
    }
}
