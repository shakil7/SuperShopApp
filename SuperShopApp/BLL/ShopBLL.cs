using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperShopApp.DLL.DAO;
using SuperShopApp.DLL.Gateway;

namespace SuperShopApp.BLL
{
    class ShopBLL
    {
        ShopGateway aShopGateway=new ShopGateway();
        public string Save(Shop aShop)
        {
            if (aShop.Name == string.Empty || aShop.Address == string.Empty)
            {
                return "fill all fields";
            }
            return aShopGateway.Save(aShop);
        }

        public string AddItem(Item anItem)
        {
            if (HasThisId(anItem))
            {
                return aShopGateway.Update(anItem);
            }
            return aShopGateway.AddItem(anItem);
        }

        private bool HasThisId(Item anItem)
        {
            return aShopGateway.HasThisId(anItem);
        }
    }
}
