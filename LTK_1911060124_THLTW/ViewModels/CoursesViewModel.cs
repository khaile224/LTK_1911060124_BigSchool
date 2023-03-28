using LTK_1911060124_THLTW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTK_1911060124_THLTW.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}