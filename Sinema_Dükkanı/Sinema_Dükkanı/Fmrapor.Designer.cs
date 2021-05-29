namespace Sinema_Dükkanı
{
    partial class Fmrapor
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fmrapor));
            this.btnarama = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sinema_dükkanıDataSet = new Sinema_Dükkanı.sinema_dükkanıDataSet();
            this.satıslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satıslarTableAdapter = new Sinema_Dükkanı.sinema_dükkanıDataSetTableAdapters.satıslarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sinema_dükkanıDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satıslarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnarama
            // 
            this.btnarama.Location = new System.Drawing.Point(304, 15);
            this.btnarama.Name = "btnarama";
            this.btnarama.Size = new System.Drawing.Size(75, 23);
            this.btnarama.TabIndex = 0;
            this.btnarama.Text = "Arama";
            this.btnarama.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 1;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.satıslarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sinema_Dükkanı.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 61);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1007, 322);
            this.reportViewer1.TabIndex = 2;
            // 
            // sinema_dükkanıDataSet
            // 
            this.sinema_dükkanıDataSet.DataSetName = "sinema_dükkanıDataSet";
            this.sinema_dükkanıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satıslarBindingSource
            // 
            this.satıslarBindingSource.DataMember = "satıslar";
            this.satıslarBindingSource.DataSource = this.sinema_dükkanıDataSet;
            // 
            // satıslarTableAdapter
            // 
            this.satıslarTableAdapter.ClearBeforeFill = true;
            // 
            // Fmrapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1006, 395);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnarama);
            this.Name = "Fmrapor";
            this.Text = "Raporlama";
            this.Load += new System.EventHandler(this.Fmrapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinema_dükkanıDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satıslarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnarama;
        private System.Windows.Forms.TextBox textBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource satıslarBindingSource;
        private sinema_dükkanıDataSet sinema_dükkanıDataSet;
        private sinema_dükkanıDataSetTableAdapters.satıslarTableAdapter satıslarTableAdapter;
    }
}