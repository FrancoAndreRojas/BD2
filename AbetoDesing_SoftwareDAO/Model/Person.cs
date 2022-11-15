using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbetoDesing_SoftwareDAO.Model
{
    public class Person : BaseTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SecondSurname { get; set; }
        public int Ruc { get; set; }
        public string Adress { get; set; }
        public Int16 PhoneNumber { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="secondSurname"></param>
        /// <param name="ruc"></param>
        /// <param name="adress"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="status"></param>
        /// <param name="registerDate"></param>
        /// <param name="lastUpdate"></param>
        ///// <param name="userID"></param>

        public Person(int id, string name, string surname, string secondSurname, int ruc, string adress, short phoneNumber, double latitude, double longitude, byte status, DateTime registerDate, DateTime lastUpdate/*, int userID*/)
            : base(status, registerDate, lastUpdate/*, userID*/)
        {
            Id = id;
            Name = name;
            Surname = surname;
            SecondSurname = secondSurname;
            Ruc = ruc;
            Adress = adress;
            PhoneNumber = phoneNumber;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}