#### 



# ![Users](../../../../Images/User32.png) GetLatestRatesUser

---

## <a name="#properties"></a>Properties

| Property | Value |
|---|---|
| Type | SqlUser |
| Login Name | GetLatestRatesUser |
| Default Schema | dbo |


---

## <a name="#databaselevelpermissions"></a>Database Level Permissions

| Type | Action |
|---|---|
| CONNECT | Grant |


---

## <a name="#sqlscript"></a>SQL Script

```sql
IF NOT EXISTS (SELECT * FROM master.dbo.syslogins WHERE loginname = N'GetLatestRatesUser')
CREATE LOGIN [GetLatestRatesUser] WITH PASSWORD = 'p@ssw0rd'
GO
CREATE USER [GetLatestRatesUser] FOR LOGIN [GetLatestRatesUser]
GO

```


---

###### Author:  Richard Macaskill

###### Copyright 2016 - All Rights Reserved

###### Created: 22 August 2016 14:30

