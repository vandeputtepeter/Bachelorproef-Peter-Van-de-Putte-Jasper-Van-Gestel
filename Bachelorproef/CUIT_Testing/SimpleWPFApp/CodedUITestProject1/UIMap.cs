namespace CodedUITestProject1
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

    public partial class UIMap
    {
        public UIMap()
        {
            UIMainWindowWindow.UIStartButton.SearchProperties[WpfControl.PropertyNames.AutomationId] = "buttonA";
        }

        /// <summary>
        /// SimpleAppTest - Use 'SimpleAppTestParams' to pass parameters into this method.
        /// </summary>
        public void ModifiedSimpleAppTest()
        {
            #region Variable Declarations
            WpfButton uIStartButton = this.UIMainWindowWindow.UIStartButton;
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow.UICheckBoxCheckBox;
            WinButton uISluitenButton = this.UIMainWindowWindow1.UISluitenButton;
            #endregion

            // Launch 'C:\GitHub\BAP_Stage_StudentRepo\Bachelorproef\CUIT_Testing\SimpleWPFApp\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
            ApplicationUnderTest uIMainWindowWindow = ApplicationUnderTest.Launch(this.SimpleAppTestParams.UIMainWindowWindowExePath, this.SimpleAppTestParams.UIMainWindowWindowAlternateExePath);

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(48, 14));

            uICheckBoxCheckBox.WaitForControlEnabled();

            // Select 'CheckBox' check box
            uICheckBoxCheckBox.Checked = this.SimpleAppTestParams.UICheckBoxCheckBoxChecked;

            // Click 'Sluiten' button
            Mouse.Click(uISluitenButton, new Point(21, 16));
        }

        public virtual SimpleAppTestParams SimpleAppTestParams
        {
            get
            {
                if ((this.mSimpleAppTestParams == null))
                {
                    this.mSimpleAppTestParams = new SimpleAppTestParams();
                }
                return this.mSimpleAppTestParams;
            }
        }

        private SimpleAppTestParams mSimpleAppTestParams;

        /// <summary>
        /// AddTwoNumbers - Use 'AddTwoNumbersParams' to pass parameters into this method.
        /// </summary>
        public void AddTwoNumbers()
        {
            #region Variable Declarations
            WpfEdit uITextBox1Edit = this.UIMainWindowWindow.UITextBox1Edit;
            WpfEdit uITextBox2Edit = this.UIMainWindowWindow.UITextBox2Edit;
            WpfButton uIAddButton = this.UIMainWindowWindow.UIAddButton;
            #endregion

            // Type '1' in 'textBox1' text box
            uITextBox1Edit.Text = this.AddTwoNumbersParams.UITextBox1EditText;

            // Type '2' in 'textBox2' text box
            uITextBox2Edit.Text = this.AddTwoNumbersParams.UITextBox2EditText;

            // Click 'Add' button
            Mouse.Click(uIAddButton, new Point(49, 12));
        }

        public virtual AddTwoNumbersParams AddTwoNumbersParams
        {
            get
            {
                if ((this.mAddTwoNumbersParams == null))
                {
                    this.mAddTwoNumbersParams = new AddTwoNumbersParams();
                }
                return this.mAddTwoNumbersParams;
            }
        }

        private AddTwoNumbersParams mAddTwoNumbersParams;
    }
    /// <summary>
    /// Parameters to be passed into 'SimpleAppTest'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class SimpleAppTestParams
    {

        #region Fields
        /// <summary>
        /// Launch 'C:\GitHub\BAP_Stage_StudentRepo\Bachelorproef\CUIT_Testing\SimpleWPFApp\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
        /// </summary>
        public string UIMainWindowWindowExePath = "C:\\GitHub\\BAP_Stage_StudentRepo\\Bachelorproef\\CUIT_Testing\\SimpleWPFApp\\SimpleWPF" +
            "App\\bin\\Debug\\SimpleWPFApp.exe";

        /// <summary>
        /// Launch 'C:\GitHub\BAP_Stage_StudentRepo\Bachelorproef\CUIT_Testing\SimpleWPFApp\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
        /// </summary>
        public string UIMainWindowWindowAlternateExePath = "C:\\GitHub\\BAP_Stage_StudentRepo\\Bachelorproef\\CUIT_Testing\\SimpleWPFApp\\SimpleWPF" +
            "App\\bin\\Debug\\SimpleWPFApp.exe";

        /// <summary>
        /// Select 'CheckBox' check box
        /// </summary>
        public bool UICheckBoxCheckBoxChecked = true;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'AddTwoNumbers'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class AddTwoNumbersParams
    {

        #region Fields
        /// <summary>
        /// Type '1' in 'textBox1' text box
        /// </summary>
        public string UITextBox1EditText = "1";

        /// <summary>
        /// Type '2' in 'textBox2' text box
        /// </summary>
        public string UITextBox2EditText = "2";
        #endregion
    }
}
