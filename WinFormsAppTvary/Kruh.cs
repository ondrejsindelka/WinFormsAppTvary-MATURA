using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppTvary
{
    public class Kruh : Tvar
    {
        public Kruh() : base() { }
        public Kruh(int sirka) : base(sirka) { }
        public Kruh(int sirka, int x, int y, Color farba) : base(sirka, sirka, x, y, farba) { }

        public override void Nakreslit()
        {
            Console.WriteLine("Do konzole neni tak lahke nakreslit kruh");
        }
        public override void NakreslitGUI(Graphics papier)
        {
            var pero = new Pen(farba);
            papier.DrawEllipse(pero, x, y, sirka, sirka);
            pero.Dispose();
        }

        public override double VypocitatObsah()
        {
            return Math.PI * Math.Pow((sirka / 2), 2);
        }

        public override double VypocitatObvod()
        {
            return Math.PI * sirka;
        }
        public override string ToString()
        {
            return "Kruh, prumer = " + this.sirka + " farba= " + farba;
        }
    }
}
