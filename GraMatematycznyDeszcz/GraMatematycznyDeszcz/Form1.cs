#define My_Debug
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraMatematycznyDeszcz
{
    public partial class GameForm : Form
    {
        int cursX = 0;
        int cursY = 0;
        int speed = 15;
        int wynik = 0;
        int timeTick = 0;
        bool begin = true;
        bool begin2 = true;
        bool begin3 = true;
        Random rand = new Random();
        PictureBox raindrop = new PictureBox();
        
        public GameForm()
        {
            InitializeComponent();
            reset();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
    
      
      
        private void timerLoop_Tick(object sender, EventArgs e)
        {
            score.Text = "Wynik " + wynik;
            raindropFall();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
#if My_Debug
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.EndEllipsis;
            Font font = new Font("Stencil",12,FontStyle.Regular);
            TextRenderer.DrawText(dc,"X=" + cursX.ToString() + ":" + "Y=" + cursY.ToString(),font, new Rectangle(0,0,120,20), SystemColors.ControlText, flags);
#endif
        //    kropla.DrawImage(dc);
            base.OnPaint(e);
        }
        
        private void GameForm_MouseMove(object sender, MouseEventArgs e)
        {
            cursX = e.X;
            cursY = e.Y;

            this.Refresh();
        }

        private void reset()
        {
                speed = 15;
                timerLoop.Start();
        }
        private void raindropFall()
        {
            
            /*   int random_start = rand.Next(1, 3);
               switch (random_start)
               {
                   case 1: kropla1.fallDown(go1, speed, kropla1.Location.X); break;
                   case 2: kropla2.fallDown(go2, speed, kropla1.Location.X); break;
                   case 3: kropla3.fallDown(go3, speed, kropla1.Location.X); break;

               }*/
            if (begin)
            {
                kropla1.fallDown(speed);
                begin = false;
            }
           //ruch kropli w kolumnie pierwszej
           if(kropla4.Visible == false && kropla1.Top > 140)
            {
                kropla4.fallDown(speed);
            }
            else if (kropla4.Visible == true)
            {
                kropla4.fallDown(speed);
            }
            if(kropla1.Visible == false && kropla4.Top > 140)
            {
                kropla1.fallDown(speed);
            }
            else if (kropla1.Visible == true)
            {
                kropla1.fallDown(speed);
            }
            if(kropla1.Top > 400)
            {
                kropla1.resetRaindrop(kropla1.Location.X);
            }
            if(kropla4.Top > 400)
            {
                kropla4.resetRaindrop(kropla4.Location.X);
            }
            timeTick += 500;
            //ruch kropli w kolumnie drugiej
            if(timeTick > 4000 && begin2)
            {
                kropla2.fallDown(speed);
                begin2 = false;
            }
            if (kropla2.Visible == false && kropla5.Top > 140)
            {
                kropla2.fallDown(speed);
            }
            else if (kropla2.Visible == true)
            {
                kropla2.fallDown(speed);
            }
            if (kropla5.Visible == false && kropla2.Top > 140)
            {
                kropla5.fallDown(speed);
            }
            else if (kropla5.Visible == true)
            {
                kropla5.fallDown(speed);
            }
            if (kropla5.Top > 400)
            {
                kropla5.resetRaindrop(kropla5.Location.X);
            }
            if (kropla2.Top > 400)
            {
                kropla2.resetRaindrop(kropla2.Location.X);
            }
            //ruch kropli w kolumnie trzeciej
            if (timeTick > 7000 && begin3)
            {
                kropla3.fallDown(speed);
                begin3 = false;
            }
            if (kropla3.Visible == false && kropla6.Top > 140)
            {
                kropla3.fallDown(speed);
            }
            else if (kropla3.Visible == true)
            {
                kropla3.fallDown(speed);
            }
            if (kropla6.Visible == false && kropla3.Top > 140)
            {
                kropla6.fallDown(speed);
            }
            else if (kropla6.Visible == true)
            {
                kropla6.fallDown(speed);
            }
            if (kropla6.Top > 400)
            {
                kropla6.resetRaindrop(kropla6.Location.X);
            }
            if (kropla3.Top > 400)
            {
                kropla3.resetRaindrop(kropla3.Location.X);
            }



            /*     if (timeTick > 4000)
                 {
                     kropla2.fallDown(speed);
                     if (kropla2.Top > 250)
                     {
                         kropla5.fallDown(speed);
                     }
                 }
              */
        }
    }
}
