namespace DirSize
{
    partial class Form1
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
            this.panelBrowse = new System.Windows.Forms.Panel();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxRoot = new System.Windows.Forms.TextBox();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.treeViewMain = new System.Windows.Forms.TreeView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panelBrowse.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBrowse
            // 
            this.panelBrowse.Controls.Add(this.buttonAnalyze);
            this.panelBrowse.Controls.Add(this.textBoxRoot);
            this.panelBrowse.Controls.Add(this.buttonBrowse);
            this.panelBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBrowse.Location = new System.Drawing.Point(0, 0);
            this.panelBrowse.Name = "panelBrowse";
            this.panelBrowse.Size = new System.Drawing.Size(1978, 51);
            this.panelBrowse.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBrowse.Location = new System.Drawing.Point(0, 0);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 51);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            // 
            // textBoxRoot
            // 
            this.textBoxRoot.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoot.Location = new System.Drawing.Point(75, 0);
            this.textBoxRoot.Name = "textBoxRoot";
            this.textBoxRoot.ReadOnly = true;
            this.textBoxRoot.Size = new System.Drawing.Size(1822, 48);
            this.textBoxRoot.TabIndex = 1;
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAnalyze.Location = new System.Drawing.Point(1903, 0);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(75, 51);
            this.buttonAnalyze.TabIndex = 2;
            this.buttonAnalyze.Text = "Analyze";
            this.buttonAnalyze.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.treeViewMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 51);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1978, 1093);
            this.panelMain.TabIndex = 1;
            // 
            // treeViewMain
            // 
            this.treeViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewMain.Location = new System.Drawing.Point(0, 0);
            this.treeViewMain.Name = "treeViewMain";
            this.treeViewMain.Size = new System.Drawing.Size(1978, 1093);
            this.treeViewMain.TabIndex = 0;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1978, 1144);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBrowse);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelBrowse.ResumeLayout(false);
            this.panelBrowse.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBrowse;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.TextBox textBoxRoot;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TreeView treeViewMain;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

