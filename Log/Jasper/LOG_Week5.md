# Logboek - _Jasper Van Gestel_

### Week 5 (14/3/'16 - 20/3/'16)
**Maandag**

* Voorbereiden van presentatie 'stand van zaken'
* ClinicContacts combobox controls aangepakt
  * Autonome methode geschreven om alle mogelijke opties te testen
  * Probleem bij 4de combobox --> kan niet worden gevonden via CUIB (Coded UI Builder)
    * Opgelost --> maar tijdens test wordt de control toch nog niet gevonden
* Documenteren
* Presentatie / meeting
  * Verslag meeting uittypen
  * Woensdag nieuwe, korte presentatie --> Matrix opstellen voor duidelijke situatieschets
* Herstructureren van bestaande matrix
  * Checklist grondig uitwerken van scratch

**Dinsdag**

* Checklist aan het herwerken
  * Verder doen van gisteren
    * Veel tijd in gestoken
    * Gaat ons later helpen om overzicht te bewaren
* Overleg met Peter over beste methode om data te presenteren
* Overleg met Peter over hoe grotere methoden implementeren
* Slides voor woensdag opstellen
* Guidelines bijwerken
* Bugs en problemen documenteren
* ClinicContactsPage klaarmaken om morgen verder testing op te doen
  * Noteren van checklist items
  * Documenteren van controls die gebruikt worden op deze pagina

**Woensdag**

* Uitzoeken hoe we mapping beter kunnen behandelen
  * Geprobeerd een aparate klasse te maken die alle mapping per pagina voor zich nam
    * Niet gelukt
    * Ging enkel wanneer ik de UI Map ```static``` maakte
  * Voorlopig even opzij gezet
    * Later vandaag nog eens bekijken
* Bekijken van ```BaseClassCodedUI``` --> momenteel te groot aan het worden
  * Opsplitsen in meerdere 'partial' klassen
    * Partial klasse per 'paradigma-categorie'
      * Content --> Alles dat verificatie van data omvat
      * Navigations --> Alles dat navigatie omvat
      * States --> Alles dat behandeling van verschillende states omvat
      * Functionality --> Alles dat interactie met controls omvat
    * De 'main' pagina bevat alle methoden die een basis vormen voor alle andere methoden binnen de base klasse
* ClinicContacts geeft teveel problemen
  * Problemen zoals:
    * Niet kunnen selecteren van nodige elementen
      * ComboBox 'Volgens Taak' wordt soms gevonden
      * Titels van Groups kunnen niet geselecteerd worden
    * Onvolledige pagina (sommige elementen werken nog niet)
    * Etc..
  * Links laten liggen en doorgaan met pagina's die wel 'meewerken'
* Presentatie Checklist/Guideline verzet naar maandag

**Donderdag**

* Vertrek naar CeBit
  * Dag wordt volgende week ingehaald

**Vrijdag**

* Bezoek CeBit
  * Verslag bij overige documenten

**Weekend**

* Omzetten van Google Docs document naar markdown file
  * Voortgangsverslag