using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomMessageBoxes
{
    public partial class CustomMessageBox : Form
    {
        private static CustomMessageBox _instance;

        public string Message
        {
            get => this.textLabel.Text;
            private set => this.textLabel.Text = value;
        }
        public string Caption
        {
            get => this.captionLabel.Text;
            private set => this.captionLabel.Text = value;
        }

        private List<Button> Buttons => GetAll(this, typeof(Button)).Cast<Button>().ToList();

        public CustomMessageBox()
        {
            InitializeComponent();
            Buttons.ForEach(MoveToBottom);
            //Buttons.ForEach(button => button.Visible = true);
        }

        protected override void SetVisibleCore(bool value)
        {
            if (!this.IsHandleCreated)
            {
                value = false;
                CreateHandle();
            }
            base.SetVisibleCore(value);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            GetInstance();
            _instance.Message = text;
            _instance.Caption = caption;
            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    _instance.InitOk();
                    break;
                case MessageBoxButtons.OKCancel:
                    _instance.InitOKCancel();
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    _instance.InitAbortRetryIgnore();
                    break;
                case MessageBoxButtons.YesNoCancel:
                    _instance.InitYesNoCancel();
                    break;
                case MessageBoxButtons.YesNo:
                    _instance.InitYesNo();
                    break;
                case MessageBoxButtons.RetryCancel:
                    _instance.InitRetryCancel();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(buttons), buttons, null);
            }

            return _instance.ShowDialog();
        }

        private static CustomMessageBox GetInstance()
        {
            if (_instance is null)
            {
                _instance = new CustomMessageBox();
            }

            return _instance;
        }

        private void InitRetryCancel()
        {
            ShowButtons(new List<Button>{retryButton, cancelButton});
        }

        private void InitYesNo()
        {
            ShowButtons(new List<Button>{yesButton, noButton});
        }

        private void InitYesNoCancel()
        {
            ShowButtons(new List<Button>{yesButton, noButton, cancelButton});
        }

        private void InitAbortRetryIgnore()
        {
            ShowButtons(new List<Button> {abortButton, retryButton, ignoreButton});
        }


        private void InitOKCancel()
        {
            ShowButtons(new List<Button> { okButton, cancelButton });
        }

        private void InitOk()
        {
            CenterVertical(okButton);
            ShowButtons(new List<Button>{okButton});
        }

        private void CenterVertical(Control control)
        {
            control.Location = new Point(this.Size.Width / 2 - control.Size.Width / 2, control.Location.Y);
        }

        private void MoveToBottom(Control control)
        {
            control.Location = new Point(control.Location.X, this.Size.Height - this.Margin.Bottom - control.Size.Height *2);
        }

        /// <summary>
        /// https://stackoverflow.com/a/3426721
        /// </summary>
        /// <param name="control"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                .Concat(controls)
                .Where(c => c.GetType() == type);
        }

        /// <summary>
        /// Wyświetla podane buttony, ukrywa pozostałe.
        /// </summary>
        /// <param name="buttons"></param>
        private void ShowButtons(List<Button> buttons)
        {
            Buttons.ForEach(b => b.Visible = false);
            buttons.ForEach(b => b.Visible = true);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            Buttons.ForEach(b => b.Visible = false);
            this.DialogResult = DialogResult.Yes;
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void ignoreButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
