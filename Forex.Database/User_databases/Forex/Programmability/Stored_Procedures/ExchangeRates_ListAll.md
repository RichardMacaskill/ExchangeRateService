#### 



# ![Stored Procedures](../../../../Images/StoredProcedure32.png) [dbo].[ExchangeRates_ListAll]

---

## <a name="#properties"></a>Properties

| Property | Value |
|---|---|
| ANSI Nulls On | YES |
| Quoted Identifier On | YES |


---

## <a name="#sqlscript"></a>SQL Script

```sql
CREATE PROCEDURE [dbo].[ExchangeRates_ListAll]
AS
SET NOCOUNT ON
BEGIN
SELECT  er.ID ,
        er.ISO ,
        er.TenorId ,
        er.OutrightRate ,
        er.AsOfDateTime ,
        er.SettlementDate ,
        er.ValidFrom ,
        er.ValidTo ,
        t.ID ,
        t.Name ,
        t.AssumedDays ,
        c.ISO ,
        c.CountryId ,
        c.StandardPrecision ,
        c.HasSubUnits
FROM    dbo.ExchangeRate AS er
        INNER JOIN dbo.Tenor AS t ON t.ID = er.TenorId
        INNER JOIN dbo.Currency AS c ON c.ISO = er.ISO;
END	



GO

```


---

## <a name="#uses"></a>Uses

* [[dbo].[Currency]](../../Tables/Currency.md)
* [[dbo].[ExchangeRate]](../../Tables/ExchangeRate.md)
* [[dbo].[Tenor]](../../Tables/Tenor.md)


---

###### Author:  Richard Macaskill

###### Copyright 2016 - All Rights Reserved

###### Created: 22 August 2016 14:30

