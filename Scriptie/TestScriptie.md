

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




### Resultaat
Het uiteindelijke resultaat, na een paar keer herwerken, zijn verschillende checklists.


#### General checklist

Deze checklist bevat de algemene paradigma's die op elke pagina aanwezig zijn. Deze zijn onderverdeeld in een aantal subcategorieën, die later verder onderverdeeld zullen worden.

Op de general checklist staat voor elke pagina een kolom, met daaronder voor elk paradigma of dit volledig getest is voor deze pagina of niet. Het volledig getest-zijn hangt af van de pagina specifieke checklist die we zo meteen gaan bespreken. 

Onderaan de general checklist staat ook een legende met een letter en een kleur voor elke toestand van het "getest-zijn" van een paradigma (bvb Y van Yes = getest, D van Do = nog te doen, E van Error = probleem bij testen,...)


#### Paradigm checklist

Aangezien het de bedoeling is dat we paradigma's gaan zoeken, en dan voor elk paradigma uitzoeken hoe we dit moeten gaan testen en nadien documenteren, leek het ons handig om een aparte paradigma-checklist te maken. Hier staan alle paradigma's, onderverdeeld tot op het niveau van specifieke scenario's, die getest moeten worden. Vervolgens staat er een kolom naast deze lijst, met dezelfde kleurcode als in de legende. Deze geeft dus aan of dit paradigma ge-analyseerd is en we dus weten hoe we dit moeten gaan testen. 

Wanneer er een nieuw paradigma bijkomt, zal deze dus altijd eerst op groen moeten komen in de paradigma-checklist, vooraleer we dit kunnen gaan testen op de rest van de pagina's. Uiteraard zullen we dit dan wel op één pagina al getest hebben, namelijk de pagina waarop we dit paradigma gevonden en ge-analyseerd hebben. 


#### Example-page + Page checklists

Vervolgens komen we dan tot de pagina-specifieke checklist. Hierin staan de algemene paradigma's van de general checklist verder onderverdeeld zoals bij de paradigma-checklist. Bovenaan splitsen we de pagina dan op in al zijn aparte control's, die we gaan gebruiken om tests uit te voeren. Voor elke control hebben we ook de parent-control gedocumenteerd, zodat het duidelijk is over welke control het gaat. 

Op de example-page hebben we enkele control's gezet die op elke pagina terugkomen, zoals de backbutton of de home-knop. 

Wanneer we dus een nieuw paradigma vinden, zal dit eerst in de paradigm checklist terecht komen. Vervolgens zetten we dit paradigma over op de example-page en nadien op alle andere page-checklists. Wanneer we beginnen met een nieuwe pagina te testen en dus een page-checklist maken voor deze pagina, kunnen we gewoon rechtstreeks de example-page kopiëren en plakken, en vervolgens alle pagina-specifieke control's toevoegen.

Op de page checklist staat opnieuw aangeduid welk paradigma getest is en welk niet, volgens de kleurcode in de legende op de general checklist, met als verschil dat deze hier nog eens onderverdeeld worden per control. We analyseren dus voor elke control welk paradigma van toepassing is en duiden dan de status aan volgens de kleurcode. 


#### Full checklist

In onze guideline staat de volledig uitgeschreven versie van de checklist. Hierin staat voor elk puntje in de lijst beschreven wat het exact inhoud onder "what?". Dit is een korte beschrijving van wat er getest wordt en wat de elementen die in de test gebruikt worden horen te doen. 

Vervolgens staat onder "how?" een stappenplan beschreven dat je moet volgen om die specifieke test uit te voeren. 

In deze checklist proberen we zo specifiek en zo duidelijk mogelijk te zijn, zodat het ook voor een eventuele opvolger helemaal duidelijk is wat exact de bedoeling is van deze test en wat de verschillende control's en elementen horen te doen wanneer ze gebruikt worden op de beschreven manier. 

##### 1. Content

In deze sectie gaan we alle paradigma's beschrijven die betrekking hebben tot de inhoud van control's en tekstvelden. Alle informatie die in de user-interface beschikbaar is die uit de database komt, of aangepast kan worden, komt onder het paradigma "content". 

Er zijn 4 verschillende handelingen die uitgevoerd kunnen worden op info in de control's. Deze 4 staan beter bekend als de CRUD-acties. (Create, Read, Update, Delete)

###### Create

"Create" wil zeggen dat je nieuwe data gaat toevoegen aan de database. Een voorbeeld hiervan is het toevoegen van een nieuwe patiënt of een nieuwe studie. Je vult alle velden in die relevant zijn en klikt dan op "toevoegen", wat ervoor zorgt dat er in de database een patiënt bijkomt die nog niet bestond.

