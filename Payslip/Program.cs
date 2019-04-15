using System;
using System.Collections.Generic;
using System.IO;

namespace Payslip
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            string pathName = Path.GetDirectoryName(path);

            String[] st = File.ReadAllLines(pathName);
            Console.WriteLine(st);
            
        }
    }
}
