namespace Vozovy_Park_V2
{
    partial class VsechnyRezervace
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Rezervace
            // 
            this.textBox_Rezervace.Location = new System.Drawing.Point(30, 274);
            this.textBox_Rezervace.Multiline = true;
            this.textBox_Rezervace.Name = "textBox_Rezervace";
            this.textBox_Rezervace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Rezervace.Size = new System.Drawing.Size(559, 392);
            this.textBox_Rezervace.TabIndex = 26;
            // 
            // zpet
            // 
            this.zpet.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zpet.Location = new System.Drawing.Point(205, 672);
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
            this.label1.Location = new System.Drawing.Point(76, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 64);
            this.label1.TabIndex = 24;
            this.label1.Text = "Všechny rezervace";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vozovy_Park_V2.Properties.Resources.logo_PVA;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // VsechnyRezervace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 721);
            this.Controls.Add(this.textBox_Rezervace);
            this.Controls.Add(this.zpet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VsechnyRezervace";
            this.Text = "VsechnyRezervace";
            this.Load += new System.EventHandler(this.VsechnyRezervace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Rezervace;
        private System.Windows.Forms.Button zpet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}