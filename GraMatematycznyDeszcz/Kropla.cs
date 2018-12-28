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
    }
}
