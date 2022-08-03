using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSave.Shared.Entites
{
    public class User : Person
    {
        public ICollection<Device> Devices { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
