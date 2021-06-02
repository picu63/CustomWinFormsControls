
namespace ControlsTester
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
            this.testNameLabel = new System.Windows.Forms.Label();
            this.dialogResultLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.abortRetryIgnoreButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.exceptionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testNameLabel
            // 
            this.testNameLabel.AutoSize = true;
            this.testNameLabel.Location = new System.Drawing.Point(14, 32);
            this.testNameLabel.Name = "testNameLabel";
            this.testNameLabel.Size = new System.Drawing.Size(115, 20);
            this.testNameLabel.TabIndex = 1;
            this.testNameLabel.Text = "Control clicked: ";
            // 
            // dialogResultLabel
            // 
            this.dialogResultLabel.AutoSize = true;
            this.dialogResultLabel.Location = new System.Drawing.Point(30, 69);
            this.dialogResultLabel.Name = "dialogResultLabel";
            this.dialogResultLabel.Size = new System.Drawing.Size(101, 20);
            this.dialogResultLabel.TabIndex = 2;
            this.dialogResultLabel.Text = "Dialog result: ";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(81, 315);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(216, 85);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // abortRetryIgnoreButton
            // 
            this.abortRetryIgnoreButton.Location = new System.Drawing.Point(81, 427);
            this.abortRetryIgnoreButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.abortRetryIgnoreButton.Name = "abortRetryIgnoreButton";
            this.abortRetryIgnoreButton.Size = new System.Drawing.Size(216, 85);
            this.abortRetryIgnoreButton.TabIndex = 4;
            this.abortRetryIgnoreButton.Text = "Abort Retry Ignore";
            this.abortRetryIgnoreButton.UseVisualStyleBackColor = true;
            this.abortRetryIgnoreButton.Click += new System.EventHandler(this.abortRetryIgnore_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 195);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 85);
            this.button1.TabIndex = 5;
            this.button1.Text = "Object test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ObjectTest_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 427);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 85);
            this.button2.TabIndex = 6;
            this.button2.Text = "Retry Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RetryCancel_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(344, 195);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 85);
            this.button3.TabIndex = 7;
            this.button3.Text = "Abort Retry Ignore with Custom";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AbortRetryIgnoreWithCustom_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(344, 315);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 85);
            this.button4.TabIndex = 8;
            this.button4.Text = "OK Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OKCancel_Click);
            // 
            // exceptionButton
            // 
            this.exceptionButton.Location = new System.Drawing.Point(610, 427);
            this.exceptionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exceptionButton.Name = "exceptionButton";
            this.exceptionButton.Size = new System.Drawing.Size(216, 85);
            this.exceptionButton.TabIndex = 9;
            this.exceptionButton.Text = "Exception";
            this.exceptionButton.UseVisualStyleBackColor = true;
            this.exceptionButton.Click += new System.EventHandler(this.exceptionButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.exceptionButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.abortRetryIgnoreButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.dialogResultLabel);
            this.Controls.Add(this.testNameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button exceptionButton;
    }
}

