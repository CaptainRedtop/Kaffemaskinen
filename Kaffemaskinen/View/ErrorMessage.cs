using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen.View
{
    internal class ErrorMessage
    {
        public ErrorMessage(string error)
        {
            Console.Clear();
            Console.WriteLine(error);
            Console.WriteLine("Press anything to go back...");
            Console.ReadKey();
        }
    }
}
