# 1 Introductie

Het onderwerp van onze thesis is 'Coded UI Testing'.

We gaan dit toepassen op een programma, het "Maät" project , een Windows 10 applicatie die momenteel nog in ontwikkeling is door "Calidos".

De eerste fasen in onze thesis zijn:

* Uitzoeken wat "Coded UI Testing" nu eigenlijk is.
  * Wat is testing automation
* Leren werken met de Coded UI tools die voorzien zijn door Microsoft Visual Studio 2015 en het nieuwe OS van Microsoft, Windows 10 
  * De Coded UI Test Builder (Visual Studio 2015)
  * UWP / XAML (Visual Studio 2015)
  * Windows 10 (Microsoft)

Wanneer deze doelen bereikt zijn en de basiskennis opgenomen is, kan er gestart worden met het eigenlijke eindwerk dat ons gegeven is door Mark Devos.

De twee grote doelen zijn:

* Opleveren van een "Testing Guideline"
  * Hoe moet de applicatie getest worden
  * Hoe moet testing automation toegepast worden op de applicatie
* Opleveren van een "Testing Checklist" als onderdeel van de "Testing Guideline"
  * Welke criteria moeten getest zijn om zeker te zijn dat de control of pagina volledig is uitgetest

* Er werd ook gevraag om een bijkomstig document op te stellen dat bugs en niet werkende elementen of foutjes bij controls definieert. Dit document zal ook deel uitmaken van de "Testing Guideline".

Initieel zullen deze documenten korte beschrijvingen zijn, maar gedurende ons verblijf bij "Calidos" zullen deze drastisch aangroeien tot een duidelijk geheel dat in detail beschrijft hoe testing op "Maät" moet worden verwezenlijkt.

## 1.1 Situering

### 1.1.1 Maät

Het project "Maät" is vernoemd naar de Oud-Egyptische godin "Maät" of "Ma'at", waar ze staat voor onder meer kosmische orde, waarheid en stabiliteit.

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
