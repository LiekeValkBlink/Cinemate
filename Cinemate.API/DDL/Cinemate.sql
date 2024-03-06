INSERT INTO movie_categories (id, name) VALUES (1, 'Action');
INSERT INTO movie_categories (id, name) VALUES (2, 'Comedy');
INSERT INTO movie_categories (id, name) VALUES (3, 'Drama');
INSERT INTO movie_categories (id, name) VALUES (4, 'Horror');
INSERT INTO movie_categories (id, name) VALUES (5, 'Science Fiction');
INSERT INTO movie_categories (id, name) VALUES (6, 'Thriller');
INSERT INTO movie_categories (id, name) VALUES (7, 'Romance');
INSERT INTO movie_categories (id, name) VALUES (8, 'Adventure');
INSERT INTO movie_categories (id, name) VALUES (9, 'Fantasy');
INSERT INTO movie_categories (id, name) VALUES (10, 'Animation');

INSERT INTO movies (id, title, description, duration, release_year, movie_category_id, director, actor_cast, review, kijkwijzers) VALUES (1, 'Star Wars: Episode I - The Phantom Menace', 'Two Jedi Knights escape a hostile blockade to find allies and come across a young boy who may bring balance to the Force, but the long dormant Sith resurface to claim their original glory.', 136, 1999, 1, 'George Lucas', 'Liam Neeson, Ewan McGregor, Natalie Portman', 7.4, '12, Geweld');
INSERT INTO movies (id, title, description, duration, release_year, movie_category_id, director, actor_cast, review, kijkwijzers) VALUES (2, 'Star Wars: Episode II - Attack of the Clones', 'Ten years after initially meeting, Anakin Skywalker shares a forbidden romance with Padmé Amidala, while Obi-Wan Kenobi investigates an assassination attempt on the senator and discovers a secret clone army crafted for the Jedi.', 142, 2002, 1, 'George Lucas', 'Hayden Christensen, Natalie Portman, Ewan McGregor', 6.5, '12, Geweld');
INSERT INTO movies (id, title, description, duration, release_year, movie_category_id, director, actor_cast, review, kijkwijzers) VALUES (3, 'Star Wars: Episode III - Revenge of the Sith', 'Three years into the Clone Wars, the Jedi rescue Palpatine from Count Dooku. As Obi-Wan pursues a new threat, Anakin acts as a double agent between the Jedi Council and Palpatine and is lured into a sinister plan to rule the galaxy.', 140, 2005, 1, 'George Lucas', 'Hayden Christensen, Natalie Portman, Ewan McGregor', 7.5, '12, Geweld');
INSERT INTO movies (id, title, description, duration, release_year, movie_category_id, director, actor_cast, review, kijkwijzers) VALUES (4, 'The Shawshank Redemption', 'Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.', 142, 1994, 3, 'Frank Darabont', 'Tim Robbins, Morgan Freeman, Bob Gunton', 9.3, 'Geweld, Discriminatie');
INSERT INTO movies (id, title, description, duration, release_year, movie_category_id, director, actor_cast, review, kijkwijzers) VALUES (5, 'The Godfather', 'The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.', 175, 1972, 3, 'Francis Ford Coppola', 'Marlon Brando, Al Pacino, James Caan', 9.2, '16, Geweld');
INSERT INTO movies (id, title, description, duration, release_year, movie_category_id, director, actor_cast, review, kijkwijzers) VALUES (6, 'The Dark Knight', 'When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.', 152, 2008, 6, 'Christopher Nolan', 'Christian Bale, Heath Ledger, Aaron Eckhart', 9.0, '16, Geweld, Angst');
INSERT INTO movies (id, title, description, duration, release_year, movie_category_id, director, actor_cast, review, kijkwijzers) VALUES (7, 'The Lord of the Rings: The Return of the King', 'Gandalf and Aragorn lead the World of Men against Saurons army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.', 201, 2003, 8, 'Peter Jackson', 'Elijah Wood, Viggo Mortensen, Ian McKellen', 8.9, '16, Geweld, Angst');
INSERT INTO movies (id, title, description, duration, release_year, movie_category_id, director, actor_cast, review, kijkwijzers) VALUES (8, 'Inception', 'A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.', 148, 2010, 5, 'Christopher Nolan', 'Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page', 8.8, '12, Geweld, Angst');
INSERT INTO movies (id, title, description, duration, release_year, movie_category_id, director, actor_cast, review, kijkwijzers) VALUES (9, 'Pulp Fiction', 'The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.', 154, 1994, 6, 'Quentin Tarantino', 'John Travolta, Uma Thurman, Samuel L. Jackson', 8.9, '16, Geweld, Angst');
INSERT INTO movies (id, title, description, duration, release_year, movie_category_id, director, actor_cast, review, kijkwijzers) VALUES (10, 'Forrest Gump', 'The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.', 142, 1994, 7, 'Robert Zemeckis', 'Tom Hanks, Robin Wright, Gary Sinise', 8.8, '12, Geweld, Angst');

