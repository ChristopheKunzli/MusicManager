-- --------------------------------------------------------
-- Hôte:                         127.0.0.1
-- Version du serveur:           10.11.2-MariaDB - mariadb.org binary distribution
-- SE du serveur:                Win64
-- HeidiSQL Version:             12.4.0.6659
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Listage de la structure de la base pour music
DROP DATABASE IF EXISTS `music`;
CREATE DATABASE IF NOT EXISTS `music` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `music`;

-- Listage de la structure de la table music. albums
DROP TABLE IF EXISTS `albums`;
CREATE TABLE IF NOT EXISTS `albums` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `TITLE` varchar(100) NOT NULL,
  `ARTIST` varchar(100) DEFAULT NULL,
  `IMAGE_LINK` varchar(1000) DEFAULT NULL,
  `YEAR` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Listage des données de la table music.albums : ~3 rows (environ)
INSERT INTO `albums` (`ID`, `TITLE`, `ARTIST`, `IMAGE_LINK`, `YEAR`) VALUES
	(1, 'Indestructilbe', 'Disturbed', 'https://upload.wikimedia.org/wikipedia/en/thumb/6/61/Indestructible_%28Disturbed_album%29_cover.jpg/220px-Indestructible_%28Disturbed_album%29_cover.jpg', 2008),
	(2, 'Ten Tousand Fists', 'Disturbed', 'https://upload.wikimedia.org/wikipedia/en/thumb/d/dd/Disturbed_-_Ten_Thousand_Fists_%28Standard%29.jpg/220px-Disturbed_-_Ten_Thousand_Fists_%28Standard%29.jpg', 2005),
	(3, 'Asylum', 'Disturbed', 'https://upload.wikimedia.org/wikipedia/en/thumb/d/db/Disturbed_Asylum_Album_Cover.jpg/220px-Disturbed_Asylum_Album_Cover.jpg', 2010);

