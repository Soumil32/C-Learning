namespace Classes
{
	class Class
	{
		static void Main(string[] args)
		{
			Car myCar = new Car();
			myCar.brand = "Nissan";

			Console.WriteLine(myCar);
		}
	}

	class Car
	{
		public string brand { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string Year { get; set; }
		public string Colour { get; set; }
	}
}