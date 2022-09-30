using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hauler_Up.Domain.Models
{
    public class Trawl : BaseModel
    {
        public string Name { get; set; }

        // EF
        public IEnumerable<Catch> Catches { get; set; }
    }
}
