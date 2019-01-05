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
    /// <summary>
    /// Klasa głównego okna gry
    /// </summary>
    public partial class GameForm : Form
    {
        /// <summary>
        /// prędkość kropli
        /// </summary>
        int speed = 20;
        /// <summary>
        /// bieżący wynik gry
        /// </summary>
        int gameScore = 0;
        /// <summary>
        /// końcowy wynik gry
        /// </summary>
        public static int finalGameScore = 0;
        /// <summary>
        /// zmienna pomocnicza (generacja kropel)
        /// </summary>
        int timeTick = 0;
        /// <summary>
        /// zmienna zliczająca krople, które spadły na ziemię
        /// </summary>
        int raindropFail = 0;
        /// <summary>
        /// minimalna wysokość na jakiej może znaleźć się kropla
        /// </summary>
        int minHeight = 400;
        /// <summary>
        /// zmienna kontrolująca pojawianie się owada
        /// </summary>
        int bugTimer = 0;
        /// <summary>
        /// zmienne pomagające w algorytmie "przypadkowego" pojawiania się kropel
        /// </summary>
        bool begin = true;
        bool begin2 = true;
        bool begin3 = true;
        bool randomBegin = false;
        bool randomBegin2 = false;
        bool randomBegin3 = false;
        /// <summary>
        /// zmienna poziomu gry (jeśli true to znaczy, że poziom jeszcze nie został zmieniony)
        /// </summary>
        bool level2 = true;
        /// <summary>
        /// lista wyników równań, które aktualnie widoczne są na ekranie (kropli)
        /// </summary>
        List<Equation> currentResults = new List<Equation>();
        /// <summary>
        /// lista wszystkich kropli
        /// </summary>
        List<Kropla> raindropList = new List<Kropla>();
        Random rand = new Random();
       /// <summary>
       /// Konstruktor głównej formy (okienka gry)
       /// </summary>
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
            if (gameScore >= 8 && level2)
            {
                changeLevel(2);
            }

            if (gameScore > 10 && bug.Visible == false)
            {
                bugTimer += 500;
                if(bugTimer % 18000 == 0)
                {
                    int bugX =  rand.Next(0, 400);
                    int bugY = rand.Next(0, 80);
                    bugAppear(bugX, bugY);
                }
            }
            waterLevel(raindropFail);
            if(raindropFail > 5)
            {
                endGame();
            }
        }
        /// <summary>
        /// Metoda odpowiedzialna za przemieszczanie kropli po ekranie
        /// </summary>
        private void raindropFall()
        {
            timeTick += 500;
            if (timeTick > 40000)
            { // w celu zwiększenia ilości kropel widocznych na ekranie, co jakiś czas restartowane są zmienne begin, rozpoczynające ruch kropli w kolumnach 1, 2 i 3
                timeTick = 3000;
                begin = true;
                begin2 = true;
                begin3 = true;
            }
            if ((timeTick > 11000 && begin) || randomBegin)
            { // rozpoczęcie opadania kropli w pierwszej kolumnie (zawsze rozpoczyna się od kropli 1)
                kropla1.fallDown(speed);
                createEquation(equation1);
                begin = false;
                randomBegin = false;
            }
            //ruch kropli 1 i 4 w kolumnie pierwszej
            if (kropla4.Visible == false && kropla1.Top > 140) 
            {   //pojawienie się kropli 4 i generacja nowego równania, tylko w przypadku gdy kropli 4 nie ma na ekranie oraz kropla 1 jest w wystarczająco nisko (krople nie mogą na siebie nachodzić)
                kropla4.fallDown(speed);
                createEquation(equation4);
            }
            else if (kropla4.Visible == true)
            { //jeżeli kropla widoczna jest na ekranie to ma cały czas opadać
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
            {   //jeśli kropla opadnie poniżej minimalnej wysokości to wraca z powrotem na górę ekranu, równanie usuwane jest z listy i doliczany jest punkt straty
                kropla4.resetRaindrop(kropla4.Location.X);
                currentResults.Remove(equation4);
                raindropFail += 1;
            }
            //ruch kropli 2 i 5 w kolumnie drugiej
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
            //ruch kropli 3 i 6 w kolumnie trzeciej
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
                    { // w przypadku braku kropel na ekranie losowana jest kropla, która jako pierwsza pojawi się ponownie na ekranie
                        int random_start = rand.Next(1, 3);
                        switch (random_start)
                        {
                            case 1: randomBegin = true; break;
                            case 2: randomBegin2 = true; break;
                            case 3: randomBegin3 = true; break;

                        }
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
            { //losowanie kropli która jako pierwsza pojawi się na ekranie (z kolumny 1, 2 albo 3)
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
            resetGame();
        }
        /// <summary>
        /// Metoda odpowiedzialna za podnoszenie poziomu wody.
        /// </summary>
        /// <param name="raindropFail">Parametr określający liczbę nieodgadniętych wyników podczas gry</param>
        private void waterLevel(int raindropFail)
        {
            if (raindropFail == 1)
            {
                waterPanel.Location = new Point(-9, 308);
            }
            else if (raindropFail == 3)
            {
                waterPanel.Location = new Point(-9, 258);
                minHeight = 380;
            }
            else if (raindropFail == 5)
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
        /// <summary>
        /// Metoda odpowiedzialna za pojawianie się owada na ekranie
        /// </summary>
        /// <param name="x">Współrzędna x owada</param>
        /// <param name="y">Współrzędna y owada</param>
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
        /// <summary>
        /// Metoda zmieniająca poziom gry
        /// </summary>
        /// <param name="lvl">Cyfra reprezentująca poziom gry</param>
        private void changeLevel(int lvl)
        {
            equation1.level = lvl;
            equation2.level = lvl;
            equation3.level = lvl;
            equation4.level = lvl;
            equation5.level = lvl;
            equation6.level = lvl;
        }
        /// <summary>
        /// Metoda generująca równanie
        /// </summary>
        /// <param name="eq">Parametr określający które równanie (na której kropli) ma zostać wygenerowane</param>
        private void createEquation(Equation eq)
        {
            eq.noweRownanie();
            eq.Text = eq.liczba1.ToString() + eq.znak.ToString() + eq.liczba2.ToString();
            currentResults.Add(eq);
        }
        /// <summary>
        /// Metoda kończąca partię gry.
        /// </summary>
        private void endGame()
        {
            finalGameScore = gameScore;
            resetGame();
            Form2 form = new Form2();
            form.Show();
        }
        /// <summary>
        /// Metoda resetująca ustawienia gry.
        /// </summary>
        public void resetGame()
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
        
    }
}
