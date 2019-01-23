using System;

namespace ObjectInitializers
{
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public DateTime BirthDate;
    }

    class Program
    {
        // Object Initializer:  Allows us to intialize an object without the need to call one of its constructors.
        //  -- Allows us the ability to avoid creating multiple constructors which can become difficult to manage.
        static void Main(string[] args)
        {
        }
    }
}
