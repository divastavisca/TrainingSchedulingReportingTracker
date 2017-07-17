using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSchedulingReporting
{
    class Task
    {
        string taskInfo;
        DateTime taskDate;
        int taskDuration;

        public Task(string info,DateTime scheduledDate,int duration)
        {
            taskInfo = info;
            taskDate = scheduledDate;
            taskDuration = duration;
        }
    }
}
