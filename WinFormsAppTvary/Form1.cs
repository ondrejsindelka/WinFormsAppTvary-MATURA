namespace WinFormsAppTvary
{
    public partial class FormTvary : Form
    {
        public FormTvary()
        {
            InitializeComponent();
        }

        private void buttonBarva_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
               panelBarva.BackColor = colorDialog.Color;
            }
        }
    }
}
