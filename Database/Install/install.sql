CREATE DATABASE PotionShoppe;
USE PotionShoppe;
CREATE TABLE [EmployeePosition] ([EmployeePositionId] int, [Title] varchar);
CREATE TABLE [EmployeeStatus] ([EmployeeStatusId] int, [Title] varchar);
CREATE TABLE [Employee] (
    [EmployeeId] int,
    [Username] varchar,
    [Password] varchar,
    [Name] varchar,
    [EmployeeStatusId] int,
    [PositionId] int,
    CONSTRAINT [FK_Employee.PositionId] FOREIGN KEY ([PositionId]) REFERENCES [EmployeePosition]([EmployeePositionId]),
    CONSTRAINT [FK_Employee.EmployeeStatusId] FOREIGN KEY ([EmployeeStatusId]) REFERENCES [EmployeeStatus]([EmployeeStatusId])
);
CREATE TABLE [Customer] (
    [CustomerId] int,
    [Username] varchar,
    [Password] varchar,
    [Name] varchar
);
CREATE TABLE [PotionEffect] (
    [PotionEffectId] int,
    [PotionId] int,
    [EffectId] int
);
CREATE TABLE [Effect] (
    [EffectId] int,
    [Value] int,
    [Duration] int,
    [Description] varchar,
    CONSTRAINT [FK_Effect.EffectId] FOREIGN KEY ([EffectId]) REFERENCES [PotionEffect]([EffectId])
);
CREATE TABLE [Ingredient] (
    [IngredientId] int,
    [Name] varchar,
    [Description] varchar,
    [Price] int,
    [Cost] int,
    [CurrentStock] int,
    [Image] int,
    [EffectId] int
);
CREATE TABLE [OrderStatus] ([OrderStatusId] int, [Title] varchar);
CREATE TABLE [Receipt] (
    [ReceiptId] int,
    [ReceiptNumber] varchar,
    [EmployeeId] int,
    [OrderId] int,
    [DateFullfilled] date,
    CONSTRAINT [FK_Receipt.EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [Employee]([EmployeeId])
);
CREATE TABLE [Order] (
    [OrderId] int,
    [OrderNumber] varchar,
    [CustomerId] int,
    [OrderStatusId] int,
    [Total] int,
    [DatePlaced] date,
    CONSTRAINT [FK_Order.OrderStatusId] FOREIGN KEY ([OrderStatusId]) REFERENCES [OrderStatus]([OrderStatusId]),
    CONSTRAINT [FK_Order.CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customer]([CustomerId]),
    CONSTRAINT [FK_Order.OrderId] FOREIGN KEY ([OrderId]) REFERENCES [Receipt]([OrderId])
);
CREATE TABLE [Potion] (
    [PotionId] int,
    [Name] varchar,
    [Description] varchar,
    [Price] int,
    [Cost] int,
    [CurrentStock] int,
    [Image] varchar,
    [EmployeeId] int,
    CONSTRAINT [FK_Potion.EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [Employee]([EmployeeId])
);
