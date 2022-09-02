namespace ObjectLifeTime
{
    internal static class MainClass
    {
        // ReSharper disable once ArrangeTypeMemberModifiers
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            // ReSharper disable once StringLiteralTypo
            Car myCar = new Car("Toyota", "Camery", 2019, "Black");

            Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year} {myCar.Colour}");
        }
    }

    class Car
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int? Year { get; set; }
        public string? Colour { get; set; }

        public Car(string make, string model, int year, string colour)
        {
            Make = make;
            Model = model;
            Year = year;
            Colour = colour;
        }
    }
}
