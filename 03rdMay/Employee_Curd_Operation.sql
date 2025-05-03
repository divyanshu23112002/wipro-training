//my first file in sql

create table Employees(
EmployeeID int primary key,
FirstName varchar(50),
LastName varchar(50),
Department varchar(50),
salary decimal(10,2),
HireDate date
);

Insert into Employees(EmployeeID,
FirstName,
LastName,
Department,
salary,
HireDate)

values
(1,'Rajan','Kumar','Biology',45087.45,'2023-11-22'),
(2,'Santosh','Kumar','Chemistry',49087.40,'2021-01-12'),
(3,'Ajay','Verma','Mathematics',50087.50,'2022-02-02');


select * from emloyees; 

select firstname, department from employees where salary>47000;

select firstname,salary from employees  where department='Mathematics';

select firstname,LastName from employees  where HireDate='2022-02-02';
