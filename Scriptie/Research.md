# 5 Research

## 5.1 Niet-geïmplementeerde research

### 5.1.1 Windows Store For Business (SFB)

#### 5.1.1.1 Opdracht

Tijdens de stage is er de vraag geweest van Calidos om een diepere kijk te nemen betreffende de Windows Store For Business met het oog op het distribueren van de applicatie. Enkele doelen werden opgelijst

- Hoe publiceer ik een applicatie op de Microsoft Store
- Hoe publiceer ik deze applicatie op de Windows Store For Business
- Hoe link ik een computer met de Store For Business
- Hoe link ik een computer met meerdere Strores Fro Business van meerdere bedrijven
- Hoe kan version upgrading gedaan worden, als de Store For Business gebruikt wordt
- Is er de mogelijkheid om Power Shell te gebruiken

Bijkomend na eerste fase in research:

- Hoe kan Windows Intune ons hierbij helpen

#### 5.1.1.2 Resultaten van research

Hieronder de conclusies die gelijst werden na diepgaand onderzoek naar de Store For Business.

>Het volledige document in verband met de research over de Store For Business is te vinden onder de "OverigeDocumenten/Documenten" folder

-	Store for Business is in zeker zin een feature van de Windows Store
  -	Implementeert dezelfde werkwijze als de Windows Store, met enkele voordelen specifiek voor een enkel bedrijf.
  -	De voordelen van Store for Business houden onder andere in:
    -	Alle apps van het bedrijf zijn zichtbaar voor alle/specifieke gebruikers binnen dat bedrijf
    -	Flexibele distributie van deze apps op alle devices van het bedrijf
      - Private Store is een feature van de Windows Store for Business
-	Windows Store for Business stelt in staat om apps in deze Private Store te zetten en deze beschikbaar te maken voor een beperkt publiek (bedrijven)
-	Enkel apps met online licenses kunnen in deze Private Store toegevoegd worden
-	Het beschikbaar stellen van een app in de Private Store duurt ongeveer 12 uur
-	Apps zonder certificaat kunnen in principe geïnstalleerd worden als de instellingen van de computer ingesteld staan als "modus voor ontwikkelaar"
  -	Naar verluidt enkel beschikbaar als men ontwikkelaar programma’s zoals VS op de computer heeft staan (de key zou deze modus activeren) > nog te controleren
  -	"instellingen" typen in Windows search > Bijwerken & beveiligen > voor ontwikkelaars
  -	Side-loading kan ook via deze weg ingesteld worden, aangezien er een "sideload modus" beschikbaar is onder deze tab
-	Line-of-Business (LOB) lijkt een mogelijke oplossing voor het gestelde probleem
  - Via Mobile Device Management (MDM) zoals Windows Intune lijkt het mogelijk om updates gesynched te houden met alle devices
  - LOB kan via de Windows SFB
  - Windows Intune
      - Aparaatbeheer via cloud
      - Beschermen van bedrijfsdata
      - Devices registreren op bedrijfsnetwerk --> via portaal
      - Na registratie is mogelijk certificaten, VPN, WiFi in te stellen op deze devices
        - Toegang tot bedrijfsgegevens verschaffen
        - Eigen applicaties kunnen via de Intune App Wrapper ook gebruikt worden binnen dit systeem
        - Het pushen en beschikbaar stellen van apps, alsook hun updates is makkelijk beheerbaar.
          - Enkel de ingeschreven devices zijn in staat deze te instaleren
          - Ook meteen verwijderd wanneer werknemer of device niet meer in het bedrijf werkt/hoort
      - Kostprijs: Rond de 5 euro per maand per gebruiker (volgens Microsoft website, maar is onderhevig aan veranderingen.)

#### 5.1.1.3 Bevindingen van Calidos

Er waren teveel factoren die verhinderde om de applicatie te distribueren en de applicatie tegelijk aan alle voorwaarden te laten voldoen die noodzakelijk waren. De Windows Store For Business nam 12 uur de tijd om een nieuwe versie te distribueren. Dit was te lang. Er werd dan gevraagd om het "Windows Intune" verhaal te bekijken. Deze deed ook niet volledig naar wens wat gezocht werd. Daarom is er beslist om andere mogelijkheden te bekijken.

### 5.1.2 Data Driven UI Tests

#### 5.1.2.1 Wat zijn data driven UI tests

Alle variabele logica binnen de code van de UI tests zou altijd apart moeten worden gehouden, bijvoorbeeld in een database of datatabel. Deze data noemt men dan de test dataset of dataconfiguratie. Het voordeel hierbij is, dat men een grotere code coverage zal creëren op de betreffende UI test. Data driven tests zijn dus tests die op zich maar 1 enkele functie uittesten (gewoonlijk zijn dit lees en verificatietests) maar toegepast worden op een breed stuk code dankzij de dataset die ter beschikking gesteld wordt.

