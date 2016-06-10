# Logboek - _Jasper Van Gestel_

### Week 4 (7/3/'16 - 13/3/'16)
**Maandag**

* Refracturing en code cleaning
* Tests die vorige week allemaal klaar waren nu uitgebreid
  * Vorige week --> 'Click'-versies
  * Vandaag --> 'Enter' versies
* Zorgen dat alle tests overeenkomen met de juiste userinput
  * De tests juist nabootsen
    * Als je op een knop moet klikken die niet in beeld staat
      * Eerst scrollen naar de knop
      * Dan pas klikken
* Documentatie bijgewerkt
  * Noteren hoe Coded UI Testing ongeveer in elkaar zit
  * In hoevere wij daar ervaring mee hebben
  * Snapshots genomen en bijgeplaatst

**Dinsdag**

* Documenteren van errors / problemen / fouten binnen de applicatie
* 'File structure' aangevuld
  * Documetatie omtrent bedoeling van elke .cs file
* Duidelijkere checklist opgestelt (specifiek per pagina)
* `BaseClassCodedUI.Common` aangepast zodat deze compatibel was met de veranderingen die recent doorgevoerd zijn in de andere partial klasse `BaseClassCodedUI`
  * Halvering van de code als resultaat
* SemanticZoom methode bekeken
  * Werkt voorlopig enkel via Ctrl + scroll
  * Ctrl + '+' / Ctrl + '-' werkt, maar niet zoals het hoort
* Achterstand op documenteren vandaag redelijk goed bijgebeend
* Code verder autonoom gemaakt
  * Controls die vroeger als 'blocked by other control' beschreven werden worden nu omzeilt door de `GetMiddleOfControl`methode, die een Point teruggeeft waar de muis dan wel op kan klikken / hoveren
* SemanticZoom bijgewerkt
  * Doet nu controle op hubsecties

**Woensdag**

* Jobbeurs AP / KDG

**Donderdag**

* Uitbreiden van SemanticZoom tests
  * Controle op navigatie naar hubs
  * 'Click' klikfuncties
  * 'Ctrl & +' / 'Ctrl & -' klikfuncties
  * 'Ctrl & +' / 'Ctrl & -' zoomfuncties
* Alle Studies knop 'Enter' functie methode herschreven
* BaseClass wijzigingen
  * `GoToControl` methode toegevoegd als verbetering van opzoekfunctie
    * Hoe zoeken naar lijstitem met 'Arrow Keys' is nu beter
    * Zoekt eerst het eerste item in de lijst en keert dan om naar het laatste item in de lijst
      * Blijft zoeken naar het 'target' in beide richtingen
* `ZoomOutSemanticZoom` geschreven met andere parameters
  * Klik functies
* `ZoomInSemanticZoom` aangevuld
  * Klik functies
* Nieuwe Actions toegevoegd aan 'Action' enum
  * CtrlScroll (Ctrl + scrollen)
  * CtrlKey (Ctrl in combinatie met andere key toets)
* Documenteren van informatie / progressie
  * Bekijken van feedback op 'Plan van aanpak'
  * Verbeteringen bespreken
  * Maandag 14/03 nieuwe presentatie over vooruitgang

**Vrijdag**

* Thuis werken
  * Dag inhalen van woensdag (Jobbeurs)
* Documentatie aanvullen
  * Achterstallige documentatie inhalen
    * Moet meer noteren --> duidelijker om te volgen / draad oppikken
  * Aanvullen van checklist in duidelijke stijl
* Afwerken van checklist voor ClinicHub
  * Klaar buiten de niet geïmplementeerde en incomplete stukken
* Checklist aangevuld bij ClinicContacts
* Voorbereidingen ClinicContacts
* Voorbereidingen presentatie 14/03

**Weekend**

* Niet gewerkt