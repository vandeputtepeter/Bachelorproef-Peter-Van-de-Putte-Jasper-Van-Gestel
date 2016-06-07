# 2 Analyse

De eerste fase in deze thesis: Het uitzoeken, het begrijpen en het leren werken met Coded UI tests, de Coded UI Testing tools en de Maät applicatie. 

## 2.1 Definities

**Wat is een "Coded UI Test"?**

Een Coded UI Test stelt developers in staat om tests te creëren die user interaction (UI) kunnen nabootsen / simuleren op software applicaties. De tests hebben onder meer betrekkingen tot:

* Controleren of de applicatie correct opstart
* Controleren of de navigatie naar specifieke pagina's / modules correct verloopt
* Controleren of de ingevoerde data de correcte output weergeeft / verwerkt
* Controleren of de control's werken zoals men verwacht

**Wat is "Testing Automation"?**

Software testing automation of gewoon test automation is het gehele proces waarbij software tools voorgedefinieerde tests op een software applicatie uitvoeren vooraleer het betreffende product in productie gaat.

## 2.2 De Coded UI Test Builder ontdekken



## 2.3 Maät ontdekken

### 2.3.1 Hiërarchisch navigatie ontwerp

In de eerste fase van onze opdracht is er, zoals eerder vermeld, een hiërarchisch design opgesteld van alle navigatie die in de applicatie "Maät" mogelijk is. Dit gebeurde door alle navigatie uit te proberen en te documenteren naar welke pagina, of eventueel welke sub-pagina, een knop leidt. Zo kon er niet alleen een handig overzicht gecreëerd worden waarin we konden zien welke schermen het belangrijkste zijn, maar ook welke (voorlopig) minder belangrijk waren en gaf dit het bijkomende voordeel dat de applicatie verkend kon worden. Dit werd handig bij het verdere verloop van het project.

Het hiërarchisch design vertrekt vanuit de "ClinicHubPage". Dit is de hoofdpagina waarop men terecht komt als de applicatie gestart wordt (Na het inloggen). Van hieruit is een boomstructuur getekend naar alle pagina's waarnaar navigatie mogelijk is vanuit de "ClinicHubPage" (Zie afbeelding onder voor voorbeeld). Vervolgens is er voor elke hub-pagina een nieuw bestand gemaakt waarin dezelfde werkwijze gevolgd is als bij de "ClinicHubPage", namelijk al deze pagina's laten vertakken vanuit de respectievelijke pagina. 

![Voorbeeld: boomstructuur van "ClinicHubPage"](/OverigeDocumenten/Afbeeldingen/ClinicHub.jpg)

Bij elke tak is (op de pijl) geschreven welke knop of handeling ervoor zorgt dat we op die specifieke pagina terecht komen. Ook is er per pagina de belangrijkheid aangeduid in het testgebeuren. Sommige pagina's zijn namelijk nog niet af, of zijn zelfs nog in hun beginfase. Dit zijn dan pagina's die in het totale testproject minder prioriteit hebben ten opzichte van de pagina's die wel al af zijn of belangrijke informatie bevatten.

>De rode vakken stellen data-heavy pagina's voor die vrij uitgebreid zijn. Dit type pagina's is vrij belangrijk in de applicatie omdat deze data vaak andere pagina's kan beïnvloeden.

## 2.4 Planning

