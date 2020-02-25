-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Дек 27 2019 г., 07:48
-- Версия сервера: 10.3.13-MariaDB
-- Версия PHP: 7.1.22

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `tender_company`
--

-- --------------------------------------------------------

--
-- Структура таблицы `client`
--

CREATE TABLE `client` (
  `id_k` int(11) NOT NULL,
  `Adress_k` varchar(255) NOT NULL,
  `Name_k` varchar(255) NOT NULL,
  `Number_k` varchar(255) NOT NULL,
  `Email_k` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `client`
--

INSERT INTO `client` (`id_k`, `Adress_k`, `Name_k`, `Number_k`, `Email_k`) VALUES
(1, 'да колотушкина', 'каво тендер плюс', '3353535', 'tenderrr@jopa.com'),
(2, 'fdsf', 'dfgdfg', 'sdfsdf', 'dfgdfg'),
(6, 'ЖОПА', 'НЕЙМ', '', 'DEN228@FDSF');

-- --------------------------------------------------------

--
-- Структура таблицы `contract`
--

CREATE TABLE `contract` (
  `ID_D` int(11) NOT NULL,
  `ID_K` int(255) NOT NULL,
  `Kod_t` int(255) NOT NULL,
  `ID_E` int(255) NOT NULL,
  `Id_o` int(255) NOT NULL,
  `Id_electronicP` int(255) NOT NULL,
  `Price` int(255) NOT NULL,
  `About` varchar(255) NOT NULL,
  `Date_conclution` date NOT NULL,
  `Term` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `contract`
--

INSERT INTO `contract` (`ID_D`, `ID_K`, `Kod_t`, `ID_E`, `Id_o`, `Id_electronicP`, `Price`, `About`, `Date_conclution`, `Term`) VALUES
(5, 6, 1, 6, 1, 1, 35345, 'sdfdsf', '2019-12-27', 432),
(6, 6, 1, 6, 1, 1, 35345, 'sdfdsf', '2019-12-27', 432),
(7, 6, 1, 6, 1, 1, 35345, 'sdfdsf', '2019-12-27', 432),
(8, 6, 1, 6, 1, 1, 35345, 'sdfdsf', '2019-12-27', 432),
(9, 6, 1, 6, 1, 1, 35345, 'sdfdsf', '2019-12-27', 432),
(10, 6, 1, 6, 1, 1, 35345, 'sdfdsf', '2019-12-27', 432),
(12, 1, 2, 6, 1, 1, 228, 'xzvdzxfv', '2019-12-12', 234324),
(13, 1, 2, 6, 1, 1, 324234, 'dxvcxcv', '2019-12-27', 228);

-- --------------------------------------------------------

--
-- Структура таблицы `electronic_platform`
--

CREATE TABLE `electronic_platform` (
  `ID_p` int(11) NOT NULL,
  `name_p` varchar(255) NOT NULL,
  `electronic_adress` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `electronic_platform`
--

INSERT INTO `electronic_platform` (`ID_p`, `name_p`, `electronic_adress`) VALUES
(1, 'ааа', 'мммыуа');

-- --------------------------------------------------------

--
-- Структура таблицы `employee`
--

CREATE TABLE `employee` (
  `kod_E` int(11) NOT NULL,
  `K_dolzh` int(255) NOT NULL,
  `FIO_E` varchar(255) NOT NULL,
  `Number_E` varchar(255) NOT NULL,
  `Email_E` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `employee`
--

INSERT INTO `employee` (`kod_E`, `K_dolzh`, `FIO_E`, `Number_E`, `Email_E`) VALUES
(6, 5, 'вмыывмывыв', '', 'ыфафы');

-- --------------------------------------------------------

--
-- Структура таблицы `industry`
--

CREATE TABLE `industry` (
  `id_o` int(11) NOT NULL,
  `name_o` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `industry`
--

INSERT INTO `industry` (`id_o`, `name_o`) VALUES
(1, 'Промышленность');

-- --------------------------------------------------------

--
-- Структура таблицы `position`
--

CREATE TABLE `position` (
  `Kod_dolzh` int(11) NOT NULL,
  `Name_dolzh` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `position`
--

INSERT INTO `position` (`Kod_dolzh`, `Name_dolzh`) VALUES
(5, 'Белый шум');

-- --------------------------------------------------------

--
-- Структура таблицы `tariffs`
--

CREATE TABLE `tariffs` (
  `Kod_t` int(11) NOT NULL,
  `Price_t` varchar(255) NOT NULL,
  `About_t` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `tariffs`
--

INSERT INTO `tariffs` (`Kod_t`, `Price_t`, `About_t`) VALUES
(1, '22888', 'Найдем все че надо те'),
(2, '228', 'йоу');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`id_k`),
  ADD KEY `id_k` (`id_k`);

--
-- Индексы таблицы `contract`
--
ALTER TABLE `contract`
  ADD PRIMARY KEY (`ID_D`),
  ADD KEY `ID_K` (`ID_K`),
  ADD KEY `Kod_t` (`Kod_t`),
  ADD KEY `ID_E` (`ID_E`),
  ADD KEY `Id_o` (`Id_o`),
  ADD KEY `Id_electronicP` (`Id_electronicP`);

--
-- Индексы таблицы `electronic_platform`
--
ALTER TABLE `electronic_platform`
  ADD PRIMARY KEY (`ID_p`),
  ADD KEY `ID_p` (`ID_p`);

--
-- Индексы таблицы `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`kod_E`),
  ADD KEY `K_dolzh` (`K_dolzh`),
  ADD KEY `kod_E` (`kod_E`);

--
-- Индексы таблицы `industry`
--
ALTER TABLE `industry`
  ADD PRIMARY KEY (`id_o`),
  ADD KEY `id_o` (`id_o`);

--
-- Индексы таблицы `position`
--
ALTER TABLE `position`
  ADD PRIMARY KEY (`Kod_dolzh`);

--
-- Индексы таблицы `tariffs`
--
ALTER TABLE `tariffs`
  ADD PRIMARY KEY (`Kod_t`),
  ADD KEY `Kod_t` (`Kod_t`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `client`
--
ALTER TABLE `client`
  MODIFY `id_k` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT для таблицы `contract`
--
ALTER TABLE `contract`
  MODIFY `ID_D` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT для таблицы `electronic_platform`
--
ALTER TABLE `electronic_platform`
  MODIFY `ID_p` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `employee`
--
ALTER TABLE `employee`
  MODIFY `kod_E` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `industry`
--
ALTER TABLE `industry`
  MODIFY `id_o` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `position`
--
ALTER TABLE `position`
  MODIFY `Kod_dolzh` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `tariffs`
--
ALTER TABLE `tariffs`
  MODIFY `Kod_t` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `contract`
--
ALTER TABLE `contract`
  ADD CONSTRAINT `contract_ibfk_2` FOREIGN KEY (`ID_K`) REFERENCES `client` (`id_k`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `contract_ibfk_4` FOREIGN KEY (`Kod_t`) REFERENCES `tariffs` (`Kod_t`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `contract_ibfk_5` FOREIGN KEY (`ID_E`) REFERENCES `employee` (`kod_E`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `contract_ibfk_6` FOREIGN KEY (`Id_o`) REFERENCES `industry` (`id_o`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `contract_ibfk_7` FOREIGN KEY (`Id_electronicP`) REFERENCES `electronic_platform` (`ID_p`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `employee`
--
ALTER TABLE `employee`
  ADD CONSTRAINT `employee_ibfk_1` FOREIGN KEY (`K_dolzh`) REFERENCES `position` (`Kod_dolzh`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
