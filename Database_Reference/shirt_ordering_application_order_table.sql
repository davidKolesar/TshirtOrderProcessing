-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: shirt_ordering_application
-- ------------------------------------------------------
-- Server version	8.0.23

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `order_table`
--

DROP TABLE IF EXISTS `order_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order_table` (
  `idorder_table` int NOT NULL,
  `date` datetime DEFAULT NULL,
  `name` varchar(100) NOT NULL,
  `address` varchar(200) NOT NULL,
  `phone` varchar(45) DEFAULT NULL,
  `color` varchar(45) NOT NULL,
  `size` varchar(45) NOT NULL,
  `price` double NOT NULL,
  `quantity` double NOT NULL,
  `total_cost` double NOT NULL,
  `status` varchar(45) NOT NULL,
  `notes` mediumtext,
  PRIMARY KEY (`idorder_table`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_table`
--

LOCK TABLES `order_table` WRITE;
/*!40000 ALTER TABLE `order_table` DISABLE KEYS */;
INSERT INTO `order_table` VALUES (67,'2021-02-11 00:00:00','UPDATED NAME','UPDATED ADDRESS','6663336666','RED','CHILD',5,6,30,'NEW','UPDATED NOTES            '),(618,'2021-02-11 00:00:00','Test Again','9292 lol lane, lmao GA','9939994902','RED','CHILD',5,9,45,'NEW',''),(1955,'2021-02-11 00:00:00','Baby Dave','878 houglass lane','9999888989','INDIGO','CHILD',5,3,15,'NEW',''),(4087,'2021-02-10 00:00:00','Santa Clause','North Pole','8675309','RED','EXTRALARGE',18,2,36,'NEW','Do not interrupt Reindeer Games.             '),(6030,'2021-02-11 00:00:00','Orchard','3982 South Hills lane Erwin Georgia 993890','9993898839','RED','CHILD',5,5,25,'NEW','Turkey Shirts            '),(7545,'2021-02-11 00:00:00','TestModal','TestAddressAgain','9383939383','YELLOW','LARGE',14,7,98,'NEW','Notes notes notes'),(7891,'2021-02-11 00:00:00','Silas','Trinity Lane','9893372219','ORANGE','MEDIUM',10,5,50,'NEW',''),(9129,'2021-02-11 00:00:00','TestMan','TestHouse','9993338938','RED','CHILD',5,4,20,'NEW','Test Notes            '),(9953,'2021-02-11 00:00:00','White Rabbit','2989 East Coast Drive','398292019','YELLOW','CHILD',5,4,20,'NEW',''),(10574,'2021-02-11 00:00:00','gatido','398 Second street Williamsport, Pa 39839','3982282919','RED','CHILD',5,3,15,'NEW','Todos q paso            '),(11749,'2021-02-11 00:00:00','Chef Salad','9292 lol lane, lmao GA','3982927191','GREEN','MEDIUM',10,3,30,'NEW','Shirts for preparing food'),(12998,'2021-02-11 00:00:00','Barry White','110 Reindeer Lane, North Pole, AL 16620','2928993839','ORANGE','CHILD',5,3,15,'NEW',''),(13015,'2021-02-11 00:00:00','Douglas Devon','938 Junkyard road','9939929929','RED','CHILD',5,9,45,'NEW','Phone number Change            '),(13734,'2021-02-11 00:00:00','test','Test Address','-2','RED','CHILD',5,3,15,'NEW',''),(13839,'2021-02-11 00:00:00','test','Test Address','333','RED','CHILD',5,3,15,'NEW',''),(15081,'2021-02-11 00:00:00','Test Data','Test Address','9393999999','INDIGO','MEDIUM',10,9,90,'NEW',''),(15991,'2021-02-11 00:00:00','Barry White','110 Reindeer Lane, North Pole, AL 16620','3982229109','RED','CHILD',5,1,5,'NEW',''),(17377,'2021-02-11 00:00:00','Knoppix','393 Ostrich Ave. ','3392281728','BLUE','MEDIUM',10,7,70,'NEW','Ostrich Sized            '),(18302,'2021-02-11 00:00:00','Devon Guitar','Shredder Lane','9839920010','VIOLET','CHILD',5,3,15,'NEW','Shirts for band'),(23180,'2021-02-11 00:00:00','Bobby Bo','398 Second street Williamsport, Pa 39839','3887772728','VIOLET','MEDIUM',10,5,50,'NEW',''),(23638,'2021-02-11 00:00:00','Irene','Meow','938392829','GREEN','EXTRALARGE',18,4,72,'NEW','No Notes'),(24146,'2021-02-11 00:00:00','Simon','398 Second street Williamsport, Pa 39839','2239989849','BLUE','MEDIUM',10,0,0,'NEW',''),(24529,'2021-02-11 00:00:00','Bary','Eagleton','3379290010','RED','CHILD',5,1,5,'NEW',''),(25701,'2021-02-11 00:00:00','David','Krafton','39827662879','RED','LARGE',14,7,98,'NEW',''),(27217,'2021-02-11 00:00:00','Fat Albert','938 Junkyard road','4982291094','RED','EXTRALARGE',18,3,54,'NEW',''),(27377,'2021-02-11 00:00:00','Theodore','9292 lol lane, lmao GA','3339990000','INDIGO','LARGE',14,12,168,'NEW',''),(27979,'2021-02-11 00:00:00','Cow','110 Reindeer Lane, North Pole, AL 16620','3387282989','BLUE','EXTRALARGE',18,1,18,'NEW',''),(29022,'2021-02-11 00:00:00','Bug Fixer','Boxing Glove Street 98290','3339827710','RED','CHILD',5,4,20,'NEW','Fixed Bug            '),(30708,'2021-02-11 00:00:00','Canned Data','Canned Address','9982287171','RED','CHILD',5,4,20,'NEW','Notes            '),(32362,'2021-02-11 00:00:00','Testy McTestFace','Test Address','3339990000','RED','LARGE',14,9,126,'NEW','Testing            '),(34182,'2021-02-11 00:00:00','Johnny Applesauce','333 Noel Rode','33399933333','GREEN','MEDIUM',10,3,30,'NEW',''),(35913,'2021-02-11 00:00:00','Test Again','398 Second street Williamsport, Pa 39839','333333333','RED','CHILD',5,3,15,'NEW','3            '),(37087,'2021-02-11 00:00:00','Water Bottle','289 Pond Ave. Lillith, New Mexico 38829','2981110090','VIOLET','SMALL',8,6,48,'NEW','Shirt for water bottle company'),(37524,'2021-02-11 00:00:00','Test Again','410 mary street','3939992829','RED','CHILD',5,9,45,'NEW',''),(37861,'2021-02-11 00:00:00','Todd','Swoope','983902918','ORANGE','EXTRALARGE',18,2,36,'NEW','Body Builder Sleeve  Option'),(38962,'2021-02-11 00:00:00','Fat Albert','3982 South Hills lane Erwin Georgia 993890','33223222','RED','CHILD',5,1,5,'NEW',''),(39229,'2021-02-11 00:00:00','TestHat','Test address','99889989','RED','CHILD',5,8,40,'NEW',''),(39491,'2021-02-11 00:00:00','Deer Park','Water Bottle Ave','3938299928','BLUE','MEDIUM',10,8,80,'NEW',''),(41532,'2021-02-11 00:00:00','Jon Jones','Boxing Glove Street 98290','3901112983','RED','CHILD',5,2,10,'NEW','Fragile'),(47732,'2021-02-11 00:00:00','David Kolesar','false Data','93839','INDIGO','SMALL',8,33,264,'NEW','');
/*!40000 ALTER TABLE `order_table` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-02-11 12:08:35
