using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Emp_Payroll_ADO.NET
{
    public class Connection
    {
        const string ConnectionString = @"Data Source=.;Initial Catalog=Payroll_Service;Integrated Security=True";
        SqlConnection sql = new SqlConnection(ConnectionString);
        public string RetrieveEmpData()
        {
            try
            {
                EmpData EmpModel = new EmpData();
                using (this.sql)
                {
                    string query = @"SELECT EmpId , Name ,Salary , StartDate , Gender ,Department, PhoneNumber,Address ,BasicPay , Deductions ,TaxablePay , IncomeTax ,NetPay  FROM Emp_Payroll;";
                    SqlCommand cmd = new SqlCommand(query, sql);
                    this.sql.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            EmpModel.EmpId = reader.GetInt32(0);
                            EmpModel.Name = reader.GetString(1);
                            EmpModel.Salary = reader.GetDouble(2);
                            EmpModel.StartDate = reader.GetDateTime(3);
                            EmpModel.Gender = Convert.ToChar(reader.GetString(4));
                            EmpModel.Department = reader.GetString(5);
                            EmpModel.PhoneNumber = Convert.ToDouble(reader.GetInt64(6));
                            EmpModel.Address = reader.GetString(7);
                            EmpModel.BasicPay = Convert.ToDouble(reader.GetInt64(8));
                            EmpModel.Deduction = Convert.ToDouble(reader.GetInt64(9));
                            EmpModel.TaxablePay = Convert.ToDouble(reader.GetInt64(10));
                            EmpModel.IncomeTax = Convert.ToDouble(reader.GetInt64(11));
                            EmpModel.NetPay = Convert.ToDouble(reader.GetInt64(12));
                            Console.WriteLine(" EmpId: " + EmpModel.EmpId + " Name: " + EmpModel.Name + " Salary: " + EmpModel.Salary + " Start Date: " + EmpModel.StartDate + " Gender: " + EmpModel.Gender + " PhoneNumber: " + EmpModel.PhoneNumber+ " Address: " + EmpModel.Address + " Department: " + EmpModel.Department + " Basic Pay: " + EmpModel.BasicPay+ " Deductios: " + EmpModel.Deduction + "Taxable Pay: " + EmpModel.TaxablePay + " Income Tax:" + EmpModel.IncomeTax + " Net Pay: " + EmpModel.NetPay);
                        }
                    }
                    Console.WriteLine("Data not found");
                    reader.Close();
                    this.sql.Close();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return null;
        }
    }
}

