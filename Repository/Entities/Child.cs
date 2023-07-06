using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Child
    {
        
        public int Id { get; set; }
        public string ChildName { get; set; }
        public string ChildId { get; set; }
        public DateTime ChildDOB { get; set; }

    }
}
