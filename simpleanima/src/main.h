#include <Arduino.h>
#include <LedControl.h>

LedControl lc=LedControl(5,6,7,1);

void one()
{
        lc.clearDisplay(0);
    lc.setLed(0,1,4,true);
    lc.setLed(0,2,3,true);
    lc.setLed(0,2,4,true);
    lc.setLed(0,3,2,true);
    lc.setLed(0,3,4,true);
    lc.setLed(0,4,4,true);
    lc.setLed(0,5,4,true);
    lc.setLed(0,6,4,true);
}
void two()
{
        lc.clearDisplay(0);   
    lc.setLed(0,1,2,true);
    lc.setLed(0,1,3,true);
    lc.setLed(0,1,4,true);
    lc.setLed(0,1,5,true);
    lc.setLed(0,2,5,true);
    lc.setLed(0,3,2,true);
    lc.setLed(0,3,3,true);
    lc.setLed(0,3,4,true);
    lc.setLed(0,3,5,true);
    lc.setLed(0,4,2,true);
    lc.setLed(0,5,2,true);
    lc.setLed(0,5,3,true);
    lc.setLed(0,5,4,true);
    lc.setLed(0,5,5,true);
}
void three()
{    lc.clearDisplay(0);
    lc.setLed(0,1,2,true);
    lc.setLed(0,1,3,true);
    lc.setLed(0,1,4,true);
    lc.setLed(0,1,5,true);
    lc.setLed(0,2,5,true);
    lc.setLed(0,3,2,true);
    lc.setLed(0,3,3,true);
    lc.setLed(0,3,4,true);
    lc.setLed(0,3,5,true);
    lc.setLed(0,4,5,true);
    lc.setLed(0,5,2,true);
    lc.setLed(0,5,3,true);
    lc.setLed(0,5,4,true);
    lc.setLed(0,5,5,true);
}
void four()
{    lc.clearDisplay(0);
    lc.setLed(0,1,2,true);
    lc.setLed(0,1,4,true);
    lc.setLed(0,2,2,true);
    lc.setLed(0,2,4,true);
    lc.setLed(0,3,2,true);
    lc.setLed(0,3,3,true);
    lc.setLed(0,3,4,true);
    lc.setLed(0,4,4,true);
    lc.setLed(0,5,4,true);
}
void five()
{    lc.clearDisplay(0);
    lc.setLed(0,1,2,true);
    lc.setLed(0,1,3,true);
    lc.setLed(0,1,4,true);
    lc.setLed(0,1,5,true);
    lc.setLed(0,2,2,true);
    lc.setLed(0,3,2,true);
    lc.setLed(0,3,3,true);
    lc.setLed(0,3,4,true);
    lc.setLed(0,3,5,true);
    lc.setLed(0,4,5,true);
    lc.setLed(0,5,2,true);
    lc.setLed(0,5,3,true);
    lc.setLed(0,5,4,true);
    lc.setLed(0,5,5,true);
}
void signal()
{
    long long current = millis();
    tone(4, 440, 100);
    do{}
    while(millis() - current != 100);
    noTone(4);
}