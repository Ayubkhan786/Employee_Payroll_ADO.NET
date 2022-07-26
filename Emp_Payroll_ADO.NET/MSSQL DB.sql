CREATE DATABASE Payroll_Service


SELECT Name
FROM sys.databases;

USE Payroll_Service


CREATE TABLE Emp_Payroll
(
	EmpId		INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Name	    VARCHAR (150) NOT NULL,
	Salary	    float NOT NULL ,
	StartDate    Date NOT NULL
);

SELECT * FROM Emp_Payroll

INSERT INTO Emp_Payroll([Name] , [Salary] , [StartDate] )
Values ('Ayub ', 100000 ,'10/11/2019'),('Vijay' , 500000 , '12/10/2015'),('Abhishek' , 200000 , '10/06/2021')


SELECT * FROM Emp_Payroll

SELECT Salary FROM Emp_Payroll
WHERE Name = 'Ayub'

SELECT Salary FROM Emp_Payroll
WHERE StartDate BETWEEN CAST('2015/10/12'AS date) AND ('2019/11/10');


ALTER TABLE Emp_Payroll ADD Gender varchar(6);

UPDATE Emp_payroll set Gender ='Male' 
Where Name = 'Ayub' or Name='Vijay' or Name='Abhishek';

SELECT * FROM Emp_Payroll


INSERT INTO Emp_Payroll([Name] , [Salary] , [StartDate] )
Values ('Shree ', 1500000 ,'10/01/2018'),('Kalpana' , 800000 , '11/03/2012'),('Abi' , 2500000 , '01/09/2017')

UPDATE Emp_payroll set Gender ='Female' 
Where Name = 'Shree' or Name='Kalpana' or Name='Abi';

SELECT * FROM Emp_Payroll
 
SELECT SUM (Salary) AS TotalSalaryOfMale FROM Emp_Payroll Where Gender = 'Male'; 
SELECT AVG (Salary) AS AvgSalaryOfMale FROM Emp_Payroll Where Gender = 'Male'; 
SELECT MIN (Salary)  AS MinSalaryOfMale FROM Emp_Payroll Where Gender = 'Male'; 
SELECT MAX (Salary)  AS MaxSalaryOfMale FROM Emp_Payroll Where Gender = 'Male';  
SELECT COUNT (Salary) AS TotalCountOfMale FROM Emp_Payroll Where Gender ='Male';
SELECT SUM (Salary) AS TotalSalaryOfFemale FROM Emp_Payroll Where Gender = 'Female'; 
SELECT AVG (Salary)  AS AvgSalaryOfFemale FROM Emp_Payroll Where Gender = 'Female'; 
SELECT MIN (Salary) AS MinSalaryOfFemale FROM Emp_Payroll Where Gender = 'Female'; 
SELECT MAX (Salary) AS MaxSalaryOfFemale FROM Emp_Payroll Where Gender = 'Female';  
SELECT COUNT (Salary)  AS TotalCountOfFemale FROM Emp_Payroll Where Gender ='Female';



ALTER TABLE Emp_Payroll 
ADD PhoneNumber float;

ALTER TABLE Emp_Payroll 
ADD Address varchar(300) ;

ALTER TABLE Emp_Payroll 
ADD Department varchar(250) NOT NULL ;

SELECT * FROM Emp_Payroll

UPDATE Emp_Payroll Set PhoneNumber = 8445412318 , Address = 'India' , Department = 'Engineering' where EmpId = 1 ;
UPDATE Emp_Payroll Set PhoneNumber = 8897561234 , Address = 'India' , Department = 'Research' where EmpId = 2;


ALTER TABLE Emp_Payroll ADD BasicPay BIgInt , Deductions BigInt , TaxablePay BigInt ,IncomeTax BigInt ,NetPay BigInt;
UPDATE Emp_Payroll Set BasicPay = 10000 , Deductions = 500 , TaxablePay = 2000 , IncomeTax = 1000 , NetPay = 10500 WHERE Name = 'Ayub' OR Name='Vijay';

SELECT * FROM Emp_Payroll

INSERT INTO Emp_Payroll([Name] ,[Salary] ,[StartDate] ,[Department] ,[Gender] )
Values ('Terissa', 135000,'12-12-2020' ,'Marketing' , 'Female');

SELECT * FROM Emp_Payroll

Update Emp_Payroll Set BasicPay = 5000 , Deductions = 1000 ,TaxablePay = 500, IncomeTax = 1000, NetPay = 20000 Where EmpId = 11; 
Update Emp_Payroll Set PhoneNumber = 8565456740 Where EmpId = 11 ;

SELECT * FROM Emp_Payroll