select * from INFORMATION_SCHEMA.Tables
GO

select *from Agent
GO

select AgentID, FirstName,MaritalStatus from Agent
Go

select AgentID,FirstName,MaritalStatus,
CASE MaritalStatus
    when 0 then 'unmarried'
	when 1 then 'married'
End 'marital'
from Agent 
GO

select *from policy
go

select PolicyID, PolicyNumber,AnnualPremium,PayMentModelID from policy
go

select PolicyID, PolicyNumber,AnnualPremium,PayMentModelID,
CASE PayMentModelID
   when 1 then 'half paid'
   when 2 then 'full-paid'
   when 3 then 'all-paid'
END 'status_payment'
from policy 
GO