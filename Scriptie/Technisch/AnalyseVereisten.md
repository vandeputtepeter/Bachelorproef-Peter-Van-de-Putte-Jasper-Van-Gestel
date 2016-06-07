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

## 2.2 De Coded UI Test Builder en UI Mapping

In deze sectie wordt beschreven hoe de coded UI Test Builder werkt en hoe UI Mapping gebeurt voor elk control. Er is heel wat tijd over gegaan vooraleer het duidelijk werd hoe deze testing tool werkte. Daarom zijn er ook regels en beschreven om de (toekomstige) code leesbaar en makkelijk aanpasbaar te maken en houden.

### 2.2.1 Hoe werkt het

#### 2.2.1.1 Een Coded UI Test klasse toevoegen aan het project

Om een Coded UI Test klasse toe te voegen aan het project zijn volgende stappen noodzakelijk:

* Rechtsklik op de map in het project waar de Coded UI Test gewenst wordt
* Selecteer "Add"
* Selecteer "New Item"

 ![toevoegen van een 'new item'](/OverigeDocumenten/Afbeeldingen/CUITBuilder1.PNG)
* Selecteer "Test"
* Selecteer "Coded UI Test (Windows Store apps)"

 ![Toevoegen van een Coded UI Test klasse](/OverigeDocumenten/Afbeeldingen/CUITBuilder2.PNG)

Om een UI map toe te voegen:

* Doe dezelfde stappen als hiervoor
* Selecteer "Coded UI Test Map" in plaats van "Coded UI Test (Windows Store apps)"

Wanneer men een Coded UI Test toevoegd aan het project is het belangrijk om steeds de juiste UI Map toe te voegen als variabele. Bovenaan de Coded UI Test klasse moet steeds een "using" statement toegevoegd worden voor de gecreerde UI Map. Als bijvoorbeeld de UI Map de naam “UIMap_ClinicHubPage” heeft moet er bovenaan staan:

 `using Calidos.Maat.CodedUITests.Screens.Clinic.ClinicHub.UIMap_ClinicHubPageClasses;`

Onderaan de Coded UI Test klasse moet ook de UI Map property veranderd worden naar iets zoals volgende lijnen code:
 
`public UIMap_ClinicHubPage UIMapClinicHub
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
private UIMap_ClinicHubPage map;`

Als dit gebeurt is, is het mogelijk om tests te beginnen schrijven. Om een test te schrijven moet men eerst controls toevoegen aan de UI Map, het zogenaamde "Mappen van controls". Om dit te doen:

* Rechtsklik op het ".uitest" bestand
* Selecteer “Edit with Coded UI Test Builder”

De Coded UI Test Builder zal nu opstarten. Men moet zich vooral geen zorgen maken wanneer Visual Studio geminimaliseerd wordt. De Builder maakt hiermee duidelijk dat je eventueel een applicatie kan opstarten waarbij men controls wil mappen.

Het mappen van een control naar de UI Map gebeurt door de cirkelvormige marker ("add Assertions") te slepen naar de control. Wanneer de marker losgelaten wordt, wordt deze control opgelicht met een blauwe rand en zal er een nieuw venster verschijnen (Zie afbeelding onder).

 ![Add Assertions venster](/OverigeDocumenten/Afbeeldingen/CUITBuilder3.PNG)

Op het nieuwe venster kan meer informatie teruggevonden worden in verband met de geselecteerde control (eigenschappen). Als men op de pijl klikt bovenaan links in dit venster, zal het venster uitbreiden met een hiërarchie waarin de control zichtbaar wordt.

> **Nota:**
Omdat de Clinical Trials applicatie ‘Maät’ gecreëerd is als een Windows 10 Metro App, is de Coded UI technology (voornamelijk de Coded UI Test Builder) nog niet volledig aangepast om de hiërarchie van controls correct te detecteren. 

>Om de hiërarchie van controls correct te laten detecteren is het noodzakelijk om elke control een unieke automatisatie ID (UID) te geven. Op het moment van de stageopdracht was deze bij veel controls niet aanwezig, wat een bijkomend probleem opleverde. Meer hierover later.

To make sure control’s or lists are properly mapped and easy to find by the testprogram itself, we sometimes gave AutomationId’s to the control’s ourselves. To do this, open the XAML file of the page you want to test, and then search for an indication out of which you can derive this section is the section you want to give an AutomationId.

Example: I gave a unique Id to a list, so I can later easily access the childs of that list

 ![Add Assertions met hiërarchie](/OverigeDocumenten/Afbeeldingen/CUITBuilder4.PNG)

I wanted to give a unique Id to the list of Studies-searchresults, so I searched the XAML file for a while, tried naming some different grid’s and gridviews, untill I named the right one. Now if I select that list with the Coded UI Test Builder, the name I gave to it will appear as AutomationId, as seen below.

 ![CUITBuilder5](/OverigeDocumenten/Afbeeldingen/CUITBuilder5.PNG)

##### Adding popup controls to the UIMap
Sometimes, we have to add control’s or menu’s to the UIMap that are only visible after clicking a certain button/control. If we just drag the croshair of the CodedUITestBuilder onto the screen, the popupmenu will disappear. A solution for this is using the “Ctrl-i”-combination while hovering over the menu, which will directly select the menu. 


![crosshair](/OverigeDocumenten/Afbeeldingen/croshair.png)


## 2.3 Maät ontdekken

### 2.3.1 Hiërarchisch navigatie ontwerp

In de eerste fase van onze opdracht is er, zoals eerder vermeld, een hiërarchisch design opgesteld van alle navigatie die in de applicatie "Maät" mogelijk is. Dit gebeurde door alle navigatie uit te proberen en te documenteren naar welke pagina, of eventueel welke sub-pagina, een knop leidt. Zo kon er niet alleen een handig overzicht gecreëerd worden waarin we konden zien welke schermen het belangrijkste zijn, maar ook welke (voorlopig) minder belangrijk waren en gaf dit het bijkomende voordeel dat de applicatie verkend kon worden. Dit werd handig bij het verdere verloop van het project.

Het hiërarchisch design vertrekt vanuit de "ClinicHubPage". Dit is de hoofdpagina waarop men terecht komt als de applicatie gestart wordt (Na het inloggen). Van hieruit is een boomstructuur getekend naar alle pagina's waarnaar navigatie mogelijk is vanuit de "ClinicHubPage" (Zie afbeelding onder voor voorbeeld). Vervolgens is er voor elke hub-pagina een nieuw bestand gemaakt waarin dezelfde werkwijze gevolgd is als bij de "ClinicHubPage", namelijk al deze pagina's laten vertakken vanuit de respectievelijke pagina. 

![Voorbeeld: boomstructuur van "ClinicHubPage"](/OverigeDocumenten/Afbeeldingen/ClinicHub.jpg)

Bij elke tak is (op de pijl) geschreven welke knop of handeling ervoor zorgt dat we op die specifieke pagina terecht komen. Ook is er per pagina de belangrijkheid aangeduid in het testgebeuren. Sommige pagina's zijn namelijk nog niet af, of zijn zelfs nog in hun beginfase. Dit zijn dan pagina's die in het totale testproject minder prioriteit hebben ten opzichte van de pagina's die wel al af zijn of belangrijke informatie bevatten.

>De rode vakken stellen data-heavy pagina's voor die vrij uitgebreid zijn. Dit type pagina's is vrij belangrijk in de applicatie omdat deze data vaak andere pagina's kan beïnvloeden.

## 2.4 Planning

