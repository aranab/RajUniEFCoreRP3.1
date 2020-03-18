using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RajUniEFCoreRP3.Data;
using RajUniEFCoreRP3.Models.SchoolViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RajUniEFCoreRP3.Pages.Courses
{
    public class IndexSelectModel : PageModel
    {
        private readonly SchoolContext _context;

        public IndexSelectModel(SchoolContext context)
        {
            _context = context;
        }

        public IList<CourseViewModel> CoursesVM { get; set; }

        public async Task OnGetAsync()
        {
            CoursesVM = await _context.Courses
                .Select(p => new CourseViewModel
                {
                    CourseID = p.CourseID,
                    Title = p.Title,
                    Credits = p.Credits,
                    DepartmentName = p.Department.Name
                }).ToListAsync();
        }
    }
}