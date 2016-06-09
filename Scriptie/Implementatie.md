
# 4 Implementatie

## 4.1 Testing checklist

### 4.1.1 Overzicht

Dit is de kern van het project. Het was de bedoeling dat er een lijst werd opgesteld waarin alle paradigma's die getest moesten worden onder elkaar weergegeven werden. In de "testing guideline" staat voor elk element in deze lijst beschreven hoe dat specifieke paradigma moet getest worden. Daarnaast is er in een apart excel document voor elke pagina opgelijst welke specifieke paradigma's op die bepaalde pagina aanwezig zijn. Op die manier wordt er per pagina in een matrix bijgehouden of een bepaald paradigma volledig getest is, moet getest worden of niet van toepassing is. 

>Naar het einde van de bachelorproef toe werd er een automatisatie van dit process in ontwikkeld, er werd gehoopt dat deze volledig af zou zijn tegen het einde van de stage. Uiteindelijk zijn de tools niet volledig afgeraakt. Al zijn ze wel functioneel. Meer informatie over deze tools vindt je terug in de 'Gebruikte tools en technologieën' sectie van het 'Introductie' hoofdstuk.
 
### 4.1.2 Werkwijze

Er werd gestart met de basispagina’s die de meest gebruikte paradigma's/control ’s bevatten (die zo goed als overal terugkomen). 

Voor elke gevonden control/paradigma werd dan ge-analyseerd hoe deze zo effecient mogelijk getest kon worden. Deze methode werd dan gedocumenteerd zodat eventuele opvolgers deze altijd terug kunnen raadplegen wanneer nodig. Er werd ook gedocumenteerd welke control ’s en paradigma's reeds getest zijn geweest, tot alles getest is voor de specifieke pagina. Op het moment dat alle paradigma's op alle controls die deze paradigma's toepassen getest zijn, wordt een pagina als volledig getest verklaard.

Indien er op een volgende pagina weer een nieuwe control/paradigma tevoorschijn komt, zetten we deze bij onderaan onze checklist met gevonden control ‘s/paradigma's. Het is dan weer opnieuw de bedoeling om uit te zoeken hoe deze getest kan worden en alle voorgaande pagina’s opnieuw af te gaan en te controleren of ook dit element aanwezig is op de pagina en te testen indien nodig, zodat de pagina weer als getest verklaard kan worden. 

### 4.1.3 General checklist

Deze checklist bevat de algemene paradigma's die op elke pagina aanwezig zijn. Ze zijn onderverdeeld in een aantal subcategorieën, die later verder onderverdeeld zullen worden.

Op de general checklist staat voor elke pagina een kolom, met daaronder voor elk paradigma of dit volledig getest is voor deze pagina of niet. Men verklaard een pagina als volledig getest wanneer de pagina specifieke checklist, die verder besproken wordt, volledig is afgewerkt. 

Onderaan de general checklist staat ook een legende met een letter en een kleur die de test-status voorstelt van een paradigma (bijvoorbeeld: Y van Yes = getest, D van Do = nog te doen, E van Error = probleem bij testen,...)

### 5.1.4 Paradigm checklist

Aangezien het de bedoeling is dat er paradigma's gaan gezocht worden, en dat er dan voor elk paradigma uitgezocht wordt hoe dit moet getest worden, en dit nadien gedocumenteerd moet worden, leek het handig om een aparte paradigma-checklist te maken. Hier staan alle paradigma's, onderverdeeld tot op het niveau van specifieke scenario's, die getest moeten worden. Vervolgens staat er een kolom naast deze lijst, met dezelfde kleurcode als in de legende. Deze geeft dus aan of dit paradigma ge-analyseerd is en dus bekend is hoe dit moet getest worden. 

Wanneer er een nieuw paradigma bijkomt, zal deze dus altijd eerst op groen moeten komen in de paradigma-checklist, vooraleer dit getest kan worden op de rest van de pagina's. Uiteraard zal dit dan wel op één pagina al getest zijn, namelijk de pagina waarop dit paradigma gevonden is en ge-analyseerd is. 

### 4.1.5 Example-page + Page checklists

Vervolgens is er de pagina-specifieke checklist. Hierin staan de algemene paradigma's van de general checklist verder onderverdeeld zoals bij de paradigma-checklist. Bovenaan wordt de pagina dan opgesplitst in al zijn aparte control's, die worden gebruikt om tests uit te voeren. Voor elke control is ook de parent-control gedocumenteerd, zodat het duidelijk is over welke control het gaat. 

Op de example-page zijn enkele control's aanwezig die op elke pagina terugkomen, zoals de backbutton of de home-knop. 

Wanneer een nieuw paradigma gevonden wordt, zal dit eerst in de paradigm checklist terecht komen. Vervolgens komt paradigma op de example-page en nadien op alle andere page-checklists. Wanneer er begonnen wordt met een nieuwe pagina te testen en dus een page-checklist gemaakt wordt voor deze pagina, kan de example-page rechtstreeks gekopiërd en geplakt worden, en kunnen vervolgens alle pagina-specifieke control's toegevoegd worden.

