create database PizzaWebStore

use PizzaWebStore

create table Users
(User_email varchar(40) primary key,
Name varchar(40),
Password varchar(40),
Address varchar(100),
Phone varchar(20))

select * from Users

create table Pizza
(Pizza_Id int identity(1,1) primary key,
Name varchar(40),
Price float,
Speciality varchar(40),
isVeg varchar(20))

create table Toppings
(Topping_Id int identity(1,1) Primary Key,
Name varchar(40),
Price float)

create table Orders
(Order_Id int identity(101,1) primary key,
User_Id varchar(40) foreign key references Users(User_email),
Total float,
Delivery_Charge float,
status varchar(40))

create table Order_Details
(Item_Id int identity(1001,1) primary key,
Order_Id int foreign key references Orders(Order_Id),
Pizza_Id int foreign key references Pizza(Pizza_Id))

create table Toppinng_Details
(Item_Id int foreign key references Order_Details(Item_Id),
Topping_Id int foreign key references Toppings(Topping_Id),
Primary Key(Item_Id, Topping_Id))

Insert into Pizza 
values ('Pizza Pepperoni Blues', 21, 'Spicy', 'notVeg'),
('Pizza Margarita', 19, 'Cheesy', 'Veg'),
('Pizza Manhattan', 20, 'Mashrooms', 'notVeg'),
('Pizza Toscana', 21, 'Cheesy', 'notVeg'),
('Pizza Five Cheeses', 22, 'Cheesy', 'Veg'),
('VEG Loaded', 22, 'Veg', 'Veg'),
('Paneer & Onion', 21, 'Veg', 'Veg');