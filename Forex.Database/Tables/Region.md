#### 

[Project](../../../../index.md) > [.\\dev](../../../index.md) > [User databases](../../index.md) > [Forex](../index.md) > [Tables](Tables.md) > dbo.Region

# ![Tables](../../../../Images/Table32.png) [dbo].[Region]

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
| [![Cluster Primary Key PK_Region_ID: ID](../../../../Images/pkcluster.png)](#indexes) | ID | int | 4 | NO | 1 - 1 |
|  | Name | nvarchar(100) | 200 | YES |  |
|  | ShortCode | nvarchar(20) | 40 | YES |  |


---

## <a name="#indexes"></a>Indexes

| Key | Name | Key Columns | Unique |
|---|---|---|---|
| [![Cluster Primary Key PK_Region_ID: ID](../../../../Images/pkcluster.png)](#indexes) | PK_Region_ID | ID | YES |


---

## <a name="#sqlscript"></a>SQL Script

```sql
CREATE TABLE [dbo].[Region]
(
[ID] [int] NOT NULL IDENTITY(1, 1),
[Name] [nvarchar] (100) COLLATE Latin1_General_CI_AS NULL,
[ShortCode] [nvarchar] (20) COLLATE Latin1_General_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Region] ADD CONSTRAINT [PK_Region_ID] PRIMARY KEY CLUSTERED  ([ID]) ON [PRIMARY]
GO

```


---

## <a name="#usedby"></a>Used By

* [[dbo].[Country]](Country.md)
* [[dbo].[Currency_List]](../Programmability/Stored_Procedures/Currency_List.md)


---

###### Author:  Richard Macaskill

###### Copyright 2016 - All Rights Reserved

###### Created: 22 August 2016 13:39

