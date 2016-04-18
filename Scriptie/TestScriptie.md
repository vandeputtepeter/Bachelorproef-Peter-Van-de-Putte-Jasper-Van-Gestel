

#Scriptie


##Hiërarchical navigation design
In de eerste fase van onze opdracht hebben we een hiërarchisch design opgesteld van alle navigaties die in de applicatie Maät mogelijk zijn. Dit hebben we gedaan door gewoon alle navigaties uit te proberen en dan de documenteren welke knop naar welke pagina en welke subpagina leidt. Zo konden we niet alleen een handig overzicht creëren waarin we kunnen zien welke schermen het belangrijkste zijn en welke voorlopig minder belangrijk zijn, maar leerden we ook meteen werken met de applicatie, wat voordelig uitkomt bij het verdere verloop van het project. 

Het hiërarchisch design vertrekt vanuit de ClinicHubPage, welke de hoofdpagina is waarop we terecht komen als we de applicatie starten. Van hieruit is een takstructuur getekend naar alle pagina's waarnaar we kunnen navigeren vanuit de ClinicHubPage. Vervolgens hebben we voor elke knelpuntpagina (pagina's van waaruit we naar nog meerdere andere pagina's kunnen navigeren) een nieuw bestand gemaakt waarin we dezelfde werkwijze volgden als in het eerste document, namelijk alle al deze pagina's laten vertakken uit de respectievelijke pagina. 

Op elke tak hebben we ook geschreven welke knop of handeling ervoor zorgt dat we op die specifieke pagina terecht komen. Ook hebben we per pagina de belangrijkheid aangeduid in het testgebeuren. Sommige pagina's zijn namelijk nog niet af, of zijn zelfs nog in hun beginfase. Dit zijn dan pagina's die in het totale testproject minder prioriteit hebben tov de pagina's die wel al af zijn of belangrijke informatie bevatten. 


##Method naming
In dit onderdeel beschrijven we een aantal regels, door ons opgesteld, waaraan de namen van alle geschreven testmethodes moeten voldoen. De visie op deze naamgeving is dat je aan de naam van een testmethode alleen alle informatie over wat er getest wordt kan afleiden. De reden hierachter is dat wanneer we een verslag terug krijgen van alle uitgevoerde tests, en er zijn bepaalde tests gefaald, we meteen kunnen zien welk paradigma in de applicatie niet werkt zoals het hoort te werken, en dit door gewoon de naam van de testmethode te lezen. Waarom dit paradigma gefaald is wordt weggeschreven in een test-log, waar we later op terugkomen. 

Na een brainstorm sessie zijn we tot het volgende resultaat gekomen:

Page name + Paradigm (+ Context) (+ Xaml Control Type Property) (+ optional info)

* "Page name" duidt de pagina aan waarin de test zich bevind. Dit is dus bijvoorbeeld "ClinicHub", "ClinicSearch", "TrialHub", "PatientScript",... Deze parameter moet altijd in het begin van de testmethode geschreven worden, omdat we dan meteen weten op welke pagina er zich een bug bevind indien de test faalt.
* "Paradigm" duidt op het paradigma dat getest wordt. Dit is een denkwijze/werkwijze die de applicatie volgt om tot een bepaald resultaat te komen. Paradigma's kunnen zijn: Navigate (navigeer naar een andere pagina), Check (controleer een bepaalde waarde),... Deze parameter komt meteen na de pagina om een duidelijke afbakening te zien van wat er wel/niet werkt op welke pagina.
* "Context": Dit is een optionele parameter, die meer specifiek aanduidt welke control of welk deel van de geteste pagina getest wordt. Wanneer je bijvoorbeeld meerdere lijsten hebt, die elk een lijst van zoekresultaten bevatten, en waarbij elke lijst een ander soort zoekresultaat bevat, kan je "Context" interpreteren als het woord dat duidelijk maakt om welke lijst het gaat. 
* "Xaml Control Type property" duidt op het type control dat getest wordt. Wanneer je bijvoorbeeld bij context al hebt aangeduid welk subdeel van de applicatie getest wordt, kan het nog steeds zijn dat dit subdeel meerdere control's of control types bevat. Deze parameter duid dan duidelijk aan om welke control het gaat (indien er één specifieke control getest wordt). 
* "Optional info" is de laatste extra info die je bij sommige tests nodig hebt om volledig duidelijk te maken wat er exact getest wordt. Dit kan allerhande informatie zijn zoals bijvoorbeeld een bepaalde state waarin de pagina zich bevind voor die specifieke test.


