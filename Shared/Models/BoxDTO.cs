﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jVision.Shared.Models
{
    public class BoxDTO
    {
        public int BoxId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Ip { get; set; }
        public string Hostname { get; set; }
        public bool State { get; set; }
        public string Comments { get; set; }
        public bool Active { get; set; }
        public bool Pwned { get; set; }
        public bool Unrelated { get; set; }
        public bool Comeback { get; set; }
        public string Os { get; set; }
        public string Cidr { get; set; }

        public string Subnet { get; set; }
        public string Refs { get; set; }

        public ICollection<ServiceDTO> Services { get; set; }

    }
}
