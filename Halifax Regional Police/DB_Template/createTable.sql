drop table admins;
drop table complaint_handlers;
drop table complaints;
drop table complaint_types;
drop table users;
drop table address;
drop table polices;
drop table positions;
drop table status;

CREATE TABLE address(
	
	id INT PRIMARY KEY identity(1,1),
	door_no INT NOT NULL,
	street_name VARCHAR(50) NOT NULL,
	unit VARCHAR(50) ,
	city VARCHAR(50) NOT NULL,
	province VARCHAR(50) NOT NULL,
	postal_code VARCHAR(50) NOT NULL,
	country VARCHAR(50) NOT NULL
	
);

CREATE TABLE users (
    
	sin INT PRIMARY KEY,
    fname VARCHAR (255) NOT NULL,
	lname VARCHAR (255) NOT NULL,
	email VARCHAR (50) NOT NULL,
	password VARCHAR (100) NOT NULL,
	contact VARCHAR (15) NOT NULL,
	gender char(1) NOT NULL,
	dob DATE NOT NULL,
	address_id INT FOREIGN KEY REFERENCES address(id),
	is_police VARCHAR(5) NOT NULL
    
);




CREATE TABLE positions(

	
	id int PRIMARY KEY identity(1,1),
	name varchar(30) not null
	
	
);






CREATE TABLE polices(

	sin INT PRIMARY KEY,
	position_id int NOT NULL FOREIGN KEY REFERENCES positions(id),
	activation_code VARCHAR(50) NOT NULL
	
);



CREATE TABLE status(

	id INT PRIMARY KEY identity(1,1),
	name VARCHAR(50) NOT NULL
);	




CREATE TABLE admins(

	sin INT PRIMARY KEY,
	username VARCHAR(70) NOT NULL,
	password VARCHAR(20) NOT NULL

);
	



CREATE TABLE complaint_types(

	id INT PRIMARY KEY identity(1,1),
	name VARCHAR(100) NOT NULL

);


CREATE TABLE complaints(

	id INT PRIMARY KEY identity(1,1),
	reporting_date DATE NOT NULL,
	status_id INT FOREIGN KEY REFERENCES status(id),
	complaint_type_id INT FOREIGN KEY REFERENCES complaint_types(id),
	description VARCHAR(250), 
	owner INT FOREIGN KEY REFERENCES users(sin)
	
);







CREATE TABLE complaint_handlers(

	id int primary key identity(1,1),
	complaint_id INT FOREIGN KEY REFERENCES complaints(id),
	officer INT FOREIGN KEY REFERENCES polices(sin)
	
);