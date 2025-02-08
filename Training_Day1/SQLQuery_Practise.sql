use sqlpractice1;

select *from INFORMATION_SCHEMA.tables;


select *from Emp;

select Empno,nam,dept,basic from Emp;

select *from Emp where dept='Java';

select  *from Emp where Empno=1;

select *from Emp where basic<90000;

select *from Emp where basic between 80000 and 90000;

select *from emp where nam in('Mano','Swapna','kiran');

select *from emp where nam like 's%';

select *from emp where nam like '%a';

select *from emp where nam like 's%%a';

select *from emp order by nam desc;

select *from emp order by nam desc,basic ;

select *from Agent;

select AgentID, FullName, Gender , MaritalStatus from Agent;

select AgentID,FullName, Gender, MaritalStatus,
Case MaritalStatus
when 0 then 'Unmarried'
when 1 then 'Married'
End 'Status'
from Agent;

select *from policy;

select PolicyID, AppNumber, AnnualPremium, PayMentModelID from policy;

select PolicyID,AppNumber, AnnualPremium,PayMentModelID,
Case PaymentModelID
when 0 then 'un-paid'
when 1 then 'half-paid'
when 2 then 'full-paid'
when 3 then 'no-status'
End 'Payment_Status'
from policy;

/* Number Functions */

select abs(-15);

select round(15.522224,2);

select sqrt(81);

select power(2,3);

select ceiling(14.52);

select floor(14.52);

select charindex('l','hello');

select reverse('piuy');

select len('Shiva');

select len('Ram');

select left('Kailash',3);

select right('Kailash',4);

select *from agent;

select FirstName from agent;

select FirstName, left(FirstName,3)  from agent;

select FirstName , right(FirstName,4) from agent;

select FirstName,reverse(FirstName) from agent;

select FirstName , lower(FirstName) lower_values , upper(FirstName) upper_values from agent;

select substring(Firstname,3,5) from agent;


/*Aggregate Functions */

select *from agent;

select *from emp;

select sum(basic) from emp;

select avg(basic) from emp;

select max(basic) from emp;

select min(basic) from emp;

select count(*) from emp;

/*Date Functions*/

select getdate();

select convert(varchar,getdate(),103); /*Date Month Year*/


/*Group By*/

select *from emp;

select Dept,sum(basic) from emp group by dept;

select desig , sum(basic) from emp group by desig;

select desig, sum(basic) from emp group by desig having sum(basic)>100000;


select dept, sum(basic) sum_total from emp group by dept having sum(basic)>100000;
