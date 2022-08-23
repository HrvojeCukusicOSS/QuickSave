using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using QuickSave.Domain.Entities;
using QuickSave.Persistence.DatabseContext;
using System.Collections.Generic;
using System.Linq;

namespace QuickSave.Persistence.Repositories
{
    public class UserRepository
    {
        QuickSaveDbContext _quickSaveDbContext;
        public UserRepository(QuickSaveDbContext quickSaveDbContext)
        {
            _quickSaveDbContext = quickSaveDbContext;
        }
        public IEnumerable<User> GetUsers()
        {
            return _quickSaveDbContext.Users.ToList();
        }
    }
}
