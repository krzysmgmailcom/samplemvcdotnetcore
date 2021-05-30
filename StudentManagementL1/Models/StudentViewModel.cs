using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementL1.Models
{
    public class StudentViewModel
    {
        //[Key]
        //public int Id { get; set; }
        public Student studentsVm { get; set; }
        public Specialization specializationVm { get; set; }
    }
}
