using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraMatematycznyDeszcz
{
    /// <summary>
    /// Klasa odpowiedzialna za równania 
    /// </summary>
    class Equation : Label
    {
        /// <summary>
        /// Znak równania
        /// </summary>
        public char znak;
        /// <summary>
        /// Wynik równania
        /// </summary>
        public double wynik;
        /// <summary>
        /// Pierwsza liczba równania
        /// </summary>
        public double liczba1;
        /// <summary>
        /// Druga liczba równania
        /// </summary>
        public double liczba2;
        /// <summary>
        /// Losowa liczba
        /// </summary>
        private static Random r;
        /// <summary>
        /// Zmienna poziomu gry
        /// </summary>
        public int level;
        /// <summary>
        /// Konstruktor klasy Equation
        /// </summary>
        public Equation()
        {
        }
        /// <summary>
        /// metoda generująca nowe randomowe równanie
        /// </summary>
        public void noweRownanie()
        {
            r = new Random();
            int losujZnak;
            switch (level)
            {
                case 1:
                    {
                        liczba1 = r.Next(0, 10);
                        liczba2 = r.Next(0, 10);
                    }
                    break;
                case 2:
                    {
                        liczba1 = r.Next(0, 100);
                        liczba2 = r.Next(0, 10);
                    }
                    break;
            }
          

            //warunek zapewniający, że nie dzielimy przez 0
            if (liczba2 != 0)
            {
                losujZnak = r.Next(1, 5);
            }
            else losujZnak = r.Next(1, 4);
            //wynik dzielenia może być tylko liczbą całkowitą
            if (losujZnak == 4)
            {
                do { liczba2 = r.Next(0, 10); } while (liczba1 % liczba2 != 0);
            }

            switch (losujZnak)
            {
                case 1: znak = '+'; break;
                case 2: znak = '-'; break;
                case 3: znak = '*'; break;
                case 4: znak = '/'; break;
            }
            switch (znak)
            {
                case '+': wynik = add(liczba1, liczba2); break;
                case '-': wynik = substract(liczba1, liczba2); break;
                case '*': wynik = multiply(liczba1, liczba2); break;
                case '/': wynik = divide(liczba1, liczba2); break;
            }
        }

        private double add(double l1, double l2)
        {
            return l1 + l2;
        }
        private double substract(double l1, double l2)
        {
            return l1 - l2;
        }
        private double multiply(double l1, double l2)
        {
            return l1 * l2;
        }
        private double divide(double l1, double l2)
        {
            return l1 / l2;
        }
    }
}
