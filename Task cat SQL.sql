DROP TABLE IF EXISTS products;

CREATE TABLE products(
	product_id INT PRIMARY KEY,product_name VARCHAR(50),is_recyclable BIT,is_low_fat BIT
);

INSERT INTO products(product_id,product_name,is_recyclable,is_low_fat)
VALUES
(1,'Product_A',1,1),
(2,'Product_B',1,0),
(3,'Product_C',0,1),
(4,'Product_D',1,1);

SELECT product_id , product_name
FROM products
WHERE is_recyclable=1 AND is_low_fat=1;