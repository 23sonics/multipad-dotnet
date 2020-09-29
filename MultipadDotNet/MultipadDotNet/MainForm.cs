using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace MultipadDotNet
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            MdiChild newMdiChild = new MdiChild();
            newMdiChild.MdiParent = this;
            newMdiChild.Text = "Untitled";
            newMdiChild.WindowState = FormWindowState.Maximized;
            try
            {
                if (Environment.GetCommandLineArgs().GetValue(1).ToString() != string.Empty)
                {
                    newMdiChild.openedFilePath = Environment.GetCommandLineArgs().GetValue(1).ToString();
                    if (File.Exists(newMdiChild.openedFilePath))
                    {
                        newMdiChild.Text = Path.GetFileName(newMdiChild.openedFilePath);
                        newMdiChild.TextInput.Text = File.ReadAllText(newMdiChild.openedFilePath);
                        newMdiChild.TextInput.DeselectAll();
                    }
                    else
                    {
                        switch (MessageBox.Show("Cannot find the " + newMdiChild.openedFilePath + " file." + (char)10 + "Do you want to create a new file?", "Multipad .NET", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                        {
                            case DialogResult.Yes:
                                File.CreateText(newMdiChild.openedFilePath);
                                newMdiChild.Text = Path.GetFileName(newMdiChild.openedFilePath);
                                newMdiChild.TextInput.Text = File.ReadAllText(newMdiChild.openedFilePath);
                                return;
                            case DialogResult.No:
                                return;
                        }
                    }
                }
            }
            catch { return; }
            finally { newMdiChild.Show(); }
        }

        private void FileAbout_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void FileExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void FileSave_Click(object sender, System.EventArgs e)
        {
            MdiChild thisMdiChild = (ActiveMdiChild as MdiChild);
            if (thisMdiChild.openedFilePath != "Untitled")
            {
                string safeName = Path.GetFileName(thisMdiChild.openedFilePath);
                using (StreamWriter writer = new StreamWriter(thisMdiChild.openedFilePath))
                {
                    writer.Write(thisMdiChild.TextInput.Text);
                }
                thisMdiChild.TextInput.Modified = false;
                thisMdiChild.Text = safeName;
            }
            else
            {
                saveDialog.ShowDialog();
            }
        }

        private void FileSaveAs_Click(object sender, System.EventArgs e)
        {
            saveDialog.ShowDialog();
        }

        private void SaveFile(object sender, CancelEventArgs e)
        {
            MdiChild thisMdiChild = (ActiveMdiChild as MdiChild);
            string safeName = Path.GetFileName(saveDialog.FileName);
            using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
            {
                writer.Write(thisMdiChild.TextInput.Text);
            }
            thisMdiChild.Text = safeName;
            thisMdiChild.openedFilePath = saveDialog.FileName;
            thisMdiChild.TextInput.Modified = false;
        }

        private void FileOpen_Click(object sender, System.EventArgs e)
        {
            openDialog.ShowDialog();
        }

        private void OpenFile(object sender, CancelEventArgs e)
        {
            MdiChild newMdiChild = new MdiChild();
            newMdiChild.MdiParent = this;
            using (StreamReader reader = new StreamReader(openDialog.FileName))
            {
                newMdiChild.TextInput.Text = reader.ReadToEnd();
            }
            newMdiChild.Text = openDialog.SafeFileName;
            newMdiChild.openedFilePath = openDialog.FileName;
            newMdiChild.Show();
        }

        private void FileNew_Click(object sender, System.EventArgs e)
        {
            MdiChild newMdiChild = new MdiChild();
            newMdiChild.Text = "Untitled";
            newMdiChild.MdiParent = this;
            newMdiChild.Show();
        }

        private void FilePrint_Click(object sender, System.EventArgs e)
        {
            this.printDialog.ShowDialog();
        }

        private void WindowCloseAll_Click(object sender, System.EventArgs e)
        {
            foreach (MdiChild mdiChildForm in this.MdiChildren)
            {
                mdiChildForm.Close();
            }
        }

        public void SaveFile2()
        {
            saveDialog.ShowDialog();
        }

        private void WindowArrangeIcons_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void WindowCascade_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void WindowTileHorizontal_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void WindowTileVertical_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void EditPaste_Click(object sender, System.EventArgs e)
        {
            MdiChild thisMdiChild = (ActiveMdiChild as MdiChild);
            thisMdiChild.TextInput.Text += Clipboard.GetText();
        }

        private void EditWordWrap_Click(object sender, System.EventArgs e)
        {
            ToggleWordWrap(1);
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            CheckExistingChildren();

            // Perform tasks to grab info about the active MDI child.

            // Look at the Find dialog and, if the Find what
            // box is empty, disable Find Next (Search menu)
            if (findDialog.FindWhat == string.Empty)
            {
                SearchNext.Enabled = false;
            }
            else
            {
                SearchNext.Enabled = true;
            }

            if (ActiveMdiChild != null)
            {
                MenuOptionEnable(true);
                ToggleWordWrap(0);
                if ((ActiveMdiChild as MdiChild).TextInput.CanUndo)
                {
                    EditUndo.Enabled = true;
                }
                else
                {
                    EditUndo.Enabled = false;
                }
            }
            else
            {
                MenuOptionEnable(false);
            }
        }

        private void ToggleWordWrap(short mode)
        {
            // Cast the active MDI child form as the template,
            // for access to the controls inside it.
            MdiChild thisMdiChild = (ActiveMdiChild as MdiChild);

            // Toggle word wrap in the text box.
            if (ActiveMdiChild != null)
            {
                if (thisMdiChild.TextInput.WordWrap == false)
                {
                    if (mode == 1)
                    {
                        thisMdiChild.TextInput.WordWrap = true;
                        EditWordWrap.Checked = true;
                    }
                    else if (mode == 0)
                    {
                        EditWordWrap.Checked = false;
                    }
                }
                else
                {
                    if (mode == 1)
                    {
                        thisMdiChild.TextInput.WordWrap = false;
                        EditWordWrap.Checked = false;
                    }
                    else if (mode == 0)
                    {
                        EditWordWrap.Checked = true;
                    }
                }
            }
        }

        private void EditUndo_Click(object sender, System.EventArgs e)
        {
            // Cast the active MDI child form as the template,
            // for access to the controls inside it.
            MdiChild thisMdiChild = (ActiveMdiChild as MdiChild);
            thisMdiChild.TextInput.Undo();
        }

        private void MenuOptionEnable(bool enabled)
        {
            EditWordWrap.Enabled = enabled;
            EditUndo.Enabled = enabled;
            EditCut.Enabled = enabled;
            EditCopy.Enabled = enabled;
            EditPaste.Enabled = enabled;
            SearchFind.Enabled = enabled;
            SearchNext.Enabled = enabled;
            EditSelectAll.Enabled = enabled;
            FileSave.Enabled = enabled;
            FileSaveAs.Enabled = enabled;
            FilePrint.Enabled = enabled;
        }

        private void CheckExistingChildren()
        {
            if (MdiChildren == null)
            {
                WindowTileHorizontal.Enabled = false;
                WindowTileVertical.Enabled = false;
                WindowCascade.Enabled = false;
                WindowArrangeIcons.Enabled = false;
                WindowCloseAll.Enabled = false;
            }
            else
            {
                WindowTileHorizontal.Enabled = true;
                WindowTileVertical.Enabled = true;
                WindowCascade.Enabled = true;
                WindowArrangeIcons.Enabled = true;
                WindowCloseAll.Enabled = true;
            }
        }

        private void SearchFind_Click(object sender, System.EventArgs e)
        {
            findDialog.Show(this);
        }

        private void findDialog_FindNextClick()
        {
            MdiChild thisMdiChild = (ActiveMdiChild as MdiChild);
            try
            {
                findDialog.FindString(thisMdiChild.TextInput);
            }
            catch
            { }
        }

        private void findDialog_SearchFailed(FindReplace.FindReplaceEventArgs eventArguments)
        {
            MessageBox.Show($"Could not find any occurrences of \"{eventArguments.FindWhat}\".");
        }

        private void SearchNext_Click(object sender, System.EventArgs e)
        {
            MdiChild thisMdiChild = (ActiveMdiChild as MdiChild);
            findDialog.Direction = FindReplace.FindDirection.Down;
            findDialog.FindString(thisMdiChild.TextInput);
        }

        private void EditCopy_Click(object sender, EventArgs e)
        {
            MdiChild thisMdiChild = (ActiveMdiChild as MdiChild);
            Clipboard.SetText(thisMdiChild.TextInput.SelectedText);
        }

        private void EditCut_Click(object sender, EventArgs e)
        {
            MdiChild thisMdiChild = (ActiveMdiChild as MdiChild);
            Clipboard.SetText(thisMdiChild.TextInput.SelectedText);
            thisMdiChild.TextInput.Text =
                thisMdiChild.TextInput.Text.Remove(thisMdiChild.TextInput.SelectionStart, thisMdiChild.TextInput.SelectedText.Length);
        }
    }
}
