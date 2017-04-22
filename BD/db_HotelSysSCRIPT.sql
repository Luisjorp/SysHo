-- MySQL Script generated by MySQL Workbench
-- Sat Apr 15 11:08:41 2017
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema db_HotelSys
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema db_HotelSys
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `db_HotelSys` DEFAULT CHARACTER SET utf8 ;
USE `db_HotelSys` ;

-- -----------------------------------------------------
-- Table `db_HotelSys`.`persona`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_HotelSys`.`persona` ;

CREATE TABLE IF NOT EXISTS `db_HotelSys`.`persona` (
  `idPersona` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `apellido` VARCHAR(75) NOT NULL,
  `tipoDocumento` VARCHAR(20) NOT NULL,
  `noDocumento` VARCHAR(25) NOT NULL,
  `direccion` VARCHAR(60) NULL,
  `telefono` VARCHAR(10) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idPersona`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_HotelSys`.`cliente`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_HotelSys`.`cliente` ;

CREATE TABLE IF NOT EXISTS `db_HotelSys`.`cliente` (
  `idPersona` INT NOT NULL,
  `codigoCliente` VARCHAR(15) NOT NULL,
  INDEX `fk_cliente_persona_idx` (`idPersona` ASC),
  PRIMARY KEY (`idPersona`),
  CONSTRAINT `fk_cliente_persona`
    FOREIGN KEY (`idPersona`)
    REFERENCES `db_HotelSys`.`persona` (`idPersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_HotelSys`.`trabajador`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_HotelSys`.`trabajador` ;

CREATE TABLE IF NOT EXISTS `db_HotelSys`.`trabajador` (
  `idPersona` INT NOT NULL,
  `sueldo` DECIMAL(7,2) NOT NULL,
  `acceso` VARCHAR(45) NOT NULL,
  `login` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `estado` VARCHAR(1) NOT NULL,
  INDEX `fk_trabajador_persona1_idx` (`idPersona` ASC),
  PRIMARY KEY (`idPersona`),
  CONSTRAINT `fk_trabajador_persona1`
    FOREIGN KEY (`idPersona`)
    REFERENCES `db_HotelSys`.`persona` (`idPersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_HotelSys`.`habitacion`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_HotelSys`.`habitacion` ;

CREATE TABLE IF NOT EXISTS `db_HotelSys`.`habitacion` (
  `idHabitacion` INT NOT NULL AUTO_INCREMENT,
  `numero` VARCHAR(4) NOT NULL,
  `piso` VARCHAR(2) NOT NULL,
  `descripcion` VARCHAR(512) NULL,
  `caracteristicas` VARCHAR(512) NULL,
  `precioDiario` DECIMAL(7,2) NOT NULL,
  `estado` VARCHAR(15) NOT NULL,
  `tipoHabitacion` VARCHAR(25) NOT NULL,
  PRIMARY KEY (`idHabitacion`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_HotelSys`.`reserva`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_HotelSys`.`reserva` ;

CREATE TABLE IF NOT EXISTS `db_HotelSys`.`reserva` (
  `idReserva` INT NOT NULL AUTO_INCREMENT,
  `idHabitacion` INT NOT NULL,
  `idCliente` INT NOT NULL,
  `idTrabajador` INT NOT NULL,
  `tipoReserva` VARCHAR(45) NOT NULL,
  `fechaReserva` DATE NOT NULL,
  `fechaIngreso` DATE NOT NULL,
  `fechaSalida` DATE NOT NULL,
  `costoAlojamiento` DECIMAL(7,2) NOT NULL,
  `observacion` VARCHAR(512) NULL,
  `estado` VARCHAR(20) NULL,
  PRIMARY KEY (`idReserva`),
  INDEX `fk_reserva_habitacion1_idx` (`idHabitacion` ASC),
  INDEX `fk_reserva_cliente1_idx` (`idCliente` ASC),
  INDEX `fk_reserva_trabajador1_idx` (`idTrabajador` ASC),
  CONSTRAINT `fk_reserva_habitacion1`
    FOREIGN KEY (`idHabitacion`)
    REFERENCES `db_HotelSys`.`habitacion` (`idHabitacion`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_reserva_cliente1`
    FOREIGN KEY (`idCliente`)
    REFERENCES `db_HotelSys`.`cliente` (`idPersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_reserva_trabajador1`
    FOREIGN KEY (`idTrabajador`)
    REFERENCES `db_HotelSys`.`trabajador` (`idPersona`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_HotelSys`.`pago`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_HotelSys`.`pago` ;

CREATE TABLE IF NOT EXISTS `db_HotelSys`.`pago` (
  `idPago` INT NOT NULL AUTO_INCREMENT,
  `idReserva` INT NOT NULL,
  `tipoComprobante` VARCHAR(45) NOT NULL,
  `noComprobante` VARCHAR(15) NOT NULL,
  `iva` DECIMAL(7,2) NOT NULL,
  `totalPago` DECIMAL(9,2) NOT NULL,
  `fechaEmision` DATE NOT NULL,
  `fechaPago` DATE NOT NULL,
  `estado` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`idPago`),
  INDEX `fk_pago_reserva1_idx` (`idReserva` ASC),
  CONSTRAINT `fk_pago_reserva1`
    FOREIGN KEY (`idReserva`)
    REFERENCES `db_HotelSys`.`reserva` (`idReserva`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_HotelSys`.`producto`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_HotelSys`.`producto` ;

CREATE TABLE IF NOT EXISTS `db_HotelSys`.`producto` (
  `idProducto` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(50) NOT NULL,
  `descripcion` VARCHAR(255) NULL,
  `unidadMedida` VARCHAR(25) NOT NULL,
  `precioVenta` DECIMAL(7,2) NOT NULL,
  PRIMARY KEY (`idProducto`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_HotelSys`.`consumo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `db_HotelSys`.`consumo` ;

CREATE TABLE IF NOT EXISTS `db_HotelSys`.`consumo` (
  `idconsumo` INT NOT NULL AUTO_INCREMENT,
  `idReserva` INT NOT NULL,
  `idProducto` INT NOT NULL,
  `cantidad` DECIMAL(7,2) NOT NULL,
  `precioVenta` DECIMAL(7,2) NOT NULL,
  `estado` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idconsumo`),
  INDEX `fk_consumo_reserva1_idx` (`idReserva` ASC),
  INDEX `fk_consumo_producto1_idx` (`idProducto` ASC),
  CONSTRAINT `fk_consumo_reserva1`
    FOREIGN KEY (`idReserva`)
    REFERENCES `db_HotelSys`.`reserva` (`idReserva`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_consumo_producto1`
    FOREIGN KEY (`idProducto`)
    REFERENCES `db_HotelSys`.`producto` (`idProducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;