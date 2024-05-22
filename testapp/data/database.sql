CREATE DATABASE Digital_signage
GO

USE Digital_signage
GO

CREATE TABLE Category
(
	Category_id INT IDENTITY PRIMARY KEY,
	Category_name NVARCHAR(100),
	Min_age INT DEFAULT 0,
	Max_age INT DEFAULT 120,
	Gender INT -- 0: Nam, 1: Nữ
)
GO

CREATE TABLE Product
(
	product_id INT IDENTITY PRIMARY KEY,
	product_name NVARCHAR(100),
	category_id INT,
	stat INT DEFAULT 1, --stat = 0: hết hàng, = 1: còn hàng 
	price INT,
	sale INT DEFAULT 0, --%
	priority_lev INT DEFAULT 0,-- mức độ ưu tiên càng cao thì sẽ được hiện lên trước các sản phẩm khác
	promotion NVARCHAR(200) DEFAULT Null -- khuyến mãi (mua 2 tặng 1, tặng kèm sản phẩm khác, vouncher,...)

	FOREIGN KEY (category_id) REFERENCES dbo.Category(category_id)
)
GO

