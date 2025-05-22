using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_BACK_OFFICE
{
    public class CustomMenuRenderer : ToolStripProfessionalRenderer
    {
        public CustomMenuRenderer() : base(new CustomColorTable()) { }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                // Hover zamanı fon və border
                using (SolidBrush b = new SolidBrush(Color.LightSkyBlue))
                    e.Graphics.FillRectangle(b, e.Item.ContentRectangle);

                using (Pen p = new Pen(Color.SteelBlue, 2))
                    e.Graphics.DrawRectangle(p, new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1));
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }
    }

    public class CustomColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected => Color.LightSkyBlue;
        public override Color MenuItemBorder => Color.SteelBlue;
        public override Color ToolStripDropDownBackground => Color.WhiteSmoke;
    }

}
