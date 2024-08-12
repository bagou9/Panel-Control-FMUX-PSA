# Panel-Control-FMUX-PSA

Sketch Arduino :
envoi de trame CAN via Serial.
format en hexa: CanID|data

la partie data peut varier en taille de données.
exemples:
0x122|0x00 -> seulement 1 octet envoyé
0x122|0x00:0x02 -> 2 octets envoyés
0x122|0x00:0x00:0x00:0x00:0x00:0x02:0x0A:0x00 -> 8 octets envoyés


programme C#:
Reproduit le panneau de controle pour RD5/RD45 sur vehicules 308 II / 508 ph1 / C4 II / DS4 ph1.
