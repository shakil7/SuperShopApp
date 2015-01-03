using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperShopApp.DLL.DAO;
using System.Configuration;

namespace SuperShopApp.DLL.Gateway
{
    class ShopGateway
    {
        private SqlConnection connection;

        public ShopGateway()
        {
           connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConn"].ConnectionString);
        }

        public string Save(Shop aShop)                                                                                                                                                                                                                                                                                                                                                                    
        {
            connection.Open();
            string query = string.Format("INSERT INTO ashop_Table VALUES('{0}','{1}')", aShop.Name, aShop.Address);
            SqlCommand command=new SqlCommand(query,connection);


            try
            {
                command.ExecuteNonQuery();
                connection.Close();
                return "Shop has been created";
                
            }
            catch (SqlException)
            {
                connection.Close();
                return "something went wrong";
            }      
            
        }

        public string AddItem(Item anItem)
        {
            connection.Open();
            string query = string.Format("INSERT INTO item_Table VALUES('{0}','{1}')", anItem.ItemId,anItem.Qty);
            SqlCommand command = new SqlCommand(query, connection);
            int affectedRow = command.ExecuteNonQuery();
            connection.Close();
            if (affectedRow > 0)
            {
                return "Item added";
            }
            return "some problem about ur query";
            //try
            //{
            //    command.ExecuteNonQuery();
            //    connection.Close();
            //    return "Item Added";
            //}
            //catch (SqlException)
            //{
            //    connection.Close();
            //    return "something went wrong";
            //}
        }

        public bool HasThisId(Item anItem)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM item_Table WHERE ItemId={0}",anItem.ItemId);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool HasRow = aReader.HasRows;
            connection.Close();
            return HasRow;
        }

        public string Update(Item anItem)
        {
            connection.Open();
            string query = string.Format("UPDATE item_Table SET Qty=Qty+{0} WHERE ItemId='{1}'",anItem.Qty,anItem.ItemId);
            SqlCommand command = new SqlCommand(query, connection);
            int affectedRow = command.ExecuteNonQuery();
            connection.Close();
            if (affectedRow > 0)
            {
                return "Qty is updated";
            }
            return "some problem";
        }
    }
}
