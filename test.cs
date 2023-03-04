using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext dsdc = new DataClasses1DataContext();

            var lessonName = from std in dsdc.lessons
                             where std.gradeLesson == "5"
                             select std.nameLesson;

            foreach(string n in lessonName)
            {
                Console.WriteLine("{0}", n);
            }

            Console.ReadLine();
        }
    }
}
