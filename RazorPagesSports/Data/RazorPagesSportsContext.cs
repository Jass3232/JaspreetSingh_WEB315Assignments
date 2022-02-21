#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesSports.Models;

    public class RazorPagesSportsContext : DbContext
    {
        public RazorPagesSportsContext (DbContextOptions<RazorPagesSportsContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesSports.Models.Sports> Sports { get; set; }
    }
