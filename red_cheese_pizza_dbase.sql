-- MySqlBackup.NET 2.0.9.2
-- Dump Time: 2015-12-17 20:02:50
-- --------------------------------------
-- Server version 5.5.24-log MySQL Community Server (GPL)


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES latin1 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of employee
-- 

DROP TABLE IF EXISTS `employee`;
CREATE TABLE IF NOT EXISTS `employee` (
  `Emp_ID` int(50) NOT NULL AUTO_INCREMENT,
  `Emp_Fname` varchar(70) NOT NULL,
  `Emp_Lname` varchar(70) NOT NULL,
  `Emp_Mname` varchar(70) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  PRIMARY KEY (`Emp_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=1014 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table employee
-- 

/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee`(`Emp_ID`,`Emp_Fname`,`Emp_Lname`,`Emp_Mname`,`Username`,`Password`) VALUES
(1001,'Jessa ','Alcantara','G.','admin','administrator'),
(1006,'Diane','G.','Llamoso','maganda','akodaw'),
(1007,'Elzan','C.','Arimbay','elzan','olaf'),
(1008,'$fname','$lname','$mname','$username','$password'),
(1009,'$fname','$lname','$mname','$username','$password'),
(1010,'$fname','$lname','$mname','$username','$password'),
(1011,'$fname','$mname','$lname','$username','$pad'),
(1012,'$fname','$mname','$lname','$username','$pad'),
(1013,'$fname','$mname','$lname','$username','$pad');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;

-- 
-- Definition of user_account
-- 

DROP TABLE IF EXISTS `user_account`;
CREATE TABLE IF NOT EXISTS `user_account` (
  `Emp_ID` int(50) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `User_ID` int(50) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`User_ID`),
  KEY `Emp_ID` (`Emp_ID`),
  CONSTRAINT `user_account_ibfk_1` FOREIGN KEY (`Emp_ID`) REFERENCES `employee` (`Emp_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table user_account
-- 

/*!40000 ALTER TABLE `user_account` DISABLE KEYS */;
INSERT INTO `user_account`(`Emp_ID`,`Username`,`Password`,`User_ID`) VALUES
(1012,'rex','king',1),
(1013,'rex','king',2);
/*!40000 ALTER TABLE `user_account` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2015-12-17 20:02:50
-- Total time: 0:0:0:0:184 (d:h:m:s:ms)
