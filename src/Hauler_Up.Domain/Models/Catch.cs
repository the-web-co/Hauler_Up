using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hauler_Up.Domain.Models
{
    public class Catch : BaseModel
    {
        public DateTime Date { get; set; }
        public int Market { get; set; } 
        public int Canner { get; set; }
        public int TrawlId { get; set; }

        // EF Relation
        public Trawl Trawl { get; set; }
    }
}
