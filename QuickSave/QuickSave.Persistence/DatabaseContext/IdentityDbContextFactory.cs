using QuickSave.Persistence.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSave.Persistence.DatabseContext
{
    class IdentityDbContextFactory : DesignTimeDbContextFactoryBase<IdentityDbContext>
    {
        protected override IdentityDbContext CreateNewInstance(DbContextOptions<IdentityDbContext> options)
        {
            return new IdentityDbContext(options);
        }
    }
}
