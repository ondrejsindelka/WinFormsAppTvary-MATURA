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
            throw new NotImplementedException();
        }

        public override void NakreslitGUI(Graphics papier)
        {
            throw new NotImplementedException();
        }

        public override double VypocitatObsah()
        {
            throw new NotImplementedException();
        }

        public override double VypocitatObvod()
        {
            throw new NotImplementedException();
        }
    }
}
