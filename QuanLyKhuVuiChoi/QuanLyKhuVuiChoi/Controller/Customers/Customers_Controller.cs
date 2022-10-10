using QuanLyKhuVuiChoi.Model.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyKhuVuiChoi.Controller.Customers
{
    internal class Customers_Controller
    {
        Customers_Method Customers_Method;
        public DataTable getCustomers()
        {
            return Customers_Method.getCustomers();
        }
        public bool InsertCustomers(tblCustomers cts)
        {
            return Customers_Method.InsertCustomers(cts);
        }
        public bool DeleteCustomers(tblCustomers cts)
        {
            return Customers_Method.DeleteCustomers(cts);
        }
        public DataTable FindCustomers(string cts)
        {
            return Customers_Method.FindCustomers(cts);
        }
        }
}
