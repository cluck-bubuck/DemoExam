use Terna_SportShop
go

--OrderProduct
insert into OrderProduct([order_id], [product_article], [orderProd_count])
select [����� ������], [������], [������]
from [dbo].[Order$]

--Order
/*
insert into [Order]([order_startdate], [order_enddate], [point_id], [user_id], [order_code], [order_status])
select [���� ������], [���� ��������], [����� ������], [��� �������], [��� ��� ���������], [������ ������]
from Order$
*/

--Point Of Issue
/*
insert into [dbo].[PointOfIssue]( [point_index], [point_city], [point_street], [point_streetNumb])
select p.[������], p.[�����], p.[�����], p.[����� �����]
from Point$ p
*/

--Users
/*
insert into Users([user_name], [user_surname], [user_patronymic], [user_login], [user_pass], [role_id])
select us.[�], us.[���], us.[�], us.[�����], us.[������], us.[���� ����������]
from Users1$ us
*/

/*
SELECT TOP (1000) 
      [user_name]
      ,[user_surname]
      ,[user_patronymic]
      ,[user_login]
      ,[user_pass]
      ,[role_id]

	  -- ���������� ������ �� �������� �������
	  into #T
  FROM [Terna_SportShop].[dbo].[Users]
  --����������� ������ � ���������� ���������
  truncate table [Terna_SportShop].[dbo].[Users]
  --��������� ������ �� �������� ������� � ��������
  insert INTO [Terna_SportShop].[dbo].[Users]
  (     
      [user_name]
      ,[user_surname]
      ,[user_patronymic]
      ,[user_login]
      ,[user_pass]
      ,[role_id]
)
	  select 
      [user_name]
      ,[user_surname]
      ,[user_patronymic]
      ,[user_login]
      ,[user_pass]
      ,[role_id]

	  from #T
	  --������� ���������(?)
  Drop Table #T
*/