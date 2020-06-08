namespace PNG_Compressor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Files = new System.Windows.Forms.ListBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxOutputdirectory = new System.Windows.Forms.TextBox();
            this.trackBarlossyless = new System.Windows.Forms.TrackBar();
            this.trackBarlossy = new System.Windows.Forms.TrackBar();
            this.radioButtonlossyless = new System.Windows.Forms.RadioButton();
            this.radioButtonLossy = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarlossyless)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarlossy)).BeginInit();
            this.SuspendLayout();
            // 
            // Files
            // 
            this.Files.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Files.FormattingEnabled = true;
            this.Files.ItemHeight = 18;
            this.Files.Location = new System.Drawing.Point(21, 52);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(508, 238);
            this.Files.TabIndex = 0;
            this.Files.SelectedIndexChanged += new System.EventHandler(this.listbox_files_SelectedIndexChanged);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.Location = new System.Drawing.Point(442, 24);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(78, 22);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(21, 296);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(76, 25);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxOptions.Controls.Add(this.button1);
            this.groupBoxOptions.Controls.Add(this.textBoxOutputdirectory);
            this.groupBoxOptions.Controls.Add(this.trackBarlossyless);
            this.groupBoxOptions.Controls.Add(this.trackBarlossy);
            this.groupBoxOptions.Controls.Add(this.radioButtonlossyless);
            this.groupBoxOptions.Controls.Add(this.radioButtonLossy);
            this.groupBoxOptions.Location = new System.Drawing.Point(21, 328);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(508, 149);
            this.groupBoxOptions.TabIndex = 3;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Output directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxOutputdirectory
            // 
            this.textBoxOutputdirectory.Location = new System.Drawing.Point(136, 118);
            this.textBoxOutputdirectory.Name = "textBoxOutputdirectory";
            this.textBoxOutputdirectory.Size = new System.Drawing.Size(268, 20);
            this.textBoxOutputdirectory.TabIndex = 4;
            this.textBoxOutputdirectory.TextChanged += new System.EventHandler(this.textBoxOutputdirectory_TextChanged);
            // 
            // trackBarlossyless
            // 
            this.trackBarlossyless.Location = new System.Drawing.Point(136, 67);
            this.trackBarlossyless.Maximum = 8;
            this.trackBarlossyless.Minimum = 1;
            this.trackBarlossyless.Name = "trackBarlossyless";
            this.trackBarlossyless.Size = new System.Drawing.Size(197, 45);
            this.trackBarlossyless.TabIndex = 3;
            this.trackBarlossyless.Value = 1;
            this.trackBarlossyless.Scroll += new System.EventHandler(this.trackBarlossyless_Scroll);
            // 
            // trackBarlossy
            // 
            this.trackBarlossy.Location = new System.Drawing.Point(136, 29);
            this.trackBarlossy.Minimum = 1;
            this.trackBarlossy.Name = "trackBarlossy";
            this.trackBarlossy.Size = new System.Drawing.Size(197, 45);
            this.trackBarlossy.TabIndex = 2;
            this.trackBarlossy.Value = 1;
            this.trackBarlossy.Scroll += new System.EventHandler(this.trackBarlossy_Scroll);
            // 
            // radioButtonlossyless
            // 
            this.radioButtonlossyless.AutoSize = true;
            this.radioButtonlossyless.Checked = true;
            this.radioButtonlossyless.Location = new System.Drawing.Point(36, 67);
            this.radioButtonlossyless.Name = "radioButtonlossyless";
            this.radioButtonlossyless.Size = new System.Drawing.Size(70, 17);
            this.radioButtonlossyless.TabIndex = 1;
            this.radioButtonlossyless.TabStop = true;
            this.radioButtonlossyless.Text = "Lossyless";
            this.radioButtonlossyless.UseVisualStyleBackColor = true;
            this.radioButtonlossyless.CheckedChanged += new System.EventHandler(this.radioButtonlossyless_CheckedChanged);
            // 
            // radioButtonLossy
            // 
            this.radioButtonLossy.AutoSize = true;
            this.radioButtonLossy.Location = new System.Drawing.Point(36, 29);
            this.radioButtonLossy.Name = "radioButtonLossy";
            this.radioButtonLossy.Size = new System.Drawing.Size(52, 17);
            this.radioButtonLossy.TabIndex = 0;
            this.radioButtonLossy.Text = "Lossy";
            this.radioButtonLossy.UseVisualStyleBackColor = true;
            this.radioButtonLossy.CheckedChanged += new System.EventHandler(this.radioButtonLossy_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PNG files|*.png";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Select the PNG files";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.buttonBrowse_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 507);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.Files);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PNG Compressor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarlossyless)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarlossy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Files;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.TrackBar trackBarlossyless;
        private System.Windows.Forms.TrackBar trackBarlossy;
        private System.Windows.Forms.RadioButton radioButtonlossyless;
        private System.Windows.Forms.RadioButton radioButtonLossy;
        private System.Windows.Forms.TextBox textBoxOutputdirectory;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
    }
}

