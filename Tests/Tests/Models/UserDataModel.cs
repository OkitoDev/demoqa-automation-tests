using System;
using System.Collections.Generic;

namespace Tests.Models
{
    public class UserDataModel : IEquatable<UserDataModel>
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public int Age { get; }
        public int Salary { get; }
        public string Department { get; }

        public UserDataModel(string firstName, string lastName, string email, int age, int salary, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Age = age;
            Salary = salary;
            Department = department;
        }

        public bool Equals(UserDataModel other)
        {
            if (other == null)
            {
                return false;
            }

            return FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   Email == other.Email &&
                   Age == other.Age &&
                   Salary == other.Salary &&
                   Department == other.Department;
        }

        public List<string> ReturnAsListOfStrings()
        {
            return new List<string>
            {
                FirstName,
                LastName,
                Email,
                Age.ToString(),
                Salary.ToString(),
                Department
            };
        }
    }
}