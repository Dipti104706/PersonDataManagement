using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            PersonAddDetails(people);
            Console.ReadLine();
        }

        public static void PersonAddDetails(List<Person> people)
        {
            people.Add(new Person() { SSN = 1, Name = "Dipti", Address = "India", Age = 25 });
            people.Add(new Person() { SSN = 2, Name = "Dipt", Address = "India", Age = 46 });
            people.Add(new Person() { SSN = 3, Name = "Dii", Address = "India", Age = 75 });
            people.Add(new Person() { SSN = 4, Name = "Dipy", Address = "India", Age = 56 });
            people.Add(new Person() { SSN = 5, Name = "Dti", Address = "India", Age = 81 });
            people.Add(new Person() { SSN = 6, Name = "tip", Address = "India", Age = 15 });
            IterateLoop(people);
        }     

        public static void IterateLoop(List<Person> people) 
        {
            foreach(Person person in people)
            {
                Console.WriteLine("SSN={0} \t Name={1} \t Address={2} \t Age={3}",person.SSN,person.Name,person.Address,person.Age);
            }
        }
    }
}
