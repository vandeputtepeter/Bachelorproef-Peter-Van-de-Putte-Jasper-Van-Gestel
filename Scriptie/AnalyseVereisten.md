## Analyse en vereisten

De eerste fase in onze thesis: Uitzoeken waar we juist mee werken, het begrijpen en er mee leren werken. 

**Wat is een "Coded UI Test"?**

Een Coded UI Test stelt developers in staat om tests te creëren die user interaction (UI) kunnen nabootsen / simuleren op software applicaties. De tests hebben onder meer betrekkingen tot:

* Controleren of de applicatie correct opstart
* Controleren of de navigatie naar specifieke pagina's / modules correct verloopt
* Controleren of de ingevoerde data de correcte output weergeeft / verwerkt
* Controleren of de control's werken zoals men verwacht

**Wat is "Testing Automation"?**

Software testing automation of gewoon test automation is het gehele proces waarbij software tools voorgedefinieerde tests op een software applicatie uitvoeren vooraleer het betreffende product in productie gaat.

**Wat is de "Coded UI Test Builder"?** _(Visual Studio 2015)_

De Coded UI Test Builder is een onderdeel van het testing framework dat voorzien is door Visual Studio. Het is meer bepaald een testing tool die de ontwikkelaar in staat stelt om controls te mappen via UIMap's. De UIMap is een partial klasse die voor de helft automatisch gegenereerd wordt. Dit deel zorgt voor de mapping en eventueel voor assertions (beweringen) die kunnen controleren of een bepaalde voorwaarde voldoet. Een soort van "if" statement, maar dan voor het testing framework. De andere helft van de partial klasse is voor manuele aanpassingen. Hier komen we later duidelijker op terug.

**"UWP" en "Windows 10"** _(Microsoft)_

UWP of Universal Windows Platform is geintroduceerd met Windows 10. Het is een evolutie uit het Windows Runtime Model en brengt deze in de Windows 10 "Unified Core". Als onderdeel van de "Core" voorziet UWP een gemeenschappelijk applicatie platform voor elk apparaat dat Windows 10 draait. UWP voorziet een gegarandeerde "Core API" over alle apparaten. Dit wil zeggen dat het mogelijk is een enkele applicatie te creëren dat geïnstalleerd kan worden op een waaier van apparaten.Hierbij voorziet Windows Store een distributie kanaal dat alle apparaten kan bereiken waarop de betreffende applicatie kan draaien.