Om dit paradigma te testen, moeten we eerst gaan uitzoeken op welk deel van de applicatie het toevoegen van nieuwe data invloed heeft. Vervolgens kunnen we dan data toevoegen (door tekstveldjes in te vullen, staat beschreven in de guideline). tot slot moeten we dan gaan controleren of de data veranderd is waar deze moest veranderen. Voor die controle hebben we een "Read"-functie nodig, dus create en read zijn deels verweven met elkaar. 

>Voorbeeld: Ik voeg een nieuwe studie toe. Dit doe ik door een overlay te openen waarin een aantal tekstveldjes staan en een knop "toevoegen". Ik vul deze veldjes in en klik op de knop. Vervolgens navigeer ik naar de pagina waar de lijst met alle studies staat en loop ik over deze lijst om te controleren dat de studie die ik net heb toegevoegd aanwezig is in de lijst. Wanneer al deze stappen succesvol zijn uitgevoerd, is mijn test geslaagd.

###### Read

"Read" wil zeggen dat je gaat controleren of bestaande data, die aanwezig zou moeten zijn in de user-interface, ook effectief aanwezig is. Om dit te testen moeten we gaan uitzoeken hoe we enerzijds tekstvelden en eventueel andere control's kunnen gaan uitlezen, en anderzijds hoe we deze kunnen vergelijken met de effectieve data in de database. 

Er zijn verschillende scenario's die onder "Read" vallen.



***Weergegeven data***

Buiten het zoek-algoritme, welke een speciaal geval van "read" is, bestaat een read-test eruit om te gaan controleren dat de data die weergegeven wordt in de user-interface correct is. 

Een voorbeeld is dat we naar de TrialHubPage navigeren. Hierin staat alle data die te maken heeft met een bepaalde studie. Deze pagina gedraagt zich qua functionaliteit altijd hetzelfde, maar de data die weergegeven wordt hangt af van de studie waarop we geklikt hebben. De bedoeling van de read-test is dan om te gaan controleren of de data die we te zien krijgen in de user-interface dezelfde is als de data die we verwachten na een bepaalde navigatie. 

We kunnen dit enerzijds hardcoded controleren, door eerst manueel de navigatie uit te voeren en dan alle data die we zien in code te schrijven als assertions (assertions worden later uitgelegd). Anderzijds kunnen we datadriven tests schrijven, waarbij de data die we gebruiken in de test afkomstig is van een database (wordt ook later uitgelegd). 

###### Update/delete

Update wil zeggen dat je reeds bestaande data gaat aanpassen en deze aanpassingen opslaan.

Delete is het verwijderen van bestaande data in de database. 

Update en delete vallen binnen deze applicatie onder dezelfde tab, aangezien het deleten van data in de UI een update naar de database stuurt met een indicatie dat deze data niet meer bestaat. 

###### Custom

Onder deze tab gaan we alle speciale gevallen plaatsen die nog bij content horen. Onder deze speciale gevallen horen bijvoorbeeld: het zoek-algoritme, de partpickers (wordt zo meteen besproken),...

***Zoek-algoritme***

Dit het algoritme dat de zoekfunctie doet werken. Er zijn 3 verschillende testscenario's die we hierop gaan moeten uitvoeren.
1. We moeten testen of alle mogelijke parameters waarop we kunnen zoeken zoekresultaten opleveren. Het kan bijvoorbeeld zijn dat het zoekalgoritme zo is ingesteld dat je kan zoeken op de studienaam, patientnaam,... 

  Het soort parameters waarop we kunnen zoeken gaan we zelf analyseren. Nadien schrijven we hier tests voor.
2. Vervolgens moeten we controleren of alle zoekresultaten die weergegeven worden het zoekwoord bevatten dat we hebben ingegeven. Hiervoor moeten we een speciaal soort read-functie schrijven, waar we later meer over zullen vertellen. 
3. Als derde moeten we controleren of alle objecten in de database, die voldoen aan onze zoekterm, ook effectief worden weergegeven. Het is één ding dat alle zoekresultaten de zoekterm bevatten, maar het zou natuurlijk altijd kunnen dat een aantal zoekresultaten die in de database wel effectief bestaan, niet worden weergegeven. In dat geval zou de vorige test wel werken, maar zou er toch nog een fout in het zoek-algoritme zitten. Vandaar dat deze derde test noodzakelijk is om het zoek-algoritme volledig te testen.

***Part-pickers***

Part-pickers zijn speciale knoppen waarmee je een datum of een tijd kan instellen. Door op de knop te klikken, verschijnt er een popup-venster. In dit venster staan een aantal verschillende tabs. Elk van deze tabs bevat een aantal blokken met waarden gaande van bvb 0-30/maandag-vrijdag/januari-december/... Door over deze blokken te hoveren met de muis en te scrollen, verschuiven ze, waardoor je de waarde aanpast. Er is altijd 1 van tab geselecteerd die je kan aanpassen. Bij het hoveren met de muis wordt de tab waarover je hovert automatisch geselecteerd. Je kan echter ook met de pijltjestoetsen van links naar rechts gaan om andere tabs te selecteren. Als je met de pijltjestoetsen van boven naar beneden gaat verschuif je de geselecteerde tab altijd met 2 waardes per keer. Met het scroll-wiel van de muis verplaats je de geselecteerde tab met 1 waarde per keer. 

