
# Testing checklist

## Overzicht

Dit is de kern van het project. Het is de bedoeling dat een lijst wordt opgesteld waarin alle paradigma's die getest moeten worden onder elkaar staan weergegeven. In de "testing guideline" staat voor elk element in deze lijst beschreven hoe dat bepaald paradigma moet getest worden, en in een apart excel document staat voor elke pagina elk paradigma opgelijst onder elkaar. Op die manier wordt in een matrix makkelijk aangeduid of een bepaald paradigma volledig getest is of niet, op de respectievelijke pagina. 

>Ondertussen is er een automation van dit process in ontwikkeling, we hopen deze nog af te hebben voor de stage afgelopen is, het gaat om een applicatie die twee XML documenten neemt en deze verwerkt tot een HTML document die weergeeft in hoevere de applicatie getest is. Eén van de input XML documenten wordt dagelijks gegenereerd door het automatische buildprocess dat 'snachts in werking treed (De DOBT of build-straat). Het andere XML document wordt opgestelt door de gebruiker die hierin beschrijft welke dingen getest moeten worden. De applicatie moet deze twee documenten overlapen en weergeven in een HTML document in hoevere er getest is geweest op de gewenste plaatsen van de applicatie.

## Werkwijze

Er wordt gestart met de basispagina’s die de meest gebruikte paradigma's/control ’s bevatten (die zo goed als overal terugkomen). 

Voor elke gevonden control/paradigma wordt dan ge-analyseerd hoe deze zo effecient mogelijk getest kan worden. Deze methode wordt dan gedocumenteerd zodat wij, en onze eventuele opvolgers, deze altijd terug kunnen raadplegen wanneer nodig. We documenteren ook voor de pagina die we aan het testen zijn welke control ’s en paradigma's reeds getest zijn, tot we ze allemaal hebben gehad. Op het moment dat alle paradigma's op alle controls die deze paradigma's toepassen getest zijn, wordt de pagina als volledig getest verklaard.

Indien we op een volgende pagina weer een nieuwe control/paradigma tegenkomen, zetten we deze bij onderaan onze checklist met gevonden control ‘s/paradigma's. Het is dan weer opnieuw de bedoeling om uit te zoeken hoe we deze kunnen testen en alle voorgaande pagina’s opnieuw af te gaan en te controleren of ook dit element aanwezig is op de pagina en te testen indien nodig, zodat we de pagina weer als getest kunnen verklaren. 

## Resultaat
Het uiteindelijke resultaat, na een paar keer herwerken, zijn verschillende checklists.

### General checklist

Deze checklist bevat de algemene paradigma's die op elke pagina aanwezig zijn. Deze zijn onderverdeeld in een aantal subcategorieën, die later verder onderverdeeld zullen worden.

Op de general checklist staat voor elke pagina een kolom, met daaronder voor elk paradigma of dit volledig getest is voor deze pagina of niet. Het volledig getest-zijn hangt af van de pagina specifieke checklist die we zo meteen gaan bespreken. 

Onderaan de general checklist staat ook een legende met een letter en een kleur voor elke toestand van het "getest-zijn" van een paradigma (bvb Y van Yes = getest, D van Do = nog te doen, E van Error = probleem bij testen,...)

### Paradigm checklist

Aangezien het de bedoeling is dat we paradigma's gaan zoeken, en dan voor elk paradigma uitzoeken hoe we dit moeten gaan testen en nadien documenteren, leek het ons handig om een aparte paradigma-checklist te maken. Hier staan alle paradigma's, onderverdeeld tot op het niveau van specifieke scenario's, die getest moeten worden. Vervolgens staat er een kolom naast deze lijst, met dezelfde kleurcode als in de legende. Deze geeft dus aan of dit paradigma ge-analyseerd is en we dus weten hoe we dit moeten gaan testen. 

Wanneer er een nieuw paradigma bijkomt, zal deze dus altijd eerst op groen moeten komen in de paradigma-checklist, vooraleer we dit kunnen gaan testen op de rest van de pagina's. Uiteraard zullen we dit dan wel op één pagina al getest hebben, namelijk de pagina waarop we dit paradigma gevonden en ge-analyseerd hebben. 

### Example-page + Page checklists

