
namespace ControlsTester
{
    partial class CustomMessageBoxTests
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
            this.customMessageBoxButton = new System.Windows.Forms.Button();
            this.dialogResultLabel = new System.Windows.Forms.Label();
            this.testNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customMessageBoxButton
            // 
            this.customMessageBoxButton.Location = new System.Drawing.Point(57, 181);
            this.customMessageBoxButton.Name = "customMessageBoxButton";
            this.customMessageBoxButton.Size = new System.Drawing.Size(189, 64);
            this.customMessageBoxButton.TabIndex = 1;
            this.customMessageBoxButton.Text = "CustomMessageBox";
            this.customMessageBoxButton.UseVisualStyleBackColor = true;
            this.customMessageBoxButton.Click += new System.EventHandler(this.customMessageBoxButton_Click);
            // 
            // dialogResultLabel
            // 
            this.dialogResultLabel.AutoSize = true;
            this.dialogResultLabel.Location = new System.Drawing.Point(26, 37);
            this.dialogResultLabel.Name = "dialogResultLabel";
            this.dialogResultLabel.Size = new System.Drawing.Size(79, 15);
            this.dialogResultLabel.TabIndex = 4;
            this.dialogResultLabel.Text = "Dialog result: ";
            // 
            // testNameLabel
            // 
            this.testNameLabel.AutoSize = true;
            this.testNameLabel.Location = new System.Drawing.Point(12, 9);
            this.testNameLabel.Name = "testNameLabel";
            this.testNameLabel.Size = new System.Drawing.Size(93, 15);
            this.testNameLabel.TabIndex = 3;
            this.testNameLabel.Text = "Control clicked: ";
            // 
            // CustomMessageBoxTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dialogResultLabel);
            this.Controls.Add(this.testNameLabel);
            this.Controls.Add(this.customMessageBoxButton);
            this.Name = "CustomMessageBoxTests";
            this.Text = "CustomMessageBoxTests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button customMessageBoxButton;
        private System.Windows.Forms.Label dialogResultLabel;
        private System.Windows.Forms.Label testNameLabel;
    }
}