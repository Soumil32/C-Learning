namespace Methods
{
	class Methods
	{

		/* 
		This is a simple method that writes 'Hello World' to the console.
		With methods you can write code once and use it again easily.
		The word 'private' means that you can only use it in this class.
		(Create a note for what static means later)
		The word void means it just executes the code inside it and doesn't return anything.
		Next you give the method a name which is followed by a pair of paranthensis.
		Lastly, you write your code between a pair of curly brackets.
		*/
		private static void HelloWorld()
		{
			Console.WriteLine("Hello World");
		}

        static void Main(string[] args)
        {
			// To call a function you just type its name followed by a pair of parathensis
			HelloWorld();
        }
    }
}
