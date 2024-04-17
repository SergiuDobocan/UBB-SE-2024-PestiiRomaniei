create table Users(
id int primary key, 
email varchar(255),
password varchar(255),
type varchar(255)
)
ALTER TABLE Users
add username varchar(255)
ALTER TABLE Users
add	profile_picture varchar (255)

create table Requests(
req_id int primary key identity,
id_user int ,
id_artist int,
reqboddy varchar(1000),
FOREIGN KEY (id_user) REFERENCES Users(id))