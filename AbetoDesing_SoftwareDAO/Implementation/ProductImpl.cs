using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbetoDesing_SoftwareDAO.Interfaces;
using AbetoDesing_SoftwareDAO.Model;
using System.Data.SqlClient;


namespace AbetoDesing_SoftwareDAO.Implementation
{
    public class ProductImpl : BaseImpl, IProduct
    {
        public int Delete(Product t)
        {
            string query = @"UPDATE WarrantyType SET status=0, lastUpdate=CURRENT_TIMESTAMP, userID=@userID
                            WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@id", t.Id);
            try
            {
                return ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            { 
                //Log
                throw ex; 
            }

        }

        public Product Get(byte id)
        {
            Product t = null;
            string query = @"  SELECT id, warrantyTypeName, status, registerDate, lastUpdate, userID
                              FROM WarrantyType
                              WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = null;
            try
            {
                reader = ExecuteDataReaderCommand(command);
                while (reader.Read())
                {
                    t = new Product(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), short.Parse(reader[3].ToString()), reader[4].ToString(), reader[5].ToString(), int.Parse(reader[6].ToString()), byte.Parse(reader[7].ToString()), DateTime.Parse(reader[8].ToString()), DateTime.Parse(reader[9].ToString()));
                }
            }
            catch (Exception ex)
            {
                //log
                throw ex;
            }
            finally
            {
                command.Connection.Close();
                reader.Close();
            }
            return t;
        }

        public int Insert(Product t)
        {
            string query = @"INSERT INTO Product (ProductName, userID)
                            VALUES (@warrantyTypeName, @userID)";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@warrantyTypeName", t.Name);
            try
            {
                return ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                //Log
                throw ex;
            }

        }

        public DataTable Select()
        {
            string query = @" SELECT id AS ID, name AS Material, description AS Descripción, registerDate AS 'Creado en'
                              FROM Material
                              WHERE status=1
                              ORDER BY 2";
            SqlCommand command = CreateBasicCommand(query);

            try
            {
                return ExecuteDataTableCommand(command);
            }
            catch (Exception ex)
            {
                //Log
                throw ex;
            }
        }

        public int Update(Product t)
        {
            string query = @" UPDATE WarrantyType SET warrantyTypeName=@warrantyTypeName, lastUpdate=CURRENT_TIMESTAMP, userID=@userID
                              WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@warrantyTypeName", t.Name);
            command.Parameters.AddWithValue("@id", t.Id);
            try
            {
                return ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                //Log
                throw ex;
            }
        }
    }
}


