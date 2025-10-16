using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wba.Oefening.Students.Web.Students.Core.Entities;

namespace Wba.Oefening.Students.Web.Students.Core.Repositories
{
    public class CourseRepository
    {
        public IEnumerable<Course> GetCourses()
        {
            return new List<Course> 
            {
                new Course{ Id = 1,Name = "WBA"},
                new Course{ Id = 2,Name = "WFA"},
                new Course{ Id = 3,Name = "PRE"},
            };
        }
    }
}
