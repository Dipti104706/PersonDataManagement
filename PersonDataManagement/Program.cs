﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            PersonAddDetails(people);
            Console.WriteLine("");
            RetrieveAgemorethan60(people);
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

        //UC6 rectrive age greater than 60 and use Skip() to skip record as per requirement
        public static void RetrieveAgemorethan60(List<Person> people)
        {
            Console.WriteLine("Displaying person details above 60 age");
            List<Person> result = people.FindAll(person => person.Age > 60).Skip(1).ToList();
            IterateLoop(result);
        }

    }    
}
