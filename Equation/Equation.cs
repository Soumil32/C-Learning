namespace Equations
{
    class Equations
    {
        static void Main(string[] args)
        {
            //x + 3x = 56
            // x + 3x = x + 45
            decimal x = int.MinValue;

            while (x != 0)
            {
                x += 0.1M;
            }

            Console.WriteLine(x);
            // ReSharper disable once StringLiteralTypo
            File.WriteAllText(@"C:\Users\soumi\Documents\GitHub\C-Learning\Equation\Answer.txt", x.ToString());
        }
    }
}
