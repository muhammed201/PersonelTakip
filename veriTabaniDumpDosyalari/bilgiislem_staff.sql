-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: localhost    Database: bilgiislem
-- ------------------------------------------------------
-- Server version	8.0.29

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
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `staff` (
  `idstaff` int NOT NULL AUTO_INCREMENT,
  `registration` varchar(10) NOT NULL,
  `stafName` varchar(45) DEFAULT NULL,
  `stafSurname` varchar(45) DEFAULT NULL,
  `duty` int DEFAULT NULL,
  `department` int DEFAULT NULL,
  `mobilephone` varchar(12) DEFAULT NULL,
  `internalphone` varchar(10) DEFAULT NULL,
  `reg` varchar(10) DEFAULT NULL,
  `regdate` datetime DEFAULT NULL,
  `stafflog` mediumtext,
  PRIMARY KEY (`idstaff`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (17,'ab126348','Muhammed','Zengin',0,1,'533 510 4921','4444','uuu','2022-09-14 01:35:57','uuu tarihinde kayıt edildi'),(22,'ab145854','Erkan','Coşu',0,1,'533 510 4921','4444','uuu','2022-09-17 01:38:16','uuu tarihinde kayıt edildi'),(23,'ab180883','Serhat','Keleş',0,1,'564 545 6465','5646','uuu','2022-09-17 01:38:34','uuu tarihinde kayıt edildi'),(24,'ab114525','Yasin','Geren',0,1,'564 546 5456','5665','uuu','2022-09-17 01:38:56','uuu tarihinde kayıt edildi'),(30,'ab126346','Deneme','deneme',5,5,'533 512 5485','5555','uuu','2022-09-19 22:44:02','2022-09-19-22:44:02 tarihinde kayıt edildi');
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-09-20  1:32:57
