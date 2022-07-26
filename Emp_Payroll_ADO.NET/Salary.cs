using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Emp_Payroll_ADO.NET
{
    public class Salary
    {
        const string ConnectionString = @"Data Source=.;Initial Catalog=Payroll_Service;Integrated Security=True";
        SqlConnection sql = new SqlConnection(ConnectionString);
        public double SumofMale()
        {
            EmpData Emp = new EmpData();
            var query = @"SELECT SUM (Salary) FROM Emp_Payroll Where Gender = 'Male'";
            SqlCommand command = new SqlCommand(query, sql);
            this.sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Emp.Salary = reader.GetInt64(0);
                        Console.WriteLine("Total salary of Male Employees: " + Emp.Salary);
                    }
                }
                reader.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Emp.Salary;
        }
        public double SumofFemale()
        {
            EmpData Emp = new EmpData();
            var query = @"SELECT SUM (Salary) FROM Emp_Payroll Where Gender = 'Female'";
            SqlCommand command = new SqlCommand(query, sql);
            this.sql.Open();
            SqlDataReader read = command.ExecuteReader();
            try
            {
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        Emp.Salary = read.GetInt64(0);
                        Console.WriteLine("Total salary of Female Employees: " + Emp.Salary);
                    }
                }
                read.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Emp.Salary;
        }
        public double AvgofMale()
        {
            EmpData Emp = new EmpData();
            var query = @"SELECT AVG (Salary) FROM Emp_Payroll Where Gender = 'Male'";
            SqlCommand command = new SqlCommand(query, sql);
            sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Emp.Salary = reader.GetInt64(0);
                        Console.WriteLine("Average salary of male Employee: " + Emp.Salary);
                    }
                }
                reader.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Emp.Salary;
        }
        public double AvgofFemale()
        {
            EmpData Emp = new EmpData();
            var query = @"SELECT AVG (Salary) FROM Emp_Payroll Where Gender = 'Female'";
            SqlCommand command = new SqlCommand(query, sql);
            this.sql.Open();
            SqlDataReader read = command.ExecuteReader();
            try
            {
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        Emp.Salary = read.GetInt64(0);
                        Console.WriteLine("Average salary of Female Employee: " + Emp.Salary);
                    }
                }
                read.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Emp.Salary;
        }
        public double MinofMale()
        {
            EmpData Emp = new EmpData();
            var query = @"SELECT MIN (Salary) FROM Emp_Payroll Where Gender = 'Male'";
            SqlCommand command = new SqlCommand(query, sql);
            sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Emp.Salary = reader.GetInt64(0);
                        Console.WriteLine("Minimum salary of male Employee: " + Emp.Salary);
                    }
                }
                reader.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Emp.Salary;
        }
        public double MinofFemale()
        {
            EmpData Emp = new EmpData();
            var query = @"SELECT MIN (Salary) FROM Emp_Payroll Where Gender = 'Female'";
            SqlCommand command = new SqlCommand(query, sql);
            this.sql.Open();
            SqlDataReader read = command.ExecuteReader();
            try
            {
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        Emp.Salary = read.GetInt64(0);
                        Console.WriteLine("Minimum salary of Female Employee: " + Emp.Salary);
                    }
                }
                read.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Emp.Salary;
        }
        public double MaxofMale()
        {
            EmpData Emp = new EmpData();
            var query = @"SELECT MAX (Salary) FROM Emp_Payroll Where Gender = 'Male'";
            SqlCommand command = new SqlCommand(query, sql);
            sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Emp.Salary = reader.GetInt64(0);
                        Console.WriteLine("Maximum salary of male Employee: " + Emp.Salary);
                    }
                }
                reader.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Emp.Salary;
        }
        public double MaxofFemale()
        {
            EmpData Emp = new EmpData();
            var query = @"SELECT MAX (Salary) FROM Emp_Payroll Where Gender = 'Female'";
            SqlCommand command = new SqlCommand(query, sql);
            try
            {
                this.sql.Open();
                SqlDataReader read = command.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        Emp.Salary = read.GetInt64(0);
                        Console.WriteLine("Maximum salary of Female Employee: " + Emp.Salary);
                    }
                }
                read.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Emp.Salary;
        }
        public void CountofMale()
        {
            EmpData employeeData = new EmpData();
            var query = @"SELECT COUNT (EmpId) FROM Emp_Payroll Where Gender = 'Male'";
            SqlCommand command = new SqlCommand(query, sql);
            sql.Open();
            try
            {
                int count = (int)command.ExecuteScalar();
                Console.WriteLine("Number of Male employees: " + count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            sql.Close();
        }
        public void CountofFemale()
        {
            EmpData Emp = new EmpData();
            var query = @"SELECT COUNT (EmpId) FROM Emp_Payroll Where Gender = 'Female'";
            SqlCommand command = new SqlCommand(query, sql);
            this.sql.Open();
            try
            {
                int count = (int)command.ExecuteScalar();
                Console.WriteLine("Number of Female employees: " + count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            sql.Close();
        }
    }
}