-- Listage de la structure de la table music. tracks
DROP TABLE IF EXISTS `tracks`;
CREATE TABLE IF NOT EXISTS `tracks` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `TITLE` varchar(100) NOT NULL,
  `LINK` varchar(100) NOT NULL,
  `ALBUM_ID` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_ALBUM` (`ALBUM_ID`),
  CONSTRAINT `FK_ALBUM` FOREIGN KEY (`ALBUM_ID`) REFERENCES `albums` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Listage des données de la table music.tracks : ~38 rows (environ)
INSERT INTO `tracks` (`ID`, `TITLE`, `LINK`, `ALBUM_ID`) VALUES
	(1, 'Remnants', 'https://www.youtube.com/watch?v=Hy5u_no7vYM', 3),
	(2, 'Asylum', 'https://www.youtube.com/watch?v=hf9uU6Y2yYA', 3),
	(3, 'The Infection', 'https://www.youtube.com/watch?v=f5QlWLa7aMk', 3),
	(4, 'Warrior', 'https://www.youtube.com/watch?v=AiCn3079wOA', 3),
	(5, 'Another way to Die', 'https://www.youtube.com/watch?v=BnYh1SwZme4', 3),
	(6, 'Never Again', 'https://www.youtube.com/watch?v=wqYZUUEmPq0', 3),
	(7, 'The Animal', 'https://www.youtube.com/watch?v=t8-IASDXwQI', 3),
	(8, 'Crucified', 'https://www.youtube.com/watch?v=O1QWZKHMW-U', 3),
	(9, 'Serpentine', 'https://www.youtube.com/watch?v=yf6YRPUQZRo', 3),
	(10, 'My Child', 'https://www.youtube.com/watch?v=E5xeaYlXHwI', 3),
	(11, 'Sacrifice', 'https://www.youtube.com/watch?v=3OsnhuGvGTU', 3),
	(12, 'Innocence', 'https://www.youtube.com/watch?v=ebPDsYXCMRM', 3),
	(13, 'Ishfwilf U2 Cover', 'https://www.youtube.com/watch?v=B04UChjYb34', 3),
	(14, 'Indestructible ', 'https://www.youtube.com/watch?v=aWxBrI0g1kE', 1),
	(15, 'Inside The Fire', 'https://www.youtube.com/watch?v=rxujAPhxlo0', 1),
	(16, 'Deceiver', 'https://www.youtube.com/watch?v=3mQbvOumD0c', 1),
	(17, 'The Night', 'https://www.youtube.com/watch?v=kfLAwMftiOc', 1),
	(18, 'Perfect Insanity', 'https://www.youtube.com/watch?v=q0jCq6wwoEk', 1),
	(19, 'Haunted', 'https://www.youtube.com/watch?v=t8d1UsB3JaY', 1),
	(20, 'Enough', 'https://www.youtube.com/watch?v=QM3PfYjEHEc', 1),
	(21, 'The Curse', 'https://www.youtube.com/watch?v=8I7jv04wKHQ', 1),
	(22, 'Torn', 'https://www.youtube.com/watch?v=Zye9zX-N-Lc', 1),
	(23, 'Criminal', 'https://www.youtube.com/watch?v=QxYkMCf0F7I', 1),
	(24, 'Divide', 'https://www.youtube.com/watch?v=wqCAls1PCGw', 1),
	(25, 'Façade', 'https://www.youtube.com/watch?v=vUdaBnfEmvE', 1),
	(26, 'Ten Thousand Fists', 'https://www.youtube.com/watch?v=_wcQP2tGzu0', 2),
	(27, 'Just Stop', 'https://www.youtube.com/watch?v=bURU1TPgf0c', 2),
	(28, 'Guarded', 'https://www.youtube.com/watch?v=WeFsMiMBywU', 2),
	(29, 'Deify', 'https://www.youtube.com/watch?v=NZ_wT5qx0UM', 2),
	(30, 'I\'m Alive', 'https://www.youtube.com/watch?v=lGlbwFqtvu4', 2),
	(31, 'Sons Of Plunder', 'https://www.youtube.com/watch?v=eb_orfs6oAM', 2),
	(32, 'Overburdened', 'https://www.youtube.com/watch?v=SbXn7Osj0qY', 2),
	(33, 'Decadence', 'https://www.youtube.com/watch?v=-daTpfB-7K4', 2),
	(34, 'Forgiven', 'https://www.youtube.com/watch?v=isCx7UGvvcw', 2),
	(35, 'Land Of Confusion', 'https://www.youtube.com/watch?v=YV4oYkIeGJc', 2),
	(36, 'Sacred Lie', 'https://www.youtube.com/watch?v=b4mmz6BmJeM', 2),
	(37, 'Pain Redefined', 'https://www.youtube.com/watch?v=jxPc3uqmmEk', 2),
	(38, 'Avarice', 'https://www.youtube.com/watch?v=rMZnY1P7MS4', 2);

-- Listage de la structure de la table music. users
DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `EMAIL` varchar(200) NOT NULL,
  `PASSWORD` varchar(256) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `EMAIL` (`EMAIL`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Listage des données de la table music.users : ~3 rows (environ)
INSERT INTO `users` (`ID`, `EMAIL`, `PASSWORD`) VALUES
	(1, 'patrick.altieri@cpnv.ch', '$2a$11$MztCo7mNiQTun3wbpe0ifeQBD1dUSSbG11l6vnB47lNkm7zcbtaIC'),
	(2, 'pascal.benzonana@cpnv.ch', '$2a$11$Tw.DldMUG5xXUBNPbuRiV.G6sAqBoAeL.V3cQad6I1rBRUMf5o6ta'),
	(3, 'Frederique.ANDOLFATTO@cpnv.ch', '$2a$11$knh.0mBRVW6Nml1qmGbRxe8USt71IjAtQ89NuoUA3JMKnfAJz0ZL.');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
