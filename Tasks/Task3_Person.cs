using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Person
    {
        public string Name;
        public int Age;
        public int PhoneNumber;

        public Person(string Name, int Age, int PhoneNumber)
        {
            this.Name = Name;
            this.Age = Age;
            this.PhoneNumber = PhoneNumber;
        }
    }

    class Task3_Person
    {
        List<Person> myPerson = null;
        public Task3_Person()
        {
             myPerson = new List<Person>{
                new Person("Lilia",24, 0942751986),
                new Person("Katya",35, 0875494683),
                new Person ("Anna", 20, 0504976852),
                new Person ("Pavlo",18, 0579468215),
                new Person ("John", 44, 0557689451),
                new Person ("Olha", 29, 0675489762),
                new Person ("Daryna",34, 0978465982)
            };
        }
        public string PersonNameAndAge()
        {
            string result=" ";
            foreach (Person person in myPerson)
            {
                result += "Name:" + person.Name + ";  Age:" + person.Age + ";\n"; 
            }
            return result;
        }


    }



}



