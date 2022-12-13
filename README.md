# Projekt_LA1300-1



# Projekt-Dokumentation



Filip Mitrovic, Julian Warnebold, Julian Hitz, Justus Meister, Lennard Bühler

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   22.11.2022    | 0.0.1   |  Gruppe kennengelernt, sich min Use case und WinForms vertraut gemacht, Projektdokumentation angefangen|
|   29.11.2022    | 0.0.5     |   Wir haben uns mit Winforms besser kennengelernt und fingen an unseren ersten Code zu schreiben.              |
| 06.12.2022      | 1.0.0   |Wir beschäftigen uns mit der PR und haben unseren Code weiter geschrieben.                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Wir machen ein Spiel in Visual Studions mit WinForms, das dem Spiel Pong ähnlich ist.

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











### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |      Programm wird geöffnet        |  Der User wählt eine Schwierigkeit aus       |   Der Gegner im nächsten spiel hat diese Schwierigkeit.                |
| 2.1  |     User ist im Spiel         |  keine       |     Seine Punkte werden angezeigt.             |
| 3.1  |    User ist im Spiel          |   keine      |     Punkte des Gegners werden angezeigt              |
| 4.1  |      Programm wird geöffnet         |  User wählt Ballfarbe aus       |    Die ausgewählte Ballfarbe wird im nächsten Spiel benutzt.              |
| 5.1  |      Programm wird geöffnet          |   User wählt Blockstabfarbe aus       |  Die ausgewählte Blockstabfarbe auf seiner Seite wird im nächsten Spiel benutzt.                 |
| 6.1  |    Programm wird geöffnet            |   Der User wählt die Blockstabfarbe für seinen Gegner aus      |  Die ausgewählte Blockstabfarbe auf der gegner Seite wird im nächsten Spiel benutzt.                  |
| 7.1  |     User ist im Spiel         | Punkt wird gemacht        |      Sound wird abgespielt.             |
| 8.1  |    Programm wird geöffnet           |   Ballgeschwindigkeit wird ausgewählt      |   Die ausgewählte Ballgeschwindigkeit wird im nächsten Spiel benutzt.                 |
| 9.1  |     Spiel wird gestartet         |  Keine       |     Musik wird abgespielt.              |
| 10.1  |    Spiel wird gestartet          |   Keine      |   Ball bewegt sich frei.                |
| 11.1  |   Spiel wird gestartet           | User steuert Blockstab        |  Blockstab bewegt sich vertikal.                 |
| 12.1  |    Spiel wird gestartet          | Ball kommt mit Decke oder Boden in Kontakt        |   Ball Prallt ab .               |
| 13.1  |   Spiel wird gestartet           | Keine        |  Nachdem der erste Spieler 10 Punkte erreicht hat, spiel beendet .                |
| 14.1  |     Spiel wird gestartet        |  Keine       |Spiel wird spätestens nach 5 Minuten beendet.                   |
|15.1|Spiel wird gestartet  |User wählt Hintergrundfarbe aus|Die Hintergrundsfarbe wird verändert.|



### 1.4 Diagramme

