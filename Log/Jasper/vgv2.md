# Voortgangsverslag 2 - _Jasper Van Gestel_

#*Coded UI Testing:*

# Promotors

* **Stagebegeleider:**
  * Naam: Patrick Van Houtven
  * E-mail: patrick.vanhoutven@ap.be
  * Gsm: 0474 66 57 15
* **Stagementor:**
  * Naam: Mark Devos
  * E-mail: Mark.devos@calidos.be
  * Gsm: 0475 69 13 42
* **Stagementor:**
  * Naam: Tom Wuyts
  * E-mail: Tom.wuyts@calidos.be
  * Gsm: /

# Abstract

De Bachelorproef bestaat erin om Coded UI testing uit te voeren op het *'Maät'* project van *Calidos BVBA*.

De set doelstellingen bestaat onder meer uit:

* Leren werken met de *'Coded UI Test Builder'* van *'Microsoft Visual Studio'*. Dit aan de hand van kleine projecten die zelf worden opgezet of al reeds bestaan.

* Het gehele proces zo automatisch mogelijk te maken. (test automation)

* Een *'Guideline voor de tester'* afleveren aan het eind van de stage die alle belangrijke informatie bevat omtrent gebruik, opstellen en werking van tests. Deze zal initieel kort zijn, maar zal in de loop van de bachelorproef verder aangroeien.


# Technische omschrijving

Het tweede (en laatste) deel van de stage zit er bijna op. In de loop van dit tweede deel zijn er heel wat dingen herschreven, verwijderd, uitgebreid of nieuwe dingen opgesteld. Het grootste verschil met het eerste deel van de stage is dat ik en Peter nu wel met echt verschillende dingen bezig zijn. Versta dit niet verkeerd, we werken nog steeds aan hetzelfde overkoepelende geheel. Het komt er meer op neer dit ik voornamelijk research heb gedaan naar het gebruik of de mogelijkheid om andere dingen te integreren in het project (op aanvraag van Mark).


## Korte omschrijving taken

Peter is zich momenteel aan het focussen op de uitbreiding van paradigma's in de applicatie. Analyseren en opstellen van tests. Voornamelijk is hij bezig geweest met de WorkBookConfig pagina. Deze bevat een hele hoop complexe controls en navigatie. Hij zal zich tot het einde van de stage vooral focussen op het maken en uitbreiden van onze tests, alsook de basis (paradigma's) voor nieuwe tests die hetzelfde stramien volgen om te testen.

