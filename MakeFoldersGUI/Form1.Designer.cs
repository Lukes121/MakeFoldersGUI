namespace MakeFoldersGUI
{
    partial class Form1
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
            this.FilePathDesc = new System.Windows.Forms.Label();
            this.FileNameDesc = new System.Windows.Forms.Label();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.FolderNameTextBox = new System.Windows.Forms.TextBox();
            this.NumFoldersDec = new System.Windows.Forms.Label();
            this.FolderNumberTextBox = new System.Windows.Forms.TextBox();
            this.FolderMaxTextBox = new System.Windows.Forms.TextBox();
            this.SafetyDescription = new System.Windows.Forms.Label();
            this.MakeFoldersButton = new System.Windows.Forms.Button();
            this.RadioSafetyOn = new System.Windows.Forms.RadioButton();
            this.RadioSafetyOff = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // FilePathDesc
            // 
            this.FilePathDesc.AutoSize = true;
            this.FilePathDesc.Location = new System.Drawing.Point(14, 15);
            this.FilePathDesc.Name = "FilePathDesc";
            this.FilePathDesc.Size = new System.Drawing.Size(193, 15);
            this.FilePathDesc.TabIndex = 7;
            this.FilePathDesc.Text = "Input a Filepath to create folders in:";
            // 
            // FileNameDesc
            // 
            this.FileNameDesc.AutoSize = true;
            this.FileNameDesc.Location = new System.Drawing.Point(14, 51);
            this.FileNameDesc.Name = "FileNameDesc";
            this.FileNameDesc.Size = new System.Drawing.Size(159, 15);
            this.FileNameDesc.TabIndex = 8;
            this.FileNameDesc.Text = "Input a Name for the folders:";
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(258, 7);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(247, 23);
            this.FilePathTextBox.TabIndex = 0;
            // 
            // FolderNameTextBox
            // 
            this.FolderNameTextBox.Location = new System.Drawing.Point(258, 48);
            this.FolderNameTextBox.Name = "FolderNameTextBox";
            this.FolderNameTextBox.Size = new System.Drawing.Size(247, 23);
            this.FolderNameTextBox.TabIndex = 1;
            this.FolderNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumFoldersDec
            // 
            this.NumFoldersDec.AutoSize = true;
            this.NumFoldersDec.Location = new System.Drawing.Point(14, 87);
            this.NumFoldersDec.Name = "NumFoldersDec";
            this.NumFoldersDec.Size = new System.Drawing.Size(238, 15);
            this.NumFoldersDec.TabIndex = 9;
            this.NumFoldersDec.Text = "Input an Integer number of folders to make:";
            // 
            // FolderNumberTextBox
            // 
            this.FolderNumberTextBox.Location = new System.Drawing.Point(258, 87);
            this.FolderNumberTextBox.Name = "FolderNumberTextBox";
            this.FolderNumberTextBox.Size = new System.Drawing.Size(247, 23);
            this.FolderNumberTextBox.TabIndex = 2;
            this.FolderNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FolderMaxTextBox
            // 
            this.FolderMaxTextBox.Location = new System.Drawing.Point(107, 216);
            this.FolderMaxTextBox.Name = "FolderMaxTextBox";
            this.FolderMaxTextBox.ReadOnly = true;
            this.FolderMaxTextBox.Size = new System.Drawing.Size(100, 23);
            this.FolderMaxTextBox.TabIndex = 6;
            this.FolderMaxTextBox.Text = "12";
            this.FolderMaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FolderMaxTextBox.TextChanged += new System.EventHandler(this.FolderMaxTextBox_TextChanged);
            // 
            // SafetyDescription
            // 
            this.SafetyDescription.Location = new System.Drawing.Point(12, 137);
            this.SafetyDescription.Name = "SafetyDescription";
            this.SafetyDescription.Size = new System.Drawing.Size(368, 46);
            this.SafetyDescription.TabIndex = 10;
            this.SafetyDescription.Text = "The Radio buttons below will allow editing of the maximum allowable number of fol" +
    "ders to be made. Making many folders at once can be dangrous.";
            // 
            // MakeFoldersButton
            // 
            this.MakeFoldersButton.Location = new System.Drawing.Point(318, 216);
            this.MakeFoldersButton.Name = "MakeFoldersButton";
            this.MakeFoldersButton.Size = new System.Drawing.Size(100, 23);
            this.MakeFoldersButton.TabIndex = 3;
            this.MakeFoldersButton.Text = "Make Folders";
            this.MakeFoldersButton.UseVisualStyleBackColor = true;
            this.MakeFoldersButton.Click += new System.EventHandler(this.MakeFoldersButton_Click);
            // 
            // RadioSafetyOn
            // 
            this.RadioSafetyOn.AutoSize = true;
            this.RadioSafetyOn.Checked = true;
            this.RadioSafetyOn.Location = new System.Drawing.Point(7, 198);
            this.RadioSafetyOn.Name = "RadioSafetyOn";
            this.RadioSafetyOn.Size = new System.Drawing.Size(82, 19);
            this.RadioSafetyOn.TabIndex = 11;
            this.RadioSafetyOn.TabStop = true;
            this.RadioSafetyOn.Text = "Editing Off";
            this.RadioSafetyOn.UseVisualStyleBackColor = true;
            this.RadioSafetyOn.CheckedChanged += new System.EventHandler(this.RadioSafetyOn_CheckedChanged_1);
            // 
            // RadioSafetyOff
            // 
            this.RadioSafetyOff.AutoSize = true;
            this.RadioSafetyOff.Location = new System.Drawing.Point(7, 240);
            this.RadioSafetyOff.Name = "RadioSafetyOff";
            this.RadioSafetyOff.Size = new System.Drawing.Size(81, 19);
            this.RadioSafetyOff.TabIndex = 12;
            this.RadioSafetyOff.Text = "Editing On";
            this.RadioSafetyOff.UseVisualStyleBackColor = true;
            this.RadioSafetyOff.CheckedChanged += new System.EventHandler(this.RadioSafetyOff_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 271);
            this.Controls.Add(this.RadioSafetyOff);
            this.Controls.Add(this.RadioSafetyOn);
            this.Controls.Add(this.MakeFoldersButton);
            this.Controls.Add(this.SafetyDescription);
            this.Controls.Add(this.FolderMaxTextBox);
            this.Controls.Add(this.FolderNumberTextBox);
            this.Controls.Add(this.NumFoldersDec);
            this.Controls.Add(this.FolderNameTextBox);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.FileNameDesc);
            this.Controls.Add(this.FilePathDesc);
            this.Name = "Form1";
            this.Text = "MakeFoldersGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label FilePathDesc;
        private Label FileNameDesc;
        private TextBox FilePathTextBox;
        private TextBox FolderNameTextBox;
        private Label NumFoldersDec;
        private TextBox FolderNumberTextBox;
        private TextBox FolderMaxTextBox;
        private Label SafetyDescription;
        private Button MakeFoldersButton;
        private RadioButton RadioSafetyOn;
        private RadioButton RadioSafetyOff;
    }
}