Onderaan het popup-venster staan 2 knoppen, een vinkje en een kruisje. Door op het vinkje te klikken accepteer je de datum/tijd die je net hebt ingesteld en zal deze verschijnen in de Part-picker waarmee je net gewerkt hebt. Door op het kruisje te klikken wordt de verandering geanuleerd en blijft de waarde van de part-picker staan zoals die voordien stond. 

De aangepaste waarde accepteren kan ook door op enter te klikken. 

Telkens je een waarde accepteert/weigert verdwijnt het popup-venster terug. 

Het testen van deze partpickers is tot nu toe nog niet gelukt, aangezien we geen enkele manier hebben gevonden om in testcode de partpicker te kunnen zien. 

##### 2. Navigations

Het volgende grote paradigma zijn de navigaties binnen de applicatie. Onder navigaties verstaan we alle acties die ervoor zorgen dat de applicatie een ander scherm opendoet. Ook de zoekfunctie behoort tot navigaties, aangezien we hier ook naar een ander scherm gaan. Het verschil tussen de CRUD-tests voor de zoekfunctie en de navigatietests is echter dat we bij de navigatietests niet gaan controleren welke zoekdata weergegeven wordt, maar enkel of we op de zoekresultatenpagina terecht komen (ClinicSearch). 

Om een navigatie te testen zijn er dus in grote lijnen 2 handelingen die we moeten uitvoeren. Enerzijds moeten we de actie uitvoeren die zorgt voor de navigatie (meestal klikken op een control). Anderzijds moeten we gaan controleren of de juiste pagina wordt geopend nadat deze actie is uitgevoerd. 

Deze controle kan voor elke pagina anders zijn, maar de werkwijze is steeds dezelfde: we zoeken een control of een set van controls die uniek zijn voor de desbetreffende pagina, en controleren dan of deze controls aanwezig zijn, of dat ze de juiste waarde bevatten (bvb titels). 

###### Soorten navigations

Paradigmagewijs zijn alle navigations natuurlijk hetzelfde. Maar in manier van testen hebben we de navigaties verder onderverdeeld in sub-paradigma's, waarbij elk sub-paradigma een lichtjes andere manier van testen omvat. 

***Variabele controls***

Hieronder verstaan we het concept van een lijst, waarin zich allemaal verschillende gevallen bevinden van een bepaald opject. Dit kan bijvoorbeeld zijn: een lijst van studies, een lijst van patienten,... Het aantal items in de lijst staat nooit vast, aangezien het afhangt van hoeveel studies/patienten/... er zich in de database bevinden. Dit kan voortdurend wijzigen. Ook de tekst op deze controls hangt af van de data in de database. 

Als je op één van de controls in deze lijst klikt, zal je altijd op dezelfde pagina terecht komen. Hoe deze pagina is ingevuld hangt echter af van de control waarop je geklikt hebt.

Om dit te testen moeten we dus enerzijds zorgen dat we kunnen klikken op de control, en nadien moeten we controleren of de titel van de pagina naarwaar we genavigeerd zijn overeen stemt met de control waarop we geklikt hebben. 


***Vaste controls***

Vaste controls zijn controls die altijd op een pagina aanwezig zijn, ongeacht de data in de database. De navigatie is uniek voor elk van deze controls. Soms kan het wel zijn dat meerdere vaste controls naar dezelfde pagina navigeren maar ze zorgen dan elk apart voor een andere state van de desbetreffende pagina. Ze openen bijvoorbeeld allemaal een aparte tab van dezelfde pagina of zorgen ervoor dat de pagina anders ge-ordend is. 

Het aantal vaste controls op een pagina is altijd dezelfde, en deze staan ook altijd op dezelfde plaats gepositioneerd, enkel kan het zijn dat de tekst in deze controls varieert op basis van de data die zich in de database bevind. 

Om deze controls te testen moeten we ook klikken op de control, maar de concrete klikfunctie voor deze testmethode zal lichtjes verschillen van de variabele controls, aangezien de manier om toegang te krijgen tot de control anders zal zijn. De controle of de navigatie juist gebeurd is is opnieuw een controle op de titel van de pagina waarnaar we genavigeerd hebben, en eventueel een controle op de state van deze pagina (bvb: staat de juiste tab open? Staan de elementen in de pagina juist ge-ordend? ...).

***Zoekfunctie***

