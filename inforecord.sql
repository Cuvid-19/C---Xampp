-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 29, 2020 at 10:14 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.2.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inforecord`
--

-- --------------------------------------------------------

--
-- Table structure for table `leavetable`
--

CREATE TABLE `leavetable` (
  `Name` varchar(50) NOT NULL,
  `LeaveCases` int(200) NOT NULL,
  `DateCreated` varchar(20) NOT NULL,
  `Day` varchar(20) NOT NULL,
  `LeaveStarted` varchar(20) NOT NULL,
  `LeaveEnded` varchar(20) NOT NULL,
  `LeaveStatus` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `leavetable`
--

INSERT INTO `leavetable` (`Name`, `LeaveCases`, `DateCreated`, `Day`, `LeaveStarted`, `LeaveEnded`, `LeaveStatus`) VALUES
('', 0, 'Thursday, April 16, ', 'Half Day', '4:47:41 PM', '4:47:41 PM', 'Decline'),
('admin', 0, 'Sunday, April 19, 20', 'Full Day', '11:29:43 PM', '11:29:43 PM', 'Decline'),
('admin', 0, 'Monday, April 20, 20', 'Full Day', '9:58:33 PM', '9:58:33 PM', 'Decline'),
('admin', 1, 'Tuesday, April 21, 2', 'Half Day', '5:57:13 PM', '5:57:13 PM', 'Decline'),
('admin', 1, 'Friday, April 24, 20', '', '5:07:36 PM', '5:07:36 PM', 'Pending');

-- --------------------------------------------------------

--
-- Table structure for table `overtimetable`
--

CREATE TABLE `overtimetable` (
  `OTCreatedBy` varchar(25) NOT NULL,
  `OTStarted` varchar(25) NOT NULL,
  `OTEnded` varchar(25) NOT NULL,
  `OTDateCreated` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `overtimetable`
--

INSERT INTO `overtimetable` (`OTCreatedBy`, `OTStarted`, `OTEnded`, `OTDateCreated`) VALUES
('admin', '10:05:44 PM', '10:05:44 PM', 'Friday, April 17, 2020'),
('admin', '4:15:52 PM', '4:15:52 PM', 'Friday, April 24, 2020');

-- --------------------------------------------------------

--
-- Table structure for table `userinfo`
--

CREATE TABLE `userinfo` (
  `Name` varchar(100) NOT NULL,
  `IdentificationCard` int(50) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `Nationality` varchar(50) NOT NULL,
  `Status` varchar(25) NOT NULL,
  `ID` int(20) NOT NULL,
  `Password` varchar(20) NOT NULL,
  `Username` varchar(20) NOT NULL,
  `DateCreated` varchar(25) NOT NULL,
  `LastLogin` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `userinfo`
--

INSERT INTO `userinfo` (`Name`, `IdentificationCard`, `Address`, `Nationality`, `Status`, `ID`, `Password`, `Username`, `DateCreated`, `LastLogin`) VALUES
('0', 0, '0', '', '', 1, 'admin', 'admin', '4/16/2020 1:23:39 PM', '4/28/2020 4:05:37 PM'),
('0', 0, '0', '', '', 2, 'user', 'user', '4/22/2020 10:07:12 PM', '4/22/2020 10:07:12 PM');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `userinfo`
--
ALTER TABLE `userinfo`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `userinfo`
--
ALTER TABLE `userinfo`
  MODIFY `ID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
