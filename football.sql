-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jun 03, 2020 at 02:05 AM
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
-- Database: `football`
--

-- --------------------------------------------------------

--
-- Table structure for table `club`
--

CREATE TABLE `club` (
  `ID` int(4) UNSIGNED NOT NULL,
  `name` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `club`
--

INSERT INTO `club` (`ID`, `name`) VALUES
(2, 'Барселона'),
(1, 'Манчестер Сити');

-- --------------------------------------------------------

--
-- Table structure for table `footballer`
--

CREATE TABLE `footballer` (
  `ID` int(4) UNSIGNED NOT NULL,
  `name` varchar(25) NOT NULL,
  `surname` varchar(25) NOT NULL,
  `height` int(3) UNSIGNED NOT NULL,
  `weight` int(3) UNSIGNED NOT NULL,
  `position` varchar(5) NOT NULL,
  `nation` varchar(25) NOT NULL,
  `club` varchar(25) NOT NULL,
  `years` int(2) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `footballer`
--

INSERT INTO `footballer` (`ID`, `name`, `surname`, `height`, `weight`, `position`, `nation`, `club`, `years`) VALUES
(1, 'Пепе', 'Гвардиолла', 180, 74, 'ЦФ', 'Бразилия', 'Манчестер Сити', 21),
(2, 'Лионелль', 'Месси', 170, 68, 'ЦП', 'Аргентина', 'Манчестер Сити', 27),
(3, 'Захар', 'Гура', 180, 75, 'ЛЗ', 'Украинец', 'Барселона', 19);

-- --------------------------------------------------------

--
-- Table structure for table `otpr`
--

CREATE TABLE `otpr` (
  `ID` int(4) NOT NULL,
  `name` varchar(25) NOT NULL,
  `surname` varchar(25) NOT NULL,
  `height` int(3) NOT NULL,
  `weight` int(3) NOT NULL,
  `position` varchar(5) NOT NULL,
  `nation` varchar(25) NOT NULL,
  `club` varchar(25) NOT NULL,
  `years` int(2) NOT NULL,
  `club_to` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `club`
--
ALTER TABLE `club`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `name` (`name`);

--
-- Indexes for table `footballer`
--
ALTER TABLE `footballer`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `surname` (`surname`);

--
-- Indexes for table `otpr`
--
ALTER TABLE `otpr`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `club`
--
ALTER TABLE `club`
  MODIFY `ID` int(4) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `footballer`
--
ALTER TABLE `footballer`
  MODIFY `ID` int(4) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `otpr`
--
ALTER TABLE `otpr`
  MODIFY `ID` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
