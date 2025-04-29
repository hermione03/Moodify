-- Crée la base si elle n'existe pas
CREATE DATABASE IF NOT EXISTS moodify CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE moodify;

-- Supprimer les tables si elles existent (optionnel en dev)
DROP TABLE IF EXISTS Musics;
DROP TABLE IF EXISTS Moods;

-- Table des humeurs
CREATE TABLE Moods (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Feeling VARCHAR(100) NOT NULL
);

-- Table des musiques liées à une humeur avec l'année
CREATE TABLE Musics (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(255) NOT NULL,
    Artist VARCHAR(255) NOT NULL,
    Year INT NOT NULL,  -- Ajout de l'année
    MoodId INT NOT NULL,
    FOREIGN KEY (MoodId) REFERENCES Moods(Id) ON DELETE CASCADE
);

-- Insérer les humeurs
INSERT INTO Moods (Feeling) VALUES 
('Amusement'),
('joy'),
('eroticism'),
('beauty'),
('relaxation'),
('sadness'),
('dreaminess'),
('triumph'),
('anxiety'),
('scariness'),
('annoyance'),
('defiance'),
('pumped up');

-- Insérer les musiques avec l'année
-- Amusement / Joy
INSERT INTO Musics (Title, Artist, Year, MoodId) VALUES
('Good Vibrations', 'The Beach Boys', 1966, 2),
('Twist and Shout', 'The Beatles', 1963, 2),
('Dancing Queen', 'ABBA', 1976, 2),
('Hey Ya!', 'OutKast', 2003, 2),
('I Want You Back', 'The Jackson Five', 1969, 2),
('Happy', 'Pharrell Williams', 2013, 2),
('Girls Just Want to Have Fun', 'Cyndi Lauper', 1983, 2),
('September', 'Earth, Wind & Fire', 1978, 2),
('I’m a Believer', 'The Monkees', 1966, 2),
('Do You Believe in Magic', 'The Lovin’ Spoonful', 1965, 2);

-- Eroticism
INSERT INTO Musics (Title, Artist, Year, MoodId) VALUES
('Let’s Get It On', 'Marvin Gaye', 1973, 3),
('When Doves Cry', 'Prince', 1984, 3),
('Hot Stuff', 'Donna Summer', 1979, 3),
('Untitled (How Does It Feel)', 'D’Angelo', 2000, 3),
('Like a Virgin', 'Madonna', 1984, 3),
('Closer', 'Nine Inch Nails', 1994, 3),
('Toxic', 'Britney Spears', 2003, 3),
('Kiss', 'Prince', 1986, 3),
('Vogue', 'Madonna', 1990, 3),
('Let’s Stay Together', 'Al Green', 1971, 3);

-- Beauty
INSERT INTO Musics (Title, Artist, Year, MoodId) VALUES
('God Only Knows', 'The Beach Boys', 1966, 4),
('Bridge Over Troubled Water', 'Simon & Garfunkel', 1970, 4),
('Hallelujah', 'Jeff Buckley', 1994, 4),
('Yesterday', 'The Beatles', 1965, 4),
('Landslide', 'Fleetwood Mac', 1975, 4),
('What a Wonderful World', 'Louis Armstrong', 1967, 4),
('Both Sides Now', 'Joni Mitchell', 1969, 4),
('Rolling in the Deep', 'Adele', 2011, 4),
('Fade Into You', 'Mazzy Star', 1993, 4),
('Suzanne', 'Leonard Cohen', 1967, 4);

-- Relaxation
INSERT INTO Musics (Title, Artist, Year, MoodId) VALUES
('No Woman, No Cry', 'Bob Marley', 1974, 5),
('Sunday Morning', 'The Velvet Underground', 1967, 5),
('Don’t Know Why', 'Norah Jones', 2002, 5),
('Breathe', 'Pink Floyd', 1973, 5),
('Smooth Operator', 'Sade', 1984, 5),
('Banana Pancakes', 'Jack Johnson', 2005, 5),
('La Femme d’Argent', 'Air', 1998, 5),
('Moondance', 'Van Morrison', 1970, 5),
('Pink Moon', 'Nick Drake', 1972, 5),
('Lovely Day', 'Bill Withers', 1977, 5);

