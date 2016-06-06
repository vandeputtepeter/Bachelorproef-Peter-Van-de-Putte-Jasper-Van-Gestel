# 1 Introductie

## 1.1 Situering

Het onderwerp van onze thesis is 'Coded UI Testing'.

Dit onderwerp werd toegepast op het "Maät" project, een Windows 10 applicatie die momenteel nog in ontwikkeling is door "Calidos".

### 1.1.1 Maät

Het project "Maät" is vernoemd naar de Oud-Egyptische godin "Maät" of "Ma'at", waar ze staat voor onder meer kosmische orde, waarheid en stabiliteit.

### 1.1.2 Doelen

De vooropgestelde doelen van dit stageproject zijn:

1. Opleveren van een "Testing Guideline".
  * Hoe moet de applicatie getest worden.
  * Hoe moet testing automation toegepast worden op de applicatie.
2. Opleveren van een "Testing Checklist" als onderdeel van de "Testing Guideline".
  * Welke criteria moeten getest zijn om zeker te zijn dat de control of pagina volledig is uitgetest.
3. Opleveren van een "Testing Log" als onderdeel van de "Testing Guideline".
  * bijkomstig document dat bugs en niet werkende elementen of foutjes bij controls definieert.

Initieel waren deze documenten korte beschrijvingen, maar gedurende het verblijf bij "Calidos" zijn deze drastisch aangegroeid tot een duidelijk geheel dat in detail beschrijft hoe testing op "Maät" moet worden of, tot op zekere hoogte, werd verwezenlijkt.

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



## 1.2 Gebruikte tools en technologieën

### 1.2.1 Windows 10

Oorspronkelijk is het Maät project gestart met als doelplatform Windows 8, maar door de snelle upgrade van Microsoft naar het veel recentere Windows 10 is Calidos ook overgegaan om Windows 10 tot het doelplatform te maken.

### 1.2.2 Universal Windows Platform (UWP)

Het Maät project is een Universal Windows Platform (UWP) applicatie opgestelt in C# en XAML

![Windows Core](/OverigeDocumenten/Afbeeldingen/windowscore.png)

Met de komst van Windows 10 werd UWP geïntroduceerd, dat het Windows Runtime model verder evolueert en het zo naar een verenigde Windows 10 core brengt. Als onderdeel van de core, brengt UWP een gezamenlijk app platform dat beschikbaar is op alle apparaten die Windows 10 runnen. Het UWP voorziet een gegarandeerde core API laag over apparaten. Dit wil zeggen dat men een enkel applicatie pakket kan maken dat kan geinstalleerd worden op een waaier van apparaten. Bovendien voorziet de Windows Store een verenigd distributie kanaal dat, met dit single app pakket, alle apparaten waarop de applicatie kan draaien bereikbaar wordt.


### 1.2.3 Visual Studio 2015






### 1.2.4 Coded UI Test Builder _(Test Tool from Visual Studio 2015)_

De Coded UI Test Builder is een onderdeel van het testing framework dat voorzien is door Visual Studio. Het is meer bepaald een testing tool die de ontwikkelaar in staat stelt om controls te mappen via UIMap's. De UIMap is een partial klasse die voor de helft automatisch gegenereerd wordt. Dit deel zorgt voor de mapping en eventueel voor assertions (beweringen) die kunnen controleren of een bepaalde voorwaarde voldoet. Een soort van "if" statement, maar dan voor het testing framework. De andere helft van de partial klasse is voor manuele aanpassingen. Hier komen we later duidelijker op terug.

## 1.2 Stagebedrijf

Calidos is een IT-bedrijf, gevestigd in Mechelen, dat zich specialiseert in software voor de healthcare sector. Een KMO met veel groeipotentieel en een duidelijke visie op hoe de software nuttig en tegelijk overzichtelijk informatie moet weergeven om het dagelijkse werk bij ziekenhuizen praktisch en efficiënt te laten verlopen.

![Logo calidos](/OverigeDocumenten/Afbeeldingen/thumbnail_CalidosTouchIT.jpg)

Eerder creëerde Calidos al een oplossing genaamd 'Othello' dat een toepassing is voor de MZG-registratie van VG-MZG scores (MVG-II) en personeelsgegevens. Meer dan 8750 ziekenhuisbedden hebben een licentie voor deze toepassing.
 
