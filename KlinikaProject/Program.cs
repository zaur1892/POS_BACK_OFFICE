using System.Globalization;
using PdfSharp.Fonts;

namespace POS_BACK_OFFICE
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {



            GlobalFontSettings.FontResolver = new CustomFontResolver(); // Font resolver-i qlobal olaraq təyin edirik



            // Tətbiq konfiqurasiyasını fərdiləşdirin
            ApplicationConfiguration.Initialize();



            // ✅ Burada Azərbaycan lokalını tətbiq edirik (vergül ayırıcı üçün)
            CultureInfo azCulture = new CultureInfo("az-Latn-AZ");
            Thread.CurrentThread.CurrentCulture = azCulture;
            Thread.CurrentThread.CurrentUICulture = azCulture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Ana formu işə salın
            Application.Run(new GirishFormu());
        }
    }
}
