#### 



# ![Tables](../../../Images/Table32.png) [dbo].[Currency]

---

## <a name="#description"></a>MS_Description

Core information on a currency, identified by 3 character ISO code.

## <a name="#properties"></a>Properties

| Property | Value |
|---|---|
| Collation | Latin1_General_CI_AS |
| Row Count (~) | 6 |
| Created | 16:47:21 21 May 2015 |
| Last Modified | 10:20:34 23 May 2016 |


---

## <a name="#columns"></a>Columns

| Key | Name | Data Type | Max Length (Bytes) | Allow Nulls |
|---|---|---|---|---|
| [![Cluster Primary Key PK_Currency_ISO: ISO](../../../Images/pkcluster.png)](#indexes) | ISO | nchar(3) | 6 | NO |
| [![Foreign Keys FK_Currency_Country_ID: [dbo].[Country].CountryId](../../../Images/fk.png)](#foreignkeys) | CountryId | int | 4 | NO |
|  | StandardPrecision | int | 4 | NO |
|  | HasSubUnits | bit | 1 | NO |


---

## <a name="#indexes"></a>Indexes

| Key | Name | Key Columns | Unique |
|---|---|---|---|
| [![Cluster Primary Key PK_Currency_ISO: ISO](../../../Images/pkcluster.png)](#indexes) | PK_Currency_ISO | ISO | YES |


---

## <a name="#foreignkeys"></a>Foreign Keys

| Name | Columns |
|---|---|
| FK_Currency_Country_ID | CountryId->[[dbo].[Country].[ID]](Country.md) |


---

## <a name="#sqlscript"></a>SQL Script

```sql
CREATE TABLE [dbo].[Currency]
(
[ISO] [nchar] (3) COLLATE Latin1_General_CI_AS NOT NULL,
[CountryId] [int] NOT NULL,
[StandardPrecision] [int] NOT NULL,
[HasSubUnits] [bit] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Currency] ADD CONSTRAINT [PK_Currency_ISO] PRIMARY KEY CLUSTERED  ([ISO]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Currency] ADD CONSTRAINT [FK_Currency_Country_ID] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([ID])
GO
EXEC sp_addextendedproperty N'MS_Description', N'Core information on a currency, identified by 3 character ISO code.', 'SCHEMA', N'dbo', 'TABLE', N'Currency', NULL, NULL
GO

```


---

## <a name="#uses"></a>Uses

* [[dbo].[Country]](Country.md)


---

## <a name="#usedby"></a>Used By

* [[dbo].[ExchangeRate]](ExchangeRate.md)
* [[dbo].[v_ExchangeRates]](../Views/v_ExchangeRates.md)
* [[dbo].[v_Exrates_Currency]](../Views/v_Exrates_Currency.md)
* [[dbo].[v_Geographies]](../Views/v_Geographies.md)
* [[dbo].[Currency_List]](../Programmability/Stored_Procedures/Currency_List.md)
* [[dbo].[ExchangeRates_ListAll]](../Programmability/Stored_Procedures/ExchangeRates_ListAll.md)
* [[dbo].[LatestSpotRate_GetByISO]](../Programmability/Stored_Procedures/LatestSpotRate_GetByISO.md)


---

###### Author:  Richard Macaskill

###### Copyright 2016 - All Rights Reserved

###### Created: 22 August 2016 14:30

