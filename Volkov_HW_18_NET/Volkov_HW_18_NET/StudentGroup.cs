using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_18_NET
{
    internal class StudentGroup
    {
        Student student;

        public StudentGroup(Student student)
        {
            this.student = student;
        }

        public Student Leader { get; set; }
        public List<Student> students { get; set; }
    }
}
