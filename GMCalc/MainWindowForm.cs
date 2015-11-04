using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GMCalc
{
    public partial class MainWindowForm : Form
    {
        // Lexer / Parser FTW
        private Lexer lexer;
        private Parser parser;

        // Basic equation parameters
        Button noButtonSelected;
        Button btnMselected;    // A pointer to the selected multiplier
        Button btnDselected;    // A pointer to the selected die
        Button btnXselected;    // A pointer to the selected modifier
        Int32 currentMultiplier;
        string currentDie;
        Int32 currentModifier;

        // Variable editor
        VariableEditor ve;

        // Parser availability
        bool parserAvailable;

        // Fonts
        Font defaultFont;
        Font selectedFont;

        public MainWindowForm()
        {
            InitializeComponent();

            // Init lexer and parser
            lexer = new Lexer();
            parser = new Parser(lexer);

            // Initialize Variable Editor
            ve = new VariableEditor();
            ve.setForm(this);

            // Parser availability
            this.parserAvailable = true;

            // Init result value
            this.setEntryBoxValue("Start Typing Here...");

            // Init basic equation parameters
            noButtonSelected = new Button();
            btnMselected = noButtonSelected;
            btnDselected = noButtonSelected;
            btnXselected = noButtonSelected;
            currentMultiplier = 0;
            currentDie = "d0";
            currentModifier = 0;

            defaultFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point);
            selectedFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point);

            // Init buttons
            this.btnD_Click(this.btnD20, new EventArgs());
            this.btnM_Click(this.btnM1, new EventArgs());
            this.btnX_Click(this.btnX0, new EventArgs());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBox ab = new AboutBox())
            {
                ab.ShowDialog();
            }
        }

        public void addReference(string name, string value)
        {
            System.Console.WriteLine("Adding Reference: " + name + " / " + value);
            this.parser.references.Add(name, value);
        }

        public void editReference(string name, string value)
        {
            System.Console.WriteLine("Editing Reference: " + name + " / " + value);
            this.parser.references[name] = value;
        }

        public void deleteReference(string name)
        {
            System.Console.WriteLine("Delete Reference: " + name);
            this.parser.references.Remove(name);
        }

        private void entryBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            btn_DeselectAll();
            if (e.KeyCode == Keys.Enter)
            {
                this.runParser();
            }
        }

        private void entryBox_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            this.updateStatusBarEq();
        }

        ////
        //
        // Run parser
        //

        private void runParser()
        {
            if (this.parserAvailable == false)
            {
                return;
            }

            try
            {
                // Parse input string
                //this.parser.Parse(this.entryBox.Text);
                parseWorker.RunWorkerAsync(this.entryBox.Text);
            }
            catch (Exception err)
            {
                Console.WriteLine("Err: " + err.Message);
                this.setEntryBoxValue("I AM ERROR"); //: " + err.Message);
            }
        }

        private void getParserResult()
        {
            Int32 result = 0;
            result = this.parser.getResult();

            // Save input string after cleaning up 'Last'
            //parser.references["Last"] = lexer.cleanInput.Trim();
            ve.editVariable("Last", lexer.cleanInput.Trim());
            Console.WriteLine("GetParserResult -> setting Last ref to '" + lexer.cleanInput.Trim() + "'");

            // Output result
            this.lastResultTwo.Text = this.lastResultOne.Text;
            this.lastResultOne.Text = this.resultBox.Text;
            this.setResultBoxValue(result.ToString());
            Console.WriteLine("GetParserResult -> setting Ans ref to '" + result + "'");

            // Save result in 'Ans' reference
            //parser.references["Ans"] = result;
            ve.editVariable("Ans", result.ToString());

            // Update status bar
            this.updateStatusBarEq();

            // Reset progress bar
            this.progressBar1.Value = 0;

            // Reset parser status
            this.parserAvailable = true;
        }

        void parseWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            this.parserAvailable = false;

            // Get the BackgroundWorker that raised this event.
            BackgroundWorker worker = sender as BackgroundWorker;

            // Assign the result of the computation
            // to the Result property of the DoWorkEventArgs
            // object. This is will be available to the 
            // RunWorkerCompleted eventhandler.
            e.Result = this.parser.Parse((string)e.Argument, worker, e);
        }

        void parseWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                // Error
            }
            else if (e.Cancelled)
            {
                // Cancelled
            }
            else
            {
                // Success
                this.getParserResult();
            }
        }

        void parseWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        ////
        //
        // Update status bar with equation
        //
        private void updateStatusBarEq()
        {
            this.toolStripStatusLabel1.Text = this.entryBox.Text + " (Seed: " + this.parser.getSeed() + ")" + " (ANS: " + parser.references["Ans"] + ")";
            if (this.toolStripStatusLabel1.Text.Equals("Start Typing Here...") || this.entryBox.Text.Equals(""))
            {
                this.toolStripStatusLabel1.Text = "Ready";
            }
        }

        ////
        //
        // General event handler for coloring/decoloring buttons
        //
        //
        private Button btn_ClickColorize(object sender, Button currentButton, Color setBackColor, Color setForeColor)
        {
            Button btn = (Button)sender;
            bool reset = (btn.Text == currentButton.Text) ? true : false;

            if(!reset)
            {
                currentButton.BackColor = Color.Transparent;
                currentButton.ForeColor = Button.DefaultForeColor;
                currentButton.Font = defaultFont;

                btn.BackColor = setBackColor;
                btn.ForeColor = setForeColor;
                btn.Font = selectedFont;
                return btn;
            }
            else
            {
                return btn;
            }
        }

        ////
        //
        // Deselect all
        //
        //
        private void btn_DeselectAll()
        {
            btnM_Click((object)btnMselected, new EventArgs());
            btnD_Click((object)btnDselected, new EventArgs());
            btnX_Click((object)btnXselected, new EventArgs());
            updateStatusBarEq();
        }

        ////
        //
        // Event handler for Multiplier buttons 1-10
        //
        private void btnM_Click(object sender, EventArgs e)
        {
            btnMselected = btn_ClickColorize(sender, btnMselected, Color.SteelBlue, Color.White);
            
            bool result;
            int number;
            result = Int32.TryParse(((Button)sender).Text, out number);
            if (result)
            {
                currentMultiplier = number;
            }

            updateStatusBarEq();
        }

        ////
        //
        // Event handler for Die buttons d2-d100
        //
        private void btnD_Click(object sender, EventArgs e)
        {
            btnDselected = btn_ClickColorize(sender, btnDselected, Color.OrangeRed, Color.White);
            Button btn = (Button)sender;

            bool result;
            int number;
            result = Int32.TryParse(btn.Text, out number);
            if (result)
            {
                currentDie = "d" + number;
            }
            else if(!btn.Equals(btnDn))
            {
                currentDie = ((Button)sender).Text;
            }

            updateStatusBarEq();
        }

        ////
        //
        // Event handler for Modifier buttons 1-9
        //
        private void btnX_Click(object sender, EventArgs e)
        {
            btnXselected = btn_ClickColorize(sender, btnXselected, Color.ForestGreen, Color.White);

            bool result;
            int number;
            result = Int32.TryParse(((Button)sender).Text, out number);
            if (result)
            {
                currentModifier = number;
            }

            updateStatusBarEq();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            String output = currentMultiplier + currentDie + (radXPlus.Checked ? radXPlus.Text : radXMinus.Text) + currentModifier;

            entryBox.Text = output;
            runParser();
        }

        private void radXPlusMinus_CheckedChanged(object sender, EventArgs e)
        {
            updateStatusBarEq();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "GMCalcHelp.chm");
        }

        private void btnTokAddAns_Click(object sender, EventArgs e)
        {
            this.insertEntryTextAtCaret("Ans");
        }

        private void btnTokAddLast_Click(object sender, EventArgs e)
        {
            this.insertEntryTextAtCaret("Last");
        }

        private void btnTokAddLeftParen_Click(object sender, EventArgs e)
        {
            this.insertEntryTextAtCaret("(");
        }

        private void btnTokAddRightParen_Click(object sender, EventArgs e)
        {
            this.insertEntryTextAtCaret(")");
        }

        public void insertEntryTextAtCaret(string text)
        {
            int caretStart = this.entryBox.SelectionStart;
            int caretEnd = this.entryBox.SelectionLength;
            this.entryBox.Text = this.entryBox.Text.Remove(caretStart, caretEnd);
            this.entryBox.Text = this.entryBox.Text.Insert(caretStart, text);
            this.entryBox.Focus();
            this.entryBox.Select(caretStart + text.Length, 0);
        }

        private void btnTokAddParens_Click(object sender, EventArgs e)
        {
            string selectedText = this.entryBox.SelectedText;

            // Get start and end of selection
            int caretStart = this.entryBox.SelectionStart;
            int caretEnd = this.entryBox.SelectionLength;

            if (selectedText.Equals(""))
            {
                this.entryBox.Text = this.entryBox.Text.Insert(caretStart, "()");
                this.entryBox.Focus();
                this.entryBox.Select(caretStart + 1, 0);
            }
            else
            {
                // Insert parentheses
                this.entryBox.Text = this.entryBox.Text.Insert(caretStart + caretEnd, ")");
                this.entryBox.Text = this.entryBox.Text.Insert(caretStart, "(");

                // Move caret to end of selection
                this.entryBox.Focus();
                this.entryBox.Select(caretStart + caretEnd + 2, 0);
            }
        }

        private void btnXn_Click(object sender, EventArgs e)
        {
            this.btnX_Click(this.btnXn, new EventArgs());
            NumberDialog nd = new NumberDialog();
            nd.TxtTitle = "Enter modifier number:";
            nd.TxtInput = currentModifier.ToString();
            nd.ShowDialog();

            int number;
            bool result;
            result = Int32.TryParse(nd.TxtInput, out number);
            if (!result)
            {
                number = 0;
            }

            currentModifier = number;
            if (number.ToString().Length > 8)
            {
                btnXn.Text = "m=" + number.ToString().Substring(0, 8) + "..";
            }
            else
            {
                btnXn.Text = "m = " + number;
            }
            toolTip.SetToolTip(btnXn, "m = " + number);
            updateStatusBarEq();
        }

        private void btnMn_Click(object sender, EventArgs e)
        {
            this.btnM_Click(this.btnMn, new EventArgs());
            NumberDialog nd = new NumberDialog();
            nd.TxtTitle = "Enter multiplier number:";
            nd.TxtInput = currentMultiplier.ToString();
            nd.ShowDialog();

            int number;
            bool result;
            result = Int32.TryParse(nd.TxtInput, out number);
            if (!result)
            {
                number = 0;
            }

            currentMultiplier = number;
            if (number.ToString().Length > 6)
            {
                btnMn.Text = "m=" + number.ToString().Substring(0, 6) + "..";
            }
            else
            {
                btnMn.Text = "m = " + number;
            }
            toolTip.SetToolTip(btnMn, "m  " + number);
            updateStatusBarEq();
        }

        private void MainWindowForm_Click(object sender, EventArgs e)
        {
        }

        private void btnDn_Click(object sender, EventArgs e)
        {
            this.btnD_Click(this.btnDn, new EventArgs());
            NumberDialog nd = new NumberDialog();
            nd.TxtTitle = "Enter die face number:";
            nd.TxtInput = currentDie.Substring(1);
            nd.ShowDialog();

            int number;
            bool result;
            result = Int32.TryParse(nd.TxtInput, out number);
            if (!result)
            {
                number = 0;
            }

            if (number.ToString().Length > 8)
            {
                btnDn.Text = "d" + number.ToString().Substring(0, 8) + "..";
            }
            else
            {
                btnDn.Text = "d" + number;
            }
            currentDie = "d" + number;

            toolTip.SetToolTip(btnDn, "d" + number);
            updateStatusBarEq();
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            // Set up variable editor
            ve.addVariable("Ans", "0");
            ve.addVariable("Last", "0");
            ve.dataGridView1.Rows[0].ReadOnly = true;
            ve.dataGridView1.Rows[1].ReadOnly = true;
            ve.init();
        }

        private void variableEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ve.Show();
        }
    }
}