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
    internal class Material_Impl : BaseImpl, IMaterial
    {
        public int Delete(Material t)
        {
            string query = @"UPDATE Material SET status=0, lastUpdate=CURRENT_TIMESTAMP, userID=@userID
                             WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@name", t.Name);
            command.Parameters.AddWithValue("@description", t.Description);
            command.Parameters.AddWithValue("@stock", t.Stock);
            command.Parameters.AddWithValue("@stock", Session.SessionUserID);
            command.Parameters.AddWithValue("@stock", t.Id);
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

        public int Insert(Material t)
        {
            string query = @"INSERT INTO Material(name, description, stock, userID)
                             VALUES (@name, @description, @stock, userID)";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@name", t.Name);
            command.Parameters.AddWithValue("@description", t.Description);
            command.Parameters.AddWithValue("@stock", t.Stock);
            command.Parameters.AddWithValue("@stock", Session.SessionUserID);
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

        public DataTable SelectBetweenID(byte idInit, byte idEnd)
        {
            throw new NotImplementedException();
        }

        public int Update(Material t)
        {
            string query = @"UPDATE Material SET name=@name, description=@description, lastUpdate=CURRENT_TIMESTAMP, userID=@userID
                             WHERE id=@id ";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@name", t.Name);
            command.Parameters.AddWithValue("@description", t.Description);
            command.Parameters.AddWithValue("@stock", t.Stock);
            command.Parameters.AddWithValue("@stock", Session.SessionUserID);
            command.Parameters.AddWithValue("@stock", t.Id);
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