Vervolgens komen we dan tot de pagina-specifieke checklist. Hierin staan de algemene paradigma's van de general checklist verder onderverdeeld zoals bij de paradigma-checklist. Bovenaan splitsen we de pagina dan op in al zijn aparte control's, die we gaan gebruiken om tests uit te voeren. Voor elke control hebben we ook de parent-control gedocumenteerd, zodat het duidelijk is over welke control het gaat. 

Op de example-page hebben we enkele control's gezet die op elke pagina terugkomen, zoals de backbutton of de home-knop. 

Wanneer we dus een nieuw paradigma vinden, zal dit eerst in de paradigm checklist terecht komen. Vervolgens zetten we dit paradigma over op de example-page en nadien op alle andere page-checklists. Wanneer we beginnen met een nieuwe pagina te testen en dus een page-checklist maken voor deze pagina, kunnen we gewoon rechtstreeks de example-page kopiëren en plakken, en vervolgens alle pagina-specifieke control's toevoegen.

Op de page checklist staat opnieuw aangeduid welk paradigma getest is en welk niet, volgens de kleurcode in de legende op de general checklist, met als verschil dat deze hier nog eens onderverdeeld worden per control. We analyseren dus voor elke control welk paradigma van toepassing is en duiden dan de status aan volgens de kleurcode. 

### Full checklist (oud)

In onze guideline staat de volledig uitgeschreven versie van de checklist. Hierin staat voor elk puntje in de lijst beschreven wat het exact inhoud onder "what?". Dit is een korte beschrijving van wat er getest wordt en wat de elementen die in de test gebruikt worden horen te doen. 

Vervolgens staat onder "how?" een stappenplan beschreven dat je moet volgen om die specifieke test uit te voeren. 

In deze checklist proberen we zo specifiek en zo duidelijk mogelijk te zijn, zodat het ook voor een eventuele opvolger helemaal duidelijk is wat exact de bedoeling is van deze test en wat de verschillende control's en elementen horen te doen wanneer ze gebruikt worden op de beschreven manier. 

Merk op dat deze checklist later nogmaals veranderd is. Bij deze de uitleg over de eerste versie van de checklist (de uiteindelijke volgt nog): 

#### 1. Content

In deze sectie gaan we alle paradigma's beschrijven die betrekking hebben tot de inhoud van control's en tekstvelden. Alle informatie die in de user-interface beschikbaar is die uit de database komt, of aangepast kan worden, komt onder het paradigma "content". 

Er zijn 4 verschillende handelingen die uitgevoerd kunnen worden op info in de control's. Deze 4 staan beter bekend als de CRUD-acties. (Create, Read, Update, Delete)

##### Create

"Create" wil zeggen dat je nieuwe data gaat toevoegen aan de database. Een voorbeeld hiervan is het toevoegen van een nieuwe patiënt of een nieuwe studie. Je vult alle velden in die relevant zijn en klikt dan op "toevoegen", wat ervoor zorgt dat er in de database een patiënt bijkomt die nog niet bestond.

Om dit paradigma te testen, moeten we eerst gaan uitzoeken op welk deel van de applicatie het toevoegen van nieuwe data invloed heeft. Vervolgens kunnen we dan data toevoegen (door tekstveldjes in te vullen, staat beschreven in de guideline). tot slot moeten we dan gaan controleren of de data veranderd is waar deze moest veranderen. Voor die controle hebben we een "Read"-functie nodig, dus create en read zijn deels verweven met elkaar. 

>Voorbeeld: Ik voeg een nieuwe studie toe. Dit doe ik door een overlay te openen waarin een aantal tekstveldjes staan en een knop "toevoegen". Ik vul deze veldjes in en klik op de knop. Vervolgens navigeer ik naar de pagina waar de lijst met alle studies staat en loop ik over deze lijst om te controleren dat de studie die ik net heb toegevoegd aanwezig is in de lijst. Wanneer al deze stappen succesvol zijn uitgevoerd, is mijn test geslaagd.

##### Read

"Read" wil zeggen dat je gaat controleren of bestaande data, die aanwezig zou moeten zijn in de user-interface, ook effectief aanwezig is. Om dit te testen moeten we gaan uitzoeken hoe we enerzijds tekstvelden en eventueel andere control's kunnen gaan uitlezen, en anderzijds hoe we deze kunnen vergelijken met de effectieve data in de database. 

