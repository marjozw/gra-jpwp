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
    /// <summary>
    /// Klasa obsługująca kroplę
    /// </summary>
    public class Kropla : Panel
    {

        private void CustomPanel_Resize(object sender, EventArgs e)
        {
            if (this.Visible) this.Refresh();
        }
        /// <summary>
        /// Konstruktor klasy Kropla
        /// </summary>
        public Kropla()
        {
        }
        /// <summary>
        /// metoda sterująca spadaniem kropli
        /// </summary>
        /// <param name="speed"></param>
        public void fallDown(int speed)
        {
            this.Visible = true;
            this.Top += speed;
        }
        /// <summary>
        /// metoda powodująca powrót kropli do pozycji początkowej u góry strony
        /// </summary>
        /// /// <param name="x"></param>
        public void resetRaindrop(int x)
        {
            this.Visible = false;
            this.Location = new Point(x, -150);
        }
    }
}
