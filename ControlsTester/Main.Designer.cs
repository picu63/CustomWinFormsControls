
namespace ControlsTester
{
    partial class retryAbortIgnoreButton
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
            this.testNameLabel = new System.Windows.Forms.Label();
            this.dialogResultLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.abortRetryIgnoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testNameLabel
            // 
            this.testNameLabel.AutoSize = true;
            this.testNameLabel.Location = new System.Drawing.Point(12, 24);
            this.testNameLabel.Name = "testNameLabel";
            this.testNameLabel.Size = new System.Drawing.Size(93, 15);
            this.testNameLabel.TabIndex = 1;
            this.testNameLabel.Text = "Control clicked: ";
            // 
            // dialogResultLabel
            // 
            this.dialogResultLabel.AutoSize = true;
            this.dialogResultLabel.Location = new System.Drawing.Point(26, 52);
            this.dialogResultLabel.Name = "dialogResultLabel";
            this.dialogResultLabel.Size = new System.Drawing.Size(79, 15);
            this.dialogResultLabel.TabIndex = 2;
            this.dialogResultLabel.Text = "Dialog result: ";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(71, 236);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(189, 64);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // abortRetryIgnoreButton
            // 
            this.abortRetryIgnoreButton.Location = new System.Drawing.Point(71, 320);
            this.abortRetryIgnoreButton.Name = "abortRetryIgnoreButton";
            this.abortRetryIgnoreButton.Size = new System.Drawing.Size(189, 64);
            this.abortRetryIgnoreButton.TabIndex = 4;
            this.abortRetryIgnoreButton.Text = "Abort Retry Ignore";
            this.abortRetryIgnoreButton.UseVisualStyleBackColor = true;
            this.abortRetryIgnoreButton.Click += new System.EventHandler(this.abortRetryIgnore_Click);
            // 
            // retryAbortIgnoreButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.abortRetryIgnoreButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.dialogResultLabel);
            this.Controls.Add(this.testNameLabel);
            this.Name = "retryAbortIgnoreButton";
            this.Text = "Controls Tester";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label testNameLabel;
        private System.Windows.Forms.Label dialogResultLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button abortRetryIgnoreButton;
    }
}

