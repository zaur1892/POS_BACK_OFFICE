using System;
using System.Drawing;
using System.Windows.Forms;

public static class ThemeManager
{
    public static void ApplyTheme(DataGridView dgv, DataGridViewTheme theme)
    {
        if (dgv == null || theme == null) return;

        dgv.EnableHeadersVisualStyles = false;

        // Fontları burada təyin et — Arial, 14, Bold
        Font headerFont = new Font("Arial", 14);
        Font rowFont = new Font("Arial", 12);

        dgv.ColumnHeadersDefaultCellStyle.BackColor = theme.HeaderBackColor;
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = theme.HeaderForeColor;
        dgv.ColumnHeadersDefaultCellStyle.Font = headerFont;
        dgv.ColumnHeadersHeight = theme.HeaderHeight;
        dgv.RowHeadersVisible = theme.ShowRowHeaders;

        dgv.DefaultCellStyle.Font = rowFont;
        dgv.DefaultCellStyle.BackColor = theme.RowBackColor;
        dgv.AlternatingRowsDefaultCellStyle.BackColor = theme.AlternatingRowBackColor;
        dgv.DefaultCellStyle.ForeColor = theme.RowForeColor;

        dgv.DefaultCellStyle.SelectionBackColor = theme.SelectionBackColor;
        dgv.DefaultCellStyle.SelectionForeColor = theme.SelectionForeColor;

        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgv.GridColor = theme.GridColor;
        dgv.BorderStyle = BorderStyle.None;

        foreach (DataGridViewColumn col in dgv.Columns)
        {
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        AlignNumericColumns(dgv);
        FixCheckBoxColumns(dgv);
    }

    private static void AlignNumericColumns(DataGridView dgv)
    {
        foreach (DataGridViewColumn column in dgv.Columns)
        {
            if (column.ValueType == typeof(int) || column.ValueType == typeof(decimal) || column.ValueType == typeof(double))
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
        }
    }

    private static void FixCheckBoxColumns(DataGridView dgv)
    {
        foreach (DataGridViewColumn column in dgv.Columns)
        {
            if (column is DataGridViewCheckBoxColumn checkBoxColumn)
            {
                checkBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                checkBoxColumn.Width = 50;
            }
        }
    }
}
