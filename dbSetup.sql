CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

CREATE TABLE
    houses(
        id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
        bedrooms DECIMAL UNSIGNED DEFAULT 0,
        bathrooms SMALLINT UNSIGNED DEFAULT 0,
        price INT UNSIGNED DEFAULT 0,
        isHaunted BOOLEAN DEFAULT false,
        description VARCHAR(255) NOT NULL,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update'
    ) default charset utf8 COMMENT '';

    INSERT INTO
    houses (
        bedrooms,
        bathrooms,
        price,
        isHaunted,
        description
    )
VALUES (
        2.5,
        4,
        400000,
        true,
        'A Modern House with pool!'
    );
