namespace Vozovy_Park_V2
{
    partial class VynuceniZmeny
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
            this.label2 = new System.Windows.Forms.Label();
            this.hesloA = new System.Windows.Forms.TextBox();
            this.ujmeno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.potvrdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.zpet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 36);
            this.label2.TabIndex = 25;
            this.label2.Text = "Heslo admina:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hesloA
            // 
            this.hesloA.Location = new System.Drawing.Point(18, 482);
            this.hesloA.Multiline = true;
            this.hesloA.Name = "hesloA";
            this.hesloA.PasswordChar = '*';
            this.hesloA.Size = new System.Drawing.Size(218, 43);
            this.hesloA.TabIndex = 21;
            // 
            // ujmeno
            // 
            this.ujmeno.Location = new System.Drawing.Point(18, 371);
            this.ujmeno.Multiline = true;
            this.ujmeno.Name = "ujmeno";
            this.ujmeno.Size = new System.Drawing.Size(218, 43);
            this.ujmeno.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 36);
            this.label4.TabIndex = 22;
            this.label4.Text = "Uživatel k vynucení:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 64);
            this.label1.TabIndex = 21;
            this.label1.Text = "Vynucení změny hesla";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // potvrdit
            // 
            this.potvrdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.potvrdit.Location = new System.Drawing.Point(18, 565);
            this.potvrdit.Name = "potvrdit";
            this.potvrdit.Size = new System.Drawing.Size(225, 58);
            this.potvrdit.TabIndex = 22;
            this.potvrdit.Text = "Potvrdit";
            this.potvrdit.UseVisualStyleBackColor = true;
            this.potvrdit.Click += new System.EventHandler(this.Potvrdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "label3";
            // 
            // label6
            // 
            this.label6.Cursor = System.Windows.Forms.Cursors.No;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(289, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 46);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tento uživatel již má vynucenou změnu hesla";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Vozovy_Park_V2.Properties.Resources.logo_PVA;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(18, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(289, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 46);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tento uživatel neexistuje";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // zpet
            // 
            this.zpet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zpet.Location = new System.Drawing.Point(293, 565);
            this.zpet.Name = "zpet";
            this.zpet.Size = new System.Drawing.Size(225, 58);
            this.zpet.TabIndex = 29;
            this.zpet.Text = "Zpět";
            this.zpet.UseVisualStyleBackColor = true;
            this.zpet.Visible = false;
            this.zpet.Click += new System.EventHandler(this.Zpet_Click);
            // 
            // VynuceniZmeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 644);
            this.Controls.Add(this.zpet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hesloA);
            this.Controls.Add(this.ujmeno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.potvrdit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VynuceniZmeny";
            this.Text = "VynuceniZmeny";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hesloA;
        private System.Windows.Forms.TextBox ujmeno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button potvrdit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button zpet;
    }
}