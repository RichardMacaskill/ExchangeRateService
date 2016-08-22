#### 

[Project](../../../../index.md) > [.\\dev](../../../index.md) > [User databases](../../index.md) > [Forex](../index.md) > [Views](Views.md) > dbo.myView

# ![Views](../../../../Images/View32.png) [dbo].[myView]

---

## <a name="#properties"></a>Properties

| Property | Value |
|---|---|
| ANSI Nulls On | YES |
| Quoted Identifier On | YES |
| Created | 11:08:10 01 December 2015 |
| Last Modified | 15:56:21 05 February 2016 |


---

## <a name="#columns"></a>Columns

| Name |
|---|
| ID |
| Name |
| AssumedDays |


---

## <a name="#sqlscript"></a>SQL Script

```sql

CREATE VIEW [dbo].[myView] AS 
SELECT * FROM dbo.Tenor;

GO

```


---

## <a name="#uses"></a>Uses

* [[dbo].[Tenor]](../Tables/Tenor.md)


---

###### Author:  Richard Macaskill

###### Copyright 2016 - All Rights Reserved

###### Created: 22 August 2016 13:39

