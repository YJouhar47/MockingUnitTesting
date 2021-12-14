using System;

namespace YoussefJouharMockingV2._0
{
    public class Program
    {
        static void Main(string[] args)
        {
            AskIpAddress askIpAddress = new AskIpAddress();
            askIpAddress.askIPAsync();
            Console.ReadLine();
        }
    }
}
