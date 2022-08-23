using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSave.Persistence.Dtos
{
    public class SubmissionDto
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Version { get; set; }
        public DateTime DeviceTakeoverDate { get; set; }
    }
}
