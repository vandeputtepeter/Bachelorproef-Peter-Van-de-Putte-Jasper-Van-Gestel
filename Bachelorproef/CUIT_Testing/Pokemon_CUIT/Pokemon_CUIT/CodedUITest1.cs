using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace Pokemon_CUIT
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        [DeploymentItem(@"Assets\PokedexScenarios.xlsx")]
        [DataSource("System.Data.Obdc", "Dsn=Excel Files;dbq=|DataDirectory|\\PokedexScenarios.xls;defaultdir=.;driverid=790;maxbuffersize=2048;pagetimeout=5;readonly=true", "Scenarios$" , DataAccessMethod.Sequential)]
        public void GenericStartScenarioMethod()
        {
            var Scenario = TestContext.DataRow["Scenario Name"].ToString();
            var ScenarioPath = TestContext.DataRow["Path"].ToString();

            var ScenarioUnderTest = ApplicationUnderTest.Launch(@"" + ScenarioPath);
            ScenarioUnderTest.Maximized = true;

            var cmd = TestContext.DataConnection.CreateCommand();
            cmd.CommandText = "select * from [" + Scenario + "$]";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var control = reader.GetValue(0).ToString();
                var instance = reader.GetValue(1).ToString();
                var action = reader.GetValue(2).ToString();
                var value = reader.GetValue(3).ToString();

                Console.WriteLine("Control: {0}, Instance: {1} Action: {2}, Value: {3}", control, action, value);

                ScenarioStep(ScenarioUnderTest, instance, action, control, value);
            }
        }

        private void ScenarioStep(ApplicationUnderTest App, string control, string instance, string action, string value)
        {
            var actionableControl = GetControlForAction(App, control, instance, action);
            ExecuteAction(actionableControl, action, value);
        }

        private void ExecuteAction(WpfControl actionableControl, string action, string value)
        {
            if (action == "Edit")
            {
                WpfEdit ctrl = actionableControl as WpfEdit;
                ctrl.Text = value;
            }

            if (action == "Click")
            {
                // making sure we click in the middle
                var top = actionableControl.Top;
                var left = actionableControl.Left;
                var width = actionableControl.Width;
                var clickPoint = actionableControl.GetClickablePoint();
                Console.WriteLine("ClickPoint: {0}, Top: {1}, Left: {2}, Width: {3}", clickPoint, top, left, width);
                actionableControl.DrawHighlight();
                Mouse.Click(actionableControl);
            }
        }

        private WpfControl GetControlForAction(ApplicationUnderTest App, string controlName, string instance, string action)
        {
            if (action == "Edit")
            {
                WpfEdit element = new WpfEdit(App);
                element.SearchProperties.Add(UITestControl.PropertyNames.Name, controlName);
                return element;
            }

            if (action == "Click")
            {
                WpfControl element = new WpfControl(App);
                element.SearchProperties.Add(UITestControl.PropertyNames.FriendlyName, controlName, PropertyExpressionOperator.Contains);
                if (controlName == "ListItem")
                {
                    element.SearchProperties.Add(UITestControl.PropertyNames.Instance, instance, PropertyExpressionOperator.Contains);
                }
                //See that we find it, but make sure its the inner most control we can find
                if (element.TryFind())
                {
                    var child = new WpfControl(element);
                    child.SearchProperties.Add(UITestControl.PropertyNames.FriendlyName, controlName, PropertyExpressionOperator.Contains);
                    if (controlName == "ListItem")
                    {
                        child.SearchProperties.Add(UITestControl.PropertyNames.Instance, instance, PropertyExpressionOperator.Contains);
                    }
                    if (child.TryFind())
                    {
                        return child;
                    }
                    else
                        return element;
                }
                Console.WriteLine("Unable to locate control for action: {0} and control: {1}", action, controlName);
                return element;
            }
            return null;
        }

        public void CodedUITestMethod1()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.OpenApp();
            this.UIMap.GetPokemon();
            this.UIMap.ClickKadabra();
            this.UIMap.ClickFutureSight();
            this.UIMap.VerifyKadabra();
            this.UIMap.CloseApp();
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
