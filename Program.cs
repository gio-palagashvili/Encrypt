using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Methods = new Methods();
            string msg = Methods.Encrypt("secreet message");
            Methods.Decrypt("418v100t75y432x45i15c20a 65e115w228l38b20t4");
            Console.ReadKey();
        }
    }
}
