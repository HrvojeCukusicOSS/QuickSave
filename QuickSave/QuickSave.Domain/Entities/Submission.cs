using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSave.Domain.Entities
{
    public class Submission : BaseEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Version { get; set; }
        public User Costumer { get; set; }
        public int CostumerId { get; set; }
        public string UserProblemSummary { get; set; }
        public DateTime DateOfArrival { get; set; }
        public DateTime RepairStartedAt { get; set; }
        public DateTime RepairFinishedAt { get; set; }
        public DateTime DeviceTakeoverDate { get; set; }
        public string RepairDescription { get; set; }
        public Repairment Repairment { get; set; }
    }
}