Het product ‘Team n Time’ laat ziekenhuizen toe personeel uit de mobiele equipe flexibel in te zetten in functie van hoe druk het is op een afdeling.

Het project waar deze thesis op toegepast wordt is het nieuwste project van Calidos, genaamd 'Maät'. Het Maät project is een Windows 10 applicatie die bedoelt is om clinical trials te plannen, te organiseren en op te volgen in ziekenhuizen.

## 1.3 Opgave

### 1.3.1 Doel

Als bachelorproject hebben we "Coded UI Testing" moeten toepassen op het Maät project, dat nog steeds in ontwikkeling is door "Calidos".

### 1.3.2 Deliverables: Testing Guideline

De testing guideline moet alle documentatie bevatten voor personen die het project moeten verderzetten. In essentie zullen dus volgende vragen moeten beantwoord worden in dit document:

* Hoe moet de applicatie getest worden?
* Hoe moet testing automation toegepast worden op de applicatie?
* Hoe ga je best te werk als je hieraan moet beginnen?

Er wordt dus stap voor stap toegelicht hoe dit gebeurt en wat er nodig is om dit te verwezenlijken / op te volgen.

#### 1.3.2.1 Opleveren van een "Testing Checklist" als onderdeel van de "Testing Guideline"

In essentie zal dus volgende vraag moeten beantwoord worden in dit deel van het document:

* Welke criteria moeten getest zijn om zeker te zijn dat de control / pagina volledig is uitgetest?

Opstellen van een lijst criteria, die "afgevinkt" kan worden en zo duidelijk weergeeft in hoeverre de applicatie getest is. De lijst zal dan in een soort matrix worden voorgesteld met langs de ene as een opsomming van paradigma's en sub-paradigma's en langs de andere as een opsomming van pagina's en controls.

Documenteren waar er zich problemen voordoen en wanneer mogelijk ook waarom. Ook problemen die zijn tegengekomen en hoe deze ondertussen verholpen zijn werden gedocumenteerd. Visuele foutjes, dingen die lichtjes verschillen op verschillende pagina's maar in wezen wel dezelfde control zijn,... Al deze dingen staan in dit document beschreven.

> In de laatste weken van de stageperiode is er beslist om Result Management Tools te creëren. Deze tool zou dan dit gehele process automatiseren (zie 'Result Management Tools' sectie).

#### 1.3.2.2 Opleveren van een "Testing Log" als onderdeel van de "Testing Guideline"

In essentie zal dus volgende vraag moeten beantwoord worden in dit deel van het document:

* Welke bugs en niet werkende elementen / foutjes bij controls zijn er aanwezig in de applicatie?

Bijhouden van bugs en problemen en hoe deze initieel opgelost of omzeilt zijn geweest. Ook is er steeds gedocumenteerd welke pogingen ondernomen zijn om het probleem op te lossen zonder succes. Dit omdat het dan makkelijker is om bepaalde redeneringen uit te sluiten wanneer men opnieuw probeert om het probleem aan te pakken.

### 1.3.3 Result Management Tools

Als "zij-project" werd er de laatste 5 weken gevraagd of het mogelijk was om een kleine applicatie te schrijven die het mogelijk maakt om, via de DOBT, deze matrix weer te geven in "real-time". Waar we mee willen zeggen dat de matrix het resultaat zal zijn van drie afzonderlijke bestanden.
* Een "Definition" document
  * Definities van paradigma's op de ene en pagina's / controls op de andere matrix-as in XML formaat
* Een "Result" document
  * Resultaat van de testen, die 's nachts op de DOBT uitgevoerd werden in XML formaat
* Een "Target" document
  * Automatisch gegenereerd document. Dit gebeurt via de matrix applicatie, waar men manueel kan invoeren welke testen uitgevoerd moeten worden door de gewenste cellen op "TO DO" in te stellen.

Als resultaat krijgt men een matrix die opgesteld wordt via het "Definition" document. De cellen worden dan eerst ingevuld met het "Target" document en vervolgens overschreven (wanneer data beschikbaar is) met de resultaten uit het "Result" document.

