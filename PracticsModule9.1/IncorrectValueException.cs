using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticsModule9._1
{
    /// <summary>
    /// Пользовательское исключение
    /// </summary>
    public class IncorrectValueException : Exception
    {
        public IncorrectValueException(string message) : base(message) { }
    }
}
