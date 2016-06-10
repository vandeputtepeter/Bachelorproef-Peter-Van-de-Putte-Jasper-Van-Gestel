# Logboek - _Jasper Van Gestel_

### Week 13 (9/5/'16 - 15/5/'16)

**Maandag**

* Aanpassen van foutje bij percentage berekening
  * Formule verbeterd (geen kans op percentage problemen zoals 99 of 98% wanneer alle tests slagen)
* Levels duidelijker gemarkeerd via css (indents + boldness)
* Opzoeken hoe het mogelijk is om een test agent op te zetten in een VM
  * Waarschijnlijk gebeuren via Windows Test Manager
    * Gebruikt om lab environements op te zetten
    * Kan niet verbinden met de TFS server van Calidos
    * Opgezocht waar het probleem lag
    * In samenwerking met Tom aan het proberen fixen
* Opzoekwerk om totalen weer te geven
  * Levert tot dusver niets op
  * Problemen bij mijn redenering
    * Hoe definiëren zonder de structuur te verliezen
      * Level 1, Level 2, Level 2, Level 3, Level 3, Level 2
        * Hoe deze optellen en duidelijk maken dat enkel deze 2 level 3's opgeteld mogen worden en geen andere?
* Verder kijken naar test agents (misschien komt het antwoord op de andere vraag dan nog wel)
  * Zal niet gaan met test agents --> probleem bij Windows 10
  * De TFS is versie 2013, Windows 10 bestond toen nog niet
    * Kan dus niet deployen op windows 10 test environment
    * Research wordt bij deze stopgezet
* Aanpassen van variables zodat file names niet meer hardcoded in de code staan
  * Nu mogelijk om via command line arguments de console app te draaien
* Verder kijken naar totalen
  * Proberen van onder naar boven te werken, van rechts naa links (recursief)

**Dinsdag**

* Recursieve lookup maken voor berekenen van totals
  * MatrixCell uitgebreid met meerdere properties zodat deze childdata kunnen bijhouden
  * Twee keer loop definieren die elk zullen instaan om totalen recursief te berekenen
    * Horizontale loop
    * Verticale loop
  * Testdata integreren om te testen of dit wel degelijk juist werkt
    * Manueel aangepaste versie van Target en Result XML bestanden
* Werkt momenteel al half
  * Optellen van percentages geeft problemen
  * Nog bezig met hiervoor een oplossing te voorzien
* In code doet hij alles juist, maar krijg om nog onduidelijke reden niet het gewenste resultaat in de HTML
* Ene fout gemaakt, andere fout bijgekregen
  * Totalen tellen nu juist op, NotToDo en ToDo geven nu geen parents meer weer
  * Morgen proberen op te lossen alsook nog even kijken of ik de collapsable table kan integreren

**Woensdag**

* Bekijken of ik het opgedoken probleem van gisteren kan oplossen
  * Optellen van 'ToDo's en 'NotToDo's
  * Verandering in manier van toekennen van label
* Probleem: 'Passed' wordt getoont ook al is er een 'ToDo' nog actief in dezelfde rij/kolom
  * Opgelost door aanpassen van MatrixCell
    * Uitbreiden met totalen voor childs (horizontaal + verticaal)
* Probleem bij percentages
  * Opgelost door ook rekening te houden met de 'ToDo's en 'NotToDo's in het totaal
* Indicators voor status bij console window toegevoegd
* Html generatie opgesplitst in kleinere methoden om leesbaarheid te verbeteren
* Zoeken naar collapsable table
    * Eventueel nog te doen morgen, hangt af van bespreking
* PowerPoint maken voor presentatie morgen

**Donderdag**

* Presentatie geven, bekijken van Peter zijn vooruitgang
* Discussie over verdere verloop
  * Collapse - Expand is nog een zeer belangrijk punt dat moet gebeuren
  * Lijst met gefaalde testen onderaan tonen
  * Legende onderaan tonen
  * Enkele kleine foutjes fixen
  * Als er tijd over is --> floating headers die mee blijven gaan wanneer gescrold wordt
* Benaming van Parsing Tools --> Result Management Tool
* To-do-lijst aangevuld, proberen in de toekomst meer te werken met to-do-lijsten
  * Handiger om bij te houden welk werk belangrijk is enzovoorts..
* Kleinigheden al reeds aangepast
  * Nog uitzoeken hoe ik total's een gele achtergrond kan geven (ook al zijn ze geslaagd / gefaild) wanneer er een todo in zijn childs aanwezig is
  * Opgelost in de code, moest een extra if-voorwaarde definiëren
* Legende aangemaakt
* Css aangepast om leesbaarheid te verduidelijken
* Lijst met gefaalde tests weergeven is ook gebeurt
* 'Done' tag toegevoegd aan target bestand --> duidt aan dat effectief alle test gebeurt zijn voor die bepaalde paradigma/screen combinatie
  * Geimplementeerd in code zodat de 'completed' (groene) cell getoond kan worden als een soort 'override' of exceptie
  * De gewone versie van 'completed' aangepast zodat deze exceptie wordt gebruikt
  * Morgen verder kijken naar Collapse-expand (nog maar eens)

**Vrijdag**

* Kort samengevatte dag vandaag.
  * Heel de dag uitgezocht hoe ik de Collapse - Expand kon maken
  * Matig succes
    * Uiteindelijk deels een oplossing gevonden
* Dinsdag verder gaan.

**Weekend**

* Thuis wat opgezocht over Collapse - Expand, en wat verder experimenteert