# 1 Introductie

## 1.1 Situering

Het onderwerp van onze thesis is 'Coded UI Testing'.

Dit onderwerp werd toegepast op het "Maät" project, een Windows 10 applicatie die momenteel nog in ontwikkeling is door "Calidos".

>De naam "Maät" komt van de Oud-Egyptische godin "Maät" of "Ma'at", waar ze staat voor onder meer kosmische orde, waarheid en stabiliteit.

### 1.1.1 Stagebedrijf

Calidos is een IT-bedrijf, gevestigd in Mechelen, dat zich specialiseert in software voor de healthcare sector. Een KMO met veel groeipotentieel en een duidelijke visie op hoe de software nuttig en tegelijk overzichtelijk informatie moet weergeven om het dagelijkse werk bij ziekenhuizen praktisch en efficiënt te laten verlopen.

![Logo calidos](/OverigeDocumenten/Afbeeldingen/thumbnail_CalidosTouchIT.jpg)

Eerder creëerde Calidos al een oplossing genaamd 'Othello' dat een toepassing is voor de MZG-registratie van VG-MZG scores (MVG-II) en personeelsgegevens. Meer dan 8750 ziekenhuisbedden hebben een licentie voor deze toepassing.
 
Het product ‘Team n Time’ laat ziekenhuizen toe personeel uit de mobiele equipe flexibel in te zetten in functie van hoe druk het is op een afdeling.

Het project waar deze thesis op toegepast wordt is het nieuwste project van Calidos, genaamd 'Maät'. Het Maät project is een Windows 10 applicatie die bedoelt is om clinical trials te plannen, te organiseren en op te volgen in ziekenhuizen.

### 1.1.2 Doelen

De vooropgestelde doelen van dit stageproject zijn:

1. Opleveren van een "Testing Guideline".
2. Opleveren van een "Testing Checklist" als onderdeel van de "Testing Guideline".
3. Opleveren van een "Testing Log" als onderdeel van de "Testing Guideline".
4. Opleveren van Result Management Tools *(Extra toevoeging op het einde van de stageperiode)*

Initieel waren deze documenten korte beschrijvingen, maar gedurende het verblijf bij "Calidos" zijn deze drastisch aangegroeid tot een duidelijk geheel dat in detail beschrijft hoe testing op "Maät" moet worden of, tot op zekere hoogte, werd verwezenlijkt.

#### 1.1.2.1 Deliverables: Testing Guideline

De testing guideline moet alle documentatie bevatten voor personen die het project moeten verderzetten. In essentie zullen dus volgende vragen moeten beantwoord worden in dit document:

* Hoe moet de applicatie getest worden?
* Hoe moet testing automation toegepast worden op de applicatie?
* Hoe ga je best te werk als je hieraan moet beginnen?

Er wordt dus stap voor stap toegelicht hoe dit gebeurt en wat er nodig is om dit te verwezenlijken / op te volgen.

#### 1.1.2.2 Opleveren van een "Testing Checklist" als onderdeel van de "Testing Guideline"

In essentie zal dus volgende vraag moeten beantwoord worden in dit deel van het document:

* Welke criteria moeten getest zijn om zeker te zijn dat de control / pagina volledig is uitgetest?

Opstellen van een lijst criteria, die "afgevinkt" kan worden en zo duidelijk weergeeft in hoeverre de applicatie getest is. De lijst zal dan in een soort matrix worden voorgesteld met langs de ene as een opsomming van paradigma's en sub-paradigma's en langs de andere as een opsomming van pagina's en controls.

Documenteren waar er zich problemen voordoen en wanneer mogelijk ook waarom. Ook problemen die zijn tegengekomen en hoe deze ondertussen verholpen zijn werden gedocumenteerd. Visuele foutjes, dingen die lichtjes verschillen op verschillende pagina's maar in wezen wel dezelfde control zijn,... Al deze dingen staan in dit document beschreven.

