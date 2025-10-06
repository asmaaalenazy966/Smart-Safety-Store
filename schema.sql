-- SmartSafetyStore MySQL schema (simplified)
CREATE DATABASE IF NOT EXISTS smart_safety_store;
USE smart_safety_store;

CREATE TABLE users (
  id INT AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(100),
  email VARCHAR(150) UNIQUE,
  password_hash VARCHAR(255),
  created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE products (
  id INT AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(200),
  sku VARCHAR(50),
  price DECIMAL(10,2),
  stock INT DEFAULT 0
);

CREATE TABLE sensors (
  id INT AUTO_INCREMENT PRIMARY KEY,
  uuid VARCHAR(120) UNIQUE,
  product_id INT,
  location VARCHAR(200),
  FOREIGN KEY (product_id) REFERENCES products(id)
);

CREATE TABLE alerts (
  id INT AUTO_INCREMENT PRIMARY KEY,
  sensor_id INT,
  event_type VARCHAR(50),
  details TEXT,
  created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  FOREIGN KEY (sensor_id) REFERENCES sensors(id)
);

INSERT INTO products (name, sku, price, stock) VALUES
('Small Box A','BOXA001',10.00,50),
('Small Box B','BOXB001',8.00,60);
