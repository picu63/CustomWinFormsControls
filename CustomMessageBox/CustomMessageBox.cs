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

        public Size DefaultButtonSize { get; private set; } = (new Size(160, 40));

        /// <summary>
        /// Returns <see cref="DialogResult.None"/>
        /// </summary>
        public Button CustomButton
        {
            get
            {
                hasCustomButton = true;
                return this.customButton;
            }
        }

        public Button OkButton => this.okButton;
        public Button CancelButton => this.cancelButton;
        public Button IgnoreButton => this.ignoreButton;
        public Button YesButton => this.yesButton;
        public Button NoButton => this.noButton;
        public Button RetryButton => this.retryButton;
        public Button AbortButton => this.abortButton;

        private static CustomMessageBox _instance;
        private bool hasCustomButton;

        private List<Button> Buttons => GetAll(this, typeof(Button)).Cast<Button>().ToList();
        private List<Button> EnabledButtons => Buttons.Where(b => b.Enabled).ToList();

        public CustomMessageBox()
        {
            InitializeComponent();
        }

        public CustomMessageBox(string caption, string message, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            InitializeComponent();
            this.Caption = caption;
            this.Message = message;
            this.BoxButtons = buttons;
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
            InitButtons(BoxButtons);
            return base.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="caption">Title of message box.</param>
        /// <param name="buttons"></param>
        /// <returns></returns>
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            var instance = GetInstance();
            instance.Message = text;
            instance.Caption = caption;
            instance.BoxButtons = buttons;
            //instance.InitButtons(buttons);
            return instance.ShowDialog();
        }

        public static DialogResult Show(Exception ex, string caption)
        {
            return Show(ex.ToString(), caption, MessageBoxButtons.OK);
        }

        public void SetButtonsSize(Size size)
        {
            DefaultButtonSize = size;
        }

        private void InitButtons(MessageBoxButtons buttons)
        {
            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    this.ShowOk();
                    break;
                case MessageBoxButtons.OKCancel:
                    this.ShowOkCancel();
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    this.ShowAbortRetryIgnore();
                    break;
                case MessageBoxButtons.YesNoCancel:
                    this.ShowYesNoCancel();
                    break;
                case MessageBoxButtons.YesNo:
                    this.ShowYesNo();
                    break;
                case MessageBoxButtons.RetryCancel:
                    this.ShowRetryCancel();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(buttons), buttons, null);
            }

            var enabledButtons = EnabledButtons.Cast<Control>().ToList();
            foreach (var b in enabledButtons)
            {
                b.Size = DefaultButtonSize;
            }
            this.MoveToBottom(enabledButtons);
            this.AlignHorizontally(enabledButtons);
        }

        public void MoveToBottom(List<Control> controls)
        {
            var bottomOfTextbox = this.messageTextBox.Location.Y + this.messageTextBox.Size.Height;
            var bottomOfForm = this.Size.Height - this.Margin.Bottom;
            var centerBetween = bottomOfForm - (bottomOfForm - bottomOfTextbox)/2;

            foreach (var control in controls)
            {
                control.Location = new Point(control.Location.X, centerBetween - control.Height);
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

        private void ShowRetryCancel()
        {
            ShowButtons(new List<Button>{retryButton, cancelButton});
        }

        private void ShowYesNo()
        {
            ShowButtons(new List<Button>{yesButton, noButton});
        }

        private void ShowYesNoCancel()
        {
            ShowButtons(new List<Button>{yesButton, noButton, cancelButton});
        }

        private void ShowAbortRetryIgnore()
        {
            ShowButtons(new List<Button> {abortButton, retryButton, ignoreButton});
        }


        private void ShowOkCancel()
        {
            ShowButtons(new List<Button> { okButton, cancelButton });
        }

        private void ShowOk()
        {
            ShowButtons(new List<Button>{okButton});
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
            if (hasCustomButton)
            {
                buttons.Add(customButton);
            }
            Buttons.ForEach(b => b.Enabled = false);
            buttons.ForEach(b => b.Enabled = true);
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

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // CustomMessageBox
        //    // 
        //    this.ClientSize = new System.Drawing.Size(1102, 469);
        //    this.Name = "CustomMessageBox";
        //    this.ResumeLayout(false);
        //}
    }
}
