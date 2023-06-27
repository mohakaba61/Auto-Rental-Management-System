SELECT * FROM CreditCardMerchant;

--Inserting records in the CreditCardMerchant Table

insert into CreditCardMerchant(MerchantCode,MerchantName)
values('1','PayPal');

insert into CreditCardMerchant(MerchantCode,MerchantName)
values('2','Alphabet');
insert into CreditCardMerchant(MerchantCode,MerchantName)
values('4','Zelle');
insert into CreditCardMerchant(MerchantCode,MerchantName)
values('3','CashApp');
insert into CreditCardMerchant(MerchantCode,MerchantName)
values('5','ABC');
insert into CreditCardMerchant(MerchantCode,MerchantName)
values('7','Alphabet');
insert into CreditCardMerchant(MerchantCode,MerchantName)
values('8','Block');



--Inserting records in the CreditCard Table


insert into CreditCard(CreditCardNumber,CreditCardOwnerName,CreditCardIssuingCompagy,MerchantCode,ExpDate,AddressLine1,
AddressLine2,City,StateCode,ZipCode,Country,CreditCardLimit,CreditCardBalance,ActivationStatus)
values(1235894985613446,'Jake Paul','Clover',5,'01/09/24','14 ST','Apt 1','New York City','NY','11102','USA',1500.00,100.00,1);
insert into
CreditCard(CreditCardNumber,CreditCardOwnerName,CreditCardIssuingCompagy,MerchantCode,ExpDate,AddressLine1,
AddressLine2,City,StateCode,ZipCode,Country,CreditCardLimit,CreditCardBalance,ActivationStatus)
values(2486543594210024,'Diallo Ibrahima','PayPal',2,'01/12/26','Saint Park','Apt 8','Philadelphia','PA','11002','USA',2500,980.00,1);

insert into
CreditCard(CreditCardNumber,CreditCardOwnerName,CreditCardIssuingCompagy,MerchantCode,ExpDate,AddressLine1,
AddressLine2,City,StateCode,ZipCode,Country,CreditCardLimit,CreditCardBalance,ActivationStatus)
values(6543259786214586,'Adam Eve','Google',3,'03/03/25','123 ST','Apt 5', 'Newark', 'NJ','10102','USA',1990.00,55.00,1);

insert into
CreditCard(CreditCardNumber,CreditCardOwnerName,CreditCardIssuingCompagy,MerchantCode,ExpDate,AddressLine1,
AddressLine2,City,StateCode,ZipCode,Country,CreditCardLimit,CreditCardBalance,ActivationStatus)
values(9865325698745126,'Lionel Messi','Amazon',1,'05/29/24','49 ST','Apt 1b','Calgary','AB','16485','Canada',5000.00,785,1);

insert into
CreditCard(CreditCardNumber,CreditCardOwnerName,CreditCardIssuingCompagy,MerchantCode,ExpDate,AddressLine1,
AddressLine2,City,StateCode,ZipCode,Country,CreditCardLimit,CreditCardBalance,ActivationStatus)
values(4865236589745126,'Cristiano Ronaldo','Discover',4,'4/01/26','838 Malcom ','Apt 7','Vancouver','BC','10458','Canada',4500.00,500.00,1);
insert into
CreditCard(CreditCardNumber,CreditCardOwnerName,CreditCardIssuingCompagy,MerchantCode,ExpDate,AddressLine1,
AddressLine2,City,StateCode,ZipCode,Country,CreditCardLimit,CreditCardBalance,ActivationStatus)
values(4579546889542345,'Sergio Ramos','Discover',7,'8/06/29','87 Columbus ','Apt 9','New York City','NY','10056','USA',5500.00,1000.00,1);



SELECT * FROM CreditCardMerchant;


SELECT * FROM CreditCard;

SELECT * FROM CreditCard WHERE MerchantCode=5;


SELECT CreditCard.CreditCardOwnerName,CreditCard.CreditCardLimit, CreditCardMerchant.MerchantName, CreditCard.AddressLine1,CreditCard.ExpDate
FROM CreditCard,CreditCardMerchant WHERE CreditCardMerchant.MerchantCode=CreditCard.MerchantCode AND Country='USA' ;

--Update Statement
SELECT * FROM CreditCard WHERE ZipCode=11102;

UPDATE CreditCard 
SET CreditCardOwnerName='Thiago Messi',
	CreditCardBalance=200.00,
	CreditCardIssuingCompagy='Barclays',
	CreditCardNumber=7845798784514623,
	ExpDate='11/18/27',
	AddressLine1='45 Malcom x',
	ZipCode=20045,
	ActivationStatus=0
	WHERE ZipCode=11102;



	-- Update statement
SELECT * FROM CreditCard WHERE MerchantCode=5;

UPDATE CreditCard
	SET MerchantCode= 8
	WHERE MerchantCode=5;

	SELECT * FROM CreditCard WHERE MerchantCode=8;


	-- Delete statement 1
SELECT * FROM CreditCard;

DELETE
FROM CreditCard
WHERE MerchantCode=3;

SELECT * FROM CreditCard;

	-- Delete statement 2
	--Now we have to delete a record in the CreditCardMerchant Table

	SELECT * FROM CreditCardMerchant;

	DELETE
FROM CreditCardMerchant
WHERE MerchantCode=7;

SELECT * FROM CreditCardMerchant;

Select * from COUNTRY