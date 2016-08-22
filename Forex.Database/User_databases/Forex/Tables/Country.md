#### 



# ![Tables](../../../Images/Table32.png) [dbo].[Country]

---

## <a name="#properties"></a>Properties

| Property | Value |
|---|---|
| Collation | Latin1_General_CI_AS |
| Row Count (~) | 6 |
| Created | 16:47:21 21 May 2015 |
| Last Modified | 10:20:34 23 May 2016 |


---

## <a name="#columns"></a>Columns

| Key | Name | Data Type | Max Length (Bytes) | Allow Nulls | Identity |
|---|---|---|---|---|---|
| [![Cluster Primary Key PK_Country_ID: ID](../../../Images/pkcluster.png)](#indexes) | ID | int | 4 | NO | 1 - 1 |
|  | Name | nvarchar(100) | 200 | YES |  |
| [![Foreign Keys FK_Country_Region_ID: [dbo].[Region].RegionId](../../../Images/fk.png)](#foreignkeys) | RegionId | int | 4 | NO |  |


---

## <a name="#indexes"></a>Indexes

| Key | Name | Key Columns | Unique |
|---|---|---|---|
| [![Cluster Primary Key PK_Country_ID: ID](../../../Images/pkcluster.png)](#indexes) | PK_Country_ID | ID | YES |


---

## <a name="#foreignkeys"></a>Foreign Keys

| Name | Columns |
|---|---|
| FK_Country_Region_ID | RegionId->[[dbo].[Region].[ID]](Region.md) |


---

## <a name="#sqlscript"></a>SQL Script

```sql
CREATE TABLE [dbo].[Country]
(
[ID] [int] NOT NULL IDENTITY(1, 1),
[Name] [nvarchar] (100) COLLATE Latin1_General_CI_AS NULL,
[RegionId] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Country] ADD CONSTRAINT [PK_Country_ID] PRIMARY KEY CLUSTERED  ([ID]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Country] ADD CONSTRAINT [FK_Country_Region_ID] FOREIGN KEY ([RegionId]) REFERENCES [dbo].[Region] ([ID])
GO

```


---

## <a name="#uses"></a>Uses

* [[dbo].[Region]](Region.md)


---

## <a name="#usedby"></a>Used By

* [[dbo].[Currency]](Currency.md)
* [[dbo].[Currency_List]](../Programmability/Stored_Procedures/Currency_List.md)


---

###### Author:  Richard Macaskill

###### Copyright 2016 - All Rights Reserved

###### Created: 22 August 2016 14:30

