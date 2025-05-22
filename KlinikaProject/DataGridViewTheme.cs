using System;
using System.Drawing;

public class DataGridViewTheme
{
    // **🔵 Sütun başlıqlarının fon və mətn rəngi (Manchester City mavisi)**
    public Color HeaderBackColor { get; set; } = Color.FromArgb(0, 90, 170);  // Tünd Manchester City mavisi
    public Color HeaderForeColor { get; set; } = Color.White;
    public Font HeaderFont { get; set; } = new Font("Arial", 10, FontStyle.Bold);
    public int HeaderHeight { get; set; } = 30;
    public bool ShowRowHeaders { get; set; } = true;

    // **📌 Sətir rəngləri (boz tonlarda, biri açıq, biri tünd)**
    public Color RowBackColor { get; set; } = Color.Gainsboro;  // Açıq boz
    public Color AlternatingRowBackColor { get; set; } = Color.LightGray; // Alternativ açıq boz  
    public Color RowForeColor { get; set; } = Color.Black;
    public Font RowFont { get; set; } = new Font("Arial", 9, FontStyle.Regular);

    // **⚡ Şəbəkə (Grid) xətləri üçün rəng**
    public Color GridColor { get; set; } = Color.DarkGray;

    // **🟦 Seçilən sətirin fon və mətn rəngi**
    public Color SelectionBackColor { get; set; } = Color.DodgerBlue;  // Parlaq göy
    public Color SelectionForeColor { get; set; } = Color.White;
}
