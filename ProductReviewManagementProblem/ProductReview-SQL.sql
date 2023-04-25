Create Database ProductReview_Management;
Use ProductReview_Management;
--UC7
Create table Product_Review
(
ProductId int Primary Key identity(1,1),
UserId int,
Rating int,
Review varchar(10),
IsLike varchar(20),
) 
Insert into Product_Review(UserId,Rating,Review,IsLike) values(1,5,'Good','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(4,3,'Average','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(1,5,'Good','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(2,2,'Baverage','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(1,5,'Good','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(5,5,'Good','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(1,4,'Nice','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(1,5,'Good','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(6,5,'Good','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(1,1,'Worst','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(1,5,'Good','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(3,1,'Worst','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(1,2,'Baverage','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(7,5,'Good','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(9,5,'Good','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(1,4,'Nice','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(8,5,'Good','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(10,5,'Good','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(1,5,'Good','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(4,3,'Average','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(1,5,'Good','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(2,2,'Baverage','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(1,5,'Good','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(5,5,'Good','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(6,4,'Nice','True');
Select * from Product_Review;
--UC11
Insert into Product_Review(UserId,Rating,Review,IsLike) values(1,5,'Good','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(2,2,'Baverage','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(1,5,'Good','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(5,5,'Good','True');
Insert into Product_Review(UserId,Rating,Review,IsLike) values(6,4,'Nice','True');

Select * from Product_Review where UserId=10 order by Rating;