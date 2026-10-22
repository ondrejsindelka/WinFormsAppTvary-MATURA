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
    }
}
