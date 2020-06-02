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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Prihlasit_Click(object sender, EventArgs e)
        {
            byte[] ujmeno = Encoding.GetEncoding("UTF-8").GetBytes(user.Text);
            SHA256 sha256 = SHA256.Create();
            byte[] ujmenoHash = sha256.ComputeHash(ujmeno);
            string un = Convert.ToString(ByteArrayToString(ujmenoHash));
            bool prvniPrihlaseni = true;

            string cesta = Environment.CurrentDirectory + @"\Users\" + un + ".txt";

            if (File.Exists(cesta) == false)
            {
                label3.Visible = true;
            }
            else
            {
                string h = "";
                byte[] adminHash;
                byte[] HesloHash;
                adminHash = sha256.ComputeHash(Encoding.UTF8.GetBytes("admin"));
                HesloHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(heslo.Text));

                StreamReader sr = new StreamReader(cesta);
                Regex rg = new Regex(@"(?<=Heslo:)\S+");
                Regex rh = new Regex(@"(?<=Poslední přihlášení:)\S+");
                string radek;
                bool zmena = false;
                while ((radek = sr.ReadLine()) != null)
                {
                    if (rg.IsMatch(radek))
                    {
                        h = Convert.ToString(rg.Match(radek));
                    }
                    if (radek == "zmenaHesla")
                    {
                        zmena = true;
                    }
                    if (rh.IsMatch(radek))
                    {
                        prvniPrihlaseni = false;
                    }
                }
                sr.Close();

            
                if (BitConverter.ToString(adminHash).Replace("-", "").ToLower() != un && BitConverter.ToString(HesloHash).Replace("-", "").ToLower() == h) 
                {
                    UvodniUz uz = new UvodniUz(un);
                    if (zmena == true)
                    {
                        this.Hide();
                        ZmenaHesla zm = new ZmenaHesla(uz, un);
                        zm.Show();
                    }
                    else
                    {
                        this.Hide();
                        uz.Show();
                    }
                    
                }
                if (BitConverter.ToString(adminHash).Replace("-", "").ToLower() == un && BitConverter.ToString(HesloHash).Replace("-", "").ToLower() == h)
                {
                    this.Hide();
                    UvodniAd u = new UvodniAd(un,this);
                    u.Show();
                    if (prvniPrihlaseni == true)
                    {
                        using (StreamWriter sw = File.AppendText(cesta))
                        {
                            sw.WriteLine("Poslední přihlášení:" + DateTime.Now);
                            prvniPrihlaseni = false;
                        }
                    }
                    else
                    {
                        File.WriteAllText(cesta, Regex.Replace(File.ReadAllText(cesta), @"(?<=Poslední přihlášení:)\S+", DateTime.Now.ToString()));
                    }
                }
                else
                {
                    label6.Visible = true;
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
    }
}
