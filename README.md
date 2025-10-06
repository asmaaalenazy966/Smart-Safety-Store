# Smart Safety Store 🛒🔒

A display-ready, semi-complete graduation project prepared for GitHub.
This version is *theoretical/demo* (code snippets and demo endpoints) intended to showcase the idea and your skills.

## Overview
Smart Safety Store improves the smart shopping concept by adding physical security:
- Each product box is monitored by a sensor (Arduino/ESP).
- When an item is removed without proper scan, the sensor sends an alert to the server.
- The server logs alerts and the mobile app displays notifications for store staff and users.

## Included
- API_Server: Minimal ASP.NET demo (Program.cs)
- MobileApp: Xamarin.Forms page snippets (Login, Alerts)
- Website: Simple admin HTML (reads products)
- Database: MySQL schema and sample data
- Arduino: ESP8266 sketch for sensor box
- Screenshots: placeholders (replace with real images)

## How to use
1. Import `Database/schema.sql` into MySQL.
2. Run the API (`API_Server/Program.cs`) using .NET 6+.
3. Use the Xamarin snippets in Visual Studio to create the mobile app.
4. Flash `Arduino/sensor_box.ino` to an ESP8266 and set WiFi & API host.
5. Replace screenshot placeholders with real images in `Screenshots/`.

## Why this project?
- Builds on your existing Smart Shopping work.
- Adds IoT security and practical features attractive to employers.
- Demonstrates skills: C#, .NET, Xamarin, MySQL, Arduino.

## Author
Asmaa Abdulrahman Al-Enazi
Yanbu Industrial City, Saudi Arabia
asmaazi966@gmail.com
