if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CONTRIBUTIONS') and o.name = 'FK_CONTRIBU_CONTRIBUT_SUPPORTE')
alter table CONTRIBUTIONS
   drop constraint FK_CONTRIBU_CONTRIBUT_SUPPORTE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CONTRIBUTIONS') and o.name = 'FK_CONTRIBU_CONTRIBUT_INITIATI')
alter table CONTRIBUTIONS
   drop constraint FK_CONTRIBU_CONTRIBUT_INITIATI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EXPENDITURES') and o.name = 'FK_EXPENDIT_PROVIDES_VENDORS')
alter table EXPENDITURES
   drop constraint FK_EXPENDIT_PROVIDES_VENDORS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EXPENDITURES') and o.name = 'FK_EXPENDIT_PURCHASES_INITIATI')
alter table EXPENDITURES
   drop constraint FK_EXPENDIT_PURCHASES_INITIATI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INITIATIVES') and o.name = 'FK_INITIATI_BELONGS_T_SECTORS')
alter table INITIATIVES
   drop constraint FK_INITIATI_BELONGS_T_SECTORS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CONTRIBUTIONS')
            and   name  = 'CONTRIBUTES_TO2_FK'
            and   indid > 0
            and   indid < 255)
   drop index CONTRIBUTIONS.CONTRIBUTES_TO2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CONTRIBUTIONS')
            and   name  = 'CONTRIBUTES_TO_FK'
            and   indid > 0
            and   indid < 255)
   drop index CONTRIBUTIONS.CONTRIBUTES_TO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CONTRIBUTIONS')
            and   type = 'U')
   drop table CONTRIBUTIONS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EXPENDITURES')
            and   name  = 'PROVIDES_FK'
            and   indid > 0
            and   indid < 255)
   drop index EXPENDITURES.PROVIDES_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EXPENDITURES')
            and   name  = 'PURCHASES_FK'
            and   indid > 0
            and   indid < 255)
   drop index EXPENDITURES.PURCHASES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EXPENDITURES')
            and   type = 'U')
   drop table EXPENDITURES
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('INITIATIVES')
            and   name  = 'BELONGS_TO_FK'
            and   indid > 0
            and   indid < 255)
   drop index INITIATIVES.BELONGS_TO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INITIATIVES')
            and   type = 'U')
   drop table INITIATIVES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SECTORS')
            and   type = 'U')
   drop table SECTORS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SUPPORTERS')
            and   type = 'U')
   drop table SUPPORTERS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VENDORS')
            and   type = 'U')
   drop table VENDORS
go

create table CONTRIBUTIONS (
   UNIQUE_REFERENCE     int IDENTITY(1,1)    not null,
   SUPPORTERID          int                  not null,
   INITIATIVEID         int                  not null,
   AMOUNT               decimal(18,2)        null,
   TIMESTAMP            datetime             null,
   constraint PK_CONTRIBUTIONS primary key (UNIQUE_REFERENCE)
)
go

create nonclustered index CONTRIBUTES_TO_FK on CONTRIBUTIONS (SUPPORTERID ASC)
go

create nonclustered index CONTRIBUTES_TO2_FK on CONTRIBUTIONS (INITIATIVEID ASC)
go

create table EXPENDITURES (
   ITEMID               int IDENTITY(1,1)    not null,
   INITIATIVEID         int                  not null,
   VENDORID             int                  not null,
   AMOUNT_SPENT         decimal(18,2)        null,
   DATE_SPENT           datetime             null,
   constraint PK_EXPENDITURES primary key (ITEMID)
)
go

create nonclustered index PURCHASES_FK on EXPENDITURES (INITIATIVEID ASC)
go

create nonclustered index PROVIDES_FK on EXPENDITURES (VENDORID ASC)
go

create table INITIATIVES (
   INITIATIVEID         int IDENTITY(1,1)    not null,
   SECTORID             int                  not null,
   TITLE                varchar(100)         not null,
   PRIMARY_OBJECTIVE    varchar(max)         null,
   FUNDING_TARGET       decimal(18,2)        null,
   START_DATE           datetime             null,
   END_DATE             datetime             null,
   IMPACT_SUMMARIES     varchar(max)         null,
   constraint PK_INITIATIVES primary key (INITIATIVEID)
)
go

create nonclustered index BELONGS_TO_FK on INITIATIVES (SECTORID ASC)
go

create table SECTORS (
   SECTORID             int IDENTITY(1,1)    not null,
   NAME                 varchar(50)          not null,
   DESCRIPTION          varchar(max)         null,
   constraint PK_SECTORS primary key (SECTORID)
)
go

create table SUPPORTERS (
   SUPPORTERID          int IDENTITY(1,1)    not null,
   FIRSTNAME            varchar(50)          not null,
   LASTNAME             varchar(50)          not null,
   EMAIL                varchar(100)         not null,
   constraint PK_SUPPORTERS primary key (SUPPORTERID)
)
go

create table VENDORS (
   VENDORID             int IDENTITY(1,1)    not null,
   COMPANY_NAME         varchar(100)         not null,
   CONTACT_NUMBER       varchar(11)          null,
   constraint PK_VENDORS primary key (VENDORID)
)
go

alter table CONTRIBUTIONS
   add constraint FK_CONTRIBU_CONTRIBUT_SUPPORTE foreign key (SUPPORTERID)
      references SUPPORTERS (SUPPORTERID)
go

alter table CONTRIBUTIONS
   add constraint FK_CONTRIBU_CONTRIBUT_INITIATI foreign key (INITIATIVEID)
      references INITIATIVES (INITIATIVEID)
go

alter table EXPENDITURES
   add constraint FK_EXPENDIT_PROVIDES_VENDORS foreign key (VENDORID)
      references VENDORS (VENDORID)
go

alter table EXPENDITURES
   add constraint FK_EXPENDIT_PURCHASES_INITIATI foreign key (INITIATIVEID)
      references INITIATIVES (INITIATIVEID)
go

alter table INITIATIVES
   add constraint FK_INITIATI_BELONGS_T_SECTORS foreign key (SECTORID)
      references SECTORS (SECTORID)
go