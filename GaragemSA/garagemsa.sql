-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           5.5.11 - MySQL Community Server (GPL)
-- OS do Servidor:               Win32
-- HeidiSQL Versão:              11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para garagem
CREATE DATABASE IF NOT EXISTS `garagem` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `garagem`;

-- Copiando estrutura para tabela garagem.garagem
CREATE TABLE IF NOT EXISTS `garagem` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `nome_veiculo` varchar(50) DEFAULT NULL,
  `placa_veiculo` varchar(8) DEFAULT NULL,
  `proprietario_veiculo` varchar(50) DEFAULT NULL,
  `situacao_veiculo` varchar(50) DEFAULT NULL,
  `hora_entrada` varchar(50) DEFAULT NULL,
  `hora_saida` varchar(50) DEFAULT '--',
  `Chave` varchar(3) DEFAULT 'NÃO',
  `Pago` int(1) NOT NULL DEFAULT '0',
  `Excluido` int(1) NOT NULL DEFAULT '0',
  `Valor` varchar(50) DEFAULT NULL,
  `Data` date DEFAULT '1901-01-01',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=72 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela garagem.garagem: ~41 rows (aproximadamente)
/*!40000 ALTER TABLE `garagem` DISABLE KEYS */;
INSERT INTO `garagem` (`ID`, `nome_veiculo`, `placa_veiculo`, `proprietario_veiculo`, `situacao_veiculo`, `hora_entrada`, `hora_saida`, `Chave`, `Pago`, `Excluido`, `Valor`, `Data`) VALUES
	(26, 'CARRO ', 'ABC1234 ', 'TESTANDO ', 'SOMENTE UM TESTE 123', '09:41', '20:59', 'NÃO', 1, 0, '40', '2020-09-16'),
	(27, 'CARRO ', 'ABC1223 ', 'TESTE ', 'TESTANDO SISTEMA ATUALIZANDO', '10:16', '21:30', 'NÃO', 1, 0, '40', '2020-09-16'),
	(28, 'CARRO ', 'ASD1234 ', ' TESTE', 'TESTANDO ATUALIZACAO', '10:14', '--', 'NÃO', 0, 1, '0', '2020-09-16'),
	(29, 'CARRO ', 'ABC ', '1234 ', 'TESTE', '10:10', '--', 'NÃO', 0, 1, '0', '2020-09-16'),
	(30, 'MOTO ', 'CSA1234', 'TESTANDO ', 'TESTANDO', '10:10', '--', 'NÃO', 0, 1, '0', '2020-09-17'),
	(31, 'CARRO ', 'ASC1234 ', 'TESTERSS ', 'CAMPO DE TESTE', '10:24', '16:09', 'NÃO', 1, 0, '30', '2020-09-17'),
	(32, 'Moto', 'ASD1234 ', 'TESTE ', 'TESTANDO COM 5MIN A MENOS', '10:22', '16:10', 'NÃO', 1, 0, '24', '2020-09-17'),
	(33, 'MOTO ', 'QQQ1111 ', 'BETINHO ', 'TESTE', '16:54', '--', 'NÃO', 0, 1, '0', '2020-09-17'),
	(34, 'CARRO ', 'ACV1213 ', 'ASDASDA ', 'ASDASD', '16:55', '--', 'NÃO', 0, 1, '0', '2020-09-17'),
	(35, 'CARRO ', 'ABC1234 ', 'TESTE ', 'TESTANDO', '19:53', '--', 'NÃO', 0, 1, '0', '2020-09-17'),
	(36, 'CARRO', 'ABC1234', 'CELIO', 'CARRO TA TOP', '20:21', '--', 'NÃO', 0, 1, '0', '2020-09-17'),
	(37, 'CARRO', 'ASD1234', 'CELIO', 'CARRO TA OK', '10:43', '--', 'NÃO', 0, 0, '0', '2020-09-17'),
	(38, 'Moto', 'ASD1234', 'NATHAN', 'FAROL QUEIMADO', '17:49', '--', 'NÃO', 0, 0, NULL, '2020-09-17'),
	(39, 'CARRO', 'CCC1111', 'BETO', 'PARACHOQUE QUEBRADO', '17:51', '--', 'NÃO', 0, 0, NULL, '2020-09-17'),
	(40, 'CARRO', 'CCC1111', 'BETO', 'PARACHOQUE QUEBRADO TESTE', '17:51', '--', 'NÃO', 0, 0, NULL, '2020-09-17'),
	(41, 'MOTO', 'ASD1234', 'NATHAN', 'FAROL QUEIMADO', '19:30', '--', 'NÃO', 0, 1, NULL, '2020-09-18'),
	(42, 'CARRO', 'ASD1234', 'TESTE', 'TESTE', '21:31', '--', 'NÃO', 0, 1, NULL, '2020-09-18'),
	(43, 'CARRO', 'ABC1234', 'TESTE', 'TESTE', '14:20', '16:40', 'NÃO', 1, 0, '15', '2020-09-18'),
	(44, 'MOTO', 'ABC1234', '123', '1234', '14:23', '--', 'NÃO', 0, 1, NULL, '2020-09-19'),
	(45, 'CARRO', 'AAA1111', 'TESTE', 'TESTE DE ATUALIZAÇÃO', '12:07', '--', 'NÃO', 0, 1, NULL, '2020-09-19'),
	(46, 'CARRO', 'BBB2222', 'TESTE', 'TESTE', '13:07', '--', 'NÃO', 0, 1, NULL, '2020-09-19'),
	(47, 'CARRO', 'ZZZ1111', 'QQQQ', 'TESTANDO ATUALIZAÇÃO', '12:08', '14:01', 'NÃO', 1, 0, '10', '2020-09-19'),
	(48, 'CARRO', 'VVV1111', '111111', '11213', '12:08', '--', 'NÃO', 0, 1, NULL, '2020-09-19'),
	(49, 'CARRO', 'CCC1234', '1234', '4321123', '11:08', '--', 'NÃO', 0, 1, NULL, '2020-09-19'),
	(50, 'MOTO', '1111', '111', '1111', '11:29', '14:02', 'NÃO', 1, 0, '12', '2020-09-19'),
	(51, 'CARRO', 'ASD', '123', 'ASDA', '11:49', '--', 'NÃO', 0, 1, NULL, '2020-09-19'),
	(52, 'CARRO', 'TES1234', 'TESTE', 'TESTE', '10:09', '--', 'NÃO', 0, 0, NULL, '2020-09-19'),
	(53, 'MOTO', 'ABC1234', 'TESTE', '123123123', '08:18', '--', 'NÃO', 0, 1, NULL, '2020-09-19'),
	(54, 'MOTO', 'AAA1111', 'TTTT', '222222222', '07:18', '--', 'NÃO', 0, 0, NULL, '2020-09-19'),
	(55, 'MOTO', 'VVV1234', 'HOMI', 'TESTE', '08:20', '--', 'NÃO', 0, 0, NULL, '2020-09-19'),
	(56, 'CARRO', 'TTT1111', 'POLO', 'PALO', '09:20', '--', 'NÃO', 0, 0, NULL, '2020-09-19'),
	(57, 'CARRO', 'BBB1234', 'CARLOS', 'NORMAL', '10:43', '--', 'NÃO', 0, 0, NULL, '2020-09-19'),
	(58, 'CARRO', 'VVV1231', 'VITOR', 'NORMAL', '08:46', '--', 'NÃO', 0, 0, NULL, '2020-09-19'),
	(59, 'MOTO', 'AVC4344', 'CELIO', 'TESTE', '08:47', '--', 'NÃO', 0, 0, NULL, '2020-09-19'),
	(60, 'CARRO', 'ABS1234', 'CELIO', 'TESTE', '13:47', '--', 'NÃO', 0, 0, NULL, '2020-09-19'),
	(61, 'CARRO', 'ASD1234', 'CELIO', 'TESTE', '13:59', '--', 'NÃO', 0, 0, NULL, '2020-09-19'),
	(62, 'CARRO', 'ABC1111', 'CELIO', 'TESTE', '14:00', '--', 'NÃO', 0, 0, NULL, '2020-09-19'),
	(63, 'CARRO', 'AVC1111', 'TESTE', 'TESTE', '14:00', '--', 'NÃO', 0, 0, NULL, '2020-09-19'),
	(64, 'CARRO', 'ASD1234', 'CELIO', 'TESTE', '14:01', '--', 'NÃO', 0, 0, NULL, '2020-09-19'),
	(65, 'CARRO', 'ACS1234', 'TESTANDO', 'TESTANDO', '14:01', '--', 'NÃO', 0, 0, NULL, '2020-09-19'),
	(66, 'CARRO', 'AAA3333', 'ASD', 'ASD', '14:01', '--', 'NÃO', 0, 0, NULL, '2020-09-19'),
	(67, 'CARRO', 'ASD', 'ASD', 'ASD', '17:20', '--', 'NÃO', 0, 0, NULL, '2020-09-19'),
	(68, 'CARRO', 'ASD', 'ASD', 'ASD', '17:20', '--', 'SIM', 0, 0, NULL, '2020-09-19'),
	(69, 'CARRO', 'ASD', 'ASD', 'ASD', '17:21', '--', 'SIM', 0, 0, NULL, '2020-09-19'),
	(70, 'CARRO', 'ASD', 'ASD', 'ASD ', '17:21', '--', 'SIM', 0, 0, NULL, '2020-09-19'),
	(71, 'CARRO', 'ASD', 'ASD', 'ASD', '17:21', '--', 'SIM', 0, 0, NULL, '2020-09-19');
/*!40000 ALTER TABLE `garagem` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
