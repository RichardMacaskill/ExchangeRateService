#### 

[Project](../../../../index.md) > [.\\dev](../../../index.md) > [User databases](../../index.md) > [Forex](../index.md) > [Tables](Tables.md) > dbo.Tenor

# ![Tables](../../../../Images/Table32.png) [dbo].[Tenor]

---

## <a name="#properties"></a>Properties

| Property | Value |
|---|---|
| Collation | Latin1_General_CI_AS |
| Row Count (~) | 5 |
| Created | 16:47:21 21 May 2015 |
| Last Modified | 10:20:34 23 May 2016 |


---

## <a name="#columns"></a>Columns

| Key | Name | Data Type | Max Length (Bytes) | Allow Nulls | Identity |
|---|---|---|---|---|---|
| [![Cluster Primary Key PK_Tenor_ID: ID](../../../../Images/pkcluster.png)](#indexes) | ID | int | 4 | NO | 1 - 1 |
|  | Name | nvarchar(10) | 20 | YES |  |
|  | AssumedDays | int | 4 | NO |  |


---

## <a name="#indexes"></a>Indexes

| Key | Name | Key Columns | Unique |
|---|---|---|---|
| [![Cluster Primary Key PK_Tenor_ID: ID](../../../../Images/pkcluster.png)](#indexes) | PK_Tenor_ID | ID | YES |


---

## <a name="#sqlscript"></a>SQL Script

```sql
CREATE TABLE [dbo].[Tenor]
(
[ID] [int] NOT NULL IDENTITY(1, 1),
[Name] [nvarchar] (10) COLLATE Latin1_General_CI_AS NULL,
[AssumedDays] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tenor] ADD CONSTRAINT [PK_Tenor_ID] PRIMARY KEY CLUSTERED  ([ID]) ON [PRIMARY]
GO

```


---

## <a name="#usedby"></a>Used By

* [[dbo].[ExchangeRate]](ExchangeRate.md)
* [[dbo].[myView]](../Views/myView.md)
* [[dbo].[v_ExchangeRates]](../Views/v_ExchangeRates.md)
* [[dbo].[ExchangeRates_ListAll]](../Programmability/Stored_Procedures/ExchangeRates_ListAll.md)
* [[dbo].[LatestSpotRate_GetByISO]](../Programmability/Stored_Procedures/LatestSpotRate_GetByISO.md)


---

###### Author:  Richard Macaskill

###### Copyright 2016 - All Rights Reserved

###### Created: 22 August 2016 13:39

