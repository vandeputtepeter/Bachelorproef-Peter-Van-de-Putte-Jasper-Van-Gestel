# Data Driven CUI-tests
##How to include and use a datasource file into the testproject
normal testmethod:

```
[TestMethod]
        public void Method1()
        {
            //testcode...
        }
```


testmethod with datasource:

```
[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]
        public void ClickPatientSearchResults()
        {
            
            // set searchproperty to value in datafile
            UIMap.UICalidosMaatWindowsWindow.UISemanticZoomSemanticZoom.UIPatiëntenHubSection.UIPatiëntenText.UIItemList.UICalidosMaatClientLogListItem1.SearchProperties[XamlControl.PropertyNames.Instance] = TestContext.DataRow[0].ToString();
            
            // create control based on new searchproperty
            XamlControl Control = new XamlControl(UIMap.UICalidosMaatWindowsWindow.UISemanticZoomSemanticZoom.UIPatiëntenHubSection.UIPatiëntenText.UIItemList.UICalidosMaatClientLogListItem);
            
            //testcode...
        }```
        
The DataSource-function gets 4 variables:
* Provider name: in this case csv will be the provider (Microsoft.VisualStudio.TestTools.DataSource.CSV)
* Connection string
* Table name
* Data access method

In this testmethod, we used a datafile to specify the searchproperty of a control we want to test, so we can manualy adjust the controls in the datafile without having te rewrite the whole testcode/UI-map.
You can also use column names to specify the datacolumn like this ```TestContext.DataRow["columnName"].ToString();```. The testmethod will repeat the test for each row of data in the datafile.