Er zijn verschillende scenario's die onder "Read" vallen.

######Weergegeven data

Buiten het zoek-algoritme, welke een speciaal geval van "read" is, bestaat een read-test eruit om te gaan controleren dat de data die weergegeven wordt in de user-interface correct is. 

Een voorbeeld is dat we naar de TrialHubPage navigeren. Hierin staat alle data die te maken heeft met een bepaalde studie. Deze pagina gedraagt zich qua functionaliteit altijd hetzelfde, maar de data die weergegeven wordt hangt af van de studie waarop we geklikt hebben. De bedoeling van de read-test is dan om te gaan controleren of de data die we te zien krijgen in de user-interface dezelfde is als de data die we verwachten na een bepaalde navigatie. 

We kunnen dit enerzijds hardcoded controleren, door eerst manueel de navigatie uit te voeren en dan alle data die we zien in code te schrijven als assertions (assertions worden later uitgelegd). Anderzijds kunnen we datadriven tests schrijven, waarbij de data die we gebruiken in de test afkomstig is van een database (wordt ook later uitgelegd). 

##### Update/delete

Update wil zeggen dat je reeds bestaande data gaat aanpassen en deze aanpassingen opslaan.

Delete is het verwijderen van bestaande data in de database. 

Update en delete vallen binnen deze applicatie onder dezelfde tab, aangezien het deleten van data in de UI een update naar de database stuurt met een indicatie dat deze data niet meer bestaat. 

##### Custom

Onder deze tab gaan we alle speciale gevallen plaatsen die nog bij content horen. Onder deze speciale gevallen horen bijvoorbeeld: het zoek-algoritme, de partpickers (wordt zo meteen besproken),...

######Zoek-algoritme

Dit het algoritme dat de zoekfunctie doet werken. Er zijn 3 verschillende testscenario's die we hierop gaan moeten uitvoeren.
1. We moeten testen of alle mogelijke parameters waarop we kunnen zoeken zoekresultaten opleveren. Het kan bijvoorbeeld zijn dat het zoekalgoritme zo is ingesteld dat je kan zoeken op de studienaam, patientnaam,... 

  Het soort parameters waarop we kunnen zoeken gaan we zelf analyseren. Nadien schrijven we hier tests voor.
2. Vervolgens moeten we controleren of alle zoekresultaten die weergegeven worden het zoekwoord bevatten dat we hebben ingegeven. Hiervoor moeten we een speciaal soort read-functie schrijven, waar we later meer over zullen vertellen. 
3. Als derde moeten we controleren of alle objecten in de database, die voldoen aan onze zoekterm, ook effectief worden weergegeven. Het is één ding dat alle zoekresultaten de zoekterm bevatten, maar het zou natuurlijk altijd kunnen dat een aantal zoekresultaten die in de database wel effectief bestaan, niet worden weergegeven. In dat geval zou de vorige test wel werken, maar zou er toch nog een fout in het zoek-algoritme zitten. Vandaar dat deze derde test noodzakelijk is om het zoek-algoritme volledig te testen.

######Part-pickers

Part-pickers zijn speciale knoppen waarmee je een datum of een tijd kan instellen. Door op de knop te klikken, verschijnt er een popup-venster. In dit venster staan een aantal verschillende tabs. Elk van deze tabs bevat een aantal blokken met waarden gaande van bvb 0-30/maandag-vrijdag/januari-december/... Door over deze blokken te hoveren met de muis en te scrollen, verschuiven ze, waardoor je de waarde aanpast. Er is altijd 1 van tab geselecteerd die je kan aanpassen. Bij het hoveren met de muis wordt de tab waarover je hovert automatisch geselecteerd. Je kan echter ook met de pijltjestoetsen van links naar rechts gaan om andere tabs te selecteren. Als je met de pijltjestoetsen van boven naar beneden gaat verschuif je de geselecteerde tab altijd met 2 waardes per keer. Met het scroll-wiel van de muis verplaats je de geselecteerde tab met 1 waarde per keer. 

Onderaan het popup-venster staan 2 knoppen, een vinkje en een kruisje. Door op het vinkje te klikken accepteer je de datum/tijd die je net hebt ingesteld en zal deze verschijnen in de Part-picker waarmee je net gewerkt hebt. Door op het kruisje te klikken wordt de verandering geanuleerd en blijft de waarde van de part-picker staan zoals die voordien stond. 

