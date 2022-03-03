create database AtmDB
go
use AtmDB
go
create table LoginTable
(LoginId int identity primary key,
AccountNum int not null,
PinNum int not null,
AcccountHolder varchar(30) not null
)
go
insert into LoginTable values(101,101,'Neha')
insert into LoginTable values(102,102,'Jon')
insert into LoginTable values(103,103,'Alan')
go
insert into LoginTable values(501,501,'Mseb')
insert into LoginTable values(502,502,'Bsnl')
insert into LoginTable values(503,503,'Lic')
go
create table Transac
(TransacId int identity primary key,
AccountNum int not null,
DateOfTransac varchar(30) not null,
Deposite int not null,
Withdraw int not null,
Transf int not null 
)
go 
insert into Transac values(101,'01-02-2022',5000,0,0)--deposite
insert into Transac values(101,'01-02-2022',0,1000,0)--withdraw
insert into Transac values(101,'01-02-2022',0,0,1000)--transfer
insert into Transac values(102,'01-02-2022',1000,0,0)--after transefer added

go
select * from Transac
go 
create table Bill
(LoginId int references LoginTable(LoginId),
BillNum int not null,
BillAmount int not null
)
go 
insert into Bill values(4,123,500)
insert into Bill values(5,1234,200)
insert into Bill values(6,12345,1000)
go 
select * from Bill
go
select b.BillNum from Bill b inner join LoginTable l on b.LoginId=l.LoginId where AcccountHolder='Mseb'---take bill number
go
select b.BillAmount from Bill b inner join LoginTable l on b.LoginId=l.LoginId where AcccountHolder='Mseb'---return bill amount-mseb







