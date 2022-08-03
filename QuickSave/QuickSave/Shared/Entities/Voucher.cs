using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSave.Shared.Entites
{
    public class Voucher
    {
        public int Id { get; set; }
        public DateTime DateOfStart { get; set; }
        public string ProblemDescription { get; set; }
        public float Amount { get; set; }
        public DateTime DateOfCompletion { get; set; }
        public Device Device { get; set; }
        public int DeviceId { get; set; }
        public Worker Worker { get; set; }
        public int WorkerId { get; set; }
        public ICollection<Part> Parts { get; set; }
        public Payment Payment { get; set; }
    }
}
