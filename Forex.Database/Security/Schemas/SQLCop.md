#### 

[Project](../../../../../index.md) > [.\\dev](../../../../index.md) > [User databases](../../../index.md) > [Forex](../../index.md) > [Security](../index.md) > [Schemas](Schemas.md) > SQLCop

# ![Schemas](../../../../../Images/Schema32.png) SQLCop

---

## <a name="#properties"></a>Properties

| Property | Value |
|---|---|
| Owner | dbo |


---

## <a name="#extendedproperties"></a>Extended Properties

| Name | Value |
|---|---|
| tSQLt.TestClass | 1 |


---

## <a name="#sqlscript"></a>SQL Script

```sql
CREATE SCHEMA [SQLCop]
AUTHORIZATION [dbo]
GO
DECLARE @xp int
SELECT @xp=1
EXEC sp_addextendedproperty N'tSQLt.TestClass', @xp, 'SCHEMA', N'SQLCop', NULL, NULL, NULL, NULL
GO

```


---

###### Author:  Richard Macaskill

###### Copyright 2016 - All Rights Reserved

###### Created: 22 August 2016 13:39

