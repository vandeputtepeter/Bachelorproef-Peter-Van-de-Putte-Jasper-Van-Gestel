using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Input;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.DirectUIControls;
using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using CodedUITestProject1.UIMaps.NewUIMapTestClasses;

namespace CodedUITestProject1
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest(CodedUITestType.WindowsStore)]
    public class CodedUITest1
    {
        XamlWindow TestRunWindow;
        public CodedUITest1()
        {           
        }

        [TestInitialize]
        public void Initialize()
        {
            // Start app op
            TestRunWindow = XamlWindow.Launch("78282a25-0172-4519-a001-f05bc7a28b27_ndk7ypv5e5wqt!App");
            TestRunWindow.CloseOnPlaybackCleanup = false;
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            // Genereer een 'click' operatie in de applicatie (UIAppTestWin10Window) op de knop (UIButtonButton)
            Gesture.Tap(UIMap.UIAppTestWin10Window.UIButtonButton);
            // Controleer of waarde correct is
            UIMap.AssertMethod1();
        }

        [TestMethod]
        public void CodedUITestMethod2()
        {
            // Genereer een 'click' operatie in de applicatie (UIAppTestWin10Window) op de knop (UIButtonButton)
            Gesture.Tap(NewUIMapTest.UIAppTestWin10Window.UIButtonButton);
            // Controleer of waarde correct is
            NewUIMapTest.AssertMethod1();
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
                if ((map == null))
                {
                    map = new UIMap();
                }

                return map;
            }
        }

        private UIMap map;

        public NewUIMapTest NewUIMapTest
        {
            get
            {
                if ((newMap == null))
                {
                    newMap = new NewUIMapTest();
                }
                return newMap;
            }

        }

        private NewUIMapTest newMap;
    }
}
