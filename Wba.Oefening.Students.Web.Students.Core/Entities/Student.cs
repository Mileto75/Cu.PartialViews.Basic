using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wba.Oefening.Students.Web.Students.Core.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        //many to many in MockData
        public IEnumerable<Course> Courses { get; set; }
        //one to many in MockData
        public Department Department { get; set; }
    }
}
