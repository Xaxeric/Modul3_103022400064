using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_103022400064
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double ToCelcius(double nilai, String satuan)
        {
            switch (satuan)
            {
                case "Celcius":
                    return nilai;
                case "Fahrenheit":
                    return (nilai - 32) * (5/9);
                case "Kelvin":
                    return (nilai - 273.15);
                case "Reamur":
                    return nilai * (5/4);
                default:
                    return nilai;
            }
        }

        private double fromCelcius(double nilai, String satuan)
        {
            switch (satuan)
            {
                case "Celcius":
                    return nilai;
                case "Fahrenheit":
                    return (nilai * (9/5)) + 32;
                case "Kelvin":
                    return nilai + 273.15;
                case "Reamur":
                    return nilai * (4/5);
                default:
                    return nilai;
            }
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            if (comboBoxDegree.SelectedItem == null || comboBoxDegreeAkhir.SelectedItem == null)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu");
                return;
            }

            string satuanAwal = comboBoxDegree.SelectedItem.ToString().Trim();
            string satuanAkhir = comboBoxDegreeAkhir.SelectedItem.ToString().Trim();
            
            if (!double.TryParse(textBox1.Text, out double nilai))
            {
                MessageBox.Show("Masukkan angka yang valid!");
                return;
            }

            double celcius = ToCelcius(nilai, satuanAwal);
            double nilaiAkhir = fromCelcius(celcius, satuanAkhir);

            textBox2.Text = nilaiAkhir.ToString("F2");
            


        }
    }
}
