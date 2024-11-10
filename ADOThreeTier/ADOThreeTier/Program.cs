using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOThreeTier
{
    class ProductRetrive
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        public ProductRetrive()
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-76VV44J\SQLEXPRESS;
            //                            Initial Catalog=Northwind;
            //                            User Id=sa;
            //                            Password=gamersinn");
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myproduct"].ConnectionString);
        }
        public void ProductDisplay()
        {
            conn.Open();
            cmd = new SqlCommand("select * from Products", conn);
            dr = cmd.ExecuteReader();
            Console.WriteLine("Displaying product details from NorthWind");
            while(dr.Read())
            {
                Console.WriteLine(dr[0] + "\t" + dr[1]);
            }
            conn.Close();
        }

        public void ProductDisplay(int i)
        {
            conn.Open();
            cmd = new SqlCommand("getProduct", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", i);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3]);
            }
            conn.Close();
        }
        
        public void DisplayExpense()
        {
            conn.Open();
            cmd = new SqlCommand("[ten most expensive products]", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine(dr[0] + "\t" + dr[1]);
            }
            conn.Close();
        }

        public bool Insert(string name, int cid, double price)
        {
            bool status = false;


            cmd = new SqlCommand("prcInsertCommand", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pname", name);
            cmd.Parameters.AddWithValue("@cid", cid);
            cmd.Parameters.AddWithValue("@price", price);

            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
            conn.Open();
            try
            {
                if(cmd.ExecuteNonQuery() >0)
                {
                    status = true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            conn.Close();
            return status;
        }

        public void DeleteProduct(int id)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("delete from products where productId = @pid", conn);
                cmd.Parameters.AddWithValue("@pid", id);
                int count = cmd.ExecuteNonQuery();
                Console.WriteLine("No of rows deleted {0)", count);
            }
            catch (SqlException s)
            {
                Console.WriteLine("Database does not have permissions to delete");
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error...Try again");
            }
            finally
            {
                conn.Close();
            }
        }
    }
    public class Client
    {
        public static void Main()
        {
            ProductRetrive pr = new ProductRetrive();
            int choice = 0;
            do
            {
                Console.WriteLine("Enter your choice \n 1.All \t 2.Expensive \t 3.Product of your choice 4.Insert \t 0.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        pr.ProductDisplay();
                        break;
                    case 2:
                        pr.DisplayExpense();
                        break;
                    case 3:
                        pr.ProductDisplay(2);
                        break;
                    case 4:
                        if (pr.Insert("Lemon Juice", 200, 5))
                            Console.WriteLine("The Product inserted....");
                        else
                            Console.WriteLine("Insertion failed!");
                        break;
                    default: break;
                }
            } while (choice != 0);
            Console.ReadLine();
        }
    }
}
