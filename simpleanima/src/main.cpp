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
    signal();
    delay(2000 / times);
    two();
    signal();
    delay(2000 / times);
    three();
    signal();
    delay(2000 / times);
    four();
    signal();
    delay(2000 / times);
    five();
    signal();
    delay(2000 / times);
    if(times < 25 && !zero)
      times++;
    else 
    {
      times--;
      zero = true;
      if(times == 0) {times++; zero = false;}
    }

}
