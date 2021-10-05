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
            RetrieveTop2Records(people);
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

        //UC2 to get Top 2 records age less than 60
        public static void RetrieveTop2Records(List<Person> people)
        {
            //List<Person> AgeLessthan60 = people.FindAll(person => person.Age < 60);
            //Console.WriteLine("Displaying person details if age is less than 60");
            //IterateLoop(AgeLessthan60);

            //List<Person> SortedResult = AgeLessthan60.OrderBy(s => s.Age).ToList();
            //Console.WriteLine("Displaying person details after sort");
            //IterateLoop(SortedResult);

            //List<Person> Top2 = SortedResult.Take(2).ToList();
            //Console.WriteLine("Displaying person details of top 2");
            //IterateLoop(Top2);

            //All 9 lines can be written in a single line using lambda
            Console.WriteLine("Displaying person details of top 2 with age less than 60");
            //Findall() used to get all Ages accoding to the expression
            //Orderby() used to sort list in ascending order
            //Take(2) show onlu first two records
            List<Person> result = people.FindAll(person => person.Age < 60).OrderBy(s => s.Age).Take(2).ToList();
            IterateLoop(result);
        }
    }
}
