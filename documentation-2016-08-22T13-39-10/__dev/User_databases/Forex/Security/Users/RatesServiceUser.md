#### 

[Project](../../../../../index.md) > [.\\dev](../../../../index.md) > [User databases](../../../index.md) > [Forex](../../index.md) > [Security](../index.md) > [Users](Users.md) > RatesServiceUser

# ![Users](../../../../../Images/User32.png) RatesServiceUser

---

## <a name="#properties"></a>Properties

| Property | Value |
|---|---|
| Type | WindowsUser |
| Login Name | TESTNET\\RatesServiceUser |
| Default Schema | dbo |


---

## <a name="#databaselevelpermissions"></a>Database Level Permissions

| Type | Action |
|---|---|
| CONNECT | Grant |


---

## <a name="#sqlscript"></a>SQL Script

```sql
IF NOT EXISTS (SELECT * FROM master.dbo.syslogins WHERE loginname = N'TESTNET\\RatesServiceUser')
CREATE LOGIN [TESTNET\\RatesServiceUser] FROM WINDOWS
GO
CREATE USER [RatesServiceUser] FOR LOGIN [TESTNET\\RatesServiceUser]
GO

```


---

###### Author:  Richard Macaskill

###### Copyright 2016 - All Rights Reserved

###### Created: 22 August 2016 13:39