Op de page checklist staat opnieuw aangeduid welk paradigma getest is en welk niet, volgens de kleurcode in de legende op de general checklist, met als verschil dat deze hier nog eens onderverdeeld worden per control. Er wordt dus voor elke control ge-analyseerd welk paradigma van toepassing is en dan wordt de status volgens de kleurcode aangeduid. 

### 4.1.6 Full checklist (eerste versie)

In de guideline staat de volledig uitgeschreven versie van de checklist. Hierin staat voor elk puntje in de lijst beschreven wat het exact inhoud onder "what?". Dit is een korte beschrijving van wat er getest wordt en wat de elementen die in de test gebruikt worden horen te doen. 

Vervolgens staat onder "how?" een stappenplan beschreven dat je moet volgen om die specifieke test uit te voeren. 

In deze checklist hoort zo specifiek en zo duidelijk mogelijk te zijn, zodat het ook voor een eventuele opvolger helemaal duidelijk is wat exact de bedoeling is van deze test en wat de verschillende control's en elementen horen te doen wanneer ze gebruikt worden op de beschreven manier. 

Merk op dat deze checklist later nogmaals veranderd is. Bij deze de uitleg over de eerste versie van de checklist (de uiteindelijke volgt nog): 

#### 4.1.6.1 Content

In deze sectie worden alle paradigma's beschreven die betrekking hebben tot de inhoud van control's en tekstvelden. Alle informatie die in de user-interface beschikbaar is die uit de database komt, of aangepast kan worden, komt onder het paradigma "content". 

Er zijn 4 verschillende handelingen die uitgevoerd kunnen worden op info in de control's. Deze 4 staan beter bekend als de CRUD-acties. (Create, Read, Update, Delete)

##### A. Create

"Create" wil zeggen dat je nieuwe data gaat toevoegen aan de database. Een voorbeeld hiervan is het toevoegen van een nieuwe patiënt of een nieuwe studie. Je vult alle velden in die relevant zijn en klikt dan op "toevoegen", wat ervoor zorgt dat er in de database een patiënt bijkomt die nog niet bestond.

Om dit paradigma te testen, moet eerst uitgezocht worden op welk deel van de applicatie het toevoegen van nieuwe data invloed heeft. Vervolgens kan data toegevoegd worden (door tekstveldjes in te vullen, staat beschreven in de guideline). tot slot moet gecontroleerd worden of de data veranderd is waar deze moest veranderen. Voor die controle is een "Read"-functie nodig, dus create en read zijn deels verweven met elkaar. 

>Voorbeeld: Ik voeg een nieuwe studie toe. Dit doe ik door een overlay te openen waarin een aantal tekstveldjes staan en een knop "toevoegen". Ik vul deze veldjes in en klik op de knop. Vervolgens navigeer ik naar de pagina waar de lijst met alle studies staat en loop ik over deze lijst om te controleren dat de studie die ik net heb toegevoegd aanwezig is in de lijst. Wanneer al deze stappen succesvol zijn uitgevoerd, is mijn test geslaagd.

##### B. Read

"Read" wil zeggen dat je gaat controleren of bestaande data, die aanwezig zou moeten zijn in de user-interface, ook effectief aanwezig is. Om dit te testen moet uitgezocht worden hoe enerzijds tekstvelden en eventueel andere control's uitgelezen kunnen worden, en anderzijds hoe deze vergeleken kunnen worden met de effectieve data in de database. 

Er zijn verschillende scenario's die onder "Read" vallen.

**Weergegeven data**

Buiten het zoek-algoritme, welke een speciaal geval van "read" is, bestaat een read-test eruit om te gaan controleren dat de data die weergegeven wordt in de user-interface correct is. 

Een voorbeeld is dat er naar de TrialHubPage genavigeerd wordt. Hierin staat alle data die te maken heeft met een bepaalde studie. Deze pagina gedraagt zich qua functionaliteit altijd hetzelfde, maar de data die weergegeven wordt hangt af van de studie waarop geklikt is. De bedoeling van de read-test is dan om te gaan controleren of de data die zichtbaar is in de user-interface dezelfde is als de data die verwacht wordt na een bepaalde navigatie. 

Dit kan enerzijds hardcoded gecontroleerd worden, door eerst manueel de navigatie uit te voeren en dan alle data die zichtbaar is in code te schrijven als assertions (assertions worden later uitgelegd). Anderzijds kunnen datadriven tests geschreven worden, waarbij de data die we gebruiken in de test afkomstig is van een database (wordt ook later uitgelegd). 

##### C. Update/delete

Update wil zeggen dat je reeds bestaande data gaat aanpassen en deze aanpassingen opslaan.

Delete is het verwijderen van bestaande data in de database. 

