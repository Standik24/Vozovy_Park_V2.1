namespace Vozovy_Park_V2
{
    partial class VsechnaAuta
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
            this.zpet = new System.Windows.Forms.Button();
            this.textBox_Auta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(131, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 64);
            this.label1.TabIndex = 16;
            this.label1.Text = "Všechna auta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vozovy_Park_V2.Properties.Resources.logo_PVA;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // zpet
            // 
            this.zpet.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zpet.Location = new System.Drawing.Point(205, 685);
            this.zpet.Name = "zpet";
            this.zpet.Size = new System.Drawing.Size(192, 46);
            this.zpet.TabIndex = 21;
            this.zpet.Text = "Zpět";
            this.zpet.UseVisualStyleBackColor = true;
            this.zpet.Click += new System.EventHandler(this.Zpet_Click);
            // 
            // textBox_Auta
            // 
            this.textBox_Auta.Location = new System.Drawing.Point(30, 287);
            this.textBox_Auta.Multiline = true;
            this.textBox_Auta.Name = "textBox_Auta";
            this.textBox_Auta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Auta.Size = new System.Drawing.Size(559, 392);
            this.textBox_Auta.TabIndex = 22;
            // 
            // VsechnaAuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 749);
            this.Controls.Add(this.textBox_Auta);
            this.Controls.Add(this.zpet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VsechnaAuta";
            this.Text = "VsechnaAuta";
            this.Load += new System.EventHandler(this.VsechnaAuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button zpet;
        private System.Windows.Forms.TextBox textBox_Auta;
    }
}