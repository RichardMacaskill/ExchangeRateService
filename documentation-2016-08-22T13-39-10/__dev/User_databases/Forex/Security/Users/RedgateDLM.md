#### 

[Project](../../../../../index.md) > [.\\dev](../../../../index.md) > [User databases](../../../index.md) > [Forex](../../index.md) > [Security](../index.md) > [Users](Users.md) > RedgateDLM

# ![Users](../../../../../Images/User32.png) RedgateDLM

---

## <a name="#properties"></a>Properties

| Property | Value |
|---|---|
| Type | SqlUser |
| Login Name | RedgateDLM |
| Default Schema | dbo |


---

## <a name="#databaselevelpermissions"></a>Database Level Permissions

| Type | Action |
|---|---|
| CONNECT | Grant |


---

## <a name="#sqlscript"></a>SQL Script

```sql
IF NOT EXISTS (SELECT * FROM master.dbo.syslogins WHERE loginname = N'RedgateDLM')
CREATE LOGIN [RedgateDLM] WITH PASSWORD = 'p@ssw0rd'
GO
CREATE USER [RedgateDLM] FOR LOGIN [RedgateDLM]
GO

```


---

## <a name="#usedby"></a>Used By

* [RatesService](../Roles/Database_Roles/RatesService.md)


---

###### Author:  Richard Macaskill

###### Copyright 2016 - All Rights Reserved

###### Created: 22 August 2016 13:39

