using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kmi.Contracts.Entities
{
    public class TimeRestriction
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }


        public DayOfWeek Day { get; set; }
    }
}
