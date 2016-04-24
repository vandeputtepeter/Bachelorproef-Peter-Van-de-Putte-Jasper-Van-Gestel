>Deze bestanden representeren een tijdelijke voorstelling van de scriptie 
## Methoden en technieken

### Benaming van testmethoden

In dit onderdeel beschrijven we een aantal regels, door ons opgesteld, waaraan de namen van alle geschreven testmethodes moeten voldoen. De visie op deze naamgeving is dat je aan de naam van een testmethode alle informatie over wat er getest wordt kan afleiden. De reden hiervoor is dat wanneer we een verslag terug krijgen van alle uitgevoerde tests en bepaalde tests zijn gefaald, we meteen kunnen zien welk paradigma in de applicatie niet werkt zoals het hoort te werken, en dit door gewoon de naam van de testmethode te lezen. Waarom dit paradigma gefaald is wordt weggeschreven in een test-log, waar we later op terugkomen.

Na een brainstorm sessie over de benamingen van testmethoden zijn we tot het volgende resultaat gekomen:

Page name + Paradigm (+ Context) (+ Xaml Control Type Property) (+ Optional Info)

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
* "Optional Info":
  * Optionele parameter
  * Duidt op de info die je bij sommige tests nodig hebt om volledig duidelijk te maken wat er exact getest wordt. Dit kan allerhande informatie zijn.
  * Bijvoorbeeld: Een bepaalde state waarin de pagina zich bevind voor die specifieke test.

>Het is noodzakelijk dat minstens één van de optionele parameters ook aanwezig is in de testmethodebenaming om verduidelijking te geven over de betreffende testmethode.


### ## Bestandsstructuur

In dit onderdeel hebben we een aantal regels opgesteld voor de onderverdeling van de verschillende testprojecten. De visie hier is dat we niet alle tests van het gehele project in 1 grote klasse mogen schrijven (wat de onderhoudbaarheid nagenoeg onmogelijk maakt). tegelijkertijd mogen we ook niet voor elke testmethode een nieuwe klasse aanmaken, aangezien er dan teveel files zouden ontstaan. Een gulden middenweg die we gevonden hebben na enkele besprekingen met onze promotors, is dat we voor elk hoofdparadigma, per pagina, een nieuwe klasse aanmaken, en dat we voor elke pagina één UIMap-klasse maken die gebruikt wordt in alle testprojecten voor de betreffende pagina. Ook hebben we na overleg beslist dat we bij elke pagina die verschillende sub-tabs bevat, elke sub-tab als één volledige pagina beschouwen. Deze worden dus onderverdeeld alsof het aparte pagina's zijn. 

Door bovenstaande regels in acht te nemen, hebben we volgende file structuur opgebouwd: 

* **Screens**
  * Bestand dat alle UIMap's en Testklassen bevat die zich bevinden in sub-folders
  * **General UIMap**
    * UIMap die gebruikt wordt voor de base-klassen
  * **Partial base-klassen**
    * Base klassen die methoden definieert die overal terugkomen
  * **Globaal scenario bestanden** 
    * Scenario's opgesteld in .csv formaat die zich strekken over alle groeperingen
  * **Groepering**
    * Bijvoorbeeld: Clinic, Patient, ...
    * **Groepsniveau scenario bestanden**
      * Scenario's opgesteld in .csv formaat die zich strekken binnen groepsniveau
    * **Pagina**
      * Bijvoorbeeld: ClinicContactsPage, ClinicHubPage,...
      * **UIMap**
        * UIMap van de betreffende pagina
      * **Locale scenario bestanden**
        * Scenario's opgesteld in .csv formaat die zich strekt over enkel de pagina zelf
      * **Klasse per paradigma**
        * **Staten**
          *  Klasse die alle testen betreffende verschillende staten van een pagina bevat
        * **Navigatie**
          * Klasse die alle testen betreffende voorwaartse en achterwaartse navigatie naar pagina's bevat
        * **Functionaliteit**
          * Klasse die alle testen betreffende functionaliteit / inter-functionaliteit van controls bevat
        * **Content**
          * Klasse die alle testen betreffende data in de database of applicatie bevat
