using System;
using System.Windows.Forms;

namespace BTI_MySqlServer
{
    static class ControlInput
    {
        public static void iDigitInt(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        public static void iDigitDouble(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (e.KeyChar == 46) e.KeyChar = ',';
            if (!Char.IsDigit(ch) && e.KeyChar != 44 && ch != 8) 
            e.Handled = true;
        }
    }
}
