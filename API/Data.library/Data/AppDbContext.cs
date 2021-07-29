using Microsoft.EntityFrameworkCore;
using Model.library.Models;
using System;

namespace Data.library.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<NoteModel> noteModels { get; set; }
    }
}
