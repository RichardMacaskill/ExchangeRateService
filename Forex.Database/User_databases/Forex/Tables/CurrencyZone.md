#### 



# ![Tables](../../../Images/Table32.png) [dbo].[CurrencyZone]

---

## <a name="#properties"></a>Properties

| Property | Value |
|---|---|
| Collation | Latin1_General_CI_AS |
| Row Count (~) | 0 |
| Created | 14:03:18 25 June 2015 |
| Last Modified | 14:03:18 25 June 2015 |


---

## <a name="#columns"></a>Columns

| Key | Name | Data Type | Max Length (Bytes) | Allow Nulls | Identity |
|---|---|---|---|---|---|
| [![Cluster Primary Key PK_CurrencyZone_ID: ID](../../../Images/pkcluster.png)](#indexes) | ID | int | 4 | NO | 1 - 1 |
|  | CurrencyZoneName | nvarchar(20) | 40 | YES |  |


---

## <a name="#indexes"></a>Indexes

| Key | Name | Key Columns | Unique |
|---|---|---|---|
| [![Cluster Primary Key PK_CurrencyZone_ID: ID](../../../Images/pkcluster.png)](#indexes) | PK_CurrencyZone_ID | ID | YES |


---

## <a name="#sqlscript"></a>SQL Script

```sql
CREATE TABLE [dbo].[CurrencyZone]
(
[ID] [int] NOT NULL IDENTITY(1, 1),
[CurrencyZoneName] [nvarchar] (20) COLLATE Latin1_General_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CurrencyZone] ADD CONSTRAINT [PK_CurrencyZone_ID] PRIMARY KEY CLUSTERED  ([ID]) ON [PRIMARY]
GO

```


---

## <a name="#usedby"></a>Used By

* [[dbo].[v_Geographies]](../Views/v_Geographies.md)


---

###### Author:  Richard Macaskill

###### Copyright 2016 - All Rights Reserved

###### Created: 22 August 2016 14:30

