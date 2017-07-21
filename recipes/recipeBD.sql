

create table recipe (
	id int primary key AUTO_INCREMENT,
	name varchar(255),
	imageUrl varchar(255),
	description text
)

go

create table ingredient(
	id int primary key,
	name varchar(255),
	recipeID int foreign key references recipe(id),
)

go

insert into recipe (name, imageUrl, description) values ('recipe 1', 'qwe', 'some description')
insert into recipe (name, imageUrl, description) values ('recipe 2', 'qwe', 'delicous meal')