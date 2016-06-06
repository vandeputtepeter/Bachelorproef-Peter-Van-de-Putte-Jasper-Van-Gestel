# 2 Ontwikkelingsproces

In dit deel bespreken we voornamelijk de methoden, denkwijzen en technieken die gehanteerd werden tijdens onze stage. Zo zullen we het hebben over hoe we van scratch en met "zero" kennis stelselmatig aan de thesis gestart zijn.


## 2.1 Hiërarchisch navigatie ontwerp

Bij aanvang van de stage was het de bedoeling te leren werken met de applicatie en te ontdekken welke testing tools er beschikbaar waren om Coded UI Testing te kunnen uitvoeren. Daarbovenop moest er geleerd worden om te werken met het nieuwe Windows 10 OS, dat noodzakelijk was, aangezien de applicatie gebouwd is voor Windows 10. Om een duidelijk beeld te krijgen van de applicatie is er een hiërarchisch ontwerp ontwikkelt van de applicatie in de eerste fasen, zodat bekend werd hoe de applicatie werkt en hoe de navigatie van pagina naar pagina in elkaar zat.

## 2.2 Benaming van testmethoden

In dit onderdeel worden een aantal regels beschreven waaraan de namen van alle geschreven testmethodes moeten voldoen. De visie op deze naamgeving is dat men aan de naam van een testmethode alle informatie over wat er getest wordt kan afleiden. De reden hiervoor is, dat wanneer een verslag terugkomt van alle uitgevoerde tests en er bepaalde tests gefaald zijn, er meteen kan worden gezien welk paradigma in de applicatie niet werkt zoals het hoort te werken door gewoon de naam van de testmethode te lezen. Waarom dit paradigma gefaald is wordt weggeschreven in een test-log, waar we later op terugkomen.

Na meerdere brainstorm sessies over de benaming van testmethoden zijn we tot het volgende resultaat gekomen:

$$Page name + Paradigm (+ Context) (+ Xaml Control Type Property) (+ Specific Info)$$

* "Page name"
  * Verplichte parameter
  * Duidt de pagina aan waarin de test zich bevind.
  * Bijvoorbeeld: "ClinicHub", "ClinicSearch", "TrialHub", "PatientScript",...
  * Deze parameter moet altijd in het begin van de testmethode geschreven worden, omdat we dan meteen weten op welke pagina er zich een bug bevind indien de test faalt.
* "Paradigm"
  * Verplichte parameter
  * Duidt op het paradigma dat getest wordt. Dit is de denkwijze/werkwijze die de applicatie volgt om tot een bepaald resultaat te komen.
  * Bijvoorbeeld: Navigate (navigeer naar een andere pagina), Check (controleer een bepaalde waarde),... 
  * Deze parameter komt meteen na de pagina om een duidelijke afbakening te zien van wat er wel/niet werkt op welke pagina.
* "Context"
  * Optionele parameter
  * Duidt meer specifiek aan welke control of welk deel van de geteste pagina getest wordt.
  * Bijvoorbeeld: Wanneer je meerdere lijsten hebt, die elk een lijst van zoekresultaten bevatten, en waarbij elke lijst een ander soort zoekresultaat bevat, kan je "Context" interpreteren als het woord dat duidelijk maakt om welke lijst het gaat. 
* "Xaml Control Type Property":
  * Optionele parameter
  * Duidt op het type control dat getest wordt.
  * Bijvoorbeeld: Wanneer je bij context al hebt aangeduid welk sub-deel van de applicatie getest wordt, kan het nog steeds zijn dat dit sub-deel meerdere control's of control types bevat. Deze parameter duid dan duidelijk aan om welke control het gaat (indien er één specifieke control getest wordt). 
* "Specific Info":
  * Optionele parameter
  * Duidt op de info die je bij sommige tests nodig hebt om volledig duidelijk te maken wat er exact getest wordt. Dit kan allerhande informatie zijn.
  * Bijvoorbeeld: Een bepaalde state waarin de pagina zich bevind voor die specifieke test.

>Het is noodzakelijk dat minstens één van de optionele parameters ook aanwezig is in de testmethodebenaming om verduidelijking te geven over de betreffende testmethode.

## 2.3 Bestandsstructuur

De bestandsstructuur is ook een vrij belangrijk onderdeel als het gaat over duidelijkheid. Zo was het noodzakelijk te documenteren hoe de structuur in elkaar zat. Zo kan ook in de toekomst verzekerd worden dat de bestandstructuur voortgezet wordt door opvolgers op een duidelijke manier die overeenkomt met de bestanden die aangemaakt zijn geweest tijdens het stageverblijf bij Calidos.

## 2.4 How to test

Uiteraard is er ook lange tijd over gegaan vooraleer de testing tools handig werden in gebruik, aangezien niemand bij Calidos eerder met coded UI testing heeft gewerkt moest dus alles opgezocht en uitgetest worden. Na 1 à 2 weken filmpjes bekijken, webblogs en fora lezen en experimenteren met onder andere de Coded UI Test Builder, werd er stilaan gestart met het effectieve werk. Het was ook noodzakelijk al deze dingen die geleerd werden bij te houden in een goed gedocumenteerde vorm.
