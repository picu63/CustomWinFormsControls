
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.textLabel = new System.Windows.Forms.Label();
            this.captionLabel = new System.Windows.Forms.Label();
            this.retryButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.abortButton = new System.Windows.Forms.Button();
            this.ignoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yesButton
            // 
            this.yesButton.Image = ((System.Drawing.Image)(resources.GetObject("yesButton.Image")));
            this.yesButton.Location = new System.Drawing.Point(116, 104);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(194, 64);
            this.yesButton.TabIndex = 0;
            this.yesButton.Text = "Yes";
            this.yesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Visible = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Image = ((System.Drawing.Image)(resources.GetObject("noButton.Image")));
            this.noButton.Location = new System.Drawing.Point(358, 104);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(194, 64);
            this.noButton.TabIndex = 1;
            this.noButton.Text = "No";
            this.noButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Visible = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(277, 50);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(119, 15);
            this.textLabel.TabIndex = 2;
            this.textLabel.Text = "There is no text given";
            // 
            // captionLabel
            // 
            this.captionLabel.AutoSize = true;
            this.captionLabel.Location = new System.Drawing.Point(299, 9);
            this.captionLabel.Name = "captionLabel";
            this.captionLabel.Size = new System.Drawing.Size(77, 15);
            this.captionLabel.TabIndex = 3;
            this.captionLabel.Text = "Caption label";
            // 
            // retryButton
            // 
            this.retryButton.Image = ((System.Drawing.Image)(resources.GetObject("retryButton.Image")));
            this.retryButton.Location = new System.Drawing.Point(244, 295);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(194, 64);
            this.retryButton.TabIndex = 4;
            this.retryButton.Text = "Retry";
            this.retryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.retryButton.UseVisualStyleBackColor = true;
            this.retryButton.Visible = false;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click);
            // 
            // okButton
            // 
            this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
            this.okButton.Location = new System.Drawing.Point(116, 205);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(194, 64);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Visible = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(358, 205);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(194, 64);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // abortButton
            // 
            this.abortButton.Image = ((System.Drawing.Image)(resources.GetObject("abortButton.Image")));
            this.abortButton.Location = new System.Drawing.Point(18, 295);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(194, 64);
            this.abortButton.TabIndex = 7;
            this.abortButton.Text = "Abort";
            this.abortButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Visible = false;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // ignoreButton
            // 
            this.ignoreButton.Image = ((System.Drawing.Image)(resources.GetObject("ignoreButton.Image")));
            this.ignoreButton.Location = new System.Drawing.Point(465, 295);
            this.ignoreButton.Name = "ignoreButton";
            this.ignoreButton.Size = new System.Drawing.Size(194, 64);
            this.ignoreButton.TabIndex = 8;
            this.ignoreButton.Text = "Ignore";
            this.ignoreButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ignoreButton.UseVisualStyleBackColor = true;
            this.ignoreButton.Visible = false;
            this.ignoreButton.Click += new System.EventHandler(this.ignoreButton_Click);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 375);
            this.ControlBox = false;
            this.Controls.Add(this.ignoreButton);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.captionLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Name = "CustomMessageBox";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label captionLabel;
        public System.Windows.Forms.Button yesButton;
        public System.Windows.Forms.Button noButton;
        public System.Windows.Forms.Button retryButton;
        public System.Windows.Forms.Button okButton;
        public System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.Button abortButton;
        public System.Windows.Forms.Button ignoreButton;
    }
}