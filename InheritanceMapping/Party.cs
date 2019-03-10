using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMapping
{
    public class Party
    {
        public virtual Guid Id { get; set; }
        public virtual string Address { get; set; }
        public virtual int PhoneNumber { get; set; }
        public virtual string EmailAddress { get; set; }
    }
}