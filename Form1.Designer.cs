namespace BlogEngineToOctopress
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
            this.btnStart = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectSource = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.btnSelectDestination = new System.Windows.Forms.Button();
            this.lblDestination = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(86, 93);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(73, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start conversion";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.Location = new System.Drawing.Point(12, 21);
            this.btnSelectSource.Name = "btnSelectSource";
            this.btnSelectSource.Size = new System.Drawing.Size(147, 23);
            this.btnSelectSource.TabIndex = 1;
            this.btnSelectSource.Text = "Select source folder";
            this.btnSelectSource.UseVisualStyleBackColor = true;
            this.btnSelectSource.Click += new System.EventHandler(this.btnSelectSource_Click);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(165, 26);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(0, 13);
            this.lblSource.TabIndex = 2;
            this.lblSource.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSelectDestination
            // 
            this.btnSelectDestination.Location = new System.Drawing.Point(12, 50);
            this.btnSelectDestination.Name = "btnSelectDestination";
            this.btnSelectDestination.Size = new System.Drawing.Size(147, 23);
            this.btnSelectDestination.TabIndex = 3;
            this.btnSelectDestination.Text = "Select a destination folder";
            this.btnSelectDestination.UseVisualStyleBackColor = true;
            this.btnSelectDestination.Click += new System.EventHandler(this.btnSelectDestination_Click);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(165, 55);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(0, 13);
            this.lblDestination.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 141);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.btnSelectDestination);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.btnSelectSource);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Converting BlogEngine posts to Octopress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelectSource;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Button btnSelectDestination;
        private System.Windows.Forms.Label lblDestination;
    }
}

