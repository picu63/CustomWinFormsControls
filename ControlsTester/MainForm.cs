using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomMessageBoxes;

namespace ControlsTester
{
    public partial class MainForm : Form
    {
        private Control controlClicked;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            testNameLabel.Text = "Control clicked: Ok";
            controlClicked = new CustomMessageBox();
            CustomMessageBox.Show("Text label", "Caption label", MessageBoxButtons.OK);
        }

        private void abortRetryIgnore_Click(object sender, EventArgs e)
        {
            testNameLabel.Text = "Control clicked: Abort Retry Ignore";

           var result = CustomMessageBox.Show("Text label", "Ok Test", MessageBoxButtons.AbortRetryIgnore);
            if (result == DialogResult.Retry)
            {
                MessageBox.Show("Retry Clicked");
            }

            if (result == DialogResult.Abort)
            {
                MessageBox.Show("Abort clicked");
            }

            if (result == DialogResult.Ignore)
            {
                MessageBox.Show("Ignore clicked");
            }
        }

        private void ObjectTest_Click(object sender, EventArgs e)
        {
            testNameLabel.Text = "Control clicked: Object test";

            var message = new CustomMessageBox();
            message.YesButton.Text = "Tak";
            message.BoxButtons = MessageBoxButtons.YesNo;
            message.ShowDialog();
        }

        private void RetryCancel_Click(object sender, EventArgs e)
        {
            testNameLabel.Text = "Control clicked: Retry Cancel";

            var result = CustomMessageBox.Show("Text label", "Ok Test", MessageBoxButtons.RetryCancel);
        }

        private void AbortRetryIgnoreWithCustom_Click(object sender, EventArgs e)
        {
            testNameLabel.Text = "Control clicked: Abort Retry Ignore with Custom";

            var cmb = new CustomMessageBox("Title", "Message", MessageBoxButtons.AbortRetryIgnore);
            cmb.CustomButton.Text = "Custom Button";
            cmb.CustomButton.Click += (_, _) =>
            {
                MessageBox.Show("Custom Button Clicked!");
                cmb.Close();
            };
            cmb.ShowDialog();
        }

        private void OKCancel_Click(object sender, EventArgs e)
        {
            CustomMessageBox.Show("Title", "Message", MessageBoxButtons.OKCancel);
        }
    }
}
