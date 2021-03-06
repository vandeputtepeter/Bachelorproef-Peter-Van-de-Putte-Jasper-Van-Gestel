# 2 Analyse

De eerste fase in deze thesis: Het uitzoeken, het begrijpen en het leren werken met Coded UI tests, de Coded UI Testing tools en de Maät applicatie. 

## 2.1 Definities

Om te kunnen begrijpen waar de thesis om draait is het dus essentieel te weten wat het onderwerp juist is. Daarom zijn volgende termen belangrijk:

**Wat is een "Coded UI Test"?**

Een Coded UI Test stelt ontwikkelaars in staat om tests te creëren die user interaction (UI) kunnen nabootsen / simuleren op software applicaties. De tests hebben onder meer betrekkingen tot:

* Controleren of de applicatie correct opstart
* Controleren of de navigatie naar specifieke pagina's / modules correct verloopt
* Controleren of de ingevoerde data de correcte output weergeeft / verwerkt
* Controleren of de besturingselementen werken zoals men verwacht

**Wat is "Testing Automation"?**

Software testing automation of gewoon test automation is het gehele proces waarbij software tools voorgedefinieerde tests op een software applicatie uitvoeren vooraleer het betreffende product in productie gaat.

## 2.2 De Coded UI Test Builder en UI Mapping

In deze sectie wordt beschreven hoe de coded UI Test Builder werkt en hoe UI Mapping gebeurt voor elk besturingselement. Er is heel wat tijd over gegaan vooraleer het duidelijk werd hoe deze testing tool werkte. Daarom zijn er ook regels en beschreven om de (toekomstige) code leesbaar en makkelijk aanpasbaar te maken en houden.

### 2.2.1 Een Coded UI Test klasse toevoegen aan het project

Om een Coded UI Test klasse toe te voegen aan het project zijn volgende stappen noodzakelijk:

* Rechtsklik op de map in het project waar de Coded UI Test gewenst wordt
* Selecteer "Add"
* Selecteer "New Item"

 ![toevoegen van een 'new item'](/OverigeDocumenten/Afbeeldingen/CUITBuilder1.PNG)
* Selecteer "Test"
* Selecteer "Coded UI Test (Windows Store apps)"

 ![Toevoegen van een Coded UI Test klasse](/OverigeDocumenten/Afbeeldingen/CUITBuilder2.PNG)

### 2.2.2 Een UI Map toevoegen aan het project

Om een UI map toe te voegen:

* Doe dezelfde stappen als bij "Coded UI Test klasse toevoegen"
* Selecteer "Coded UI Test Map" in plaats van "Coded UI Test (Windows Store apps)"

Wanneer men een Coded UI Test toevoegd aan het project is het belangrijk om steeds de juiste UI Map toe te voegen als variabele. Bovenaan de Coded UI Test klasse moet steeds een "using" statement toegevoegd worden voor de gecreerde UI Map. Als bijvoorbeeld de UI Map de naam “UIMap_ClinicHubPage” heeft moet er bovenaan staan:

 ```
 using Calidos.Maat.CodedUITests.Screens.Clinic.ClinicHub.UIMap_ClinicHubPageClasses;
 ```

Onderaan de Coded UI Test klasse moet ook de UI Map property veranderd worden naar iets zoals volgende lijnen code:
 
```
public UIMap_ClinicHubPage UIMapClinicHub
{
  get
  {
    if (map == null)
    {
      map = new UIMap_ClinicHubPage();
    }
    return map;
  }
}
private UIMap_ClinicHubPage map;
```

### 2.2.3 Mappen van besturingselementen

Als dit gebeurt is, is het mogelijk om tests te beginnen schrijven. Om een test te schrijven moet men eerst besturingselementen toevoegen aan de UI Map, het zogenaamde "Mappen van besturingselementen". Om dit te doen:

* Rechtsklik op het ".uitest" bestand
* Selecteer “Edit with Coded UI Test Builder”

De Coded UI Test Builder zal nu opstarten. Men moet zich vooral geen zorgen maken wanneer Visual Studio geminimaliseerd wordt. De Builder maakt hiermee duidelijk dat je eventueel een applicatie kan opstarten waarbij men besturingselementen wil mappen.

Het mappen van een besturingselement naar de UI Map gebeurt door de cirkelvormige marker ("add Assertions") te slepen naar de besturingselement. Wanneer de marker losgelaten wordt, wordt deze besturingselement opgelicht met een blauwe rand en zal er een nieuw venster verschijnen (Zie afbeelding onder).

 ![Add Assertions venster](/OverigeDocumenten/Afbeeldingen/CUITBuilder3.PNG)

Op het nieuwe venster kan meer informatie teruggevonden worden in verband met de geselecteerde besturingselement (eigenschappen). Als men op de pijl klikt bovenaan links in dit venster, zal het venster uitbreiden met een hiërarchie waarin de besturingselement zichtbaar wordt.

> **Nota:**
Omdat de Clinical Trials applicatie ‘Maät’ gecreëerd is als een Windows 10 Metro App, is de Coded UI technology (voornamelijk de Coded UI Test Builder) nog niet volledig aangepast om de hiërarchie van besturingselementen correct te detecteren. 

>Om de hiërarchie van besturingselementen correct te laten detecteren is het noodzakelijk om elke besturingselement een unieke automatisatie ID (UID) te geven. Op het moment van de stageopdracht was deze bij veel besturingselementen niet aanwezig, wat een bijkomend probleem opleverde. Meer hierover later.

### 2.2.4 Manueel UID's toewijzen

