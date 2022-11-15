using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbetoDesing_SoftwareDAO.Model;

namespace AbetoDesing_SoftwareDAO.Interfaces
{
    public interface IProduct : IBaseInterface<Product>
    {
        Product Get(byte id);
    }
}
