using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTaskManager
{
    public class Task
    {
        public int TaskId;
        public string Description;
        public DateTime Duedate;
        public bool IsCompleted;

        //Add constructor to simplify task creation
        public Task(int taskId, string description, DateTime dueDate)
        {
            TaskId = taskId;
            Description = description;
            Duedate = dueDate;
            IsCompleted = false; // Tasks start but not completed
        }
    }
}
