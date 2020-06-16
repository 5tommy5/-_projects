-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jun 01, 2020 at 12:59 PM
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
-- Database: `auto`
--

-- --------------------------------------------------------

--
-- Table structure for table `auto`
--

CREATE TABLE `auto` (
  `ID` int(4) UNSIGNED NOT NULL,
  `marka` varchar(25) NOT NULL,
  `model` varchar(25) NOT NULL,
  `year` int(4) UNSIGNED NOT NULL,
  `is_sealed` tinyint(1) NOT NULL DEFAULT '0',
  `price` int(7) UNSIGNED NOT NULL,
  `vlad_name` varchar(25) DEFAULT NULL,
  `vlad_surname` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `auto`
--

INSERT INTO `auto` (`ID`, `marka`, `model`, `year`, `is_sealed`, `price`, `vlad_name`, `vlad_surname`) VALUES
(1, 'Opel', 'cf32', 2005, 1, 3400, 'Влад', 'Заславский'),
(2, 'BMW', 'x5', 2010, 1, 12000, 'Yetti', 'Gorila'),
(3, 'BMW', 'x5', 2011, 1, 11000, 'DZHIGUR', 'DA'),
(4, 'BMW', 'x6', 2012, 1, 21000, 'RET', 'DIDER'),
(5, 'Mersedec', 'chica', 2015, 1, 9800, 'Григорий', 'Лепс'),
(6, 'Mersedec', 'trala', 2014, 0, 85000, NULL, NULL),
(7, 'Mersedec', 'trala', 2017, 1, 87000, 'Григорий', 'Лепс'),
(8, 'Mersedec', 'trada', 2013, 0, 14000, NULL, NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `auto`
--
ALTER TABLE `auto`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `auto`
--
ALTER TABLE `auto`
  MODIFY `ID` int(4) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
