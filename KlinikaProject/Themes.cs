public static class Themes
{
    public static DataGridViewTheme ClassicTheme => new DataGridViewTheme
    {
        HeaderBackColor = Color.DarkBlue,
        HeaderForeColor = Color.White,
        HeaderFont = new Font("Segoe UI", 10, FontStyle.Bold),
        HeaderHeight = 35,
        ShowRowHeaders = false,

        RowBackColor = Color.WhiteSmoke,
        AlternatingRowBackColor = Color.LightGray,
        RowForeColor = Color.Black,
        RowFont = new Font("Segoe UI", 10, FontStyle.Regular),
        SelectionBackColor = Color.DarkSlateGray,
        SelectionForeColor = Color.White,
        GridColor = Color.Gray
    };

    public static DataGridViewTheme DarkTheme => new DataGridViewTheme
    {
        HeaderBackColor = Color.Black,
        HeaderForeColor = Color.White,
        HeaderFont = new Font("Segoe UI", 10, FontStyle.Bold),
        HeaderHeight = 35,
        ShowRowHeaders = false,

        RowBackColor = Color.FromArgb(30, 30, 30),
        AlternatingRowBackColor = Color.FromArgb(45, 45, 45),
        RowForeColor = Color.White,
        RowFont = new Font("Segoe UI", 10, FontStyle.Regular),
        SelectionBackColor = Color.DarkGray,
        SelectionForeColor = Color.Black,
        GridColor = Color.DarkGray
    };
}
