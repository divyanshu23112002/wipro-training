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

 /*Aggregate Function */
 /*Total Number of Students */
select count(*) from students;

/* Average marks of all students */
Select avg(Marks) as AVGMARKS from students;

/* Highest Salary in Each Department */
Select Department,max(salary) as HighestSalary from employees group by Department;

/* Grade Student Based on Marks */
Select FirstName,Marks, case when Marks>=90 then 'A'
when Marks>=75 then 'B'
when Marks>=60 then 'C' else 'D' END as Grade from students;

/* Categorize Employees by Salary */
select Name, Salary, case when salary>=75000 then 'High'
when salary>=50000 then 'Medium' else 'Low' end as SalaryBand from employees;

/* Simple Transaction with commit */
Begin Transaction;
Update Employees set salary=salary+2000 where department='IT';
Commit;

/* Roollback on Mistake */
Begin Transaction;
delete from students where<60;
--Realized it's a mistake
RollBack;

/* Savepoint with Rollback To */
Begin Transaction;
Update Employees set salary=salary+1000 where EmpID=1;
save Transaction increaseJohn;
Update employees set salary=salary+1000 where EmpID=2;
--oops,Rollback second increament only
Rollback Transaction increaseJohn;
commit;


/* Over() Clause Basics
Over() -- defines the "Window " over which function operates.
what are window function ?
Window function perform calculations accross a set of rows(a window) related to the current row without collapsing rows like GROUP BY. */
Select Name,department,salary avg(salary) over() as AVGSALARY from emloyees;  -- calculate average of all rows
