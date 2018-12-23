using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraMatematycznyDeszcz
{
    class Equation : Label
    {

        public char znak;
        public double wynik;
        public double liczba1;
        public double liczba2;
        private static Random r;

        public Equation()
        {
        }

        public void noweRownanie()
        {
            r = new Random();
            int losujZnak;
            liczba1 = r.Next(0, 10);
            liczba2 = r.Next(0, 10);

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

        public double add(double l1, double l2)
        {
            return l1 + l2;
        }
        public double substract(double l1, double l2)
        {
            return l1 - l2;
        }
        public double multiply(double l1, double l2)
        {
            return l1 * l2;
        }
        public double divide(double l1, double l2)
        {
            return l1 / l2;
        }
    }
}
