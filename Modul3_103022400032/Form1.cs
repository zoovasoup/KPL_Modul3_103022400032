using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_103022400032
{
    public partial class Form1 : Form
    {
        private String satuanAwal = "";
        private String satuanAkhir = "";
        private int nilaiAwal = 0;
        private int nilaiAkhir = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("masukkan angka yang valid");
            } else if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("masukkan satuan terlebih dahulu");
            }




        }

    }
}
