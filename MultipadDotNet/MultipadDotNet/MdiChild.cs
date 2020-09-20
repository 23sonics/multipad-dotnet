using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultipadDotNet
{
    public partial class MdiChild : Form
    {
        public string openedFilePath = "Untitled";
        public string SelectedText = string.Empty;
        public int TextSelectionStart = 0;
        public int TextSelectionEnd = 0;

        public MdiChild()
        {
            InitializeComponent();
        }

        private void MdiChildTemplate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TextInput.Modified)
            {
                DialogResult saveMsg = MessageBox.Show(System.IO.Path.GetFileName(openedFilePath) + " has been changed. Save file before closing?", "Multipad .NET", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (saveMsg == DialogResult.Yes)
                {
                    MainForm frm = new MainForm();
                    frm.SaveFile2();
                }
                else if (saveMsg == DialogResult.No)
                {
                    return;
                }
                else if (saveMsg == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void TextInput_TextChanged(object sender, EventArgs e)
        {
            if (this.TextInput.Modified)
            { this.Text = System.IO.Path.GetFileName(openedFilePath) + "*"; }
            else { return; }

            if (TextInput.CanUndo)
            { ((MainForm)this.MdiParent).EditUndo.Enabled = true; }
            else { ((MainForm)this.MdiParent).EditUndo.Enabled = false; }
        }
    }
}
