using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsAppTvary
{
    public class Ctvorec : Obdlznik
    {
        public Ctvorec() : base() { }
        public Ctvorec(int sirka) : base(sirka, sirka) { }
        public Ctvorec(int sirka, int x, int y, Color farba) : base(sirka, sirka, x, y, farba) { }


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
            return "Ctverec, strana = " + this.sirka + " farba= "+farba;
        }
    }
}
