using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using QuickSave.Domain.Entities;
using QuickSave.Persistence.DatabseContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QuickSave.Persistence.Repositories
{
    public class SubmissionRepository
    {
        QuickSaveDbContext _quickSaveDbContext;
        public SubmissionRepository(QuickSaveDbContext quickSaveDbContext)
        {
            _quickSaveDbContext = quickSaveDbContext;
        }
        public IEnumerable<Submission> GetSubmissions()
        {
            return _quickSaveDbContext.Submissions.ToList();
        }
        public Submission Single(int id)
        {
            var submission = _quickSaveDbContext.Submissions.FirstOrDefault(s => s.Equals(id));
            return submission;
        }

        public void Persist(Submission entity)
        {
            _quickSaveDbContext.Submissions.Add(entity);
        }

        public void Flush()
        {
            _quickSaveDbContext.SaveChanges();
        }

        public void FlushAsync()
        {
            _quickSaveDbContext.SaveChangesAsync();
        }
    }
}
