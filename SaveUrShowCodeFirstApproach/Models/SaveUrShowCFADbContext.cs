using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaveUrShowCodeFirstApproach.Models
{
    public class SaveUrShowCFADbContext : DbContext
    {
        public SaveUrShowCFADbContext(DbContextOptions<SaveUrShowCFADbContext> options)
          : base(options)
        {
        }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<FindTicket> FindTicket { get; set; }
        public virtual DbSet<BookTicket> BookTicket { get; set; }

    }
}
