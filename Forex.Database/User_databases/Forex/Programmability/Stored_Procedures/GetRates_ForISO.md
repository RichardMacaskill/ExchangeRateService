#### 



# ![Stored Procedures](../../../../Images/StoredProcedure32.png) [dbo].[GetRates_ForISO]

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
| @AsOfDate | datetime2 | 8 |


---

## <a name="#sqlscript"></a>SQL Script

```sql
CREATE PROCEDURE [dbo].[GetRates_ForISO]
    (
     @ISO NCHAR(3)
    ,@AsOfDate DATETIME2
    )
AS
    BEGIN
        SELECT
            ISO
        ,   AsOfDateTime
        ,   OutrightRate
        FROM
            dbo.ExchangeRate
        WHERE
            ISO = @ISO
		AND AsOfDateTime < @AsOfDate
		ORDER BY 
			AsOfDateTime desc;	

    END;
GO

```


---

## <a name="#uses"></a>Uses

* [[dbo].[ExchangeRate]](../../Tables/ExchangeRate.md)


---

###### Author:  Richard Macaskill

###### Copyright 2016 - All Rights Reserved

###### Created: 22 August 2016 14:30

