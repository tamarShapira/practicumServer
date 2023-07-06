using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Parent
    {
        public int Id { get; set; }
        public string ParentFirstName { get; set; }
        public string ParentLastName { get; set; }
        public string ParentId { get; set; }
        public DateTime ParentDOB { get; set; }
        public string ParentSpecies { get; set; }
        public string ParentHMO { get; set; }
        public List<Child> Children { get; set; }
    }
}
