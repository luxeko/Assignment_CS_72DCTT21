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
        Customers_Method customers_Method;
        public Customers_Controller()
        {
            customers_Method = new Customers_Method();
        }
        public DataTable getCustomers()
        {
            return customers_Method.getCustomers();
        }
        public bool InsertCustomers(tblCustomers cts)
        {
            return customers_Method.InsertCustomers(cts);
        }
        public bool DeleteCustomers(tblCustomers cts)
        {
            return customers_Method.DeleteCustomers(cts);
        }
        public DataTable FindCustomers(string cts)
        {
            return customers_Method.FindCustomers(cts);
        }
        public bool UpdateCustomers(tblCustomers cts)
        {
            return customers_Method.UpdateCustomers(cts);
        }
        public DataTable getGioiTinh()
        {
            return customers_Method.getGioiTinh();
        }
        public DataTable ExcelCustomers(tblCustomers cts)
        {
            return customers_Method.ExcelCustomers(cts);
        }
        }
}
