# Logboek - _Jasper Van Gestel_

### Week 3 (29/2/'16 - 6/3/'16)
**Maandag**

* Verslag meeting donderdag 25/02 aangevuld en verstuurd
* Planning gemaakt die weergeeft waar we binnen enkele weken zouden moeten staan
* Volledig vastgelopen met programmeren
    * Elke keer andere error
    * Moeilijkheden met bepalen wat er fout is of hoe het op te lossen
    * Heb het idee dat het programma niet juist genoeg opgestelt is om duidelijk en goed Coded UI hierop te doen
    * UWP en Coded UI zijn momenteel twee termen die niet goed samengaan
* Problemen blijven overal opduiken, antwoorden blijven uit of miniem
* Praktisch niets bereikt vandaag

**Dinsdag**

* Base klasse aangepast --> meer code efficiency
* Mail gestuurd naar CTG met vraag naar info over CUIT bij UWP apps
    * Mail terug gehad
    * Konden niet helpen, te nieuwe technologie
    * Wel link gehad van website met eventuele interesante informatie
* Uitzoeken hoe we best testing gaan doen - Basis leggen van aanpak
* ClinicHub opnieuw aangepast
* `BaseClassCodedUI.cs` aangepast naar partial klasse
* Andere partial klasse toegevoegd genaamd `BaseClassCodedUI.Common.cs`
    * Bevat testmethoden die in alle paginas voorkomen
        * Menubalk aan de zijkant + semantic zoom
* Uitzoeken hoe partial klasse met testmethoden te implementeren
* Realiseren dat dit een redelijk zware opdracht blijkt te zijn

**Woensdag**

* `BaseClassCodedUI.Common.cs` aangepast
    * TestMethod's zijn niet inheritable
    * `[TestMethod]` tag verwijdert --> gewone methoden van gemaakt
    * UIMap_General aangemaakt --> Menubalk items ingestoken
    * Methoden kunnen nu op eender welke pagina aangeroepen worden (hebben geen andere UIMap nodig)
* Documenteren van informatie betreffende methoden/controls
* Designen van autonome, duidelijke methoden (vormgeven)
* Grote kuis:
    * Refracturen van benamingen
    * Bestanden ordenen
    * Code cleaning
* Herschrijven van Checklist in spreadsheet
    * Makkelijker en duidelijker te beheren
    * Overzichtelijker om te werken
* Het begint meer en meer duidelijker te worden wat nu juist verwacht wordt
* Plannen voor morgen
* Deel Bachelorproef Repository aanvullen

**Donderdag**

* Bekijken van Checklist (herschrijven)
  * Kort besproken en afspraken over gemaakt
  * Documenteren van noodzakelijke checklist punten
* Aan de slag gegaan met de navigatie van `ClinicHubPage` 
* Methoden geschreven om te scrollen --> 'Basis-handeling'
  * Noodzakelijk om knoppen te bereiken die nog niet zichtbaar zijn op het scherm
  * Dit was blijkbaar al langer een probleem en is nu opgelost
    * _Cannot 'Click' on hidden control_ error tijdens testen wees op dit probleem
* Basisklasse uitgebreidt met nuttige methoden voor alle pagina's
* Veel vooruitgang geboekt
  * Hele `ClinicHubPage`is bijna test-klaar

**Vrijdag**

* Niet gewerkt

**Weekend**

* Niet gewerkt