using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopApp.DLL.DAO
{
    class Item
    {
        public string ItemId { get; set; }
        public int Qty { get; set; }

        public Item(string itemId, int qty):this()
        {
            ItemId = itemId;
            Qty = qty;
        }

        public Item()
        {
        }
    }
}
