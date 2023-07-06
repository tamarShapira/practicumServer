using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repository.Entities;

namespace Repository.Interfaces
{
    public interface IDataSource
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        public DbSet<Parent> Parent { get; set; }
        public DbSet<Child> Child { get; set; }
    }
}
