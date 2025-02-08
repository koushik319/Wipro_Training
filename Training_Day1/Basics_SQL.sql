create database demopractise;
GO

create table cars
(
	 Id int Primary key , 
	 CarName Varchar(20),
	 Model varchar(20),
	 Types varchar(20)
);

insert into cars values(1,'Mustang','GT','SUV');
insert into cars values(2,'Audi','A5','Compact');

select *from cars;

create table bikes
( 
  Id int Primary key , 
  BikeName Varchar(20),
  Model Varchar(15),
  Number int
);

insert into bikes values(1,'BMW','GT',9312);
insert into bikes values(2,'Royal-Enfield','GT-650',1515);


select *from bikes;

create table demo(
Id int , 
nam varchar(20)
)

select *from demo

insert into demo values(1,'wsd');
insert into demo values(2,'opl');
insert into demo values(3,'poi');

delete from demo where id=1;

drop table demo;

/* DDL Commands */
create table books
(
  Id int primary key,
  Bookname varchar(20),
  Descriptio varchar(20),
  Code varchar(20)
);

alter table books add uniquenumber int;

select *from books;

/*DML*/

insert into books values(1,'Pirates','Novel','A',1433);
insert into books values(2,'Sherla','Nov','B',1235);

update books set Bookname='Sherlacomes' where Bookname='Sherla'

delete from books where id=2;

update books set Bookname='Carebian Pirates' where Bookname='Pirates'

update books set Code='A+' where id=1;

update books set Descriptio='Thriller' where id=2; 

select *from books;
insert into books values(3,'ass','fdd','q1',1278);

delete from books where id=3;