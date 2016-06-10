# Logboek - _Jasper Van Gestel_

### Week 11 (25/4/'16 - 1/5/'16)

**Maandag**

* Starten waar ik gebleven was vorige vrijdag
  * Samenzitten met Mark om te bespreken hoe ik best verder ga
    * Voorgesteld om eerst matrix te genereren en hieruit de result file automatisch genereren
    * Result file zelf schrijven vereist veel werk --> betere oplossing
  * Mark was akkoord, ook id's aanpassen --> moeten uniek blijven ook wanneer ze verplaatst worden
* Veranderingen aan XML file
  * Oorspronkelijke id's --> name
  * Oorspronkelijke name's --> info
  * Nieuwe id's --> GUID string
* RegisterTest tags (nog maar eens) aangepast zodat deze overeen komen
* Start met creëren van klasse om matrix mee voor te kunnen stellen
* Discussie / meeting rond matrix van paradigma's met Peter
  * Conclusies
    * Matrix moet aangepast worden zodat deze een duidelijker beeld geeft
    * Onder meer functionaliteit opsplitsen zodat deze minder gigantisch is in omvang
* Testscriptie aanvullen

**Dinsdag**

* Vandaag echt begonnen met coderen aan de automatische testresult-parsing applicatie
  * Eerst XML omgezet in code via "xsd2code++" programma
    * Genereert objecten van de XML code
* Opzetten van klassen
  * Matrix klasse
  * MatrixCell klasse
  * Program klasse (applicatie)
    * Momenteel gedaan:
      * Treeview van XML omgezet tot nieuwe lijsten van:
        * Verticale Axis (Kolom)
        * Horizontale Axis (Rij)
        * Cellen
          * Met referentie naar "Kolom" en "Rij"
          * Testnaam
          * Waarde (Geslaagd, Gefaald, Te Doen,..)

**Woensdag**

* Test scriptie bij aanvullen
* Opzoeken hoe code omzetten in html op efficiënte manier
  * Via HtmlTextWritter klasse was een optie --> kan ik niet refereren om een of andere gekke reden
  * Via XSLT document
    * Gestandaardiseerde manier om XML te transformeren (naar html in dit geval)
* Testen van omzetting
  * Voorlopig nog geen succes
  * Tutorials volgen over XSLT notatie
    * Werkt nauw samen met zuster-technologie XPath
      * Tutorials volgen over XPath

**Donderdag**

* Heel de ochtend liggen uitzoeken waarom ik geen html kon tevoorschijn brengen van het xslt bestand
  * Gevonden! --> het xmlns stylesheet atribuut van het xml document was de spelbreker
    * Moet veranderd worden naar xmlns:xsd aangezien deze het xsd document refereert
      * Het programma was in de war omdat ook de xslt een xmlns referentie gebruikt
* Na verder bekijken is er een probleem met het gebruik van xslt --> kan maar 1 input xml bestand hebben
  * Overstappen naar HtmlTextWritter klasse --> referentie is gelukt
    * Had naar verkeerde referentie gekeken
* Schrijven met HtmlTextWriter ging vrij vlot
  * Eerste versie van tabel is klaar --> volgende stap = interactief proberen maken
  * Eerst aanpassen van trx bestand naar nieuwe notatie
  * Nog een hoop foutjes hier in dit bestand zo blijkt

**Vrijdag**

* Niet gewerkt

**Weekend**

* Niet gewerkt