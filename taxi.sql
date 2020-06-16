-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jun 01, 2020 at 06:19 AM
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
-- Database: `taxi`
--

-- --------------------------------------------------------

--
-- Table structure for table `clients`
--

CREATE TABLE `clients` (
  `ID` int(4) NOT NULL,
  `name` varchar(25) NOT NULL,
  `login` varchar(25) NOT NULL,
  `password` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `clients`
--

INSERT INTO `clients` (`ID`, `name`, `login`, `password`) VALUES
(1, 'Arthur', 'login', 'qwerty'),
(2, 'Greg', 'loginen', 'qwerty'),
(3, 'Dima', 'grubui', 'qwerty'),
(4, '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `regions`
--

CREATE TABLE `regions` (
  `name` varchar(25) NOT NULL,
  `far_from_center` int(4) UNSIGNED NOT NULL,
  `far_from_obolon` int(4) UNSIGNED NOT NULL,
  `far_from_sviatoshin` int(4) UNSIGNED NOT NULL,
  `far_from_soloma` int(4) UNSIGNED NOT NULL,
  `far_from_pechersk` int(4) UNSIGNED NOT NULL,
  `far_from_darnica` int(4) UNSIGNED NOT NULL,
  `far_from_shevchenka` int(4) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `regions`
--

INSERT INTO `regions` (`name`, `far_from_center`, `far_from_obolon`, `far_from_sviatoshin`, `far_from_soloma`, `far_from_pechersk`, `far_from_darnica`, `far_from_shevchenka`) VALUES
('Оболонь', 20, 0, 7, 24, 22, 29, 13),
('Святошин', 17, 5, 0, 5, 14, 25, 4),
('Соломянский', 4, 20, 5, 0, 5, 10, 5),
('Печерский', 2, 17, 10, 5, 0, 10, 5),
('Дарница', 20, 34, 20, 15, 12, 0, 10),
('Шевченковский', 4, 4, 6, 4, 3, 14, 0);

-- --------------------------------------------------------

--
-- Table structure for table `rides`
--

CREATE TABLE `rides` (
  `from_where` varchar(25) NOT NULL,
  `to_where` varchar(25) NOT NULL,
  `marka` varchar(25) NOT NULL,
  `price` int(4) UNSIGNED NOT NULL,
  `id_clienta` int(4) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `rides`
--

INSERT INTO `rides` (`from_where`, `to_where`, `marka`, `price`, `id_clienta`) VALUES
('Оболонь', 'Соломянский', 'Opel', 54, 3),
('Оболонь', 'Печерский', 'Opel', 52, 3),
('Оболонь', 'Святошин', 'Opel', 74, 3),
('Святошин', 'Печерский', 'Opel', 88, 3),
('Оболонь', 'Дарница', 'Volkswagen', 118, 3),
('Оболонь', 'Дарница', 'Volkswagen', 118, 3),
('Дарница', 'Соломянский', 'Volkswagen', 90, 3),
('Святошин', 'Соломянский', 'Opel', 70, 3),
('Соломянский', 'Дарница', 'Opel', 80, 3),
('Соломянский', 'Дарница', 'Volkswagen', 80, 3),
('Дарница', 'Печерский', 'Opel', 84, 3),
('Дарница', 'Оболонь', 'Volkswagen', 128, 1),
('Печерский', 'Оболонь', 'Opel', 94, 1),
('Оболонь', 'Шевченковский', 'Volkswagen', 86, 1);

-- --------------------------------------------------------

--
-- Table structure for table `vodiy`
--

CREATE TABLE `vodiy` (
  `ID_voditel` int(4) UNSIGNED NOT NULL,
  `name` varchar(25) NOT NULL,
  `login` varchar(25) NOT NULL,
  `password` varchar(25) NOT NULL,
  `marka` varchar(25) NOT NULL,
  `year` int(4) NOT NULL,
  `model` varchar(25) NOT NULL,
  `number` int(4) NOT NULL,
  `region` varchar(25) NOT NULL DEFAULT 'Оболонь'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `vodiy`
--

INSERT INTO `vodiy` (`ID_voditel`, `name`, `login`, `password`, `marka`, `year`, `model`, `number`, `region`) VALUES
(1, 'Dima', 'Automagnat', 'qwerty', 'Opel', 2009, 'X6', 2534, 'Оболонь'),
(2, 'Art', 'ttt', 'qwerty', 'Volkswagen', 2018, 're20', 2345, 'Шевченковский');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `login` (`login`);

--
-- Indexes for table `vodiy`
--
ALTER TABLE `vodiy`
  ADD PRIMARY KEY (`ID_voditel`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `clients`
--
ALTER TABLE `clients`
  MODIFY `ID` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `vodiy`
--
ALTER TABLE `vodiy`
  MODIFY `ID_voditel` int(4) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
