using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz_28
{
    internal class Wait
    {
        public Wait(int valueToWaitFor, string message)
        {
            Console.WriteLine($"Создан объект ожидания для числа {valueToWaitFor}");
            Counter counter = new Counter();
            counter.Counted += delegate (int i) // обработчик события в виде анонимного метода
            {
                if (i == valueToWaitFor)
                {
                    Console.WriteLine(message);
                }
            };
            counter.Count();
        }
    }
}
