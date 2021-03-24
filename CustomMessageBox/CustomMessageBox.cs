using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CustomMessageBoxes
{
    public partial class CustomMessageBox : Form
    {
        public MessageBoxButtons BoxButtons { get; set; }
        public string Message
        {
            get => this.messageTextBox.Text;
            set => this.messageTextBox.Text = value;
        }

        public string Caption
        {
            get => this.captionLabel.Text;
            set => this.captionLabel.Text = value;
        }

        private static CustomMessageBox _instance;

        private List<Button> Buttons => GetAll(this, typeof(Button)).Cast<Button>().ToList();

        public CustomMessageBox()
        {
            InitializeComponent();
            Buttons.ForEach(MoveToBottom);
        }

        public CustomMessageBox(string caption, string message)
        {
            InitializeComponent();
            Buttons.ForEach(MoveToBottom);
            this.Caption = caption;
            this.Message = message;
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


        public new DialogResult ShowDialog()
        {
            GetInstance();
            InitButtons(BoxButtons);
            return base.ShowDialog();
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            GetInstance();
            _instance.Message = text;
            _instance.Caption = caption;
            _instance.InitButtons(buttons);
            return _instance.ShowDialog();
        }

        private void InitButtons(MessageBoxButtons buttons)
        {
            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    this.InitOk();
                    break;
                case MessageBoxButtons.OKCancel:
                    this.InitOKCancel();
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    this.InitAbortRetryIgnore();
                    break;
                case MessageBoxButtons.YesNoCancel:
                    this.InitYesNoCancel();
                    break;
                case MessageBoxButtons.YesNo:
                    this.InitYesNo();
                    break;
                case MessageBoxButtons.RetryCancel:
                    this.InitRetryCancel();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(buttons), buttons, null);
            }

            if (customButton.Visible && customButton.Enabled)
            {
                
            }
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
        private IEnumerable<Control> GetAll(Control control, Type type)
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
            Buttons.ForEach(b => b.Visible = false);
            this.DialogResult = DialogResult.OK;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            Buttons.ForEach(b => b.Visible = false);
            this.DialogResult = DialogResult.Yes;
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            Buttons.ForEach(b => b.Visible = false);
            this.DialogResult = DialogResult.Retry;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            Buttons.ForEach(b => b.Visible = false);
            this.DialogResult = DialogResult.No;
        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            Buttons.ForEach(b => b.Visible = false);
            this.DialogResult = DialogResult.Abort;
        }

        private void ignoreButton_Click(object sender, EventArgs e)
        {
            Buttons.ForEach(b => b.Visible = false);
            this.DialogResult = DialogResult.Ignore;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Buttons.ForEach(b => b.Visible = false);
            this.DialogResult = DialogResult.Cancel;
        }

        private void customButton_Click(object sender, EventArgs e)
        {
            Buttons.ForEach(b => b.Visible = false);
            this.DialogResult = DialogResult.None;
        }
    }
}
