using System.ComponentModel;

namespace WinFormsAppTvary
{
    public partial class FormTvary : Form
    {
        private BindingList<Tvar> tvary = new BindingList<Tvar>();
        public FormTvary()
        {
            InitializeComponent();
            listBoxTvary.DataSource = tvary;
        }
        protected int sirka;
        protected int vyska;
        protected int x;
        protected int y;
        protected Color farba;

        private Tvar VybranyTvar()
        {
            return listBoxTvary.SelectedItem as Tvar;
        }
        private void buttonBarva_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panelBarva.BackColor = colorDialog.Color;
            }
        }

        private void pictureBoxCanvas_Paint(object sender, PaintEventArgs e)
        {
            foreach (Tvar tvar in tvary)
            {
                tvar.NakreslitGUI(e.Graphics);
            }
        }

        private void buttonObdelnik_Click(object sender, EventArgs e)
        {
            x = (int)numericUpDownPoziceX.Value;
            y = (int)numericUpDownPoziceY.Value;
            sirka = (int)numericUpDownSirka.Value;
            vyska = (int)numericUpDownVyska.Value;
            farba = (Color)panelBarva.BackColor;
            Obdlznik o = new Obdlznik(sirka, vyska, x, y, farba);
            tvary.Add(o);
            pictureBoxCanvas.Invalidate();
        }

        private void buttonCtverec_Click(object sender, EventArgs e)
        {
            x = (int)numericUpDownPoziceX.Value;
            y = (int)numericUpDownPoziceY.Value;
            sirka = (int)numericUpDownSirka.Value;
            vyska = (int)numericUpDownVyska.Value;
            farba = (Color)panelBarva.BackColor;
            Ctvorec c = new Ctvorec(sirka, x, y, farba);
            tvary.Add(c);
            pictureBoxCanvas.Invalidate();
        }

        private void buttonKruh_Click(object sender, EventArgs e)
        {
            x = (int)numericUpDownPoziceX.Value;
            y = (int)numericUpDownPoziceY.Value;
            sirka = (int)numericUpDownSirka.Value;
            vyska = (int)numericUpDownVyska.Value;
            farba = (Color)panelBarva.BackColor;
            Kruh k = new Kruh(sirka, x, y, farba);
            tvary.Add(k);
            pictureBoxCanvas.Invalidate();
        }

        private void buttonZvetsit_Click(object sender, EventArgs e)
        {
            Tvar tvar = VybranyTvar();
            if (tvar != null)
            {
                tvar.Zvetsit();
                pictureBoxCanvas.Invalidate();
            }
        }

        private void buttonZmensit_Click(object sender, EventArgs e)
        {
            Tvar tvar = VybranyTvar();
            if (tvar != null)
            {
                tvar.Zmensit();
                pictureBoxCanvas.Invalidate();
            }
        }

        private void buttonSipkaNavrch_Click(object sender, EventArgs e)
        {
            Tvar tvar = VybranyTvar();
            if (tvar != null)
            {
                tvar.Hore();
                pictureBoxCanvas.Invalidate();
            }
        }
        private void buttonSipkaDolu_Click(object sender, EventArgs e)
        {
            Tvar tvar = VybranyTvar();
            if (tvar != null)
            {
                tvar.Dole();
                pictureBoxCanvas.Invalidate();
            }
        }
        private void buttonSipkaDoleva_Click(object sender, EventArgs e)
        {
            Tvar tvar = VybranyTvar();
            if (tvar != null)
            {
                tvar.Dolava();
                pictureBoxCanvas.Invalidate();
            }
        }

        private void buttonSipkaDoprava_Click(object sender, EventArgs e)
        {
            Tvar tvar = VybranyTvar();
            if (tvar != null)
            {
                tvar.Doprava();
                pictureBoxCanvas.Invalidate();
            }
        }

        private void buttonVypocitejObvod_Click(object sender, EventArgs e)
        {
            Tvar tvar = VybranyTvar();
            if (tvar != null)
            {
                textBox1.Text = tvar.VypocitatObvod().ToString();
            }
        }

        private void buttonVypocitejObsah_Click(object sender, EventArgs e)
        {
            Tvar tvar = VybranyTvar();
            if (tvar != null)
            {
                textBox2.Text = tvar.VypocitatObsah().ToString();
            }
        }
    }
}
