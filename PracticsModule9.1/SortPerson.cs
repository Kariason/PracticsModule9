using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticsModule9._1
{
    /// <summary>
    /// Статический класс сортировки списка
    /// </summary>
    public static class SortPerson
    {
        public static IOrderedEnumerable<Person> Sorted(int number, List<Person> persons)
        {
            switch (number)
            {
                case 1:
                    var result = from p in persons orderby p.Surname select p;
                    return result;
                case 2:
                    result = from p in persons orderby p.Surname descending select p;
                    return result;
                default: return null;
            }
        }
    }
}
