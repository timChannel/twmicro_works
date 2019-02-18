#include <Arduino.h>
#include <LedControl.h>
#include <main.h>

int times = 1;
bool zero = false;
void setup() {
  lc.shutdown(0,false);// Выключить энергосбережение, включить матрицу
  lc.setIntensity(0,8);// Устанавлить яркость (0 ~ 15 возможных значений)
  lc.clearDisplay(0);// Очистить матрицу
}

void loop() {
    one();
    //signal();
    analogWrite(8, 255);
    delay(2000 / times);
    digitalWrite(8, LOW);
    two();
    //signal();
    analogWrite(9, 255);
    delay(2000 / times);
    digitalWrite(9, LOW);
    three();
    //signal();
        analogWrite(10, 255);
      delay(2000 / times);
      digitalWrite(10, LOW);
      four();
      //signal();
    analogWrite(11, 255);
    delay(2000 / times);
    digitalWrite(11, LOW);
    five();
    //signal();
    analogWrite(12, 255);
    delay(2000 / times);
    digitalWrite(11, LOW);
    if(times < 25 && !zero)
      times++;
    else 
    {
      times--;
      zero = true;
      if(times == 0) {times++; zero = false;}
    }

}