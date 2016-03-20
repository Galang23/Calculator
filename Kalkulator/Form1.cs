using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double total1 = 0;
        double total2 = 0;

        bool tombolTambahTertekan = true;
        bool tombolKurangTertekan = false;
        bool tombolKaliTertekan = true;
        bool tombolBagiTertekan = false;
        string theOperator;

        public Form1()
        {
            InitializeComponent();
        }

        private void satu_Click(object sender, EventArgs e)
        {
            soalJawab.Text += satu.Text;
        }

        private void dua_Click(object sender, EventArgs e)
        {
            soalJawab.Text += dua.Text;
        }

        private void tiga_Click(object sender, EventArgs e)
        {
            soalJawab.Text += tiga.Text;
        }

        private void empat_Click(object sender, EventArgs e)
        {
            soalJawab.Text += empat.Text;
        }

        private void lima_Click(object sender, EventArgs e)
        {
            soalJawab.Text += lima.Text;
        }

        private void enam_Click(object sender, EventArgs e)
        {
            soalJawab.Text += enam.Text;
        }

        private void tujuh_Click(object sender, EventArgs e)
        {
            soalJawab.Text += tujuh.Text;
        }

        private void delapan_Click(object sender, EventArgs e)
        {
            soalJawab.Text += delapan.Text;
        }

        private void sembilan_Click(object sender, EventArgs e)
        {
            soalJawab.Text += sembilan.Text;
        }

        private void nol_Click(object sender, EventArgs e)
        {
            soalJawab.Text += nol.Text;
        }

        private void koma_Click(object sender, EventArgs e)
        {
            soalJawab.Text += ',';
        }

        private void clear_Click(object sender, EventArgs e)
        {
            soalJawab.Clear();
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(soalJawab.Text);
            soalJawab.Clear();

            //tombolTambahTertekan = true;
            //tombolKurangTertekan = false;

            theOperator = "+";
        }

        private void kurang_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(soalJawab.Text);
            soalJawab.Clear();

            //tombolTambahTertekan = false;
            //tombolKurangTertekan = true;

            theOperator = "-";
        }

        private void kali_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(soalJawab.Text);
            soalJawab.Clear();

             ////tombolKaliTertekan = true;
             //tombolBagiTertekan = false;
             //tombolTambahTertekan = false;
             //tombolKurangTertekan = false;

            theOperator = "*";
        }

        private void bagi_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(soalJawab.Text);
            soalJawab.Clear();

             //tombolKaliTertekan = false;
             //tombolBagiTertekan = true;
             //tombolTambahTertekan = false;
             //tombolKurangTertekan = false;
            theOperator = "/";        
        }

        private void samaDengan_Click(object sender, EventArgs e)
        {
            switch (theOperator)
            {
                case "+":
                    total2 = total1 + double.Parse(soalJawab.Text);
                    break;
                case "-":
                    total2 = total1 - double.Parse(soalJawab.Text);
                    break;
                case "*":
                    total2 = total1 * double.Parse(soalJawab.Text);
                    break;
                case "/":
                    total2 = total1 / double.Parse(soalJawab.Text);
                    break;
            }


            /*
            if (tombolTambahTertekan == true) //cara penggunaan if statement yang baik dan benar :v
            {
                total2 = total1 + double.Parse(soalJawab.Text);
            }
            else if (tombolKurangTertekan == true)
            {
                total2 = total1 - double.Parse(soalJawab.Text);
            }
            else if (tombolKaliTertekan == true)
            {
                total2 = total1 * double.Parse(soalJawab.Text);
            }
            else if (tombolBagiTertekan == true)
            {
                total2 = total1 / double.Parse(soalJawab.Text);
            }
            */

            soalJawab.Text = total2.ToString();
            total1 = 0;
        }

    }
}
