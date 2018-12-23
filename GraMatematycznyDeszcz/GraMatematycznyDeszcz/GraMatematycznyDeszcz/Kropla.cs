using System;
using GraMatematycznyDeszcz.Properties;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GraMatematycznyDeszcz
{
    public class Kropla : Panel
    {

        private void CustomPanel_Resize(object sender, EventArgs e)
        {
            if (this.Visible) this.Refresh();

        }
        public Kropla()
        {
        }
        public void fallDown(int speed)
        {
            this.Visible = true;
            this.Top += speed;
        }
        public void resetRaindrop(int x)
        {
            this.Visible = false;
            this.Location = new Point(x, -150);
        }
        /* private Rectangle kroplaPolozenie = new Rectangle();

public ddropla() : base(Resources.kropla)
{//to do owada
    kroplaPolozenie.X = obrazX + 20;
    kroplaPolozenie.Y = obrazY - 1;
    kroplaPolozenie.Width = 127;
    kroplaPolozenie.Height = 131;
}

public void Update(int x, int y)
{//to do owada
    obrazX = x;
    obrazY = y;
    kroplaPolozenie.X = obrazX + 20;
    kroplaPolozenie.Y = obrazY - 1;
}

public bool Hit(int x, int y)
{
    Rectangle r = new Rectangle(x, y, 1, 1);
    if (kroplaPolozenie.Contains(r))
    {
        return true;
    }

    return false;
}*/
    }
}
