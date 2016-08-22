#### 

[Project](../../../../index.md) > [.\\dev](../../../index.md) > [User databases](../../index.md) > [Forex](../index.md) > [Tables](Tables.md) > dbo.ExchangeRate

# ![Tables](../../../../Images/Table32.png) [dbo].[ExchangeRate]

---

## <a name="#properties"></a>Properties

| Property | Value |
|---|---|
| Collation | Latin1_General_CI_AS |
| Row Count (~) | 1300 |
| Created | 16:47:21 21 May 2015 |
| Last Modified | 10:20:34 23 May 2016 |


---

## <a name="#columns"></a>Columns

| Key | Name | Data Type | Max Length (Bytes) | Allow Nulls | Identity | Default |
|---|---|---|---|---|---|---|
| [![Cluster Primary Key PK_ExchangeRate_Id: ID](../../../../Images/pkcluster.png)](#indexes) | ID | int | 4 | NO | 1 - 1 |  |
| [![Foreign Keys FK_ExchangeRate_Currency_ISO: [dbo].[Currency].ISO](../../../../Images/fk.png)](#foreignkeys) | ISO | nchar(3) | 6 | NO |  |  |
| [![Foreign Keys FK_ExchangeRate_Tenor_ID: [dbo].[Tenor].TenorId](../../../../Images/fk.png)](#foreignkeys) | TenorId | int | 4 | NO |  |  |
|  | OutrightRate | decimal(22,10) | 13 | YES |  |  |
|  | AsOfDateTime | datetime | 8 | YES |  | (getutcdate()) |
|  | SettlementDate | datetime | 8 | YES |  |  |
|  | ValidFrom | datetime | 8 | YES |  | (getutcdate()) |
|  | ValidTo | datetime | 8 | YES |  |  |


---

## <a name="#indexes"></a>Indexes

| Key | Name | Key Columns | Unique |
|---|---|---|---|
| [![Cluster Primary Key PK_ExchangeRate_Id: ID](../../../../Images/pkcluster.png)](#indexes) | PK_ExchangeRate_Id | ID | YES |


---

## <a name="#foreignkeys"></a>Foreign Keys

| Name | Columns |
|---|---|
| FK_ExchangeRate_Currency_ISO | ISO->[[dbo].[Currency].[ISO]](Currency.md) |
| FK_ExchangeRate_Tenor_ID | TenorId->[[dbo].[Tenor].[ID]](Tenor.md) |


---

## <a name="#sqlscript"></a>SQL Script

```sql
CREATE TABLE [dbo].[ExchangeRate]
(
[ID] [int] NOT NULL IDENTITY(1, 1),
[ISO] [nchar] (3) COLLATE Latin1_General_CI_AS NOT NULL,
[TenorId] [int] NOT NULL,
[OutrightRate] [decimal] (22, 10) NULL,
[AsOfDateTime] [datetime] NULL CONSTRAINT [DF_AsOfDateTime] DEFAULT (getutcdate()),
[SettlementDate] [datetime] NULL,
[ValidFrom] [datetime] NULL CONSTRAINT [DF_ValidFrom] DEFAULT (getutcdate()),
[ValidTo] [datetime] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ExchangeRate] ADD CONSTRAINT [PK_ExchangeRate_Id] PRIMARY KEY CLUSTERED  ([ID]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ExchangeRate] ADD CONSTRAINT [FK_ExchangeRate_Currency_ISO] FOREIGN KEY ([ISO]) REFERENCES [dbo].[Currency] ([ISO])
GO
ALTER TABLE [dbo].[ExchangeRate] ADD CONSTRAINT [FK_ExchangeRate_Tenor_ID] FOREIGN KEY ([TenorId]) REFERENCES [dbo].[Tenor] ([ID])
GO

```


---

## <a name="#uses"></a>Uses

* [[dbo].[Currency]](Currency.md)
* [[dbo].[Tenor]](Tenor.md)


---

## <a name="#usedby"></a>Used By

* [[dbo].[v_ExchangeRates]](../Views/v_ExchangeRates.md)
* [[dbo].[v_Exrates_Currency]](../Views/v_Exrates_Currency.md)
* [[dbo].[ExchangeRates_ListAll]](../Programmability/Stored_Procedures/ExchangeRates_ListAll.md)
* [[dbo].[GetLatestExchangeRate]](../Programmability/Stored_Procedures/GetLatestExchangeRate.md)
* [[dbo].[GetRates_ForISO]](../Programmability/Stored_Procedures/GetRates_ForISO.md)
* [[dbo].[LatestSpotRate_GetByISO]](../Programmability/Stored_Procedures/LatestSpotRate_GetByISO.md)


---

###### Author:  Richard Macaskill

###### Copyright 2016 - All Rights Reserved

###### Created: 22 August 2016 13:39

