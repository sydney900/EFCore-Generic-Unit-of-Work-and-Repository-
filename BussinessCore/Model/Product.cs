﻿using BussinessCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessCore.Model
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual List<ClientProduct> ClientsClientProducts { get; set; } = new List<ClientProduct>();
    }
}
