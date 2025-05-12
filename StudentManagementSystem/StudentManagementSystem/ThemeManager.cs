using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

public static class ThemeManager
{
    public static bool IsDarkTheme { get; set; } = false;

    public static void ApplyTheme(Control control)
    {
        Color backColor = IsDarkTheme ? Color.FromArgb(30, 30, 30) : Color.White;
        Color foreColor = IsDarkTheme ? Color.White : Color.Black;

        control.BackColor = backColor;
        control.ForeColor = foreColor;

        foreach (Control c in control.Controls)
        {
            ApplyTheme(c);
        }
    }

    public static void ToggleTheme(Control formRoot)
    {
        IsDarkTheme = !IsDarkTheme;
        ApplyTheme(formRoot);
    }
}
