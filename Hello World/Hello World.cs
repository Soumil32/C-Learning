using System;
using System.IO;
using System.Net;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HttpClient webClient = new HttpClient();
            var googleDownloaded = webClient.GetStringAsync(@"https://www.google.co.uk/");
            Console.WriteLine(googleDownloaded);
            File.AppendAllText("site code.html", googleDownloaded.ToString());
            
            Console.ReadLine();
        }


    }
}