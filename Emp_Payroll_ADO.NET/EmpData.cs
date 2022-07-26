using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Emp_Payroll_ADO.NET
{
    public class EmpData
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime StartDate { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        public long BasicPay { get; set; }
        public long Deduction { get; set; }
        public long TaxablePay { get; set; }
        public long IncomeTax { get; set; }
        public long NetPay { get; set; }
    }
}


