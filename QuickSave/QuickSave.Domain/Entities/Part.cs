using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSave.Domain.Entities
{
    public class Part
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public Voucher Voucher { get; set; }
    }
}
