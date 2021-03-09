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
    public partial class retryAbortIgnoreButton : Form
    {
        private Control controlClicked;

        public retryAbortIgnoreButton()
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

            CustomMessageBox.Show("Text label", "Ok Test", MessageBoxButtons.AbortRetryIgnore);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testNameLabel.Text = "Control clicked: Object test";

            var message = new CustomMessageBox();
            message.yesButton.Text = "Tak";
            message.BoxButtons = MessageBoxButtons.YesNo;
            message.ShowDialog();
        }
    }
}
