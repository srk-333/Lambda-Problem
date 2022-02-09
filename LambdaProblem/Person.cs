using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaProblem
{
    public class Person
    {
        //Properties
        public string Name { get; set; }
        public int SSN { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        //Method to Add Persons in List
        public static void PersonDetails(List<Person> list)
        {
            Console.WriteLine("Person Details");
            list.Add(new Person() { Name = "Saurav", SSN = 1, Age = 14, Address = "Patna" });
            list.Add(new Person() { Name = "Ritesh", SSN = 2, Age = 68, Address = "Bangalore" });
            list.Add(new Person() { Name = "Vikash", SSN = 3, Age = 23, Address = "Mumbai" });
            list.Add(new Person() { Name = "Shashi", SSN = 4, Age = 22, Address = "Delhi" });
            list.Add(new Person() { Name = "Suresh", SSN = 5, Age = 63, Address = "Patna" });
            list.Add(new Person() { Name = "Saurav", SSN = 6, Age = 17, Address = "Gaya" });
            list.Add(new Person() { Name = "Sanjay", SSN = 7, Age = 29, Address = "Pune" });
            list.Add(new Person() { Name = "Ramesh", SSN = 8, Age = 12, Address = "Hyderabad" });
            list.Add(new Person() { Name = "Rohit", SSN = 9, Age = 70, Address = "Gurugram" });
            ShowPersonDetails(list);
        }
        //Method To Show Person Deatils From List 
        public static void ShowPersonDetails(List<Person> list)
        {
            foreach (Person p in list)
            {
                Console.WriteLine("Name={0}\tSSN={1}\tAge={2}\tAddress={3}",p.Name,p.SSN,p.Age,p.Address);
            }
        }
        //Method to Get Top Two Person having Age less than 60.
        public static void GetTopTwoPerson(List<Person> list)
        {
            Console.WriteLine();
            Console.WriteLine("Get Top Two Person having Age less than 60");
            var TopTwoPerson = list.Where(p => p.Age < 60).OrderBy(p => p.Age).Take(2).ToList();
            ShowPersonDetails(TopTwoPerson);
        }
        //Method to Get Person having Age Between 13 and 18 .
        public static void RetrivePersonByAge(List<Person> list)
        {
            Console.WriteLine();
            Console.WriteLine("Get Person having Age Between 13 and 18");
            var PersonByAge = list.Where(p => p.Age >= 13 && p.Age <= 18).OrderBy(p => p.Age).ToList();
            ShowPersonDetails(PersonByAge);
        }
        //Method to Get Person Average Age
        public static void RetrivePersonAverageAge(List<Person> list)
        {
            Console.WriteLine();
            Console.WriteLine("Get Person Average Age From the List");
            double PersonAverageAge = list.Average(p => p.Age);
            Console.WriteLine("Average Age of Person = "+PersonAverageAge);
        }
        //Method to Get Person Details by Specific Name
        public static void SearchPersonByName(List<Person> list, string name)
        {
            Console.WriteLine();
            Console.WriteLine("Get Person By name From the List");
            var PersonByName = list.FindAll(p => p.Name == name).ToList();
            ShowPersonDetails(PersonByName);
        }
        //Method to Skip Person having Age less than 60.
        public static void SkipPersonByAge(List<Person> list)
        {
            Console.WriteLine();
            Console.WriteLine("Skip Person having Age less than 60");
            var TopTwoPerson = list.Where(p => p.Age >= 60).OrderBy(p => p.Age).Skip(1).ToList();
            ShowPersonDetails(TopTwoPerson);
        }
        //Method to Remove a Person Details by Specific Name from the List.
        public static void RemovePersonByName(List<Person> list, string name)
        {
            Console.WriteLine();
            Console.WriteLine("Get Person By name From the List");
            var PersonByName = list.FindAll(p => p.Name == name).Take(1).ToList();
            ShowPersonDetails(PersonByName);           
        }
        //Override ToString Method.
        public override string ToString()
        {
            return ($"Name={Name}\tSSN={SSN}\tAge={Age}\tAddress={Address}");
        }
        //Method to Remove a Person Details by Specific Name from the List.
        public static void RemovePerson(List<Person> list, string name)
        {
            Console.WriteLine();
            Console.WriteLine("Remove Person From list by another Way");
            string PersonByName2 = list.Find(p => p.Name == name).ToString();
            Console.WriteLine(PersonByName2);
        }
    }  
}