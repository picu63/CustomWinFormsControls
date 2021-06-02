using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomMessageBoxes
{
    public static class ControlPositioner
    {
        public static void AlignHorizontally(this Form form, List<Control> controls)
        {
            var sections = controls.Count;
            var sectionSize = (form.Size.Width - form.Margin.Left - form.Margin.Right)/ sections;
            for (var index = 0; index < controls.Count; index++)
            {
                var control = controls[index];
                var startSectionPoint = new Point(form.Margin.Left + index * sectionSize, control.Location.Y);
                var nextSectionPoint = new Point((form.Margin.Left + index * sectionSize) + sectionSize, control.Location.Y);
                var centerPoint = GetCenterBetweenTwoPoints(startSectionPoint, nextSectionPoint).X;
                control.Location = new Point(centerPoint - control.Size.Width / 2, control.Location.Y);
            }
        }

        public static void MoveToBottom(this Form form, List<Control> controls)
        {
            foreach (var control in controls)
            {
                control.Location = new Point(control.Location.X, form.Size.Height - form.Margin.Bottom - control.Size.Height * 2);
            }
        }

        private static Point GetCenterPoint(this Control control)
        {
            return new Point(control.Location.X - control.Size.Width / 2, control.Location.Y - control.Size.Height / 2);
        }

        private static Point GetCenterBetweenTwoPoints(Point first, Point second)
        {
            return new Point((first.X + second.X)/2, (first.Y + second.Y)/2);
        }
        private static void CenterVertical(Form form, Control control)
        {
            control.Location = new Point(form.Size.Width / 2 - control.Size.Width / 2, control.Location.Y);
        }
    }
}
