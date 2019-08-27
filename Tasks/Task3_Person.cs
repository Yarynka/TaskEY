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
        public long PhoneNumber;

        public Person(string Name, int Age,  long PhoneNumber)
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
                new Person("Lilia",24, 80942751986),
                new Person("Katya",35, 80875494683),
                new Person ("Anna", 20, 80504976852),
                new Person ("Pavlo",18, 80579468215),
                new Person ("John", 44, 80557689451),
                new Person ("Olha", 29, 80675489762),
                new Person ("Daryna",34, 80978465982)
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
        public string PersonPhoneNumber()
        {
            string result = "";
            
            foreach (Person person in myPerson)
            {
                result += "Phone :" + String.Format("{0:(###) ###-####}",person.PhoneNumber) + ";\n";
            }
          
            return result;
        }
       
        public void AddTwoList()
        {
            var NewPerson = new List<Person>{
                new Person("David",30, 80752567948),
                new Person("Maya",30, 80978451278) };
            myPerson.AddRange(NewPerson);
        }




    }



}



