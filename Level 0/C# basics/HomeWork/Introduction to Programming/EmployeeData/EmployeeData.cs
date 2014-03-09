//Problem 11.	Employee Data
//A marketing company wants to keep record of its employees. Each record would 
//have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single 
//employee using appropriate primitive data types. Use descriptive 
//names. Print the data at the console.

namespace EmployeeData
{
    using System;
    using System.Text;

    internal class EmployeeData
    {
        private static void Main()
        {
            Person person = new Person();

            person.FirstName = "Elthon";
            person.LastName = "John";
            person.Age = 99;
            person.PersonGender = Gender.Male;
            person.PersonalId = "8306112507";
            person.EmployeeNumber = 27560000;

            Console.WriteLine(person);
        }
    }
}