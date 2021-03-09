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
using System.Windows.Forms.VisualStyles;

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

        private MessageBoxButtons _buttons;

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
            throw new NotImplementedException();
        }

        private void InitYesNo()
        {
            throw new NotImplementedException();
        }

        private void InitYesNoCancel()
        {
            throw new NotImplementedException();
        }

        private void InitAbortRetryIgnore()
        {
            abortButton.Visible = true;
            retryButton.Visible = true;
            ignoreButton.Visible = true;
        }

        private void InitOKCancel()
        {
            throw new NotImplementedException();
        }

        private void InitOk()
        {
            var size = this.Size;
            yesButton.Visible = true;
            CenterVertical(yesButton);
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

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
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