De aangepaste waarde accepteren kan ook door op enter te klikken. 

Telkens je een waarde accepteert/weigert verdwijnt het popup-venster terug. 

Het testen van deze partpickers is tot nu toe nog niet gelukt, aangezien we geen enkele manier hebben gevonden om in testcode de partpicker te kunnen zien. 

#### 2. Navigations

Het volgende grote paradigma zijn de navigaties binnen de applicatie. Onder navigaties verstaan we alle acties die ervoor zorgen dat de applicatie een ander scherm opendoet. Ook de zoekfunctie behoort tot navigaties, aangezien we hier ook naar een ander scherm gaan. Het verschil tussen de CRUD-tests voor de zoekfunctie en de navigatietests is echter dat we bij de navigatietests niet gaan controleren welke zoekdata weergegeven wordt, maar enkel of we op de zoekresultatenpagina terecht komen (ClinicSearch). 

Om een navigatie te testen zijn er dus in grote lijnen 2 handelingen die we moeten uitvoeren. Enerzijds moeten we de actie uitvoeren die zorgt voor de navigatie (meestal klikken op een control). Anderzijds moeten we gaan controleren of de juiste pagina wordt geopend nadat deze actie is uitgevoerd. 

Deze controle kan voor elke pagina anders zijn, maar de werkwijze is steeds dezelfde: we zoeken een control of een set van controls die uniek zijn voor de desbetreffende pagina, en controleren dan of deze controls aanwezig zijn, of dat ze de juiste waarde bevatten (bvb titels). 

##### Soorten navigations

Paradigmagewijs zijn alle navigations natuurlijk hetzelfde. Maar in manier van testen hebben we de navigaties verder onderverdeeld in sub-paradigma's, waarbij elk sub-paradigma een lichtjes andere manier van testen omvat. 

######Variabele controls

Hieronder verstaan we het concept van een lijst, waarin zich allemaal verschillende gevallen bevinden van een bepaald opject. Dit kan bijvoorbeeld zijn: een lijst van studies, een lijst van patienten,... Het aantal items in de lijst staat nooit vast, aangezien het afhangt van hoeveel studies/patienten/... er zich in de database bevinden. Dit kan voortdurend wijzigen. Ook de tekst op deze controls hangt af van de data in de database. 

Als je op één van de controls in deze lijst klikt, zal je altijd op dezelfde pagina terecht komen. Hoe deze pagina is ingevuld hangt echter af van de control waarop je geklikt hebt.

Om dit te testen moeten we dus enerzijds zorgen dat we kunnen klikken op de control, en nadien moeten we controleren of de titel van de pagina naarwaar we genavigeerd zijn overeen stemt met de control waarop we geklikt hebben. 

######Vaste controls

Vaste controls zijn controls die altijd op een pagina aanwezig zijn, ongeacht de data in de database. De navigatie is uniek voor elk van deze controls. Soms kan het wel zijn dat meerdere vaste controls naar dezelfde pagina navigeren maar ze zorgen dan elk apart voor een andere state van de desbetreffende pagina. Ze openen bijvoorbeeld allemaal een aparte tab van dezelfde pagina of zorgen ervoor dat de pagina anders ge-ordend is. 

Het aantal vaste controls op een pagina is altijd dezelfde, en deze staan ook altijd op dezelfde plaats gepositioneerd, enkel kan het zijn dat de tekst in deze controls varieert op basis van de data die zich in de database bevind. 

Om deze controls te testen moeten we ook klikken op de control, maar de concrete klikfunctie voor deze testmethode zal lichtjes verschillen van de variabele controls, aangezien de manier om toegang te krijgen tot de control anders zal zijn. De controle of de navigatie juist gebeurd is is opnieuw een controle op de titel van de pagina waarnaar we genavigeerd hebben, en eventueel een controle op de state van deze pagina (bvb: staat de juiste tab open? Staan de elementen in de pagina juist ge-ordend? ...).

######Zoekfunctie

De zoekfunctie vanuit de ClinicHubPage kan ook beschouwd worden als een navigatie. Als we puur het navigatiegedeelte gaan testen hiervan, moeten we geen rekening meer houden met het algoritme dat zorgt voor de correcte zoekresultaten, maar enkel met het feit dat er genavigeerd wordt naar de zoekresultatenpagina. 

