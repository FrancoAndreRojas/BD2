using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbetoDesing_SoftwareDAO.Model
{
    public class Material : BaseTable
    {
        #region Properties
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Int16 Stock { get; set; }

        #endregion


        #region Constructors
        /// <summary>
        /// Get
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="stock"></param>
        /// <param name="status"></param>
        /// <param name="registerDate"></param>
        /// <param name="lastUpdate"></param>
        ///// <param name="userID"></param>
        public Material(int id, string name, string description, short stock, byte status, DateTime registerDate, DateTime lastUpdate/*, int userID*/)
             : base(status, registerDate, lastUpdate/*, userID*/)
        {
            Id = id;
            Name = name;
            Description = description;
            Stock = stock;
        }

        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="stock"></param>
        public Material(string name, string description, short stock)
        {
            Name = name;
            Description = description;
            Stock = stock;
        }

        #endregion

    }
}