INSERT INTO users (id, email, name, password, subscribed_to_newsletter) VALUES (1, 'john@example.com', 'John Doe', 'password123', true);
INSERT INTO users (id, email, name, password, subscribed_to_newsletter) VALUES (2, 'jane@example.com', 'Jane Smith', 'securepassword', false);
INSERT INTO users (id, email, name, password, subscribed_to_newsletter) VALUES (3, 'alice@example.com', 'Alice Johnson', 'strongpassword', true);
INSERT INTO users (id, email, name, password, subscribed_to_newsletter) VALUES (4, 'bob@example.com', 'Bob Brown', 'password123', false);
INSERT INTO users (id, email, name, password, subscribed_to_newsletter) VALUES (5, 'emily@example.com', 'Emily Davis', 'adminpassword', true);
INSERT INTO users (id, email, name, password, subscribed_to_newsletter) VALUES (6, 'mike@example.com', 'Mike Wilson', 'p@ssw0rd', false);
INSERT INTO users (id, email, name, password, subscribed_to_newsletter) VALUES (7, 'sarah@example.com', 'Sarah Lee', 'secret123', true);
INSERT INTO users (id, email, name, password, subscribed_to_newsletter) VALUES (8, 'david@example.com', 'David Taylor', 'pass123', false);
INSERT INTO users (id, email, name, password, subscribed_to_newsletter) VALUES (9, 'anna@example.com', 'Anna Garcia', 'qwerty', true);
INSERT INTO users (id, email, name, password, subscribed_to_newsletter) VALUES (10, 'chris@example.com', 'Chris Martinez', 'password', false);

INSERT INTO authorizations (id, descriptions) VALUES (1, 'Admin');
INSERT INTO authorizations (id, descriptions) VALUES (2, 'Moderator');
INSERT INTO authorizations (id, descriptions) VALUES (3, 'User');

INSERT INTO employees (id, first_name, last_name, email, authorization_id, password)
VALUES (1, 'John', 'Doe', 'john@example.com', 1, 'password123');

INSERT INTO employees (id, first_name, last_name, email, authorization_id, password)
VALUES (2, 'Jane', 'Smith', 'jane@example.com', 2, 'password456');

INSERT INTO employees (id, first_name, last_name, email, authorization_id, password)
VALUES (3, 'Michael', 'Johnson', 'michael@example.com', 1, 'password789');

INSERT INTO employees (id, first_name, last_name, email, authorization_id, password)
VALUES (4, 'Emily', 'Brown', 'emily@example.com', 3, 'password321');

INSERT INTO employees (id, first_name, last_name, email, authorization_id, password)
VALUES (5, 'William', 'Taylor', 'william@example.com', 3, 'password654');