Update en delete vallen binnen deze applicatie onder dezelfde tab, aangezien het deleten van data in de UI een update naar de database stuurt met een indicatie dat deze data niet meer bestaat. 

##### D. Custom

Onder deze tab worden alle speciale gevallen geplaatst die nog bij content horen. Onder deze speciale gevallen horen bijvoorbeeld: het zoek-algoritme, de partpickers (wordt zo meteen besproken),...

**Zoek-algoritme**

Dit het algoritme dat de zoekfunctie doet werken. Er zijn 3 verschillende testscenario's die hierop uitgevoerd moeten worden.
1. Er moet getest worden of alle mogelijke parameters waarop we kunnen zoeken zoekresultaten opleveren. Het kan bijvoorbeeld zijn dat het zoekalgoritme zo is ingesteld dat je kan zoeken op de studienaam, patientnaam,... 

  Het soort parameters waarop gezocht kan worden moet manueel ge-analyseerd worden. Nadien worden hier tests voor geschreven.
2. Vervolgens moet gecontroleerd worden of alle zoekresultaten die weergegeven worden het zoekwoord bevatten dat ingegeven is. Hiervoor moet een speciaal soort read-functie geschreven worden, waar later meer over verteld wordt. 
3. Als derde moeten gecontroleerd worden of alle objecten in de database, die voldoen aan de zoekterm, ook effectief worden weergegeven. Het is één ding dat alle zoekresultaten de zoekterm bevatten, maar het zou natuurlijk altijd kunnen dat een aantal zoekresultaten die in de database wel effectief bestaan, niet worden weergegeven. In dat geval zou de vorige test wel werken, maar zou er toch nog een fout in het zoek-algoritme zitten. Vandaar dat deze derde test noodzakelijk is om het zoek-algoritme volledig te testen.

##### E. Part-pickers

Part-pickers zijn speciale knoppen waarmee je een datum of een tijd kan instellen. Door op de knop te klikken, verschijnt er een popup-venster. In dit venster staan een aantal verschillende tabs. Elk van deze tabs bevat een aantal blokken met waarden gaande van bijvoorbeeld 0-30/maandag-vrijdag/januari-december/... Door over deze blokken te hoveren met de muis en te scrollen, verschuiven ze, waardoor je de waarde aanpast. Er is altijd 1 van tab geselecteerd die je kan aanpassen. Bij het hoveren met de muis wordt de tab waarover je hovert automatisch geselecteerd. Je kan echter ook met de pijltjestoetsen van links naar rechts gaan om andere tabs te selecteren. Als je met de pijltjestoetsen van boven naar beneden gaat verschuif je de geselecteerde tab altijd met 2 waardes per keer. Met het scroll-wiel van de muis verplaats je de geselecteerde tab met 1 waarde per keer. 

Onderaan het popup-venster staan 2 knoppen, een vinkje en een kruisje. Door op het vinkje te klikken accepteer je de datum/tijd die je net hebt ingesteld en zal deze verschijnen in de Part-picker waarmee je net gewerkt hebt. Door op het kruisje te klikken wordt de verandering geanuleerd en blijft de waarde van de part-picker staan zoals die voordien stond. 

De aangepaste waarde accepteren kan ook door op enter te klikken. 

Telkens je een waarde accepteert/weigert verdwijnt het popup-venster terug. 

Het testen van deze partpickers is tot nu toe nog niet gelukt, aangezien er geen enkele manier gevonden is om in testcode de partpicker te kunnen zien. 

#### 4.1.6.2 Navigations

Het volgende grote paradigma zijn de navigaties binnen de applicatie. Onder navigaties vallen alle acties die ervoor zorgen dat de applicatie een ander scherm opendoet. Ook de zoekfunctie behoort tot navigaties, aangezien we hier ook naar een ander scherm gaan. Het verschil tussen de CRUD-tests voor de zoekfunctie en de navigatietests is echter dat bij de navigatietests niet gecontroleerd wordt welke zoekdata weergegeven wordt, maar enkel of er naar de zoekresultatenpagina genavigeerd wordt (ClinicSearch). 

Om een navigatie te testen zijn er dus in grote lijnen 2 handelingen die we moeten uitvoeren. Enerzijds moete de actie uitvoerd worden die zorgt voor de navigatie (meestal klikken op een control). Anderzijds moeten gecontroleerd worden of de juiste pagina wordt geopend nadat deze actie is uitgevoerd. 

Deze controle kan voor elke pagina anders zijn, maar de werkwijze is steeds dezelfde: er wordt een control of een set van controls die uniek zijn voor de desbetreffende pagina gezocht, en gecontroleerd of deze controls aanwezig zijn, of dat ze de juiste waarde bevatten (bijvoorbeeld: titels). 

##### A. Soorten navigations

Paradigmagewijs zijn alle navigations natuurlijk hetzelfde. Maar in manier van testen zijn de navigaties verder onderverdeeld in sub-paradigma's, waarbij elk sub-paradigma een lichtjes andere manier van testen omvat. 

