>Deze bestanden representeren een tijdelijke voorstelling van de scriptie 
## Methoden en technieken

### Bestandsstructuur

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
