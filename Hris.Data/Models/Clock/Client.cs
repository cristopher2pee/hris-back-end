using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hris.Data.Models.Clock
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public string? Address { get; set; }
        public string? ContactPerson { get; set; }
        public string? Email { get; set; }
        public string? Contact { get; set; }
    }
}