De zoekfunctie vanuit de ClinicHubPage kan ook beschouwd worden als een navigatie. Als we puur het navigatiegedeelte gaan testen hiervan, moeten we geen rekening meer houden met het algoritme dat zorgt voor de correcte zoekresultaten, maar enkel met het feit dat er genavigeerd wordt naar de zoekresultatenpagina. 

Opnieuw zal dit een klein verschil geven in het schrijven van code, aangezien we deze keer niet moeten klikken op een control, maar eerst een zoekwoord moeten ingeven en nadien enteren of klikken op het vergrootglas naast het zoekvak. 

De controle gaan we opnieuw doen op de titel van de zoekresultatenpagina. 

***Hyperlink-navigatie***

Op pagina's die data bevatten die te maken heeft met één bepaalde studie of één bepaalde patiënt (of eventueel nog andere objecten die we in de toekomst nog zouden kunnen tegenkomen), staat bovenaan steeds een hyperlink met de naam van dit object. Als we hierop klikken, komen we op de overzichtpagina van dat object (bvb studie->TrialHub, patiënt->PatientHub, ...)

Het schrijven van navigatiecode zal hier opnieuw lichtjes verschillen omdat de toegankelijkheid van de hyperlink lichtjes verschilt van de vorige navigaties. De controle gebeurt opnieuw op de titel.

>Voor al deze verschillende navigaties gaan we steeds onderzoeken hoe we de control kunnen vinden in code, hoe we een verwachte waarde kunnen creëren aan de hand van welke we kunnen controleren of de juiste navigatie uitgevoerd werd, hoe we dan deze control kunnen gebruiken (meestal klikken, aangezien de verschillende functionaliteiten zoals tab-enter bij navigaties nog niet van belang zijn, deze komen later terug bij functionality) en hoe we dan kunnen controleren dat deze verwachtte waarde aanwezig is na de navigatie. Na elk van deze tests gaan we dan ook nog de omgekeerde test doen met de backbutton, opnieuw met een verwachtte waarde en een effectieve waarde. Dit zorgt ervoor dat alle mogelijke back-navigaties in de applicatie uiteindelijk getest zijn. Dit geheel gaan we zoveel mogelijk in één grote functie per soort navigatie proberen te schrijven, zodat als we nadien dit soort navigatie nog tegenkomen, we gewoon éénmaal de geschreven functie kunnen aanroepen en dus geen extra werk meer hebben.

##### 3. States

De verschillende states van een pagina zijn de verschillende soorten toestanden waarin die pagina zich kan bevinden. Dit zijn:
* Semantic zoom
  * Zoomed in
  * Zoomed out
* Overlay
  * Overlay is open
  * Overlay is gesloten
* Filtering search
  * Verschillende orderingen
* Multiselect
  * Meerdere geselecteerde elementen

###### Semantic zoom

De semantic zoom is een parent-control, die de mogelijkheid bezit om zichzelf in en uit te zoomen. Meestal bevind er zich in de semantic zoom een hub, die onderverdeeld wordt in verschillende hubsecties. Dit zijn allemaal aparte blokken waarin zich een aantal controls bevinden. Bovenaan een hubsectie staat dan de titel van deze hubsectie. Het aantal hubsecties is niet van belang, en ook het aantal controls die in een hubsectie geimplementeerd worden is niet van belang. Dat zijn er zoveel of zo weinig als je zelf wil. 

Wanneer we naar een pagina navigeren met een semantic zoom, staat deze automatisch ingezoomd. Alle hubsecties zijn dan volledig zichtbaar met hun titel en alle controls. Uitzoomen kunnen we doen door "Ctrl-", Ctrl & scrollen, klikken op de hubsectie-titels, PgUp/PgDn&Enter en Tab&Enter. Wanneer we uitzoomen verdwijnen alle volledige hubsecties en komt er in de plaats een lijst met listitems tevoorschijn, waarin alle titels van de hubsecties weergegeven zijn. Zo kunnen we makkelijk navigeren naar een hubsectie die helemaal rechts op het scherm staat en dus nog niet zichtbaar was in de zoomed-in state (toen moesten we er naartoe scrollen). 

Het terug inzoomen kan op dezelfde manier, door te klikken op de listitems, "Ctrl+", Ctrl & scrollen, , PgUp/PgDn&Enter en Tab&Enter. Als we terug inzoomen op een bepaalde hubsectie zal deze links van het scherm getoond worden. 

Wat we dus moeten testen is dat deze semantic zoom altijd in- en uitzoomt wanneer we de beschreven acties uitvoeren. We gaan dit opnieuw één keer volledig manueel analyseren, en nadien proberen op zo een manier te schrijven in een functie dat we deze functie voor alle pagina's die een semantic zoom bevatten kunnen gebruiken zonder moeite. 