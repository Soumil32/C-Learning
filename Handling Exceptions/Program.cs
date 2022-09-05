using Humanizer;

namespace HandlingExceptions
{
    class Program
    {
        static void Main()
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\soumi\Documents\GitHub\C-Learning\.gitinore");
                Console.WriteLine(content);
                Console.ReadLine();
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("The directory specified could not be found. /nCheck if you entered the correct path.");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("The file specified could not be found. \nCheck if you entered the correct path to the file.");
            }
            catch (Exception e)
            {
                Console.WriteLine("An unknown error occurred. /n" + e.Message);
            }
        }
    }
}

