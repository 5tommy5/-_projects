-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jun 01, 2020 at 12:11 PM
-- Server version: 5.7.24
-- PHP Version: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `terapevt`
--

-- --------------------------------------------------------

--
-- Table structure for table `doctors`
--

CREATE TABLE `doctors` (
  `ID_doctor` int(4) UNSIGNED NOT NULL,
  `name` varchar(25) NOT NULL,
  `surname` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `doctors`
--

INSERT INTO `doctors` (`ID_doctor`, `name`, `surname`) VALUES
(1, 'Антон', 'Хорошок'),
(2, 'Виталий', 'Герченко');

-- --------------------------------------------------------

--
-- Table structure for table `pacient`
--

CREATE TABLE `pacient` (
  `ID` int(4) UNSIGNED NOT NULL,
  `name` varchar(25) NOT NULL,
  `surname` varchar(25) NOT NULL,
  `phone` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `pacient`
--

INSERT INTO `pacient` (`ID`, `name`, `surname`, `phone`) VALUES
(1, 'Димасик', 'Грига', '0637035715'),
(2, 'Беззубый', 'Данил', '0662107303'),
(3, 'Светлана', 'Мазайка', '083712387'),
(4, 'Дима', 'Билан', '0995107303'),
(5, 'Вашких', 'Архамат', '0995103403'),
(6, 'Бродвей', 'Диктор', '0995110304'),
(7, 'Алина', 'Гармония', '077111111'),
(8, 'Антон', 'Бризимориус', '0557039988');

-- --------------------------------------------------------

--
-- Table structure for table `priyom`
--

CREATE TABLE `priyom` (
  `ID_priyom` int(4) UNSIGNED NOT NULL,
  `phone` varchar(10) NOT NULL,
  `doctor_surname` varchar(25) NOT NULL,
  `date` date NOT NULL,
  `comment` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `priyom`
--

INSERT INTO `priyom` (`ID_priyom`, `phone`, `doctor_surname`, `date`, `comment`) VALUES
(1, '0995103403', 'Хорошок', '2020-06-02', 'Тут коммент'),
(2, '0637035715', 'Хорошок', '2020-06-25', 'Работает?'),
(3, '0662107303', 'Герченко', '2020-05-30', 'Ну што!'),
(4, '083712387', 'Герченко', '2020-06-18', 'Болит стопа'),
(5, '0995103403', 'Хорошок', '2020-05-31', ''),
(6, '0995103403', 'Хорошок', '2020-05-31', ''),
(7, '0995103403', 'Хорошок', '2020-05-31', ''),
(8, '0995103403', 'Хорошок', '2020-05-31', ''),
(9, '0995103403', 'Хорошок', '2020-05-31', ''),
(10, '0995110304', 'Хорошок', '2020-06-04', 'оно работает круто'),
(11, '0995110304', 'Хорошок', '2020-06-04', ''),
(12, '0995110304', 'Хорошок', '2020-06-04', ''),
(13, '0995110304', 'Хорошок', '2020-06-04', ''),
(14, '0995110304', 'Хорошок', '2020-06-04', ''),
(15, '0995110304', 'Хорошок', '2020-06-02', 'впапаана'),
(16, '0995107303', 'Хорошок', '2020-06-02', '23234'),
(17, '077111111', 'Герченко', '2020-06-18', 'Гармонирую'),
(18, '0557039988', 'Герченко', '2020-06-18', 'ТРАРАРАТАРТАР'),
(19, '0557039988', 'Герченко', '2020-06-18', ''),
(20, '0557039988', 'Герченко', '2020-06-18', ''),
(21, '0557039988', 'Хорошок', '2020-06-18', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `doctors`
--
ALTER TABLE `doctors`
  ADD PRIMARY KEY (`ID_doctor`),
  ADD UNIQUE KEY `surname` (`surname`);

--
-- Indexes for table `pacient`
--
ALTER TABLE `pacient`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `phone` (`phone`);

--
-- Indexes for table `priyom`
--
ALTER TABLE `priyom`
  ADD PRIMARY KEY (`ID_priyom`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `doctors`
--
ALTER TABLE `doctors`
  MODIFY `ID_doctor` int(4) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `pacient`
--
ALTER TABLE `pacient`
  MODIFY `ID` int(4) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `priyom`
--
ALTER TABLE `priyom`
  MODIFY `ID_priyom` int(4) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
