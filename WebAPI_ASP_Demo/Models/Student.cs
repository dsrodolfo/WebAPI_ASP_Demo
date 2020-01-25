using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_ASP_Demo.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }

        public Student(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }
    }
}