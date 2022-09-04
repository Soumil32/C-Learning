namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCars = new List<Car>()
            {
                new Car("A1", Brands.BMW, "550i", 2015, 55000),
                new Car("B2", Brands.Toyota, "4Runner", 2016, 35000),
                new Car("C3", Brands.BMW, "745li", 2015, 75000),
                new Car("D4", Brands.Ford, "Escape", 2016, 25000),
                new Car("E5", Brands.BMW, "55i", 2017, 57000)
            };
            //LINQ query
            var bmwCarsQuery = 
                from car in myCars where car.Brand == Brands.BMW && car.StickerPrice < 45000 select car;
            foreach (Car car in bmwCarsQuery)
            {
                Console.WriteLine($"Model: {car.Model} VIN: {car.VIN}");
            }

            var carsOrderedByYearOrderedEnumerable =
                from car in myCars orderby car.StickerPrice ascending select car;
            List<Car> carsOrderedByYear = carsOrderedByYearOrderedEnumerable.ToList();
            /*
            foreach (Car car in carsOrderedByYear)
            {
                Console.WriteLine($"{car.Brand} {car.Model}");
            }
            */
            //LINQ method
            var bmwCarsMethod = myCars.Where(p => p.Brand == Brands.BMW);
            Car mostExpensiveCar = myCars.OrderByDescending(p => p.StickerPrice).First();
            Console.WriteLine($"The most expensive car is {mostExpensiveCar.Brand} {mostExpensiveCar.Model} with a price of £{mostExpensiveCar.StickerPrice}");
            Car newestCar = myCars.OrderByDescending(p => p.Year).First();
            Console.WriteLine($"The newest car is {newestCar.Brand} {newestCar.Model} made in {newestCar.Year}");
            Car latestBMWCar = bmwCarsMethod.OrderByDescending(p => p.Year).First();
            Console.WriteLine($"The latest BMW car is {latestBMWCar.Brand} {latestBMWCar.Model} made in {latestBMWCar.Year}");
            Console.WriteLine(myCars.TrueForAll(p => p.Year >= 2015)
                ? "All cars are from 2015 or newer"
                : "Not all cars are from 2015 or newer");
            myCars.ForEach(p => Console.WriteLine(p.Brand + " " + p.Model));
            var totalStickerPrice = myCars.Sum(p => p.StickerPrice);
            Console.WriteLine("The total sticker price of all cars is {0:C0}", totalStickerPrice);

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public Brands Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }

        public Car(string vin, Brands brand, string model, int year, double stickerPrice)
        {
            VIN = vin;
            Brand = brand;
            Model = model;
            Year = year;
            StickerPrice = stickerPrice;
        }
    }

    // ReSharper disable once ArrangeTypeModifiers
    enum Brands
    {
        BMW,
        Toyota,
        Ford,
        Nissan
    }
}

