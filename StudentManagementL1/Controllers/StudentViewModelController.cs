using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagementL1.Data;
using StudentManagementL1.Models;

namespace StudentManagementL1.Controllers
{
    public class StudentViewModelController : Controller
    {
        private readonly StudentContext _context;

        public StudentViewModelController(StudentContext context)
        {
            _context = context;
        }
        // GET: StudentViewModelController
        public IActionResult Index()
        {
            var alist = from s in _context.Student
                        join sa in _context.Specialization on s.spec equals sa.Id
                        //where s.G_ID == 1
                        select new StudentViewModel
                        {
                            studentsVm = s,
                            specializationVm = sa,

                        };

            return View(alist.ToList());
        }

        // GET: StudentViewModelController/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alist = from s in _context.Student
                        join sa in _context.Specialization on s.spec equals sa.Id
                        where s.Id == id
                        select new StudentViewModel
                        {
                            studentsVm = s,
                            specializationVm = sa,

                        };


            return View(alist.FirstOrDefault());
        }
    }


}