**Variabele controls**

Hieronder valt het concept van een lijst, waarin zich allemaal verschillende gevallen bevinden van een bepaald opject. Dit kan bijvoorbeeld zijn: een lijst van studies, een lijst van patienten,... Het aantal items in de lijst staat nooit vast, aangezien het afhangt van hoeveel studies/patienten/... er zich in de database bevinden. Dit kan voortdurend wijzigen. Ook de tekst op deze controls hangt af van de data in de database. 

Als je op één van de controls in deze lijst klikt, zal je altijd op dezelfde pagina terecht komen. Hoe deze pagina is ingevuld hangt echter af van de control waarop je geklikt hebt.

Om dit te testen moet er dus enerzijds voor gezorgd worden dat de control aanklikbaar is, en nadien moet gecontroleerd worden of de titel van de pagina naarwaar genavigeerd werd overeen stemt met de control waarop geklikt is. 

**Vaste controls**

Vaste controls zijn controls die altijd op een pagina aanwezig zijn, ongeacht de data in de database. De navigatie is uniek voor elk van deze controls. Soms kan het wel zijn dat meerdere vaste controls naar dezelfde pagina navigeren maar ze zorgen dan elk apart voor een andere state van de desbetreffende pagina. Ze openen bijvoorbeeld allemaal een aparte tab van dezelfde pagina of zorgen ervoor dat de pagina anders ge-ordend is. 

Het aantal vaste controls op een pagina is altijd dezelfde, en deze staan ook altijd op dezelfde plaats gepositioneerd, enkel kan het zijn dat de tekst in deze controls varieert op basis van de data die zich in de database bevind. 

Om deze controls te testen moet ook geklikt worden op de control, maar de concrete klikfunctie voor deze testmethode zal lichtjes verschillen van de variabele controls, aangezien de manier om toegang te krijgen tot de control anders zal zijn. De controle of de navigatie juist gebeurd is is opnieuw een controle op de titel van de pagina waarnaar genavigeerd werd, en eventueel een controle op de state van deze pagina (bijvoorbeeld: staat de juiste tab open? Staan de elementen in de pagina juist ge-ordend? ...).

**Zoekfunctie**

De zoekfunctie vanuit de ClinicHubPage kan ook beschouwd worden als een navigatie. Als puur het navigatiegedeelte hiervan getest wordt, moet er geen rekening gehouden worden met het algoritme dat zorgt voor de correcte zoekresultaten, maar enkel met het feit dat er genavigeerd wordt naar de zoekresultatenpagina. 

Opnieuw zal dit een klein verschil geven in het schrijven van code, aangezien er deze keer niet moet geklikt worden op een control, maar er eerst een zoekwoord moet ingeven worden en nadien ge-enterd moet worden of geklikt moet worden op het vergrootglas naast het zoekvak. 

De controle gebeurt opnieuw op de titel van de zoekresultatenpagina. 

**Hyperlink-navigatie**

Op pagina's die data bevatten die te maken heeft met één bepaalde studie of één bepaalde patiënt (of eventueel nog andere objecten die in de toekomst zouden kunnen tevoorschijn komen), staat bovenaan steeds een hyperlink met de naam van dit object. Als hierop geklikt wordt, verschijnt de overzichtpagina van dat object (bijvoorbeeld: studie->TrialHub, patiënt->PatientHub, ...)

Het schrijven van navigatiecode zal hier opnieuw lichtjes verschillen omdat de toegankelijkheid van de hyperlink lichtjes verschilt van de vorige navigaties. De controle gebeurt opnieuw op de titel.

>Voor al deze verschillende navigaties wordt steeds onderzocht hoe de control gevonden kan worden in code, hoe een verwachte waarde gecreëerd kan worden aan de hand van welke gecontroleerd kan worden of de juiste navigatie uitgevoerd werd, hoe dan deze control gebruikt kan worden (meestal klikken, aangezien de verschillende functionaliteiten zoals tab-enter bij navigaties nog niet van belang zijn, deze komen later terug bij functionality) en hoe dan gecontroleerd kan worden dat deze verwachtte waarde aanwezig is na de navigatie. Na elk van deze tests wordt dan ook nog de omgekeerde test gedaan met de backbutton, opnieuw met een verwachtte waarde en een effectieve waarde. Dit zorgt ervoor dat alle mogelijke back-navigaties in de applicatie uiteindelijk getest zijn. Dit geheel wordt zoveel mogelijk in één grote functie per soort navigatie geschreven, zodat als nadien dit soort navigatie nog tevoorschijn komt, de geschreven functie gewoon éénmaal aangeroepen moet worden en er dus geen extra werk meer is.

#### 4.1.6.3 States

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

##### A. Semantic zoom