-- Sadness
INSERT INTO Musics (Title, Artist, Year, MoodId) VALUES
('Crying', 'Roy Orbison', 1962, 6),
('Strange Fruit', 'Billie Holiday', 1939, 6),
('There Is a Light That Never Goes Out', 'The Smiths', 1986, 6),
('Love Will Tear Us Apart', 'Joy Division', 1980, 6),
('Hallelujah', 'Leonard Cohen', 1984, 6),
('Fast Car', 'Tracy Chapman', 1988, 6),
('Fake Plastic Trees', 'Radiohead', 1994, 6),
('Someone Like You', 'Adele', 2011, 6),
('Something in the Way', 'Nirvana', 1991, 6),
('I’m So Lonesome I Could Cry', 'Hank Williams', 1949, 6);

-- Dreaminess
INSERT INTO Musics (Title, Artist, Year, MoodId) VALUES
('Strawberry Fields Forever', 'The Beatles', 1967, 7),
('Wish You Were Here', 'Pink Floyd', 1975, 7),
('Cherry-Coloured Funk', 'Cocteau Twins', 1990, 7),
('Dreams', 'The Cranberries', 1993, 7),
('Video Games', 'Lana Del Rey', 2011, 7),
('Let It Happen', 'Tame Impala', 2015, 7),
('Heroin', 'The Velvet Underground', 1967, 7),
('Pyramid Song', 'Radiohead', 2001, 7),
('Svefn-g-englar', 'Sigur Rós', 1999, 7),
('Myth', 'Beach House', 2012, 7);

-- Triumph
INSERT INTO Musics (Title, Artist, Year, MoodId) VALUES
('We Are the Champions', 'Queen', 1977, 8),
('Eye of the Tiger', 'Survivor', 1982, 8),
('Stronger', 'Kanye West', 2007, 8),
('Lose Yourself', 'Eminem', 2002, 8),
('I Will Survive', 'Gloria Gaynor', 1978, 8),
('Roar', 'Katy Perry', 2013, 8),
('Don’t Stop Believin’', 'Journey', 1981, 8),
('Gonna Fly Now (Rocky Theme)', 'Bill Conti', 1976, 8),
('The Climb', 'Miley Cyrus', 2009, 8),
('Tubthumping', 'Chumbawamba', 1997, 8);

-- Anxiety / Scariness
INSERT INTO Musics (Title, Artist, Year, MoodId) VALUES
('The End', 'The Doors', 1967, 9),
('Comfortably Numb', 'Pink Floyd', 1979, 9),
('Paranoid Android', 'Radiohead', 1997, 9),
('Heart-Shaped Box', 'Nirvana', 1993, 9),
('Paranoid', 'Black Sabbath', 1970, 9),
('Disorder', 'Joy Division', 1979, 9),
('Hurt', 'Nine Inch Nails', 1994, 9),
('A Forest', 'The Cure', 1980, 9),
('Blackstar', 'David Bowie', 2016, 9),
('Angel', 'Massive Attack', 1998, 9);

-- Annoyance / Defiance
INSERT INTO Musics (Title, Artist, Year, MoodId) VALUES
('Anarchy in the UK', 'Sex Pistols', 1976, 10),
('Killing in the Name', 'Rage Against the Machine', 1992, 10),
('Fight the Power', 'Public Enemy', 1989, 10),
('London Calling', 'The Clash', 1979, 10),
('Fuck tha Police', 'N.W.A', 1988, 10),
('Alright', 'Kendrick Lamar', 2015, 10),
('American Idiot', 'Green Day', 2004, 10),
('Holiday in Cambodia', 'Dead Kennedys', 1980, 10),
('Chop Suey!', 'System of a Down', 2001, 10),
('Close Your Eyes', 'Run the Jewels', 2016, 10);

-- Pumped Up
INSERT INTO Musics (Title, Artist, Year, MoodId) VALUES
('Eye of the Tiger', 'Survivor', 1982, 11),
('Welcome to the Jungle', 'Guns N’ Roses', 1987, 11),
('Highway to Hell', 'AC/DC', 1979, 11),
('Kickstart My Heart', 'Mötley Crüe', 1989, 11),
('Enter Sandman', 'Metallica', 1991, 11),
('Seven Nation Army', 'The White Stripes', 2003, 11),
('Till I Collapse', 'Eminem', 2002, 11),
('Power', 'Kanye West', 2010, 11),
('X Gon’ Give It to Ya', 'DMX', 2003, 11),
('Sabotage', 'Beastie Boys', 1994, 11);


