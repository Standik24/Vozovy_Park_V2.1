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
using System.Security.Cryptography;

namespace Vozovy_Park_V2
{
    public partial class VynuceniZmeny : Form
    {
        UvodniAd a;
        public VynuceniZmeny(UvodniAd ad)
        {
            InitializeComponent();
            a = ad;
        }

        private void Potvrdit_Click(object sender, EventArgs e)
        {
            string h = "";
            byte[] uJmeno = Encoding.GetEncoding("UTF-8").GetBytes(ujmeno.Text);
            SHA256 sha256 = SHA256.Create();
            byte[] HesloHash;
            HesloHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(hesloA.Text));
            byte[] ujmenoHash = sha256.ComputeHash(uJmeno);
            string un = Convert.ToString(ByteArrayToString(ujmenoHash));
            byte[] adminHash;
            adminHash = sha256.ComputeHash(Encoding.UTF8.GetBytes("admin"));
            string unA = Convert.ToString(ByteArrayToString(adminHash));

            string cesta = Environment.CurrentDirectory + @"\Users\" + un +".txt";
            string cestaAdmin = Environment.CurrentDirectory + @"\Users\" + unA + ".txt";

            if (File.Exists(cesta) == false)
            {
                label5.Visible = true;
            }
            else
            {
                using (StreamReader sr = new StreamReader(cestaAdmin))
                {
                    Regex rg = new Regex(@"(?<=Heslo:)\S+");
                    string radek;
                    while ((radek = sr.ReadLine()) != null)
                    {
                        if (rg.IsMatch(radek))
                        {
                            h = Convert.ToString(rg.Match(radek));
                        }
                    }
                }
                if (BitConverter.ToString(HesloHash).Replace("-", "").ToLower() == h)
                {
                    using (StreamReader sr = new StreamReader(cesta))
                    {
                        string radek;
                        while ((radek = sr.ReadLine()) != null)
                        {
                            if (radek == "zmenaHesla")
                            {
                                label6.Visible = true;
                                zpet.Visible = true;
                            }
                        }
                    }
                    if (label6.Visible == false)
                    {
                        using (StreamWriter sw = new StreamWriter(cesta, true))
                        {
                            sw.WriteLine("zmenaHesla");
                        }
                        this.Hide();
                        a.Show();
                    }
                }
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
            a.Show();
        }
    }
}
