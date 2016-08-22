#### 

[Project](../../../../index.md) > [.\\dev](../../../index.md) > [User databases](../../index.md) > [Forex](../index.md) > [Tables](Tables.md) > RedGateLocal.DeploymentMetadata

# ![Tables](../../../../Images/Table32.png) [RedGateLocal].[DeploymentMetadata]

---

## <a name="#description"></a>MS_Description

This table records deployments with migration scripts. Learn more: http://rd.gt/230GBP3

## <a name="#properties"></a>Properties

| Property | Value |
|---|---|
| Collation | Latin1_General_CI_AS |
| Row Count (~) | 2 |
| Created | 12:49:10 25 May 2016 |
| Last Modified | 12:49:10 25 May 2016 |


---

## <a name="#columns"></a>Columns

| Key | Name | Data Type | Max Length (Bytes) | Allow Nulls | Identity | Default |
|---|---|---|---|---|---|---|
| [![Cluster Primary Key PK__Deployme__3214EC07BB6FE1EE: Id](../../../../Images/pkcluster.png)](#indexes) | Id | int | 4 | NO | 1 - 1 |  |
|  | Name | nvarchar(max) | max | NO |  |  |
|  | Type | varchar(50) | 50 | NO |  |  |
|  | Action | varchar(50) | 50 | NO |  |  |
|  | By | nvarchar(128) | 256 | NO |  | (original_login()) |
|  | As | nvarchar(128) | 256 | NO |  | (suser_sname()) |
|  | CompletedDate | datetime | 8 | NO |  | (getdate()) |
|  | With | nvarchar(128) | 256 | NO |  | (app_name()) |
|  | BlockId | varchar(50) | 50 | NO |  |  |
|  | InsertedSerial | binary(8) | 8 | NO |  | (@@dbts+(1)) |
|  | UpdatedSerial | timestamp | 8 | NO |  |  |
|  | MetadataVersion | varchar(50) | 50 | NO |  |  |
|  | Hash | nvarchar(max) | max | YES |  |  |


---

## <a name="#indexes"></a>Indexes

| Key | Name | Key Columns | Unique |
|---|---|---|---|
| [![Cluster Primary Key PK__Deployme__3214EC07BB6FE1EE: Id](../../../../Images/pkcluster.png)](#indexes) | PK__Deployme__3214EC07BB6FE1EE | Id | YES |


---

## <a name="#sqlscript"></a>SQL Script

```sql
CREATE TABLE [RedGateLocal].[DeploymentMetadata]
(
[Id] [int] NOT NULL IDENTITY(1, 1),
[Name] [nvarchar] (max) COLLATE Latin1_General_CI_AS NOT NULL,
[Type] [varchar] (50) COLLATE Latin1_General_CI_AS NOT NULL,
[Action] [varchar] (50) COLLATE Latin1_General_CI_AS NOT NULL,
[By] [nvarchar] (128) COLLATE Latin1_General_CI_AS NOT NULL CONSTRAINT [DF__DeploymentMe__By__269AB60B] DEFAULT (original_login()),
[As] [nvarchar] (128) COLLATE Latin1_General_CI_AS NOT NULL CONSTRAINT [DF__DeploymentMe__As__278EDA44] DEFAULT (suser_sname()),
[CompletedDate] [datetime] NOT NULL CONSTRAINT [DF__Deploymen__Compl__2882FE7D] DEFAULT (getdate()),
[With] [nvarchar] (128) COLLATE Latin1_General_CI_AS NOT NULL CONSTRAINT [DF__Deployment__With__297722B6] DEFAULT (app_name()),
[BlockId] [varchar] (50) COLLATE Latin1_General_CI_AS NOT NULL,
[InsertedSerial] [binary] (8) NOT NULL CONSTRAINT [DF__Deploymen__Inser__2A6B46EF] DEFAULT (@@dbts+(1)),
[UpdatedSerial] [timestamp] NOT NULL,
[MetadataVersion] [varchar] (50) COLLATE Latin1_General_CI_AS NOT NULL,
[Hash] [nvarchar] (max) COLLATE Latin1_General_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [RedGateLocal].[DeploymentMetadata] ADD CONSTRAINT [PK__Deployme__3214EC07BB6FE1EE] PRIMARY KEY CLUSTERED  ([Id]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'This table records deployments with migration scripts. Learn more: http://rd.gt/230GBP3', 'SCHEMA', N'RedGateLocal', 'TABLE', N'DeploymentMetadata', NULL, NULL
GO

```


---

## <a name="#uses"></a>Uses

* [RedGateLocal](../Security/Schemas/RedGateLocal.md)


---

###### Author:  Richard Macaskill

###### Copyright 2016 - All Rights Reserved

###### Created: 22 August 2016 13:39

