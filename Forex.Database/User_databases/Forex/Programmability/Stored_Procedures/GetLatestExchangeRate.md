#### 



# ![Stored Procedures](../../../../Images/StoredProcedure32.png) [dbo].[GetLatestExchangeRate]

---

## <a name="#properties"></a>Properties

| Property | Value |
|---|---|
| ANSI Nulls On | YES |
| Quoted Identifier On | YES |


---

## <a name="#parameters"></a>Parameters

| Name | Data Type | Max Length (Bytes) | Direction |
|---|---|---|---|
| @AsAtDateTime | datetime | 8 |  |
| @ISO | nchar(3) | 6 |  |
| @Rate | decimal(22,10) | 13 | Out |


---

## <a name="#permissions"></a>Permissions

| Type | Action | Owning Principal |
|---|---|---|
| Grant | Execute | GetLatestRate |
| Grant | Execute | RatesService |


---

## <a name="#sqlscript"></a>SQL Script

```sql
CREATE PROCEDURE [dbo].[GetLatestExchangeRate]
    (
      @AsAtDateTime DATETIME,
      @ISO NCHAR(3),
	  @Rate DECIMAL(22, 10) OUTPUT
    )
AS
    BEGIN
        SELECT TOP 1
                @Rate = er.OutrightRate
        FROM    dbo.ExchangeRate AS er
        WHERE   er.ISO = @ISO
                AND er.AsOfDateTime <= @AsAtDateTime
                AND er.ValidTo IS NULL;
	RETURN;

    END;
GO
GRANT EXECUTE ON  [dbo].[GetLatestExchangeRate] TO [GetLatestRate]
GO
GRANT EXECUTE ON  [dbo].[GetLatestExchangeRate] TO [RatesService]
GO

```


---

## <a name="#uses"></a>Uses

* [[dbo].[ExchangeRate]](../../Tables/ExchangeRate.md)


---

###### Author:  Richard Macaskill

###### Copyright 2016 - All Rights Reserved

###### Created: 22 August 2016 14:30

