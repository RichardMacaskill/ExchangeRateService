#### 



# ![Views](../../../Images/View32.png) [dbo].[v_Exrates_Currency]

---

## <a name="#properties"></a>Properties

| Property | Value |
|---|---|
| ANSI Nulls On | YES |
| Quoted Identifier On | YES |
| Created | 14:50:16 24 November 2015 |
| Last Modified | 15:22:09 24 November 2015 |


---

## <a name="#columns"></a>Columns

| Name |
|---|
| ID |
| ISO |
| TenorId |
| OutrightRate |
| AsOfDateTime |
| ValidFrom |
| ValidTo |
| CountryId |
| StandardPrecision |
| HasSubUnits |


---

## <a name="#sqlscript"></a>SQL Script

```sql
CREATE VIEW [dbo].[v_Exrates_Currency]
AS

SELECT er.ID
    ,  er.ISO
    ,  er.TenorId
    ,  er.OutrightRate
    ,  er.AsOfDateTime
        ,  er.ValidFrom
    ,  er.ValidTo
        ,  c.CountryId
    ,  c.StandardPrecision
    ,  c.HasSubUnits FROM dbo.ExchangeRate AS er INNER JOIN dbo.Currency AS c ON c.ISO = er.ISO
GO

```


---

## <a name="#uses"></a>Uses

* [[dbo].[Currency]](../Tables/Currency.md)
* [[dbo].[ExchangeRate]](../Tables/ExchangeRate.md)


---

###### Author:  Richard Macaskill

###### Copyright 2016 - All Rights Reserved

###### Created: 22 August 2016 14:30

