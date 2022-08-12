using QuickSave.Persistence.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSave.Persistence.DatabseContext
{
    class QuickSaveDbContextFactory : DesignTimeDbContextFactoryBase<QuickSaveDbContext>
    {
        protected override QuickSaveDbContext CreateNewInstance(DbContextOptions<QuickSaveDbContext> options)
        {
            return new QuickSaveDbContext(options);
        }
    }
}
