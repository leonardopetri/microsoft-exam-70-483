using System;

namespace Ex23
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            // person.FirstName = string.Empty;
            person.FirstName = "Leo";

            Console.WriteLine($"Person: {person.FirstName}");
        }
    }

    class Person
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Firstname can't be empty");
                }

                _firstName = value;
            }
        }
    }
}
