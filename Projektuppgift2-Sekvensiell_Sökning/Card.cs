using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektuppgift2_Sekvensiell_Sökning
{
    class Card
    {
        public bool visaFramsida = false;
        Image img = Properties.Resources.daimoned2;

        public void Rita(Graphics g, String s, bool visa,int x,int y)
        {
            SolidBrush brush = new SolidBrush(Color.Red);
            SolidBrush brushWhite = new SolidBrush(Color.White);
            if (visa)
            {
                g.FillRectangle(brushWhite, x-30, y - 45, 150, 200);
                Font font = new Font(FontFamily.GenericSansSerif, 12f, FontStyle.Regular);
                g.DrawString(s, font, brush, x -23, y-30);
                g.DrawString(s, font, brush, x + 80, y + 120);
                g.DrawImage(img, new Point(x, y));
                
            }
        }

    }
}
