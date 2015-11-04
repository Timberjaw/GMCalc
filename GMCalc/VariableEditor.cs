using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GMCalc
{
    public partial class VariableEditor : Form
    {
        private MainWindowForm form;
        private Hashtable keys;

        public VariableEditor()
        {
            InitializeComponent();

            this.keys = new Hashtable();
        }

        public void setForm(MainWindowForm f)
        {
            this.form = f;
        }

        public void addVariable(string name, string value)
        {
            if (keys.ContainsKey(name))
            {
                return;
            }

            this.dataGridView1.Rows.Add(new string[] { name, value });
            this.keys[name] = this.dataGridView1.Rows.Count;
        }

        public void editVariable(string name, string value)
        {
            if (!this.keys.ContainsKey(name))
            {
                // No good
                return;
            }

            this.dataGridView1.Rows[(int)this.keys[name]-1].Cells[0].Value = name;
            this.dataGridView1.Rows[(int)this.keys[name]-1].Cells[1].Value = value;

            this.form.editReference(name, value);
        }

        public void deleteVariable(string name)
        {
            if (!this.keys.ContainsKey(name))
            {
                // No good
                return;
            }

            this.dataGridView1.Rows.RemoveAt(((int)this.keys[name])-1);
            this.keys.Remove(name);
            this.form.deleteReference(name);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Validate
            // 1. Name and value must both be entered
            // 2. Name cannot be already in use by a different row

            int selectedIndex = this.dataGridView1.SelectedRows[0].Index;
            string name = this.txtName.Text;
            string value = this.txtVar.Text;

            if (name.Length == 0 || value.Length == 0)
            {
                // Shit
                return;
            }

            if (this.keys.ContainsKey(name) && (int)this.keys[name] == selectedIndex)
            {
                // No good
                return;
            }

            // If name has changed, delete existing row and add a new one
            // If name has not changed, update existing row

            if (name != this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString())
            {
                this.dataGridView1.Rows[0].Selected = true;

                // Delete
                this.deleteVariable(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                // Add
                this.addVariable(name, value);

                // Select
                this.dataGridView1.Rows[this.dataGridView1.Rows.Count-1].Selected = true;
            }
            else
            {
                // Edit
                this.editVariable(name, value);
            }

            // Disable edit button
            this.btnEdit.Enabled = false;
        }

        public void init()
        {
            System.Console.WriteLine("VariableEditor: Initialized");
            this.txtName.Text = "";
            this.txtVar.Text = "";
            this.btnEdit.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate
            // 1. Both name and value must be entered
            // 2. Name must not be in use

            if (this.txtName.Text.Length == 0 || this.txtVar.Text.Length == 0 || this.keys.Contains(this.txtName.Text))
            {
                return;
            }

            // Add
            this.addVariable(this.txtName.Text, this.txtVar.Text);

            // Clear form
            this.txtName.Text = "";
            this.txtVar.Text = "";
        }

        private void VariableEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("VariableEditor -> Inserting from index: " + ((DataGridViewRow)menuVarItem.Tag).Index);
            this.form.insertEntryTextAtCaret(((DataGridViewRow)menuVarItem.Tag).Cells[0].Value.ToString());
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("VariableEditor -> Deleting from index: " + ((DataGridViewRow)menuVarItem.Tag).Index);
            this.deleteVariable(((DataGridViewRow)menuVarItem.Tag).Cells[0].Value.ToString());
        }
    }
}
