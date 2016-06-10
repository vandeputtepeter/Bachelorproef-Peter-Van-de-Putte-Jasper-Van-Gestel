# Logboek - _Jasper Van Gestel_

### Week 10 (18/4/'16 - 24/4/'16)

**Maandag**

* Verdergaan met opzoekwerk draaitabelen
  * Waarschijnlijk moeten wegschrijven in XML bestand om makkelijke integratie met Excel te verzekeren
  * .csv wordt dus naar de vuilbak verwezen
    * Code omvormen om output naar XML om te zetten
  * Met wat hulp van Tom de juiste manier gevonden om de data om te vormen
  * Andere voorstelling in Excel zal noodzakelijk zijn
    * Mogelijkheid om originele model te recreeren, maar dit zal via een tussenstap moeten
      * Eerst omzetten naar informatie die draaitabellen kunnen verwerken
      * Deze informatie kan omgezet worden tot een duidelijke visuele weergave
* Vanmorgen alles omgezet van .trx naar .csv file
  * Nu naar .xml mogelijk gemaakt
  * De .xml file kan worden weergegeven 
* Feedback gehad op de geschreven tests / code van Tom (via mail)
  * Volledige code herbekeken en aangepast waar nodig
  * Laten overeenkomen met de code guideline van Calidos
    * Regions verwijderd waar nodig / regions vaste benamingen gegeven 
      * (geen 10 verschillende namen waar hetzelfde bedoelt werd)
    * Public en private fields/properties juiste schrijfwijze gegeven
    * Methods juiste schrijfwijze gegeven
    * Op sommige plaatsen ver'engels't zodat alles duidleijk in eenzelfde taal staat

**Dinsdag**

* Gisteren gegevens in tabel kunnen gieten
  * Vandaag gegevens aan het omzetten naar draaitabel / pie chart
* Alle Test Methodes de RegisterTest methode meegegeven
  * Belangrijk met het vooruitzicht op automatisch registreren van testresultaten en dergelijke
  * Voorlopig even op 'hold' gezet nu
* Volgende week nieuwe voorstelling
  * Vraag of ik wou kijken naar SFX oftewel self extracting zip
    * Research gedaan, weinig of geen info te vinden met de bestaande library die gebruikt wordt om zips op te stellen
    * Na lang zoeken dan toch een post op een forum gevonden met een 'hack' om een SFX te creeren binnen de library.
    * Uittesten of deze zijn werk doet
    * Oude code, maar effectief
      * Bestaande library aangepast met code van op forum
      * Recompile van dll
      * Na tests blijkt dit zeer goed te werken
* Klaarmaken om morgen verder te gaan met draaitabel
  * In overleg met Mark proberen deze weer te geven in HTML via javascript
    * Excel verwacht getallen, terwijl we met letters werken in de checklist

**Woensdag**

* TargetData XML afwerken
  * Paradigma's compleet
  * Clinichub als testscreen gebruikt
  * Nog te doen
    * Targets defineren
* Xsd file opgestelt met schema voor TargetData XML
  * Nog te doen
    * Xsd file opstellen met schema voor ResultData XML
    * Code die ResultData XML schrijft, herschrijven zodat deze de juiste formatting doet
* Probleem opgedoken met SFX (.exe) file
  * Extract zijn files maar opent zijn map vervolgens niet meer
    * Probleem zit in de Byte array waar de .exe wordt gemaakt
    * Proberen op te lossen door andere library te gebruiken
      * Zo niet zal de volledige .exe zelf geschreven moeten worden
* Herschreven met DotNetZip library
  * Werkt al volledig tot op het punt dat de command na extraction moet worden uitgevoerd
  * Morgen verder zoeken

**Donderdag**

* Vanmorgen na wat zoeken en 'sukkelen' de juiste command gevonden om de folder te openen waar de files geextract zijn door de self extracting zip
* Verdergaan met het opstellen van XML files
  * Problemen gehad bij het omzetten (serialize - deserialize) van XML naar objecten
  * Nog niet kunnen oplossen
    * Xsd gemaakt voor resultdata
    * Resultdata geautomatiseerd zodat deze conform de xsd van resultdata is
    * Targets uitgeschreven voor ClinicHub (de tests die plaats MOETEN vinden (TODO))
  * Verder proberen oplossen zodat deserialization mogelijk is
    * Na even zoeken, uiteindelijk dan toch het probleem gevonden
      * StringReader leest UTF-16 --> moet StreamReader worden (leest UTF-8 zoals XML opgesteld is)
  * Base klasse aangevuld zodat deze voorbereidt is op de automatisatie van de testresults

**Vrijdag**

* Hardcoded strings invullen bij RegisterTest methoden
  * Hardcoded omdat dit momenteel de enige manier is om niet te veel werk te maken voor wat het moet doen
  * Problemen bij meerdere paradigmas per control
  * Opgelost door ombouwen van constructie XML file
    * For loop
  * Verder omzetten van vorige RegisterText format naar nieuwe

**Weekend**

* Niet gewerkt