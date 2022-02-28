Use QuanLiQuanBar
GO

CREATE TABLE account
(
	UserName Nvarchar(100) Primary Key,
	password NVarchar(1000) NOT NULL,
	Name NVarchar(100) NOT NULL,
	Type INT -- 1 là admin , 2 là staff

)
GO
CREATE TABLE tableBar 
(
	id INT IDentity PRIMARY KEY,
	Name NVarchar(100) NOT NULL,
	status NVarChar(100) NOT NULL -- Còn bàn ,hết bàn

)
GO
CREATE TABLE foodCategory
(
	id INT IDentity PRIMARY KEY,
	Name NVarchar(100) not null
)
GO
CREATE TABLE food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	idCategoryFood Int NOT NULL,
	price float NOT NULL DEFAULT 0
	Foreign Key (idCategoryFood) References dbo.foodCategory(id)
	
)
GO
CREATE TABLE drinkCategory
(
	id INT IDentity PRIMARY KEY,
	Name NVarchar(100) Not null
)
GO
CREATE TABLE drink
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	idCategoryDrink Int NOT NULL,
	price float NOT NULL DEFAULT 0
	Foreign Key (idCategoryDrink) References dbo.drinkCategory(id)
)
GO
CREATE TABLE bill
(
	id Int Identity Primary Key,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT Not Null,
	status INT Not Null -- đã thanh toán, chưa thanh toán
	Foreign Key (idTable) REFERENCES dbo.tableBar(id)
)
GO
CREATE TABLE billInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	idDrink INT NOT NULL,
	soLuong Int NOT NULL Default 0
	Foreign Key (idBill) REFERENCES dbo.bill(id),
	Foreign Key (idFood) REFERENCES dbo.food(id),
	Foreign Key (idDrink) REFERENCES dbo.drink(id)
)
GO
