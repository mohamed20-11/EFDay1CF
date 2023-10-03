﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDay1
{
    public class Wallet
    {
        public int id { get; set; }
        public string Holder { get; set; }
        public decimal Balance { get; set; }
        public override string ToString()
        {
            return $"[{id}] {Holder}  ({Balance:C})";
        }
    }
}
