#include <SoftwareSerial.h>
#include <Adafruit_Sensor.h>
#include <Wire.h>
#include <ESP32Servo.h>
#include "DHT.h"
#define MQ2Pin 39 //mq2 gaz sensörü pin tanımlaması yapıldı
#define DHTPIN 21
#define DHTTYPE DHT11
DHT dht(DHTPIN, DHTTYPE);
Servo servoMotor ;
int servoPin = 4;
unsigned long ISR1_Zaman=1000; //ms
unsigned long ISR1_evvelkiMillis=0;
const int in1 = 5;
const int in2 = 18;
const int e1 = 17;
String gelendeger;
String gelendeger2;
const int ldrPin = 27;  
float GAZDEGER;
int LDRDEGER=0;
float sicaklik=0;
float nem=0;
const int freq = 3000;
const int pwmChannel = 0;
const int resolution = 8;

void setup() {
  Serial.begin(9600);
  pinMode(15, OUTPUT);
  dht.begin();
  pinMode(in1,OUTPUT);
  pinMode(in2,OUTPUT);
  pinMode(e1,OUTPUT);
  pinMode(servoPin, OUTPUT);
  ledcSetup(pwmChannel, freq, resolution);
  ledcAttachPin(e1, pwmChannel);
  //delay(20000);
}

void loop() {  
  unsigned long currentMillis=millis();
  if(currentMillis-ISR1_evvelkiMillis>=ISR1_Zaman)
    {
    ISR1_evvelkiMillis=currentMillis;
    ISR_1();
    }
 if (Serial.available()) {
    char c = Serial.read();
    ///////Fan AyarlarÄ±/////////////////////////////
    if (c == 'y')
    {
      yavasDondur();
    }
    else if (c == 'o')
    {
      ortaDondur();
    }
    else if (c == 'h')
    {
      hizliDondur();
    }
    else if (c == 'd')
    {
      Durdur();
    }
    else if(c == 's')
    {
      servoDondur();
    }
    else if (c == 'r')
    {
      servoGeriDondur();
    }
    else if(c == 'a')
    {
      ledyak();
    }
    else if(c == 'b')
    {
      ledsondur();
    }

 }
}

void ISR_1()
{
LDRDEGER = analogRead(ldrPin);
GAZDEGER = analogRead(MQ2Pin); 
nem = dht.readHumidity();
sicaklik = dht.readTemperature();
int yenigaz = int(GAZDEGER);
int yeninem = int(nem);
int yenisicaklik = int(sicaklik);
Serial.print(LDRDEGER);
Serial.print("*");
Serial.print(yenigaz);
Serial.print("*");
Serial.print(yeninem);
Serial.print("*");
Serial.print(yenisicaklik);
Serial.println("*"); 
}

void servoDondur() 
{
  for (int i = 0; i <= 3; i++) 
  {
    digitalWrite (servoPin, HIGH);
    delayMicroseconds(2400);
    digitalWrite (servoPin, LOW);
    delay(20);
  }
}
void servoGeriDondur()
{
  for (int i = 0; i <= 3; i++)
  {
    digitalWrite (servoPin, HIGH);
    delayMicroseconds(544);
    digitalWrite (servoPin, LOW);
    delay(20);
  }
  
}

void yavasDondur()
{
  digitalWrite(in1, HIGH);
  digitalWrite(in2, LOW);
  ledcWrite(pwmChannel, 200);
}

void ortaDondur()
{
  digitalWrite(in1, HIGH);
  digitalWrite(in2, LOW);
  ledcWrite(pwmChannel, 225);
}
void hizliDondur() 
{
  digitalWrite(in1, HIGH);
  digitalWrite(in2, LOW);
  ledcWrite(pwmChannel, 255);
}
void Durdur() 
{
  digitalWrite(in1, LOW);
  digitalWrite(in2, LOW);
  ledcWrite(pwmChannel, 255);
}

void ledyak()
{
  digitalWrite(15,HIGH);
}

void ledsondur(){
  digitalWrite(15,LOW);
}