De semantic zoom is een parent-control, die de mogelijkheid bezit om zichzelf in en uit te zoomen. Meestal bevind er zich in de semantic zoom een hub, die onderverdeeld wordt in verschillende hubsecties. Dit zijn allemaal aparte blokken waarin zich een aantal controls bevinden. Bovenaan een hubsectie staat dan de titel van deze hubsectie. Het aantal hubsecties is niet van belang, en ook het aantal controls die in een hubsectie geimplementeerd worden is niet van belang. Dat zijn er zoveel of zo weinig als je zelf wil. 

Wanneer naar een pagina met een semantic zoom genavigeerd wordt, staat deze automatisch ingezoomd. Alle hubsecties zijn dan volledig zichtbaar met hun titel en alle controls. Uitzoomen wordt gedaan door "Ctrl-", Ctrl & scrollen, klikken op de hubsectie-titels, PgUp/PgDn&Enter en Tab&Enter. Wanneer uitgezoomd wordt verdwijnen alle volledige hubsecties en komt er in de plaats een lijst met listitems tevoorschijn, waarin alle titels van de hubsecties weergegeven zijn. Zo kan er makkelijk genavigeerd worden naar een hubsectie die helemaal rechts op het scherm staat en dus nog niet zichtbaar was in de zoomed-in state (toen moest er naartoe gescrolld worden). 

Het terug inzoomen kan op dezelfde manier, door te klikken op de listitems, "Ctrl+", Ctrl & scrollen, , PgUp/PgDn&Enter en Tab&Enter. Als er terug ingezoomd wordt op een bepaalde hubsectie zal deze links van het scherm getoond worden. 

Wat er dus moet getest worden is dat deze semantic zoom altijd in- en uitzoomt wanneer de beschreven actie uitgevoerd wordt. Dit moet opnieuw één keer volledig manueel ge-analyseerd worden, en nadien op zo een manier beschreven worden in een functie dat deze functie voor alle pagina's die een semantic zoom bevatten bruikbaar is zonder moeite. 

Wat echter ook moet getest worden bij de semantic zoom, is het feit dat de hubsectietitels die in de zoomed-in state weergegeven zijn, ook overeenkomen met de titels die te zien is in de lijst als we uitzoomen. Ook moet gecontroleerd worden of alle hubsecties aanwezig zijn in de zoomed-in en zoomed-out state en dat deze aantallen dus overeen komen. 

Op sommige pagina's bevat de semantic zoom dan ook nog eens content die gebaseerd is op de content veranderingen in de gehele pagina. Zo is het bijvoorbeeld zo dat op de PatientScript page een checkbox in de semantic zoom staat, die aan uit uitgevinkt staat afhankelijk van het feit dat bepaalde info in de pagina is ingevuld of nog leeg is. Er moet dus ook getest worden dat deze checkboxes bij de zoomed-in en de zoomed-out state overeen komen.

Ook deze inhoudelijke tests moeten eerst manueel uitgevoerd worden en daarna in een functie weggeschreven worden zodat deze later hergebruikt kan worden zonder teveel denkwerk. 

##### B. Overlay

Een overlay is een extra stuk scherm dat bovenop een weergegeven scherm komt, wanneer er op een bepaalde  knop geklikt wordt. De intentie van de overlay is dat bepaalde data toegevoegd kan worden (create) of aangepast kan worden (Update). Meestal bestaat de overlay uit een aantal inputveldjes en een uitvoer-knop. Door deze inputveldjes in te vullen en op de uitvoer-knop te klikken wordt de data die jij net hebt ingevuld toegevoegd of aangepast in de database. 

Wat hier moet getest worden zijn verschillende dingen. Eerst en vooral moet getest worden of de overlay initieel niet zichtbaar is. Dan moet er gekeken worden dat de knop die de bedoeling heeft de overlay te openen dit ook effectief doet. Dan moeten er gecontroleerd worden of de functionaliteit op de overlay zelf werkt naar behoren. Dit kan bijvoorbeeld zijn dat de uitvoer-knop pas actief wordt als bepaalde veldjes zijn ingevuld. Als laatste moet er getest worden of de overlay ook terug sluit als er op de sluit-knop of de uitvoer-knop geklikt wordt. Als er op de uitvoerknop geklikt wordt moet er gecontroleerd worden of de data die ingevoerd is doorgevoerd wordt naar de applicatie. 

#### 4.1.6.4 Functionality

Onder functionaliteit valt: alles dat te maken heeft met hoe de applicatie werkt, hoe controls werken,...

##### A. Speed

Speed heeft alles te maken met de snelheid waarmee de pagina's geladen zijn. Er zijn twee speed paradigmas die getest worden. 
* Reaction-speed
* Reactivity

**Reaction speed**

De "reaction-speed" of reactiesnelheid is de snelheid waarmee een pagina geladen wordt. Dit is een speciaal soort test, die niet slaagt of faalt, maar een bepaalde waarde moet teruggeven. 

