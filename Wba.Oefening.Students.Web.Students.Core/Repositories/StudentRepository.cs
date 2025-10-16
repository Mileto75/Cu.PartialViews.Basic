using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wba.Oefening.Students.Web.Students.Core.Entities;

namespace Wba.Oefening.Students.Web.Students.Core.Repositories
{
    public class StudentRepository
    {
        private IEnumerable<Student> Students;
        //declare extra repositories
        private readonly CourseRepository _courseRepository;
        private readonly DepartmentRepository _departmentRepository;
        public StudentRepository()
        {
            _courseRepository = new CourseRepository();
            _departmentRepository = new DepartmentRepository();
        }
        public IEnumerable<Student> Getstudents() 
        {
            Students = new List<Student>()
            {
                new Student{ Id = 1,Firstname = "Roberto",Lastname = "Baggio",Courses = _courseRepository
                .GetCourses().Where(c => c.Id == 1 || c.Id == 2),Department = _departmentRepository
                .GetDepartments()
                .FirstOrDefault(d => d.Id == 1)
                
                },
                new Student{ Id = 2,Firstname = "Paolo",Lastname = "Maldini",Courses = _courseRepository
                .GetCourses().Where(c => c.Id == 2 || c.Id == 3),Department = _departmentRepository
                .GetDepartments()
                .FirstOrDefault(d => d.Id == 2) },
                new Student{ Id = 3,Firstname = "Andrea",Lastname = "Pirlo",Courses = _courseRepository
                .GetCourses().Where(c => c.Id == 3 || c.Id == 1),Department = _departmentRepository
                .GetDepartments()
                .FirstOrDefault(d => d.Id == 3)},
                new Student{ Id = 4,Firstname = "Filippo",Lastname = "Inzaghi",Courses = _courseRepository
                .GetCourses().Where(c => c.Id == 3 || c.Id == 2),Department = _departmentRepository
                .GetDepartments()
                .FirstOrDefault(d => d.Id == 2)},
            };
            return Students;
        }
    }
}
