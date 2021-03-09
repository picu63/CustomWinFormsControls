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
    public partial class CustomMessageBoxTests : Form
    {
        private Control controlClicked;

        public CustomMessageBoxTests()
        {
            InitializeComponent();
        }

        private void customMessageBoxButton_Click(object sender, EventArgs e)
        {
            testNameLabel.Text = "Control clicked:" + nameof(CustomMessageBox);
            controlClicked = new CustomMessageBox();
            controlClicked.Show();
        }
    }
}