INSERT INTO employees (id, first_name, last_name, email, authorization_id, password)
VALUES (6, 'Olivia', 'Anderson', 'olivia@example.com', 3, 'password987');

INSERT INTO employees (id, first_name, last_name, email, authorization_id, password)
VALUES (7, 'James', 'Martinez', 'james@example.com', 3, 'password123');

INSERT INTO employees (id, first_name, last_name, email, authorization_id, password)
VALUES (8, 'Sophia', 'Hernandez', 'sophia@example.com', 3, 'password456');

INSERT INTO employees (id, first_name, last_name, email, authorization_id, password)
VALUES (9, 'Benjamin', 'Young', 'benjamin@example.com', 3, 'password789');

INSERT INTO employees (id, first_name, last_name, email, authorization_id, password)
VALUES (10, 'Amelia', 'King', 'amelia@example.com', 3, 'password321');

INSERT INTO theaters (id, name, street, house_nr, city, country)
VALUES (1, 'Cinemate', 'Lovensdijkstraat', '61', 'Breda', 'NL');

INSERT INTO theater_rooms (id, name, theater_id) VALUES (1, 'Zaal 1', 1);
INSERT INTO theater_rooms (id, name, theater_id) VALUES (2, 'Zaal 2', 1);
INSERT INTO theater_rooms (id, name, theater_id) VALUES (3, 'Zaal 3', 1);

INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (1, 1, 1, '2024-03-01 10:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (2, 1, 2, '2024-03-01 13:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (3, 2, 1, '2024-03-01 11:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (4, 2, 2, '2024-03-01 14:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (5, 3, 1, '2024-03-02 12:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (6, 3, 2, '2024-03-02 15:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (7, 4, 1, '2024-03-02 13:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (8, 4, 2, '2024-03-02 16:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (9, 5, 1, '2024-03-03 11:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (10, 5, 2, '2024-03-03 14:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (11, 6, 1, '2024-03-03 12:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (12, 6, 2, '2024-03-03 15:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (13, 7, 1, '2024-03-04 10:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (14, 7, 2, '2024-03-04 13:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (15, 8, 1, '2024-03-04 11:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (16, 8, 2, '2024-03-04 14:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (17, 9, 1, '2024-03-05 12:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (18, 9, 2, '2024-03-05 15:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (19, 10, 1, '2024-03-05 13:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (20, 10, 2, '2024-03-05 16:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (21, 1, 1, '2024-03-06 10:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (22, 2, 2, '2024-03-06 13:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (23, 2, 1, '2024-03-06 11:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (24, 2, 2, '2024-03-06 14:00:00');
INSERT INTO screenings (id, movie_id, theater_room_id, movie_start) VALUES (25, 3, 1, '2024-03-07 12:00:00');

INSERT INTO seats (row, number, theater_room_id) VALUES (1, 1, 1);
INSERT INTO seats (row, number, theater_room_id) VALUES (1, 2, 1);
INSERT INTO seats (row, number, theater_room_id) VALUES (1, 3, 1);
INSERT INTO seats (row, number, theater_room_id) VALUES (1, 4, 1);
INSERT INTO seats (row, number, theater_room_id) VALUES (1, 5, 1);
INSERT INTO seats (row, number, theater_room_id) VALUES (2, 1, 1);
INSERT INTO seats (row, number, theater_room_id) VALUES (2, 2, 1);
INSERT INTO seats (row, number, theater_room_id) VALUES (2, 3, 1);
INSERT INTO seats (row, number, theater_room_id) VALUES (2, 4, 1);
INSERT INTO seats (row, number, theater_room_id) VALUES (2, 5, 1);
INSERT INTO seats (row, number, theater_room_id) VALUES (3, 1, 1);
INSERT INTO seats (row, number, theater_room_id) VALUES (3, 2, 1);
INSERT INTO seats (row, number, theater_room_id) VALUES (3, 3, 1);
INSERT INTO seats (row, number, theater_room_id) VALUES (3, 4, 1);
INSERT INTO seats (row, number, theater_room_id) VALUES (3, 5, 1);
INSERT INTO seats (row, number, theater_room_id) VALUES (4, 1, 1);
INSERT INTO seats (row, number, theater_room_id) VALUES (4, 2, 1);
INSERT INTO seats (row, number, theater_room_id) VALUES (4, 3, 1);
INSERT INTO seats (row, number, theater_room_id) VALUES (4, 4, 1);
INSERT INTO seats (row, number, theater_room_id) VALUES (4, 5, 1);

INSERT INTO seats (row, number, theater_room_id) VALUES (1, 1, 2);
INSERT INTO seats (row, number, theater_room_id) VALUES (1, 2, 2);
INSERT INTO seats (row, number, theater_room_id) VALUES (1, 3, 2);
INSERT INTO seats (row, number, theater_room_id) VALUES (1, 4, 2);
INSERT INTO seats (row, number, theater_room_id) VALUES (1, 5, 2);
INSERT INTO seats (row, number, theater_room_id) VALUES (2, 1, 2);
INSERT INTO seats (row, number, theater_room_id) VALUES (2, 2, 2);
INSERT INTO seats (row, number, theater_room_id) VALUES (2, 3, 2);
INSERT INTO seats (row, number, theater_room_id) VALUES (2, 4, 2);
INSERT INTO seats (row, number, theater_room_id) VALUES (2, 5, 2);
INSERT INTO seats (row, number, theater_room_id) VALUES (3, 1, 2);
INSERT INTO seats (row, number, theater_room_id) VALUES (3, 2, 2);
INSERT INTO seats (row, number, theater_room_id) VALUES (3, 3, 2);
INSERT INTO seats (row, number, theater_room_id) VALUES (3, 4, 2);
INSERT INTO seats (row, number, theater_room_id) VALUES (3, 5, 2);
INSERT INTO seats (row, number, theater_room_id) VALUES (4, 1, 2);
INSERT INTO seats (row, number, theater_room_id) VALUES (4, 2, 2);
INSERT INTO seats (row, number, theater_room_id) VALUES (4, 3, 2);
INSERT INTO seats (row, number, theater_room_id) VALUES (4, 4, 2);
INSERT INTO seats (row, number, theater_room_id) VALUES (4, 5, 2);

INSERT INTO seats (row, number, theater_room_id) VALUES (1, 1, 3);
INSERT INTO seats (row, number, theater_room_id) VALUES (1, 2, 3);
INSERT INTO seats (row, number, theater_room_id) VALUES (1, 3, 3);
INSERT INTO seats (row, number, theater_room_id) VALUES (1, 4, 3);
INSERT INTO seats (row, number, theater_room_id) VALUES (1, 5, 3);
INSERT INTO seats (row, number, theater_room_id) VALUES (2, 1, 3);
INSERT INTO seats (row, number, theater_room_id) VALUES (2, 2, 3);
INSERT INTO seats (row, number, theater_room_id) VALUES (2, 3, 3);
INSERT INTO seats (row, number, theater_room_id) VALUES (2, 4, 3);
INSERT INTO seats (row, number, theater_room_id) VALUES (2, 5, 3);
INSERT INTO seats (row, number, theater_room_id) VALUES (3, 1, 3);
INSERT INTO seats (row, number, theater_room_id) VALUES (3, 2, 3);
INSERT INTO seats (row, number, theater_room_id) VALUES (3, 3, 3);
INSERT INTO seats (row, number, theater_room_id) VALUES (3, 4, 3);
INSERT INTO seats (row, number, theater_room_id) VALUES (3, 5, 3);
INSERT INTO seats (row, number, theater_room_id) VALUES (4, 1, 3);
INSERT INTO seats (row, number, theater_room_id) VALUES (4, 2, 3);
INSERT INTO seats (row, number, theater_room_id) VALUES (4, 3, 3);
INSERT INTO seats (row, number, theater_room_id) VALUES (4, 4, 3);
INSERT INTO seats (row, number, theater_room_id) VALUES (4, 5, 3);

INSERT INTO reservations (id, screening_id, paid, user_id, employee_id, payment_type) VALUES (1, 1, true, 1, 1, 'Credit Card');
INSERT INTO reservations (id,screening_id, paid, user_id, employee_id, payment_type) VALUES (2, 2, false, 2, 2, 'PayPal');
INSERT INTO reservations (id,screening_id, paid, user_id, employee_id, payment_type) VALUES (3, 3, true, 3, 3, 'Credit Card');
INSERT INTO reservations (id,screening_id, paid, user_id, employee_id, payment_type) VALUES (4, 4, true, 4, 4, 'PayPal');
INSERT INTO reservations (id,screening_id, paid, user_id, employee_id, payment_type) VALUES (5, 5, true, 5, 5, 'Credit Card');
INSERT INTO reservations (id,screening_id, paid, user_id, employee_id, payment_type) VALUES (6, 6, false, 6, 6, 'PayPal');
INSERT INTO reservations (id,screening_id, paid, user_id, employee_id, payment_type) VALUES (7, 7, true, 7, 7, 'Credit Card');
INSERT INTO reservations (id,screening_id, paid, user_id, employee_id, payment_type) VALUES (8, 8, true, 8, 8, 'PayPal');
INSERT INTO reservations (id,screening_id, paid, user_id, employee_id, payment_type) VALUES (9, 9, true, 9, 9, 'Credit Card');
INSERT INTO reservations (id,screening_id, paid, user_id, employee_id, payment_type) VALUES (10, 10, true, 10, 10, 'PayPal');
INSERT INTO reservations (id,screening_id, paid, user_id, employee_id, payment_type) VALUES (11, 11, false, 1, 1, 'Credit Card');
INSERT INTO reservations (id,screening_id, paid, user_id, employee_id, payment_type) VALUES (12, 12, true, 2, 2, 'PayPal');
INSERT INTO reservations (id,screening_id, paid, user_id, employee_id, payment_type) VALUES (13, 13, true, 3, 3, 'Credit Card');
INSERT INTO reservations (id,screening_id, paid, user_id, employee_id, payment_type) VALUES (14, 14, false, 4, 4, 'PayPal');
INSERT INTO reservations (id,screening_id, paid, user_id, employee_id, payment_type) VALUES (15, 15, true, 5, 5, 'Credit Card');
INSERT INTO reservations (id,screening_id, paid, user_id, employee_id, payment_type) VALUES (16, 16, false, 6, 6, 'PayPal');
INSERT INTO reservations (id,screening_id, paid, user_id, employee_id, payment_type) VALUES (17, 17, true, 7, 7, 'Credit Card');
INSERT INTO reservations (id,screening_id, paid, user_id, employee_id, payment_type) VALUES (18, 18, false, 8, 8, 'PayPal');
INSERT INTO reservations (id,screening_id, paid, user_id, employee_id, payment_type) VALUES (19, 19, true, 9, 9, 'Credit Card');
INSERT INTO reservations (id,screening_id, paid, user_id, employee_id, payment_type) VALUES (20, 20, true, 2, 2, 'PayPal');

INSERT INTO seats_reserved (seat_id, reservation_id, screening_id) VALUES (1, 1, 1);
INSERT INTO seats_reserved (seat_id, reservation_id, screening_id) VALUES (2, 2, 2);
INSERT INTO seats_reserved (seat_id, reservation_id, screening_id) VALUES (3, 3, 3);
INSERT INTO seats_reserved (seat_id, reservation_id, screening_id) VALUES (4, 4, 4);
INSERT INTO seats_reserved (seat_id, reservation_id, screening_id) VALUES (5, 5, 5);
INSERT INTO seats_reserved (seat_id, reservation_id, screening_id) VALUES (6, 6, 6);
INSERT INTO seats_reserved (seat_id, reservation_id, screening_id) VALUES (7, 7, 7);
INSERT INTO seats_reserved (seat_id, reservation_id, screening_id) VALUES (8, 8, 8);
INSERT INTO seats_reserved (seat_id, reservation_id, screening_id) VALUES (9, 9, 9);
INSERT INTO seats_reserved (seat_id, reservation_id, screening_id) VALUES (10, 10, 10);
INSERT INTO seats_reserved (seat_id, reservation_id, screening_id) VALUES (11, 11, 11);
INSERT INTO seats_reserved (seat_id, reservation_id, screening_id) VALUES (12, 12, 12);
INSERT INTO seats_reserved (seat_id, reservation_id, screening_id) VALUES (13, 13, 13);
INSERT INTO seats_reserved (seat_id, reservation_id, screening_id) VALUES (14, 14, 14);
INSERT INTO seats_reserved (seat_id, reservation_id, screening_id) VALUES (15, 15, 15);
INSERT INTO seats_reserved (seat_id, reservation_id, screening_id) VALUES (16, 16, 16);
INSERT INTO seats_reserved (seat_id, reservation_id, screening_id) VALUES (17, 17, 17);
INSERT INTO seats_reserved (seat_id, reservation_id, screening_id) VALUES (18, 18, 18);
INSERT INTO seats_reserved (seat_id, reservation_id, screening_id) VALUES (19, 19, 19);
INSERT INTO seats_reserved (seat_id, reservation_id, screening_id) VALUES (20, 20, 20);

INSERT INTO tickets (reservation_id, base_price, price_after_discount) VALUES (1, 15.00, 10.00);
INSERT INTO tickets (reservation_id, base_price, price_after_discount) VALUES (2, 15.00, 10.00);
INSERT INTO tickets (reservation_id, base_price, price_after_discount) VALUES (3, 15.00, 10.00);
INSERT INTO tickets (reservation_id, base_price, price_after_discount) VALUES (4, 15.00, 10.00);
INSERT INTO tickets (reservation_id, base_price, price_after_discount) VALUES (5, 15.00, 10.00);
INSERT INTO tickets (reservation_id, base_price, price_after_discount) VALUES (6, 15.00, 10.00);
INSERT INTO tickets (reservation_id, base_price, price_after_discount) VALUES (7, 15.00, 10.00);
INSERT INTO tickets (reservation_id, base_price, price_after_discount) VALUES (8, 15.00, 10.00);
INSERT INTO tickets (reservation_id, base_price, price_after_discount) VALUES (9, 15.00, 10.00);
INSERT INTO tickets (reservation_id, base_price, price_after_discount) VALUES (10, 15.00, 10.00);
INSERT INTO tickets (reservation_id, base_price, price_after_discount) VALUES (11, 15.00, 10.00);
INSERT INTO tickets (reservation_id, base_price, price_after_discount) VALUES (12, 15.00, 10.00);
INSERT INTO tickets (reservation_id, base_price, price_after_discount) VALUES (13, 15.00, 10.00);
INSERT INTO tickets (reservation_id, base_price, price_after_discount) VALUES (14, 15.00, 10.00);
INSERT INTO tickets (reservation_id, base_price, price_after_discount) VALUES (15, 15.00, 10.00);
INSERT INTO tickets (reservation_id, base_price, price_after_discount) VALUES (16, 15.00, 10.00);
INSERT INTO tickets (reservation_id, base_price, price_after_discount) VALUES (17, 15.00, 10.00);
INSERT INTO tickets (reservation_id, base_price, price_after_discount) VALUES (18, 15.00, 10.00);
INSERT INTO tickets (reservation_id, base_price, price_after_discount) VALUES (19, 15.00, 10.00);
INSERT INTO tickets (reservation_id, base_price, price_after_discount) VALUES (20, 15.00, 10.00);