Opnieuw zal dit een klein verschil geven in het schrijven van code, aangezien we deze keer niet moeten klikken op een control, maar eerst een zoekwoord moeten ingeven en nadien enteren of klikken op het vergrootglas naast het zoekvak. 

De controle gaan we opnieuw doen op de titel van de zoekresultatenpagina. 

######Hyperlink-navigatie

Op pagina's die data bevatten die te maken heeft met één bepaalde studie of één bepaalde patiënt (of eventueel nog andere objecten die we in de toekomst nog zouden kunnen tegenkomen), staat bovenaan steeds een hyperlink met de naam van dit object. Als we hierop klikken, komen we op de overzichtpagina van dat object (bvb studie->TrialHub, patiënt->PatientHub, ...)

Het schrijven van navigatiecode zal hier opnieuw lichtjes verschillen omdat de toegankelijkheid van de hyperlink lichtjes verschilt van de vorige navigaties. De controle gebeurt opnieuw op de titel.

>Voor al deze verschillende navigaties gaan we steeds onderzoeken hoe we de control kunnen vinden in code, hoe we een verwachte waarde kunnen creëren aan de hand van welke we kunnen controleren of de juiste navigatie uitgevoerd werd, hoe we dan deze control kunnen gebruiken (meestal klikken, aangezien de verschillende functionaliteiten zoals tab-enter bij navigaties nog niet van belang zijn, deze komen later terug bij functionality) en hoe we dan kunnen controleren dat deze verwachtte waarde aanwezig is na de navigatie. Na elk van deze tests gaan we dan ook nog de omgekeerde test doen met de backbutton, opnieuw met een verwachtte waarde en een effectieve waarde. Dit zorgt ervoor dat alle mogelijke back-navigaties in de applicatie uiteindelijk getest zijn. Dit geheel gaan we zoveel mogelijk in één grote functie per soort navigatie proberen te schrijven, zodat als we nadien dit soort navigatie nog tegenkomen, we gewoon éénmaal de geschreven functie kunnen aanroepen en dus geen extra werk meer hebben.

#### 3. States

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

##### Semantic zoom

De semantic zoom is een parent-control, die de mogelijkheid bezit om zichzelf in en uit te zoomen. Meestal bevind er zich in de semantic zoom een hub, die onderverdeeld wordt in verschillende hubsecties. Dit zijn allemaal aparte blokken waarin zich een aantal controls bevinden. Bovenaan een hubsectie staat dan de titel van deze hubsectie. Het aantal hubsecties is niet van belang, en ook het aantal controls die in een hubsectie geimplementeerd worden is niet van belang. Dat zijn er zoveel of zo weinig als je zelf wil. 

Wanneer we naar een pagina navigeren met een semantic zoom, staat deze automatisch ingezoomd. Alle hubsecties zijn dan volledig zichtbaar met hun titel en alle controls. Uitzoomen kunnen we doen door "Ctrl-", Ctrl & scrollen, klikken op de hubsectie-titels, PgUp/PgDn&Enter en Tab&Enter. Wanneer we uitzoomen verdwijnen alle volledige hubsecties en komt er in de plaats een lijst met listitems tevoorschijn, waarin alle titels van de hubsecties weergegeven zijn. Zo kunnen we makkelijk navigeren naar een hubsectie die helemaal rechts op het scherm staat en dus nog niet zichtbaar was in de zoomed-in state (toen moesten we er naartoe scrollen). 

Het terug inzoomen kan op dezelfde manier, door te klikken op de listitems, "Ctrl+", Ctrl & scrollen, , PgUp/PgDn&Enter en Tab&Enter. Als we terug inzoomen op een bepaalde hubsectie zal deze links van het scherm getoond worden. 

Wat we dus moeten testen is dat deze semantic zoom altijd in- en uitzoomt wanneer we de beschreven acties uitvoeren. We gaan dit opnieuw één keer volledig manueel analyseren, en nadien proberen op zo een manier te schrijven in een functie dat we deze functie voor alle pagina's die een semantic zoom bevatten kunnen gebruiken zonder moeite. 

