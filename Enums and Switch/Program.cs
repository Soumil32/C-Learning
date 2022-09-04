using MoreTypeExtensions;

namespace EnumsAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>()
            {
                new Todo("Task 1", "Clean my room",6, Status.OnHold),
                new Todo("Task 2", 2, Status.InProgress),
                new Todo("Task 3", 8, Status.NotStarted),
                new Todo("Task 4", 12, Status.Deleted),
                new Todo("Task 5", 6, Status.InProgress ),
                new Todo("Task 6", 2, Status.NotStarted ), 
                new Todo("Task 7", 8, Status.Completed),
                new Todo { Description = "Task 8", EstimatedHours = 8, Status = Status. InProgress },
                new Todo { Description = "Task 9", EstimatedHours = 8, Status = Status.Completed},
                new Todo { Description = "Task 10", EstimatedHours = 4, Status = Status.NotStarted},
                new Todo { Description = "Task 11", EstimatedHours = 10, Status = Status.Completed}, 
                new Todo { Description = "Task 12", EstimatedHours = 12, Status = Status.Deleted}, 
                new Todo { Description = "Task 13", EstimatedHours = 6, Status = Status.Completed},
            };

            string userInput = Console.ReadLine();
            if (userInput.IgnoreCaseContains("status"))
                PrintAssessment(todos);
            else if (userInput.IgnoreCaseContains("list names"))
            {
                foreach (Todo todo in todos)
                {
                    Console.WriteLine(todo.Name);
                }
            }
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
                        Console.WriteLine("You should get started on {0} soon", todo.Name);
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Make sure to finish {todo.Name}!");
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Remember to get back to {todo.Name}");
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Congrats for completing {todo.Name}");
                        break;
                    case  Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine($"You have removed {todo.Name}");
                        break;
                }
                Console.ResetColor();
            }
        }
    }

    class Todo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }

        public Todo() {}
        
        public Todo(string name, int estimatedHours, Status status)
        {
            Name = name;
            EstimatedHours = estimatedHours;
            Status = status;
        }
        
        public Todo(string name, string description,int estimatedHours, Status status)
        {
            Name = name;
            Description = description;
            EstimatedHours = estimatedHours;
            Status = status;
        }
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

