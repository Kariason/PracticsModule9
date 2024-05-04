using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticsModule9._1
{
    public class NumberReader
    {
        public delegate IOrderedEnumerable<Person> NumberReaderDelegate(int number, List<Person> person);
        public event NumberReaderDelegate NumberReaderEvent;

        public IOrderedEnumerable<Person> Read(List<Person> person)
        {
            Console.WriteLine();
            Console.WriteLine("Для сортировки списка фамилий от А до Z введите 1");
            Console.WriteLine("Для сортировки списка фамилий от Z до A введите 2\n");

            int number = int.Parse(Console.ReadLine());

            if (number != 1 && number != 2)
                throw new IncorrectValueException("Введено неверное значение!");
            var result =NumberEntered(number, person);
            return result;
        }

        public virtual IOrderedEnumerable<Person> NumberEntered(int number, List<Person> person)
        {
            return NumberReaderEvent?.Invoke(number,person);
        }
    }
}
