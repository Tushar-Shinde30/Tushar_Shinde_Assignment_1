using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    class Program
    {
        static List<Task> tasks = new List<Task>();

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Task List Application");
                Console.WriteLine("1. Create a task");
                Console.WriteLine("2. Read tasks");
                Console.WriteLine("3. Update a task");
                Console.WriteLine("4. Delete a task");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateTask();
                        break;
                    case 2:
                        ReadTasks();
                        break;
                    case 3:
                        UpdateTask();
                        break;
                    case 4:
                        DeleteTask();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void CreateTask()
        {
            Task task = new Task();
            Console.Write("Enter task title: ");
            task.Title = Console.ReadLine();
            Console.Write("Enter task description: ");
            task.Description = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Task created successfully.");
        }

        static void ReadTasks()
        {
            Console.WriteLine("Task List:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i].Title} - {tasks[i].Description}");
            }
        }

        static void UpdateTask()
        {
            ReadTasks();
            Console.Write("Enter the index of the task to update: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index >= 0 && index < tasks.Count)
            {
                Console.Write("Enter updated title (leave blank to keep current): ");
                string updatedTitle = Console.ReadLine();
                if (!string.IsNullOrEmpty(updatedTitle))
                {
                    tasks[index].Title = updatedTitle;
                }
                Console.Write("Enter updated description (leave blank to keep current): ");
                string updatedDescription = Console.ReadLine();
                if (!string.IsNullOrEmpty(updatedDescription))
                {
                    tasks[index].Description = updatedDescription;
                }
                Console.WriteLine("Task updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        static void DeleteTask()
        {
            ReadTasks();
            Console.Write("Enter the index of the task to delete: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
                Console.WriteLine("Task deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }
    }
}
