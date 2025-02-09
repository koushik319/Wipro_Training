use sqlpractice1;

select * from Agent;
select * from AgentPolicy;

select AgentId,FirstName, Gender , MaritalStatus from Agent;

select AgentId,PolicyId from AgentPolicy;

/*Joins*/

/* INNER JOIN */

select A.AgentId,FirstName,Gender, MAritalStatus, Ap.PolicyID
from Agent as A INNER JOIN AgentPolicy as Ap
ON A.AgentId=AP.AgentID

/* LEFT JOIN */

select A.AgentId, FirstName,Gender,MaritalStatus,Ap.PolicyID
from Agent as A LEFT JOIN AgentPolicy as Ap
ON A.AgentID= AP.AgentID


/* RIGHT JOIN */

select A.AgentId, FirstName, Gender, MaritalStatus , Ap.PolicyId 
from Agent as A RIGHT JOIN AgentPolicy as Ap
ON A.AgentID = AP.AgentID

/* FULL JOIN */

select A.AgentId,FirstName, Gender , MaritalStatus , Ap.PolicyId 
from Agent as A FULL JOIN AgentPolicy as Ap
ON A.AgentID= Ap.AgentID

/* CROSS JOIN */

select A.AgentId, FirstName, Gender, MaritalStatus , Ap.PolicyId 
from Agent as A CROSS JOIN AgentPolicy as Ap
