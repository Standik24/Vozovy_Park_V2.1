﻿using System;
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
    public partial class VsechnaAuta : Form
    {
        UvodniAd a;
        public VsechnaAuta(UvodniAd ad)
        {
            InitializeComponent();
            a = ad;
        }

        private void VsechnaAuta_Load(object sender, EventArgs e)
        {
            string cesta = Environment.CurrentDirectory + @"\Cars\";
            string[] fileData = Directory.EnumerateFiles(cesta, "*.txt")
            .Select(x => File.ReadAllText(x)).ToArray();
            for (int i = 0; i < fileData.Length; i++)
            {
                textBox_Auta.Text += Path.GetFileName(cesta);
                textBox_Auta.Text += fileData[i];
                textBox_Auta.Text += Environment.NewLine;
            }

        }

        private void Zpet_Click(object sender, EventArgs e)
        {
            this.Hide();
            a.Show();
        }
    }
}
