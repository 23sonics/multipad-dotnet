namespace MultipadDotNet
{
    partial class MdiChild
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "MdiChild";
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiChild));
            this.TextInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextInput
            // 
            this.TextInput.AcceptsTab = true;
            this.TextInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextInput.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextInput.Location = new System.Drawing.Point(0, 0);
            this.TextInput.Multiline = true;
            this.TextInput.Name = "TextInput";
            this.TextInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextInput.Size = new System.Drawing.Size(832, 319);
            this.TextInput.TabIndex = 1;
            this.TextInput.WordWrap = false;
            this.TextInput.TextChanged += new System.EventHandler(this.TextInput_TextChanged);
            // 
            // MdiChildTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 319);
            this.Controls.Add(this.TextInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MdiChildTemplate";
            this.Text = "MdiChildTemplate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MdiChildTemplate_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        internal System.Windows.Forms.TextBox TextInput;
    }
}