> In het onderzoek naar data driven tests is er gebruik gemaakt van CSV bestanden als datatabel (via Excel)

#### 5.1.2.2 Hoe gebruik ik data driven UI tests

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
[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|data.csv", "data#csv",
DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]
public void ClickPatientSearchResults()
{           
    // set searchproperty to value in datafile
    UIMap.UICalidosMaatWindowsWindow.UISemanticZoomSemanticZoom.UIPatiëntenHubSection.UIPatiëntenText.
    UIItemList.UICalidosMaatClientLogListItem1.SearchProperties[XamlControl.PropertyNames.Instance] = TestContext.DataRow[0].ToString();
            
    // create control based on new searchproperty
    XamlControl Control = new XamlControl(UIMap.UICalidosMaatWindowsWindow.UISemanticZoomSemanticZoom
    .UIPatiëntenHubSection.UIPatiëntenText.UIItemList.UICalidosMaatClientLogListItem);
            
    //testcode...
}
```
        
De DataSource-functie heeft 4 variabelen nodig:

* Provider name: bij dit onderzoek was de provider CSV
  * Microsoft.VisualStudio.TestTools.DataSource.CSV
* Connectie string
* Tabel naam
* Data toegang methode

In deze testmethode is er een datafile gebruikt om de zoekeigenschap van een besturingselement die we willen uit testen te specificeren. Dit gebeurt in de CSV file zodat het mogelijk wordt om variabelen binnen de testcode te definiëren zonder effectief code te veranderen.

Het is mogelijk om kolom namen te vernoemen om de datakolom te specificeren op volgende wijze:
```
TestContext.DataRow["columnName"].ToString();
```
De testmethode zal de rest van de test herhalen voor elke rij data in de datafile.

#### 5.1.2.3 Bevindingen

Er is vroeg gekeken naar data driven tests omdat het mogelijk was dat er van bij de start dan op een bepaalde manier gewerkt moest worden om de tests op te stellen. Er is heel kort de intentie geweest om zoveel mogelijk data driven te gaan doen. Hoewel dit absoluut aan de orde was geweest op lange termijn was het niet interessant genoeg om heel diep in het data-driven-test-wereldje te duiken en te concluderen dat alles getest zou zijn geweest van een welbepaald onderwerp, maar praktisch niets van de gehele applicatie. De documentatie over data driven tests is dus geen verloren moeite, maar het uitvoeren en in gebruik nemen van dit type tests zou eerder voor de toekomst zijn. 

### 5.1.3 Test Automation (Integratie in Build-straat)

#### 5.1.3.1 Probleemstelling

Het uitvoeren van Coded UI Tests werd lange tijd manueel gedaan op de computer die ook gebruikt werd om code te ontwikkelen. Wanneer een Coded UI Test uitgevoerd wordt is het belangrijk om alle randapparatuur beschikbaar te stellen aan de computer, zodat de tests naar behoren kunnen worden uitgevoerd. Als dit niet het geval is, zal de gebruiker de test verstoren en 95% van de tijd een verkeerd resultaat laten genereren door de testing tool. Zoals gezegd is men dus tijdelijk de computer kwijt en zit de ontwikkelaar/tester met een productief "gat" waar men niets meer kan doen dan wachten tot de alle tests uitgevoerd zijn geweest.

Omdat er een hele hoop tests geschreven waren en de tijdsduur van deze tests te laten uitvoeren steeds langer werd, werd beslist om te kijken of we deze in de build-straat konden krijgen. Dit hield in dat er virtual machines moesten aangemaakt worden en deze tests daar uit te laten voeren. Er waren dus enkele vragen die beantwoord moesten worden:

- Is het mogelijk om de tests op virtual machines uit te voeren
- Zijn er speciale vereisten om dit mogelijk te maken

#### 5.1.3.2 Onderzoek naar implementatie in de build-straat

Er werd een virtual machine opgezet om dit te kunnen testen. Het zou te makkelijk geweest zijn als er geen probleem zou opduiken: Al doet men de uitvoer van de tests op een virtual machine, men heeft altijd een scherm, muis en toetsenbord nodig. Deze tests kunnen niet op de achtergrond worden uitgevoerd omdat deze dan niet meer overeenkomen met een "werkelijke" testomgeving.

Er was dus nood aan een beter concept om deze testing uit te voeren. Daarom werd gekeken naar testsettings, test agents en test controllers. Wanneer hiermee getest is geweest, doken er al snel (nog meer) problemen op. Het voornaamste en grootste probleem was, dat men een omgeving moest opstarten waar de applicatie kon gedeployed worden. Dit hield in dat men een virtual machine moest creëren waarop Windows 10 OS geïnstalleerd stond. Visual Studio 2015 moest ook aanwezig zijn om de test agents en test controllers op toe te kennen.

Omdat de testcontroller op de TFS moest aangemaakt worden (om zo meerdere testagents toe te wijzen) werd dit geprobeerd op de TFS 2013 van Calidos. Wanneer we spreken over 2013 wil dit zeggen dat in dit jaar nog helemaal geen spraken was van Windows 10. Met andere woorden. Een testcontroller aanmaken die Windows 10 als doel-OS heeft is hier dus onmogelijk.

#### 5.1.3.3 Bevindingen

Vanwege het laatste probleem is ook dit onderzoek aan de kant geschoven. Al leverde dit wel een extra stimulans op voor Calidos om te overwegen om de TFS 2013 te upgraden naar TFS 2015 of TFS "in the Cloud".

Dit stukje kan ook teruggevonden worden in de Testing Guideline onder het hoofdstuk "Automation: Adding Coded UI Tests to the build street"

## 5.2 Geïmplementeerde research

### 5.2.1 Self-extracting zip

#### 5.2.1.1 Probleemstelling

Door het update probleem dat zich nog steeds voordeed na de research naar de Windows Store For Business bleef het grootste probleem dat er niet genoeg vertrouwen is in de gebruiker om het update proces juist en makkelijk te laten verlopen. Calidos vroeg hierdoor om een oplossing te creëren in verband met het extracten van de geüpdate vesie.

Van Calidos uit gaven ze ook de hint mee om de "self-extracting zip" even te bekijken als oplossing voor dit probleem.

#### 5.2.1.2 Oplossing

De self-extracting zip of SFX is een zip bestand dat zichzelf uitpakt en daarna zichzelf, via een extra script, kan installeren. Het voordeel hierbij is dat men zo veel mogelijk user interaction vermijd en garandeert dat alles correct geïnstalleerd wordt. De enige user interaction zal de bevestiging van uitpakken en installeren zijn.

Bij het uitzoeken naar welke library hiervoor  het meest geschikt was zijn er 2 libraries de revue gepasseerd:

 - SharpZipLib
   - GNU GPL Library voor .NET dat het mogelijk maakt om Zip's, GZip's, Tar's en BZip2's te creëren en uit te pakken
   - Volledig in C# geschreven.


 - DotNetZip
   - Open software (Ms-PL) library voor .NET dat het mogelijk maakt om Zip's, BZip2's, CRC's en Zipstreams te creëren en uit te pakken.
   - Maakt gebruik van ionic Zip DLL.


Origineel is er gewerkt met de DotNetZip om Zip's aan te maken in het Maät project. Omdat er na een eerste onderzoek niet heel veel informatie beschikbaar was over een SFX binnen deze library, is geprobeerd met de SharpZipLib library te werken. Deze werkte vrijwel goed. Het nadeel was echter dat deze gebruik maakte van een extern opgestelde bitstream om de Zip te genereren. Deze bitstream zorgde voor problemen na enkele tests.

Na verder onderzoek is er beslist om toch met de DotNetZip library te werken. Er is verder gezocht naar bruikbare informatie omtrent het creëren van Zip's, die uiteindelijk ook werd gevonden. Na enkele tests met deze library werkte de code zoals gewenst. De code is hieronder terug te vinden. Belangrijk om te weten is, dat de PostExtractCommandLine enkele keren herschreven is moeten worden omdat er enkele " **/** " of " **"** " misten of teveel geschreven waren.

#### 5.2.1.3 Code: SFX creatie

```
private static void CreateZip(DirectoryInfo dirToZip, FileInfo zipFile, FileInfo exe)
{
    //Location where the SFX will extract to:
    string extractDir = @"%TEMP%/Maat";

    //We can't create an SFX with SharpZipLib (we do have added a 3rd party way to do this, but this doesn't open the dir after unzipping.
    //DotNetZip nowadays allows for SFX's as well:
    using (ZipFile zip = new Ionic.Zip.ZipFile(zipFile.FullName))
    {
        zip.AddDirectory(dirToZip.FullName);
        zip.Comment = "Calidos Maät";
        var options = new SelfExtractorSaveOptions
        {
            Flavor = SelfExtractorFlavor.WinFormsApplication,
            DefaultExtractDirectory = extractDir,
            ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently,
            RemoveUnpackedFilesAfterExecute = false,

            //Set to non-interactive, so the user doesn't have to do anything. We do define the location where the files will be extracted to though.
            Quiet = true,

            //Launch the extracted path after unzipping:
            PostExtractCommandLine = "cmd /c start \"\" \"" + extractDir + "\"",
            
            SfxExeWindowTitle = "Extracting Maät Client...",
        };

        zip.SaveSelfExtractor(exe.FullName, options);
    }
}
```
