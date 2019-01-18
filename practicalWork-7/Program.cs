using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalWork_7
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask firstObject = new FirstTask(10,10);
            FirstTask secondObject = new FirstTask(11,10);

            if(firstObject == secondObject)
            {
                Console.WriteLine("Массы объектов равны");
            }

            if (firstObject != secondObject)
            {
                Console.WriteLine("Массы объектов не равны");
            }

            Console.ReadLine();

            SecondTask array = new SecondTask();

            if (array > 10)
            {
                Console.WriteLine("Cумма больше чем 10");
            }

            if (array < 10)
            {
                Console.WriteLine("Cумма меньше чем 10");
            }

            Console.ReadLine();
        }
    }
}
