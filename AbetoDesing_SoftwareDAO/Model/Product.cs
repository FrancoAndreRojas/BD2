using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbetoDesing_SoftwareDAO.Model
{
    public class Product : BaseTable
    {
        #region Properties
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public Int16 Price { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public Int32 Stock { get; set; }

        #endregion


        #region Constructors
        /// <summary>
        /// Get
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="image"></param>
        /// <param name="price"></param>
        /// <param name="description"></param>
        /// <param name="status"></param>
        /// <param name="registerDate"></param>
        /// <param name="lastUpdate"></param>
        /// <param name="userID"></param>
        public Product(int id, string name, string image, short price, string description, string type, int stock, byte status, DateTime registerDate, DateTime lastUpdate, int userID)
            : base(status, registerDate, lastUpdate, userID)
        {
            Id = id;
            Name = name;
            Image = image;
            Price = price;
            Description = description;
            Type = type;
            Stock = stock;
        }

        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="name"></param>
        /// <param name="image"></param>
        /// <param name="price"></param>
        /// <param name="description"></param>
        /// <param name="type"></param>
        /// <param name="stock"></param>
        public Product(string name, string image, short price, string description, string type, int stock)
        {
            Name = name;
            Image = image;
            Price = price;
            Description = description;
            Type = type;
            Stock = stock;
        }

        public Product(int v1, string v2, string v3, short v4, string v5, string v6, int v7, byte v8, DateTime dateTime1, DateTime dateTime2)
        {
        }

        #endregion

    }
}