Om dit te testen moet dus eerst uitgezocht worden hoe je nagaat of een pagina geladen is of niet. Vervolgens moet er uitgezocht worden hoe dit kan getimed worden en tot slot hoe deze getimede tijd opgeslagen en gerapporteerd kan worden.

**Reactivity**

Reactiviteit is het kunnen gebruiken van controls vooraleer de pagina volledig geladen is. 

Om dit te testen moet een manier gevonden worden om te controleren of de pagina al geladen is of nog niet, nadat de control gebruikt is. Als de vorige test succesvol uitgevoerd is, is bekend hoe gecontroleerd moet worden of een pagina geladen is of niet, dus zou dit voor deze test geen probleem mogen zijn. 

##### B. Scrolling

De scroll-functie wordt bij heel veel verschillende soorten vensters gebruikt. Het wordt gebruikt binnen een hub, binnen een combobox, sommige dropdown of popup-menus,...

Om de scroll-functie te testen, moet een manier gevonden worden om te controleren of de controls op het scherm dat getest wordt verplaatsen of zijn verplaatst. Vervolgens moet dan een manier gezocht worden om de verschillende soorten scroll-functies uit te voeren. Deze zijn onderandere het muis-scroll-wiel, de scrollbar,...

##### C. Control state verification

Dit is het controleren of de visuele toestand van de controls is hoe deze hoort te zijn. Enkele toestanden kunnen zijn: enabled/disabled, de kleur, de helptext,...

Er zijn ook verschillende scenarios waarvoor deze toestanden moeten gecontroleerd worden. Je kunt klikken op een control, klikken en vasthouden, hoveren over de control, ... Ook heb je nog de initiele toestand waarin de control zich bevind. 

De tests zullen dus bestaan uit 2 delen, in het eerste deel wordt het scenario gecreëerd dat getest gaat worden (initeel, hover,...)
In het tweede deel wordt de toestand van de control gecontroleerd, zich bevindend in dit scenario. 

##### D. Control accessibility

Als de toestand van een control getest wordt, wordt natuurlijk ook de toegankelijkheid getest. Dit wil zeggen dat er getest wordt of je de control kan selecteren door middel van de tab en pijltjes toetsen. Het werd duidelijk dat dit voor sommige controls mogelijk is maar voor andere niet. Indien het mogelijk is moet er uitgezocht worden hoe er gecontroleerd kan worden of er een stippelijn rondom de control zichtbaar is wanneer deze geselecteerd is. Vervolgens moet er automatisch getabt worden of op de pijltjestoetsen gedrukt worden in code en gecontroleerd worden of op een gegeven moment deze control geselecteerd is. 

Later wordt er ook gecontroleerd of de control gebruikt kan worden met enkele toetsen op het toetsenbord als deze geselecteerd is. 

##### E. Custom

Onder custom valt alle functionaliteit die specifiek te maken heeft met de controls zelf, en voor elk type van control alle tests die enkel gelden voor dit soort control. 

#### 4.1.6.5 Config

Alle config-pagina's van Maät, zijn veruit de meest unieke pagina's in de applicatie. Dit zijn de pagina's met de meeste maar ook de meest complexe functionaliteit, die nergens anders in de applicatie te vinden is. Daarom is er beslist om voor deze pagina's een apart paradigma te maken, waarin al deze unieke gevallen beschreven worden en er automatische functies van gemaakt worden. Deze functies kunnen dan op alle config-pagina's toepast worden. Dit is mogelijk omdat veel controls en elementen op exact dezelfde plaats en in exact dezelfde hiërarchie voorkomen op al deze pagina's. 

### 4.1.7 Full checklist (nieuw)

Na een tijdje te werken met deze checklist, begonnen meer en meer paradigmas in verschillende categorieën elkaar te overlappen. Daarom is de beslissing genomen om de checklist nogmaals aan te passen en deels uit te breiden, om zoveel mogelijk paradigma's apart te houden en zo dus een overzichtelijke checklist te creëren. Het resultaat was volgende nieuwe indeling:

#### 4.1.7.1 Content

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

#### 4.1.7.2 Navigations

Onder navigations waren er 2 subcategorieën, namelijk het navigeren zelf en het creëren van een bepaalde state van een pagina bij een navigatie. Het lijkt echter logisch dat ook de loadspeed (die voordien onder Functionality stond) ook bij navigations wordt geplaatst, aangezien dit iets is dat getest moet worden onmiddelijk na een navigatie. 

Resultaat

* Navigate to page
* Navigate to page-state
* Loadspeed

#### 4.1.7.3 States

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

#### 4.1.7.4 Control state appearance

Dit was een onderdeel van functionality in de oude checklist, maar het lijkt logischer om ook dit paradigma apart te plaatsen. Onder control state appearance vallen alle tests die de toestand van een control (zowel visueel als functioneel) gaan controleren. Dit kan bijvoorbeeld zijn: de kleur van controls, het feit dat deze ge-enabled zijn, de waarde die zich in de control bevind,... Deze toestand moet voor verschillende handelingen gecontroleerd worden. Volgende handelingen zijn alle handelingen die de state van een control kunnen veranderen:

