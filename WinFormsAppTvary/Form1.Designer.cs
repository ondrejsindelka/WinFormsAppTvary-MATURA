namespace WinFormsAppTvary
{
    partial class FormTvary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            colorDialog = new ColorDialog();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDownPoziceX = new NumericUpDown();
            numericUpDownPoziceY = new NumericUpDown();
            numericUpDownSirka = new NumericUpDown();
            numericUpDownVyska = new NumericUpDown();
            groupBoxOvladani = new GroupBox();
            buttonZmensit = new Button();
            buttonZvetsit = new Button();
            buttonSipkaDolu = new Button();
            buttonSipkaDoprava = new Button();
            buttonSipkaDoleva = new Button();
            buttonSipkaNavrch = new Button();
            listBoxTvary = new ListBox();
            buttonBarva = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonVypocitejObvod = new Button();
            buttonVypocitejObsah = new Button();
            buttonObdelnik = new Button();
            buttonCtverec = new Button();
            buttonKruh = new Button();
            panelBarva = new Panel();
            pictureBoxCanvas = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPoziceX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPoziceY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSirka).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVyska).BeginInit();
            groupBoxOvladani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCanvas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 70);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 0;
            label1.Text = "Pozice Y";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 1);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 0;
            label2.Text = "Pozice X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 1);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 0;
            label3.Text = "Šířka";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 70);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 28);
            label4.TabIndex = 0;
            label4.Text = "Výška";
            // 
            // numericUpDownPoziceX
            // 
            numericUpDownPoziceX.Location = new Point(11, 27);
            numericUpDownPoziceX.Margin = new Padding(5, 6, 5, 6);
            numericUpDownPoziceX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPoziceX.Name = "numericUpDownPoziceX";
            numericUpDownPoziceX.Size = new Size(139, 34);
            numericUpDownPoziceX.TabIndex = 1;
            numericUpDownPoziceX.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numericUpDownPoziceY
            // 
            numericUpDownPoziceY.Location = new Point(11, 104);
            numericUpDownPoziceY.Margin = new Padding(5, 6, 5, 6);
            numericUpDownPoziceY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPoziceY.Name = "numericUpDownPoziceY";
            numericUpDownPoziceY.Size = new Size(139, 34);
            numericUpDownPoziceY.TabIndex = 1;
            numericUpDownPoziceY.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numericUpDownSirka
            // 
            numericUpDownSirka.Location = new Point(208, 27);
            numericUpDownSirka.Margin = new Padding(5, 6, 5, 6);
            numericUpDownSirka.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numericUpDownSirka.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownSirka.Name = "numericUpDownSirka";
            numericUpDownSirka.Size = new Size(139, 34);
            numericUpDownSirka.TabIndex = 1;
            numericUpDownSirka.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numericUpDownVyska
            // 
            numericUpDownVyska.Location = new Point(208, 104);
            numericUpDownVyska.Margin = new Padding(5, 6, 5, 6);
            numericUpDownVyska.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numericUpDownVyska.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownVyska.Name = "numericUpDownVyska";
            numericUpDownVyska.Size = new Size(139, 34);
            numericUpDownVyska.TabIndex = 1;
            numericUpDownVyska.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // groupBoxOvladani
            // 
            groupBoxOvladani.Controls.Add(buttonZmensit);
            groupBoxOvladani.Controls.Add(buttonZvetsit);
            groupBoxOvladani.Controls.Add(buttonSipkaDolu);
            groupBoxOvladani.Controls.Add(buttonSipkaDoprava);
            groupBoxOvladani.Controls.Add(buttonSipkaDoleva);
            groupBoxOvladani.Controls.Add(buttonSipkaNavrch);
            groupBoxOvladani.Location = new Point(12, 315);
            groupBoxOvladani.Name = "groupBoxOvladani";
            groupBoxOvladani.Size = new Size(349, 163);
            groupBoxOvladani.TabIndex = 2;
            groupBoxOvladani.TabStop = false;
            groupBoxOvladani.Text = "Ovládání";
            // 
            // buttonZmensit
            // 
            buttonZmensit.Location = new Point(215, 82);
            buttonZmensit.Name = "buttonZmensit";
            buttonZmensit.Size = new Size(120, 35);
            buttonZmensit.TabIndex = 2;
            buttonZmensit.Text = "Zmenšit -";
            buttonZmensit.UseVisualStyleBackColor = true;
            // 
            // buttonZvetsit
            // 
            buttonZvetsit.Location = new Point(215, 33);
            buttonZvetsit.Name = "buttonZvetsit";
            buttonZvetsit.Size = new Size(120, 36);
            buttonZvetsit.TabIndex = 1;
            buttonZvetsit.Text = "Zvětšit +";
            buttonZvetsit.UseVisualStyleBackColor = true;
            // 
            // buttonSipkaDolu
            // 
            buttonSipkaDolu.Location = new Point(48, 117);
            buttonSipkaDolu.Name = "buttonSipkaDolu";
            buttonSipkaDolu.Size = new Size(101, 36);
            buttonSipkaDolu.TabIndex = 0;
            buttonSipkaDolu.Text = "↓";
            buttonSipkaDolu.UseVisualStyleBackColor = true;
            // 
            // buttonSipkaDoprava
            // 
            buttonSipkaDoprava.Location = new Point(99, 75);
            buttonSipkaDoprava.Name = "buttonSipkaDoprava";
            buttonSipkaDoprava.Size = new Size(74, 36);
            buttonSipkaDoprava.TabIndex = 0;
            buttonSipkaDoprava.Text = "→";
            buttonSipkaDoprava.UseVisualStyleBackColor = true;
            // 
            // buttonSipkaDoleva
            // 
            buttonSipkaDoleva.Location = new Point(18, 75);
            buttonSipkaDoleva.Name = "buttonSipkaDoleva";
            buttonSipkaDoleva.Size = new Size(75, 36);
            buttonSipkaDoleva.TabIndex = 0;
            buttonSipkaDoleva.Text = "←";
            buttonSipkaDoleva.UseVisualStyleBackColor = true;
            // 
            // buttonSipkaNavrch
            // 
            buttonSipkaNavrch.Location = new Point(48, 33);
            buttonSipkaNavrch.Name = "buttonSipkaNavrch";
            buttonSipkaNavrch.Size = new Size(101, 36);
            buttonSipkaNavrch.TabIndex = 0;
            buttonSipkaNavrch.Text = "↑";
            buttonSipkaNavrch.UseVisualStyleBackColor = true;
            // 
            // listBoxTvary
            // 
            listBoxTvary.FormattingEnabled = true;
            listBoxTvary.Location = new Point(10, 484);
            listBoxTvary.Name = "listBoxTvary";
            listBoxTvary.Size = new Size(349, 88);
            listBoxTvary.TabIndex = 3;
            // 
            // buttonBarva
            // 
            buttonBarva.BackColor = SystemColors.WindowText;
            buttonBarva.ForeColor = SystemColors.Window;
            buttonBarva.Location = new Point(8, 165);
            buttonBarva.Name = "buttonBarva";
            buttonBarva.Size = new Size(111, 44);
            buttonBarva.TabIndex = 4;
            buttonBarva.Text = "Barva";
            buttonBarva.UseVisualStyleBackColor = false;
            buttonBarva.Click += buttonBarva_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 578);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 34);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 633);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 34);
            textBox2.TabIndex = 6;
            // 
            // buttonVypocitejObvod
            // 
            buttonVypocitejObvod.Location = new Point(8, 578);
            buttonVypocitejObvod.Name = "buttonVypocitejObvod";
            buttonVypocitejObvod.Size = new Size(168, 34);
            buttonVypocitejObvod.TabIndex = 7;
            buttonVypocitejObvod.Text = "Vypočítej obvod";
            buttonVypocitejObvod.UseVisualStyleBackColor = true;
            // 
            // buttonVypocitejObsah
            // 
            buttonVypocitejObsah.Location = new Point(8, 633);
            buttonVypocitejObsah.Name = "buttonVypocitejObsah";
            buttonVypocitejObsah.Size = new Size(168, 34);
            buttonVypocitejObsah.TabIndex = 8;
            buttonVypocitejObsah.Text = "Vypočítej obsah";
            buttonVypocitejObsah.UseVisualStyleBackColor = true;
            // 
            // buttonObdelnik
            // 
            buttonObdelnik.BackColor = Color.LimeGreen;
            buttonObdelnik.ForeColor = SystemColors.Window;
            buttonObdelnik.Location = new Point(208, 165);
            buttonObdelnik.Name = "buttonObdelnik";
            buttonObdelnik.Size = new Size(139, 44);
            buttonObdelnik.TabIndex = 9;
            buttonObdelnik.Text = "Obdélník";
            buttonObdelnik.UseVisualStyleBackColor = false;
            buttonObdelnik.Click += buttonObdelnik_Click;
            // 
            // buttonCtverec
            // 
            buttonCtverec.BackColor = Color.DarkOrange;
            buttonCtverec.ForeColor = SystemColors.Window;
            buttonCtverec.Location = new Point(208, 215);
            buttonCtverec.Name = "buttonCtverec";
            buttonCtverec.Size = new Size(139, 44);
            buttonCtverec.TabIndex = 9;
            buttonCtverec.Text = "Čtverec";
            buttonCtverec.UseVisualStyleBackColor = false;
            buttonCtverec.Click += buttonCtverec_Click;
            // 
            // buttonKruh
            // 
            buttonKruh.BackColor = Color.OrangeRed;
            buttonKruh.ForeColor = SystemColors.Window;
            buttonKruh.Location = new Point(210, 265);
            buttonKruh.Name = "buttonKruh";
            buttonKruh.Size = new Size(137, 44);
            buttonKruh.TabIndex = 9;
            buttonKruh.Text = "Kruh";
            buttonKruh.UseVisualStyleBackColor = false;
            buttonKruh.Click += buttonKruh_Click;
            // 
            // panelBarva
            // 
            panelBarva.BackColor = SystemColors.MenuHighlight;
            panelBarva.Location = new Point(134, 167);
            panelBarva.Name = "panelBarva";
            panelBarva.Size = new Size(42, 42);
            panelBarva.TabIndex = 10;
            // 
            // pictureBoxCanvas
            // 
            pictureBoxCanvas.BackColor = SystemColors.Window;
            pictureBoxCanvas.Location = new Point(371, 11);
            pictureBoxCanvas.Name = "pictureBoxCanvas";
            pictureBoxCanvas.Size = new Size(738, 657);
            pictureBoxCanvas.TabIndex = 11;
            pictureBoxCanvas.TabStop = false;
            pictureBoxCanvas.Paint += pictureBoxCanvas_Paint;
            // 
            // FormTvary
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 680);
            Controls.Add(pictureBoxCanvas);
            Controls.Add(panelBarva);
            Controls.Add(buttonKruh);
            Controls.Add(buttonCtverec);
            Controls.Add(buttonObdelnik);
            Controls.Add(buttonVypocitejObsah);
            Controls.Add(buttonVypocitejObvod);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonBarva);
            Controls.Add(listBoxTvary);
            Controls.Add(groupBoxOvladani);
            Controls.Add(numericUpDownVyska);
            Controls.Add(numericUpDownPoziceY);
            Controls.Add(numericUpDownSirka);
            Controls.Add(numericUpDownPoziceX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormTvary";
            Text = "Tvary";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPoziceX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPoziceY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSirka).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVyska).EndInit();
            groupBoxOvladani.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDownPoziceX;
        private NumericUpDown numericUpDownPoziceY;
        private NumericUpDown numericUpDownSirka;
        private NumericUpDown numericUpDownVyska;
        private GroupBox groupBoxOvladani;
        private ListBox listBoxTvary;
        private Button buttonBarva;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonVypocitejObvod;
        private Button buttonZmensit;
        private Button buttonZvetsit;
        private Button buttonSipkaDolu;
        private Button buttonSipkaDoprava;
        private Button buttonSipkaDoleva;
        private Button buttonSipkaNavrch;
        private Button buttonVypocitejObsah;
        private Button buttonObdelnik;
        private Button buttonCtverec;
        private Button buttonKruh;
        private Panel panelBarva;
        private PictureBox pictureBoxCanvas;
    }
}
