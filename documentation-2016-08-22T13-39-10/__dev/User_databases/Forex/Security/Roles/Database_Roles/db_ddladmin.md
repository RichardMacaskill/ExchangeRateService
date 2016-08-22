#### 

[Project](../../../../../../index.md) > [.\\dev](../../../../../index.md) > [User databases](../../../../index.md) > [Forex](../../../index.md) > [Security](../../index.md) > [Roles](../index.md) > [Database Roles](Database_Roles.md) > db_ddladmin

# ![Database Roles](../../../../../../Images/Role_Database32.png) db_ddladmin

---

## <a name="#properties"></a>Properties

| Property | Value |
|---|---|
| Owner | dbo |


---

## <a name="#members"></a>Members

* [RatesService](RatesService.md)


---

## <a name="#sqlscript"></a>SQL Script

```sql
EXEC sp_addrolemember N'db_ddladmin', N'RatesService'
GO

```


---

## <a name="#uses"></a>Uses

* [RatesService](RatesService.md)


---

###### Author:  Richard Macaskill

###### Copyright 2016 - All Rights Reserved

###### Created: 22 August 2016 13:39

