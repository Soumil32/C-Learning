namespace ObjectLifeTime
{
    class MainClass
    {
        // ReSharper disable once ArrangeTypeMemberModifiers
        static void Main(string[] args)
        {
            Car myCar = new();
            myCar.Make = "Toyota";
            // ReSharper disable once StringLiteralTypo
            myCar.Model = "Camery";
            myCar.Year = 2019;
            myCar.Colour = "Black";
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
