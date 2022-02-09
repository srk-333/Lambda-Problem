using LambdaProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LambdaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("LambdaTest")]
        public void GetTopTwoPersonReturnTrue()
        {
            List<Person> list = new List<Person>();
            list.Add(new Person() { Name = "Saurav", SSN = 1, Age = 20, Address = "Patna" });
            list.Add(new Person() { Name = "Saurav", SSN = 2, Age = 21, Address = "Patna" });
            string excepted = "true";
            string actual = null; ;
            try
            {
               actual = Person.RemovePerson(list, "Saurav");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory("LambdaTest")]
        public void GetTopTwoPersonReturnNotFound()
        {
            List<Person> list = new List<Person>();
            list.Add(new Person() { Name = "Saurav", SSN = 1, Age = 20, Address = "Patna" });
            list.Add(new Person() { Name = "Saurav", SSN = 2, Age = 21, Address = "Patna" });
            string excepted = "not found";
            try
            {
               string actual = Person.RemovePerson(list, "abc");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(excepted, ex.Message);
            }
        }          
    }
}