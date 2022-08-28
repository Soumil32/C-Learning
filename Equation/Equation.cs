namespace Equations
{
    class Equations
    {
        static void Main(string[] args)
        {
            //x + 3x = 56
            // x + 3x = x + 45
            int x = int.MinValue;

            while (x + (x * 3)!= x + 45)
            {
                x ++;
                
            }

            Console.WriteLine(x);
            File.WriteAllText(@"C:\Users\soumi\Documents\GitHub\C-Learning\Equation\Answer.txt", x.ToString());
        }
    }
}
