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
            
            EmpData EmpModel = new EmpData();
            using (this.sql)
            {
                string query = @"SELECT *  FROM Emp_Payroll;";
                SqlCommand cmd = new SqlCommand(query, sql);
                this.sql.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        EmpModel.EmpId = reader.GetInt32(0);
                        EmpModel.Name = reader.GetString(1);
                        EmpModel.Salary =reader.GetInt64(8);
                        EmpModel.StartDate = reader.GetDateTime(3);
                        EmpModel.Gender = reader.GetString(4);
                        EmpModel.Department = reader.GetString(5);
                        EmpModel.PhoneNumber = reader.GetInt64(6);
                        EmpModel.Address = reader.GetString(7);
                        EmpModel.BasicPay = reader.GetInt64(8);
                        EmpModel.Deduction =reader.GetInt64(9);
                        EmpModel.TaxablePay = reader.GetInt64(10);
                        EmpModel.IncomeTax = reader.GetInt64(11);
                        EmpModel.NetPay = reader.GetInt64(12);
                        Console.WriteLine(" EmpId: " + EmpModel.EmpId + " Name: " + EmpModel.Name + " Salary: " + EmpModel.Salary + " Start Date: " + EmpModel.StartDate + " Gender: " + EmpModel.Gender + " PhoneNumber: " + EmpModel.PhoneNumber + " Address: " + EmpModel.Address + " Department: " + EmpModel.Department + " Basic Pay: " + EmpModel.BasicPay + " Deductios: " + EmpModel.Deduction + "Taxable Pay: " + EmpModel.TaxablePay + " Income Tax:" + EmpModel.IncomeTax + " Net Pay: " + EmpModel.NetPay);
                    }
                }
                else 
                { 
                Console.WriteLine("Data not found");
                }
                reader.Close();
                this.sql.Close();
            }

            return null;
        }

        public int UpdateData()
        {
            
                EmpData Emp = new EmpData();
           
                var query = @"UPDATE Emp_Payroll Set Salary = 4000000 where Name = 'Terissa'";
                SqlCommand cmd = new SqlCommand(query, sql);
               this.sql.Open();
               cmd.CommandType = CommandType.Text;
                
                
                cmd.Parameters.Add("Salary", SqlDbType.BigInt).Value = 4000000;
                cmd.ExecuteNonQuery();
               
                sql.Close();
                return 400000;
           
        }
        public string RetrieveDataByName()
        {
            EmpData EmpModel = new EmpData();
            var query = @"SELECT * FROM Emp_Payroll where Name = 'Ayub'";
            SqlCommand command = new SqlCommand(query, sql);

            this.sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        EmpModel.EmpId = reader.GetInt32(0);
                        EmpModel.Name = reader.GetString(1);
                        EmpModel.Salary = reader.GetInt64(8);
                        EmpModel.StartDate = reader.GetDateTime(3);
                        EmpModel.Gender = reader.GetString(4);
                        EmpModel.Department = reader.GetString(5);
                        EmpModel.PhoneNumber = reader.GetInt64(6);
                        EmpModel.Address = reader.GetString(7);
                        EmpModel.BasicPay = reader.GetInt64(8);
                        EmpModel.Deduction = reader.GetInt64(9);
                        EmpModel.TaxablePay = reader.GetInt64(10);
                        EmpModel.IncomeTax = reader.GetInt64(11);
                        EmpModel.NetPay = reader.GetInt64(12);
                        Console.WriteLine(" EmpId: " + EmpModel.EmpId + " Name: " + EmpModel.Name + " Salary: " + EmpModel.Salary + " Start Date: " + EmpModel.StartDate + " Gender: " + EmpModel.Gender + " PhoneNumber: " + EmpModel.PhoneNumber + " Address: " + EmpModel.Address + " Department: " + EmpModel.Department + " Basic Pay: " + EmpModel.BasicPay + " Deductios: " + EmpModel.Deduction + "Taxable Pay: " + EmpModel.TaxablePay + " Income Tax:" + EmpModel.IncomeTax + " Net Pay: " + EmpModel.NetPay);
                    }
                }

                else
                {
                    Console.WriteLine("data not found");
                }
                reader.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return EmpModel.Name;
        }
    }
}


