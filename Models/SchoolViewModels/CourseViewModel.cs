using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RajUniEFCoreRP3.Models.SchoolViewModels
{
    public class CourseViewModel
    {
        [Display(Name = "Number")]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }
    }
}
