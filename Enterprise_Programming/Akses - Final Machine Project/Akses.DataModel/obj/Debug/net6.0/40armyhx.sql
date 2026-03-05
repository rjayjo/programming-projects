CREATE TABLE [ExpensesTbl] (
    [MonthAndYear] nvarchar(450) NOT NULL,
    [RestockTotalPrice] int NOT NULL,
    [ElectricityBill] int NOT NULL,
    [WaterBill] int NOT NULL,
    [WorkersSalaries] int NOT NULL,
    CONSTRAINT [PK_ExpensesTbl] PRIMARY KEY ([MonthAndYear])
);
GO


CREATE TABLE [MedicineINV] (
    [MedicineID] int NOT NULL IDENTITY,
    [MedicineName] int NOT NULL,
    [MFGDate] nvarchar(max) NOT NULL,
    [ExpiryDate] nvarchar(max) NOT NULL,
    [Price] int NOT NULL,
    CONSTRAINT [PK_MedicineINV] PRIMARY KEY ([MedicineID])
);
GO


CREATE TABLE [MedicineRequestTbl] (
    [RequestID] int NOT NULL IDENTITY,
    [Request] nvarchar(max) NOT NULL,
    [Quantity] nvarchar(max) NOT NULL,
    [NameOfRequester] nvarchar(max) NOT NULL,
    [DateRequested] datetime2 NOT NULL,
    [DateNeeded] datetime2 NOT NULL,
    [ContactNoOfRequester] int NOT NULL,
    CONSTRAINT [PK_MedicineRequestTbl] PRIMARY KEY ([RequestID])
);
GO


CREATE TABLE [SalesTbl] (
    [EntryID] int NOT NULL IDENTITY,
    [MedicineName] int NOT NULL,
    [Price] int NOT NULL,
    [Quantity] int NOT NULL,
    [Amount] int NOT NULL,
    [DateOrdered] datetime2 NOT NULL,
    CONSTRAINT [PK_SalesTbl] PRIMARY KEY ([EntryID])
);
GO