* Initial (= de oorspronkelijke toestand, voor er een handeling uitgevoerd is)
* Hovered (= wanneer de muis over de control zweeft)
* Clicked (= wanneer er op de control geklikt is)
* Click & hold (= wanneer er op de control geklikt wordt maar de muis ingedrukt gehouden wordt)
* Filled in (= wanneer er data in de control wordt geplaatst door de gebruiker)

#### 4.1.7.5 Control functionality

Hieronder vallen alle andere functionality tests van de oude checklist, maar deze zijn anders geördend en meer veralgemeend (niet meer specifiek per type control, maar gewoon algemene tests) aangezien de volledige analyse voor elk type control moet gebeuren. 

De nieuwe indeling is als volgt:

* General: Hieronder vallen alle algemene functionaliteiten, namelijk het selecteren van een control door click/tab/pijltjestoetsen, en het gebruiken van een control met click/enter/spatie.
* Execution functionality: Hieronder zijn alle functionaliteiten geplaatst die mogelijk zijn met controls in de applicatie. Dit kan gaan van het doen verschijnen van andere controls tot het scrollen doorheen de childs van een control. 

#### 4.1.7.6 Custom functionality

Deze categorie was oorspronkelijk bedoeld voor de config-pagina's, maar de naam is veralgemeend aangezien er op andere pagina's ook nog speciale functionaliteit zou kunnen bestaan. Deze categorie is echter nog niet voldoende geanalyseerd.

## 4.2 Testing Maät

Tijdens het schrijven van tests zijn er verschillende moeilijkheden en dingen die het testen moeilijker maken aan het licht gekomen. Daarom bevat de guideline ook een sectie waarin voor elke pagina het testproces beschreven wordt. Hierin wordt dus beschreven hoe er voor de specifieke pagina in kwestie te werk gegaan wordt om alle tests te analyseren en hoe bepaalde tests moeten geschreven worden om deze zo autonoom mogelijk te maken. Ook als duidelijk wordt dat bepaalde tests niet kunnen geschreven worden door gebrek aan ondersteuning of bijvoorbeeld slechte UIMapping, wordt dit in deze sectie uitgelegd. Zo kan de eventuele opvolger van het project makkelijk de draad oppikken. 

### 4.2.1 General workmethod

Hierin wordt het algemene plan van aanpak beschreven die voor elke pagina hetzelfde blijft. Zo staat er bijvoorbeeld beschreven hoe de baseclass voor elke pagina moet opgebouwd zijn en wat hier het nut van is (namelijk het aanroepen van variabelen zodat deze in alle testprojecten van deze pagina kunnen gebruikt worden, en eventueel het schrijven van private functies voor de desbetreffende pagina). 

### 4.2.2 Page specific workmethod

