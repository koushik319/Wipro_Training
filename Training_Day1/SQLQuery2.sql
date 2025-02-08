use sqlpractice1
GO

select * from INFORMATION_SCHEMA.TABLES
go

sp_help Emp
GO

select * from Emp;
GO

select Empno, nam, dept from Emp
GO

select * from Emp where dept= 'Java'
GO

select * from Emp where basic>50000
GO

select *from emp where basic between 40000 and 50000
go

select *from Emp where nam in('kiran','kalyan','satish')
GO

select * from Emp where nam like 's%'
GO

select *from Emp where nam like '%a'
GO

select *from Emp order by Empno
GO

select *from Emp order by nam DESC
GO

select *from Emp order by dept,basic 
Go