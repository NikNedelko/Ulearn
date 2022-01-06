using System;
using System.Collections.Generic;
using System.Linq;
using firstLINQ;
namespace firstLINQ
{
    class Student{
        public string LastName{get;set;}
        public string GroupName{get;set;}

    }
    class Program
    {
        static void Main(string[] args)
        {
             var students = new List<Student>{
                 new Student{LastName = "Jones", GroupName = "FT-1"},
                 new Student{LastName = "Adam", GroupName = "FT-1"},
                 new Student{LastName = "Williams", GroupName = "KN-1"},
                 new Student{LastName = "Brown", GroupName = "KN-1"}
             };
             var result = new List<string>();
             foreach (var student in students)
                if(student.GroupName == "KN-1")
                result.Add(student.LastName);

                var result1 = students
                .Where(z=>z.GroupName == "KN-1") //filter
                .Select(z=>z.LastName)
                .ToList();// convert to list
        }
    }
}
