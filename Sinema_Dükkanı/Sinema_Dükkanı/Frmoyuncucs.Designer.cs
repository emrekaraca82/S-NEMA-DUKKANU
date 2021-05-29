namespace Sinema_Dükkanı
{
    partial class Frmoyuncucs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmoyuncucs));
            this.label1 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewoyuncu = new System.Windows.Forms.DataGridView();
            this.Btnekle = new System.Windows.Forms.Button();
            this.txtmemleket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btnsil = new System.Windows.Forms.Button();
            this.Btngün = new System.Windows.Forms.Button();
            this.Btngeri = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewoyuncu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adsoyad:";
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(125, 21);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(190, 26);
            this.txtad.TabIndex = 1;
            // 
            // dttarih
            // 
            this.dttarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dttarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dttarih.Location = new System.Drawing.Point(467, 19);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(238, 26);
            this.dttarih.TabIndex = 2;
            // 
            // dataGridViewoyuncu
            // 
            this.dataGridViewoyuncu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewoyuncu.Location = new System.Drawing.Point(12, 71);
            this.dataGridViewoyuncu.Name = "dataGridViewoyuncu";
            this.dataGridViewoyuncu.Size = new System.Drawing.Size(707, 263);
            this.dataGridViewoyuncu.TabIndex = 3;
            this.dataGridViewoyuncu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewoyuncu_CellClick);
            this.dataGridViewoyuncu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewoyuncu_CellContentClick);
            // 
            // Btnekle
            // 
            this.Btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnekle.ForeColor = System.Drawing.Color.Maroon;
            this.Btnekle.Location = new System.Drawing.Point(741, 147);
            this.Btnekle.Name = "Btnekle";
            this.Btnekle.Size = new System.Drawing.Size(97, 46);
            this.Btnekle.TabIndex = 4;
            this.Btnekle.Text = "Ekle";
            this.Btnekle.UseVisualStyleBackColor = true;
            this.Btnekle.Click += new System.EventHandler(this.Btnekle_Click);
            // 
            // txtmemleket
            // 
            this.txtmemleket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmemleket.Location = new System.Drawing.Point(823, 19);
            this.txtmemleket.Name = "txtmemleket";
            this.txtmemleket.Size = new System.Drawing.Size(186, 26);
            this.txtmemleket.TabIndex = 6;
            this.txtmemleket.TextChanged += new System.EventHandler(this.txtmemleket_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(325, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "DoğumTarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(711, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Memleket:";
            // 
            // Btnsil
            // 
            this.Btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnsil.ForeColor = System.Drawing.Color.Maroon;
            this.Btnsil.Location = new System.Drawing.Point(894, 147);
            this.Btnsil.Name = "Btnsil";
            this.Btnsil.Size = new System.Drawing.Size(97, 46);
            this.Btnsil.TabIndex = 8;
            this.Btnsil.Text = "Sil";
            this.Btnsil.UseVisualStyleBackColor = true;
            this.Btnsil.Click += new System.EventHandler(this.Btnsil_Click);
            // 
            // Btngün
            // 
            this.Btngün.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btngün.ForeColor = System.Drawing.Color.Maroon;
            this.Btngün.Location = new System.Drawing.Point(803, 228);
            this.Btngün.Name = "Btngün";
            this.Btngün.Size = new System.Drawing.Size(107, 51);
            this.Btngün.TabIndex = 9;
            this.Btngün.Text = "Güncelle";
            this.Btngün.UseVisualStyleBackColor = true;
            this.Btngün.Click += new System.EventHandler(this.Btngün_Click);
            // 
            // Btngeri
            // 
            this.Btngeri.BackColor = System.Drawing.Color.Transparent;
            this.Btngeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btngeri.Location = new System.Drawing.Point(26, 349);
            this.Btngeri.Name = "Btngeri";
            this.Btngeri.Size = new System.Drawing.Size(116, 55);
            this.Btngeri.TabIndex = 10;
            this.Btngeri.Text = "Geriye Dön";
            this.Btngeri.UseVisualStyleBackColor = false;
            this.Btngeri.Click += new System.EventHandler(this.Btngeri_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(737, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Arama";
            // 
            // txtara
            // 
            this.txtara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtara.Location = new System.Drawing.Point(814, 82);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(177, 26);
            this.txtara.TabIndex = 11;
            this.txtara.TextChanged += new System.EventHandler(this.txtara_TextChanged);
            // 
            // Frmoyuncucs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1021, 407);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.Btngeri);
            this.Controls.Add(this.Btngün);
            this.Controls.Add(this.Btnsil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmemleket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btnekle);
            this.Controls.Add(this.dataGridViewoyuncu);
            this.Controls.Add(this.dttarih);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label1);
            this.Name = "Frmoyuncucs";
            this.Text = "Oyunucular";
            this.Load += new System.EventHandler(this.Frmoyuncucs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewoyuncu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.DataGridView dataGridViewoyuncu;
        private System.Windows.Forms.Button Btnekle;
        private System.Windows.Forms.TextBox txtmemleket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btnsil;
        private System.Windows.Forms.Button Btngün;
        private System.Windows.Forms.Button Btngeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtara;
    }
}