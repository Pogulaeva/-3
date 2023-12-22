-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Дек 22 2023 г., 12:03
-- Версия сервера: 5.7.24
-- Версия PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `is_fisu`
--

-- --------------------------------------------------------

--
-- Структура таблицы `orders`
--

CREATE TABLE `orders` (
  `id` int(11) NOT NULL,
  `id_product` int(11) NOT NULL,
  `amount_product` int(5) NOT NULL,
  `order_price` int(7) NOT NULL,
  `order_date` text NOT NULL,
  `order_agreement` tinyint(1) DEFAULT NULL,
  `changes_confirm` tinyint(1) DEFAULT NULL,
  `order_was_edited` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `orders`
--

INSERT INTO `orders` (`id`, `id_product`, `amount_product`, `order_price`, `order_date`, `order_agreement`, `changes_confirm`, `order_was_edited`) VALUES
(31, 8, 2, 1000, '09.12.2023 16:05:57', 1, 0, 0),
(33, 7, 5, 600, '09.12.2023 16:48:00', 1, 0, 0),
(36, 11, 4, 6250, '09.12.2023 16:56:04', 1, 1, 1),
(38, 8, 3, 1560, '09.12.2023 17:02:27', 1, 0, 0),
(39, 9, 7, 3500, '09.12.2023 19:50:41', 1, 0, 0);

-- --------------------------------------------------------

--
-- Структура таблицы `products`
--

CREATE TABLE `products` (
  `id` int(11) NOT NULL,
  `name_product` varchar(80) NOT NULL,
  `price_product` int(7) NOT NULL,
  `amount_products` int(5) NOT NULL,
  `supply_date` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `products`
--

INSERT INTO `products` (`id`, `name_product`, `price_product`, `amount_products`, `supply_date`) VALUES
(7, 'Мишура красная', 120, 0, '01.12.2023'),
(8, 'Гирлянда \"Звёздочка\"', 520, 130, '01.12.2023'),
(9, 'Ёлочная игрушка \"Ангелок\" (6 шт. в коробке)', 500, 180, '01.12.2023'),
(10, 'Кружка новогодняя \"Дед Мороз\"', 599, 200, '01.12.2023'),
(11, 'Пихта(1.5м) с подставкой', 1250, 48, '08.12.2023'),
(12, 'Ёлочка настольная (Искусственная, зелёная)', 800, 80, '09.12.2023');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`id`),
  ADD KEY `orders_ibfk_1` (`id_product`);

--
-- Индексы таблицы `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id` (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `orders`
--
ALTER TABLE `orders`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT для таблицы `products`
--
ALTER TABLE `products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`id_product`) REFERENCES `products` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
