using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Top_Mesto_55.Models;

namespace Top_Mesto_55.Models
{
    public class Top_Mesto_55Context : DbContext
    {
        public Top_Mesto_55Context (DbContextOptions<Top_Mesto_55Context> options)
            : base(options)
        {
        }

        public DbSet<Top_Mesto_55.Models.Music> Music { get; set; }

        public DbSet<Top_Mesto_55.Models.Sport> Sport { get; set; }

        public DbSet<Top_Mesto_55.Models.Park> Park { get; set; }
    }
}
