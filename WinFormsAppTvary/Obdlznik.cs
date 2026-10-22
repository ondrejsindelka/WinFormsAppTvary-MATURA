using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppTvary
{
    public class Obdlznik : Tvar
    {
        public Obdlznik(): base() { }
        public Obdlznik(int sirka, int vyska): base(sirka, vyska) { }
        public Obdlznik(int sirka, int vyska, int x, int y, Color farba) : base(sirka, vyska, x, y, farba) { }

        public override void Nakreslit()
        {
            for (int i = 0; i < vyska; i++)
            {
                for (int j = 0; j < sirka; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public override void NakreslitGUI(Graphics papier)
        {
            SolidBrush stetec = new SolidBrush(farba);
            papier.FillRectangle(stetec, x, y, sirka, vyska);
            stetec.Dispose();
        }

        public override double VypocitatObsah()
        {
            return sirka * vyska;
        }

        public override double VypocitatObvod()
        {
            return 2*(sirka + vyska);
        }
        public override string ToString()
        {
            return "Obdelnik, vyska = " + this.vyska + " sirka = " + this.sirka + " farba = " + farba.ToKnownColor();
        }
    }
}
