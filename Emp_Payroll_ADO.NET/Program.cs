using Emp_Payroll_ADO.NET;

Console.WriteLine("Welcome to Employee Payroll");




//Connection con= new Connection();
////string Data = con.RetrieveEmpData();
////Console.WriteLine(Data);
////long Update = con.UpdateData();
////Console.WriteLine(Update);

////string Data = con.RetrieveDataByName();
////Console.WriteLine(Data);


//string Data = con.RetrieveFromDate();
//Console.WriteLine(Data);


Salary salary = new Salary();
salary.SumofMale();
salary.SumofFemale();
salary.AvgofMale();
salary.AvgofFemale();
salary.MinofMale();
salary.MinofFemale();
salary.MaxofMale();
salary.MaxofFemale();
salary.CountofMale();
salary.CountofFemale();