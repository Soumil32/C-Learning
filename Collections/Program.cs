using System.Collections;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Collections
{
    class Program
    {
        static void Main()
        {
            
            Car car1 = new Car();
            car1.Make = "OldsMobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A24";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "B21";

            Book book1 = new Book();
            book1.Author = "Robert Tabor";
            book1.Title = "Microsoft .Net";
            book1.ISBN = "0-000-00000-0";

            /*
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(book1);

            foreach (var variable in myArrayList)
            {
                Console.WriteLine(variable);
            }
            */

            // List<data type>
            /*
            List<Car> cars = new List<Car>();
            cars.Add(car1);
            cars.Add(car2);

            foreach (Car car in cars)
            {
                Console.WriteLine(car.Model);
            }
            */
            
            // Dictionary<Tkey, Tvalue>
            
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);
            Console.WriteLine(myDictionary[car1.VIN].Make);

            Console.ReadLine();
            
        }

    /*[RankColumn]
    [MemoryDiagnoser()]
    public class Benchmark
    {
        static void Main()
        {
            var summary = BenchmarkRunner.Run<Benchmark>();
        }
        
        [Benchmark]
        public ArrayList ArrayList()
        {
            Car car1 = new Car();
            car1.Make = "OldsMobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A24";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "B21";
            
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            return myArrayList;
        }
        
        [Benchmark]
        public List<Car> List()
        {
            Car car1 = new Car();
            car1.Make = "OldsMobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A24";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "B21";
            
            List<Car> cars = new List<Car>();
            cars.Add(car1);
            cars.Add(car2);
            return cars;
        }
        
        [Benchmark]
        public Dictionary<string, Car> Dictionary()
        {
            Car car1 = new Car();
            car1.Make = "OldsMobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A24";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "B21";
            
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);
            return myDictionary;
        }
        */
    }
    
    public class Car
    {
        // ReSharper disable once InconsistentNaming
        public string? VIN { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
    }

    class Book
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
    }
}