<img width="358" alt="MicrosoftTeams-image (1)" src="https://user-images.githubusercontent.com/110892642/204496004-052f2f71-1603-4840-a314-8a9cf70b554e.png">


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |    Lennard Bühler       |  Der User wird nach dem Namen gefragt.            |   30 Min            |
| 2.A  |       |   Lennard Bühler          |  Der User kann die Hintergrundfarbe bestimmen.           |    50 Min           |
| 3.A  |       |     Lennard Bühler        |  Der User kann seinem Gegner einen Namen geben.           |  30 Min             |
| 4.A  |       |     Lennard Bühler        |   Der User hat die Auswahl aus verschiedenen Ball geschwindigkeiten.          |  90 Min             |
| 5.A  |       |     Lennard Bühler        |  Im Spiel werden die Punkte des Users gezählt.           |    50 Min           |
| 6.A  |       |     Lennard Bühler        |  Im Spiel werden die Punkte des Gegners gezählt.            |   50 Min            |
| 7.A  |       |     Filip Mitrovic        | Ballfarbe kann bestimmt werden.|30 Min.|
| 8.A  |       |    Filip Mitrovic         |  Blockstabfarbe des Gegners kann bestimmt werden.| 30 Min.              |
| 9.A  |       |    Filip Mitrovic        | Es hat ein Zeitlimit bis das Spiel beendet wird.             |    30 Min.           |
| 10.A  |       |      Filip Mitrovic      | Blockstäbe können nur Vertikal bewegt werden.             |     45 Min.          |
| 11.A  |       |        Filip Mitrovic    | Ball prallt von der Decke und Boden ab.             |      40 Min.         |
| 12.A  |       |        Filip Mitrovic    | Schwierigkeitgrad kann verändert werden.             |    30 Min.           |
| 13.A  |       |        Justus mester   | Sound wird nach einem Tor abgespielt.             |     50 min          |
| 14.A  |       |  Justus Meister       |  Blockstabfarbe des Users kann bestimmt werden.            |  35 Min.             |
| 15.A  |       |    Justus Meister      |     User hat eine Auswahl von Sounds die abgespielt werden können beim erzielen eines Punktes.         |     45 Min.          |
| 16.A  |       |    Justus Meister       |    Der Winkel mit dem der Ball vom Blockstab abprallt soll sich ändern je weiter oben oder unten der Ball auf den Blockstab trifft.          |      30 Min.         |
| 17.A  |       |     Justus Meister      |  Das Spiel soll im Vollbildmodus spielbar sein.            |    30 Min.           |
| 18.A  |       |      Julian Warnebold     |Hintergrundfarben bestimmen können.              |   60 Min.            |
| 19.A  |       |       Julian Warnebold       |  Hintergrundfarbe nach jedem Spiel ändern können.            |      30 Min.         |              
| 20.A  |       |      Julian Warnebold        |  Hintergründe mit mehreren Farben wählen können.            |      50 Min.         |
| 21.A  |       |      Julian Warnebold        |  Wenn Hintergrund mit mehreren Farben gewählt wird und nur eine Ausgesucht wird, Fehler eingabe.            |     20 Min.          |
| 22.A  |       |      Julian Warnebold        |  Hintergrundmuster auswählen könne.            |   40 Min.            |
| 23.A  |       |    Julian Warnebold       | Maximal 1 Hintergrundmuster möglich machen.             |     30 Min          |
| 24.A  |       |    Julian Hitz         | Das Spiel nach 10 Punkten beendet wird.     | 30 Min.    |
| 25.A  |       |     Julian Hitz        | Das Spiel nach 5 Min. beendet wird, wenn keine 10 Punkte.|  45 Min.             |
| 26.A  |       |     Julian Hitz        | Der Ball sich bewegen kann.       | 45 Min.              |
| 27.A  |       |      Julian Hitz       | Es nach einem Punkt weiter geht, mit Anstoss.       | 30 Min.              |
| 29.A  |       |      Julian Hitz       | Der Sieger am Ende des Spiels bestimmt wird.             |  45 Min.             |
| 30.A  |       |     Julian Hitz        | Die Punkte Angezeigt werden.             | 45 Min.              |
      

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

Wie haben uns für eine Stoppuhr endschieden, weil wir das schon im letzten Projekt machen mussten und das dadurch schon konnten.

Wir haben uns für eine Farben auswahl bei Blockstäben, Ball, Hintergrund etc. entschieden, weil dadurch das Spiel nicht so uninteresant ist.

Wir haben uns dafür entschieden das es verschiedene Schwirigkeiten gibt, dass der User das Spiel an seine Stärke anpassen kann.


## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |      Lennard Bühler     |       30 min        |                   |
| 2.A. |       |    Lennard Bühler        |    50 min           |                   |
| 3.A  |       |    Lennard Bühler        |     30 min          |                   |
| 4.A  |       |     Lennard Bühler       |     90 min          |                   |
| 5.A  |       |     Lennard Bühler       |      50 min         |                   |
| 6.A  |       |     Lennard Bühler       |      50 min         |                   |
| 7.A  |       |    Filip Mitrovic       |      30 min         |                   |
| 8.A  |       |   Filip Mitrovic         |      30 min         |                   |
| 9.A  |       |   Filip Mitrovic         |     30 min          |                   |
| 10.A  |       |   Filip Mitrovic         |      45 min         |                   |
| 11.A  |       |    Filip Mitrovic        |     40 min          |                   |
| 12.A  |       |    Filip Mitrovic        |     30 min          |                   |
| 13.A  |       |    Justus Meister       |      50 min         |                   |
| 14.A  |       |   Justus Meister         |     35 min          |                   |
| 15.A  |       |   Justus Meister         |      45 min         |                   |
| 16.A  |       |   Justus Meister         |      30 min         |                   |
| 17.A  |       |  Justus Meister          |      30 min         |                   |
| 18.A  |       |  Julian Warnebold         |        60 min       |                   |
| 19.A  |       |   Julian Warnebold         |     30 min          |                   |
| 20.A  |       |   Julian Warnebold         |        30 min       |                   |
| 21.A  |       |    Julian Warnebold        |       50 min        |                   |
| 22.A  |       |   Julian Warnebold         |         20 min      |                   |
| 23.A  |       |   Julian Warnebold         |      40 min         |                   |
| 24.A  |       | Julian Hitz          |         30 min      |                   |
| 25.A  |       | Julian Hitz          |         30 min      |                   |
| 26.A  |       |  Julian Hitz         |        45 min       |                   |
| 27.A  |       |  Julian Hitz         |       45 min        |                   |
| 28.A  |       | Julian Hitz          |       30 min        |                   |
| 29.A  |       | Julian Hitz          |        45 min       |                   |
| 30.A  |       |  Julian Hitz         |      45 min         |                   |




## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
Footer
© 2022 GitHub, Inc.
Footer navigation
Terms
Privacy
Security
Status
Docs
Contact GitHub
Pricing
API
Training
Blog
About