Ook is hij veel bezig geweest met documenteren van alle noodzakelijke data met betrekking tot hoe, waar en waarom de tests op een bepaalde manier geschreven moeten worden. Hij heeft op zijn eentje zowat een goede 70% van de documentatie voor zich genomen. Of het zal niet veel schelen (de guideline bevat momenteel al 65 pagina's)

Ik ben bezig met 'Result Management Tools', ofwel tools die de result file die gegeneerd wordt uit de coded UI tests (.rtx, meer uitleg verder in het verslag) zal parsen naar een meer bruikbare XML file. Die dan op zijn beurt gebruikt wordt om samen met 2 andere XML's (die momenteel manueel gedefinieerd moeten worden) met een tweede tool geparset wordt naar een HTML file. Deze geeft een matrix weer waarin in één (of meerdere) oogopslag duidelijk wordt hoever de testing van het project vordert.

Ook heb ik tussendoor uitgezocht hoe deze in de buildstraat kan worden geintegreerd.

## Process

### Definiëren van XSD schema's

Om ervoor te zorgen dat een XML een bepaalde format moet volgen kan men gebruik maken van XSD bestanden. Een XSD bestand valideert in zekere zin een XML bestand dat gelinkt is aan deze XSD. XSD is geschreven in XML en is daardoor makkelijk te lezen en begrijpen.

#### Xsd2code++

Xsd2Code++ is een Add-in voor Microsoft Visual Studio. In het kort beschreven migrate Xsd2Code de XSD code naar C#. Het genereert automatisch een (partial) Designer.cs klasse die properties genereert uit de XSD data.

### Definiëren van Definition XML bestand

De definition XML is de eerste uit een reeks van 3 XML's die noodzakelijk zijn om het volledige 'test repport' weer te geven. Dit is een vereist bestand, omdat je zonder dit bestand geen situering hebt, geen idee waar het nu juist over gaat, of waarop de tests zijn uitgevoerd.

De definition XML bevat de definities. Specifiek, de definities van de X en Y assen. Er moet dus al beschreven worden welke waarden op de Y as (Category definitions of CategoryDefs) en welke waarden er in de X as (Object definitions of ObjectDefs) moeten staan.

Elke definition bestaat uit enkele vereiste attributen:

* Een ID, opgemaakt uit een GUID string, om uniek aan te duiden over welk object of category het gaat.
* Een name, de benaming van het Object/Category ter sprake.
* Een info, de benaming die beter specificeert wat de naam wil zeggen (met spaties, of gewoon extra uitleg). De info wordt momenteel nog niet gebruikt, maar was gepland als tooltip in de toekomst.
* Een level, origineel beschreef deze het niveau waarop het Objcet/Categort zich bevond. Deze wordt nu (in code) automatisch berekend, maar blijft vereist om te definiëren als lege string (Misschien wordt dit in de toekomst nog aangepast)

### Definiëren van Target XML bestand

De target XML is de tweede uit een reeks van 3 XML's die noodzakelijk zijn om het volledige 'test rapport' weer te geven. Dit is een vereist bestand, omdat je zonder dit bestand geen weet hebt van welke tests gemaakt moeten worden. 

Het is als het ware een bestand gemaakt voor de analist. De analist bekijkt de applicatie op een kritische manier en zoekt kritieke punten in de applicatie. Deze kritieke punten zullen dan gedefinieerd worden in de vorm van 'targets', tests die **moeten** (of juist niet) worden uitgevoerd.

Elk target bestaat uit enkele vereiste attributen:

* Een Category ID, opgemaakt uit een GUID string, om uniek aan te duiden over welke category het gaat.
* Een Object ID, opgemaakt uit een GUID string, om uniek aan te duiden over welk object het gaat.
* Een Target label, een enum waarbij gedefinieerd is of deze test noodzakelijk, niet noodzakelijk, afgewerkt of onbekend is.
  * Enum:
    * ToDo: De test is noodzakelijk en wordt verwacht een resultaat te krijgen
    * NotToDo: De test is niet noodzakelijk en wordt niet verwacht een resultaat te krijgen
    * Done: De test wordt door de analist als afgewerkt verklaart
    * Unknown: Default waarde, wanneer geen definitie is gezet in dit bestand, wordt het als onbekend beschouwt.

Men kan zich afvragen, "Waarom zou men manueel willen zeggen wanneer een test klaar is? Dit gebeurt toch automatisch?"

Inderdaad. Maar, soms zijn er meerdere tests voor eenzelfde 'kruispunt' (waar Object en Category kruisen). Neem bijvoorbeeld de 'BackButton' deze wordt in meerdere tests aangeroepen om controle te doen of de knop wel naar de juiste pagina terug navigeert. Dit wil zeggen dat men soms 10 keer een resultaat terug krijgen van deze knop. Er kan dus niet na 5 tests gezegd worden dat dit kruispunt 100% getest is. Hiervoor is dus dit attribuut toegevoegd. Zo kan aangeduidt worden wanneer iets werkelijk 100% getest is.

### Generatie van TRX bestand

Om het laatste van de 3 XMLs te genereren is het noodzakelijk de resultaten te verkrijgen uit de Coded UI Tests. Nadat de opdracht is gegeven om de tests uit te voeren treed een heel mechanisme in werking.

Eerst wordt er voor gezorgd dat elke Coded UI Test een "RegisterTest" methode bevat. Deze zal ervoor zorgen dat de mapping van de tests in de Result Management Tools juist gebeurt. Specifieker bekeken zorgt deze methode ervoor dat de juiste Object ID en Category ID worden meegegeven, voorafgegaan door "MaatTest|". De tag die voorafgaat ("MaatTest|") is noodzakelijk zodat kan teruggevonden worden waar deze data juist beschreven is. Het TRX bestand dat dan gegenereerd wordt bevat in de DebugTrace sectie van de desbetreffende test, de data die we nodig zullen hebben om de mapping te kunnen verwezenlijken.

### TRX to XML tool

De eerste van de twee Result Management Tools is de TRX to XML tool. Deze doet exact wat er van de naam verwacht wordt.

De parsing is noodzakelijk om drie redenen:

* Duidelijke leesbaarheid
* Alle overbodige informatie wordt weggefilterd
* Zelfde formaat als de twee andere bestanden die we als input nodig hebben

Er worden dus results gegenereerd die enkel de nuttige informatie van het TRX bestand bevatten.

Elk result bestaat uit enkele vereiste attributen:

* Een Test ID, de benaming die gegeven is aan de test bij het opstellen van de Coded UI Test.
* Een Category ID, opgemaakt uit een GUID string, om uniek aan te duiden over welke category het gaat.
* Een Object ID, opgemaakt uit een GUID string, om uniek aan te duiden over welk object het gaat.
* Een Result label, een enum waarbij gedefinieerd is of deze test geslaagd, gefaald, afgebroken of niet uitgevoerd is.
  * Enum:
    * Passed: De test is geslaagd
    * Failed: De test is niet geslaagd
    * Aborted: De test werd gestart en was tijdens het uitvoeren onderbroken (meestal manueel)
    * NotExecuted: De test werd niet uitgevoerd, meestal het gevolg van een voorgaande test die "Aborted" of afgebroken was

### XML to HTML tool

De eerste van de twee Result Management Tools is de XML to HTML tool. Deze doet (ook al) exact wat er van de naam verwacht wordt.

Het moet hier alleen wel nog net iets duidelijker toegelicht worden. De bedoeling van de tool is om schematisch en duidelijk weer te kunnen geven hoe ver het testen van de applicatie staat. Aangezien met een dubbele as gewerkt wordt (we moeten met belangrijke dingen rekening houden), wordt gebruik gemaakt van een matrix.

De matrix gebruikt alle drie voorgaande XML bestanden om de juiste informatie te verkrijgen en gegenereerd te worden. De matrix kan ook opgesteld worden met slechts de twee eerste XML bestanden. Dit geeft wel enkel een beeld van welke tests verwacht worden te slagen, ofwel de Analyse-matrix.

De "XML to HTML" tool stelt dus de matrix op. Het zal deze eerst in geheugen maken. en dan de juiste waarden en informatie uitprinten in een HTML tabel. Voor het genereren in geheugen volgt het programma enkele stappen:

* Definition XML:
  * Toewijzen van de assen
  * De Objecten zullen ingevuld worden in de horizontale as
  * De categories zulen ingevuld worden in de verticale as
* Creeren van cellen:
  * Genereert cellen aan de hand van het aantal waarden in de horizontale en verticale assen
  * De horizontale as waarden maal de verticale as waarden
* Target XML:
  * Toewijzen van analyse-data
  * De targets mappen naar de juiste cel, die dus overeenkomt met de Object en Category ID
* Result XML:
  * Overschrijven van analyse-data met werkelijke resultaten
  * De results mappen naar de juiste cel, die dus overeenkomt met de Object en Category ID
* Berekenen van totalen:
  * Omdat er veel data zichtbaar gemaakt moet worden is het niet altijd handig om alles tot op het laagste niveau weer te geven. Daarom is er beslist dat de tabel inklapbaar moet worden en alle onderliggende resultaten dan weer te geven in deze ene "Parent" cel. (Via JQuery, meer in volgend puntje)

Nadat de data in het geheugen zit is het bijna kinderspel om deze weer te geven in HTML vorm. In de tool wordt dit gedaan met de "HtmlTextWriter" klasse. Deze voorziet een streamwriter die al reeds HTML tags herkent en je dus ook in staat stelt deze snel te kunnen schrijven. Zo kan het de begin en end tag genereren, klassen en id's toevoegen, style aanpassen, etc.

Via de "HtmlTextWriter" wordt dan de juiste data in een tabel gegoten. Alle elementen krijgen Id's en klassen toegekend die dan via een CSS bestand visueel worden versterkt.

Er wordt ook gezorgd dat alle links naar de assets (zie volgend puntje) worden bijgezet. Er zijn in dit geval twee assets. Een JavaScript bestand en een CSS bestand die elk een deel van de weergave op zich nemen.

Onder de tabel wordt er nog een kleine tabel gegenereerd die dienst doet als legende van de "Result Table" (De tabel die dus de results weergeeft). Hierin wordt verduidelijkt voor wat elke kleur staat en waarvoor de waarden in de cellen staan.

Als laatste wordt er daaronder nog een lijst weergegeven die weergeeft welke tests faalden en dus ook geen resultaat opleverden in het TRX bestand. Waardoor enkel de Test ID naam werd doorgegeven en er dus geen extra informatie beschikbaar is. Deze lijst moet de tester alarmeren en hem duidelijk maken dat hij naar desbetreffende testen moet kijken om deze aan te passen.


### Assets voor HTML


#### Javascript JQuery voor HTML

Omdat er veel data beschikbaar is, is het handig om alles netjes en duidelijk weer te geven zodat het geen chaos van cijfers en letters wordt. Via JQuery word bijvoorbeeld gebruik gemaakt van een kleine functie die samen met CSS de horizontale headers rechtzet zodat al een hele hoop plaats bespaard wordt.

Het voornaamste dat in de JQuery code gebeurt is het collapsen, oftewel inklapbaar maken van de tabel. Deze is momenteel nog niet honderd procent in orde en kan dan ook nog niet volledig toegelicht worden.

#### CSS voor HTML

Via een CSS bestand zorgen we voor een goede opmaak om alles nog meer te verduidelijken.

Met de "HtmlTextWriter" is er namelijk voor gezorgd dat alle elementen een klasse of id toegekend krijgen naargelang resultaat van de cel, headertpye, level of niveau van het object of category, plaats op het scherm, etc.

### Test Automation

Omdat waren problemen om de TRX bestanden te genereren. Deze problemen waren:

* Tests moesten manueel uitgevoerd worden via invoer van een commando in de "Developer Command Prompt for VS2015"
* De computer waarop de tests uitgevoert werden werdt onbeschikbaar omdat de tests vereisen dat de muis en het keyboard ter beschikking van de test blijft.

Hierdoor kon het vaak een uur duren vooraleer men als tester kon verderwerken. Dit is uiteraard niet gewenst. De oplossing zou zijn om deze in de build-straat te kunnen verwerken en deze tests op een virtual machine (VM) te laten uitvoeren.

Na enige research naar de integratie in de DOBT (build-straat) van onze Coded UI Tests kwam het idee om met een Test Manager en Test Agents te werken. Via de Team Foundation Server (TFS) zou dit moeglijk moeten zijn. Men installeert dan een Test Manager in de TFS en installeert een Test Agent op een VM die gekoppeld is aan de TFS. De Test Manager zorgt voor de links met de Test Agents. Die dan de applicatie geployed krijgen. De Test Agents zullen dan de tests uitvoeren op hun versie van de applicatie.

Dit lijkt allemaal perfect en goed. Maar natuurlijk weten we als developers dat dit niet het geval is. Er kwamen namenlijk al gouw kleine, en dan snel grote problemen opduiken.

De TFS waarop Calidos momenteel werkt is TFS2013. Als je goed weet wat onze thesis inhoudt gaat er waarschijnlijk al een belletje rinkelen. In 2013 bestond Windows 10 namelijk nog niet. Aangezien de applicatie als target OS Windows 10 heeft kunnen Test Managers op de TFS2013 en dus ook op hun VM's de Test Agents geen deploy doen van de applicatie omdat Windows 8 de meest recente OS is.

Na enig overleg met Mark en Tom hebben we dus dit deel voorlopig in de kast gestoken. Een upgrade van de TFS zal waarschijnlijk in de toekomst wel worden doorgevoerd, waardoor Automation mogelijk zal worden.

## Extra informatie

### Bijscholingen

Does Not Apply

### Nieuwe contacten

Does Not Apply

### Literatuur

* https://msdn.microsoft.com/en-us/library/ee943321.aspx
* https://msdn.microsoft.com/en-us/library/dd380688.aspx
* https://msdn.microsoft.com/en-us/library/ff400223.aspx
* https://msdn.microsoft.com/en-us/library/hh546460%28v=vs.120%29.aspx
* https://msdn.microsoft.com/en-us/library/system.web.ui.htmltextwriter%28v=vs.110%29.aspx
