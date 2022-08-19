class PersonalInformation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your name");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter your age");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("What is your email address?");
        string email = Console.ReadLine();
        Console.WriteLine("What is your phone number?");
        string phone = Console.ReadLine();
        Console.WriteLine("Hello " + name + " you are " + age + " years old");
        Console.WriteLine("Your email address is " + email);
        Console.WriteLine("Your phone number is " + phone);
    }
}
