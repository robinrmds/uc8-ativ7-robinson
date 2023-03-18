-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 18-Out-2022 às 21:51
-- Versão do servidor: 10.4.24-MariaDB
-- versão do PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `uc8_sistema`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `recados`
--

CREATE TABLE `recados` (
  `idrecados` int(11) NOT NULL,
  `assunto` varchar(100) NOT NULL,
  `recado` text NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `data` date NOT NULL,
  `ativo` tinyint(4) NOT NULL,
  `sequencia` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `recados`
--

INSERT INTO `recados` (`idrecados`, `assunto`, `recado`, `id_usuario`, `data`, `ativo`, `sequencia`) VALUES
(1, 'Recado 01 Assunto', 'Recado texto 01', 0, '2022-10-14', 1, 5),
(3, 'Reado 2', 'Recado 2 ', 0, '2022-10-18', 1, 1),
(4, 'Recado 3', 'Recaco 03 Texto', 0, '2022-10-18', 1, 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `turmas`
--

CREATE TABLE `turmas` (
  `idturmas` int(11) NOT NULL,
  `turma` varchar(45) NOT NULL,
  `serie` varchar(10) NOT NULL,
  `ano_letivo` int(11) NOT NULL,
  `turno` varchar(10) NOT NULL,
  `ativo` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='		';

--
-- Extraindo dados da tabela `turmas`
--

INSERT INTO `turmas` (`idturmas`, `turma`, `serie`, `ano_letivo`, `turno`, `ativo`) VALUES
(1, 'Pré I A', 'PreI', 2022, 'Tarde', 1),
(2, 'Pré I B', 'PreI', 2022, 'Tarde', 1),
(4, 'Pré II A', 'PreII', 2022, 'Tarde', 1),
(9, '1º Ano A', '1º Ano', 2022, 'Manha', 1),
(10, '1º Ano B', '1º Ano', 2022, 'Manha', 1),
(11, '2º Ano A', '2º Ano', 2022, 'Tarde', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `idusuario` int(11) NOT NULL,
  `nome` varchar(80) NOT NULL,
  `matricula` int(11) DEFAULT NULL,
  `turma` int(11) DEFAULT NULL,
  `cpf` varchar(11) DEFAULT NULL,
  `telefone` varchar(11) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `login` varchar(45) DEFAULT NULL,
  `senha` varchar(45) DEFAULT NULL,
  `responsavel_ID` int(11) DEFAULT NULL,
  `isAluno` tinyint(4) DEFAULT NULL,
  `isProfessor` tinyint(4) DEFAULT NULL,
  `isFuncionario` tinyint(4) DEFAULT NULL,
  `isResponsavel` tinyint(4) DEFAULT NULL,
  `isActive` tinyint(4) DEFAULT NULL,
  `token` varchar(45) DEFAULT NULL,
  `endereco` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`idusuario`, `nome`, `matricula`, `turma`, `cpf`, `telefone`, `email`, `login`, `senha`, `responsavel_ID`, `isAluno`, `isProfessor`, `isFuncionario`, `isResponsavel`, `isActive`, `token`, `endereco`) VALUES
(10, 'Robinson Stürmer', 0, 0, '01321077084', '+5554981156', 'robin.rmds@gmail.com', 'robin', '1qazxsw2', 0, 0, 1, 0, 1, 1, NULL, 'Rua B'),
(11, 'Func2', 0, 0, '01321077084', '+5554981156', 'robin.rmds@gmail.com', 'func2', NULL, 0, 0, 0, 1, 1, 1, NULL, NULL),
(12, 'Aluno1', 1324, 2, NULL, NULL, NULL, NULL, NULL, 10, 1, 0, 0, 0, 1, NULL, 'rua A'),
(13, 'Prof01', 0, 0, '@cpf', '@telefone', '@email', '@login', NULL, 0, 1, 1, 1, 0, 1, NULL, 'rua update'),
(14, 'Aluno 02', 1359, 10, NULL, NULL, NULL, NULL, NULL, 11, 1, 0, 0, 0, 1, 'F13RUll%%2pR', 'rua aluno 2'),
(15, 'Professor 3', 0, 0, '01321077084', NULL, NULL, 'professor3', 'senha3', 0, 0, 1, 0, 0, 1, '3QbKhgcqK0BW', 'rua'),
(16, 'xsxxs', 22222, 1, '01370020085', NULL, 'email', 'login tesre', NULL, 11, 1, 1, 1, 1, 0, NULL, 'xsxsx');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `recados`
--
ALTER TABLE `recados`
  ADD PRIMARY KEY (`idrecados`);

--
-- Índices para tabela `turmas`
--
ALTER TABLE `turmas`
  ADD PRIMARY KEY (`idturmas`);

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`idusuario`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `recados`
--
ALTER TABLE `recados`
  MODIFY `idrecados` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `turmas`
--
ALTER TABLE `turmas`
  MODIFY `idturmas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `idusuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
