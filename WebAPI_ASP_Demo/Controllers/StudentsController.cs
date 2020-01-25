using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_ASP_Demo.Models;

namespace WebAPI_ASP_Demo.Controllers
{
    public class StudentsController : ApiController
    {
        private static List<Student> students = new List<Student>();

        [HttpGet]
        public List<Student> Get() => students;

        [HttpPost]
        public void Post(string name, string country, int age)
        {
            if (!String.IsNullOrWhiteSpace(name)) { students.Add(new Student(name, country, age)); }
        }
        
        [HttpDelete]
        public void Delete(string name)
        {
            students.RemoveAt(students.IndexOf(students.First(x => x.Name.Equals(name))));
        }
    }
}
