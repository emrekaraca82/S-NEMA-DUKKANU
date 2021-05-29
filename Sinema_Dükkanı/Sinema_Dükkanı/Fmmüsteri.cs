using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Dükkanı
{
    public partial class Fmmüsteri : Form
    {
        public Fmmüsteri()
        {
            InitializeComponent();
        }
        sinema_dükkanıEntities1 ctx = new sinema_dükkanıEntities1();

        private void Btngeri_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }

        private void Fmmüsteri_Load(object sender, EventArgs e)
        {
            dataGridViewmüsteri.DataSource = ctx.müsteriler.ToList();
        }

        private void Btnekle_Click(object sender, EventArgs e)
        {
            müsteriler m = new müsteriler();
            m.adsoyad = txtad.Text;
            m.tcno = txtcno.Text;
            m.adres = txtadres.Text;
            m.telefon = txttlf.Text;
            m.kayıttarihi = Convert.ToDateTime(dttarih.Text);

            ctx.müsteriler.Add(m);
            ctx.SaveChanges();
            dataGridViewmüsteri.DataSource = ctx.müsteriler.ToList();

        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
           
            int id = (int)dataGridViewmüsteri.CurrentRow.Cells["müsid"].Value;
            müsteriler m = ctx.müsteriler.FirstOrDefault(x => x.müsid == id);

            ctx.müsteriler.Remove(m);
            ctx.SaveChanges();
            dataGridViewmüsteri.DataSource = ctx.müsteriler.ToList(); ;
        }

        private void dataGridViewmüsteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewmüsteri.CurrentRow;
            txtad.Tag = row.Cells["müsid"].Value;
            txtad.Text = row.Cells["adsoyad"].Value.ToString();
            txtcno.Text = row.Cells["tcno"].Value.ToString();
            txtadres.Text= row.Cells["adres"].Value.ToString();
            txttlf.Text = row.Cells["telefon"].Value.ToString();
            dttarih.Text = row.Cells["kayıttarihi"].Value.ToString();
        
        }

        private void Btngun_Click(object sender, EventArgs e)
        {
            int id = (int)txtad.Tag;
            müsteriler m = ctx.müsteriler.FirstOrDefault(x => x.müsid == id);
            m.adsoyad = txtad.Text;
            m.tcno = txtcno.Text;
            m.adres = txtadres.Text;
            m.telefon = txttlf.Text;
            m.kayıttarihi = Convert.ToDateTime(dttarih.Text);

            ctx.SaveChanges();
            dataGridViewmüsteri.DataSource = ctx.müsteriler.ToList();
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtara.Text;
            var müsara = from m in ctx.müsteriler
                          where m.adsoyad.Contains(aranan)
                          select m;
            dataGridViewmüsteri.DataSource = müsara.ToList();
        }
    }
}
