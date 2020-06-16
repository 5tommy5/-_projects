-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: May 29, 2020 at 12:04 PM
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
-- Database: `stomotologia`
--

-- --------------------------------------------------------

--
-- Table structure for table `patient`
--

CREATE TABLE `patient` (
  `ID` int(5) UNSIGNED NOT NULL,
  `name` varchar(25) NOT NULL,
  `surname` varchar(25) NOT NULL,
  `phone` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `patient`
--

INSERT INTO `patient` (`ID`, `name`, `surname`, `phone`) VALUES
(1, 'Дима', 'Мембрановский', '0667105403'),
(2, 'Кукушка', 'Гвоздь', '0977035499'),
(3, 'Брюс', 'Ли', '0005106303'),
(4, 'Крот', 'Иванов', '0510735466'),
(5, 'Андрей', 'Иванцев', '0775106603'),
(6, 'Кот', 'Леопольд', '0113035715'),
(7, 'Офтальмолог', 'Петя', '0995657675'),
(8, 'Дом', 'Совы', '0455602343'),
(9, 'Тракторист', 'Иван', '0995653421'),
(10, 'Ширь', 'Банка', '0883427171');

-- --------------------------------------------------------

--
-- Table structure for table `personal`
--

CREATE TABLE `personal` (
  `ID` int(5) UNSIGNED NOT NULL,
  `name` varchar(25) NOT NULL,
  `surname` varchar(25) NOT NULL,
  `login` varchar(25) NOT NULL,
  `password` varchar(25) NOT NULL,
  `position` char(3) NOT NULL,
  `work_time_start` int(4) NOT NULL,
  `work_time_end` int(4) NOT NULL,
  `work_days` varchar(7) NOT NULL DEFAULT '12345'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `personal`
--

INSERT INTO `personal` (`ID`, `name`, `surname`, `login`, `password`, `position`, `work_time_start`, `work_time_end`, `work_days`) VALUES
(6, 'Влад', 'Заславский', 'admin1', 'admin1', 'adm', 830, 1930, '123456'),
(7, 'Дима', 'Хорошок', 'doctor1', 'doctor1', 'doc', 830, 1930, '1356'),
(8, 'Антон', 'Томчук', 'admin', 'admin', 'own', 830, 1930, '12345'),
(13, 'филип', 'киркоров', 'doctor2', 'doctor', 'doc', 900, 1900, '567');

-- --------------------------------------------------------

--
-- Table structure for table `talon`
--

CREATE TABLE `talon` (
  `talon_id` int(10) UNSIGNED NOT NULL,
  `doctor_id` int(5) UNSIGNED NOT NULL DEFAULT '4',
  `patient_id` int(5) UNSIGNED NOT NULL,
  `seaans_date` datetime NOT NULL,
  `seans_time` varchar(4) NOT NULL DEFAULT '1400'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `talon`
--

INSERT INTO `talon` (`talon_id`, `doctor_id`, `patient_id`, `seaans_date`, `seans_time`) VALUES
(1, 3, 3, '2020-05-25 00:00:00', '1200'),
(2, 4, 3, '2020-05-27 00:00:00', '1200'),
(5, 4, 3, '2020-05-27 00:00:00', '1200'),
(6, 7, 2, '2020-05-28 00:00:00', '1300'),
(7, 7, 2, '2020-05-29 00:00:00', '1700'),
(8, 7, 3, '2020-05-28 00:00:00', '1530'),
(9, 7, 3, '2020-05-28 00:00:00', '1331'),
(10, 7, 2, '2020-05-28 00:00:00', '1401'),
(11, 7, 2, '2020-06-02 00:00:00', '1000'),
(12, 7, 2, '2020-06-02 00:00:00', '1031'),
(13, 7, 2, '2020-06-02 00:00:00', '0929'),
(14, 7, 2, '2020-06-05 00:00:00', '1000'),
(15, 7, 2, '2020-06-05 00:00:00', '1031'),
(16, 7, 1, '2020-06-10 00:00:00', '1300'),
(17, 7, 4, '2020-06-19 00:00:00', '1000'),
(18, 7, 4, '2020-06-19 00:00:00', '1031'),
(19, 7, 4, '2020-06-19 00:00:00', '929'),
(20, 7, 8, '2020-05-15 00:00:00', '1300'),
(21, 7, 7, '2020-05-15 00:00:00', '1331'),
(22, 7, 2, '2020-05-25 00:00:00', '1400'),
(23, 7, 4, '2020-05-28 00:00:00', '1700'),
(24, 10, 4, '2020-05-30 00:00:00', '1700'),
(25, 7, 4, '2020-06-25 00:00:00', '1700'),
(26, 12, 3, '2020-06-17 00:00:00', '1300'),
(27, 12, 4, '2020-06-17 00:00:00', '1335'),
(28, 13, 3, '2020-06-27 00:00:00', '1300'),
(29, 7, 3, '2020-07-10 00:00:00', '1300'),
(30, 13, 3, '2020-07-12 00:00:00', '1300'),
(31, 13, 3, '2020-06-07 00:00:00', '1325'),
(32, 7, 3, '2020-06-17 00:00:00', '1440'),
(33, 7, 4, '2020-06-17 00:00:00', '1534');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `patient`
--
ALTER TABLE `patient`
  ADD UNIQUE KEY `patient_id` (`ID`);

--
-- Indexes for table `personal`
--
ALTER TABLE `personal`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `personal_id` (`ID`);

--
-- Indexes for table `talon`
--
ALTER TABLE `talon`
  ADD UNIQUE KEY `talon_index` (`talon_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `patient`
--
ALTER TABLE `patient`
  MODIFY `ID` int(5) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `personal`
--
ALTER TABLE `personal`
  MODIFY `ID` int(5) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `talon`
--
ALTER TABLE `talon`
  MODIFY `talon_id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