##File structure
In dit onderdeel hebben we een aantal regels opgesteld voor de onderverdeling van de verschillende testprojecten. De visie hier is dat we niet alle tests van het gehele project in 1 groot project mogen schrijven (wat de onderhoudbaarheid nagenoeg onmogelijk maakt), maar dat we ook niet voor elke testmethode een nieuw project mogen schrijven, aangezien er dan teveel files zouden ontstaan. Een gulden middenweg die we gevonden hebben na enkele besprekingen met onze promotors, is dat we voor elk hoofdparadigma, per pagina, een nieuw testproject schrijven, en dat we voor elke pagina één UIMap maken die gebruikt wordt in alle testprojecten voor deze pagina. Ook hebben we na overleg beslist dat we bij elke pagina die verschillende subtabs bevat, elke subtab als één volledige pagina beschouwen. Deze worden dus onderverdeeld alsof het aparte pagina's zijn. 

Door bovenstaande regels in acht te nemen, hebben we volgende file structuur opgebouwd: 
* Screens
  * General UIMap
  * Partial parent .cs file
  * .csv global scenarios
  * Category (clinic,…)
    * .csv categorical scenarios
    * Page (contactspage,….)
      * UImap
      * .csv local scenarios
      * .cs files per category
        * States
        
        All tests regarding the different states of a page

        * Navigation

        All tests regarding forward navigations from a page and backwards navigation to the page

        * Functionality
        All tests regarding functionality/interfunctionality of controls

        * Content	
        All tests regarding data in the database
        

## Checklist testing

### Overzicht

Dit is de kern van het project. Het is de bedoeling dat we een lijst opstellen waarin alle paradigma's die getest moeten worden onder elkaar staan weergegeven. In de Testing Guideline staat voor elk element in deze lijst beschreven hoe dat bepaald paradigma moet getest worden, en in een apart excel document staat voor elke pagina elk paradigma opgelijst onder elkaar. Op die manier kunnen we in een matrix makkelijk aanduiden of een bepaald paradigma volledig getest is of niet, op de respectievelijke pagina. 


### Werkwijze

We beginnen met de basispagina’s die de meest gebruikte paradigma's/control ’s bevatten (die zo goed als overal zullen terugkomen). 

Voor elke gevonden control/paradigma  zoeken we dan uit hoe we deze zo efficiënt mogelijk kunnen testen. Deze methode documenteren we dan zodat wij, en onze eventuele opvolgers, deze altijd terug kunnen raadplegen wanneer nodig (voor volgende pagina’s etc.). We documenteren ook voor de pagina die we aan het testen zijn welke control ’s en paradigma's reeds getest zijn, tot we ze allemaal hebben gehad. Op dit moment wordt de pagina als volledig getest verklaard.
Indien we op een volgende pagina weer een nieuwe control/paradigma tegenkomen, zetten we deze bij onderaan onze checklist met gevonden control ‘s/paradigma's. Het is dan weer opnieuw de bedoeling om uit te zoeken hoe we deze kunnen testen en alle voorgaande pagina’s opnieuw af te gaan en te controleren of ook dit element aanwezig is op de pagina en te testen indien nodig, zodat we de pagina weer als getest kunnen verklaren. 













