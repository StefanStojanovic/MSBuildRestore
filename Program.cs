using ClassLibrary;
using Newtonsoft.Json;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = Class.MultiplyByE(5);
            string json = JsonConvert.SerializeObject(new { value });
            Console.WriteLine(json);
        }
    }
}