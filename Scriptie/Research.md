# 5 Research

## 5.1 Geïmplementeerde research

### 5.1.1 Self-extracting zip



## 5.2 Niet-geïmplementeerde research

### 5.2.1 Windows Store For Business (SFB)

#### 5.2.1.1 Opdracht

Tijdens de stage is er de vraag geweest om een diepere kijk te nemen betreffende de Windows Store For Business met het oog op het distribueren van de applicatie. Enkele doelen werden opgelijst

- Hoe publiceer ik een applicatie op de Microsoft Store
- Hoe publiceer ik deze applicatie op de Windows Store For Business
- Hoe link ik een computer met de Store For Business
- Hoe link ik een computer met meerdere Strores Fro Business van meerdere bedrijven
- Hoe kan version upgrading gedaan worden, als de Store For Business gebruikt wordt
- Is er de mogelijkheid om Power Shell te gebruiken

Bijkomend na eerste fase in research:

- Hoe kan Windows Intune ons hierbij helpen

#### 5.2.1.2 Bevindingen



### 5.2.2 Data Driven UI Tests

#### 5.2.2.1 Wat zijn data driven UI tests

Alle variabele logica binnen de code van de UI tests zou altijd apart moeten worden gehouden, bijvoorbeeld in een database of datatabel. Deze data noemt men dan de test dataset of dataconfiguratie. Het voordeel hierbij is, dat men een grotere code coverage zal creëren op de betreffende UI test. Data driven tests zijn dus tests die op zich maar 1 enkele functie uittesten (gewoonlijk zijn dit lees en verificatietests) maar toegepast worden op een breed stuk code dankzij de dataset die ter beschikking gesteld wordt.

> In het onderzoek naar data driven tests is er gebruik gemaakt van CSV bestanden als datatabel (via Excel)

#### 5.2.2.2 Hoe gebruik ik data driven UI tests

normale testmethode:

```
[TestMethod]
        public void Method1()
        {
            //testcode...
        }
```


testmethode met datasource:

```
[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]
        public void ClickPatientSearchResults()
        {
            
            // set searchproperty to value in datafile
            UIMap.UICalidosMaatWindowsWindow.UISemanticZoomSemanticZoom.UIPatiëntenHubSection.UIPatiëntenText.UIItemList.UICalidosMaatClientLogListItem1.SearchProperties[XamlControl.PropertyNames.Instance] = TestContext.DataRow[0].ToString();
            
            // create control based on new searchproperty
            XamlControl Control = new XamlControl(UIMap.UICalidosMaatWindowsWindow.UISemanticZoomSemanticZoom.UIPatiëntenHubSection.UIPatiëntenText.UIItemList.UICalidosMaatClientLogListItem);
            
            //testcode...
        }
```
        
De DataSource-functie heeft 4 variabelen nodig:

* Provider name: bij dit onderzoek was de provider CSV
  * Microsoft.VisualStudio.TestTools.DataSource.CSV
* Connectie string
* Tabel naam
* Data toegang methode


In deze testmethode is er een datafile gebruikt om de zoekeigenschap van een control die we willen uit testen te specificeren. Dit gebeurt in de CSV file zodat het mogelijk wordt om variabelen binnen de testcode te definiëren zonder effectief code te veranderen.

Het is mogelijk om kolom namen te vernoemen om de datakolom te specificeren op volgende wijze:
```
TestContext.DataRow["columnName"].ToString();
```
De testmethode zal de rest van de test herhalen voor elke rij data in de datafile.

#### 5.2.2.3 Bevindingen

Er is vroeg gekeken naar data driven tests omdat het mogelijk was dat er van bij de start dan op een bepaalde manier gewerkt moest worden om de tests op te stellen. Er is heel kort de intentie geweest om zoveel mogelijk data driven te gaan doen. Hoewel dit absoluut aan de orde was geweest op lange termijn was het niet interessant genoeg om heel diep in het data-driven-test-wereldje te duiken en te concluderen dat alles getest zou zijn geweest van een welbepaald onderwerp, maar praktisch niets van de gehele applicatie. De documentatie over data driven tests is dus geen verloren moeite, maar het uitvoeren en in gebruik nemen van dit type tests zou eerder voor de toekomst zijn. 
