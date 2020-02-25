-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Дек 29 2019 г., 10:47
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
(10, 'Газовиков 11', 'ООО \"Профнастил\"', '89199283415', 'prof@gmail.com'),
(11, 'Луначарского 28', 'ОАО \"Союз\"', '34215423', 'soyz@gmail.com');

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
(29, 10, 8, 27, 1, 8, 4234, 'Найти тендер', '2019-12-05', 5),
(30, 11, 7, 27, 3, 8, 21345, 'Поиск компьютеров', '2019-12-05', 4);

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
(6, 'Гос закупки', 'www.gov.ru'),
(8, 'Коммерческие закупки', 'www.comercial.com');

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
(27, 18, 'Сидоров Иван Иванович', '89324215', 'chel@mail.com');

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
(1, 'Легкая промышленность'),
(3, 'Компьютьерные услуги');

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
(18, 'Специалист по мониторингу');

-- --------------------------------------------------------

--
-- Структура таблицы `tariffs`
--

CREATE TABLE `tariffs` (
  `Kod_t` int(11) NOT NULL,
  `name_t` varchar(255) NOT NULL,
  `Price_t` varchar(255) NOT NULL,
  `About_t` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `tariffs`
--

INSERT INTO `tariffs` (`Kod_t`, `name_t`, `Price_t`, `About_t`) VALUES
(7, 'Комплексное обслужтвание тендеров', '3000', 'Сопровождение'),
(8, 'Получение электронной подписи', '1500', 'Помощь в получении подписи');

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
  MODIFY `id_k` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT для таблицы `contract`
--
ALTER TABLE `contract`
  MODIFY `ID_D` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT для таблицы `electronic_platform`
--
ALTER TABLE `electronic_platform`
  MODIFY `ID_p` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT для таблицы `employee`
--
ALTER TABLE `employee`
  MODIFY `kod_E` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT для таблицы `industry`
--
ALTER TABLE `industry`
  MODIFY `id_o` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `position`
--
ALTER TABLE `position`
  MODIFY `Kod_dolzh` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT для таблицы `tariffs`
--
ALTER TABLE `tariffs`
  MODIFY `Kod_t` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

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
