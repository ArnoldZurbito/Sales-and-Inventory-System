-- MySQL dump 10.13  Distrib 5.7.11, for Win64 (x86_64)
--
-- Host: localhost    Database: red_cheese_pizza_database
-- ------------------------------------------------------
-- Server version	5.7.11

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
-- Table structure for table `category`
--

DROP TABLE IF EXISTS `category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `category` (
  `Cat_ID` int(50) NOT NULL AUTO_INCREMENT,
  `Cat_Name` varchar(50) NOT NULL,
  PRIMARY KEY (`Cat_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category`
--

LOCK TABLES `category` WRITE;
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` VALUES (1,'Burgers and Sandwiches'),(2,'Snacks'),(3,'Mexican Dishes'),(4,'Main Dishes'),(5,'Chicken'),(6,'Pasta'),(7,'Pizzas'),(8,'Combo Meals'),(9,'Rice Meals'),(10,'Dessert'),(11,'Smothies'),(12,'Beverages');
/*!40000 ALTER TABLE `category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `logs`
--

DROP TABLE IF EXISTS `logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `logs` (
  `Log_ID` int(50) NOT NULL AUTO_INCREMENT,
  `Log_View` text NOT NULL,
  `Log_Date` datetime NOT NULL,
  `User_Company_ID` int(50) NOT NULL,
  PRIMARY KEY (`Log_ID`),
  KEY `User_Company_ID` (`User_Company_ID`),
  CONSTRAINT `logs_ibfk_1` FOREIGN KEY (`User_Company_ID`) REFERENCES `user_table` (`User_Company_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=501 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `logs`
--

LOCK TABLES `logs` WRITE;
/*!40000 ALTER TABLE `logs` DISABLE KEYS */;
INSERT INTO `logs` VALUES (69,'e','2016-09-20 14:18:34',3),(238,'judith trying to log in at ','2016-09-21 14:56:18',3),(239,'judith were logout at ','2016-09-21 15:06:12',3),(242,'judith trying to log in at ','2016-09-21 15:44:29',3),(243,'judith were logout at ','2016-09-21 15:48:32',3),(249,'judith trying to log in at ','2016-09-28 20:30:14',3),(250,'judith were logout at ','2016-09-28 20:32:21',3),(262,'mylyn trying to log in at ','2016-09-29 16:13:25',7),(264,'mylyn were logout at ','2016-09-29 16:15:58',7),(265,'judith trying to log in at ','2016-09-29 19:56:19',3),(266,'judith were logout at ','2016-09-29 20:11:19',3),(267,'neneng trying to log in at ','2016-09-29 20:11:33',8),(268,'neneng were logout at ','2016-09-29 20:11:46',8),(269,'mylyn trying to log in at ','2016-09-29 20:11:59',7),(270,'mylyn were logout at ','2016-09-29 20:14:43',7),(271,'judith trying to log in at ','2016-09-29 20:15:12',3),(272,'judith trying to log in at ','2016-09-30 23:05:42',3),(273,'judith add raw materials which is  cucumber, Quantity = 1 kG/s, Expiration Date = 2016-10-11 at ','2016-10-01 02:18:51',3),(274,'judith add raw materials which is  Shawarma Sauce, Quantity = 500 mL/s, Expiration Date = 2016-10-15 at ','2016-10-01 02:22:40',3),(275,'mylyn trying to log in at ','2016-10-01 13:51:35',7),(276,'mylyn were logout at ','2016-10-01 13:51:54',7),(277,'neneng trying to log in at ','2016-10-01 13:52:02',8),(278,'neneng add raw materials which is  fries, Quantity = 2 kG/s, Expiration Date = 2016-12-14 at ','2016-10-01 14:13:38',8),(279,'neneng were logout at ','2016-10-01 14:15:56',8),(280,'mylyn trying to log in at ','2016-10-01 14:42:43',7),(281,'mylyn add raw materials which is  Buffalo Sauce, Quantity = 1 liter/s, Expiration Date = 2016-10-22 at ','2016-10-01 14:50:10',7),(282,'mylyn add raw materials which is  Honey Mustard Sauce, Quantity = 1 liter/s, Expiration Date = 2016-10-22 at ','2016-10-01 14:53:51',7),(283,'mylyn add raw materials which is  Chilidog Sauce, Quantity = 1 liter/s, Expiration Date = 2016-10-22 at ','2016-10-01 14:54:22',7),(284,'mylyn add raw materials which is  Mayonnaise, Quantity = 200 liter/s, Expiration Date = 2016-12-28 at ','2016-10-01 14:55:00',7),(285,'judith trying to log in at ','2016-10-01 21:41:04',3),(286,'judith add raw materials which is  Pepperoni, Quantity = 3 kG/s, Expiration Date = 2016-12-15 at ','2016-10-01 21:42:05',3),(287,'judith add raw materials which is  Rice, Quantity = 5 kG/s, Expiration Date = 2016-12-31 at ','2016-10-01 21:43:14',3),(288,'judith add raw materials which is  Buko, Quantity = 1 kG/s, Expiration Date = 2016-10-14 at ','2016-10-01 21:49:22',3),(289,'judith add raw materials which is  Pandan Jelly, Quantity = 500 gram/s, Expiration Date = 2016-12-15 at ','2016-10-01 21:49:55',3),(290,'judith were logout at ','2016-10-01 21:51:28',3),(291,'mylyn trying to log in at ','2016-10-02 10:31:42',7),(292,'mylyn were logout at ','2016-10-02 11:35:45',7),(293,'judith trying to log in at ','2016-10-02 11:36:02',3),(294,'judith add raw materials which is  tomatoe, Quantity = 1 kG/s, Expiration Date = 2016-10-12 at ','2016-10-02 12:09:29',3),(295,'judith were logout at ','2016-10-02 21:46:59',3),(296,'mylyn trying to log in at ','2016-10-03 21:33:34',7),(297,'mylyn were logout at ','2016-10-03 21:33:38',7),(298,'mylyn trying to log in at ','2016-10-03 21:34:37',7),(300,'mylyn were logout at ','2016-10-03 22:03:16',7),(301,'neneng trying to log in at ','2016-10-04 18:39:32',8),(302,'neneng trying to log in at ','2016-10-04 18:45:03',8),(303,'neneng were logout at ','2016-10-04 18:50:10',8),(304,'mylyn trying to log in at ','2016-10-04 18:50:18',7),(305,'mylyn were logout at ','2016-10-04 20:10:20',7),(306,'neneng trying to log in at ','2016-10-04 20:10:30',8),(307,'neneng were logout at ','2016-10-04 21:49:17',8),(308,'mylyn trying to log in at ','2016-10-04 21:49:30',7),(309,'mylyn were logout at ','2016-10-04 22:43:54',7),(310,'neneng trying to log in at ','2016-10-04 22:44:13',8),(311,'neneng were logout at ','2016-10-04 22:58:31',8),(312,'mylyn trying to log in at ','2016-10-04 22:58:42',7),(313,'mylyn were logout at ','2016-10-05 09:49:33',7),(314,'mylyn trying to log in at ','2016-10-06 09:41:08',7),(315,'mylyn were logout at ','2016-10-06 09:50:26',7),(316,'mylyn trying to log in at ','2016-10-06 09:58:41',7),(317,'mylyn were logout at ','2016-10-06 10:04:25',7),(318,'mylyn trying to log in at ','2016-10-06 10:27:42',7),(319,'mylyn were logout at ','2016-10-06 10:32:37',7),(320,'mylyn trying to log in at ','2016-10-06 14:03:36',7),(321,' Admin add new account to Randy Espinosa. Jaucian at ','2016-10-06 14:33:36',7),(322,'mylyn trying to log in at ','2016-10-06 14:34:36',7),(323,' Admin remove an account of Randy Jaucian Espinosa at ','2016-10-06 14:42:20',7),(324,'mylyn remove 3.456 kG/s of Bacon on ','2016-10-06 14:46:34',7),(325,'mylyn were logout at ','2016-10-06 15:20:09',7),(326,'mylyn trying to log in at ','2016-10-09 12:06:09',7),(327,'mylyn were logout at ','2016-10-09 12:10:18',7),(328,'judith trying to log in at ','2016-10-09 12:10:30',3),(329,'judith were add 10 kG/s of Rice on ','2016-10-09 12:12:43',3),(330,'judith add raw materials which is  Lettuce, Quantity = 1 kG/s, Expiration Date = 2016-10-14 at ','2016-10-09 12:13:34',3),(331,'judith add raw materials which is  Cabbage, Quantity = 1 kG/s, Expiration Date = 2016-10-14 at ','2016-10-09 12:13:51',3),(332,'judith add raw materials which is  Ranch Sauce, Quantity = 500 mL/s, Expiration Date = 2016-10-21 at ','2016-10-09 12:15:20',3),(333,'judith were logout at ','2016-10-09 12:15:56',3),(334,'Judith were add 10 Solo of Beef Ball Spaghetti on ','2016-10-09 12:16:56',3),(335,'Judith were add 10 Solo of Beef Salpicao on ','2016-10-09 12:17:20',3),(336,'judith trying to log in at ','2016-10-09 13:30:05',3),(337,'judith were logout at ','2016-10-09 14:26:56',3),(338,'judith trying to log in at ','2016-10-09 14:53:42',3),(339,'judith add raw materials which is  coriander, Quantity = 250 gram/s, Expiration Date = 2016-10-14 at ','2016-10-09 14:57:09',3),(340,'judith were adding a new product which is biryani on ','2016-10-09 14:57:38',3),(341,'judith were add 10 Solo of biryani on ','2016-10-09 14:59:13',3),(342,'judith removing expired raw material which is White Onion on ','2016-10-09 15:01:34',3),(343,'judith removing expired raw material which is tomatoe on ','2016-10-09 15:01:34',3),(344,'judith removing expired raw material which is Sugar on ','2016-10-09 15:01:34',3),(345,'judith add raw materials which is  Bread Crumbs, Quantity = 1 kG/s, Expiration Date = 2017-01-12 at ','2016-10-09 15:31:28',3),(346,'judith add raw materials which is  Vinegar, Quantity = 500 mL/s, Expiration Date = 2017-03-29 at ','2016-10-09 15:40:06',3),(347,'judith add raw materials which is  Woecestire Sauce, Quantity = 200 mL/s, Expiration Date = 2017-02-14 at ','2016-10-09 15:40:59',3),(348,'judith add raw materials which is  Corn Starch, Quantity = 200 gram/s, Expiration Date = 2017-02-23 at ','2016-10-09 15:41:52',3),(349,'judith add raw materials which is  Cayenne Pepper, Quantity = 450 gram/s, Expiration Date = 2017-03-31 at ','2016-10-09 15:42:23',3),(350,'judith add raw materials which is  Oyster Sauce, Quantity = 405 gram/s, Expiration Date = 2017-02-06 at ','2016-10-09 15:42:48',3),(351,'judith add raw materials which is  Kikkoman Soy Sauce, Quantity = 500 mL/s, Expiration Date = 2017-02-22 at ','2016-10-09 15:43:28',3),(352,'judith add raw materials which is  Nachos Chips, Quantity = 180 gram/s, Expiration Date = 2016-12-21 at ','2016-10-09 15:43:53',3),(353,'judith add raw materials which is  Three Cheese Sauce, Quantity = 1 kG/s, Expiration Date = 2017-03-17 at ','2016-10-09 15:44:33',3),(354,'judith remove 5 piece/s of All Purpose Cream on ','2016-10-09 15:44:47',3),(355,'judith add raw materials which is  Eden Cheese, Quantity = 1 kG/s, Expiration Date = 2017-04-14 at ','2016-10-09 15:48:07',3),(356,'judith add raw materials which is  APC, Quantity = 2 kG/s, Expiration Date = 2017-04-12 at ','2016-10-09 15:48:39',3),(357,'judith add raw materials which is  Kung Pao Sauce, Quantity = 1 kG/s, Expiration Date = 2017-04-27 at ','2016-10-09 15:49:48',3),(358,'judith were add 200 gram/s of Italian Seasoning on ','2016-10-09 15:51:05',3),(359,'judith add raw materials which is  Fresh Milk, Quantity = 3 liter/s, Expiration Date = 2017-01-25 at ','2016-10-09 15:52:13',3),(360,'judith add raw materials which is  Bombay Biryani, Quantity = 350 gram/s, Expiration Date = 2017-01-10 at ','2016-10-09 15:52:46',3),(361,'judith add raw materials which is  Korma Powder, Quantity = 250 gram/s, Expiration Date = 2017-06-22 at ','2016-10-09 15:53:17',3),(362,'judith add raw materials which is  Taco Seasoning, Quantity = 450 gram/s, Expiration Date = 2017-09-14 at ','2016-10-09 15:53:52',3),(363,'judith add raw materials which is  Black Pepper Ground, Quantity = 450 gram/s, Expiration Date = 2017-09-19 at ','2016-10-09 15:54:18',3),(364,'judith add raw materials which is  Oregano Powder, Quantity = 10 gram/s, Expiration Date = 2017-09-14 at ','2016-10-09 15:54:47',3),(365,'judith add raw materials which is  Cumin Seed, Quantity = 10 gram/s, Expiration Date = 2017-09-27 at ','2016-10-09 15:55:04',3),(366,'judith add raw materials which is  Spanish Paprika Powder, Quantity = 470 gram/s, Expiration Date = 2017-07-11 at ','2016-10-09 15:55:45',3),(367,'judith add raw materials which is  Garlic Powder, Quantity = 500 gram/s, Expiration Date = 2017-09-14 at ','2016-10-09 15:56:06',3),(368,'judith add raw materials which is  Garlic Oil, Quantity = 500 mL/s, Expiration Date = 2016-10-14 at ','2016-10-09 15:57:27',3),(369,'judith add raw materials which is  Enchilada, Quantity = 200 mL/s, Expiration Date = 2017-01-18 at ','2016-10-09 15:58:18',3),(370,'judith add raw materials which is  Orange Chicken Sauce, Quantity = 200 mL/s, Expiration Date = 2017-01-19 at ','2016-10-09 15:58:49',3),(371,'judith add raw materials which is  Japanese Rice, Quantity = 1 kG/s, Expiration Date = 2017-06-30 at ','2016-10-09 15:59:11',3),(372,'judith add raw materials which is  Tuna Bicol Express, Quantity = 500 gram/s, Expiration Date = 2016-10-21 at ','2016-10-09 16:00:14',3),(373,'judith add raw materials which is  Tempura Butter, Quantity = 500 gram/s, Expiration Date = 2017-06-14 at ','2016-10-09 16:01:30',3),(374,'judith add raw materials which is  Cream Cheese, Quantity = 1 kG/s, Expiration Date = 2017-06-16 at ','2016-10-09 16:03:02',3),(375,'judith add raw materials which is  Potatoes, Quantity = 1 kG/s, Expiration Date = 2016-10-21 at ','2016-10-09 16:08:58',3),(376,'judith add raw materials which is  Carrot, Quantity = 1 kG/s, Expiration Date = 2016-10-26 at ','2016-10-09 16:10:44',3),(377,'judith add raw materials which is  Local tomatoe, Quantity = 1 kG/s, Expiration Date = 2016-10-20 at ','2016-10-09 16:11:29',3),(378,'judith add raw materials which is  Baguio Tomatoe, Quantity = 1 kG/s, Expiration Date = 2016-10-20 at ','2016-10-09 16:12:23',3),(379,'judith add raw materials which is  Onion Leaves, Quantity = 200 gram/s, Expiration Date = 2016-10-19 at ','2016-10-09 16:12:50',3),(380,'judith add raw materials which is  Sili Haba, Quantity = 500 gram/s, Expiration Date = 2016-10-20 at ','2016-10-09 16:13:08',3),(381,'judith add raw materials which is  Ginger, Quantity = 300 gram/s, Expiration Date = 2016-10-21 at ','2016-10-09 16:13:51',3),(382,'judith add raw materials which is  Orange, Quantity = 500 gram/s, Expiration Date = 2016-10-23 at ','2016-10-09 16:14:28',3),(383,'judith add raw materials which is  Mango, Quantity = 1 kG/s, Expiration Date = 2016-10-28 at ','2016-10-09 16:15:41',3),(384,'judith add raw materials which is  Grape, Quantity = 1 kG/s, Expiration Date = 2017-01-19 at ','2016-10-09 16:16:41',3),(385,'judith add raw materials which is  Papaya, Quantity = 1 kG/s, Expiration Date = 2017-01-18 at ','2016-10-09 16:17:01',3),(386,'judith add raw materials which is  Calamansi, Quantity = 1 kG/s, Expiration Date = 2016-11-25 at ','2016-10-09 16:17:24',3),(387,'judith add raw materials which is  Chicken fillet, Quantity = 1 kG/s, Expiration Date = 2016-10-24 at ','2016-10-09 16:17:55',3),(388,'judith add raw materials which is  Tinapa, Quantity = 500 gram/s, Expiration Date = 2016-10-19 at ','2016-10-09 16:18:13',3),(389,'judith add raw materials which is  Balaw, Quantity = 500 gram/s, Expiration Date = 2016-10-28 at ','2016-10-09 16:18:34',3),(390,'judith were logout at ','2016-10-09 16:19:42',3),(391,'judith trying to log in at ','2016-10-09 17:18:09',3),(392,'judith were add 20 Solo of Rice on ','2016-10-09 18:25:44',3),(393,'judith were logout at ','2016-10-09 18:27:37',3),(394,'mylyn trying to log in at ','2016-10-12 12:55:34',7),(395,'mylyn were adding a new product which is Shawarma on ','2016-10-12 12:56:32',7),(396,'mylyn were add 10 piece/s of Shawarma on ','2016-10-12 12:56:52',7),(397,'mylyn were add 10 Solo of Spicy Tuna on ','2016-10-12 12:58:17',7),(398,'mylyn modify our product name : Spicy Tuna to  Spicy Tuna Roll on ','2016-10-12 12:58:41',7),(399,'mylyn were add 20 Solo of Chicken Alfredo on ','2016-10-12 13:06:38',7),(400,'mylyn deleting product name which is Shawarma on ','2016-10-12 13:11:34',7),(401,'mylyn deleting product name which is Nestea together with its raw materials on ','2016-10-12 13:12:21',7),(402,'mylyn were add 10 piece/s of Beef Shawarma on ','2016-10-12 13:12:58',7),(403,'mylyn were add 10 piece/s of Chicken Tenders on ','2016-10-12 13:14:12',7),(404,'mylyn were add 20 8 oz. of Bottled Water on ','2016-10-12 13:14:46',7),(405,'mylyn remove our Product which is  Bottled Water on ','2016-10-12 13:15:10',7),(406,'mylyn were add 10 piece/s of Buffalo Wings (2pcs) on ','2016-10-12 13:16:19',7),(407,'mylyn were add 5 piece/s of Buffalo Wings (4pcs) on ','2016-10-12 13:16:37',7),(408,'neneng trying to log in at ','2016-10-12 13:18:19',8),(409,'neneng were logout at ','2016-10-12 23:13:02',8),(410,'judith trying to log in at ','2016-10-13 12:42:53',3),(411,'judith were add 10 piece/s of Chicken Quesadillas on ','2016-10-13 12:46:22',3),(412,'judith were adding a new product which is Samosa Veg on ','2016-10-13 12:48:02',3),(413,'judith were add 20 piece/s of Samosa Veg on ','2016-10-13 12:52:14',3),(414,'judith were add 20 Solo of Pasta Albayana on ','2016-10-13 12:54:25',3),(415,'judith were adding a new product which is Chicken Fajita Meal on ','2016-10-13 12:55:29',3),(416,'judith were add 149 Solo of Chicken Fajita Meal on ','2016-10-13 12:55:47',3),(417,'judith were adding a new product which is Choco Brownies on ','2016-10-13 13:17:06',3),(418,'judith were add 25 piece/s of Choco Brownies on ','2016-10-13 13:17:37',3),(419,'judith were logout at ','2016-10-13 17:45:59',3),(420,'neneng trying to log in at ','2016-10-13 17:46:09',8),(421,'neneng add raw materials which is  Sugar Syrup, Quantity = 500 mL/s, Expiration Date = 2016-11-10 at ','2016-10-13 17:55:53',8),(422,'neneng add raw materials which is  Tortilla, Quantity = 500 gram/s, Expiration Date = 2016-10-28 at ','2016-10-13 18:07:10',8),(423,'neneng add raw materials which is  Baguette, Quantity = 500 gram/s, Expiration Date = 2016-10-27 at ','2016-10-13 18:09:32',8),(424,'neneng add raw materials which is  Onion, Quantity = 1 kG/s, Expiration Date = 2016-11-22 at ','2016-10-13 18:10:49',8),(425,'neneng modify our product name : Beef Pepperoni to  Beef Pepperoni Pizza on ','2016-10-13 18:17:16',8),(426,'neneng modify our product name : Chicken Fajita to  Chicken Fajita Pizza on ','2016-10-13 18:17:38',8),(427,'neneng modify our product name : Buko Pandan w/ fresh Milk to  Buko Pandan Smoothie on ','2016-10-13 18:18:10',8),(428,'neneng trying to log in at ','2016-10-13 18:19:37',8),(429,'neneng deleting product name which is Grapes w/ fresh Milk together with its raw materials on ','2016-10-13 18:20:44',8),(430,'neneng were adding a new product which is Grape Smoothie on ','2016-10-13 18:21:03',8),(431,'neneng deleting product name which is Grapes w/ fresh Milk together with its raw materials on ','2016-10-13 18:21:14',8),(432,'neneng deleting product name which is halo halo together with its raw materials on ','2016-10-13 18:21:53',8),(433,'neneng were add 50 Pitcher of Ice Tea Bottomless on ','2016-10-13 18:23:04',8),(434,'neneng were add 25 Solo of Pesto Pasta on ','2016-10-13 18:23:32',8),(435,'neneng were add 20 piece/s of Chicken Hotshots on ','2016-10-13 18:23:57',8),(436,'neneng deleting product name which is halo halo together with its raw materials on ','2016-10-13 18:24:48',8),(437,'neneng were add 50 Cup of Hot Tea on ','2016-10-13 18:25:25',8),(438,'neneng were add 20 Solo of Beef Spaghetti on ','2016-10-13 18:25:39',8),(439,'neneng were add 10 Solo of Beef Ball Spaghetti on ','2016-10-13 18:25:49',8),(440,'neneng were add 15 piece/s of Chicken Nuggets on ','2016-10-13 18:26:00',8),(441,'neneng were add 10 piece/s of Chicken Quesadillas on ','2016-10-13 18:26:09',8),(442,'neneng were add 10 piece/s of Leche Flan Turon on ','2016-10-13 18:26:29',8),(443,'neneng were logout at ','2016-10-13 22:01:49',8),(444,'mylyn trying to log in at ','2016-10-14 12:45:30',7),(445,'mylyn were logout at ','2016-10-14 13:13:38',7),(446,'neneng trying to log in at ','2016-10-14 13:13:48',8),(447,'neneng were logout at ','2016-10-14 21:27:15',8),(448,'mylyn trying to log in at ','2016-10-28 00:00:01',7),(449,'mylyn were logout at ','2016-10-28 00:01:45',7),(450,'mylyn trying to log in at ','2016-10-27 23:26:47',7),(451,'mylyn were logout at ','2016-10-27 23:26:58',7),(452,'mylyn trying to log in at ','2016-10-27 23:29:50',7),(453,'mylyn were logout at ','2016-10-27 23:30:12',7),(454,'mylyn trying to log in at ','2016-10-27 23:37:17',7),(455,'mylyn were logout at ','2016-10-27 23:44:15',7),(456,'mylyn trying to log in at ','2016-10-28 07:33:16',7),(457,'mylyn were logout at ','2016-10-28 07:33:59',7),(458,'mylyn trying to log in at ','2016-10-28 08:03:47',7),(459,'mylyn were logout at ','2016-10-28 08:04:50',7),(460,'judith trying to log in at ','2016-10-28 08:05:08',3),(461,'mylyn trying to log in at ','2016-10-28 08:22:10',7),(462,'mylyn add raw materials which is  a, Quantity = 4 mG/s, Expiration Date = 2016-10-29 at ','2016-10-28 08:23:05',7),(463,'mylyn deleting raw material which is A on ','2016-10-28 08:24:08',7),(464,'mylyn were logout at ','2016-10-28 08:25:16',7),(465,'mylyn trying to log in at ','2016-10-28 10:04:49',7),(466,'mylyn add raw materials which is  as, Quantity = 4 gram/s, Expiration Date = 2016-11-05 at ','2016-10-28 10:05:39',7),(467,' Admin add new account to Arnold Zurbito. Pilones at ','2016-10-28 10:10:05',7),(468,'mylyn were logout at ','2016-10-28 10:10:39',7),(469,'arnold trying to log in at ','2016-10-28 10:10:48',10),(470,'arnold were logout at ','2016-10-28 10:10:55',10),(471,'mylyn trying to log in at ','2016-10-28 10:11:03',7),(472,'mylyn were logout at ','2016-10-28 10:11:26',7),(473,'mylyn trying to log in at ','2016-10-28 10:11:34',7),(474,'mylyn were logout at ','2016-10-28 10:12:34',7),(475,'zurbito trying to log in at ','2016-10-28 10:12:42',10),(476,'zurbito were logout at ','2016-10-28 10:12:48',10),(477,'mylyn trying to log in at ','2016-10-28 12:37:29',7),(478,'mylyn add raw materials which is  Corn, Quantity = 5 kG/s, Expiration Date = 2017-02-07 at ','2016-10-28 12:40:53',7),(479,'mylyn were add 300 gram/s of Corn on ','2016-10-28 12:45:10',7),(480,'mylyn remove 5 kG/s of Corn on ','2016-10-28 12:45:51',7),(481,'mylyn were logout at ','2016-10-28 13:18:43',7),(482,'mylyn trying to log in at ','2016-10-28 14:36:06',7),(483,'mylyn deleting product name which is Beef Ball Spaghetti on ','2016-10-28 14:39:45',7),(484,'mylyn were logout at ','2016-10-28 14:57:15',7),(485,'mylyn trying to log in at ','2016-11-16 11:28:53',7),(486,'judith trying to log in at ','2016-11-16 15:49:08',3),(487,'judith were logout at ','2016-11-16 15:49:47',3),(488,'mylyn trying to log in at ','2016-11-16 15:49:54',7),(489,'mylyn were logout at ','2016-11-16 15:50:01',7),(490,'mylyn trying to log in at ','2016-11-16 16:03:28',7),(491,'mylyn trying to log in at ','2016-11-16 16:05:23',7),(492,'mylyn trying to log in at ','2016-11-16 16:15:11',7),(493,'mylyn trying to log in at ','2016-11-16 16:42:46',7),(494,'mylyn trying to log in at ','2016-11-16 16:48:47',7),(495,'mylyn were logout at ','2016-11-16 16:52:09',7),(496,'mylyn trying to log in at ','2016-11-16 16:52:16',7),(497,'mylyn were logout at ','2016-11-16 16:52:48',7),(498,'mylyn trying to log in at ','2016-11-16 16:53:13',7),(499,'mylyn trying to log in at ','2016-11-16 17:26:22',7),(500,'mylyn trying to log in at ','2016-11-18 16:20:23',7);
/*!40000 ALTER TABLE `logs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `material_every_product`
--

DROP TABLE IF EXISTS `material_every_product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `material_every_product` (
  `MEP_ID` int(255) NOT NULL AUTO_INCREMENT,
  `Product_ID` int(11) NOT NULL,
  `Minus_Material_Every_Product` decimal(10,1) NOT NULL,
  `Raw_ID` int(11) NOT NULL,
  `Unit_ID` int(255) NOT NULL,
  `Size_ID` int(50) NOT NULL,
  PRIMARY KEY (`MEP_ID`),
  KEY `Product_ID` (`Product_ID`),
  KEY `Raw_ID` (`Raw_ID`),
  KEY `Unit_ID` (`Unit_ID`),
  KEY `Size_ID` (`Size_ID`),
  CONSTRAINT `material_every_product_ibfk_1` FOREIGN KEY (`Product_ID`) REFERENCES `product_table` (`Product_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `material_every_product_ibfk_2` FOREIGN KEY (`Raw_ID`) REFERENCES `raw_material_table` (`Raw_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `material_every_product_ibfk_3` FOREIGN KEY (`Unit_ID`) REFERENCES `unit_table` (`Unit_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `material_every_product_ibfk_4` FOREIGN KEY (`Size_ID`) REFERENCES `product_size` (`Size_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=90 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `material_every_product`
--

LOCK TABLES `material_every_product` WRITE;
/*!40000 ALTER TABLE `material_every_product` DISABLE KEYS */;
INSERT INTO `material_every_product` VALUES (3,1001,34.0,127,2,3),(7,1001,3.0,145,1,4),(32,1071,2.0,145,1,16),(33,1006,3.0,136,7,1),(37,1102,2.0,146,1,3),(48,1001,4.0,150,2,3),(49,1014,30.0,174,2,16),(51,1013,2.0,146,1,16),(52,1013,100.0,176,2,16),(57,1027,5.0,177,4,16),(58,1027,100.0,157,2,16),(59,1109,0.0,196,4,1),(60,1109,25.0,182,2,1),(61,1109,0.0,210,1,1),(62,1109,25.0,230,2,1),(63,1109,6.0,174,1,1),(64,1028,1000.0,157,2,16),(65,1028,15.0,177,4,16),(66,1028,5.0,167,2,16),(67,1077,50.0,183,2,9),(68,1077,30.0,202,4,9),(69,1077,5.0,200,1,9),(70,1077,5.0,233,4,9),(71,1002,100.0,156,2,1),(72,1002,30.0,162,2,1),(73,1002,5.0,142,1,1),(74,1008,50.0,230,2,16),(75,1008,50.0,178,4,16),(76,1008,10.0,186,2,16),(77,1008,20.0,158,4,16),(78,1020,10.0,164,2,1),(79,1020,25.0,230,2,1),(80,1020,10.0,158,4,1),(81,1020,20.0,234,2,1),(82,1035,30.0,163,2,1),(83,1035,30.0,166,4,1),(84,1035,10.0,235,2,1),(85,1035,10.0,142,1,1),(86,1035,10.0,236,1,1),(87,1014,30.0,162,2,16),(88,1014,10.0,175,4,16),(89,1014,15.0,234,2,16);
/*!40000 ALTER TABLE `material_every_product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order_table`
--

DROP TABLE IF EXISTS `order_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `order_table` (
  `Order_ID` int(50) NOT NULL AUTO_INCREMENT,
  `Product_ID` int(50) NOT NULL,
  `Order_Quantity` int(50) NOT NULL,
  `Size_ID` int(50) NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  `Order_Date` datetime NOT NULL,
  PRIMARY KEY (`Order_ID`),
  KEY `Product_ID` (`Product_ID`),
  KEY `Size_ID` (`Size_ID`),
  CONSTRAINT `order_table_ibfk_1` FOREIGN KEY (`Product_ID`) REFERENCES `product_table` (`Product_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `order_table_ibfk_2` FOREIGN KEY (`Size_ID`) REFERENCES `product_size` (`Size_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=195 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_table`
--

LOCK TABLES `order_table` WRITE;
/*!40000 ALTER TABLE `order_table` DISABLE KEYS */;
INSERT INTO `order_table` VALUES (62,1014,1,16,127.00,'2016-09-22 21:32:09'),(63,1006,2,5,340.00,'2016-09-22 21:32:48'),(64,1014,12,16,300.00,'2016-09-22 21:33:51'),(65,1006,1,5,240.00,'2016-09-22 21:33:51'),(66,1090,1,7,145.00,'2016-09-22 21:33:51'),(67,1020,1,3,42.00,'2016-09-22 22:06:57'),(68,1020,1,2,230.00,'2016-09-22 22:06:57'),(69,1020,3,5,99.00,'2016-09-22 22:06:57'),(70,1077,2,9,56.50,'2016-09-24 13:55:06'),(71,1081,1,15,45.00,'2016-09-24 13:57:49'),(72,1081,1,14,39.00,'2016-09-24 13:57:49'),(73,1006,2,5,680.00,'2016-09-27 12:36:08'),(74,1006,2,5,680.00,'2016-09-27 12:38:13'),(75,1006,2,3,758.00,'2016-09-27 12:38:13'),(76,1006,2,3,758.00,'2016-09-28 20:31:57'),(77,1008,3,16,357.00,'2016-09-29 19:59:21'),(78,1062,2,16,178.00,'2016-09-29 19:59:22'),(79,1102,1,2,100.00,'2016-09-29 20:00:37'),(80,1077,2,9,178.00,'2016-09-29 20:00:37'),(81,1013,2,16,118.00,'2016-09-29 20:00:37'),(82,1087,4,11,140.00,'2016-09-30 23:08:10'),(83,1016,10,16,390.00,'2016-09-30 23:08:11'),(84,1030,1,1,99.00,'2016-09-30 23:08:11'),(85,1013,5,16,295.00,'2016-10-01 13:55:01'),(86,1004,1,3,399.67,'2016-10-01 13:55:01'),(87,1061,1,3,399.00,'2016-10-01 13:55:01'),(88,1020,1,3,369.00,'2016-10-01 13:55:02'),(89,1080,1,14,75.00,'2016-10-01 13:55:02'),(90,1079,2,14,150.00,'2016-10-01 13:55:02'),(91,1025,3,16,357.00,'2016-10-01 14:04:34'),(92,1003,3,16,327.00,'2016-10-01 14:04:34'),(93,1026,3,16,387.00,'2016-10-01 21:46:45'),(94,1028,5,16,25.00,'2016-10-01 21:46:45'),(95,1032,2,1,238.00,'2016-10-01 21:46:45'),(96,1031,4,1,596.00,'2016-10-01 21:46:46'),(97,1085,2,10,150.00,'2016-10-01 21:47:29'),(98,1006,2,3,758.00,'2016-10-03 21:38:52'),(99,1035,2,1,198.00,'2016-10-03 21:39:31'),(100,1090,5,7,150.00,'2016-10-03 21:41:07'),(101,1014,2,16,254.00,'2016-10-04 18:44:17'),(102,1027,8,16,1032.00,'2016-10-04 18:44:19'),(103,1080,1,14,75.00,'2016-10-04 18:44:23'),(104,1088,5,11,175.00,'2016-10-04 18:47:11'),(105,1065,4,16,356.00,'2016-10-04 18:47:11'),(106,1062,2,16,178.00,'2016-10-04 18:47:11'),(107,1032,2,1,238.00,'2016-10-04 19:03:09'),(108,1026,2,16,258.00,'2016-10-04 19:03:09'),(109,1003,2,16,218.00,'2016-10-04 19:03:10'),(110,1085,1,10,75.00,'2016-10-04 19:03:10'),(111,1006,1,3,379.00,'2016-10-04 20:14:23'),(112,1081,2,15,80.00,'2016-10-04 20:14:23'),(113,1026,2,16,258.00,'2016-10-04 20:14:23'),(114,1036,2,1,258.00,'2016-10-04 20:14:24'),(115,1035,2,1,198.00,'2016-10-06 15:18:27'),(116,1026,1,16,129.00,'2016-10-06 15:18:27'),(117,1013,2,16,118.00,'2016-10-06 15:18:27'),(118,1001,1,2,219.00,'2016-10-06 15:19:20'),(119,1061,1,3,399.00,'2016-10-06 15:19:57'),(120,1063,3,16,297.00,'2016-10-09 12:32:45'),(121,1071,2,16,198.00,'2016-10-09 12:32:45'),(122,1070,1,16,89.00,'2016-10-09 12:32:46'),(123,1070,1,16,89.00,'2016-10-09 12:32:46'),(125,1002,2,1,318.00,'2016-10-09 13:32:03'),(126,1036,1,1,129.00,'2016-10-09 13:32:03'),(127,1031,1,1,149.00,'2016-10-09 13:32:03'),(128,1076,2,9,138.00,'2016-10-09 13:32:03'),(129,1081,1,15,40.00,'2016-10-09 13:32:03'),(130,1080,1,15,40.00,'2016-10-09 13:32:04'),(131,1013,2,16,118.00,'2016-10-09 14:26:50'),(132,1008,2,16,238.00,'2016-10-09 14:55:17'),(133,1027,4,16,516.00,'2016-10-09 15:05:30'),(134,1002,2,1,318.00,'2016-10-09 16:19:01'),(135,1024,1,16,109.00,'2016-10-09 17:19:47'),(136,1009,2,16,158.00,'2016-10-09 17:19:47'),(137,1084,2,9,36.00,'2016-10-09 17:19:48'),(138,1019,2,16,258.00,'2016-10-09 17:21:40'),(139,1031,1,1,149.00,'2016-10-09 17:21:41'),(140,1075,2,9,118.00,'2016-10-09 17:21:41'),(142,1026,1,16,129.00,'2016-10-09 18:27:01'),(143,1024,1,16,109.00,'2016-10-09 18:27:01'),(144,1002,3,1,447.00,'2016-10-12 13:22:03'),(146,1084,5,9,90.00,'2016-10-12 13:22:03'),(147,1013,1,16,59.00,'2016-10-12 15:49:35'),(148,1008,2,16,238.00,'2016-10-12 15:49:35'),(149,1009,1,16,79.00,'2016-10-12 15:49:36'),(150,1084,3,9,54.00,'2016-10-12 15:49:36'),(151,1065,2,16,178.00,'2016-10-12 20:11:50'),(152,1066,2,16,218.00,'2016-10-12 20:11:50'),(153,1100,2,1,110.00,'2016-10-12 20:11:50'),(154,1102,2,1,300.00,'2016-10-12 20:11:51'),(155,1061,2,3,798.00,'2016-10-12 20:45:51'),(156,1031,1,1,149.00,'2016-10-12 21:45:52'),(157,1001,2,3,758.00,'2016-10-12 21:45:52'),(158,1028,2,16,500.00,'2016-10-12 21:45:52'),(159,1003,2,16,218.00,'2016-10-13 12:46:51'),(160,1111,2,16,30.00,'2016-10-13 12:56:39'),(161,1032,1,1,119.00,'2016-10-13 12:56:40'),(162,1112,1,1,149.00,'2016-10-13 12:56:40'),(163,1087,1,11,35.00,'2016-10-13 12:56:40'),(164,1003,1,16,109.00,'2016-10-13 13:04:01'),(165,1002,1,1,149.00,'2016-10-13 13:04:01'),(166,1088,1,11,35.00,'2016-10-13 13:04:01'),(167,1113,1,16,150.00,'2016-10-13 13:18:20'),(168,1081,1,15,40.00,'2016-10-13 13:18:21'),(169,1062,2,16,178.00,'2016-10-13 13:18:50'),(170,1070,3,16,267.00,'2016-10-13 18:27:33'),(172,1066,3,16,327.00,'2016-10-13 18:27:33'),(173,1102,2,1,300.00,'2016-10-13 20:56:57'),(174,1028,1,16,250.00,'2016-10-13 20:56:57'),(176,1024,1,16,109.00,'2016-10-14 13:42:05'),(177,1004,2,3,799.34,'2016-10-14 15:07:21'),(178,1061,2,4,298.00,'2016-10-14 15:07:21'),(179,1088,3,11,105.00,'2016-10-14 16:29:43'),(180,1016,2,16,78.00,'2016-10-14 16:29:43'),(181,1113,3,16,450.00,'2016-10-14 16:29:43'),(182,1028,2,16,500.00,'2016-10-14 17:02:45'),(183,1002,2,1,298.00,'2016-10-14 17:02:46'),(184,1031,3,1,447.00,'2016-10-14 17:02:46'),(186,1024,1,16,109.00,'2016-10-14 20:30:04'),(187,1026,1,16,129.00,'2016-10-14 20:30:04'),(188,1081,2,15,80.00,'2016-10-14 20:30:05'),(189,1006,3,3,1137.00,'2016-10-28 14:49:59'),(190,1102,6,1,900.00,'2016-10-28 14:52:00'),(191,1006,3,3,1137.00,'2016-11-16 12:45:25'),(192,1006,3,3,447.00,'2016-11-16 14:00:16'),(193,1035,21,1,2079.00,'2016-11-18 16:25:48'),(194,1071,6,16,594.00,'2016-11-18 16:25:48');
/*!40000 ALTER TABLE `order_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product_quantity`
--

DROP TABLE IF EXISTS `product_quantity`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `product_quantity` (
  `Quantity_ID` int(100) NOT NULL AUTO_INCREMENT,
  `Quantity` int(100) NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  `Product_ID` int(100) NOT NULL,
  `Size_ID` int(100) NOT NULL,
  PRIMARY KEY (`Quantity_ID`),
  KEY `Product_ID` (`Product_ID`),
  KEY `Size_ID` (`Size_ID`),
  CONSTRAINT `product_quantity_ibfk_1` FOREIGN KEY (`Product_ID`) REFERENCES `product_table` (`Product_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `product_quantity_ibfk_2` FOREIGN KEY (`Size_ID`) REFERENCES `product_size` (`Size_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=229 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product_quantity`
--

LOCK TABLES `product_quantity` WRITE;
/*!40000 ALTER TABLE `product_quantity` DISABLE KEYS */;
INSERT INTO `product_quantity` VALUES (34,18,109.00,1003,16),(43,5,239.00,1004,2),(45,2,399.67,1004,3),(46,2,429.00,1004,5),(92,13,119.00,1008,16),(93,27,79.00,1009,16),(94,28,39.00,1016,16),(95,18,59.00,1013,16),(98,5,129.00,1018,16),(99,8,129.00,1019,16),(103,19,109.00,1024,16),(104,16,119.00,1025,16),(108,5,299.00,1029,1),(111,5,99.00,1030,1),(128,5,139.00,1034,1),(129,0,99.00,1035,1),(130,4,129.00,1036,1),(133,4,369.00,1020,3),(134,4,209.00,1020,2),(135,4,379.00,1020,5),(136,9,219.00,1001,2),(137,4,379.00,1001,3),(138,7,389.00,1001,5),(139,42,99.00,1071,16),(147,2,89.00,1077,9),(154,21,35.00,1088,11),(155,23,40.00,1081,15),(157,24,89.00,1062,16),(158,7,99.00,1063,16),(159,6,169.00,1064,16),(160,52,35.00,1087,11),(161,3,18.00,1084,9),(162,1,75.00,1085,10),(163,5,49.00,1068,16),(164,45,89.00,1070,16),(165,30,59.00,1069,16),(166,3,69.00,1076,9),(167,15,30.00,1089,6),(168,5,89.00,1072,16),(169,6,59.00,1075,9),(170,5,99.00,1061,1),(171,1,149.00,1061,4),(172,2,429.00,1061,5),(174,5,239.00,1061,2),(175,2,89.00,1065,16),(176,5,109.00,1066,16),(177,10,109.00,1067,16),(178,19,40.00,1080,15),(179,3,75.00,1080,14),(181,3,75.00,1079,14),(182,20,40.00,1079,15),(183,4,20.00,1079,13),(189,8,300.00,1097,2),(190,3,50.00,1001,1),(191,2,40.00,1098,14),(192,4,30.00,1098,13),(195,2,345.00,1100,2),(196,1,55.00,1100,1),(201,4,340.00,1006,5),(202,20,40.00,1104,15),(203,3,75.00,1105,16),(204,10,75.00,1081,14),(207,5,175.00,1109,1),(210,10,110.00,1106,1),(211,14,149.00,1002,1),(212,10,99.00,1014,16),(213,9,129.00,1026,16),(214,20,15.00,1090,12),(215,10,150.00,1027,16),(217,18,15.00,1111,16),(218,19,119.00,1032,1),(219,148,149.00,1112,1),(220,21,150.00,1113,16),(221,50,75.00,1086,10),(222,22,149.00,1031,1),(223,10,89.00,1108,16),(224,0,230.00,1102,2),(225,0,180.00,1102,3),(226,4,180.00,1028,16),(227,0,45.00,1114,9),(228,0,149.00,1006,3);
/*!40000 ALTER TABLE `product_quantity` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product_size`
--

DROP TABLE IF EXISTS `product_size`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `product_size` (
  `Size_ID` int(100) NOT NULL AUTO_INCREMENT,
  `Size_Name` varchar(50) NOT NULL,
  PRIMARY KEY (`Size_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product_size`
--

LOCK TABLES `product_size` WRITE;
/*!40000 ALTER TABLE `product_size` DISABLE KEYS */;
INSERT INTO `product_size` VALUES (1,'Solo'),(2,'Regular'),(3,'Family'),(4,'Superthin'),(5,'Chicago Deep Dish'),(6,'Small'),(7,'Medium'),(8,'Large'),(9,'Glass'),(10,'Pitcher'),(11,'Cup'),(12,'8 oz.'),(13,'12 oz.'),(14,'1.5 Liters'),(15,'Can'),(16,'None'),(17,'Platter');
/*!40000 ALTER TABLE `product_size` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product_table`
--

DROP TABLE IF EXISTS `product_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `product_table` (
  `Product_ID` int(40) NOT NULL AUTO_INCREMENT,
  `Product_Name` varchar(400) NOT NULL,
  `Cat_ID` int(50) NOT NULL,
  PRIMARY KEY (`Product_ID`),
  KEY `Product_ID` (`Product_ID`),
  KEY `Cat_ID` (`Cat_ID`),
  CONSTRAINT `product_table_ibfk_1` FOREIGN KEY (`Cat_ID`) REFERENCES `category` (`Cat_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1115 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product_table`
--

LOCK TABLES `product_table` WRITE;
/*!40000 ALTER TABLE `product_table` DISABLE KEYS */;
INSERT INTO `product_table` VALUES (1001,'Hawaiian',7),(1002,'Chicken Alfredo',6),(1003,'Chicken Quesadillas',3),(1004,'Mexican',7),(1006,'Beef Pepperoni Pizza',7),(1008,'Chicken Burger',1),(1009,'Chilidog',1),(1013,'French Fries',2),(1014,'Beef Shawarma',2),(1016,'Garlic Bread',2),(1018,'Soft Taco',3),(1019,'Nachos',3),(1020,'Chicken Fajita Pizza',7),(1024,'Chicken Hotshots',5),(1025,'Chicken Nuggets',5),(1026,'Chicken Tenders',5),(1027,'Buffalo Wings (2pcs)',5),(1028,'Buffalo Wings (4pcs)',5),(1029,'Kung Pao Pasta',6),(1030,'Tinapa Pasta',6),(1031,'Pesto Pasta',6),(1032,'Pasta Albayana',6),(1034,'Spicy Tuna Pasta',6),(1035,'Beef Spaghetti',6),(1036,'Lasagna',6),(1061,'Philly Steak',7),(1062,'Combo 1',8),(1063,'Combo 2',8),(1064,'Combo 3',8),(1065,'R1',9),(1066,'R2',9),(1067,'R3',9),(1068,'Leche flan',10),(1069,'Leche Flan with Pilinuts',10),(1070,'Leche Flan Turon with Ice Cream',10),(1071,'Blueberry Cheese Cake',10),(1072,'Oreo Cheese Cake',10),(1075,'Papaya w/ fresh Milk',11),(1076,'Mango w/ fresh milk',11),(1077,'Buko Pandan Smoothie',11),(1079,'Sprite',12),(1080,'Royal',12),(1081,'Coke',12),(1084,'Ice Tea Glass',12),(1085,'Ice Tea Pitcher',12),(1086,'Ice Tea Bottomless',12),(1087,'Hot Tea',12),(1088,'Coffee',12),(1089,'Minute Maid',12),(1090,'Bottled Water',12),(1097,'Chicken Salpicao',4),(1098,'Pepsi',12),(1100,'Shrimp Tempura',4),(1102,'Beef Salpicao',4),(1104,'Pineapple(Juice)',12),(1105,'halo halo',10),(1106,'Spicy Tuna Roll',6),(1108,'Leche Flan Turon',10),(1109,'biryani',4),(1111,'Samosa Veg',2),(1112,'Chicken Fajita Meal',4),(1113,'Choco Brownies',10),(1114,'Grape Smoothie',11);
/*!40000 ALTER TABLE `product_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `raw_expiration_date`
--

DROP TABLE IF EXISTS `raw_expiration_date`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `raw_expiration_date` (
  `Exp_Date_ID` int(50) NOT NULL AUTO_INCREMENT,
  `Raw_Quantity` decimal(10,3) NOT NULL,
  `Unit_ID` int(2) NOT NULL,
  `Raw_Expiration_Date` date NOT NULL,
  `Raw_ID` int(100) NOT NULL,
  PRIMARY KEY (`Exp_Date_ID`),
  KEY `Unit_ID` (`Unit_ID`),
  KEY `Raw_ID` (`Raw_ID`),
  CONSTRAINT `raw_expiration_date_ibfk_1` FOREIGN KEY (`Unit_ID`) REFERENCES `unit_table` (`Unit_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `raw_expiration_date_ibfk_2` FOREIGN KEY (`Raw_ID`) REFERENCES `raw_material_table` (`Raw_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=250 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `raw_expiration_date`
--

LOCK TABLES `raw_expiration_date` WRITE;
/*!40000 ALTER TABLE `raw_expiration_date` DISABLE KEYS */;
INSERT INTO `raw_expiration_date` VALUES (72,3.896,3,'2016-06-15',127),(76,400.000,4,'2016-12-17',129),(77,6.000,5,'2016-09-27',129),(82,2.000,5,'2016-11-17',130),(83,4.000,6,'2017-01-20',130),(122,2.000,7,'2016-08-11',136),(126,1.000,3,'2016-09-01',142),(130,1.000,3,'2016-12-15',146),(131,2.000,3,'2016-12-28',146),(136,4.300,2,'2016-09-08',149),(137,0.500,3,'2016-09-15',149),(139,1.005,3,'2016-09-30',150),(140,1.003,2,'2016-09-14',149),(145,600.000,2,'2016-09-18',123),(149,456.000,2,'2016-09-18',149),(150,0.123,3,'2016-09-29',149),(151,0.345,2,'2016-09-26',149),(152,1.000,5,'2017-04-28',128),(153,2.000,6,'2017-04-15',128),(155,0.004,2,'2017-01-18',123),(156,0.002,2,'2017-01-25',123),(159,0.035,3,'2016-12-13',152),(163,1.000,3,'2016-12-11',156),(164,1.000,3,'2016-10-03',157),(165,0.700,5,'2017-01-05',158),(166,4.000,3,'2017-01-03',159),(167,1.000,3,'2016-10-04',160),(168,4.000,3,'2016-12-21',161),(169,4.000,3,'2016-10-05',162),(170,0.500,3,'2017-06-13',163),(171,1.000,3,'2016-10-05',164),(172,5.000,3,'2016-10-05',165),(173,0.500,5,'2016-12-14',166),(174,0.200,3,'2016-12-12',167),(175,0.200,3,'2017-05-03',168),(176,0.100,5,'2016-10-03',169),(178,1.000,8,'2017-02-15',171),(180,0.500,3,'2017-03-14',173),(181,1.000,3,'2016-10-11',174),(182,0.500,5,'2016-10-15',175),(183,2.000,3,'2016-12-14',176),(184,1.000,5,'2016-10-22',177),(185,1.000,5,'2016-10-22',178),(186,1.000,5,'2016-10-22',179),(187,52.840,6,'2016-12-28',180),(188,3.000,3,'2016-12-15',181),(189,5.000,3,'2016-12-31',182),(190,1.000,3,'2016-10-14',183),(191,0.500,3,'2016-12-15',184),(193,10.000,3,'2017-01-10',182),(194,1.000,3,'2016-10-14',186),(195,1.000,3,'2016-10-14',187),(196,0.500,5,'2016-10-21',188),(197,0.250,3,'2016-10-14',189),(198,1.000,3,'2017-01-12',190),(199,0.500,5,'2017-03-29',191),(200,0.200,5,'2017-02-14',192),(201,0.200,3,'2017-02-23',193),(202,0.450,3,'2017-03-31',194),(203,0.405,3,'2017-02-06',195),(204,0.500,5,'2017-02-22',196),(205,0.180,3,'2016-12-21',197),(206,1.000,3,'2017-03-17',198),(207,1.000,3,'2017-04-14',199),(208,2.000,3,'2017-04-12',200),(209,1.000,3,'2017-04-27',201),(210,0.200,3,'2017-09-21',173),(211,3.000,5,'2017-01-25',202),(212,0.350,3,'2017-01-10',203),(213,0.250,3,'2017-06-22',204),(214,0.450,3,'2017-09-14',205),(215,0.450,3,'2017-09-19',206),(216,0.010,3,'2017-09-14',207),(217,0.010,3,'2017-09-27',208),(218,0.470,3,'2017-07-11',209),(219,0.500,3,'2017-09-14',210),(220,0.500,5,'2016-10-14',211),(221,0.200,5,'2017-01-18',212),(222,0.200,5,'2017-01-19',213),(223,1.000,3,'2017-06-30',214),(224,0.500,3,'2016-10-21',215),(225,0.500,3,'2017-06-14',216),(226,1.000,3,'2017-06-16',217),(227,1.000,3,'2016-10-21',218),(228,1.000,3,'2016-10-26',219),(229,1.000,3,'2016-10-20',220),(230,1.000,3,'2016-10-20',221),(231,0.200,3,'2016-10-19',222),(232,0.500,3,'2016-10-20',223),(233,0.300,3,'2016-10-21',224),(234,0.500,3,'2016-10-23',225),(235,1.000,3,'2016-10-28',226),(236,1.000,3,'2017-01-19',227),(237,1.000,3,'2017-01-18',228),(238,1.000,3,'2016-11-25',229),(239,1.000,3,'2016-10-24',230),(240,0.500,3,'2016-10-19',231),(241,0.500,3,'2016-10-28',232),(242,0.500,5,'2016-11-10',233),(243,0.500,3,'2016-10-28',234),(244,0.500,3,'2016-10-27',235),(245,1.000,3,'2016-11-22',236),(249,0.300,3,'2016-12-16',239);
/*!40000 ALTER TABLE `raw_expiration_date` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `raw_material_table`
--

DROP TABLE IF EXISTS `raw_material_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `raw_material_table` (
  `Raw_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Raw_Name` varchar(500) NOT NULL,
  PRIMARY KEY (`Raw_ID`),
  UNIQUE KEY `Raw_ID` (`Raw_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=240 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `raw_material_table`
--

LOCK TABLES `raw_material_table` WRITE;
/*!40000 ALTER TABLE `raw_material_table` DISABLE KEYS */;
INSERT INTO `raw_material_table` VALUES (123,'Bacon'),(126,'Pizza Sauce'),(127,'Pineapple'),(128,'Cooking Oil'),(129,'Soy Sauce'),(130,'Ketchup'),(136,'Egg Yolk'),(140,'Sugar'),(142,'Garlic'),(145,'Pilinuts'),(146,'Salt'),(149,'Chili'),(150,'mushroom'),(152,'cumin'),(154,'alfredo sauce'),(155,'red sauce sweet style'),(156,'Pasta'),(157,'Chicken Wings'),(158,'oil'),(159,'Flour'),(160,'Shrimp'),(161,'mozzarella cheese'),(162,'grounf beef'),(163,'ground pepper'),(164,'bell pepper'),(165,'beef'),(166,'Sweet Style sauce'),(167,'butter'),(168,'Parmesan Cheese'),(169,'Parsley'),(170,'White Onion'),(171,'Knorr Chicken Cubes'),(172,'All Purpose Cream'),(173,'Italian Seasoning'),(174,'cucumber'),(175,'Shawarma Sauce'),(176,'fries'),(177,'Buffalo Sauce'),(178,'Honey Mustard Sauce'),(179,'Chilidog Sauce'),(180,'Mayonnaise'),(181,'Pepperoni'),(182,'Rice'),(183,'Buko'),(184,'Pandan Jelly'),(185,'tomatoe'),(186,'Lettuce'),(187,'Cabbage'),(188,'Ranch Sauce'),(189,'coriander'),(190,'Bread Crumbs'),(191,'Vinegar'),(192,'Woecestire Sauce'),(193,'Corn Starch'),(194,'Cayenne Pepper'),(195,'Oyster Sauce'),(196,'Kikkoman Soy Sauce'),(197,'Nachos Chips'),(198,'Three Cheese Sauce'),(199,'Eden Cheese'),(200,'APC'),(201,'Kung Pao Sauce'),(202,'Fresh Milk'),(203,'Bombay Biryani'),(204,'Korma Powder'),(205,'Taco Seasoning'),(206,'Black Pepper Ground'),(207,'Oregano Powder'),(208,'Cumin Seed'),(209,'Spanish Paprika Powder'),(210,'Garlic Powder'),(211,'Garlic Oil'),(212,'Enchilada'),(213,'Orange Chicken Sauce'),(214,'Japanese Rice'),(215,'Tuna Bicol Express'),(216,'Tempura Butter'),(217,'Cream Cheese'),(218,'Potatoes'),(219,'Carrot'),(220,'Local tomatoe'),(221,'Baguio Tomatoe'),(222,'Onion Leaves'),(223,'Sili Haba'),(224,'Ginger'),(225,'Orange'),(226,'Mango'),(227,'Grape'),(228,'Papaya'),(229,'Calamansi'),(230,'Chicken fillet'),(231,'Tinapa'),(232,'Balaw'),(233,'Sugar Syrup'),(234,'Tortilla'),(235,'Baguette'),(236,'Onion'),(238,'as'),(239,'Corn');
/*!40000 ALTER TABLE `raw_material_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unit_table`
--

DROP TABLE IF EXISTS `unit_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `unit_table` (
  `Unit_ID` int(255) NOT NULL AUTO_INCREMENT,
  `Unit_Name` varchar(50) NOT NULL,
  PRIMARY KEY (`Unit_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unit_table`
--

LOCK TABLES `unit_table` WRITE;
/*!40000 ALTER TABLE `unit_table` DISABLE KEYS */;
INSERT INTO `unit_table` VALUES (1,'mG/s'),(2,'gram/s'),(3,'kG/s'),(4,'mL/s'),(5,'liter/s'),(6,'gallon/s'),(7,'piece/s'),(8,'dozen/s');
/*!40000 ALTER TABLE `unit_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_account`
--

DROP TABLE IF EXISTS `user_account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user_account` (
  `User_ID` int(50) NOT NULL AUTO_INCREMENT,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Account_Type` varchar(50) NOT NULL,
  `User_Company_ID` int(55) NOT NULL,
  PRIMARY KEY (`User_ID`),
  KEY `User_Company_ID` (`User_Company_ID`),
  CONSTRAINT `user_account_ibfk_1` FOREIGN KEY (`User_Company_ID`) REFERENCES `user_table` (`User_Company_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_account`
--

LOCK TABLES `user_account` WRITE;
/*!40000 ALTER TABLE `user_account` DISABLE KEYS */;
INSERT INTO `user_account` VALUES (3,'fcd1eee40b824e08506b5ff82781f775154ad51d','031b195d385618ab465ec462f45b8975122498cf','CREW',3),(7,'299a1e8de4c08ca03c14b98d3acd160d13d31978','299a1e8de4c08ca03c14b98d3acd160d13d31978','ADMIN',7),(8,'b9e3fc6453452f53ab9927334ba3f7eebeed50eb','b9e3fc6453452f53ab9927334ba3f7eebeed50eb','CREW',8),(9,'fc7bee7fa9669b6715a10766f94067445c456808','fc7bee7fa9669b6715a10766f94067445c456808','CREW',9),(10,'9fd6cc7c6bb017e9cd99c5cdcd3189d58437eef5','6f9019a59c51da7447ae804dd2cbe5203f6f90ac','CREW',10);
/*!40000 ALTER TABLE `user_account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_table`
--

DROP TABLE IF EXISTS `user_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user_table` (
  `User_Company_ID` int(50) NOT NULL AUTO_INCREMENT,
  `Firstname` varchar(255) NOT NULL,
  `Middlename` varchar(255) NOT NULL,
  `Lastname` varchar(20) NOT NULL,
  `Contact_Num` varchar(200) NOT NULL,
  PRIMARY KEY (`User_Company_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_table`
--

LOCK TABLES `user_table` WRITE;
/*!40000 ALTER TABLE `user_table` DISABLE KEYS */;
INSERT INTO `user_table` VALUES (3,'Judith','Completo','Nacor','09358787822'),(7,'Mylyn','Diaz','Almazan','09091234567'),(8,'Jenylyn','Camposano','Dollente','09095634590'),(9,'Arwyn','Sarte','Maquinana','09079597765'),(10,'Arnold','Pilones','Zurbito','9234589201');
/*!40000 ALTER TABLE `user_table` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-11-18 16:29:55
