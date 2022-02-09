using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lambda Program");
            List<Person> list = new List<Person>();
            GetPersonDetails(list);
            Console.ReadKey();
        }
        //Method to Invoke Person Class Methods.
        public static void GetPersonDetails(List<Person> list)
        {
            Person.PersonDetails(list);
            Person.GetTopTwoPerson(list);
            Person.RetrivePersonByAge(list);
            Person.RetrivePersonAverageAge(list);
            Person.SearchPersonByName(list, "Saurav");
            Person.SkipPersonByAge(list);
            Person.RemovePersonByName(list, "Saurav");
            Person.RemovePerson(list, "Saurav");
        }
    }
}
