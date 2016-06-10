# Logboek - _Jasper Van Gestel_

### Week 1 (15/2/'16 - 21/2/'16)

**Maandag**

* Kennismaking
* Uitzoeken hoe Coded UI Testing juist werkt
* Kleine applicatie maken en hier tests op uitvoeren
* Steeds groter en complexer maken
* Bekijken van Pluralsight [video](https://app.pluralsight.com/library/courses/codedui-test-automation/table-of-contents) om betere basis te hebben

**Dinsdag**

* Verder kijken van video(wegens ziekte van begeleider)
* Coded UI Tests uitvoeren op 'Pokédex' applicatie (ouder schoolproject)
* UI test scenario starten vanuit Excel-file (Keyword driven UI test)
    * Basismethoden geschreven
    * Link met Excel file faalt steeds, bezig met oplossing te zoeken

**Woensdag**

* Testing op Excel gestaakt
    * Probleem met Excel 2016 en VS2015 link
    * Eventueel verder bekijken in de toekomst
* Testing op Universal Applicaties
    * Applicatie aangemaakt (AppTestWin10)
    * Gebeurt anders dan bij eerdere versies
    * Kan niet ge-'record' gebeuren
* Eerste kennismaking met het 'Maat' project
    * Veel download, installatie en 'build'tijd nodig gehad
    * Toegevoegd aan project via eigen branch
        * Bedoeling om alle tests hier te maken
        * Controle of tests hier werken
        * 'Main' binnenhalen (geupdate versie) --> Controle op 'errors'
        * Bij werkende versie --> alles 'mergen' naar 'main'
    * Eerste methode geschreven
    * Werkt maar half --> problemen bij opstarten van testapplicatie

**Donderdag**

* Testmethode van gisteren aangepast --> Werkt nu volledig
    * Probleem zat bij opstart
        * Opgelost via `Process` klasse van `System.Diagnostics`
        * Eerste Mijlpaal bereikt (Yay!)
    * Bleek ook een probleem bij vinden van controls
        * Opgelost met `WaitForControlEnabled()` methode
* Meer testmethodes geschreven voor de eerste hub pagina ('ClinicHub')
* Parent klasse gemaakt,`TestControlHandler`, die methodes bevat om Control Events te vereenvoudigen
    * `ClickControl()` --> Click events (Knoppen, etc)
    * `EditControl()` --> Editable events (Textboxes, etc)
* Code Guidelines gekregen en bekeken
    * In de toekomst van het project rekening mee houden
    * Meeste code was echter al op juiste wijze geschreven

**Vrijdag**

* Les - Niet gewerkt

**Weekend**

* Niet gewerkt
