﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopApp.DLL.DAO
{
    class Shop
    {
        public int ShopId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Shop(string name, string address):this()
        {
            Name = name;
            Address = address;
        }

        public Shop()
        {
        }
    }
}
