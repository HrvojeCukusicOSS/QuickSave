using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using QuickSave.Domain.Entities;
using QuickSave.Persistence.DatabseContext;
using System.Collections.Generic;
using System.Linq;

namespace QuickSave.Persistence.Repositories
{
    public class RepairmentRepository
    {
        QuickSaveDbContext _quickSaveDbContext;
        public RepairmentRepository(QuickSaveDbContext quickSaveDbContext)
        {
            _quickSaveDbContext = quickSaveDbContext;
        }
        public IEnumerable<Repairment> GetRepairments()
        {
            return _quickSaveDbContext.Repairments.ToList();
        }
    }
}
