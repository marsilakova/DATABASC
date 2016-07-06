-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: gamestore
-- ------------------------------------------------------
-- Server version	5.7.12-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `games`
--

DROP TABLE IF EXISTS `games`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `games` (
  `GameID` int(11) NOT NULL AUTO_INCREMENT,
  `Image` varchar(15) NOT NULL,
  `gName` varchar(100) NOT NULL,
  `Description` varchar(500) NOT NULL,
  `Category` varchar(50) NOT NULL,
  `Price` decimal(16,2) NOT NULL,
  `UserID` int(20) NOT NULL,
  PRIMARY KEY (`GameID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `games`
--

LOCK TABLES `games` WRITE;
/*!40000 ALTER TABLE `games` DISABLE KEYS */;
INSERT INTO `games` VALUES (1,'','SimCity','Градостроительный симулятор снова с вами! Создайте город своей мечты','Симулятор',1499.00,0),(2,'','TITANFALL','Эта игра перенесет вас во вселенную, где малое противопоставляется большому, природа – индустрии, а человек – машине','Шутер',2299.00,0),(3,'','Battlefield 4','Battlefield 4 – это определяющий для жанра, полный экшена боевик, известный своей разрушаемостью, равных которой нет','Шутер',899.40,0),(4,'','The Sims 4','В реальности каждому человеку дано прожить лишь одну жизнь. Но с помощью The Sims 4 это ограничение можно снять! 		Вам решать — где, как и с кем жить, чем заниматься, чем украшать и обустраивать свой дом','Симулятор',150.00,0),(5,'','Dark Souls 2','Продолжение знаменитого ролевого экшена вновь заставит игроков пройти через сложнейшие испытания. Dark Souls II предложит \n		нового героя, новую историю и новый мир. Лишь одно неизменно – выжить в мрачной вселенной Dark Souls очень непросто.','RPG',949.00,0),(6,'','The Elder Scrolls V: Skyrim','После убийства короля Скайрима империя оказалась на грани катастрофы. Вокруг претендентов на престол сплотились новые союзы, \n		и разгорелся конфликт. К тому же, как предсказывали древние свитки, в мир вернулись жестокие и беспощадные драконы. Теперь будущее Скайрима и всей \n		империи зависит от драконорожденного — человека, в жилах которого течет кровь легендарных существ.','RPG',1399.00,0),(7,'','FIFA 14','Достоверный, красивый, эмоциональный футбол! Проверенный временем геймплей FIFA стал ещё лучше благодаря инновациям, поощряющим творческую игру в\n		 центре поля и позволяющим задавать её темп.','Симулятор',699.00,0),(8,'','Need for Speed Rivals','Забудьте про стандартные режимы игры. Сотрите грань между одиночным и многопользовательским режимом в постоянном соперничестве \n		между гонщиками и полицией. Свободно войдите в мир, в котором ваши друзья уже участвуют в гонках и погонях. ','Симулятор',15.00,0),(9,'','Crysis 3','Действие игры разворачивается в 2047 году, а вам предстоит выступить в роли Пророка.','Шутер',1299.00,0),(10,'','Dead Space 3','В Dead Space 3 Айзек Кларк и суровый солдат Джон Карвер отправляются в космическое путешествие, чтобы узнать о происхождении некроморфов.','Шутер',499.00,0);
/*!40000 ALTER TABLE `games` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-07-04  9:32:40
