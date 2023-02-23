using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Person.cs
using System;
namespace PersonNamespace
{
    public class Person
    {
        private string idNumber;
        private string lastName;
        private string firstName;
        private int age;
        // Constructor with zero arguments
        public Person()
        {
        }
        // Constructor with four arguments
        public Person(string id, string lname, string fname, int anAge)
        {
            idNumber = id;
            lastName = lname;
            firstName = fname;
            age = anAge;
        }
        // Constructor with three arguments
        public Person(string id, string lname, string fname)
        {
            idNumber = id;
            lastName = lname;
            firstName = fname;
        }
        // Constructor with one argument
        public Person(string id)
        {
            idNumber = id;
        }
        // Read-only property. ID cannot be changed.
        public string IdNumber
        {
            get
            {
                return idNumber;
            }
        }

    // Property for last name
 public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        // Read-only property. First name cannot be changed.
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        // Overrides ToString( ) method from the Object class
        public override string ToString()
        {
            return firstName + " " + lastName;
        }
        // Virtual method can be overridden by classes that
        // derive from the Person class.
        public virtual int GetSleepAmt()
        {
            return 8;
        }
    }
}