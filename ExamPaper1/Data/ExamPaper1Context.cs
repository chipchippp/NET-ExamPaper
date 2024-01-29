using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExamPaper1.Models;

namespace ExamPaper1.Data
{
    public class ExamPaper1Context : DbContext
    {
        public ExamPaper1Context (DbContextOptions<ExamPaper1Context> options)
            : base(options)
        {
        }

        public DbSet<ExamPaper1.Models.Department> Department { get; set; } = default!;

        public DbSet<ExamPaper1.Models.Employee> Employee { get; set; } = default!;

        public DbSet<ExamPaper1.Models.Account> Account { get; set; } = default!;
    }
}
