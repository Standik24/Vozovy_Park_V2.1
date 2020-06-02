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
using System.Text.RegularExpressions;

namespace Vozovy_Park_V2
{
    public partial class MojeRezervace : Form
    {
        string user;
        UvodniUz u;
        public MojeRezervace(UvodniUz uz, string uzivatel)
        {
            InitializeComponent();
            user += uzivatel;
            u = uz;
        }

        private void MojeRezervace_Load(object sender, EventArgs e)
        {
            string cesta = Environment.CurrentDirectory + @"\Rezervace\";
            using (StreamReader sr = new StreamReader(cesta + user + ".txt"))
            {
                string radek;
                while ((radek = sr.ReadLine()) != null)
                {
                    textBox_Rezervace.Text += radek;
                    textBox_Rezervace.Text += Environment.NewLine;
                }
            }
        }

        private void Zpet_Click(object sender, EventArgs e)
        {
            this.Hide();
            u.Show();
        }

        private void Zobrazit_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Detaily d = new Detaily(this, textBox_IDPod.Text);
            d.Show();
        }

        private void Zrusit_Click(object sender, EventArgs e)
        {
            string s = textBox_IDZrus.Text;
            string cesta = Environment.CurrentDirectory + @"\Rezervace\" + user + ".txt";
            string cestaA = Environment.CurrentDirectory + @"\Cars\" + s + ".txt";
            File.WriteAllText(cesta, File.ReadAllText(cesta).Replace("ID rezervovaného auta:" + textBox_IDZrus.Text, ""));
            File.WriteAllText(cestaA, File.ReadAllText(cestaA).Replace("Zarezervováno", ""));
        }
    }
}
