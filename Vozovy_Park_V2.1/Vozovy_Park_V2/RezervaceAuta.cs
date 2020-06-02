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
    public partial class RezervaceAuta : Form
    {
        string user;
        UvodniUz u;
        public RezervaceAuta(UvodniUz uz, string uzivatel)
        {
            InitializeComponent();
            user += uzivatel;
            u = uz;
        }

        private void RezervaceAuta_Load(object sender, EventArgs e)
        {
            string cesta = Environment.CurrentDirectory + @"\Cars\";
            string[] fileData = Directory.EnumerateFiles(cesta, "*.txt")
            .Select(x => File.ReadAllText(x)).ToArray();
            for (int i = 0; i < fileData.Length; i++)
            {
                textBox_Auta.Text += fileData[i];
                textBox_Auta.Text += Environment.NewLine;
            }

        }

        private void Rezervovat_Click(object sender, EventArgs e)
        {
            Regex rg = new Regex(@"(?<=Jméno:)\S+");
            Regex rx = new Regex(@"(?<=Příjmení:)\S+");
            string jmeno = "";
            string prijmeni = "";
            string cestaUzivatel = Environment.CurrentDirectory + @"\Users\";
            using (StreamReader sr = new StreamReader(cestaUzivatel + user + ".txt"))
            {
                string radek;
                while ((radek = sr.ReadLine()) != null)
                {
                    if (rg.IsMatch(radek))
                    {
                        jmeno = Convert.ToString(rg.Match(radek));
                    }
                    if (rx.IsMatch(radek))
                    {
                        prijmeni = Convert.ToString(rx.Match(radek));
                    }
                }
            }

            string cesta = Environment.CurrentDirectory + @"\Rezervace\";
            string cestaAuta = Environment.CurrentDirectory + @"\Cars\";
            using (StreamReader sr = new StreamReader(cestaAuta + textBox_ID.Text +".txt"))
            {
                string radek;
                while ((radek = sr.ReadLine()) != null)
                {
                    if (radek == "Zarezervováno")
                    {
                        label6.Visible = true;
                    }
                }
            }
            if (label6.Visible == false)
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(cesta, user + ".txt"), true))
                {
                    sw.WriteLine("Jméno:" + jmeno);
                    sw.WriteLine("Přijmení:" + prijmeni);
                    sw.WriteLine("ID rezervovaného auta:" + textBox_ID.Text);
                }
                using (StreamWriter sw = new StreamWriter(Path.Combine(cestaAuta, textBox_ID.Text + ".txt"), true))
                {
                    sw.WriteLine("Zarezervováno");
                }
                this.Hide();
                u.Show();
            }
            
        }
        public static string ByteArrayToString(byte[] arr)
        {
            StringBuilder hex = new StringBuilder(arr.Length * 2);
            foreach (byte b in arr)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }

        private void Zpet_Click(object sender, EventArgs e)
        {
            this.Hide();
            u.Show();
        }
    }
}
