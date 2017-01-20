using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lines
{
    class Program
    {
        static void Main(string[] args)
        {
            Lines line = new Lines(1, 2, 2, 3);

            Console.WriteLine("=====Линия======");
            Console.WriteLine(line);
            Console.WriteLine();


            Lines newLine = line.GetCopy();
            Console.WriteLine(line);
            Console.WriteLine(newLine);

            Console.WriteLine("Длина отрезка на линии: {0}", line.Length());
            Console.WriteLine();


            Point p1 = new Point();
            Point p2 = new Point(-2, 3);
            Lines line2 = new Lines(p1, p2);
            Console.WriteLine(line2);

            Console.WriteLine();
            Console.WriteLine("Точка на прямой {0}", line[5]); 
            Console.ReadKey();
        }
    }
}
