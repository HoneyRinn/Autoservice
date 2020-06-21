CREATE TABLE [dbo].[Clients]
(
	[№] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Имя клиента] NVARCHAR(50) NULL, 
    [Модель авто] NVARCHAR(50) NULL, 
    [Гос.№] NVARCHAR(50) NULL, 
    [Краткое описание заказа] NVARCHAR(50) NULL, 
    [Статус заказа] NVARCHAR(50) NULL, 
    [Оплата] MONEY NULL
)
