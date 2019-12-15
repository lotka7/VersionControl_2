using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMaintance.Entities
{
    class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName
        {
            get
            {
                return string.Format(
                    "{0} {1}",
                    lastName,
                    firstName
                    );
            }
        }
    }
}
