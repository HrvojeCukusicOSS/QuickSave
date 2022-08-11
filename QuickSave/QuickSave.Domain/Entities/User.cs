using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace QuickSave.Domain.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Submission> Submissions { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }

}