> In de laatste weken van de stageperiode is er beslist om Result Management Tools te creëren. Deze tool zou dan dit gehele process automatiseren (zie 'Result Management Tools' sectie).

#### 1.1.2.3 Opleveren van een "Testing Log" als onderdeel van de "Testing Guideline"

In essentie zal dus volgende vraag moeten beantwoord worden in dit deel van het document:

* Welke bugs en niet werkende elementen / foutjes bij controls zijn er aanwezig in de applicatie?

Bijhouden van bugs en problemen en hoe deze initieel opgelost of omzeilt zijn geweest. Ook is er steeds gedocumenteerd welke pogingen ondernomen zijn om het probleem op te lossen zonder succes. Dit omdat het dan makkelijker is om bepaalde redeneringen uit te sluiten wanneer men opnieuw probeert om het probleem aan te pakken.

#### 1.1.2.4 Result Management Tools

Als "zij-project" werd er de laatste 5 weken gevraagd of het mogelijk was om een kleine applicatie te schrijven die het mogelijk maakt om, via de DOBT, deze matrix weer te geven in "real-time". Waar we mee willen zeggen dat de matrix het resultaat zal zijn van drie afzonderlijke bestanden.
* Een "Definition" document
  * Definities van paradigma's op de ene en pagina's / controls op de andere matrix-as in XML formaat
* Een "Result" document
  * Resultaat van de testen, die 's nachts op de DOBT uitgevoerd werden in XML formaat
* Een "Target" document
  * Automatisch gegenereerd document. Dit gebeurt via de matrix applicatie, waar men manueel kan invoeren welke testen uitgevoerd moeten worden door de gewenste cellen op "TO DO" in te stellen.

Als resultaat krijgt men een matrix die opgesteld wordt via het "Definition" document. De cellen worden dan eerst ingevuld met het "Target" document en vervolgens overschreven (wanneer data beschikbaar is) met de resultaten uit het "Result" document.

#### 1.1.2.5 Basiskennis

Vooraleer de echte doelen kunnen worden voltooid is het belangrijk te leren werken en te begrijpen met welk onderwerp we bezig zijn. Aangezien dit de eerste keer was dat we met testing in contact kwamen.
De eerste fasen in onze thesis zijn dus:

* Uitzoeken wat "Coded UI Testing" nu eigenlijk is.
* Uitzoeken wat "Testing Automation" nu eigenlijk is.
* Leren werken met de Coded UI tools die voorzien zijn door Microsoft Visual Studio 2015.
  * De Coded UI Test Builder (Visual Studio 2015)
* Leren werken met het nieuwe OS van Microsoft, Windows 10.
  * Windows 10 (Microsoft)
* Leren werken met een UWP applicatie
  * UWP / XAML (Visual Studio 2015)

Wanneer de basiskennis opgenomen is, kan er gestart worden met het eigenlijke eindwerk dat ons gegeven is door Mark Devos.

### 1.1.3 Achtergrond

#### 1.1.3.1 Voor- en nadelen van Coded UI Testing

Het gebruik van coded UI tests en test automation kan heel wat voordelen hebben voor een project. Om een  idee te krijgen zijn hieronder de voornaamste opgelijst.

* Coded UI Tests zorgen voor stabiliteit in het project
  * Je kan aanpassingen doen aan je code zonder je teveel zorgen te maken over code die "breekt" of onverwachte bijeffecten. Bij elke aanpassing in code is het makkelijk (en bovendien ook goedkoop eens geschreven) om geschreven tests opnieuw te laten lopen. Zo ben je altijd zeker dat je project doet wat het moet doen.
* Coded UI Tests zorgen voor betrouwbaarheid in het project
  * Als er toch code "breekt" of functionaliteit veranderd, er altijd bekeken wordt via coded UI testing of er nog steeds gebeurt wat verwacht wordt. Het gekende "One step forward, two steps backward" wordt hier aangepakt door de resultaten van de testen te bekijken zodat je steeds op de hoogte bent van eventuele bugs of bijeffecten.