Om zeker te zijn dat besturingselementen juist gemapt zullen worden en makkelijk terug te vinden zijn in de toekomst door het testprogramma zelf, is het soms noodzakelijk dat men zelf de UID toewijst. Om dit te doen op een UWP applicatie:

* Open het XAML bestand waar de besturingselement zich bevindt
* Zoek naar de besturingselement in het XAML bestand
* Geef een AutomationId (UID) aan de besturingselement

In het voorbeeld hieronder werd een UID gegeven aan een list besturingselement. zodat de children van deze list later makkelijker gevonden kunnen worden.

 ![Add Assertions met hiërarchie](/OverigeDocumenten/Afbeeldingen/CUITBuilder4.PNG)

Wanneer de UID toegewezen is en men opnieuw de besturingselement selecteert met de marker zal de toegewezen naam zichtbaar zijn tussen de eigenschappen van de besturingselement.

 ![AutomationId in Add Assertions venster](/OverigeDocumenten/Afbeeldingen/CUITBuilder5.PNG)

### 2.2.5 Pop-up besturingselementen toevoegen aan de UI Map

Soms moeten er pop-up besturingselementen toegevoegd worden aan de UI Map. Dit kan niet zomaar door de marker te gebruiken. Een oplossing hiervoor is het gebruik van "Ctrl + i" wanneer men over de besturingselement zweeft die de pop-up voortbrengt. De Coded UI Test Builder zal hierdoor herkennen dat men de pop-up besturingselement wil selecteren.

![crosshair](/OverigeDocumenten/Afbeeldingen/croshair.png)

## 2.3 Maät ontdekken

### 2.3.1 Hiërarchisch navigatie ontwerp

In de eerste fase van de opdracht is er, zoals eerder vermeld, een hiërarchisch design opgesteld van alle navigatie die in de applicatie "Maät" mogelijk is. Dit gebeurde door alle navigatie uit te proberen en te documenteren naar welke pagina, of eventueel welke sub-pagina, een knop leidt. Zo kon er niet alleen een handig overzicht gecreëerd worden waarin we konden zien welke schermen het belangrijkste zijn, maar ook welke (voorlopig) minder belangrijk waren en gaf het een bijkomend voordeel, namelijk: de applicatie kon verkend worden. Wat dan weer handig was voor het verdere verloop van het project.

Het hiërarchisch design vertrekt vanuit de "ClinicHubPage". Dit is de hoofdpagina waarop men terecht komt als de applicatie gestart wordt (Na het inloggen). Van hieruit is een boomstructuur getekend naar alle pagina's waarnaar navigatie mogelijk is vanuit de "ClinicHubPage" (Zie afbeelding onder voor voorbeeld). Vervolgens is er voor elke hub-pagina een nieuw bestand gemaakt waarin dezelfde werkwijze gevolgd is als bij de "ClinicHubPage", namelijk al deze pagina's laten vertakken vanuit de respectievelijke pagina. 

![Voorbeeld: boomstructuur van "ClinicHubPage"](/OverigeDocumenten/Afbeeldingen/ClinicHub.jpg)

Bij elke tak is (op de pijl) geschreven welke knop of handeling ervoor zorgt dat we op die specifieke pagina terecht komen. Ook is er per pagina de belangrijkheid aangeduid in het testgebeuren. Sommige pagina's zijn namelijk nog niet af, of zijn zelfs nog in hun beginfase. Dit zijn dan pagina's die in het totale testproject minder prioriteit hebben ten opzichte van de pagina's die wel al af zijn of belangrijke informatie bevatten.

>De rode vakken stellen data-heavy pagina's voor die vrij uitgebreid zijn. Dit type pagina's is vrij belangrijk in de applicatie omdat deze data vaak andere pagina's kan beïnvloeden.

## 2.4 Planning

### 2.4.1 Testing + checklist


Om de applicatie Maät te testen, moeten verschillende stappen doorlopen worden.

**Fase 1**

Het leren werken met de coded-UI technologie zelf, er kan immers niet getest worden zonder kennis over de werking van deze technologie. Vervolgens is het de bedoeling om deze technologie toe te passen op enkele kleine projectjes, om zo vertrouwd te geraken met de code en technieken. 

**Fase 2**

Uitzoeken hoe de tests voor Maät het beste kunnen geschreven worden. Er wordt dan rekening gehouden met hoe de applicatie is opgebouwd, eventuele moeilijkheden die zich voordoen, wat de belangrijkste dingen zijn die getest moeten worden. Dit gebeurt simultaan met het opstellen van de testing checklist, waarbij alle elementen die getest moeten worden onder elkaar geschreven worden in verschillende categorieën. Bij het opstellen van de checklist zullen al een aantal tests geschreven worden (voor elk paradigma een aantal tests) maar wordt er nog niet zoveel in de breedte getest. 

**Fase 3**

Wanneer de checklist volledig af is, wordt de applicatie in de breedte getest. Dit wil zeggen dat alle elementen in de checklist voor elke pagina geanalyseerd worden (moet dit getest worden of niet) en nadien ook allemaal getest worden. Deze kunnen dan allemaal als getest gemarkeerd worden in de checklist. 

### 2.4.2 Testresultaten

Het schrijven van de tests is één ding. Maar wanneer deze tests zijn uitgevoerd, is het uiteraard ook de bedoeling dat er resultaten weergegeven kunnen worden. Daarom is het noodzakelijk om een tool te ontwikkelen die de testresultaten kan verwerken en op een overzichtelijke en eenvoudige manier kan rapporteren aan de projectleider. 
