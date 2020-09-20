namespace MultipadDotNet
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.MenuBar = new System.Windows.Forms.MainMenu(this.components);
            this.FileMenu = new System.Windows.Forms.MenuItem();
            this.FileNew = new System.Windows.Forms.MenuItem();
            this.FileOpen = new System.Windows.Forms.MenuItem();
            this.FileSave = new System.Windows.Forms.MenuItem();
            this.FileSaveAs = new System.Windows.Forms.MenuItem();
            this.MenuItem6 = new System.Windows.Forms.MenuItem();
            this.FilePrint = new System.Windows.Forms.MenuItem();
            this.MenuItem8 = new System.Windows.Forms.MenuItem();
            this.FileExit = new System.Windows.Forms.MenuItem();
            this.FileAbout = new System.Windows.Forms.MenuItem();
            this.EditMenu = new System.Windows.Forms.MenuItem();
            this.EditUndo = new System.Windows.Forms.MenuItem();
            this.MenuItem1 = new System.Windows.Forms.MenuItem();
            this.EditCut = new System.Windows.Forms.MenuItem();
            this.EditCopy = new System.Windows.Forms.MenuItem();
            this.EditPaste = new System.Windows.Forms.MenuItem();
            this.MenuItem7 = new System.Windows.Forms.MenuItem();
            this.EditSelectAll = new System.Windows.Forms.MenuItem();
            this.EditWordWrap = new System.Windows.Forms.MenuItem();
            this.SearchMenu = new System.Windows.Forms.MenuItem();
            this.SearchFind = new System.Windows.Forms.MenuItem();
            this.SearchNext = new System.Windows.Forms.MenuItem();
            this.WindowMenu = new System.Windows.Forms.MenuItem();
            this.WindowTileHorizontal = new System.Windows.Forms.MenuItem();
            this.WindowTileVertical = new System.Windows.Forms.MenuItem();
            this.WindowCascade = new System.Windows.Forms.MenuItem();
            this.WindowArrangeIcons = new System.Windows.Forms.MenuItem();
            this.WindowCloseAll = new System.Windows.Forms.MenuItem();
            this.findDialog = new FindReplace.FindReplaceDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // openDialog
            // 
            this.openDialog.Filter = "Text Document (*.txt)|*.txt|All files (*.*)|*.*";
            this.openDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFile);
            // 
            // saveDialog
            // 
            this.saveDialog.Filter = "Text Document (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFile);
            // 
            // MenuBar
            // 
            this.MenuBar.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FileMenu,
            this.EditMenu,
            this.SearchMenu,
            this.WindowMenu});
            // 
            // FileMenu
            // 
            this.FileMenu.Index = 0;
            this.FileMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FileNew,
            this.FileOpen,
            this.FileSave,
            this.FileSaveAs,
            this.MenuItem6,
            this.FilePrint,
            this.MenuItem8,
            this.FileExit,
            this.FileAbout});
            this.FileMenu.Text = "&File";
            // 
            // FileNew
            // 
            this.FileNew.Index = 0;
            this.FileNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.FileNew.Text = "&New";
            this.FileNew.Click += new System.EventHandler(this.FileNew_Click);
            // 
            // FileOpen
            // 
            this.FileOpen.Index = 1;
            this.FileOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.FileOpen.Text = "&Open...";
            this.FileOpen.Click += new System.EventHandler(this.FileOpen_Click);
            // 
            // FileSave
            // 
            this.FileSave.Index = 2;
            this.FileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.FileSave.Text = "&Save";
            this.FileSave.Click += new System.EventHandler(this.FileSave_Click);
            // 
            // FileSaveAs
            // 
            this.FileSaveAs.Index = 3;
            this.FileSaveAs.Text = "Save &As...";
            this.FileSaveAs.Click += new System.EventHandler(this.FileSaveAs_Click);
            // 
            // MenuItem6
            // 
            this.MenuItem6.Index = 4;
            this.MenuItem6.Text = "-";
            // 
            // FilePrint
            // 
            this.FilePrint.Index = 5;
            this.FilePrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.FilePrint.Text = "&Print...";
            this.FilePrint.Click += new System.EventHandler(FilePrint_Click);
            // 
            // MenuItem8
            // 
            this.MenuItem8.Index = 6;
            this.MenuItem8.Text = "-";
            // 
            // FileExit
            // 
            this.FileExit.Index = 7;
            this.FileExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.FileExit.Text = "E&xit";
            this.FileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // FileAbout
            // 
            this.FileAbout.Index = 8;
            this.FileAbout.Text = "About Multipad .NET...";
            this.FileAbout.Click += new System.EventHandler(this.FileAbout_Click);
            // 
            // EditMenu
            // 
            this.EditMenu.Index = 1;
            this.EditMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.EditUndo,
            this.MenuItem1,
            this.EditCut,
            this.EditCopy,
            this.EditPaste,
            this.MenuItem7,
            this.EditSelectAll,
            this.EditWordWrap});
            this.EditMenu.Text = "&Edit";
            // 
            // EditUndo
            // 
            this.EditUndo.Index = 0;
            this.EditUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.EditUndo.Text = "&Undo";
            this.EditUndo.Click += new System.EventHandler(this.EditUndo_Click);
            // 
            // MenuItem1
            // 
            this.MenuItem1.Index = 1;
            this.MenuItem1.Text = "-";
            // 
            // EditCut
            // 
            this.EditCut.Index = 2;
            this.EditCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.EditCut.Text = "&Cut";
            this.EditCut.Click += new System.EventHandler(this.EditCut_Click);
            // 
            // EditCopy
            // 
            this.EditCopy.Index = 3;
            this.EditCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.EditCopy.Text = "Co&py";
            this.EditCopy.Click += new System.EventHandler(this.EditCopy_Click);
            // 
            // EditPaste
            // 
            this.EditPaste.Index = 4;
            this.EditPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.EditPaste.Text = "&Paste";
            this.EditPaste.Click += new System.EventHandler(this.EditPaste_Click);
            // 
            // MenuItem7
            // 
            this.MenuItem7.Index = 5;
            this.MenuItem7.Text = "-";
            // 
            // EditSelectAll
            // 
            this.EditSelectAll.Index = 6;
            this.EditSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.EditSelectAll.Text = "&Select All";
            // 
            // EditWordWrap
            // 
            this.EditWordWrap.Index = 7;
            this.EditWordWrap.Text = "&Word Wrap";
            this.EditWordWrap.Click += new System.EventHandler(this.EditWordWrap_Click);
            // 
            // SearchMenu
            // 
            this.SearchMenu.Index = 2;
            this.SearchMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.SearchFind,
            this.SearchNext});
            this.SearchMenu.Text = "&Search";
            // 
            // SearchFind
            // 
            this.SearchFind.Index = 0;
            this.SearchFind.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this.SearchFind.Text = "&Find...";
            this.SearchFind.Click += new System.EventHandler(this.SearchFind_Click);
            // 
            // SearchNext
            // 
            this.SearchNext.Enabled = false;
            this.SearchNext.Index = 1;
            this.SearchNext.Shortcut = System.Windows.Forms.Shortcut.F3;
            this.SearchNext.Text = "Find &Next";
            this.SearchNext.Click += new System.EventHandler(this.SearchNext_Click);
            // 
            // WindowMenu
            // 
            this.WindowMenu.Index = 3;
            this.WindowMenu.MdiList = true;
            this.WindowMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.WindowTileHorizontal,
            this.WindowTileVertical,
            this.WindowCascade,
            this.WindowArrangeIcons,
            this.WindowCloseAll});
            this.WindowMenu.Text = "&Window";
            // 
            // WindowTileHorizontal
            // 
            this.WindowTileHorizontal.Index = 0;
            this.WindowTileHorizontal.Text = "Tile &Horizontally";
            this.WindowTileHorizontal.Click += new System.EventHandler(this.WindowTileHorizontal_Click);
            // 
            // WindowTileVertical
            // 
            this.WindowTileVertical.Index = 1;
            this.WindowTileVertical.Text = "Tile V&ertically";
            this.WindowTileVertical.Click += new System.EventHandler(this.WindowTileVertical_Click);
            // 
            // WindowCascade
            // 
            this.WindowCascade.Index = 2;
            this.WindowCascade.Text = "&Cascade";
            this.WindowCascade.Click += new System.EventHandler(this.WindowCascade_Click);
            // 
            // WindowArrangeIcons
            // 
            this.WindowArrangeIcons.Index = 3;
            this.WindowArrangeIcons.Text = "Arrange &Icons";
            this.WindowArrangeIcons.Click += new System.EventHandler(this.WindowArrangeIcons_Click);
            // 
            // WindowCloseAll
            // 
            this.WindowCloseAll.Index = 4;
            this.WindowCloseAll.Text = "Close &All";
            this.WindowCloseAll.Click += new System.EventHandler(this.WindowCloseAll_Click);
            // 
            // findDialog
            // 
            this.findDialog.Direction = FindReplace.FindDirection.Down;
            this.findDialog.FindWhat = "";
            this.findDialog.HelpVisible = false;
            this.findDialog.ReplaceWith = "";
            this.findDialog.Type = FindReplace.FindReplaceDialogType.Find;
            this.findDialog.FindNextClick += new IFindReplaceDialog.FindNextClickEventHandler(this.findDialog_FindNextClick);
            this.findDialog.SearchFailed += new IFindReplaceDialog.SearchFailedEventHandler(this.findDialog_SearchFailed);
            //
            // printDialog
            //
            this.printDialog.AllowCurrentPage = false;
            this.printDialog.AllowSomePages = false;
            this.printDialog.AllowPrintToFile = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 541);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Menu = this.MenuBar;
            this.Name = "MainForm";
            this.Text = "Multipad .NET";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.ResumeLayout(false);
        }

        #endregion

        internal System.Windows.Forms.OpenFileDialog openDialog;
        internal System.Windows.Forms.MainMenu MenuBar;
        internal System.Windows.Forms.MenuItem FileMenu;
        internal System.Windows.Forms.MenuItem FileNew;
        internal System.Windows.Forms.MenuItem FileOpen;
        internal System.Windows.Forms.MenuItem FileSave;
        internal System.Windows.Forms.MenuItem FileSaveAs;
        internal System.Windows.Forms.MenuItem MenuItem6;
        internal System.Windows.Forms.MenuItem FilePrint;
        internal System.Windows.Forms.MenuItem MenuItem8;
        internal System.Windows.Forms.MenuItem FileExit;
        internal System.Windows.Forms.MenuItem FileAbout;
        internal System.Windows.Forms.MenuItem EditMenu;
        internal System.Windows.Forms.MenuItem EditUndo;
        internal System.Windows.Forms.MenuItem MenuItem1;
        internal System.Windows.Forms.MenuItem EditCut;
        internal System.Windows.Forms.MenuItem EditCopy;
        internal System.Windows.Forms.MenuItem EditPaste;
        internal System.Windows.Forms.MenuItem MenuItem7;
        internal System.Windows.Forms.MenuItem EditSelectAll;
        internal System.Windows.Forms.MenuItem EditWordWrap;
        internal System.Windows.Forms.MenuItem SearchMenu;
        internal System.Windows.Forms.MenuItem SearchFind;
        internal System.Windows.Forms.MenuItem SearchNext;
        internal System.Windows.Forms.MenuItem WindowMenu;
        internal System.Windows.Forms.MenuItem WindowTileHorizontal;
        internal System.Windows.Forms.MenuItem WindowTileVertical;
        internal System.Windows.Forms.MenuItem WindowCascade;
        internal System.Windows.Forms.MenuItem WindowArrangeIcons;
        internal System.Windows.Forms.MenuItem WindowCloseAll;
        internal FindReplace.FindReplaceDialog findDialog;
        internal System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.SaveFileDialog saveDialog;
    }
}