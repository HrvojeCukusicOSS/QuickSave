using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using QuickSave.Domain.Entities;

namespace QuickSave.Persistence.Repository
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(IdentityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
