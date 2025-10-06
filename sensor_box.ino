/*
ESP8266 Sensor Box - SmartSafetyStore (demo)
Sends JSON to API when sensor triggers (removed/returned)
Configure WIFI_SSID, WIFI_PASS, API_HOST.
*/
#include <ESP8266WiFi.h>
#include <ESP8266HTTPClient.h>
#include <ArduinoJson.h>

const char* WIFI_SSID = "YOUR_SSID";
const char* WIFI_PASS = "YOUR_PASS";
const char* API_HOST = "http://your-api.example.com";

const int SENSOR_PIN = D3;
const char* SENSOR_UUID = "BOX_SENSOR_1";
const int PRODUCT_ID = 1;
int lastState = HIGH;

void setup() {
  Serial.begin(115200);
  pinMode(SENSOR_PIN, INPUT_PULLUP);
  WiFi.begin(WIFI_SSID, WIFI_PASS);
  while (WiFi.status() != WL_CONNECTED) { delay(500); Serial.print("."); }
  Serial.println("\nWiFi connected");
}

void loop() {
  int state = digitalRead(SENSOR_PIN);
  if (state == LOW && lastState == HIGH) {
    sendEvent("removed");
  } else if (state == HIGH && lastState == LOW) {
    sendEvent("returned");
  }
  lastState = state;
  delay(300);
}

void sendEvent(const char* ev) {
  if (WiFi.status() != WL_CONNECTED) return;
  HTTPClient http;
  String url = String(API_HOST) + "/api/alerts/sensor";
  http.begin(url);
  http.addHeader("Content-Type", "application/json");
  StaticJsonDocument<200> doc;
  doc["sensorUuid"] = SENSOR_UUID;
  doc["productId"] = PRODUCT_ID;
  doc["event"] = ev;
  String body; serializeJson(doc, body);
  int code = http.POST(body);
  if (code > 0) { Serial.println("Sent: " + String(code)); Serial.println(http.getString()); }
  else Serial.println("POST failed");
  http.end();
}
