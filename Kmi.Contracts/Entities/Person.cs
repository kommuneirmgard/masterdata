using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kmi.Contracts.Entities
{
    public class Person
    {
        public Person()
        {
            this.ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }

        public string Name { get; set; }

        public PersonStatus Status { get; set; }

    }
}
