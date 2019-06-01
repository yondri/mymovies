\connect mymovies

CREATE TABLE movie
(
    id serial PRIMARY KEY,
    title  VARCHAR (50)  NOT NULL,
    description  VARCHAR (100)  NOT NULL,
    rating  INT  NOT NULL
);

ALTER TABLE "movie" OWNER TO mymovies_user;

Insert into movie(title,description, rating) values( 'Avengers: End Game','Description 1', 5);
Insert into movie(title,description, rating) values( 'Us','Description 2', 4);
Insert into movie(title,description, rating) values( 'Sharknado','Description 3', 3);