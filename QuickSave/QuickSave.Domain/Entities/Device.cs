using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSave.Domain.Entities
{
    public class Device
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Version { get; set; }
        public string Color { get; set; }
        public User Costumer { get; set; }
        public int UserId { get; set; }
        public string ProblemSummary { get; set; }
        public DateTime DateOfArrival { get; set; }
        public Voucher Voucher { get; set; }
        public int VoucherId { get; set; }
    }
}
