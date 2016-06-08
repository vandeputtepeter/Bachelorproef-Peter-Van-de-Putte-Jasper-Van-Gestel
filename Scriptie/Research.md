# 5 Research

## 5.1 Geïmplementeerde research

### 5.1.1 Self-extracting zip



## 5.2 Niet-geïmplementeerde research

### 5.2.1 Windows Store For Business (SFB)



### 5.2.2 Data Driven UI Tests

#### 5.2.2.1 Wat zijn data driven UI tests



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

* Provider name: bij dit onderzoek is de provider CSV
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
