#### 



# ![Views](../../../Images/View32.png) [dbo].[v_ExchangeRates]

---

## <a name="#properties"></a>Properties

| Property | Value |
|---|---|
| ANSI Nulls On | YES |
| Quoted Identifier On | YES |
| Created | 14:28:26 07 October 2015 |
| Last Modified | 14:28:26 07 October 2015 |


---

## <a name="#columns"></a>Columns

| Name |
|---|
| ISO |
| Name |
| OutrightRate |
| AsOfDateTime |
| SettlementDate |
| ValidFrom |
| ValidTo |


---

## <a name="#sqlscript"></a>SQL Script

```sql
CREATE VIEW [dbo].[v_ExchangeRates]
as

SELECT
   er.ISO
,   t.Name
,   er.OutrightRate
,   er.AsOfDateTime
,   er.SettlementDate
,   er.ValidFrom
,   er.ValidTo
FROM
    dbo.ExchangeRate AS er
INNER JOIN dbo.Currency AS c
    ON c.ISO = er.ISO
INNER JOIN dbo.Tenor AS t
    ON t.ID = er.TenorId;


	
GO

```


---

## <a name="#uses"></a>Uses

* [[dbo].[Currency]](../Tables/Currency.md)
* [[dbo].[ExchangeRate]](../Tables/ExchangeRate.md)
* [[dbo].[Tenor]](../Tables/Tenor.md)


---

###### Author:  Richard Macaskill

###### Copyright 2016 - All Rights Reserved

###### Created: 22 August 2016 14:30

