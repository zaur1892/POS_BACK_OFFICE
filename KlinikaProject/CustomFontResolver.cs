using PdfSharp.Fonts;
using System.IO;

public class CustomFontResolver : IFontResolver
{
    public byte[] GetFont(string faceName)
    {
        if (faceName == "Arial#")
        {
            return File.ReadAllBytes("Fonts/arial.ttf");
        }

        throw new ArgumentException("Unknown font: " + faceName);
    }

    public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
    {
        if (familyName.Equals("Arial", StringComparison.OrdinalIgnoreCase))
        {
            return new FontResolverInfo("Arial#");
        }

        return null;
    }
}
