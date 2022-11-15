using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbetoDesing_SoftwareDAO.Interfaces;
using AbetoDesing_SoftwareDAO.Model;

namespace AbetoDesing_SoftwareDAO.Interface
{
    public interface IPerson : IBaseInterface<Person>
    {
        DataTable SelectLike(string txt);
    }
}
