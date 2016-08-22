#### 



# ![Database Roles](../../../../../Images/Role_Database32.png) RatesService

---

## <a name="#properties"></a>Properties

| Property | Value |
|---|---|
| Owner | dbo |


---

## <a name="#members"></a>Members

* [RedgateDLM](../../Users/RedgateDLM.md)


---

## <a name="#sqlscript"></a>SQL Script

```sql
CREATE ROLE [RatesService]
AUTHORIZATION [dbo]
GO
EXEC sp_addrolemember N'RatesService', N'RedgateDLM'
GO

```


---

## <a name="#uses"></a>Uses

* [RedgateDLM](../../Users/RedgateDLM.md)


---

###### Author:  Richard Macaskill

###### Copyright 2016 - All Rights Reserved

###### Created: 22 August 2016 14:30

