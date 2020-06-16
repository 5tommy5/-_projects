-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jun 05, 2020 at 01:49 AM
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
-- Database: `restaurant`
--

-- --------------------------------------------------------

--
-- Table structure for table `zakaz`
--

CREATE TABLE `zakaz` (
  `ID` int(4) UNSIGNED NOT NULL,
  `z_type` varchar(5) NOT NULL,
  `z_table` int(2) NOT NULL,
  `z_text` varchar(255) NOT NULL,
  `price` int(5) NOT NULL,
  `ready` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `zakaz`
--

INSERT INTO `zakaz` (`ID`, `z_type`, `z_table`, `z_text`, `price`, `ready`) VALUES
(15, 'Кухня', 2, 'System.Windows.Forms.RichTextBox, Text: Тушенка\nКапуста по Гонкогски', 130, 1),
(18, 'Кухня', 7, 'System.Windows.Forms.RichTextBox, Text: Uhtxf', 10, 1),
(19, 'Бар', 7, 'System.Windows.Forms.RichTextBox, Text: yyyy', 10, 1),
(20, 'Бар', 8, 'System.Windows.Forms.RichTextBox, Text: yyyy', 10, 1),
(22, 'Кухня', 5, 'System.Windows.Forms.RichTextBox, Text: Борщ\nСалат', 100, 1),
(23, 'Кухня', 8, 'System.Windows.Forms.RichTextBox, Text: Борщ\nСалат\nХдеб', 120, 1),
(24, 'Кухня', 10, 'System.Windows.Forms.RichTextBox, Text: хлеб\nвода', 200, 1),
(25, 'Кухня', 10, 'System.Windows.Forms.RichTextBox, Text: Борщ\nЦезарь', 130, 1),
(26, 'Бар', 7, 'System.Windows.Forms.RichTextBox, Text: лонг айленд\n', 95, 0),
(27, 'Бар', 7, 'System.Windows.Forms.RichTextBox, Text: зеленая фея', 96, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `zakaz`
--
ALTER TABLE `zakaz`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `zakaz`
--
ALTER TABLE `zakaz`
  MODIFY `ID` int(4) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
