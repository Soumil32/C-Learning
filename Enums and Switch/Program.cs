namespace EnumsAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>()
            {
                new Todo { Description = "Task 1", EstimatedHours = 6, Status = Status.OnHold },
                new Todo { Description = "Task 2", EstimatedHours = 2, Status = Status.InProgress },
                new Todo { Description = "Task 3", EstimatedHours = 8, Status = Status.NotStarted },
                new Todo { Description = "Task 4", EstimatedHours = 12, Status = Status.Deleted },
                new Todo { Description = "Task 5", EstimatedHours = 6, Status = Status.InProgress },
                new Todo { Description = "Task 6", EstimatedHours = 2,Status = Status.NotStarted }, 
                new Todo { Description = "Task 7", EstimatedHours = 8, Status = Status.Completed },
                new Todo { Description = "Task 8", EstimatedHours = 8, Status = Status. InProgress },
                new Todo { Description = "Task 9", EstimatedHours = 8, Status = Status.Completed},
                new Todo { Description = "Task 10", EstimatedHours = 4, Status = Status.NotStarted},
                new Todo { Description = "Task 11", EstimatedHours = 10, Status = Status.Completed}, 
                new Todo { Description = "Task 12", EstimatedHours = 12, Status = Status.Deleted}, 
                new Todo { Description = "Task 13", EstimatedHours = 6, Status = Status.Completed},
            };
            
            PrintAssessment(todos);
            Console.ReadLine();
        }

        private static void PrintAssessment(List<Todo> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("You should get started on {0} soon", todo.Description);
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Make sure to finish {todo.Description}!");
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Remember to get back to {todo.Description}");
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Congrats for completing {todo.Description}");
                        break;
                    case  Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine($"You have removed {todo.Description}");
                        break;
                }
                Console.ResetColor();
            }
        }
    }

    class Todo
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }
    }

    enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }
}

