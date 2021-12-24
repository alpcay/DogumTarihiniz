
namespace DogumTarihiniz
{
    partial class Form1
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
            this.lblDogumTarihiniz = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblGun = new System.Windows.Forms.Label();
            this.lblBurc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDogumTarihiniz
            // 
            this.lblDogumTarihiniz.AutoSize = true;
            this.lblDogumTarihiniz.Location = new System.Drawing.Point(161, 58);
            this.lblDogumTarihiniz.Name = "lblDogumTarihiniz";
            this.lblDogumTarihiniz.Size = new System.Drawing.Size(168, 25);
            this.lblDogumTarihiniz.TabIndex = 0;
            this.lblDogumTarihiniz.Text = "Doğum Tarihiniz";
            this.lblDogumTarihiniz.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(141, 117);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 31);
            this.dtpDogumTarihi.TabIndex = 1;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(183, 190);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(118, 41);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(95, 278);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(89, 25);
            this.lblYas.TabIndex = 3;
            this.lblYas.Text = "Yaşınız:";
            this.lblYas.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Location = new System.Drawing.Point(95, 332);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(176, 25);
            this.lblGun.TabIndex = 3;
            this.lblGun.Text = "Yaşadığınız Gün:";
            // 
            // lblBurc
            // 
            this.lblBurc.AutoSize = true;
            this.lblBurc.Location = new System.Drawing.Point(95, 386);
            this.lblBurc.Name = "lblBurc";
            this.lblBurc.Size = new System.Drawing.Size(109, 25);
            this.lblBurc.TabIndex = 3;
            this.lblBurc.Text = "Burcunuz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(660, 650);
            this.Controls.Add(this.lblBurc);
            this.Controls.Add(this.lblGun);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.lblDogumTarihiniz);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Yaş Hesapla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDogumTarihiniz;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Label lblBurc;
    }
}

