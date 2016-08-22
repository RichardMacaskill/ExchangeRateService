#### 

[Project](../../../../../index.md) > [.\\dev](../../../../index.md) > [User databases](../../../index.md) > [Forex](../../index.md) > [Programmability](../index.md) > [Stored Procedures](Stored_Procedures.md) > dbo.LatestSpotRate_GetByISO

# ![Stored Procedures](../../../../../Images/StoredProcedure32.png) [dbo].[LatestSpotRate_GetByISO]

---

## <a name="#properties"></a>Properties

| Property | Value |
|---|---|
| ANSI Nulls On | YES |
| Quoted Identifier On | YES |


---

## <a name="#parameters"></a>Parameters

| Name | Data Type | Max Length (Bytes) |
|---|---|---|
| @ISO | nchar(3) | 6 |


---

## <a name="#sqlscript"></a>SQL Script

```sql
CREATE PROCEDURE [dbo].[LatestSpotRate_GetByISO] @ISO AS NCHAR(3)
AS
    BEGIN
        SELECT TOP 1
                c.ISO ,
                c.StandardPrecision ,
                er.OutrightRate
        FROM    dbo.Currency AS c
                LEFT OUTER JOIN dbo.ExchangeRate AS er ON c.ISO = er.ISO
                LEFT OUTER JOIN dbo.Tenor AS t ON t.ID = er.TenorId
        WHERE   c.ISO = @ISO
                AND er.ValidTo IS NULL
        ORDER BY er.AsOfDateTime DESC;

    END;
    
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

###### Created: 22 August 2016 13:39

