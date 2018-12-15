using System;
using System.Collections.Generic;

namespace FuncDLL
{
    public class CustomerDA : ICustomerDA
    {
        private List<CustomerVO> customerList;
        public CustomerDA()
        {
            customerList = new List<CustomerVO>();
            customerList.Add(new CustomerVO { ID = 1, FirstName = "A", LastName = "AL" });
            customerList.Add(new CustomerVO { ID = 2, FirstName = "B", LastName = "BL" });
            customerList.Add(new CustomerVO { ID = 3, FirstName = "C", LastName = "CL" });
        }

        List<CustomerVO> ICustomerDA.GetAllCustomer() => customerList;



        CustomerVO ICustomerDA.GetCustomerByID(int id) => customerList.Find(match: c => c.ID == id);


    }
}
