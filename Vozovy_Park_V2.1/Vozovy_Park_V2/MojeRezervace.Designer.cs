namespace Vozovy_Park_V2
{
    partial class MojeRezervace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Rezervace = new System.Windows.Forms.TextBox();
            this.zpet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zobrazit = new System.Windows.Forms.Button();
            this.textBox_IDPod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_IDZrus = new System.Windows.Forms.TextBox();
            this.Zrusit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Rezervace
            // 
            this.textBox_Rezervace.Location = new System.Drawing.Point(12, 282);
            this.textBox_Rezervace.Multiline = true;
            this.textBox_Rezervace.Name = "textBox_Rezervace";
            this.textBox_Rezervace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Rezervace.Size = new System.Drawing.Size(559, 392);
            this.textBox_Rezervace.TabIndex = 26;
            // 
            // zpet
            // 
            this.zpet.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zpet.Location = new System.Drawing.Point(252, 680);
            this.zpet.Name = "zpet";
            this.zpet.Size = new System.Drawing.Size(192, 46);
            this.zpet.TabIndex = 25;
            this.zpet.Text = "Zpět";
            this.zpet.UseVisualStyleBackColor = true;
            this.zpet.Click += new System.EventHandler(this.Zpet_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(140, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 64);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mé rezervované auta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vozovy_Park_V2.Properties.Resources.logo_PVA;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(114, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // zobrazit
            // 
            this.zobrazit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zobrazit.Location = new System.Drawing.Point(582, 623);
            this.zobrazit.Name = "zobrazit";
            this.zobrazit.Size = new System.Drawing.Size(211, 61);
            this.zobrazit.TabIndex = 27;
            this.zobrazit.Text = "Zobrazit podrobnosti";
            this.zobrazit.UseVisualStyleBackColor = true;
            this.zobrazit.Click += new System.EventHandler(this.Zobrazit_Click);
            // 
            // textBox_IDPod
            // 
            this.textBox_IDPod.Location = new System.Drawing.Point(582, 573);
            this.textBox_IDPod.Multiline = true;
            this.textBox_IDPod.Name = "textBox_IDPod";
            this.textBox_IDPod.Size = new System.Drawing.Size(211, 44);
            this.textBox_IDPod.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(577, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Podrobnosti o autech";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(577, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "ID auta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(577, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "ID auta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(577, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Zrušít rezervaci";
            // 
            // textBox_IDZrus
            // 
            this.textBox_IDZrus.Location = new System.Drawing.Point(582, 356);
            this.textBox_IDZrus.Multiline = true;
            this.textBox_IDZrus.Name = "textBox_IDZrus";
            this.textBox_IDZrus.Size = new System.Drawing.Size(211, 44);
            this.textBox_IDZrus.TabIndex = 32;
            // 
            // Zrusit
            // 
            this.Zrusit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zrusit.Location = new System.Drawing.Point(582, 406);
            this.Zrusit.Name = "Zrusit";
            this.Zrusit.Size = new System.Drawing.Size(211, 61);
            this.Zrusit.TabIndex = 31;
            this.Zrusit.Text = "Zrušit rezervaci";
            this.Zrusit.UseVisualStyleBackColor = true;
            this.Zrusit.Click += new System.EventHandler(this.Zrusit_Click);
            // 
            // MojeRezervace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 732);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_IDZrus);
            this.Controls.Add(this.Zrusit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_IDPod);
            this.Controls.Add(this.zobrazit);
            this.Controls.Add(this.textBox_Rezervace);
            this.Controls.Add(this.zpet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MojeRezervace";
            this.Text = "MojeRezervace";
            this.Load += new System.EventHandler(this.MojeRezervace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Rezervace;
        private System.Windows.Forms.Button zpet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button zobrazit;
        private System.Windows.Forms.TextBox textBox_IDPod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_IDZrus;
        private System.Windows.Forms.Button Zrusit;
    }
}