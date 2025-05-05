Create table students(
    studentId int primary key,
    FirstName varchar(50),
    Marks INT,
    DOB Date
);

Insert into students(studentId,FirstName,Marks,DOB) values
(1,'Amit',92,'2003-05-10'),
(2,'Neha',78,'2002-11-15'),
(3,'Rahul',61,'2004-01-20'),
(4,'Sneha',49,'2003-09-01');


Create table employees(
    EmpID int primary key,
    Name varchar(50),
    Department varchar(50),
    salary decimal(10,2),
    JoinDate Date
);

Insert into Employees(EmpID,Name,Department,salary,JoinDate) values
(1,'John','HR',50000,'2021-06-01'),
(2,'Priya','Finance',60000,'2020-09-15'),
(3,'Amit','IT',75000,'2019-01-10'),
(4,'Sara','IT',72000,'2023-02-25');


/* Scaler Function */
/* Convert Student Names into UpperCase */ 
Select FirstName, upper(FirstName) as UPPERNME from students;

/* Get Age of Each Student */
Select FirstName, DATEDIFF(YEAR,DOB,GETDATE()) as AGE from students;

/* Rounded off Salary to Nearest 1000 */
Select Name,Round(salary,-3) as RoundedSalary from employees;