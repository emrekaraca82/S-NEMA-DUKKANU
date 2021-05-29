namespace Sinema_Dükkanı
{
    partial class Frmtürler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmtürler));
            this.txtad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnekle = new System.Windows.Forms.Button();
            this.dataGridViewtürler = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtarama = new System.Windows.Forms.TextBox();
            this.Btnsil = new System.Windows.Forms.Button();
            this.Btngün = new System.Windows.Forms.Button();
            this.Btngeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtürler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(190, 25);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(198, 28);
            this.txtad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(99, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "TürAdı:";
            // 
            // Btnekle
            // 
            this.Btnekle.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnekle.ForeColor = System.Drawing.Color.Teal;
            this.Btnekle.Location = new System.Drawing.Point(804, 70);
            this.Btnekle.Name = "Btnekle";
            this.Btnekle.Size = new System.Drawing.Size(109, 51);
            this.Btnekle.TabIndex = 2;
            this.Btnekle.Text = "Ekle";
            this.Btnekle.UseVisualStyleBackColor = true;
            this.Btnekle.Click += new System.EventHandler(this.Btnekle_Click);
            // 
            // dataGridViewtürler
            // 
            this.dataGridViewtürler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtürler.Location = new System.Drawing.Point(36, 70);
            this.dataGridViewtürler.Name = "dataGridViewtürler";
            this.dataGridViewtürler.Size = new System.Drawing.Size(762, 269);
            this.dataGridViewtürler.TabIndex = 3;
            this.dataGridViewtürler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtürler_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(423, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Arama:";
            // 
            // txtarama
            // 
            this.txtarama.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtarama.Location = new System.Drawing.Point(511, 25);
            this.txtarama.Name = "txtarama";
            this.txtarama.Size = new System.Drawing.Size(189, 28);
            this.txtarama.TabIndex = 4;
            this.txtarama.TextChanged += new System.EventHandler(this.txtarama_TextChanged);
            // 
            // Btnsil
            // 
            this.Btnsil.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsil.ForeColor = System.Drawing.Color.Teal;
            this.Btnsil.Location = new System.Drawing.Point(860, 172);
            this.Btnsil.Name = "Btnsil";
            this.Btnsil.Size = new System.Drawing.Size(107, 53);
            this.Btnsil.TabIndex = 6;
            this.Btnsil.Text = "Sil";
            this.Btnsil.UseVisualStyleBackColor = true;
            this.Btnsil.Click += new System.EventHandler(this.Btnsil_Click);
            // 
            // Btngün
            // 
            this.Btngün.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btngün.ForeColor = System.Drawing.Color.Teal;
            this.Btngün.Location = new System.Drawing.Point(908, 287);
            this.Btngün.Name = "Btngün";
            this.Btngün.Size = new System.Drawing.Size(116, 52);
            this.Btngün.TabIndex = 7;
            this.Btngün.Text = "Güncelle";
            this.Btngün.UseVisualStyleBackColor = true;
            this.Btngün.Click += new System.EventHandler(this.Btngün_Click);
            // 
            // Btngeri
            // 
            this.Btngeri.BackColor = System.Drawing.Color.Transparent;
            this.Btngeri.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btngeri.Location = new System.Drawing.Point(12, 345);
            this.Btngeri.Name = "Btngeri";
            this.Btngeri.Size = new System.Drawing.Size(108, 50);
            this.Btngeri.TabIndex = 8;
            this.Btngeri.Text = "Geriye Dön";
            this.Btngeri.UseVisualStyleBackColor = false;
            this.Btngeri.Click += new System.EventHandler(this.Btngeri_Click);
            // 
            // Frmtürler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1027, 407);
            this.Controls.Add(this.Btngeri);
            this.Controls.Add(this.Btngün);
            this.Controls.Add(this.Btnsil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtarama);
            this.Controls.Add(this.dataGridViewtürler);
            this.Controls.Add(this.Btnekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtad);
            this.Name = "Frmtürler";
            this.Text = "Türler";
            this.Load += new System.EventHandler(this.Frmtürler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtürler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnekle;
        private System.Windows.Forms.DataGridView dataGridViewtürler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtarama;
        private System.Windows.Forms.Button Btnsil;
        private System.Windows.Forms.Button Btngün;
        private System.Windows.Forms.Button Btngeri;
    }
}