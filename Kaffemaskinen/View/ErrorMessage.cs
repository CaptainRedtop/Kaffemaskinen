using System;

namespace Kaffemaskinen.View
{
    internal class ErrorMessage
    {
        public ErrorMessage(string error)
        {
            Console.Clear();
            Console.WriteLine(error);
            Console.WriteLine("\nPress anything to go back...");
            Console.ReadKey();
        }
    }
}
