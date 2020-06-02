using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vozovy_Park_V2
{
    public partial class VsechnyRezervace : Form
    {
        UvodniAd a;
        public VsechnyRezervace(UvodniAd ad)
        {
            InitializeComponent();
            a = ad;
        }

        private void Zpet_Click(object sender, EventArgs e)
        {
            this.Hide();
            a.Show();
        }

        private void VsechnyRezervace_Load(object sender, EventArgs e)
        {
            string cesta = Environment.CurrentDirectory + @"\Rezervace\";
            string[] fileData = Directory.EnumerateFiles(cesta, "*.txt")
            .Select(x => File.ReadAllText(x)).ToArray();
            for (int i = 0; i < fileData.Length; i++)
            {
                textBox_Rezervace.Text += fileData[i];
                textBox_Rezervace.Text += Environment.NewLine;
            }
        }
    }
}
