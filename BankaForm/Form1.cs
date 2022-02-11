using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankaKnihovna;

namespace BankaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            l_kodBanky.Text = "/" + Ucet.KODBANKY.ToString();
        }

        private void b_vytvoritUcet_Click(object sender, EventArgs e)
        {
            try
            {
                string ucet = tb_cisloUctu.Text;
                string majitel = tb_majitel.Text;
                double zustatek = double.Parse(tb_zustatek.Text);

                Ucet uc;
                if (rb_bezny.Checked)
                {
                    uc = new Ucet(ucet, majitel, zustatek);
                }
                else if (rb_sporici.Checked)
                {
                    double urok = double.Parse(tb_urok.Text);
                    uc = new SporiciUcet(ucet, majitel, zustatek, urok);
                }
                else
                {
                    double debet = double.Parse(tb_debet.Text);
                    uc = new DebetniUcet(ucet, majitel, zustatek, debet);
                }

                lb_seznamUctu.Items.Add(uc);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Zadej všechny parametry! \n" + ex.Message);
            }
         }
        private void b_transakce_Click(object sender, EventArgs e)
        {
            try
            {
                double castka = double.Parse(tb_castka.Text);
                Ucet ucet = lb_seznamUctu.SelectedItem as Ucet;
                switch (cb_vyberTransakce.SelectedIndex) {
                    case 0:
                        toolStripStatusLabel1.Text = ucet.Vybrat(castka);
                        break;
                    case 1:
                        toolStripStatusLabel1.Text = ucet.Vlozit(castka);
                        break;
                    case 2:
                        if (ucet.GetType() == typeof(SporiciUcet))
                        {
                            toolStripStatusLabel1.Text = ((SporiciUcet)ucet).PripsatUrok();
                        }
                        break;
                }
                lb_seznamUctu.Items[lb_seznamUctu.SelectedIndex] = lb_seznamUctu.Items[lb_seznamUctu.SelectedIndex];
            }

            catch(Exception ex)
            {
                MessageBox.Show("Zadej částku! \n" + ex.Message);
            }
        }

        private void rb_sporici_CheckedChanged(object sender, EventArgs e)
        {
            tb_debet.ReadOnly = true;
            tb_urok.ReadOnly = false;
        }

        private void rb_debetni_CheckedChanged(object sender, EventArgs e)
        {
            tb_urok.ReadOnly = true;
            tb_debet.ReadOnly = false;
        }

        private void rb_bezny_CheckedChanged(object sender, EventArgs e)
        {
            tb_debet.ReadOnly = true;
            tb_urok.ReadOnly = true;
        }
    }
}