* Coded UI Tests zorgen voor schaalbaarheid in het project
  * Een enkele test laten lopen op het huidige project kan makkelijk handmatig. Maar waarschijnlijk zal je project wel meer dan één test nodig hebben om te garanderen dat het effectief doet wat het hoort te doen. Daarom is het makkelijk om testing automation te doen en deze tests automatisch te laten lopen zonder je zelf teveel zorgen te maken. Want, wanneer meerdere applicaties of projecten dezelfde bronnen gebruiken (een database of website bijvoorbeeld) los je dit makkelijk op door deze tests (of delen ervan) over te nemen en ook hier te gebruiken.

Er zijn echter ook nadelen bij coded UI tests:

* Coded UI Tests hebben een redelijk hoge kostprijs
  * Om goede Coded UI Tests te schrijven is veel tijd nodig. Vooral wanneer het project veel veranderingen doorloopt tijdens de ontwikkeling van de applicatie of website op UI-vlak.
* Coded UI Tests vereisen een testplan
  * Een goed testplan opstellen kan een enorm verschil maken in tijd en kost. Daarom is het niet meteen een nadeel, maar men moet vooral onthouden dat het vooraf uitstippelen van de manier van testen heel wat problemen kan voorkomen.

## 1.2 Algemeen overzicht

### 1.2.1 Analyse

Om tot de bevindingen te komen in dit onderdeel was het noodzakelijk de testing tools en de applicatie te leren kennen en gebruiken. Wanneer men een basisbegrip heeft van deze onderwerpen kunnen we dieper ingaan op hoe testing effectief gebeurd.

### 1.2.2 Design

In dit deel wordt gesproken over de denkwijze die toegepast werd op alles rondom de thesis. Zo zal er aandacht geschonken worden aan onder andere de benamingen van tests, de hiërarchische opbouw van de applicatie "Maät" en de documentstructuur van het Coded UI Test project op de TFS.

### 1.2.3 Implementatie

In dit hoofdstuk worden de denkwijze en opbouw van de testing guideline beschreven. Zo zal er aandacht geschonken worden hoe de testing checklist opgebouwd is, telkens kort toegelicht per paradigma / sub-paradigma.

### 1.2.4 Research

Er was heel wat onderzoekwerk gebeurd die uiteindelijk niet geïmplementeerd is geweest omdat de uitkomst van het onderzoek niet positief was. In dit hoofdstuk worden deze onderzoeken besproken en bevindingen hieromtrent neergeschreven.

### 1.2.5 Conclusies

Hierin zal uitgebreid uitgelegd worden wat de conclusies zijn die men kan trekken uit deze bachelorproef. Alsook kort toelichten wat er in de toekomst gepland was als bepaalde zaken sneller en/of vlotter hadden vooruitgegaan.

### 1.2.6 Appendices

De appendices bestaan voornamelijk uit alle documenten die als "deliverable" worden gezien. We hebben het dus over de Testing Guideline, de Testing Checklist, de Testing Log, de bevindingen voor de ontwikkelaar en de tijdschatting om de applicatie volledig te testen.

## 1.3 Gebruikte tools en technologieën

Hieronder volgt een korte opsomming van de voornaamste technologieën die gebruikt zijn tijdens de stage.

### 1.3.1 Software

#### 1.3.1.1 Windows 10

Oorspronkelijk is het Maät project gestart met als doelplatform Windows 8, maar door de snelle upgrade van Microsoft naar het veel recentere Windows 10 is Calidos ook overgegaan om Windows 10 tot het doelplatform te maken.

#### 1.3.1.2 Visual Studio 2015

Visual Studio 2015 is een rijk, geïntegreerd ontwikkelingsplatform om applicaties te creëren voor Windows, Andriod en iOS. Maar ook webapplicaties en cloud services vallen onder deze noemer.

#### 1.3.1.3 Team Foundation Server (TFS) 2013

