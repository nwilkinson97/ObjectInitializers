using System;

namespace ObjectInitializers
{
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public DateTime BirthDate;

        // If we used Class Constructors it ma look like this below.  
        // Using basic statistics and understanding that we have x amount of combinations
        // of these constructors.  For this problem we would multiply 4 * 3 * 2 * 1 = 24
        // This tells me that to get all possible combitations of constructors I could end
        // up with 24 constructors and have to manage inheritance.  This is not plausible 
        // especially as many classes in an enterprise situation will contain 20+ Fields
        // which would equate to 20 * 19 * 18 * 17 * 16 * .... = 2,432,902,008,176,640,000
        // No one in their right mind would create the clutter required to manage all the 
        // possibilites

        public Person()
        {

        }

        public Person(int id): this()
        {
            this.Id = id;
        }

        public Person(int id, string firstName): this(id)
        {
            this.FirstName = firstName;
        }

        public Person(int id, string firstName, string lastName): this(id, firstName)
        {
            this.LastName = lastName;
        }

        public Person(int id, string firstName, string lastName, DateTime birthDate): this(id, firstName, lastName)
        {
            this.BirthDate = birthDate;
        }
    }
}
