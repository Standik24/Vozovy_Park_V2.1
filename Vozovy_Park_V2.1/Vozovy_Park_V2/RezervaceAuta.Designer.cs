namespace Vozovy_Park_V2
{
    partial class RezervaceAuta
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rezervovat = new System.Windows.Forms.Button();
            this.textBox_Auta = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.zpet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(250, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 64);
            this.label1.TabIndex = 16;
            this.label1.Text = "Rezervace";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vozovy_Park_V2.Properties.Resources.logo_PVA;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(109, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // rezervovat
            // 
            this.rezervovat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rezervovat.Location = new System.Drawing.Point(503, 446);
            this.rezervovat.Name = "rezervovat";
            this.rezervovat.Size = new System.Drawing.Size(281, 67);
            this.rezervovat.TabIndex = 17;
            this.rezervovat.Text = "Zarezervovat";
            this.rezervovat.UseVisualStyleBackColor = true;
            this.rezervovat.Click += new System.EventHandler(this.Rezervovat_Click);
            // 
            // textBox_Auta
            // 
            this.textBox_Auta.Location = new System.Drawing.Point(12, 283);
            this.textBox_Auta.Multiline = true;
            this.textBox_Auta.Name = "textBox_Auta";
            this.textBox_Auta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Auta.Size = new System.Drawing.Size(470, 471);
            this.textBox_Auta.TabIndex = 18;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(503, 342);
            this.textBox_ID.Multiline = true;
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(288, 35);
            this.textBox_ID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(498, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID auta k rezervaci :";
            // 
            // label6
            // 
            this.label6.Cursor = System.Windows.Forms.Cursors.No;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(499, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 46);
            this.label6.TabIndex = 21;
            this.label6.Text = "Toto auto už je zarezervované";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // zpet
            // 
            this.zpet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zpet.Location = new System.Drawing.Point(510, 662);
            this.zpet.Name = "zpet";
            this.zpet.Size = new System.Drawing.Size(281, 67);
            this.zpet.TabIndex = 22;
            this.zpet.Text = "Zpět";
            this.zpet.UseVisualStyleBackColor = true;
            this.zpet.Click += new System.EventHandler(this.Zpet_Click);
            // 
            // RezervaceAuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 758);
            this.Controls.Add(this.zpet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.textBox_Auta);
            this.Controls.Add(this.rezervovat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RezervaceAuta";
            this.Text = "RezervaceAuta";
            this.Load += new System.EventHandler(this.RezervaceAuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button rezervovat;
        private System.Windows.Forms.TextBox textBox_Auta;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button zpet;
    }
}