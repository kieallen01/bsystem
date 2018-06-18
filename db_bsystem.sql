/*
MySQL Data Transfer
Source Host: localhost
Source Database: db_bsystem
Target Host: localhost
Target Database: db_bsystem
Date: 3/9/2016 10:07:26 PM
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for tbl_clientmanagement
-- ----------------------------
CREATE TABLE `tbl_clientmanagement` (
  `accountno` varchar(15) DEFAULT NULL,
  `amount` int(20) DEFAULT NULL,
  `fullname` varchar(60) DEFAULT NULL,
  `address` varchar(80) DEFAULT NULL,
  `phone` varchar(15) DEFAULT NULL,
  `dateofbirth` varchar(80) DEFAULT NULL,
  `age` varchar(10) DEFAULT NULL,
  `placeofbirth` varchar(80) DEFAULT NULL,
  `nationality` varchar(20) DEFAULT NULL,
  `occupation` varchar(20) DEFAULT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `civilstatus` varchar(10) DEFAULT NULL,
  `registrationdate` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for tbl_lasttrans
-- ----------------------------
CREATE TABLE `tbl_lasttrans` (
  `id` varchar(20) DEFAULT NULL,
  `date` varchar(50) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for tbl_transaction
-- ----------------------------
CREATE TABLE `tbl_transaction` (
  `id` varchar(50) DEFAULT NULL,
  `clientname` varchar(25) DEFAULT NULL,
  `type` varchar(15) DEFAULT NULL,
  `date` varchar(20) DEFAULT NULL,
  `amount` varchar(20) DEFAULT NULL,
  `balance` int(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for tbl_transfer
-- ----------------------------
CREATE TABLE `tbl_transfer` (
  `id` varchar(50) DEFAULT NULL,
  `sender` varchar(50) DEFAULT NULL,
  `receiverAccountNo` varchar(50) DEFAULT NULL,
  `date` varchar(50) DEFAULT NULL,
  `amount` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for tbl_usermanagement
-- ----------------------------
CREATE TABLE `tbl_usermanagement` (
  `id` varchar(15) DEFAULT NULL,
  `account` varchar(15) DEFAULT '',
  `name` varchar(30) DEFAULT NULL,
  `username` varchar(15) CHARACTER SET latin1 COLLATE latin1_bin DEFAULT '',
  `password` varchar(15) CHARACTER SET latin1 COLLATE latin1_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records 
-- ----------------------------
INSERT INTO `tbl_usermanagement` VALUES ('531', 'Manager', 'Bicera, Kier Allen', 'admin', 'admin');
