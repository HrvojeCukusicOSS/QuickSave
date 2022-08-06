using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace QuickSave.Domain.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Device> Devices { get; set; }
        public ICollection<Voucher> Vouchers { get; set; }
        public ICollection<Invoice> Invoices { get; set; }

    }

}
