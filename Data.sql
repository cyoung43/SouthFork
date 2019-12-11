CREATE TABLE [dbo].[Project] (
	[ProjectID]		INT			IDENTITY (1, 1) NOT NULL,
	[ProjectName]	VARCHAR(100) 	NOT NULL,
	[BudgetedHours]	INT 			NOT NULL,
	[ActualHours]	INT 			NULL,
	[BudgetedDays]	INT 			NULL,
	[ActualDays]	INT 			NULL,
	[DepositDate]	DATE 			NULL,
	[BeginDate]		DATE 			NULL,
	[CompleteDate]	DATE	 		NULL,
	[PayDate]		DATE	 		NULL,
	[DeliverDate]	DATE	 		NULL,
	[ProjectPrice]	INT 			NULL,
	[BidPrice]		INT 			NULL,
	[ClientPaid]	VARCHAR(5) 		NULL,
	[SquareFootage]	INT 			NULL,
	[BuilderID]		INT 			NULL,
	[EmployeeID]	INT 			NULL,
	[ClientID]		INT 			NULL,
	PRIMARY KEY CLUSTERED ([ProjectID] ASC)
);

CREATE TABLE [dbo].[Employee] (
	[EmployeeID]	INT		IDENTITY (1, 1) NOT NULL,
	[FirstName]		VARCHAR(25) NOT NULL,
	[LastName]		VARCHAR(25) NOT NULL,
	[Email]			VARCHAR(50) NOT NULL,
	[Phone]			VARCHAR(15) NOT NULL,
	[Wage]			INT NOT NULL,
	[Password]		VARCHAR(25) NOT NULL,
	[PositionID]	INT NULL,
	PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
);

CREATE TABLE [dbo].[Position] (
	[PositionID]	INT		IDENTITY (1, 1) NOT NULL,
	[PositionName]	VARCHAR(15) NOT NULL,
	PRIMARY KEY CLUSTERED ([PositionID] ASC)
);

CREATE TABLE [dbo].[Client] (
	[ClientID]		INT		IDENTITY (1, 1) NOT NULL,
	[FirstName]		VARCHAR(25) NOT NULL,
	[LastName]		VARCHAR(25) NOT NULL,
	[Email]			VARCHAR(50) NOT NULL,
	[Phone]			VARCHAR(15) NOT NULL,
	[Address]		VARCHAR(50) NOT NULL,
	[City]			VARCHAR(20) NOT NULL,
	[State]			VARCHAR(2) NOT NULL,
	[Zip]			VARCHAR(5) NOT NULL,
	[Notes]	VARCHAR(100) NULL,
	PRIMARY KEY CLUSTERED ([ClientID] ASC)
);

CREATE TABLE [dbo].[Builder] (
	[BuilderID]		INT		IDENTITY (1, 1) NOT NULL,
	[CompanyName]	VARCHAR(30) NOT NULL,
	PRIMARY KEY CLUSTERED ([BuilderID] ASC)
);