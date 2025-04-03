create database car_rental;

use car_rental;

create table Vehicle (
    vehicleID int primary key,
    make varchar(255),
    model varchar(255),
    year int,
    dailyRate int,
    status varchar(255) not null check (status in ('available', 'notAvailable')),
    passengerCapacity int,
    engineCapacity int
);

create table Customer (
    customerID int primary key,
    firstName varchar(255),
    lastName varchar(255),
    email varchar(255) unique,
    phoneNumber int unique
);

create table Lease (
    leaseID int primary key,
    vehicleID int,
    customerID int,
    startDate date,
    endDate date,
    type varchar(255) not null check (type in ('DailyLease', 'MonthlyLease')),
    foreign key (vehicleID) references Vehicle(vehicleID),
    foreign key (customerID) references Customer(customerID)
);

create table Payment (
    paymentID int primary key,
    leaseID int,
    paymentDate date,
    amount int,
    foreign key (leaseID) references Lease(leaseID) 
);



alter table vehicle alter column dailyRate decimal(10,2);






ALTER TABLE Customer DROP CONSTRAINT UQ__Customer__4849DA01B0EDB0C1;
alter table customer alter column  phoneNumber varchar(15);
ALTER TABLE Customer ADD CONSTRAINT UQ_phoneNumber UNIQUE (phoneNumber);








ALTER TABLE Customer 
ALTER COLUMN phoneNumber VARCHAR(15);






alter table customer drop constraint UQ__Customer__4849DA0108A9489F;
alter table customer alter column phoneNumber varchar(25);









ALTER TABLE Vehicle 
ALTER COLUMN status BIT;











ALTER TABLE Vehicle DROP CONSTRAINT CK__Vehicle__status__49C3F6B7;
ALTER TABLE Vehicle ALTER COLUMN status BIT NOT NULL;

