using Emp_Payroll_ADO.NET;

Console.WriteLine("Welcome to Employee Payroll");




Connection con= new Connection();
string Data = con.RetrieveEmpData();
Console.WriteLine(Data);