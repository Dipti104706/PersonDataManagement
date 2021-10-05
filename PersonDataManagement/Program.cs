using System;
using System.Collections.Generic;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            PersonAddDetails(people);
            Console.WriteLine("");
            SearchName(people, "Priti");
            Console.ReadLine();
        }

        //uc1 for creating and adding details of a person in person data management
        public static void PersonAddDetails(List<Person> people)
        {
            people.Add(new Person() { SSN = 1, Name = "Dipti", Address = "India", Age = 25 });
            people.Add(new Person() { SSN = 2, Name = "Deba", Address = "Jajpur", Age = 46 });
            people.Add(new Person() { SSN = 3, Name = "Sarika", Address = "Ganjam", Age = 75 });
            people.Add(new Person() { SSN = 4, Name = "Suchitra", Address = "BBSR", Age = 56 });
            people.Add(new Person() { SSN = 5, Name = "Aliva", Address = "Bangalore", Age = 81 });
            people.Add(new Person() { SSN = 6, Name = "Priti", Address = "Kerala", Age = 15 });
            IterateLoop(people);
        }

        //Printing details of the list people
        public static void IterateLoop(List<Person> people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine("SSN={0} \t Name={1} \t Address={2} \t Age={3}", person.SSN, person.Name, person.Address, person.Age);
            }
        }

        //UC5 search a specific name present or not
        public static void SearchName(List<Person> people, string name)
        {
            var result = people.Find(p => p.Name == name);
            try
            {
                if (result != null)
                {
                    Console.WriteLine("The name is Present: "  +result.SSN+ " " +result.Name);
                }
                else
                    Console.WriteLine("The name is not present");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }    
}
