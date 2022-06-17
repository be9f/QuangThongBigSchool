using QuangThongBigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuangThongBigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
    //public ActionResult Create()
    //{
    //    var viewModel = new CourseViewModel
    //    {
    //        Categories = _dbContext.Categories.ToList(),
    //        Heading = "Add Course"
    //    };
    //    return View(viewModel);
    //}
}