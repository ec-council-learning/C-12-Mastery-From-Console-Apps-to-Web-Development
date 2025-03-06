// See https://aka.ms/new-console-template for more information
using System;

namespace MyTaskManager;

class Program
{
    internal static List<Task> taskList = new List<Task>();

    static void Main(string[] args)
    {
        

        // Initial sample task
        taskList.Add(new Task(1, "C# 12 project", DateTime.Now.AddDays(3)));

        DisplayMenu();

        while (true)
        {
            Console.Write("Enter Your Choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ReadTasks();
                    break;
                case "3":
                    MarkAsCompleted();
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        void AddTask()
        {
            int taskId = taskList.Count + 1; //Auto increment Id
            Console.Write("Enter task description: ");
            string description = Console.ReadLine();
            Console.Write("Enter due date (YYYY-MM-DD): ");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());
            taskList.Add(new Task(taskId, description, dueDate));
            Console.WriteLine("Task Added!");
        }

        void ReadTasks()
        {
            if (taskList.Count == 0)
            {
                Console.WriteLine("No tasks found.");
                return;
            }

            Console.WriteLine("***Task List***");
            Console.WriteLine("| Task ID | Description | Due Date | Completed |");
            Console.WriteLine("---------|-------------|----------|-----------|");

            foreach (Task task in taskList)
            {
                string status = task.IsCompleted ? "Yes" : "No";
                Console.WriteLine($"|{task.TaskId}|{task.Description}|{task.Duedate.Year}|{task.Duedate:MM}|{task.Duedate:dd}|{status}|");
            }

            Console.Write("Enter sorting criteria(id, description, due date, completed): ");
            string sortBy = Console.ReadLine();

            SortTask(sortBy);
        }

        void SortTask(string sortBy)
            {
            switch (sortBy.ToLower()) 
            {
                case "id":
                    taskList.Sort((t1,t2) => t1.TaskId.CompareTo(t2.TaskId)); 
                    break;
                case "description":
                    taskList.Sort((t1, t2) => t1.Description.CompareTo(t2.Description));
                    break;
                case "due date":
                    taskList.Sort((t1, t2) => t1.Duedate.CompareTo(t2.Duedate));
                    break;
                case "completed":
                    taskList.Sort((t1, t2) => t1.IsCompleted.CompareTo(t2.IsCompleted));
                    break;
            }
            // Display the sorted task list directly within the function
            if (taskList.Count == 0)
            {
                Console.WriteLine("No tasks found.");
                return;
            }

            Console.WriteLine("***Sorted Task List***");
            Console.WriteLine("| Task ID | Description | Due Date | Completed |");
            Console.WriteLine("---------|-------------|----------|-----------|");

            foreach (Task task in taskList)
            {
                string status = task.IsCompleted ? "Yes" : "No";
                Console.WriteLine($"|{task.TaskId}|{task.Description}|{task.Duedate.Year}|{task.Duedate:MM}|{task.Duedate:dd}|{status}|");
            }

        }

        void MarkAsCompleted()
        {
            // Get the task ID from the user
            Console.Write("Enter task Id: ");
            // Handle potential parsing errors
            int taskId = Convert.ToInt32(Console.ReadLine());

            // Find the task in the list
            Task taskToMark = taskList.Find(task => task.TaskId == taskId);

            // Check if task exists
            if (taskToMark == null)
            {
                Console.WriteLine("task doesn't exist!");
                return;
            }

            taskToMark.IsCompleted = true;
            Console.WriteLine($"The task {taskId} has been completed!");
        }



        static void DisplayMenu()
        {
            Console.WriteLine("***My Task Manager***");
            Console.WriteLine("1. Add Task.");
            Console.WriteLine("2. Read tasks.");
            Console.WriteLine("3. Mark task as Completed.");
            Console.WriteLine("4. Exit.");
        }
    }
}
