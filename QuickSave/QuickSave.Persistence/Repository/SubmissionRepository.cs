using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using QuickSave.Domain.Entities;
using QuickSave.Persistence.DatabseContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSave.Persistence.Repository
{
    public class SubmissionRepository : BaseRepository<Submission>
    {
        public SubmissionRepository(IdentityDbContext db) : base(db)
        {
        }
    }
}
