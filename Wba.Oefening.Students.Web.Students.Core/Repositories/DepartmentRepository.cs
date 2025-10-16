using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wba.Oefening.Students.Web.Students.Core.Entities;

namespace Wba.Oefening.Students.Web.Students.Core.Repositories
{
    public class DepartmentRepository
    {
        public IEnumerable<Department> GetDepartments()
        {
            return new List<Department>
            {
                new Department {Id = 1, Name = "Programming"},
                new Department {Id = 2, Name = "Software Engineering"},
                new Department {Id = 3, Name = "Cybersecurity"},
            };
        }
    }
}
