using SclManagementSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SclManagementSystem.Data.Services
{
    public class InMemoryStudentData : IStudentData
    {
        List<Student> students;
        public InMemoryStudentData()
        {
            students = new List<Student>()
            {
                new Student{ID=1,Name="Mainul",Department="CSTE"},
                new Student{ID=2,Name="Asraf",Department="Economics"},
                new Student{ID=3,Name="Adon",Department="Economics"}
            };
        }
        public IEnumerable<Student> GetAll()
        {
            return students.OrderBy(r => r.ID);
        }
    }
}
