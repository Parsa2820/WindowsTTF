namespace WindowsTTF
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calculate = new System.Windows.Forms.Button();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.FileChooser = new System.Windows.Forms.Button();
            this.Subdirectories = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(380, 42);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(94, 29);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // FolderPath
            // 
            this.FolderPath.Location = new System.Drawing.Point(12, 12);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(462, 27);
            this.FolderPath.TabIndex = 1;
            // 
            // FileChooser
            // 
            this.FileChooser.Location = new System.Drawing.Point(235, 42);
            this.FileChooser.Name = "FileChooser";
            this.FileChooser.Size = new System.Drawing.Size(139, 29);
            this.FileChooser.TabIndex = 2;
            this.FileChooser.Text = "Choose a Folder";
            this.FileChooser.UseVisualStyleBackColor = true;
            this.FileChooser.Click += new System.EventHandler(this.FileChooser_Click);
            // 
            // Subdirectories
            // 
            this.Subdirectories.AutoSize = true;
            this.Subdirectories.Location = new System.Drawing.Point(18, 45);
            this.Subdirectories.Name = "Subdirectories";
            this.Subdirectories.Size = new System.Drawing.Size(211, 24);
            this.Subdirectories.TabIndex = 3;
            this.Subdirectories.Text = "Include Subdirectories Files";
            this.Subdirectories.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 89);
            this.Controls.Add(this.Subdirectories);
            this.Controls.Add(this.FileChooser);
            this.Controls.Add(this.FolderPath);
            this.Controls.Add(this.Calculate);
            this.Name = "MainForm";
            this.Text = "Windows Total Time Finder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.Button FileChooser;
        private System.Windows.Forms.CheckBox Subdirectories;
    }
}

