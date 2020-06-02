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
    public partial class Detaily : Form
    {
        MojeRezervace m;
        string id;
        public Detaily(MojeRezervace mo,string ID)
        {
            InitializeComponent();
            m = mo;
            id = ID;
        }

        private void Zpet_Click(object sender, EventArgs e)
        {
            this.Hide();
            m.Show();
        }

        private void Detaily_Load(object sender, EventArgs e)
        {
            string cestaAuta = Environment.CurrentDirectory + @"\Cars\";
            string g = "";
            string y = "";
            string x = "";
            string z = "";
            string s = "";
            using (StreamReader sr = new StreamReader(cestaAuta + id + ".txt"))
            {
                string radek;
                Regex rg = new Regex(@"(?<=Značka:)\S+");
                Regex ry = new Regex(@"(?<=Model:)\S+");
                Regex rx = new Regex(@"(?<=Typ:)\S+");
                Regex rz = new Regex(@"(?<=Spotřeba na 100 km:)\S+");
                Regex r = new Regex(@"(?<=Náklady na celkovou údržbu:)\S+");
                while ((radek = sr.ReadLine()) != null)
                {
                    if (rg.IsMatch(radek))
                    {
                        g = Convert.ToString(rg.Match(radek));
                    }
                    if (ry.IsMatch(radek))
                    {
                        y = Convert.ToString(ry.Match(radek));
                    }
                    if (rx.IsMatch(radek))
                    {
                        x = Convert.ToString(rx.Match(radek));
                    }
                    if (rz.IsMatch(radek))
                    {
                        z = Convert.ToString(rz.Match(radek));
                    }
                    if (r.IsMatch(radek))
                    {
                        s = Convert.ToString(r.Match(radek));
                    }
                }
            }
            textBox_Detaily.Text += "Značka:" + g;
            textBox_Detaily.Text += Environment.NewLine;
            textBox_Detaily.Text += "Model:" + y;
            textBox_Detaily.Text += Environment.NewLine;
            textBox_Detaily.Text += "Typ:" + x;
            textBox_Detaily.Text += Environment.NewLine;
            textBox_Detaily.Text += "Spotřeba na 100 km:" + z + " litrů";
            textBox_Detaily.Text += Environment.NewLine;
            textBox_Detaily.Text += "Náklady na celkovou údržbu:" + s + " Kč";
        }
    }
}
