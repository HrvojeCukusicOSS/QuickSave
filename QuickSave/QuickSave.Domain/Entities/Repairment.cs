using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSave.Domain.Entities
{
    public class Repairment : BaseEntity
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public float Price { get; set; }
        public Submission Submission { get; set; }
        public int SubmissionId { get; set; }
        public ICollection<Part> Parts { get; set; }
        public Invoice Invoice { get; set; }
        public int InvoiceId { get; set; }
    }
}
