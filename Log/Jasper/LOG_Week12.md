# Logboek - _Jasper Van Gestel_

### Week 12 (2/5/'16 - 8/5/'16)

**Maandag**

* Draad oppikken waar we vorige week gebleven waren
  * Nakijken van Program.cs dat instaat voor de omzetting van .TRX naar .XML van testresultaten
    * Fixed it! --> Problemen bij omzetting, fout in benaming van file
* Volgende dilemma:
  * Eerste resultaat van sample file beïnvloed alle niet uitgevoerde resultaten
  * Bijna alle resultaten worden nu weergegeven zoals de uitkomst van het eerste resultaat
    * (Buiten de resultaten die wel gedefinieerd werden in het resultaten document)
    * Opgelost door creëren van alle cellen (leeg) voor we onze targets gaan toevoegen
      * "Targets" zoeken naar ingestelde categorie en object en overschrijven de betreffende cel
      * Zelfde bij "Results" die dan de targets overschrijven
  * Uitzoeken hoe javascript te implementeren in het HTML document
    * Gaat moeizaam
    * Misschien oplossing gevonden, morgen testen

**Dinsdag**

* Vanmorgen begonnen met uitzoeken van javascript
  * Stilaan meer tot de conclusie aan het komen dat collapsable tabel te ver gegrepen is
  * Ook proberen uitzoeken of het mogelijk is om tabel headers fixed te houden
    * zodat de tabel makkelijker te bekijken valt
    * Ook geen tot weinig succes
* Css en js files gevonden (MIT/GPL licensed) die beloofden headers fixed te houden
  * Werkt half, opmaak is verbeterd op een 'bootstrap' manier, simpel maar strak
  * Werkt in het princiepe dat het een kopie maakt van de tabel
    * Hieruit genereerd het js script een column, intersect en header tabel
    * Deze worden bovenop de originele tabel weergegeven
      * Normaal zou het script deze tabellen verplaatsen, maar dit gebeurt tot dusver niet
      * Zou ook problemen geven met collapsable rows en columns

**Woensdag**

* Aanpassen van column header zodat deze verticaal getoont wordt, via JS
  * Klein script zorgt voor transformatie
  * Geeft duidelijker en compacter beeld
* Voorbereiden presentatie
  * Statusraport toelichten bij mentors, en bij Peter
    * Dit omwille van 2 verschillende projecten en elkaar te informeren
      * Hij houdt mij op de hoogte van zijn vooruitgang
      * Ik houd hem op de hoogte van mijn vooruitgang
* Proberen runnen van de CUIT op een virtual machine
  * Gaf problemen omdat deze nog steeds mijn muis nodig had
  * Origineel hadden we dit gedaan zodat ik verder kon werken terwijl de CUIT ook gebeurden
    * Fout opgedoken die ons ook problemen zal geven in de build straat

**Donderdag**

* Niet gewerkt -- Feestdag

**Vrijdag**

* Werken van thuis uit
* Aanduiden van inheritance levels via .split() functie
  * Erkennen welke level de categorie / het object heeft
  * Hierdoor wordt het makkelijk om volgende dingen te implementeren
    * Totalen bij parents weergeven
    * Align / indentation van children
* Aanpassen van F (Failed) naar percentage van geslaagde tests op bepaalde paradigma

**Weekend**

* Niet gewerkt