Team Foundation Server 2013 is een server die het praktisch maakt om code te delen binnen een bedrijf/groep. Het is te vergelijken met bijvoorbeeld GitHub. Het maakt het mogelijk om code te mergen naar de server vanop ieders eigen branch, alsook de historie bekijken van elke methode/project. De ideale uitbreiding op de Visual Studio IDE wanneer men in een team aan een groot project werkt.

#### 1.3.1.4 Maät

De applicatie "Maät" is, zoals al eerder vermeld, een Windows 10 UWP applicatie die nog steeds onder ontwikkeling is. De applicatie maakt het mogelijk om clinical trials te plannen, te organiseren en op te volgen in ziekenhuizen.

De applicatie bevat heel wat data die gestructureerd en overzichtelijk wordt weergegeven op zijn verschillende schermen. Er zijn Hub-schermen die het mogelijk maken om een overzicht van een bepaald deel informatie te krijgen zoals bijvoorbeeld alle clinical trials. En er zijn dan weer andere schermen die veel specifieker data weergeven zoals bijvoorbeeld een specifieke trial.

  De applicatie werkt op alle Windows-10-draaiende apparaten en vereist een internetverbinding om de connecties met de database live te houden. Dit zodat alle data die aangepast wordt via een scherm, rechtstreeks aangepast kan worden in de database zelf.

#### 1.3.1.5 Xsd2Code++

Xsd2code++ is een Add-in voor Microsoft Visual Studio die code genereerd uit XSD bestanden. Het maakt als het ware objecten in Visual Studio die beschreven zijn in XML-vorm in de XSD schema's. Deze tool is gebruikt in de thesis bij het creëren van HTML in de Result Management Tools.

### 1.3.2 Tools 

#### 1.3.2.1 Coded UI Test Builder _(Test Tool from Visual Studio 2015)_

De Coded UI Test Builder is een onderdeel van het testing framework dat voorzien is door Visual Studio. Het is meer bepaald een testing tool die de ontwikkelaar in staat stelt om controls te mappen via UIMap's. De UIMap is een partial klasse die voor de helft automatisch gegenereerd wordt. Dit deel zorgt voor de mapping en eventueel voor assertions (beweringen) die kunnen controleren of een bepaalde voorwaarde voldoet. Een soort van "if" statement, maar dan voor het testing framework. De andere helft van de partial klasse is voor manuele aanpassingen. Hier komen we later duidelijker op terug.

### 1.3.3 Technologieën

#### 1.3.3.1 Universal Windows Platform (UWP)

Het Maät project is een Universal Windows Platform (UWP) applicatie opgestelt in C# en XAML

![Windows Core](/OverigeDocumenten/Afbeeldingen/windowscore.png)

Met de komst van Windows 10 werd UWP geïntroduceerd, dat het Windows Runtime model verder evolueert en het zo naar een verenigde Windows 10 core brengt. Als onderdeel van de core, brengt UWP een gezamenlijk app platform dat beschikbaar is op alle apparaten die Windows 10 runnen. Het UWP voorziet een gegarandeerde core API laag over apparaten. Dit wil zeggen dat men een enkel applicatie pakket kan maken dat kan geïnstalleerd worden op een waaier van apparaten. Bovendien voorziet de Windows Store een verenigd distributie kanaal dat, met dit single app pakket, alle apparaten waarop de applicatie kan draaien bereikbaar wordt.

#### 1.3.3.2 "C#" 

De Thesis is grotendeels opgesteld in C#. Dit heet te maken met het feit dat het grootste deel van applicatie in deze taal is geschreven, wat de dijdelijkheid van de code verbeterd. C# is een object georiënteerde programeertaal van Microsoft en is gebaseerd op de C++ programeertaal. De essentie is dat het de gemakkelijkheid van Visual Basic wil combineren met de kracht van C++. Ook .NET is nauwgebonden aan de C# taal.

#### 1.3.3.3 XML









 



