using System;
using System.Collections.Generic;
using System.IO;

namespace Payslip
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Directory.GetCurrentDirectory();
            var pathName = Path.GetDirectoryName(path);

            var st = File.ReadAllLines(pathName);
            Console.WriteLine(st);
            
        }
    }
}
