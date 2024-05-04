namespace PracticsModule9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberReader numberReader = new NumberReader();
            numberReader.NumberReaderEvent += SortPerson.Sorted;

            List<Person> Persons = new List<Person>
            {
                new Person("Ivan", "Ivanov"),
                new Person("Bogdan", "Bogdanov"),
                new Person("Nikita", "Nikitin"),
                new Person("Sergey", "Sergeev"),
                new Person("Alexandr", "Alexsandrow")
            };

            foreach (Person p in Persons)
            {
                Console.WriteLine(p.Surname);
            }

            while (true)
            {
                try
                {
                    var newPersons = numberReader.Read(Persons);
                    foreach (Person p in newPersons)
                    {
                        Console.WriteLine(p.Surname);
                    }
                }
                catch (IncorrectValueException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }





        }
    }
}