Hier staat voor elke pagina apart beschreven hoe er te werk gegaan wordt om deze specifieke pagina te testen (of een specifieke groep van pagina's). 

## 4.3 How To Test

In dit onderdeel word algemeen beschreven hoe een test opgebouwd wordt en hoe deze werkt. Hier gaat het dus niet meer om hoe de applicatie Maät getest moet worden, maar echt hoe het Coded UI framework van Visual Studio in elkaar zit. 

### 4.3.1 Basics

In de basics wordt beschreven hoe een testproject aangemaakt wordt, welke parameters er in dit project moeten staan om dit te laten runnen, hoe je deze parameters moet aanroepen en dergelijke. 
Ook hoe controls toegevoegd worden aan een testproject wordt hier beschreven. Dit is dus eigelijk het eerste hoofdstuk dat de eventuele opvolger moet lezen om aan het project te kunnen beginnen. Zonder deze basis is het onmogelijk om de rest van de guideline te begrijpen. 

### 4.3.2 Generating controls 

Onder generating controls staat alles wat nodig is om controls in een test aan te roepen en waardes van deze control te verifiëren. Dit is uiteindelijk de essentie van alle tests, namelijk dat we bepaalde waardes gaan controleren op hun correctheid. 

### 4.3.3 Commonly used variables and methods

Hier staan een aantal variabelen en methoden beschreven die vaak nodig zijn om bepaalde tests uit te voeren. Een voorbeeld hiervan is de "StopWatch"-variabele. 

### 4.3.4 Commonly used controls

Dit hoofdstuk gaat al terug iets specifieker. Hier staan een aantal speciale controls beschreven die vaak terugkomen in de applicatie en vaak gebruikt worden in tests. Het kan bijvoorbeeld gaan om de "ProgressBar", die aangeeft wanneer een pagina volledig geladen is. 

### 4.3.5 BaseClassCodedUI

In dit hoofdstuk staan wel iets specifiekere zaken beschreven rond de applicatie Maät. Om het effectieve testen van de applicatie zo efficient mogelijk te laten verlopen, zijn er functies beschreven in een algemene baseclass (namelijk BaseClassCodedUI) die bepaalde tests automatisch uitvoeren. Het is tijdens de analyse de taak van de tester om bepaalde paradigma's te gaan uitzoeken (bijvoorbeeld: navigatie naar een andere pagina). Wanneer geanalyseerd is hoe dit moet getest worden wordt dit in een functie geschreven in de BaseClassCodedUI, waardoor dit paradigma bij de volgende test in één of enkele lijnen kan getest worden in plaats van elke keer opnieuw een hele blok code te schrijven. 

## 4.4 Result Management Tools

In dit hoofdstuk wordt beschreven hoe de result management tools tot stand zijn gekomen. Het draait hier voornamelijk over het feit dat er nooit echt een goed beeld kan worden gegeven van de status van testing. Deze tools zijn ontwikkeld om de ontwikkelaar en de klant te bewijzen dat tests wel degelijk uitgevoerd werden, en garanderen dat de resultaten onvervalst zijn.

Er zijn twee tools die dit mogelijk maken:

- TRX 2 XML Parser
- Testresult Parser

### 4.4.1 TRX 2 XML Parser

Wanneer Coded UI Tests uitgevoerd worden via MSTest of via Visual Studio zal er een .trx document gegenereerd worden. Dit document bevat alle resultaten en andere informatie omtrent de tests. Het .trx document is opgesteld in een XML-structuur. Omdat dit document teveel informatie bevat wordt er enkel de essentiele informatie uitgehaald en in een nieuw aangemaakt XML document gezet.

#### 4.4.1.1 RegisterTest

RegisterTest is een methode, gedefineerd in de BaseTestClass, die altijd als eerste moet worden aangeroepen binnen een testmethode. Deze methode zorgt ervoor dat er nog meer noodzakelijke informatie in de XML terecht zal komen. Het neemt namenlijk de scherm en paradigma ID op in zijn methode en schrijft deze dan bij uitvoering van de test mee weg in het .trx document. Op deze manier is er een link tussen de test, het scherm en het paradigma waarbij een test-resultaat wordt gegeven.

#### 4.4.1.2 Running tests

In dit onderdeeltje is kort uitgelegd hoe er manueel voor gezorgd werd dat het .trx bestand gegenereerd werd. De bedoeling is uiteraard in de toekomst dat dit mee in de build-straat komt en het zo automatisch gebeurd.

#### 4.4.1.3 Running the tool

Omdat er manueel nog variabelen moeten meegegeven worden in het stadium waar de tool zich op het einde van de stage zich bevond, is er duidelijk beschreven hoe dit moet gebeuren.

#### 4.4.1.4 Result XML

Deze XML zal het gegenereerde XML bestand zijn dat voortkomt uit het .trx bestand dat de tests zelf op hun beurt voortbrachten. Belangrijk is om te weten wat er in dit bestand aanwezig is. Het bevat volgende syntax:

```
<Test TestId=”Test Name” CategoryId =”Category GUID” ObjectId=”Object GUID” ResultLabel=”Outcome”>
```

* TestId
  * De test naam (test methode naam) die gegeven was in de code van de test
* CategoryId
  * De ID van de category, geschreven als een GUID
* ObjectId
  * De ID van het object, geschreven als een GUID
* ResultLabel 
  * Bevat één van de vier verschillende mogelijke statusen:
    * Passed (De test is geslaagd)
    * Failed (De test is gefaald)
    * Aborted (De test die uitgevoerd werd is manueel geanuleerd)
    * Not Executed (De test is niet uitgevoerd geweest)

###  4.4.2 Testresult Parser

Deze tool is de tool waar het allemaal om te doen is als men spreekt over het weergeven van de vooruitgang bij testing. Het neemt drie XML bestanden als input en genereerd hieruit een HTML bestand dat de stand van zake weergeeft.

#### 4.4.2.1 HTML bestand: Result tabel

Om te begrijpen hoe de tool werkt is het noodzakelijk de output te begrijpen. In dit geval genereerd de tool een HTML bestand. Hierin wordt een tabel weergegeven die de progressie van het testen van de applicatie weergeeft. De tabel is opgebouwd uit twee assen die de schermen en paradigma's weerrgeven en heel wat cellen die de status van elke testcase weergeven. Een cel kent 5 staten:

* Passed (100% Completion of test case)
* Failed (< 100% Completion of test case)
* To Do	(This test case does not have a test written for it)
* Not To Do (This test case does not need a test written for it)
* Unknown (This test case is not yet been analyzed)

#### 4.4.2.2 Definition XML

De Definition XML is het document waar manueel de assen van de tabel worden gedefineerd. 

```
<Category id="Category GUID" name="Paradigm" info="Description" level="">
<Object id="Object GUID" name="Screen / Control" info="Description" level="">
```


