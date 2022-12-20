# Projekt-Dokumentation



Filip Mitrovic, Julian Warnebold, Julian Hitz, Justus Meister, Lennard Bühler

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   22.11.2022    | 0.0.1   |  Gruppe kennengelernt, sich mit Use case und WinForms vertraut gemacht, Projektdokumentation angefangen.|
| 29.11.2022      | 0.0.2   | Gruppe hat angefangen zu realisieren und sich mit tutorials beschäftigt.                                     |
|  06.12.2022     | 0.0.3   |Gruppe hat angefangen sich mit der PR zu beschäftigen und setzte das Programmieren fort.| 
|13.12.2022       | 0.0.4   |Besprechung und zusammenstellung des Codes mit der ganzen Gruppe, PR wurde erstellt und vorgetragen, erweiterung- und verbesserung des Codes. |
|20.12.2022       | 1.0.0   |Wir haben unsere Projektdokumentation und den Lernbericht fertig gemacht. Wir haben auch den Code auf Github geladen. |

## 1 Informieren

### 1.1 Ihr Projekt

Wir machen ein Spiel in Visual Studio mit WinForms, dass dem Spiel Pong ähnlich ist, Pong ist ein Spiel, bei welchem sich zwei Balken gegenüberstehen und sich einen Ball zuspielen. Ziel ist es, den Ball hinter die Linie des Mitspielers zu befördern.




### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |       kann         |   funktional   | Als User möchte ich ein Schwierigkeit bei dem Gegner auswählen können, damit es verschiedene Schwierigkeiten gibt.  |
| 2  |          muss       |  funktional    |   Als User möchte ich das ich sehen kann wie viele Punkte ich habe, damit ich weiss ob ich am gewinnnen oder verlieren bin.                                 |
|3|          muss       |   funktional   |   Als User möchte ich das ich sehen kann wie viele Punkte mein Gegner hat, damit ich weiss ob ich am gewinnen oder verlieren bin.                                  |
|  4 |          muss       |  funktional    |    Als User möchte ich eine auswahl von verschiedenen Ballfarben haben, damit das Spiel verschiedene Farben haben kann.                             |
| 5  |          kann       |  funktional    |     Als User möchte ich eine auswahl von verschiedenen Blockstabfarben haben, damit das Spiel verschiedene Farben haben kann.                           |
| 6 |          kann       |    funktional  |    Als User möchte ich eine Farbauswahl von dem Blockstab meines Gegners haben, damit das Spiel verschiedene Farben haben kann.                             |
| 7  |          kann       |  funktional    |      Als User möchte ich das wenn ich einen Punkt mache ein Sound abgespielt wird, damit das Spiel Lustiger wird.                               |
| 8 |          kann       |  funktional    |    Als User möchte ich die Ballgeschwindigkeit ändern können, damit das Spiel schwieriger wird.                               |
| 9  |          kann       |  funktional    |     Als User möchte ich dass während des Spiel eine leise Musik abgespielt wird, damit das Spiel intreresanter wird.                              |
| 10 |          muss       |   funktional   |      Als User möchte ich das sich der Ball bewegen kann, damit das Spiel laufen kann.                               |
| 11 |          muss       |   funktional   |   Als User möchte ich dass sich die Blockstäbe nur vertikal bewegen können, damit man Bälle abwehren kann.                            |
| 12 |          muss       |   funktional   |   Als User möchte ich das der Ball an der Decke und am Boden abprallt, damit der Ball im Spiel bleibt.                             |
| 13 |          muss       |   funktional   |   Als User möchte ich das das Spiel nachdem der erste Spieler 10 Punkte erreicht hat beendet wird, damit es dann einen Sieger gibt.                                |
| 14 |          muss       |   funktional   |   Als User möchte ich das fals die 10 Punkte in der Zeit von 5 Minuten nicht erreicht werden das Spiel beendet wird und der Spieler mit mehr Punkten das Spiel gewinnt, fals gleich viele Punkte Unendschieden, damit das Spiel nicht unendlich lange ist.                                |
| 15    |       kann         |   funktional   |  Als User möchte ich eine Farbauswahl von dem Hintergrund haben, damit das Spiel verschiedene Farben haben kann.  |
|16|kann|funktional|Als User möchte ich, wenn ich >=5 Punkte erzielt habe der Schwierigkeitgrad meines Gegners erhöht wird, damit das Spiel spannender ist. |










### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |      Programm wird geöffnet        |  Der User wählt eine Schwierigkeit aus       |   Der Gegner im nächsten spiel hat diese Schwierigkeit                |
| 2.1  |     User ist im Spiel         |  keine       |     Seine Punkte werden angezeigt              |
| 3.1  |    User ist im Spiel          |   keine      |     Punkte des Gegners werden angezeigt              |
| 4.1  |      Programm wird geöffnet         |  User wählt Ballfarbe aus       |    Die ausgewählte Ballfarbe wird im nächsten Spiel benutzt               |
| 5.1  |      Programm wird geöffnet          |   User wählt Blockstabfarbe aus       |  Die ausgewählte Blockstabfarbe auf seiner Seite wird im nächsten Spiel benutzt                 |
| 6.1  |    Programm wird geöffnet            |   Der User wählt die Blockstabfarbe für seinen Gegner aus      |  Die ausgewählte Blockstabfarbe auf der gegner Seite wird im nächsten Spiel benutzt                  |
| 7.1  |     User ist im Spiel         | Punkt wird gemacht        |      Sound wird abgespielt             |
| 8.1  |    Programm wird geöffnet           |   Ballgeschwindigkeit wird ausgewählt      |   Die ausgewählte Ballgeschwindigkeit wird im nächsten Spiel benutzt                 |
| 9.1  |     Spiel wird gestartet         |  Keine       |     Musik wird abgespielt              |
| 10.1  |    Spiel wird gestartet          |   Keine      |   Ball bewegt sich frei                |
| 11.1  |   Spiel wird gestartet           | User steuert Blockstab        |  Blockstab bewegt sich vertikal                 |
| 12.1  |    Spiel wird gestartet          | Ball kommt mit Decke oder Boden in Kontakt        |   Ball Prallt ab                |
| 13.1  |   Spiel wird gestartet           | Keine        |  Nachdem der erste Spieler 10 Punkte erreicht hat, spiel beendet                 |
| 14.1  |     Spiel wird gestartet        |  Keine       |Spiel wird spätestens nach 5 Minuten beendet                   |
|15.1|Spiel wird gestartet|User wält Hintergrundfarbe aus|Der Hintergrund bekommt die Ausgewählte Farbe.|
|16.1|User ist im Spiel|keine|Schwierigkeitsgrad des Spieles wird nach mindestens 5 erzielten Toren erhöht.|


### 1.4 Diagramme

