using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kmi.Contracts.Entities
{
    public class AccessRestriction
    {
        /// <summary>
        /// Array of time restriction which indicates when persons are allowed to enter 
        /// </summary>
        public TimeRestriction[] TimeRestriction {get; set;}

        //Maybe we will add "area destriction one day" so we sepearted time restriction into a seperate class

    }
}
