using PdfSharp.Drawing;
using PdfSharp.Pdf;
using POS_BACK_OFFICE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

public class PDFExporter
{
    private List<AppSetting> settings;

    public PDFExporter(List<AppSetting> appSettings)
    {
        this.settings = appSettings;
    }

    public void ExportToPDF(DataGridView grid, string settingsPrefix, string filePath, Dictionary<string, string> headerFieldValues)
    {
        var pdfColumns = GetSettingValue("PDF_EXPORT", $"{settingsPrefix}_PDF_COLUMNS")
                            ?.Split(',')
                            ?.Select(c => c.Trim())
                            ?.ToList();

        if (pdfColumns == null || pdfColumns.Count == 0)
            throw new Exception("PDF-ə çıxacaq sütunlar təyin olunmayıb.");

        var columnHeaderMap = ParseMap(GetSettingValue("PDF_EXPORT", $"{settingsPrefix}_PDF_HEADER_MAP"));
        var headerLabelMap = ParseMap(GetSettingValue("PDF_EXPORT", $"{settingsPrefix}_PDF_HEADER_FIELDS"));

        using (var doc = new PdfDocument())
        {
            PdfPage page = doc.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            var font = new XFont("Arial", 12);
            double y = 20;
            double xStart = 20;
            double columnWidth = 100;

            // 🔰 Başlıq hissəsi
            foreach (var key in headerLabelMap.Keys)
            {
                if (headerFieldValues.ContainsKey(key))
                {
                    string label = headerLabelMap[key];
                    string value = headerFieldValues[key];
                    gfx.DrawString($"{label}: {value}", font, XBrushes.Black, new XRect(xStart, y, page.Width, page.Height), XStringFormats.TopLeft);
                    y += 20;
                }
            }

            y += 10;

            // 🔰 Cədvəl başlıqları
            xStart = 20;
            foreach (var col in pdfColumns)
            {
                string headerText = columnHeaderMap.ContainsKey(col) ? columnHeaderMap[col] : col;
                gfx.DrawString(headerText, font, XBrushes.Black, new XRect(xStart, y, columnWidth, page.Height), XStringFormats.TopLeft);
                gfx.DrawRectangle(XPens.Black, xStart, y, columnWidth, 20);
                xStart += columnWidth;
            }

            y += 20;

            // 🔰 Məlumat satırları
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;

                double rowHeight = 20;
                xStart = 20;

                foreach (var col in pdfColumns)
                {
                    var column = grid.Columns
                        .Cast<DataGridViewColumn>()
                        .FirstOrDefault(c => c.DataPropertyName == col);

                    if (column == null) continue;

                    string cellValue = row.Cells[column.Index].Value?.ToString() ?? "";
                    gfx.DrawString(cellValue, font, XBrushes.Black, new XRect(xStart, y, columnWidth, rowHeight), XStringFormats.TopLeft);
                    gfx.DrawRectangle(XPens.Black, xStart, y, columnWidth, rowHeight);
                    xStart += columnWidth;
                }

                y += rowHeight;

                // Yeni səhifəyə keç
                if (y > page.Height - 40)
                {
                    page = doc.AddPage();
                    gfx = XGraphics.FromPdfPage(page);
                    y = 20;
                }
            }

            // ✔️ Faylı yadda saxla (yalnız 1 dəfə)
            doc.Save(filePath);
        }
    }

    public Dictionary<string, string> GetHeaderFieldMap(string prefix)
    {
        string raw = GetSettingValue("PDF_EXPORT", $"{prefix}_PDF_HEADER_FIELDS");
        return ParseMap(raw);
    }

    private string GetSettingValue(string section, string code)
    {
        return settings.FirstOrDefault(s => s.Section == section && s.Code == code)?.Value;
    }

    private Dictionary<string, string> ParseMap(string raw)
    {
        var result = new Dictionary<string, string>();
        if (string.IsNullOrWhiteSpace(raw)) return result;

        var pairs = raw.Split(',');
        foreach (var pair in pairs)
        {
            var kv = pair.Split('=');
            if (kv.Length == 2)
                result[kv[0].Trim()] = kv[1].Trim();
        }
        return result;
    }
}
