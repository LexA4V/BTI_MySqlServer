using System;
using System.Linq;
using System.Windows.Forms;

namespace BTI_MySqlServer
{
    class Access
    {
        static public void VisibleControl(User user, Control.ControlCollection Window)
        {
            foreach(Control c in Window)
            {
                if (!String.IsNullOrWhiteSpace(c.Tag?.ToString()))
                {
                    switch (c.Tag.ToString().First())
                    {
                        case 'v': c.Visible = User.getCurrent().Root.Read; break;
                        case 'i': c.Visible = User.getCurrent().Root.Insert; break;
                        case 'e': c.Visible = User.getCurrent().Root.Edit; break;
                        case 'd': c.Visible = User.getCurrent().Root.Delete; break;
                        case 's': c.Visible = User.getCurrent().Root.Setting; break;
                        default: break;
                    }
                }
                else if (c.GetType() == typeof(Panel) || c.GetType() == typeof(FlowLayoutPanel) || c.GetType() == typeof(GroupBox))
                    VisibleControl(user, c.Controls);
            }
        }
    }
}
