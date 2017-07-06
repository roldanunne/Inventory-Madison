-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jul 06, 2017 at 04:28 PM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 5.6.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `branch`
--

CREATE TABLE `branch` (
  `id` int(11) NOT NULL,
  `name` text NOT NULL,
  `address` text NOT NULL,
  `contact` text NOT NULL,
  `status` int(11) NOT NULL,
  `created_by` int(11) NOT NULL,
  `delete_flag` int(11) NOT NULL,
  `dt_created` datetime NOT NULL,
  `dt_updated` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `branch`
--

INSERT INTO `branch` (`id`, `name`, `address`, `contact`, `status`, `created_by`, `delete_flag`, `dt_created`, `dt_updated`) VALUES
(870, 'mmm', 'm', '034343434343', 0, 110, 0, '0000-00-00 00:00:00', '2017-07-04 09:37:19'),
(871, 'Bayambang', 'Bayambang, Pangasinan', '0099', 2147483647, 110, 0, '0000-00-00 00:00:00', '0000-00-00 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `delivery`
--

CREATE TABLE `delivery` (
  `id` int(11) NOT NULL,
  `ref_id` int(11) NOT NULL,
  `date_created` datetime NOT NULL,
  `branch_id` int(11) NOT NULL,
  `employee_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `delivery_details`
--

CREATE TABLE `delivery_details` (
  `Id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `prod_id` int(11) NOT NULL,
  `retail_price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `delivery_report`
--

CREATE TABLE `delivery_report` (
  `del_rep_id` int(11) NOT NULL,
  `stock_out_id` int(11) NOT NULL,
  `reference_number` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `id` int(11) NOT NULL,
  `fname` varchar(255) CHARACTER SET utf8 NOT NULL,
  `lname` varchar(255) NOT NULL,
  `gender` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `useraccess` varchar(255) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `status` tinyint(4) NOT NULL COMMENT '1=Active 0=Not Active',
  `delete_flag` tinyint(1) NOT NULL COMMENT '1=Deleted 0=Not Deleted',
  `dt_created` datetime NOT NULL,
  `dt_updated` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`id`, `fname`, `lname`, `gender`, `address`, `useraccess`, `username`, `password`, `status`, `delete_flag`, `dt_created`, `dt_updated`) VALUES
(1, 'Superadmin', 'Superadmin', 'Female', 'This is a test address og superadmin', '1,2,3,4,5,6,7,8,', 'admin', 'admin', 1, 0, '0000-00-00 00:00:00', '2017-07-04 10:20:47'),
(2, 'Sunny', 'Ang', 'Male', 'Madizon Calasiao', '1,2,3,4,5,', 'ang', 'ang', 1, 0, '2017-03-08 00:00:00', '2017-07-04 10:21:04'),
(3, 'New', 'Test', 'Male', 'New Test Address', '1,2,5,', 'test', 'test', 1, 0, '2017-03-17 00:00:00', '2017-07-04 10:10:20'),
(4, 'Mike', 'Junio', 'Male', 'Calasiao', '3,4,5,', 'mike', 'mike', 0, 1, '2017-03-17 00:00:00', '2017-03-16 18:15:29'),
(5, 'This Is', 'Test', 'Male', 'This is a test address', '1,2,3,4,5,7,8,', 'test', 'test', 1, 0, '2017-06-26 00:00:00', '2017-07-04 09:40:37');

-- --------------------------------------------------------

--
-- Table structure for table `inventory_adjustment`
--

CREATE TABLE `inventory_adjustment` (
  `id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `unit_cost` float NOT NULL,
  `total_cost` float NOT NULL,
  `status` text NOT NULL,
  `reason` text NOT NULL,
  `memo` text NOT NULL,
  `prod_id` int(11) NOT NULL,
  `employee_id` int(11) NOT NULL,
  `date_created` datetime NOT NULL,
  `date_updated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `inventory_adjustment`
--

INSERT INTO `inventory_adjustment` (`id`, `quantity`, `unit_cost`, `total_cost`, `status`, `reason`, `memo`, `prod_id`, `employee_id`, `date_created`, `date_updated`) VALUES
(1, 1, 100, 100, '', 'Damage', 'return within 2 weeks', 1, 1, '2017-03-21 00:00:00', '2017-03-23 09:46:27'),
(3, 2, 1650.5, 0, 'Pending', 'Over stock in', '', 1, 1, '2017-03-22 21:41:12', '0000-00-00 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `logfile`
--

CREATE TABLE `logfile` (
  `log_id` int(11) NOT NULL,
  `log_file` text NOT NULL,
  `user_id` int(11) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `logfile`
--

INSERT INTO `logfile` (`log_id`, `log_file`, `user_id`, `created_at`) VALUES
(1, 'because quantiry is overload', 1, '2017-03-07 05:50:21');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `id` int(11) NOT NULL,
  `barcode` text NOT NULL,
  `prod_name` text NOT NULL,
  `prod_desc` text NOT NULL,
  `prod_class` text NOT NULL,
  `prod_price` float NOT NULL,
  `prod_qty` int(11) NOT NULL,
  `critical_stock` int(11) NOT NULL,
  `employee_id` int(11) NOT NULL,
  `date_created` datetime NOT NULL,
  `date_updated` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`id`, `barcode`, `prod_name`, `prod_desc`, `prod_class`, `prod_price`, `prod_qty`, `critical_stock`, `employee_id`, `date_created`, `date_updated`) VALUES
(1, '9130611866', 'HeadLight', 'Driver Side, Fits Models Without Xtreme Edition Package, With Bulb(s), Clear Lens, Black Interior Driver Side, Fits Models Without Xtreme Edition Package, With Bulb(s), Clear Lens, Black Interior', 'A', 1650.5, 0, 0, 1, '2017-03-02 22:46:02', '2017-03-22 12:15:44'),
(3, '3853409962', 'Brake Calipers', 'Semi-loaded (Caliper & Hardware), Direct Fit', 'C', 3100, 0, 0, 1, '2017-03-04 13:52:52', '2017-03-17 14:39:57'),
(39, '8587903978', 'm', 'm', 'm', 0, 0, 10, 1, '2017-03-15 00:14:57', '0000-00-00 00:00:00'),
(40, '8346419093', 'm', 'm', 'z', 0, 0, 10, 1, '2017-03-15 00:16:47', '0000-00-00 00:00:00'),
(41, '8716864043', 'm', 'k', 'k', 0, 0, 10, 1, '2017-03-15 00:17:42', '0000-00-00 00:00:00'),
(42, '7206691941', 'l', 'l', 'l', 0, 0, 10, 1, '2017-03-15 00:19:25', '2017-03-15 00:19:25'),
(43, '8927354564', 'Brake Fluid', 'For 4t Motor', 'A', 0, 0, 10, 1, '2017-03-20 16:40:24', '0000-00-00 00:00:00'),
(44, '9292460045', 'o', 'o', 'o', 0, 0, 10, 1, '2017-03-20 16:42:05', '0000-00-00 00:00:00'),
(45, '9253154180', 'i', 'i', 'i', 0, 0, 10, 1, '2017-03-20 16:44:03', '0000-00-00 00:00:00'),
(46, '8379584135', 'k', 'k', 'k', 0, 0, 10, 1, '2017-03-20 16:56:21', '0000-00-00 00:00:00'),
(47, '2457756629', 'j', 'j', 'j', 0, 0, 10, 1, '2017-03-20 16:57:44', '0000-00-00 00:00:00'),
(48, '2028223703', 'h', 'h', 'h', 0, 0, 10, 1, '2017-03-20 16:57:44', '0000-00-00 00:00:00'),
(49, '0137349762', 'v', 'v', 'v', 0, 0, 10, 1, '2017-03-20 16:58:51', '0000-00-00 00:00:00'),
(50, '6943712941', 'f', 'f', 'f', 0, 0, 10, 1, '2017-03-20 16:58:51', '0000-00-00 00:00:00'),
(51, '7978193365', 's', 's', 's', 0, 0, 10, 1, '2017-03-20 16:58:51', '0000-00-00 00:00:00'),
(52, '9764303000', 'n', 'n', 'n', 0, 0, 10, 1, '2017-03-20 17:03:17', '0000-00-00 00:00:00'),
(53, '9456883760', 'y', 'y', 'y', 0, 0, 10, 1, '2017-03-20 17:03:17', '0000-00-00 00:00:00'),
(54, '1728607840', 'q', 'n', 'n', 0, 0, 10, 1, '2017-03-20 17:03:17', '0000-00-00 00:00:00'),
(55, '2271963181', 'xc', 'h', 'h', 0, 0, 10, 1, '2017-03-20 17:03:17', '0000-00-00 00:00:00'),
(56, '0616343143', 'hhghg', 'g', 'j', 0, 0, 10, 1, '2017-03-20 17:08:48', '0000-00-00 00:00:00'),
(57, '6630079108', 'jhjjh', 'h', 'h', 0, 0, 10, 1, '2017-03-20 17:08:48', '0000-00-00 00:00:00'),
(58, '4198815415', 'b', 'b', 'b', 0, 0, 10, 1, '2017-03-20 17:08:48', '0000-00-00 00:00:00'),
(59, '3799311536', 'knknknk', 'knknknk', 'nknk', 0, 0, 10, 1, '2017-03-20 17:10:15', '0000-00-00 00:00:00'),
(60, '4803355480', 'hhhh', 'hhhh', 'h', 0, 0, 10, 1, '2017-03-20 17:10:15', '0000-00-00 00:00:00'),
(61, '5451287542', 'hbhh', 'hbhbhbh', 'bh', 0, 0, 10, 1, '2017-03-20 17:10:15', '0000-00-00 00:00:00'),
(62, '2223004851', 'popo', 'n', 'n', 0, 0, 10, 1, '2017-03-20 17:16:36', '0000-00-00 00:00:00'),
(63, '5622035186', 'huh', 'b', 'b', 0, 0, 10, 1, '2017-03-20 17:16:36', '0000-00-00 00:00:00'),
(64, '8146277213', 'hhvhv', 'vvv', 'vv', 0, 0, 10, 1, '2017-03-20 17:33:39', '0000-00-00 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `prod_properties`
--

CREATE TABLE `prod_properties` (
  `prop_id` int(11) NOT NULL,
  `prop_name` text NOT NULL,
  `prop_value` text NOT NULL,
  `barcode` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `prod_properties`
--

INSERT INTO `prod_properties` (`prop_id`, `prop_name`, `prop_value`, `barcode`) VALUES
(7, 'mmmmm', 'mmmmm', '1'),
(11, 'bbmkmk', 'kmkmkm', '4767048620'),
(12, 'Height', '12"', '5518201832');

-- --------------------------------------------------------

--
-- Table structure for table `rack`
--

CREATE TABLE `rack` (
  `id` int(11) NOT NULL,
  `rack_name` text NOT NULL,
  `rack_desc` text NOT NULL,
  `date_created` datetime NOT NULL,
  `date_updated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `employee_id` int(11) NOT NULL,
  `prod_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `rack`
--

INSERT INTO `rack` (`id`, `rack_name`, `rack_desc`, `date_created`, `date_updated`, `employee_id`, `prod_id`) VALUES
(1, 'mm', 'mm', '2017-03-20 11:53:39', '0000-00-00 00:00:00', 1, 39),
(2, '101', 'Malapit lang sa front door', '2017-03-20 12:23:06', '0000-00-00 00:00:00', 1, 1),
(3, 'Rack 102', 'Tabi ng 101', '2017-03-20 17:58:38', '2017-03-22 10:36:00', 1, 1),
(4, 'Rack 102', 'tabi ng front', '2017-03-22 10:36:00', '0000-00-00 00:00:00', 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `rack_level`
--

CREATE TABLE `rack_level` (
  `id` int(11) NOT NULL,
  `level_name` text NOT NULL,
  `level_desc` text NOT NULL,
  `capacity` int(11) NOT NULL,
  `date_created` datetime NOT NULL,
  `date_updated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `employee_id` int(11) NOT NULL,
  `rack_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `rack_level`
--

INSERT INTO `rack_level` (`id`, `level_name`, `level_desc`, `capacity`, `date_created`, `date_updated`, `employee_id`, `rack_id`) VALUES
(11, '1', 'Electrical Materials', 200, '2017-03-17 14:21:35', '2017-03-17 14:21:35', 1, 49),
(12, '2', 'Turbines', 150, '2017-03-17 14:21:35', '0000-00-00 00:00:00', 1, 49),
(13, 'mm', 'njnj', 9, '2017-03-20 11:22:44', '0000-00-00 00:00:00', 1, 1),
(14, 'nn', 'nnn', 9, '2017-03-20 11:53:39', '0000-00-00 00:00:00', 1, 0),
(15, 'Layer 1', 'malaki', 78, '2017-03-20 12:39:51', '0000-00-00 00:00:00', 1, 2),
(16, 'Layer 2', 'Mas malaki', 10, '2017-03-20 12:39:51', '0000-00-00 00:00:00', 1, 2),
(17, 'Layer 1', 'ok lang', 10, '2017-03-20 17:58:38', '0000-00-00 00:00:00', 1, 3);

-- --------------------------------------------------------

--
-- Table structure for table `reference`
--

CREATE TABLE `reference` (
  `ref_id` int(11) NOT NULL,
  `ref_number` int(11) NOT NULL,
  `employee_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `reference`
--

INSERT INTO `reference` (`ref_id`, `ref_number`, `employee_id`) VALUES
(1, 0, 0),
(2, 10013421, 0),
(3, 10023741, 0),
(4, 10033731, 0),
(5, 1004374, 0),
(6, 1005377, 0),
(7, 10063745, 0),
(8, 10073719, 0),
(9, 10083734, 0),
(10, 10093107, 0),
(11, 101031014, 0),
(12, 101131036, 0),
(13, 101231056, 0),
(14, 101331035, 0);

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `sales_id` int(11) NOT NULL,
  `amount` int(20) NOT NULL,
  `qty` int(11) NOT NULL,
  `prod_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`sales_id`, `amount`, `qty`, `prod_id`) VALUES
(1, 600, 4, 23);

-- --------------------------------------------------------

--
-- Table structure for table `stocks`
--

CREATE TABLE `stocks` (
  `id` int(11) NOT NULL,
  `prod_id` int(11) NOT NULL,
  `rack_id` int(11) NOT NULL,
  `rack_name` text NOT NULL,
  `level_id` int(11) NOT NULL,
  `level_name` text NOT NULL,
  `qty_in` int(11) NOT NULL,
  `qty_out` int(11) NOT NULL,
  `price` double NOT NULL,
  `status` int(11) NOT NULL,
  `reference` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stocks`
--

INSERT INTO `stocks` (`id`, `prod_id`, `rack_id`, `rack_name`, `level_id`, `level_name`, `qty_in`, `qty_out`, `price`, `status`, `reference`, `user_id`, `created_at`, `updated_at`) VALUES
(1, 1, 2, '101', 15, 'Layer 1', 9, 0, 100, 0, 2147483647, 1, '2016-03-26 11:33:21', '2017-03-26 11:33:21'),
(2, 3, 2, '101', 15, 'Layer 1', 10, 0, 100, 0, 2147483647, 1, '2017-02-26 11:34:44', '2017-03-26 11:34:44'),
(3, 1, 2, '101', 15, 'Layer 1', 1, 0, 10, 0, 2147483647, 1, '2017-03-02 12:16:37', '2017-04-02 12:16:37'),
(4, 1, 2, '101', 16, 'Layer 2', 10, 0, 1, 0, 2147483647, 1, '2017-04-19 20:41:01', '2017-04-19 20:41:01');

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `id` int(11) NOT NULL,
  `name` text NOT NULL,
  `address` text NOT NULL,
  `contact` text NOT NULL,
  `status` int(11) NOT NULL,
  `created_by` int(11) NOT NULL,
  `delete_flag` int(11) NOT NULL,
  `dt_created` datetime NOT NULL,
  `dt_updated` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`id`, `name`, `address`, `contact`, `status`, `created_by`, `delete_flag`, `dt_created`, `dt_updated`) VALUES
(3, 'Auto Mechanic', 'Calasiao, Pangasinan', '88112323232', 0, 0, 0, '2017-07-10 00:00:00', '2017-07-04 09:28:18'),
(6, 'Motoposh', 'Makati', '09098765433', 1, 0, 0, '2017-07-03 00:00:00', '2017-07-04 09:28:22'),
(7, 'test ko lang', 'This is a test address', '2323232323', 0, 0, 1, '2017-07-02 00:00:00', '2017-07-02 00:00:00'),
(8, 'Test', 'Test', '343434', 1, 0, 0, '2017-07-04 09:28:08', '2017-07-04 09:28:27');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `branch`
--
ALTER TABLE `branch`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `delivery`
--
ALTER TABLE `delivery`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `delivery_details`
--
ALTER TABLE `delivery_details`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `delivery_report`
--
ALTER TABLE `delivery_report`
  ADD PRIMARY KEY (`del_rep_id`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `inventory_adjustment`
--
ALTER TABLE `inventory_adjustment`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `logfile`
--
ALTER TABLE `logfile`
  ADD PRIMARY KEY (`log_id`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `prod_properties`
--
ALTER TABLE `prod_properties`
  ADD PRIMARY KEY (`prop_id`);

--
-- Indexes for table `rack`
--
ALTER TABLE `rack`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `rack_level`
--
ALTER TABLE `rack_level`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `reference`
--
ALTER TABLE `reference`
  ADD PRIMARY KEY (`ref_id`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`sales_id`);

--
-- Indexes for table `stocks`
--
ALTER TABLE `stocks`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `branch`
--
ALTER TABLE `branch`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=872;
--
-- AUTO_INCREMENT for table `delivery`
--
ALTER TABLE `delivery`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `delivery_details`
--
ALTER TABLE `delivery_details`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `delivery_report`
--
ALTER TABLE `delivery_report`
  MODIFY `del_rep_id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `inventory_adjustment`
--
ALTER TABLE `inventory_adjustment`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `logfile`
--
ALTER TABLE `logfile`
  MODIFY `log_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=65;
--
-- AUTO_INCREMENT for table `prod_properties`
--
ALTER TABLE `prod_properties`
  MODIFY `prop_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `rack`
--
ALTER TABLE `rack`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `rack_level`
--
ALTER TABLE `rack_level`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
--
-- AUTO_INCREMENT for table `reference`
--
ALTER TABLE `reference`
  MODIFY `ref_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `sales_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `stocks`
--
ALTER TABLE `stocks`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
