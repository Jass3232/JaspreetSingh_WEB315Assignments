#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesSports.Models;

namespace RazorPagesSports.Pages_Sports
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesSportsContext _context;

        public DetailsModel(RazorPagesSportsContext context)
        {
            _context = context;
        }

        public Sports Sports { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sports = await _context.Sports.FirstOrDefaultAsync(m => m.ID == id);

            if (Sports == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