![Diagramm](https://user-images.githubusercontent.com/110892641/208510858-7e0d8642-178c-41bc-ae43-9f1a542d67d1.png)


## 2 Planen

| AP-№ | Zuständig | Beschreibung | geplante Zeit |
| ---- |  --------- | ------------ | ------------- |
| 1.A  |           Lennard Bühler       |  Der User wird nach dem Namen gefragt            |   30 Min            |
| 2.A  |         Lennard Bühler          |  Der User kann die Hintergrundfarbe bestimmen           |    50 Min           |
| 3.A  |           Lennard Bühler        |  Der User kann seinem Gegner einen Namen geben           |  30 Min             |
| 4.A  |           Lennard Bühler        |   Der User hat die Auswahl aus verschiedenen Ball geschwindigkeiten          |  90 Min             |
| 5.A  |          Lennard Bühler        |  Im Spiel werden die Punkte des Users gezählt           |    50 Min           |
| 6.A  |           Lennard Bühler        |  Im Spiel werden die Punkte des Gegners gezählt            |   50 Min            |
| 7.A  |          Filip Mitrovic        | Ballfarbe kann bestimmt werden|30 Min.|
| 8.A  |         Filip Mitrovic         |  Blockstabfarbe des Gegners kann bestimmt werden| 20 Min.              |
| 9.A  |         Filip Mitrovic        | Es hat ein Zeitlimit bis das Spiel beendet wird             |    20 Min.           |
| 10.A  |          Filip Mitrovic      | Blockstäbe können nur Vertikal bewegt werden.             |     45 Min.          |
| 11.A  |            Filip Mitrovic    | Ball prallt von der Decke und Boden ab.             |      40 Min.         |
| 12.A  |           Filip Mitrovic    | Schwierigkeitgrad kann verändert werden.             |    20 Min.           |
| 13.A  |           Justus meister   | Sound wird nach einem Tor abgespielt             |     50 min          |
| 14.A  |      Justus Meister       |  Blockstabfarbe des Users kann bestimmt werden            |  15 Min.             |
| 15.A  |        Justus Meister      |     User hat eine Auswahl von Sounds die abgespielt werden können beim erzielen eines Punktes.         |     45 Min.          |
| 16.A  |       Justus Meister       |    Der Winkel mit dem der Ball vom Blockstab abprallt soll sich ändern je weiter oben oder unten der Ball auf den Blockstab trifft.          |        20Min.       |
| 17.A  |        Justus Meister      |   Das Spiel soll im Vollbildmodus spielbar sein.           |     20 Min.          |
| 18.A  |       Julian Warnebold     |Hintergrundfarben bestimmen können              |   60 Min.            |
| 19.A  |         Julian Warnebold       |  Hintergrundfarbe nach jedem Spiel ändern können            |      30 Min.         |              
| 20.A  |       Julian Warnebold        |  Hintergründe mit mehreren Farben wählen können            |      50 Min.         |
| 21.A  |        Julian Warnebold        |  Wenn Hintergrund mit mehreren Farben gewählt wird und nur eine Ausgesucht wird, Fehler eingabe            |     20 Min.          |
| 22.A  |       Julian Warnebold        |  Hintergrundmuster auswählen könne            |   40 Min.            |
| 23.A  |       Julian Warnebold       | Maximal 1 Hintergrundmuster möglich machen             |     30 Min          |
| 24.A  |       Julian Hitz         | Das Spiel nach 10 Punkten beendet wird     | 30 Min.    |
| 25.A  |       Julian Hitz        | Das Spiel nach 5 Min. beendet wird, wenn keine 10 Punkte|  45 Min.             |
| 26.A  |      Julian Hitz        | Der Ball sich bewegen kann       | 45 Min.              |
| 27.A  |       Julian Hitz       | Es nach einem Punkt weiter geht, mit Anstoss       | 30 Min.              |
| 29.A  |       Julian Hitz       | Der Sieger am Ende des Spiels bestimmt wird             |  45 Min.             |
| 30.A  |      Julian Hitz        | Die Punkte Angezeigt werden             | 45 Min.              |
|31.A|    Filip Mitrovic|Der Schwierigkeitsgrad des Spieles wird nach 5 erzielten Toren erhöht.|15 Min.|      
|Total|    |      |   1155 min     |




## 3 Entscheiden

Wir haben uns entschieden einen Timer einzubauen, da uns dies schon im letzten Projekt gut gelungen ist.

Wir haben uns entschieden ein System einzubauen, dass bei 10 erzielten Punkten das Spiel beendet, damit das Spiel auch ein Punktlimit besitzt.


## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |    29.11.2022     |    Lennard Bühler       |      30 min         |        25 min           |
| 2.A  |     29.11.2022    |    Lennard Bühler       |      50 min         |     40 min              |
| 3.A  |     29.11.2022   |     Lennard Bühler      |       30 min        |       40 min            |
| 4.A  |    29.11.2022    |     Lennard Bühler      |        90 min       |        80 min           |
| 5.A  |    29.11.2022    |      Lennard Bühler     |      50 min         |         40 min          |
| 6.A  |    29.11.2022    |      Lennard Bühler     |       50 min        |         40 min          |
| 7.A  |     29.11.2022   |     Filip Mitrovic      |       30 min        |        30 min           |
| 8.A  |      29.11.2022  |      Filip Mitrovic     |       20 min        |         20 min          |
| 9.A  |     29.11.2022   |      Filip Mitrovic     |       20 min        |         30 min          |
| 10.A |    29.11.2022    |      Filip Mitrovic     |     45 min          |       40 min            |
| 11.A |    29.11.2022    |      Filip Mitrovic     |       40 min        |      35 min             |
| 12.A |     29.11.2022   |       Filip Mitrovic    |         20 min      |       25 min            |
| 13.A |     29.11.2022   |      Justus meister     |           50 min    |      45 min             |
| 14.A |      29.11.2022  |        Justus meister   |       15 min        |       20 min            |
| 15.A |      29.11.2022  |       Justus meister    |         45 min      |         40 min          |
| 16.A |      06.12.2022  |      Justus meister     |        20 min       |          20 min         |
| 17.A |     06.12.2022   |      Justus meister     |          20 min     |         25 min          |
| 18.A |     06.12.2022   |     Julian Warnebold      |        60 min     |          60 min         |
| 19.A |     06.12.2022   |      Julian Warnebold     |      30 min         |        25 min           |
| 20.A |     06.12.2022   |       Julian Warnebold    |         50 min      |       45 min            |
| 21.A |     06.12.2022   |       Julian Warnebold    |     20 min          |       25 min            |
| 22.A |     06.12.2022   |      Julian Warnebold     |     40 min          |       45 min            |
| 23.A |     06.12.2022   |       Julian Warnebold    |      30 min         |       35 min            |
| 24.A |   06.12.2022    |     Julian Hitz       |      30 min         |       40 min            |
| 25.A |   06.12.2022   |      Julian Hitz      |        45 min       |      40 min             |
| 26.A |    06.12.2022    |    Julian Hitz        |     45 min          |    40 min               |
| 27.A |    13.12.2022  |      Julian Hitz      |        45 min       |      50 min             |
| 28.A |    13.12.2022   |     Julian Hitz       |       30 min        |     20 min              |
| 29.A |    13.12.2022   |        Julian Hitz    |        45 min       |     30 min              |
| 30.A |   13.12.2022    |       Julian Hitz     |       45 min        |      50 min             |
| 31.A |  13.12.2022     |     Filip Mitrovic      |      15 min         |      20 min             |
|Total|       |        |      1155 min    |   1080 min    |



## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |    13.12.2022   |     Funktioniert nicht     |  Mitrovic+Meister      |
| 2.1  |     13.12.2022   |    Funktioniert      |   Mitrovic+Meister     |
| 3.1  |     13.12.2022   |     Funktioniert     |    Mitrovic+Meister    |
| 4.1  |     13.12.2022   |      Funktioniert nicht    |    Mitrovic+Meister    |
| 5.1  |    13.12.2022    |       Funktioniert nicht   |    Mitrovic+Meister    |
| 6.1  |    13.12.2022    |     Funktioniert nicht    |    Mitrovic+Meister    |
| 7.1  |    13.12.2022    |    Funktioniert nicht      |    Mitrovic+Meister    |
| 8.1  |    13.12.2022    |      Funktioniert nicht    |    Mitrovic+Meister    |
| 9.1  |    13.12.2022    |    Funktioniert      |    Mitrovic+Meister    |
| 10.1  |    13.12.2022    |   Funktioniert       |   Mitrovic+Meister     |
| 11.1  |     13.12.2022   |     Funktioniert     |   Mitrovic+Meister     |
| 12.1  |     13.12.2022   |      Funktioniert    |   Mitrovic+Meister     |
| 13.1  |     13.12.2022   |   Funktioniert       |   Mitrovic+Meister     |
| 14.1  |     13.12.2022   |    Funktioniert      |   Mitrovic+Meister     |
| 15.1  |      13.12.2022  |     Funktioniert nicht    |   Mitrovic+Meister     |
| 16.1  |      13.12.2022  |     Funktioniert     |   Mitrovic+Meister     |

`Fazit:`

Die wichtigsten Teile des Programmes sind mit Erfolg ausgegangen, somit ist unser Programm spielbar. Doch Leider konnten wir wegen geringer Zeit nicht alle unsere Wünsche für das Programm erfüllen.
