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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesSportsContext _context;

        public IndexModel(RazorPagesSportsContext context)
        {
            _context = context;
        }

        public IList<Sports> Sports { get;set; }

        public async Task OnGetAsync()
        {
            Sports = await _context.Sports.ToListAsync();
        }
    }
}
