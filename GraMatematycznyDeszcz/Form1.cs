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
        int speed = 20;
        int gameScore = 0;
        int timeTick = 0;
        int raindropFail = 0;
        int minHeight = 400;
        int bugTimer = 0;
        bool begin = true;
        bool begin2 = true;
        bool begin3 = true;
        bool randomBegin = false;
        bool randomBegin2 = false;
        bool randomBegin3 = false;
        bool level2 = true;
        List<Equation> currentResults = new List<Equation>();
        List<Kropla> raindropList = new List<Kropla>();
        Random rand = new Random();

        public GameForm()
        {
            InitializeComponent();
            equation1.Parent = pictureBox1;
            equation1.BackColor = Color.Transparent;
            equation2.Parent = pictureBox2;
            equation2.BackColor = Color.Transparent;
            equation3.Parent = pictureBox3;
            equation3.BackColor = Color.Transparent;
            equation4.Parent = pictureBox4;
            equation4.BackColor = Color.Transparent;
            equation5.Parent = pictureBox5;
            equation5.BackColor = Color.Transparent;
            equation6.Parent = pictureBox6;
            equation6.BackColor = Color.Transparent;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        private void timerLoop_Tick(object sender, EventArgs e)
        {
            score.Text = "Wynik " + gameScore;
            raindropFall();
            if (gameScore >= 2 && level2)
            {
                changeLevel(2);
            }
            if (gameScore > 6 && bug.Visible == false)
            {
                bugTimer += 500;
                if(bugTimer % 10000 == 0)
                {
                    int bugX =  rand.Next(0, 400);
                    int bugY = rand.Next(0, 18);
                    bugAppear(bugX, bugY);
                }
            }
            waterLevel(raindropFail);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
#if My_Debug
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.EndEllipsis;
            Font font = new Font("Stencil", 12, FontStyle.Regular);
            TextRenderer.DrawText(dc, "X=" + cursX.ToString() + ":" + "Y=" + cursY.ToString(), font, new Rectangle(0, 0, 120, 20), SystemColors.ControlText, flags);
#endif
            base.OnPaint(e);
        }

        private void GameForm_MouseMove(object sender, MouseEventArgs e)
        {
            cursX = e.X;
            cursY = e.Y;

            this.Refresh();
        }

        private void raindropFall()
        {
            timeTick += 500;
            if (timeTick > 40000)
            {
                timeTick = 3000;
                begin = true;
                begin2 = true;
                begin3 = true;
            }
            if ((timeTick > 11000 && begin) || randomBegin)
            {
                kropla1.fallDown(speed);
                createEquation(equation1);
                begin = false;
                randomBegin = false;
            }
            //ruch kropli w kolumnie pierwszej
            if (kropla4.Visible == false && kropla1.Top > 140)
            {
                kropla4.fallDown(speed);
                createEquation(equation4);
            }
            else if (kropla4.Visible == true)
            {
                kropla4.fallDown(speed);
            }
            if (kropla1.Visible == false && kropla4.Top > 140)
            {
                kropla1.fallDown(speed);
                createEquation(equation1);
            }
            else if (kropla1.Visible == true)
            {
                kropla1.fallDown(speed);
            }
            if (kropla1.Top > minHeight)
            {
                kropla1.resetRaindrop(kropla1.Location.X);
                currentResults.Remove(equation1);
                raindropFail += 1;
            }
            if (kropla4.Top > minHeight)
            {
                kropla4.resetRaindrop(kropla4.Location.X);
                currentResults.Remove(equation4);
                raindropFail += 1;
            }
            //ruch kropli w kolumnie drugiej
            if ((timeTick > 4000 && begin2) || randomBegin2)
            {
                kropla2.fallDown(speed);
                createEquation(equation2);
                begin2 = false;
                randomBegin2 = false;
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
                createEquation(equation5);
            }
            else if (kropla5.Visible == true)
            {
                kropla5.fallDown(speed);
            }
            if (kropla5.Top > minHeight)
            {
                kropla5.resetRaindrop(kropla5.Location.X);
                currentResults.Remove(equation5);
                raindropFail += 1;
            }
            if (kropla2.Top > minHeight)
            {
                kropla2.resetRaindrop(kropla2.Location.X);
                currentResults.Remove(equation2);
                raindropFail += 1;
            }
            //ruch kropli w kolumnie trzeciej
            if ((timeTick > 7000 && begin3) || randomBegin3)
            {
                kropla3.fallDown(speed);
                createEquation(equation3);
                begin3 = false;
                randomBegin3 = false;
            }
            if (kropla3.Visible == false && kropla6.Top > 140)
            {
                kropla3.fallDown(speed);
                createEquation(equation3);
            }
            else if (kropla3.Visible == true)
            {
                kropla3.fallDown(speed);
            }
            if (kropla6.Visible == false && kropla3.Top > 140)
            {
                kropla6.fallDown(speed);
                createEquation(equation6);
            }
            else if (kropla6.Visible == true)
            {
                kropla6.fallDown(speed);
            }
            if (kropla6.Top > minHeight)
            {
                kropla6.resetRaindrop(kropla6.Location.X);
                currentResults.Remove(equation6);
                raindropFail += 1;
            }
            if (kropla3.Top > minHeight)
            {
                kropla3.resetRaindrop(kropla3.Location.X);
                currentResults.Remove(equation3);
                raindropFail += 1;
            }
        }

        private void resultBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                int ok;
                bool parsed = Int32.TryParse(resultBox.Text, out ok);

                if (parsed)
                {
                    List<int> tmpListOfResults = new List<int>(); //tymczasowa lista zapamiętująca id równań do usunięcia z listy wyników
                    foreach (Equation result in currentResults)
                    {
                        if (Int32.Parse(resultBox.Text) == result.wynik)
                        {
                            char id = result.Name[result.Name.Length - 1];
                            string kroplaID = "kropla" + id.ToString();
                            foreach (Kropla raindrop in raindropList)
                            {
                                if (kroplaID == raindrop.Name) //identyfikacja kropli do której należy równanie z wynikiem zgodnym z TextBox
                                {
                                    raindrop.resetRaindrop(raindrop.Location.X); //reset kropli
                                    tmpListOfResults.Add(Int32.Parse(id.ToString())); //zapamiętanie id w celu usunięcia odpowiednich równań z listy currentResults
                                }
                            }
                            gameScore += 1;
                        }
                    }
                    // usunięcie odpowiednich równań z listy
                    foreach (int tmp in tmpListOfResults)
                    {
                        if (currentResults.Count != 0)
                        {
                            if (tmp == 1)
                            {
                                currentResults.Remove(equation1);
                            }
                            else if (tmp == 2)
                            {
                                currentResults.Remove(equation2);
                            }
                            else if (tmp == 3)
                            {
                                currentResults.Remove(equation3);
                            }
                            else if (tmp == 4)
                            {
                                currentResults.Remove(equation4);
                            }
                            else if (tmp == 5)
                            {
                                currentResults.Remove(equation5);
                            }
                            else if (tmp == 6)
                            {
                                currentResults.Remove(equation6);
                            }
                        }
                    }

                    if (currentResults.Count == 0)
                    {
                        int random_start = rand.Next(1, 3);
                        switch (random_start)
                        {
                            case 1: randomBegin = true; break;
                            case 2: randomBegin2 = true; break;
                            case 3: randomBegin3 = true; break;

                        }
                        //  timeTick = 0; 
                    }
                    resultBox.Clear();
                    tmpListOfResults.Clear();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultBox.Focus();
            speed = 15;
            raindropList.Add(kropla1);
            raindropList.Add(kropla2);
            raindropList.Add(kropla3);
            raindropList.Add(kropla4);
            raindropList.Add(kropla5);
            raindropList.Add(kropla6);
            int random_start = rand.Next(1, 3);
            switch (random_start)
            {
                case 1: randomBegin = true; break;
                case 2: randomBegin2 = true; break;
                case 3: randomBegin3 = true; break;
            }
            button1.Enabled = false;
            changeLevel(1);
            timerLoop.Start();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            currentResults.Clear();
            raindropFail = 0;
            minHeight = 400;
            speed = 15;
            gameScore = 0;
            score.Text = "Wynik " + gameScore;
            timeTick = 0;
            waterPanel.Location = new Point(-9, 608);
            begin = true;
            begin2 = true;
            begin3 = true;
            randomBegin = false;
            randomBegin2 = false;
            randomBegin3 = false;
            button1.Enabled = true;
            timerLoop.Stop();
            foreach (Kropla kropla in raindropList)
            {
                kropla.resetRaindrop(kropla.Location.X);
            }
            changeLevel(1);
            raindropList.Clear();
            bug.Visible = false;
        }

        private void waterLevel(int raindropFail)
        {
            if (raindropFail == 1)
            {
                waterPanel.Location = new Point(-9, 308);
            }
            else if (raindropFail == 2)
            {
                waterPanel.Location = new Point(-9, 258);
                minHeight = 380;
            }
            else if (raindropFail == 4)
            {
                waterPanel.Location = new Point(-9, 208);
                minHeight = 325;
            }
        }

        private void bug_Click(object sender, EventArgs e)
        {
            bug.Visible = false;
            resultBox.Enabled = true;
            resultBox.Focus();
        }

        private void bugAppear(int x, int y)
        {
            bug.Location = new Point(x, y);
            bug.Visible = true;
            resultBox.Enabled = false;
        }

        private void GameForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                e.Handled = true;
            }
        }

        private void changeLevel(int lvl)
        {
            equation1.level = lvl;
            equation2.level = lvl;
            equation3.level = lvl;
            equation4.level = lvl;
            equation5.level = lvl;
            equation6.level = lvl;
        }

        private void createEquation(Equation eq)
        {
            eq.noweRownanie();
            eq.Text = eq.liczba1.ToString() + eq.znak.ToString() + eq.liczba2.ToString();
            currentResults.Add(eq);
        }
    }
}
