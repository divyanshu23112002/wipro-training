create table books(
    bookId int primary key,
    Title varchar(50),
    Author varchar(100),
    Genre varchar(50),
    Price decimal(10,2),
    PublishedYear int
);

Insert into books(bookId,Title,Author,Genre,Price,PublishedYear) values
(1,'Atomic Habits','James Clear','Self-Help',499.00,2018),
(2,'The Alchemist','Paulo Coelho','Fiction',299.00,1993),
(3,'Clean Code','Robert C. Martin','Programming',799.00,2008),
(4,'Sapiens','Yuval Noah Harari','History',599.00,2015);


