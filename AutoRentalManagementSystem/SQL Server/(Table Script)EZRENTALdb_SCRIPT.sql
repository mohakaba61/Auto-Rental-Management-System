
--select database
Use EzRentalDB
--Create CreditCardMerchant

CREATE TABLE CreditCardMerchant
(
	MerchantCode		TINYINT			PRIMARY KEY CHECK(MerchantCode>=1 AND MerchantCode<21) ,
	MerchantName		VARCHAR(50)		UNIQUE NOT NULL
);
--Create CreditCard

CREATE TABLE CreditCard
(
	CreditCardNumber				VARCHAR(16)		PRIMARY KEY,
	CreditCardOwnerName				VARCHAR(50)		NOT NULL,
	CreditCardIssuingCompagy		VARCHAR(50)		NOT NULL,	
	MerchantCode					TINYINT			NOT NULL,
	ExpDate							DATE			NOT NULL,
	AddressLine1					VARCHAR(50)		NOT NULL,
	AddressLine2					VARCHAR(50)		    NULL,
	City							VARCHAR(30)		NOT NULL,
	StateCode						CHAR(2)			NOT NULL,
	ZipCode							VARCHAR(10)		NOT NULL,
	Country							VARCHAR(100)	NOT NULL,
	CreditCardLimit					DECIMAL(6,2)	NOT NULL,
	CreditCardBalance				DECIMAL(6,2)	NOT NULL,
	ActivationStatus				BIT				NOT NULL,

	CONSTRAINT contraintForeingKey 
	FOREIGN KEY (MerchantCode)
	REFERENCES CreditCardMerchant(MerchantCode)
	ON DELETE CASCADE ON UPDATE CASCADE
);

--Create a USSTATE TABLE
CREATE TABLE USSTATE
(
	StateID				TINYINT			PRIMARY KEY CHECK(StateID>1 AND StateID<=75 ),
	StateCode2Char		CHAR(2)			UNIQUE NOT NULL,
	StateName			VARCHAR(30)		UNIQUE NOT NULL

	
);

--Create a USSTATE TABLE
CREATE TABLE COUNTRY
(
	CountryID				TINYINT				PRIMARY KEY CHECK(CountryID>1 AND CountryID<=250 ),
	CountryCode2Char		CHAR(2)				UNIQUE NOT NULL,
	CountryCode3Char		CHAR(3)				UNIQUE NOT NULL,
	CountryName				VARCHAR(100)		UNIQUE NOT NULL


);