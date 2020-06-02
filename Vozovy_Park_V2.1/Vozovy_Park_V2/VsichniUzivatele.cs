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
    public partial class VsichniUzivatele : Form
    {
        UvodniAd a;
        public VsichniUzivatele(UvodniAd ad)
        {
            InitializeComponent();
            a = ad;
        }

        private void VsichniUzivatele_Load(object sender, EventArgs e)
        {
            string cesta = Environment.CurrentDirectory + @"\Users\";
            string[] fileData = Directory.EnumerateFiles(cesta, "*.txt")
            .Select(x => File.ReadAllText(x)).ToArray();
            for (int i = 0; i < fileData.Length; i++)
            {
                textBox_uzivatele.Text += fileData[i];
                textBox_uzivatele.Text += Environment.NewLine;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            a.Show();
        }
    }
}
