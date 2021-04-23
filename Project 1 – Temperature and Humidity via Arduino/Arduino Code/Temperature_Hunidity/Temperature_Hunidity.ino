

#include <DHT.h>

#define DHTPIN1 4


DHT dht[] = {
  {DHTPIN1, DHT11}
};

float humidity[1];
float temperature[1];

void setup()
{
  Serial.begin(9600);
  for (auto& sensor : dht) {
    sensor.begin();
  }
}

void loop()
{
  for (int i = 0; i < 1; i++) {
    temperature[i] = dht[i].readTemperature();
    humidity[i] = dht[i].readHumidity();
  }

  for (int i = 0; i < 1; i++) {
    Serial.print("Temperature ");    
    Serial.print(temperature[i]);
    Serial.print("°C");
    Serial.print("  :  Humidity ");    
    Serial.print(humidity[i]);
    Serial.println("%");
  }
  delay(2000);
}
