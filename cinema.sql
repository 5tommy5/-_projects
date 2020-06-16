-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jun 02, 2020 at 05:09 AM
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
-- Database: `cinema`
--

-- --------------------------------------------------------

--
-- Table structure for table `bilet`
--

CREATE TABLE `bilet` (
  `ID` int(4) UNSIGNED NOT NULL,
  `name` varchar(25) NOT NULL,
  `position` varchar(3) NOT NULL DEFAULT '1.1',
  `phone` varchar(10) NOT NULL,
  `data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `bilet`
--

INSERT INTO `bilet` (`ID`, `name`, `position`, `phone`, `data`) VALUES
(1, 'Гаваи', '1.4', '0637035715', '2020-06-02'),
(2, 'Гаваи', '1.5', '0637035715', '2020-06-02'),
(3, 'Гаваи', '1.6', '0637035715', '2020-06-02'),
(4, 'Гаваи', '1.5', '0637035715', '2020-06-02'),
(5, 'Гаваи', '1.6', '0637035715', '2020-06-02'),
(6, 'Гаваи', '1.6', '0637035716', '2020-06-02'),
(7, 'Рембо', '1.1', '0995103403', '2020-06-02'),
(8, 'Рембо', '1.6', '0665103405', '2020-06-02'),
(9, 'Санччез', '1.1', '3443445456', '2020-06-02'),
(10, 'Санччез', '1.2', '3443445455', '2020-06-02'),
(11, 'Санччез', '2.1', '3443445455', '2020-06-02'),
(12, 'Рембо', '1.2', '0543223131', '2020-06-02'),
(13, 'Рембо', '1.3', '3434333454', '2020-06-02'),
(14, 'Рембо', '1.4', '380937322', '2020-06-02'),
(15, 'Рембо', '1.5', '380937321', '2020-06-02'),
(16, 'Рембо 2', '1.1', '0554334343', '2020-06-04'),
(17, 'Рембо 2', '1.6', '0554334344', '2020-06-04');

-- --------------------------------------------------------

--
-- Table structure for table `film`
--

CREATE TABLE `film` (
  `ID` int(4) UNSIGNED NOT NULL,
  `name` varchar(25) NOT NULL,
  `rezh` varchar(25) NOT NULL,
  `price` int(4) UNSIGNED NOT NULL DEFAULT '100'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `film`
--

INSERT INTO `film` (`ID`, `name`, `rezh`, `price`) VALUES
(1, 'Рембо', 'Бибер', 120),
(2, 'Рембо 2', 'Сталин', 145),
(3, 'Санччез', 'Диего', 75),
(4, 'Гаваи', 'Патрик', 117),
(5, 'Мартышки', 'Санузел', 666);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bilet`
--
ALTER TABLE `bilet`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `film`
--
ALTER TABLE `film`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bilet`
--
ALTER TABLE `bilet`
  MODIFY `ID` int(4) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `film`
--
ALTER TABLE `film`
  MODIFY `ID` int(4) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
