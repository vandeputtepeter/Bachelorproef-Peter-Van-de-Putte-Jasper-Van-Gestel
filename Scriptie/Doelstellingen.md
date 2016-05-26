# Introductie

## Situering

Als bachelorproject hebben we "Coded UI Testing" moeten toepassen op het Maät project, dat nog steeds in ontwikkeling is door "Calidos". Het Maät project is een Windows 10 applicatie die bedoelt is om clinical trials op te volgen in ziekenhuizen.

## Stagebedrijf

Calidos is een IT-bedrijf dat zich specialiseert in software voor de healthcare sector. Een KMO met veel groeipotentieel en een duidelijke visie op hoe de software nuttig en tegelijk overzichtelijk informatie moet worden weergeven om het dagelijkse werk bij ziekenhuizen praktisch en efficiënt te laten verlopen.

## Opgave

### Opleveren van een "Testing Guideline"

* Hoe moet de applicatie getest worden?
* Hoe moet testing automation toegepast worden op de applicatie?
* Hoe ga je best te werk als je hieraan moet beginnen?

Stap voor stap toelichten hoe je dit doet en wat er nodig is om dit te verwezenlijken.

#### Opleveren van een "Testing Checklist" als onderdeel van de "Testing Guideline"

* Welke criteria moeten getest zijn om zeker te zijn dat de control / pagina volledig is uitgetest

Opstellen van een lijst criteria, die "afgevinkt" kan worden en zo duidelijk weergeeft in hoeverre de applicatie getest is. De lijst zal dan in een soort matrix worden voorgesteld met langs de ene as een opsomming van paradigma's en sub-paradigma's en langs de andere as een opsomming van pagina's en controls.

> Als "zij-project" werd er de laatste 5 weken gevraagd of het mogelijk was om een kleine applicatie te schrijven die het mogelijk maakt om, via de DOBT, deze matrix weer te geven in "real-time". Waar we mee willen zeggen dat de matrix het resultaat zal zijn van drie afzonderlijke bestanden.
* Een "Definition" document
  * Definities van paradigma's op de ene en pagina's / controls op de andere matrix-as in XML formaat
* Een "Result" document
  * Resultaat van de testen, die 's nachts op de DOBT uitgevoerd werden in XML formaat
* Een "Target" document
  * Automatisch gegenereerd document. Dit gebeurt via de matrix applicatie, waar men manueel kan invoeren welke testen uitgevoerd moeten worden door de gewenste cellen op "TO DO" in te stellen.

> Als resultaat krijgt men een matrix die opgesteld wordt via het "Definition" document. De cellen worden dan eerst invult volgens het "Target" document en vervolgens overschreven met de resultaten uit het "Result" document.

#### Opleveren van een "Testing Log" als onderdeel van de "Testing Guideline"

* Welke bugs en niet werkende elementen / foutjes bij controls zijn er aanwezig in de applicatie

Documenteren waar er zich problemen voordoen en wanneer mogelijk ook waarom. Ook problemen die zijn tegengekomen en hoe deze ondertussen verholpen zijn werden gedocumenteerd. Visuele foutjes, dingen die lichtjes verschillen op verschillende pagina's maar in wezen wel dezelfde control zijn,... Al deze dingen staan in dit document beschreven.
