#### 



# ![Stored Procedures](../../../../Images/StoredProcedure32.png) [dbo].[Currency_List]

---

## <a name="#properties"></a>Properties

| Property | Value |
|---|---|
| ANSI Nulls On | YES |
| Quoted Identifier On | YES |


---

## <a name="#sqlscript"></a>SQL Script

```sql
CREATE PROCEDURE [dbo].[Currency_List]
AS
SET NOCOUNT ON
BEGIN
    SELECT  c.ISO as ISO,
            c.CountryId ,
            c.StandardPrecision ,
            c.HasSubUnits ,
            ct.ID as CountryId,
            ct.Name ,
            ct.RegionId ,
            r.ID ,
            r.Name ,
            r.ShortCode
    FROM    dbo.Currency AS c
            INNER JOIN dbo.Country AS ct ON ct.ID = c.CountryId
            INNER JOIN dbo.Region AS r ON r.ID = ct.RegionId;
END;
GO

```


---

## <a name="#uses"></a>Uses

* [[dbo].[Country]](../../Tables/Country.md)
* [[dbo].[Currency]](../../Tables/Currency.md)
* [[dbo].[Region]](../../Tables/Region.md)


---

###### Author:  Richard Macaskill

###### Copyright 2016 - All Rights Reserved

###### Created: 22 August 2016 14:30

