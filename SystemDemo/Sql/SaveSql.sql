create table Sys_Employee
(
Emp_Id varchar(50) primary key,
Emp_Name nvarchar(200) null,
Emp_UserId varchar(50) null,
Emp_Password varchar(50) null,
Emp_Eamil nvarchar(50) null,
Emp_Phone varchar(50) null,
Emp_Address nvarchar(200) null,
Emp_CreateDate datetime null,
)

create table Sys_Menu
(
Menu_Id varchar(50) primary key,
Menu_Child_Id varchar(50) null,
Menu_Title varchar(50) null,
)

