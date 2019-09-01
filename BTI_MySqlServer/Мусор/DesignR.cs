/*
 * Registration of applications in the Bureau of Technical Inventory
 * This software works with applications for the inventory of real estate
 * Copyright (C) 2018 Vasilev Sergey
 * E-mail: sergey.vasilev.99@inbox.ru
 * 
 * This program is free software: you can redistribute it and/or modify it under the terms
 * of the GNU General Public License as published by the Free Software Foundation, either
 * version 3 of the License, or (at your option) any later version.
 * This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
 * without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 * See the GNU General Public License for more details.
 * You should have received a copy of the GNU General Public License along with this program.
 * If not, see <http://www.gnu.org/licenses/>.
*/
using System.Drawing;
using System.Windows.Forms;

namespace BTI_MySqlServer
{
    static class Theme
    {
        public static void DesignTable(DataGridView Table)
        {
            //Table.BorderStyle = BorderStyle.None;
            Table.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            Table.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Table.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            Table.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            Table.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Table.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Table.BackgroundColor = Color.FromArgb(255, 239, 211);
            Table.EnableHeadersVisualStyles = false;
            Table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Table.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(43, 73, 132);//20, 25, 72
            Table.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Table.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        }
    }
}
