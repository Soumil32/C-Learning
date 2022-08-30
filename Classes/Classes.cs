namespace Classes
{
	class Class
	{
		// ReSharper disable once UnusedParameter.Local
		static void Main(string[] args)
		{
			Car myCar = new Car();
			myCar.Make = "Toyota";
			myCar.Model = "Prius";
			myCar.Year = 2018;
			myCar.Colour = "Red";

			Console.WriteLine("{0} {1} {2} {3}", myCar.Make,myCar.Model, myCar.Year, myCar.Colour);
			Console.WriteLine("{0:C}", myCar.DetermineCarValue());
		}
	}

	class Car
	{
		public string? Make { get; set; }
		public string? Model { get; set; }
		public int? Year { get; set; }
		public string? Colour { get; set; }

		public decimal DetermineCarValue()
		{
			decimal carValue = 0;

			if (Year > 2005)
				carValue += 800;
			else
				carValue += 200;

			return carValue;
		}
	}
}