use Terna_SportShop
go

--OrderProduct
insert into OrderProduct([order_id], [product_article], [orderProd_count])
select [Номер заказа], [Состав], [заказа]
from [dbo].[Order$]

--Order
/*
insert into [Order]([order_startdate], [order_enddate], [point_id], [user_id], [order_code], [order_status])
select [Дата заказа], [Дата доставки], [Пункт выдачи], [ФИО клиента], [Код для получения], [Статус заказа]
from Order$
*/

--Point Of Issue
/*
insert into [dbo].[PointOfIssue]( [point_index], [point_city], [point_street], [point_streetNumb])
select p.[Индекс], p.[город], p.[улица], p.[номер улицы]
from Point$ p
*/

--Users
/*
insert into Users([user_name], [user_surname], [user_patronymic], [user_login], [user_pass], [role_id])
select us.[И], us.[ФИО], us.[О], us.[Логин], us.[Пароль], us.[Роль сотрудника]
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

	  -- засовываем данные во временую таблицу
	  into #T
  FROM [Terna_SportShop].[dbo].[Users]
  --пересоздаем данные с обнулением айдишника
  truncate table [Terna_SportShop].[dbo].[Users]
  --вставляем данные из временой таблицы в основную
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
	  --удаляем временную(?)
  Drop Table #T
*/