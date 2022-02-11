namespace BankaForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_transakce = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_vyberTransakce = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_castka = new System.Windows.Forms.TextBox();
            this.lb_seznamUctu = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.l_kodBanky = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.b_vytvoritUcet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_urok = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_debet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_cisloUctu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_majitel = new System.Windows.Forms.TextBox();
            this.rb_sporici = new System.Windows.Forms.RadioButton();
            this.tb_zustatek = new System.Windows.Forms.TextBox();
            this.rb_debetni = new System.Windows.Forms.RadioButton();
            this.rb_bezny = new System.Windows.Forms.RadioButton();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(874, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_transakce);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cb_vyberTransakce);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_castka);
            this.groupBox2.Controls.Add(this.lb_seznamUctu);
            this.groupBox2.Location = new System.Drawing.Point(393, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 298);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transakce";
            // 
            // b_transakce
            // 
            this.b_transakce.Location = new System.Drawing.Point(261, 45);
            this.b_transakce.Name = "b_transakce";
            this.b_transakce.Size = new System.Drawing.Size(100, 29);
            this.b_transakce.TabIndex = 16;
            this.b_transakce.Text = "Proveď";
            this.b_transakce.UseVisualStyleBackColor = true;
            this.b_transakce.Click += new System.EventHandler(this.b_transakce_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Kč";
            // 
            // cb_vyberTransakce
            // 
            this.cb_vyberTransakce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_vyberTransakce.FormattingEnabled = true;
            this.cb_vyberTransakce.Items.AddRange(new object[] {
            "Připsat úrok",
            "Vložit",
            "Vybrat"});
            this.cb_vyberTransakce.Location = new System.Drawing.Point(15, 19);
            this.cb_vyberTransakce.Name = "cb_vyberTransakce";
            this.cb_vyberTransakce.Size = new System.Drawing.Size(138, 21);
            this.cb_vyberTransakce.TabIndex = 6;
            this.cb_vyberTransakce.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "částka";
            // 
            // tb_castka
            // 
            this.tb_castka.Location = new System.Drawing.Point(261, 19);
            this.tb_castka.Name = "tb_castka";
            this.tb_castka.Size = new System.Drawing.Size(100, 20);
            this.tb_castka.TabIndex = 5;
            // 
            // lb_seznamUctu
            // 
            this.lb_seznamUctu.FormattingEnabled = true;
            this.lb_seznamUctu.Location = new System.Drawing.Point(16, 133);
            this.lb_seznamUctu.Name = "lb_seznamUctu";
            this.lb_seznamUctu.Size = new System.Drawing.Size(432, 147);
            this.lb_seznamUctu.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.l_kodBanky);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.b_vytvoritUcet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_urok);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_debet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_cisloUctu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_majitel);
            this.groupBox1.Controls.Add(this.rb_sporici);
            this.groupBox1.Controls.Add(this.tb_zustatek);
            this.groupBox1.Controls.Add(this.rb_debetni);
            this.groupBox1.Controls.Add(this.rb_bezny);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 298);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nový účet";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Kč";
            // 
            // l_kodBanky
            // 
            this.l_kodBanky.AutoSize = true;
            this.l_kodBanky.Location = new System.Drawing.Point(206, 30);
            this.l_kodBanky.Name = "l_kodBanky";
            this.l_kodBanky.Size = new System.Drawing.Size(36, 13);
            this.l_kodBanky.TabIndex = 16;
            this.l_kodBanky.Text = "/1234";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kč";
            // 
            // b_vytvoritUcet
            // 
            this.b_vytvoritUcet.Location = new System.Drawing.Point(81, 233);
            this.b_vytvoritUcet.Name = "b_vytvoritUcet";
            this.b_vytvoritUcet.Size = new System.Drawing.Size(166, 50);
            this.b_vytvoritUcet.TabIndex = 13;
            this.b_vytvoritUcet.Text = "Vytvoř účet";
            this.b_vytvoritUcet.UseVisualStyleBackColor = true;
            this.b_vytvoritUcet.Click += new System.EventHandler(this.b_vytvoritUcet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Číslo účtu:";
            // 
            // tb_urok
            // 
            this.tb_urok.Location = new System.Drawing.Point(209, 197);
            this.tb_urok.Name = "tb_urok";
            this.tb_urok.Size = new System.Drawing.Size(100, 20);
            this.tb_urok.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Majitel:";
            // 
            // tb_debet
            // 
            this.tb_debet.Location = new System.Drawing.Point(209, 165);
            this.tb_debet.Name = "tb_debet";
            this.tb_debet.Size = new System.Drawing.Size(100, 20);
            this.tb_debet.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zůstatek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Úrok:";
            // 
            // tb_cisloUctu
            // 
            this.tb_cisloUctu.Location = new System.Drawing.Point(99, 26);
            this.tb_cisloUctu.Name = "tb_cisloUctu";
            this.tb_cisloUctu.Size = new System.Drawing.Size(100, 20);
            this.tb_cisloUctu.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Debet:";
            // 
            // tb_majitel
            // 
            this.tb_majitel.Location = new System.Drawing.Point(99, 58);
            this.tb_majitel.Name = "tb_majitel";
            this.tb_majitel.Size = new System.Drawing.Size(100, 20);
            this.tb_majitel.TabIndex = 4;
            // 
            // rb_sporici
            // 
            this.rb_sporici.AutoSize = true;
            this.rb_sporici.Location = new System.Drawing.Point(36, 198);
            this.rb_sporici.Name = "rb_sporici";
            this.rb_sporici.Size = new System.Drawing.Size(84, 17);
            this.rb_sporici.TabIndex = 8;
            this.rb_sporici.TabStop = true;
            this.rb_sporici.Text = "spořící účet";
            this.rb_sporici.UseVisualStyleBackColor = true;
            this.rb_sporici.CheckedChanged += new System.EventHandler(this.rb_sporici_CheckedChanged);
            // 
            // tb_zustatek
            // 
            this.tb_zustatek.Location = new System.Drawing.Point(99, 90);
            this.tb_zustatek.Name = "tb_zustatek";
            this.tb_zustatek.Size = new System.Drawing.Size(100, 20);
            this.tb_zustatek.TabIndex = 5;
            // 
            // rb_debetni
            // 
            this.rb_debetni.AutoSize = true;
            this.rb_debetni.Location = new System.Drawing.Point(36, 167);
            this.rb_debetni.Name = "rb_debetni";
            this.rb_debetni.Size = new System.Drawing.Size(86, 17);
            this.rb_debetni.TabIndex = 7;
            this.rb_debetni.TabStop = true;
            this.rb_debetni.Text = "debetní účet";
            this.rb_debetni.UseVisualStyleBackColor = true;
            this.rb_debetni.CheckedChanged += new System.EventHandler(this.rb_debetni_CheckedChanged);
            // 
            // rb_bezny
            // 
            this.rb_bezny.AutoSize = true;
            this.rb_bezny.Location = new System.Drawing.Point(37, 134);
            this.rb_bezny.Name = "rb_bezny";
            this.rb_bezny.Size = new System.Drawing.Size(77, 17);
            this.rb_bezny.TabIndex = 6;
            this.rb_bezny.TabStop = true;
            this.rb_bezny.Text = "běžný účet";
            this.rb_bezny.UseVisualStyleBackColor = true;
            this.rb_bezny.CheckedChanged += new System.EventHandler(this.rb_bezny_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 366);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_transakce;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_vyberTransakce;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_castka;
        private System.Windows.Forms.ListBox lb_seznamUctu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label l_kodBanky;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_vytvoritUcet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_urok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_debet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_cisloUctu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_majitel;
        private System.Windows.Forms.RadioButton rb_sporici;
        private System.Windows.Forms.TextBox tb_zustatek;
        private System.Windows.Forms.RadioButton rb_debetni;
        private System.Windows.Forms.RadioButton rb_bezny;
    }
}

