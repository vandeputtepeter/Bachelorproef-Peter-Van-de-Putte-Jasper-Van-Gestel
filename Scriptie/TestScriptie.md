

# Testscriptie

## Inhoud

### 1. Doelstelling
[Plan van aanpak.](https://github.com/vandeputtepeter/Bachelorproef-Peter-Van-de-Putte-Jasper-Van-Gestel/blob/master/OverigeDocumenten/Plan%20van%20aanpak%20nieuw.docx)

### 2. Werkwijze

[Plan van aanpak.](https://github.com/vandeputtepeter/Bachelorproef-Peter-Van-de-Putte-Jasper-Van-Gestel/blob/master/OverigeDocumenten/Plan%20van%20aanpak%20nieuw.docx)
### 3. Testing guideline

### 4. Bronnen





























### Maät
We gaan Coded UI-tests schrijven voor de “Maät” applicatie van Calidos. Dit is een applicatie die klinische studies opvolgt.

Coded UI-tests zijn tests om de werking van de User Interface te controleren (wat je anders handmatig zou doen). Het voordeel van deze geautomatiseerde tests is dat deze veel sneller gaan en alle aspecten dekken (als gebruiker zie je snel iets over het hoofd). 
 
Het testen zelf is echter niet het belangrijkste, aangezien de applicatie in de toekomst nog kan wijzigen en onze tests dan niets meer waard zijn. Het is veel belangrijker dat we een gedetailleerde guideline schrijven waarin beschreven staat hoe de applicatie getest moet worden, waaraan de applicatie moet voldoen om het schrijven van tests zo eenvoudig en efficiënt mogelijk te laten gaan, en welke onderdelen al getest zijn. Zo kan een eventuele opvolger (of ook wijzelf tijdens het proces) bij wijzigingen in de applicatie zeer snel traceren waar de tests moeten aangepast worden en hoe dit moet gebeuren. 


## 2. Plan van aanpak

### Hiërarchie
Eerst en vooral moeten we de hiërarchie van de navigations binnen de applicatie in kaart brengen (wat intussen gebeurd is). Hierin kunnen we zien welke pagina’s naar waar navigeren om zo makkelijker te kunnen vastleggen welke navigations er per pagina getest moeten worden. 
To test
Vervolgens is het de bedoeling pagina per pagina na te gaan welk soort control ’s er zijn, welke handelingen deze kunnen uitvoeren en welke acties er op de pagina mogelijk zijn. 
Checklist
We beginnen met de basispagina’s die de meest gebruikte basisacties/control ’s bevatten (die zo goed als overal zullen terugkomen). 
Voor elke gevonden control/actie (met actie bedoelen we handelingen die meer als één control gebruiken om te voltooien) zoeken we dan uit hoe we deze zo efficiënt mogelijk kunnen testen. Deze methode documenteren we dan zodat wij, en onze eventuele opvolgers, deze altijd terug kunnen raadplegen wanneer nodig (voor volgende pagina’s etc.). We documenteren ook voor de pagina die we aan het testen zijn welke control ’s en acties reeds getest zijn, tot we ze allemaal hebben gehad. Op dit moment wordt de pagina als volledig getest verklaard.












