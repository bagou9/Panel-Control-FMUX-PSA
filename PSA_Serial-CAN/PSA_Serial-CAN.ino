#include <SPI.h>
#include "mcp_can.h"

///////////////////
// Configuration //
///////////////////

// CS pin for CAN bus shield.
// The default pin depends on the shield's version:
//  - 1.0: digital pin 10
//  - 1.1 and newer: digital pin 9
const int CS_PIN = 10;

// Serial port data rate
const long SERIAL_SPEED = 115200;

// CAN bus data rate
const byte CAN_SPEED = CAN_125KBPS;

///////////////////

MCP_CAN CAN(CS_PIN);
unsigned char len = 0;
byte buffer[8];
long temps = 0;
int vol=0;

void setup() {
    Serial.begin(SERIAL_SPEED);
    byte canSpeed = CAN_SPEED;

    while (CAN.begin(canSpeed, MCP_8MHz) != CAN_OK) {
      delay(100);
    }
}

void loop() {

  char tabRecu[23];
  byte msgSend[8] = {0,0,0,0,0,0,0,0};
  int i=0;
  int j=0;
  byte rc = 0;
  while (Serial.available() > 0)
  {
    rc = Serial.read();
    tabRecu[i] = rc;
    if (rc == '\n')
    {
      tabRecu[i] = '\0';
    }
    i++;
    delay(5);
  }  
        
  if (i > 0)
  {
    if (tabRecu[0] == 'v'){
      if (tabRecu[1] == '-') vol--;
      if (tabRecu[1] == '+') vol++;

      if (vol < 0) vol = 0xFF;
      if (vol > 255) vol = 0;
      Serial.println(vol);
    }
    else
    {    
      char * ids = strtok(tabRecu, "|");
      int ID = strtoul(ids, NULL, 16);
      
      ids = strtok(NULL, ":");
      while (ids != NULL) {
        msgSend[j] = strtoul(ids, NULL, 16);
        Serial.println(msgSend[j],HEX);
        j++;
        ids = strtok(NULL, ":");
      }

      if (ID == 0x122){
        msgSend[4] = 0;
        msgSend[5] = 0x02;
        msgSend[6] = vol;
        msgSend[7] = 0;
        j=8;
      }
      CAN.sendMsgBuf(ID, 0, j, msgSend);
      //Serial.println(val,HEX);
    }
    i=0;
  }

  if ((millis() - temps) > 100)
  {
    temps = millis();
    msgSend[0] = 0;
    msgSend[1] = 0;
    msgSend[2] = 0;
    msgSend[3] = 0;
    msgSend[4] = 0;
    msgSend[5] = 0x02;
    msgSend[6] = vol;
    msgSend[7] = 0;
    CAN.sendMsgBuf(0x122, 0, 8, msgSend);
  }

  if (1==0)
  {
    if (CAN.checkReceive() == CAN_MSGAVAIL) {
        CAN.readMsgBuf(&len, buffer);

        int id = CAN.getCanId();
        if (id == 0x122)
        {
          Serial.print("FRAME:ID=");
          Serial.print(CAN.getCanId(),HEX);
          Serial.print(":LEN=");
          Serial.print(len);
          Serial.print(":DATA=");
          
          char tmp[3];
          for(int i = 0; i<len; i++) {
              Serial.print(":");
              
              snprintf(tmp, 3, "%02X", buffer[i]);
              
              Serial.print(tmp);
          }
  
          Serial.println();
        }
    }
  }
}
