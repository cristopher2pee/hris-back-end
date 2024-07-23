﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hris.Data.Models.Tracker
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set;}
        public string? Email { get; set; }
        public string? ContactPerson { get; set; }

        public virtual IEnumerable<Project>? Projects { get; set; }= new List<Project>();
    }
}
