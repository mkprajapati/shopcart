CREATE TABLE Products
(
 [ProductID] INT NOT NULL PRIMARY KEY IDENTITY,
 [Name] NVARCHAR(100) NOT NULL,
 [Description] NVARCHAR(500) NOT NULL,
 [Category] NVARCHAR(50) NOT NULL,
 [Price] DECIMAL(16, 2) NOT NULL
)
go
insert into Products values('Hockey','A stick to play Hockey','Field sports',450.677)
insert into Products values('Hockey Boll','A Boll to play Hockey','Field sports',150.677)
insert into Products values('Hockey Pad','A tool for protection ','Field sports',500.99)
insert into Products values('Helmet','A Tool for head Protection ','Field sports',999.677)
insert into Products values('Bat','A bat to play Cricket','Field sports',2000.77)
insert into Products values('Boll','A Boll to play Cricket','Field sports',150.677)
insert into Products values('Tennis Boll','A Boll to play Tennis ','Field sports',250.997)
insert into Products values('FootBoll','A Boll to play FootBoll','Field sports',660.98)
insert into Products values('Wicket Stick','A stick to setup of Wicket ','Field sports',889.88)
insert into Products values('Gloves','A tool for hand Protection ','Field sports',750.60)
insert into Products values('Goggles','Too for eye Protection ','Field sports',550.60)
