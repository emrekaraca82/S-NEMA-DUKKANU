namespace Sinema_Dükkanı
{
    partial class frmfilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfilm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtadı = new System.Windows.Forms.TextBox();
            this.Btnekle = new System.Windows.Forms.Button();
            this.cmbyönetmen = new System.Windows.Forms.ComboBox();
            this.dataGridViewFilm = new System.Windows.Forms.DataGridView();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.txtkonu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsure = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Btnsil = new System.Windows.Forms.Button();
            this.Btngün = new System.Windows.Forms.Button();
            this.Btngeri = new System.Windows.Forms.Button();
            this.txtarama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(66, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "FilmAdı:";
            // 
            // txtadı
            // 
            this.txtadı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadı.Location = new System.Drawing.Point(156, 10);
            this.txtadı.Name = "txtadı";
            this.txtadı.Size = new System.Drawing.Size(191, 26);
            this.txtadı.TabIndex = 1;
            // 
            // Btnekle
            // 
            this.Btnekle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btnekle.Location = new System.Drawing.Point(377, 362);
            this.Btnekle.Name = "Btnekle";
            this.Btnekle.Size = new System.Drawing.Size(114, 39);
            this.Btnekle.TabIndex = 2;
            this.Btnekle.Text = "Kaydet";
            this.Btnekle.UseVisualStyleBackColor = true;
            this.Btnekle.Click += new System.EventHandler(this.Btnekle_Click);
            // 
            // cmbyönetmen
            // 
            this.cmbyönetmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbyönetmen.FormattingEnabled = true;
            this.cmbyönetmen.Location = new System.Drawing.Point(156, 115);
            this.cmbyönetmen.Name = "cmbyönetmen";
            this.cmbyönetmen.Size = new System.Drawing.Size(191, 24);
            this.cmbyönetmen.TabIndex = 3;
            // 
            // dataGridViewFilm
            // 
            this.dataGridViewFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilm.Location = new System.Drawing.Point(377, 62);
            this.dataGridViewFilm.Name = "dataGridViewFilm";
            this.dataGridViewFilm.Size = new System.Drawing.Size(627, 285);
            this.dataGridViewFilm.TabIndex = 4;
            this.dataGridViewFilm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFilm_CellClick);
            // 
            // dttarih
            // 
            this.dttarih.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dttarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dttarih.Location = new System.Drawing.Point(156, 220);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(191, 22);
            this.dttarih.TabIndex = 5;
            // 
            // txtkonu
            // 
            this.txtkonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkonu.Location = new System.Drawing.Point(156, 65);
            this.txtkonu.Name = "txtkonu";
            this.txtkonu.Size = new System.Drawing.Size(191, 26);
            this.txtkonu.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(84, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Konu:";
            // 
            // txtsure
            // 
            this.txtsure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsure.Location = new System.Drawing.Point(156, 162);
            this.txtsure.Name = "txtsure";
            this.txtsure.Size = new System.Drawing.Size(191, 26);
            this.txtsure.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(17, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "YönetmenAdı:";
            // 
            // txtfiyat
            // 
            this.txtfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfiyat.Location = new System.Drawing.Point(156, 270);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(191, 26);
            this.txtfiyat.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(87, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Süre:";
            // 
            // txtstok
            // 
            this.txtstok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtstok.Location = new System.Drawing.Point(156, 321);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(191, 26);
            this.txtstok.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(28, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "VizyonTarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(86, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fiyat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(88, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Stok:";
            // 
            // Btnsil
            // 
            this.Btnsil.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnsil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btnsil.Location = new System.Drawing.Point(550, 362);
            this.Btnsil.Name = "Btnsil";
            this.Btnsil.Size = new System.Drawing.Size(114, 38);
            this.Btnsil.TabIndex = 16;
            this.Btnsil.Text = "Sil";
            this.Btnsil.UseVisualStyleBackColor = true;
            this.Btnsil.Click += new System.EventHandler(this.Btnsil_Click);
            // 
            // Btngün
            // 
            this.Btngün.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btngün.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btngün.Location = new System.Drawing.Point(746, 361);
            this.Btngün.Name = "Btngün";
            this.Btngün.Size = new System.Drawing.Size(114, 41);
            this.Btngün.TabIndex = 17;
            this.Btngün.Text = "Güncelle";
            this.Btngün.UseVisualStyleBackColor = true;
            this.Btngün.Click += new System.EventHandler(this.Btngün_Click);
            // 
            // Btngeri
            // 
            this.Btngeri.BackColor = System.Drawing.Color.White;
            this.Btngeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btngeri.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btngeri.ForeColor = System.Drawing.Color.Teal;
            this.Btngeri.Location = new System.Drawing.Point(12, 361);
            this.Btngeri.Name = "Btngeri";
            this.Btngeri.Size = new System.Drawing.Size(118, 53);
            this.Btngeri.TabIndex = 18;
            this.Btngeri.Text = "Geriye Dön";
            this.Btngeri.UseVisualStyleBackColor = false;
            this.Btngeri.Click += new System.EventHandler(this.Btngeri_Click);
            // 
            // txtarama
            // 
            this.txtarama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtarama.Location = new System.Drawing.Point(657, 16);
            this.txtarama.Name = "txtarama";
            this.txtarama.Size = new System.Drawing.Size(191, 26);
            this.txtarama.TabIndex = 20;
            this.txtarama.TextChanged += new System.EventHandler(this.txtarama_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(559, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Arama";
            // 
            // frmfilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1016, 426);
            this.Controls.Add(this.txtarama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Btngeri);
            this.Controls.Add(this.Btngün);
            this.Controls.Add(this.Btnsil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtkonu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dttarih);
            this.Controls.Add(this.dataGridViewFilm);
            this.Controls.Add(this.cmbyönetmen);
            this.Controls.Add(this.Btnekle);
            this.Controls.Add(this.txtadı);
            this.Controls.Add(this.label1);
            this.Name = "frmfilm";
            this.Text = "Filmler";
            this.Load += new System.EventHandler(this.frmfilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadı;
        private System.Windows.Forms.Button Btnekle;
        private System.Windows.Forms.ComboBox cmbyönetmen;
        private System.Windows.Forms.DataGridView dataGridViewFilm;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.TextBox txtkonu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btnsil;
        private System.Windows.Forms.Button Btngün;
        private System.Windows.Forms.Button Btngeri;
        private System.Windows.Forms.TextBox txtarama;
        private System.Windows.Forms.Label label8;
    }
}