Wat echter ook moet getest worden bij de semantic zoom, is het feit dat de hubsectietitels die in de zoomed-in state weergegeven zijn, ook overeenkomen met de titels die we in de lijst te zien krijgen als we uitzoomen. Ook moeten we controleren of alle hubsecties aanwezig zijn in de zoomed-in en zoomed-out state en dat deze aantallen dus overeen komen. 

Op sommige pagina's bevat de semantic zoom dan ook nog eens content die gebaseerd is op de content veranderingen in de gehele pagina. Zo is het bijvoorbeeld zo dat op de PatientScript page een checkbox in de semantic zoom staat, die aan uit uitgevinkt staat afhankelijk van het feit dat bepaalde info in de pagina is ingevuld of nog leeg is. We moeten dus ook testen dat deze checkboxes bij de zoomed-in en de zoomed-out state overeen komen.

Ook deze inhoudelijke tests gaan we eerst manueel uitvoeren en daarna in een functie wegschrijven zodat deze later hergebruikt kan worden zonder teveel denkwerk. 

##### Overlay

Een overlay is een extra stuk scherm dat bovenop een weergegeven scherm komt, wanneer we op een bepaalde knop klikken. De intentie van de overlay is dat we bepaalde data kunnen toevoegen (create) of aanpassen (Update). Meestal bestaat de overlay uit een aantal inputveldjes en een uitvoer-knop. Door deze inputveldjes in te vullen en op de uitvoer-knop te klikken wordt de data die jij net hebt ingevuld toegevoegd of aangepast in de database. 

Wat we hier moeten testen zijn verschillende dingen. Eerst en vooral moeten we testen of de overlay initieel niet zichtbaar is. Dan moeten we gaan kijken dat de knop die de bedoeling heeft de overlay te openen dit ook effectief doet. Dan moeten we controleren of de functionaliteit op de overlay zelf werkt naar behoren. Dit kan bijvoorbeeld zijn dat de uitvoer-knop pas actief wordt als bepaalde veldjes zijn ingevuld. Als laatste moeten we dan gaan testen of de overlay ook terug sluit als we op de sluit-knop of de uitvoer-knop klikken. Als we op de uitvoerknop hebben geklikt moeten we controleren of de data die wij hebben ingevoerd doorgevoerd wordt naar de applicatie. 

#### 4. Functionality

Onder functionaliteit verstaan we: alles dat te maken heeft met hoe de applicatie werkt, hoe controls werken,...

##### Speed

Speed heeft alles te maken met de snelheid waarmee de pagina's geladen zijn. Er zijn twee speed paradigmas die we gaan testen. 
* Reaction-speed
* Reactivity

######Reaction speed

De "reaction-speed" of reactiesnelheid is de snelheid waarmee een pagina geladen wordt. Dit is een speciaal soort test, die niet slaagt of faalt, maar een bepaalde waarde moet teruggeven. 

Om dit te testen moeten we dus eerst gaan uitzoeken hoe je nagaat of een pagina geladen is of niet. Vervolgens moeten we uitzoeken hoe we dit kunnen timen en tot slot hoe we deze getimede tijd kunnen opslaan en rapporteren.

######Reactivity

Reactiviteit is het kunnen gebruiken van controls vooraleer de pagina volledig geladen is. 

Om dit te testen moeten we dus een manier vinden om te controleren of de pagina al geladen is of nog niet, nadat we de control gebruikt hebben. Als we vorige test succesvol hebben uitgevoerd, weten we hoe we moeten controleren of een pagina geladen is of niet, dus zou dit voor deze test geen probleem mogen zijn. 

##### Scrolling

De scroll-functie wordt bij heel veel verschillende soorten vensters gebruikt. Het wordt gebruikt binnen een hub, binnen een combobox, sommige dropdown of popup-menus,...

Om de scroll-functie te testen, moeten we een manier vinden om te controleren of het de controls op het scherm dat we proberen te testen verplaatsen of zijn verplaatst. Vervolgens moeten we dan een manier zoeken om de verschillende soorten scroll-functies uit te voeren. Deze zijn onderandere het muis-scroll-wiel, de scrollbar,...

##### Control state verification

Dit is het controleren of de visuele toestand van de controls is hoe deze hoort te zijn. Enkele toestanden kunnen zijn: enabled/disabled, de kleur, de helptext,...

