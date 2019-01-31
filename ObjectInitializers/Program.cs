namespace ObjectInitializers
{
    class Program
    {
        // Object Initializer:  Allows us to intialize an object without the need to call one of its constructors.
        //  -- Allows us the ability to avoid creating multiple constructors which can become difficult to manage.
        static void Main(string[] args)
        {
            // An example of how Object Initialization can be used on the Person Class.  
            // Here during the initialization process we define the fields that we know
            // without the use of the class constructors.
            var person = new Person { FirstName = "Super", LastName = "Thing" };
        }
    }
}
