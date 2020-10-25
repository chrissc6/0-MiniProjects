using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolUniversity.Models
{
    public class Student
    {
        //primary key
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //navigation property
        //a Student entity will hold all of the Enrollment entities that are related to that Student entity
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