Er zijn ook verschillende scenarios waarvoor we deze toestanden moeten controleren. Je kunt klikken op een control, klikken en vasthouden, hoveren over de control, ... Ook heb je nog de initiele toestand waarin de control zich bevind. 

De tests zullen dus bestaan uit 2 delen, in het eerste deel creëren we het scenario dat we gaan testen (initeel, hover,...)
In het tweede deel controleren we de toestand van de control, zich bevindend in dit scenario. 

##### Control accessibility

Als we de toestand van een control gaan testen, gaan we natuurlijk ook de toegankelijkheid testen. Dit wil zeggen dat we gaan testen of je de control kan selecteren door middel van de tab en pijltjes toetsen. We hebben gemerkt dat dit voor sommige controls mogelijk is maar voor andere niet. Indien het mogelijk is moeten we dus uitzoeken hoe we kunnen controleren of er een stippelijn rondom de control zichtbaar is wanneer deze geselecteerd is. Vervolgens kunnen we dan automatisch beginnen tabben of op de pijltjestoetsen drukken in code en controleren of op een gegeven moment deze control geselecteerd is. 

Later gaan we ook controleren of we de control kunnen gebruiken met enkele toetsen op het toetsenbord als deze geselecteerd is. 

##### Custom

Onder custom plaatsen we alle functionaliteit die specifiek te maken heeft met de controls zelf, en voor elk type van control alle tests die enkel gelden voor dit soort control. 

#### 5. Config

Alle config-pagina's van Maät, zijn veruit de meest unieke pagina's in de applicatie. Dit zijn de pagina's met de meeste maar ook de meest complexe functionaliteit, die nergens anders in de applicatie te vinden is. Daarom hebben we beslist om voor deze pagina's een apart paradigma te maken, waarin we al deze unieke gevallen beschrijven en er automatische functies van maken. Deze functies kunnen we dan op alle config-pagina's toepassen. Dit is mogelijk omdat veel controls en elementen op exact dezelfde plaats en in exact dezelfde hiërarchie voorkomen op al deze pagina's. 

### Full checklist (nieuw)

Na een tijdje te werken met deze checklist, begonnen meer en meer paradigmas in verschillende categorieën elkaar te overlappen. Daarom is de beslissing genomen om de checklist nogmaals aan te passen en deels uit te breiden, om zoveel mogelijk paradigma's apart te houden en zo dus een overzichtelijke checklist te creëren. Het resultaat was volgende nieuwe indeling:


#### Content
Content krijgt een nieuwe onderverdeling, waarbij alle normale CRUD-operaties onder 1 subcategorie "CRUD" worden geplaatst met dan de verdere onderverdeling in Create, Read, Update en Delete. Onder "normaal" verstaan we gewone content die weergegeven wordt door controls. 

Alle "niet-normale" CRUD-operaties zijn interactieve functies zoals bijvoorbeeld de zoekfunctie. Deze worden onder de tab "Custom CRUD" geplaatst. 

Resultaat: 

* CRUD
  * Create
  * Read
  * Update
  * Delete
* Custom CRUD
  * General
  * Search algorithm

#### Navigations
Onder navigations waren er 2 subcategorieën, namelijk het navigeren zelf en het creëren van een bepaalde state van een pagina bij een navigatie. Het lijkt echter logisch dat ook de loadspeed (die voordien onder Functionality stond) ook bij navigations wordt geplaatst, aangezien dit iets is dat getest moet worden onmiddelijk na een navigatie. 

Resultaat

* Navigate to page
* Navigate to page-state
* Loadspeed

#### States
Bij states zijn er een hele hoop aanpassingen gebeurd. Na het analyseren van de applicatie is duidelijk geworden dat alle mogelijke states buiten overlay-state enkel voor kunnen komen wanneer een pagina niet in overlay-state is. Daarom is dit paradigma nu onderverdeeld in twee grote hoofdcategorieën: Overlay-state en no-overlay-state. Alle andere mogelijke states komen dan onder no-overlay-state. Het resultaat ziet er als volgt uit:

Resultaat:

* No overlay state
  * Zoomed in state
    * Alle mogelijke zoom-acties vanuit een zoomed in state
  * Zoomed out state
    * Alle mogelijk zoom-acties vanuit een zoomed out state
  * Filtering search state (page ordering
  * Multiselect state
* Overlay state
  * Alle mogelijke overlay-acties in een overlay state




