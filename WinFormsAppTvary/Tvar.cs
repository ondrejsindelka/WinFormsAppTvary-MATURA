using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppTvary
{
    public abstract class Tvar
    {
        protected int sirka;
        protected int vyska;
        protected int x;
        protected int y;
        protected Color farba;
        public Tvar()
        {
            this.sirka = 10;
            this.vyska = 10;
            this.x = 0;
            this.y = 0;
            this.farba = Color.Black;
        }
        public Tvar(int sirka)
        {
            this.sirka = sirka;
            this.vyska = sirka;
            this.x = 0;
            this.y = 0;
            this.farba = Color.Black;
        }
        public Tvar(int sirka, int vyska)
        {
            this.sirka = sirka;
            this.vyska = vyska;
            this.x = 0;
            this.y = 0;
            this.farba = Color.Black;
        }
        public Tvar(int sirka, int vyska, int x, int y, Color farba)
        {
            this.sirka = sirka;
            this.vyska = vyska;
            this.x = x;
            this.y = y;
            this.farba = farba;
        }
        public override string ToString()
        {
            return "Som tvar ktory je farebny jakoze "+ this.farba+" a moja vyska a sirka je "+ this.vyska + " " + this.sirka;
        }
        public void Zmensit()
        {
            if (sirka > 10 && vyska > 10)
            {
                sirka /= 2;
                vyska /= 2;
            }
        }
        public void Zvetsit()
        {
            if (sirka < 10000 && vyska < 10000)
            {
                sirka *= 2;
                vyska *= 2;
            }
        }

        public void Dolava()
        {
            x -= 10;
        }
        public void Doprava()
        {
            x += 10;
        }
        public void Hore()
        {
            y -= 10;
        }
        public void Dole()
        {
            y += 10;
        }
        public abstract void Nakreslit();
        public abstract void NakreslitGUI(Graphics papier);
        public abstract double VypocitatObvod();
        public abstract double VypocitatObsah();


    }
}
