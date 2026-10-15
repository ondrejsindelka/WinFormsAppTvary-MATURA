using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsAppTvary
{
    public class Ctvorec : Tvar
    {
        public Ctvorec() : base() { }
        public Ctvorec(int sirka) : base(sirka) { }
        public Ctvorec(int sirka, int x, int y, Color farba) : base(sirka, sirka, x, y, farba) { }

        public override void Nakreslit()
        {
            for (int i = 0; i < sirka; i++)
            {
                
            }
        }

        public override void NakreslitGUI(Graphics papier)
        {
            throw new NotImplementedException();
        }

        public override double VypocitatObsah()
        {
            return sirka * sirka;
        }

        public override double VypocitatObvod()
        {
            return 4 * sirka;
        }
        public override string ToString()
        {
            return "Zdar ja som ctvorec a som ctvorcovy, ma strana je " + this.sirka + " dlha a moc pekna ";
        }
    }
}
