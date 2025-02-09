use sqlpractice1


/*Transat SQL (T-SQL)*/

declare @age Int;
set @age=18;
print @age;

declare @name varchar(20)
set @name='Shiva'
print @name;

declare @carname varchar(20)
set @carname='BMW'
print 'The Car Name is '+@carname


declare 
     @firstnumber int=15,
	 @secondnumber int=13,
	 @result int
begin
 set @result = @firstnumber+@secondnumber
 print 'the sum of 2 numbers is '
 print @result

 set @result = @firstnumber-@secondnumber
 print 'Subtraction of numbers is :'
 print @result

 set @result=@firstnumber*@secondnumber
 print 'The Multiplication of 2 numbers is'
 print @result

end


declare  @totalcount INT
begin
  select @totalcount =count(*) from Emp;
  print @totalcount
end

