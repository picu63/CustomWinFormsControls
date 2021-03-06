
namespace CustomMessageBoxes
{
    partial class CustomMessageBox
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
            this.SuspendLayout();
            // 
            // CustomMessageBox
            // 
            this.ClientSize = new System.Drawing.Size(1102, 469);
            this.Name = "CustomMessageBox";
            this.ResumeLayout(false);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.captionLabel = new System.Windows.Forms.Label();
            this.retryButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.abortButton = new System.Windows.Forms.Button();
            this.ignoreButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.customButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yesButton
            // 
            this.yesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yesButton.Image = ((System.Drawing.Image)(resources.GetObject("yesButton.Image")));
            this.yesButton.Location = new System.Drawing.Point(116, 104);
            this.yesButton.Margin = new System.Windows.Forms.Padding(4);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(193, 64);
            this.yesButton.TabIndex = 0;
            this.yesButton.Text = "Yes";
            this.yesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Visible = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.noButton.Image = ((System.Drawing.Image)(resources.GetObject("noButton.Image")));
            this.noButton.Location = new System.Drawing.Point(358, 104);
            this.noButton.Margin = new System.Windows.Forms.Padding(4);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(193, 64);
            this.noButton.TabIndex = 1;
            this.noButton.Text = "No";
            this.noButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Visible = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // captionLabel
            // 
            this.captionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.captionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.captionLabel.Location = new System.Drawing.Point(8, 9);
            this.captionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.captionLabel.Name = "captionLabel";
            this.captionLabel.Size = new System.Drawing.Size(662, 29);
            this.captionLabel.TabIndex = 3;
            this.captionLabel.Text = "Caption label";
            this.captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // retryButton
            // 
            this.retryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.retryButton.Image = ((System.Drawing.Image)(resources.GetObject("retryButton.Image")));
            this.retryButton.Location = new System.Drawing.Point(244, 295);
            this.retryButton.Margin = new System.Windows.Forms.Padding(4);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(193, 64);
            this.retryButton.TabIndex = 4;
            this.retryButton.Text = "Retry";
            this.retryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.retryButton.UseVisualStyleBackColor = true;
            this.retryButton.Visible = false;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
            this.okButton.Location = new System.Drawing.Point(116, 205);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(193, 64);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Visible = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(358, 205);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(193, 64);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // abortButton
            // 
            this.abortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.abortButton.Image = ((System.Drawing.Image)(resources.GetObject("abortButton.Image")));
            this.abortButton.Location = new System.Drawing.Point(18, 295);
            this.abortButton.Margin = new System.Windows.Forms.Padding(4);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(193, 64);
            this.abortButton.TabIndex = 7;
            this.abortButton.Text = "Abort";
            this.abortButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Visible = false;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // ignoreButton
            // 
            this.ignoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ignoreButton.Image = ((System.Drawing.Image)(resources.GetObject("ignoreButton.Image")));
            this.ignoreButton.Location = new System.Drawing.Point(466, 295);
            this.ignoreButton.Margin = new System.Windows.Forms.Padding(4);
            this.ignoreButton.Name = "ignoreButton";
            this.ignoreButton.Size = new System.Drawing.Size(193, 64);
            this.ignoreButton.TabIndex = 8;
            this.ignoreButton.Text = "Ignore";
            this.ignoreButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ignoreButton.UseVisualStyleBackColor = true;
            this.ignoreButton.Visible = false;
            this.ignoreButton.Click += new System.EventHandler(this.ignoreButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageTextBox.Location = new System.Drawing.Point(8, 40);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(661, 236);
            this.messageTextBox.TabIndex = 12;
            this.messageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customButton
            // 
            this.customButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.customButton.Location = new System.Drawing.Point(242, 156);
            this.customButton.Margin = new System.Windows.Forms.Padding(4);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(193, 64);
            this.customButton.TabIndex = 13;
            this.customButton.Text = "Custom button";
            this.customButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton.UseVisualStyleBackColor = true;
            this.customButton.Visible = false;
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 375);
            //
            // Important! Sequence means a lot!
            //
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.ignoreButton);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.customButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.captionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomMessageBox";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label captionLabel;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button customButton;
        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.Button retryButton;
        private System.Windows.Forms.Button ignoreButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button yesButton;
    }
}