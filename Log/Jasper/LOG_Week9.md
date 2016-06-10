# Logboek - _Jasper Van Gestel_

### Week 9 (11/4/'16 - 17/4/'16)

**Maandag**

* Opstart na 2 weken 'pauze'
* Terug kijken hoe alles nu weer juist werkt
* Terug kijken of alles nog werkt (tests)
  * Testrun --> 88 / 99 geslaagde tests
  * Valt dus nog goed mee
* Proberen ClincHub volledig uit te werken
* "Alle Studies" knop problemen opgelost
  * Problemen doordat dit een "unique control" is
  * Opgesplitst in 3 methoden --> probleem weggewerkt
* Documenteren van gevonden problemen / visuele bugs
  * Herwerken van "Log" - document zodat deze ALLE problemen bevat
    * Voordien verdeeld over meerdere documenten
* Gestart met analyse "PatientScriptPage"
  * Uitzoeken hoe we deze paradigmas aan moeten pakken
    * SemanticZoom + checkbox

**Dinsdag**

* Voortgangspresentatie op school
* Rest van de dag gebruikt om testscriptie op punt te zetten

**Woensdag**

* Cleanup van repo's
  * Leegmaken van persoonlijke repo, buiten 'Log' bestanden
  * Gezamelijke repo bijwerken
  * Herwerken van hierarchy zodat deze overal uniform is
* Installatie Visual Studio Update 2
* Korte meeting
  * Inlichten waar we staan en wat we gaan doen de komende weken
  * Problemen besproken
  * Doelen gesteld
    * Peter
      * Gaat paradigma's uitdiepen
        * Heel uitgebreid analyseren van pagina's en zijn paradigma's
    * Ik 
      * Ga pagina's proberen compleet te testen
      * Ga eerst bekijken hoe we de testresults kunnen voorleggen aan de klant/Calidos zelf
        * Aantonen dat de tests werkelijk gerunt zijn geweest
        * Bekijken of er geen cruciale fouten zijn
        * Duidelijke weergave --> parsing van files e.d.

**Donderdag**

* Trage vooruitgang omtrent automatisatie van de visuele voorstelling
  * Veel nieuwe dingen leren / bekijken / opzoeken
  * Veel dingen terug oppikken van vorige jaren (file handling e.d.)
  * Uitzoeken hoe ik de .trx file kan parsen
    * A.d.h.v. developer CMD van VS zelf
      * MSTest gebruiken om tests te runnen en .trx file te genereren
    * De juiste data uit de .trx file halen
      * Ontbreekt nog 'tags' van waar de tests komen (welke pagina?, welk paradigma?)
      * Toegevoegd via 'trace' in de .trx file
    * Na een halve dag zoeken, vooruitgang geboekt
      * Kan de specifieke lijnen met data omzetten naar een .csv bestand
        * Bevat enkel de noodzakelijke informatie + tests die niet uitgevoerd zijn
* Na besprekingen met Mark
  * Opzoeken wat een 'draaitabel' is in Excel --> mogelijk goede optie tot juiste weergave van data

**Vrijdag**

* Niet gewerkt

**Weekend**

* Niet gewerkt
