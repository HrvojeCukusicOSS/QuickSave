using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSave.Shared.Entites
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Description { get; set; }
        public string Nationality { get; set; }
        public string Continent { get; set; }
        public ICollection<State> States { get; set; }
        public ICollection<Person> People { get; set; }
    }
}
