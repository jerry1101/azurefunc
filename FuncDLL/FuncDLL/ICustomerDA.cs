using System;
using System.Collections.Generic;
using System.Text;

namespace FuncDLL
{
    interface ICustomerDA
    {
        List<CustomerVO> GetAllCustomer();
        CustomerVO GetCustomerByID(int id);

    }
}
