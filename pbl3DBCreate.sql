-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema pbl3
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema pbl3
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `pbl3` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `pbl3` ;

-- -----------------------------------------------------
-- Table `pbl3`.`roles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pbl3`.`roles` (
  `role_id` INT NOT NULL,
  `role_name` VARCHAR(10) NULL DEFAULT NULL,
  PRIMARY KEY (`role_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `pbl3`.`accounts`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pbl3`.`accounts` (
  `account_id` INT NOT NULL,
  `role_id` INT NOT NULL,
  `username` VARCHAR(50) NOT NULL,
  `email` VARCHAR(50) NOT NULL,
  `password` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`account_id`),
  INDEX `role_id` (`role_id` ASC) VISIBLE,
  CONSTRAINT `accounts_ibfk_1`
    FOREIGN KEY (`role_id`)
    REFERENCES `pbl3`.`roles` (`role_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `pbl3`.`account_reports`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pbl3`.`account_reports` (
  `report_id` INT NOT NULL,
  `create_account_id` INT NOT NULL,
  `reported_account_id` INT NOT NULL,
  `content` TEXT NOT NULL,
  PRIMARY KEY (`report_id`),
  INDEX `create_account_id` (`create_account_id` ASC) VISIBLE,
  INDEX `reported_account_id` (`reported_account_id` ASC) VISIBLE,
  CONSTRAINT `account_reports_ibfk_1`
    FOREIGN KEY (`create_account_id`)
    REFERENCES `pbl3`.`accounts` (`account_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `account_reports_ibfk_2`
    FOREIGN KEY (`reported_account_id`)
    REFERENCES `pbl3`.`accounts` (`account_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `pbl3`.`authors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pbl3`.`authors` (
  `author_id` INT NOT NULL,
  `author_name` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`author_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `pbl3`.`books`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pbl3`.`books` (
  `book_id` INT NOT NULL,
  `book_name` VARCHAR(255) CHARACTER SET 'utf8mb3' NOT NULL,
  `book_description` VARCHAR(255) CHARACTER SET 'utf8mb3' NULL DEFAULT NULL,
  `rating` INT NULL DEFAULT 0,
  `views` INT NULL DEFAULT 0,
  `likes` INT NULL DEFAULT 0,
  `upload_account` INT NULL DEFAULT NULL,
  `author_id` INT NULL DEFAULT NULL,
  PRIMARY KEY (`book_id`),
  INDEX `upload_account` (`upload_account` ASC) VISIBLE,
  INDEX `author_id` (`author_id` ASC) VISIBLE,
  CONSTRAINT `books_ibfk_1`
    FOREIGN KEY (`upload_account`)
    REFERENCES `pbl3`.`accounts` (`account_id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE,
  CONSTRAINT `books_ibfk_2`
    FOREIGN KEY (`author_id`)
    REFERENCES `pbl3`.`authors` (`author_id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `pbl3`.`genres`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pbl3`.`genres` (
  `genre_id` INT NOT NULL,
  `genre_name` VARCHAR(50) CHARACTER SET 'utf8mb3' NOT NULL,
  PRIMARY KEY (`genre_id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `pbl3`.`book_genre`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pbl3`.`book_genre` (
  `unique_id` INT NOT NULL,
  `book_id` INT NOT NULL,
  `genre_id` INT NOT NULL,
  PRIMARY KEY (`unique_id`),
  INDEX `book_id` (`book_id` ASC) VISIBLE,
  INDEX `genre_id` (`genre_id` ASC) VISIBLE,
  CONSTRAINT `book_genre_ibfk_1`
    FOREIGN KEY (`book_id`)
    REFERENCES `pbl3`.`books` (`book_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `book_genre_ibfk_2`
    FOREIGN KEY (`genre_id`)
    REFERENCES `pbl3`.`genres` (`genre_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `pbl3`.`book_reports`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pbl3`.`book_reports` (
  `report_id` INT NOT NULL,
  `create_account_id` INT NOT NULL,
  `reported_book_id` INT NOT NULL,
  `content` TEXT NOT NULL,
  PRIMARY KEY (`report_id`),
  INDEX `create_account_id` (`create_account_id` ASC) VISIBLE,
  INDEX `reported_book_id` (`reported_book_id` ASC) VISIBLE,
  CONSTRAINT `book_reports_ibfk_1`
    FOREIGN KEY (`create_account_id`)
    REFERENCES `pbl3`.`accounts` (`account_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `book_reports_ibfk_2`
    FOREIGN KEY (`reported_book_id`)
    REFERENCES `pbl3`.`books` (`book_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `pbl3`.`chapters`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pbl3`.`chapters` (
  `chapter_id` INT NOT NULL,
  `book_id` INT NOT NULL,
  `content` TEXT NOT NULL,
  `views` INT NULL DEFAULT 0,
  `likes` INT NULL DEFAULT 0,
  PRIMARY KEY (`chapter_id`),
  INDEX `book_id` (`book_id` ASC) VISIBLE,
  CONSTRAINT `chapters_ibfk_1`
    FOREIGN KEY (`book_id`)
    REFERENCES `pbl3`.`books` (`book_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `pbl3`.`followed_book`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pbl3`.`followed_book` (
  `unique_id` INT NOT NULL,
  `account_id` INT NOT NULL,
  `followed_book_id` INT NOT NULL,
  PRIMARY KEY (`unique_id`),
  INDEX `account_id` (`account_id` ASC) VISIBLE,
  INDEX `followed_book_id` (`followed_book_id` ASC) VISIBLE,
  CONSTRAINT `followed_book_ibfk_1`
    FOREIGN KEY (`account_id`)
    REFERENCES `pbl3`.`accounts` (`account_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `followed_book_ibfk_2`
    FOREIGN KEY (`followed_book_id`)
    REFERENCES `pbl3`.`books` (`book_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `pbl3`.`history`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pbl3`.`history` (
  `unique_id` INT NOT NULL,
  `account_id` INT NOT NULL,
  `book_id` INT NOT NULL,
  `read_chapter_ids` TEXT NOT NULL,
  PRIMARY KEY (`unique_id`),
  INDEX `account_id` (`account_id` ASC) VISIBLE,
  INDEX `book_id` (`book_id` ASC) VISIBLE,
  CONSTRAINT `history_ibfk_1`
    FOREIGN KEY (`account_id`)
    REFERENCES `pbl3`.`accounts` (`account_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `history_ibfk_2`
    FOREIGN KEY (`book_id`)
    REFERENCES `pbl3`.`books` (`book_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `pbl3`.`notifications`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pbl3`.`notifications` (
  `notification_id` INT NOT NULL,
  `create_account_id` INT NOT NULL,
  `receiver_account_id` INT NULL DEFAULT NULL,
  `receiver_role_id` INT NULL DEFAULT NULL,
  `content` TEXT NOT NULL,
  PRIMARY KEY (`notification_id`),
  INDEX `receiver_account_id` (`receiver_account_id` ASC) VISIBLE,
  INDEX `receiver_role_id` (`receiver_role_id` ASC) VISIBLE,
  INDEX `create_account_id` (`create_account_id` ASC) VISIBLE,
  CONSTRAINT `notifications_ibfk_1`
    FOREIGN KEY (`receiver_account_id`)
    REFERENCES `pbl3`.`accounts` (`account_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `notifications_ibfk_2`
    FOREIGN KEY (`receiver_role_id`)
    REFERENCES `pbl3`.`roles` (`role_id`),
  CONSTRAINT `notifications_ibfk_5`
    FOREIGN KEY (`create_account_id`)
    REFERENCES `pbl3`.`accounts` (`account_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `pbl3`.`user_info`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pbl3`.`user_info` (
  `account_id` INT NOT NULL,
  `avatar` BLOB NULL DEFAULT NULL,
  `name` VARCHAR(50) CHARACTER SET 'utf8mb3' NULL DEFAULT NULL,
  `sex` ENUM('male', 'female', 'other') NULL DEFAULT NULL,
  `dob` DATETIME NULL DEFAULT NULL,
  PRIMARY KEY (`account_id`),
  CONSTRAINT `user_info_ibfk_1`
    FOREIGN KEY (`account_id`)
    REFERENCES `pbl3`.`accounts` (`account_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
