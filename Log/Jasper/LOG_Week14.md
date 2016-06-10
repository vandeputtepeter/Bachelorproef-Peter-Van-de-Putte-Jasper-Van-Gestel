# Logboek - _Jasper Van Gestel_

### Week 14 (16/5/'16 - 22/5/'16)

**Maandag**

* Niet gewerkt - Feestdag

**Dinsdag**

* Na een ganse voormiddag zoeken, eindelijk geslaagd in collapsen van rijen
* Verder aan het uitzoeken hoe ik collapsen in twee richtingen kan doen laten werken
* Hoogtepunt van de afgelopen 2 weken!
  * Collapse - Expand werkt 100% in 2 richtingen
    * Klassen gegeven aan cellen die horizontale en verticale waarden bijhouden
      * waarden geven aan of de cel getoond of verstopt moet worden
* Nieuwe To Do lijst aangemaakt in overleg met Mark
  * Enkele puntjes herbekijken / aanpassen / maken

**Woensdag**

* Aanpassen van kleinigheden
  * Uitleg 'Failed Tests', en aanpassing 'Legend' --> verduidelijken van inhoud
  * Controleren of Fails juist optellen
    * Opgelost, ToDo naar Failed gezet bij matrixCell klasse
      * Foutje bij vorige aanpassing
* Verbeteren van sommering logaritme
  * Momenteel --> zoekt 3 keer een cel op waarden 'i,j'
    * Te veel loops zorgen voor slechte schaalbaarheid en performantie
  * Bezig het logaritme te verbeteren
  * Veel tijd gekropen in het bedenken van een haalbare, en sneller versie

**Donderdag**

* Oplossen van problemen bij verandering
  * Instantieren van List property in MatrixCell, gaf voorheen een 'niet ingesteld op object' error
  * TargetName toegevoegd aan XSD bestand bij Target
    * Duidt aan welk object en paradigma
    * Voorheen enkel zichtbaar via GUID --> zegt niet veel op zich
  * Wordt maar 1 child ingevuld in de lijst met children als er meerdere aanwezig moeten zijn
    * Meerdere children worden nu toegevoegd
  * Children worden nu dan weer niet hiërarchisch toegevoegd, eerder chaotisch zonder logica
    * Opgelost, Kleine foutjes in mijn code aangepast, recursiviteit verbeterd
  * Nieuw probleem ontstaan: HTML genereert nu trager bij meer data
    * Peter had data uitgebreidt met WorkBookConfig pagina --> Trage generatie van HTML
  * Optellen lukt ook, alleen lijkt het niet 100% juist op te tellen --> nog te tweaken

**Vrijdag**

* Niet gewerkt

**Weekend**

* Niet gewerkt