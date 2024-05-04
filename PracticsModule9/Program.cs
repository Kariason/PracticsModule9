using Module9ArrayExceptions;

namespace PracticsModule9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] arrayExceptions = new Exception[]
            {
                new ArgumentException("Непустой аргумент, передаваемый в метод, является недопустимым."),
                new ArgumentNullException("Аргумент, передаваемый в метод — null."),
                new DriveNotFoundException("Диск недоступен или не существует."),
                new DivideByZeroException("Знаменатель в операции деления или целого числа Decimal равен нулю."),
                new MyException("Пользовательское исключение")
            };

            foreach (Exception exception in arrayExceptions)
            {
                try
                {
                    throw exception;
                }
                catch(Exception ex) 
                {
                    Console.WriteLine(ex.Message); 
                }

            }
        }
    }
}
