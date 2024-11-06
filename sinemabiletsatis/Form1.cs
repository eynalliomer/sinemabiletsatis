using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinemabiletsatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int bilet, misir, cay, su, cips,toplam;
            misir = Convert.ToInt32(txtmisir.Text);
            bilet = Convert.ToInt32(txtbilet.Text);
            cay = Convert.ToInt32(txtcay.Text);
            su = Convert.ToInt32(txtsu.Text);
            cips = Convert.ToInt32(txtcips.Text);

            toplam = bilet * 20 + misir * 15 + cay * 10 + su * 5 + cips * 25;
            lbltoplam.Text = toplam.ToString()+ " TL";

            kasatutar = kasatutar + toplam;
            lblkasa.Text = kasatutar.ToString() + " TL";               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbltoplam.Text = "00";
            txtcips.Text = "";
            txtbilet.Text = "";
            txtmisir.Text = "";
            txtcay.Text = "";
            txtsu.Text = "";
            
            txtbilet.Focus();


        }
    }
}
