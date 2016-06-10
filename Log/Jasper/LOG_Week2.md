# Logboek - _Jasper Van Gestel_

### Week 2 (22/2/'16 - 28/2/'16)
**Maandag**

* Trage vooruitgang door problemen met combobox
* Document opgesteld waar fouten en problemen beschreven worden (ook bijgevoegd in map 'Overige Documenten')
* 4 testmethoden bijgeschreven
    * Volledige eerste pagina is nu 'test-ready' (buiten 2  tests met comboboxen)
* Besproken om morgen een planning op te stellen

**Dinsdag**

* Gestart met bijhouden van vereisten om de applicatie op een juiste, volledige manier te testen alsook bijkomende informatie
    * Document zal later toegevoegd worden aan 'Overige Documenten'
* Belangrijkste 'controls' toegevoegd op document
* Verder gedocumenteerd waar fouten voorkomen en waarom
* Oplossing proberen zoeken voor combobox probleem
    * Nog niet opgelost
* 'Delay' ingevoegd bij testmethoden (2 seconden)
    * Voorkomt dat laadtijd grote impact heeft op resultaten
    * Verhoogt kans op slagen
* Korte stroomonderbreking, plaatsing van zonnepanelen
    * Tijd gebruikt om planning te bespreken (Ik en Peter)
    * Basispunten opgesteld, later met Mark in detail bespreken
* Oplossing gevonden voor combobox probleem
    * Opgelost door `SelectedIndex` te gebruiken i.p.v. `SelectedItem`
    * Kleine aanpassingen gedaan in `TestControlHandler` klasse om deze 'fix' door te wijzen

**Woensdag**

* Comboboxen verder bekijken, bij nader inzien nog niet 100% op punt
* Oplossing zoeken voor hierarchie probleem bij Coded UI Builder
    * Coded UI Builder mapt de controls verkeerd
    * Waarschijnlijk doordat er geen AutomationID's aanwezig zijn
    * Kan ook liggen omdat de controls 'Virtualized' zijn en nog 'Realised' moeten worden door manuele code
        * Oplossing die ik op het internet heb gevonden werkt niet voor UWP applicaties
    * Proberen via aanpassing van .config file van de Coded UI Builder om zo dieper in de hierarchie te controleren
        * Aanpassing leverde helaas niets op
        * Is enkel van toepassing voor WPF projecten
* Proberen uitzoeken welke de basisvereisten zijn om overzichtelijk en grondig Coded UI testing uit te kunnen voeren
* Op MSDN forum een vraag gepost i.v.m. Coded UI Testing op Windows 10 platform voor UWP applicaties
    * Voorlopig amper informatie te vinden
    * De informatie die we wel vinden zijn meestal met betrekking op Windows 8.1 en/of WPF applicaties
* Visual Studio 2015 Update 2 CPT bekeken
    * De updates met betrekking tot Testing zijn voornamelijk om 'debugging' makkelijker te maken
    * Niet echt iets dat Coded UI testing zal verbeteren

**Donderdag**

* Presentatie opgesteld op vraag van Mark
    * Staat van zaken uitleggen
        * Waar we staan
        * Waar we naartoe willen
        * Vereisten om makkelijker Coded UI Testing op applicatie uit te voeren
* Hiërarchie van applicatie digitaal gemaakt (via Google Docs)
    * Als .jpg bijgevoegd bij 'Overige Documenten'
* Meeting i.v.m. Status van project
    * Presentatie gegeven
    * Feedback gehad over werkpunten
    * Problemen aangekaart en overlegt naar oplossingen
    * Beter idee gekregen over het 'doel' van onze opdracht
    * Tegen maandag verslag over meeting indienen
        * Documenten worden toegevoegd aan 'Overige Documenten'
* Basis leggen van Guideline voor de tester:
    * Uiteindelijke doel van de stage
    * Guideline's voor toekomstige testers opstellen

**Vrijdag**

* Les - niet gewerkt

**Weekend**

* Niet gewerkt
