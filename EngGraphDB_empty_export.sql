-- phpMyAdmin SQL Dump
-- version 4.0.10
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1:3306
-- Время создания: Фев 14 2014 г., 20:19
-- Версия сервера: 5.5.35-log
-- Версия PHP: 5.3.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `EngGraphDB`
--

-- --------------------------------------------------------

--
-- Структура таблицы `Questions`
--

CREATE TABLE IF NOT EXISTS `Questions` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `test_id` int(11) NOT NULL,
  `q_text` text COLLATE utf8_unicode_ci NOT NULL,
  `var1` tinytext COLLATE utf8_unicode_ci NOT NULL,
  `var2` tinytext COLLATE utf8_unicode_ci NOT NULL,
  `var3` tinytext COLLATE utf8_unicode_ci NOT NULL,
  `var4` tinytext COLLATE utf8_unicode_ci NOT NULL,
  `var5` tinytext COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Структура таблицы `Results`
--

CREATE TABLE IF NOT EXISTS `Results` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `studentsurname` tinytext COLLATE utf8_unicode_ci NOT NULL,
  `surname_fname` tinytext COLLATE utf8_unicode_ci NOT NULL,
  `faculty` tinytext COLLATE utf8_unicode_ci NOT NULL,
  `group` tinytext COLLATE utf8_unicode_ci NOT NULL,
  `date_time` datetime NOT NULL,
  `completion_time` time NOT NULL,
  `sum_mark` int(11) NOT NULL,
  `Q1_mark` int(11) NOT NULL,
  `Q2_mark` int(11) NOT NULL,
  `Q3_mark` int(11) NOT NULL,
  `Q4_mark` int(11) NOT NULL,
  `Q5_mark` int(11) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Структура таблицы `TestList`
--

CREATE TABLE IF NOT EXISTS `TestList` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `test_name` tinytext COLLATE utf8_unicode_ci NOT NULL,
  `variant` int(11) NOT NULL,
  `question_table_id` int(11) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
