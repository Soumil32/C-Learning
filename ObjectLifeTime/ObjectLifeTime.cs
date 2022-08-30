namespace ObjectLifeTime
{
    class MainClass
    {
        // ReSharper disable once ArrangeTypeMemberModifiers
        static void Main(string[] args)
        {
            Car myCar = new();
        }
    }

    class Car
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int? Year { get; set; }
        public string? Colour { get; set; }
    }
}
