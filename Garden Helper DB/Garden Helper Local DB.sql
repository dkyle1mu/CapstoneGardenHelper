CREATE TABLE Garden
(
id INT PRIMARY KEY,
growing BINARY(1),
name varchar(30),
photo MEDIUMBLOB,
plant_date date,
category enum('vegetable', 'fruit', 'grain', 'flower', 'grass', 'other')
);
