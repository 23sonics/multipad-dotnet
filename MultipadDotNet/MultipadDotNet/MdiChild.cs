using System;
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
                switch (MessageBox.Show(System.IO.Path.GetFileName(openedFilePath) + " has been changed. Save file before closing?", "Multipad .NET", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information))
                { 
                    case DialogResult.Yes:
                        MainForm frm = new MainForm();
                        frm.SaveFile2();
                        return;
                    case DialogResult.No:
                        return;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        return;
                }
            }
        }

        private void TextInput_TextChanged(object sender, EventArgs e)
        {
            if (this.TextInput.Modified)
            {
                this.Text = System.IO.Path.GetFileName(openedFilePath) + "*";
            }
            else
            {
                return;
            }

            if (TextInput.CanUndo)
            {
                ((MainForm)this.MdiParent).EditUndo.Enabled = true;
            }
            else
            {
                ((MainForm)this.MdiParent).EditUndo.Enabled = false;
            }
        }
    }
}
