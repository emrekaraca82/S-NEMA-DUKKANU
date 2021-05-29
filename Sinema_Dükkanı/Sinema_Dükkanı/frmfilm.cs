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
    public partial class frmfilm : Form
    {
        sinema_dükkanıEntities1 ctx = new sinema_dükkanıEntities1();
        public frmfilm()
        {
            InitializeComponent();
        }

        private void Btngeri_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }

        private void frmfilm_Load(object sender, EventArgs e)
        {
            dataGridViewFilm.DataSource = ctx.filmlers.ToList();
           
            cmbyönetmen.DataSource = ctx.yöntemenler.ToList();
            cmbyönetmen.DisplayMember = "adsoyad";
            cmbyönetmen.ValueMember = "yönetmenid";
           
        }

        private void Btnekle_Click(object sender, EventArgs e)
        {
            filmler f = new filmler();
            f.filmad = txtadı.Text;
            f.konu = txtkonu.Text;
            f.yönetmenid = Convert.ToInt32(cmbyönetmen.SelectedValue);
            f.sure =Convert.ToInt32(txtsure.Text);
            f.vizyontarihi = Convert.ToDateTime(dttarih.Text);
            f.fiyat = Convert.ToDouble(txtfiyat.Text);
            f.stok = Convert.ToInt32(txtstok.Text);

            ctx.filmlers.Add(f);
            ctx.SaveChanges();
            dataGridViewFilm.DataSource = ctx.filmlers.ToList();

        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewFilm.CurrentRow.Cells["filmid"].Value;
           filmler f = ctx.filmlers.FirstOrDefault(x => x.filmid == id);

            ctx.filmlers.Remove(f);
            ctx.SaveChanges();
            dataGridViewFilm.DataSource = ctx.filmlers.ToList(); 
        }

        private void dataGridViewFilm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewFilm.CurrentRow;

            cmbyönetmen.Tag = row.Cells["filmid"].Value;
            cmbyönetmen.Text = row.Cells["yönetmenid"].Value.ToString();
            txtadı.Text = row.Cells["filmad"].Value.ToString();
            txtkonu.Text = row.Cells["konu"].Value.ToString();
            dttarih.Text = row.Cells["vizyontarihi"].Value.ToString();
            txtsure.Text = row.Cells["sure"].Value.ToString();
            txtfiyat.Text = row.Cells["fiyat"].Value.ToString();
            txtstok.Text = row.Cells["stok"].Value.ToString();

        }

        private void Btngün_Click(object sender, EventArgs e)
        {
            int id = (int)cmbyönetmen.Tag;
            filmler f = ctx.filmlers.FirstOrDefault(x => x.filmid == id);
            f.filmad = txtadı.Text;
            f.konu = txtkonu.Text;
            f.yönetmenid = Convert.ToInt32(cmbyönetmen.SelectedValue);
            f.sure =Convert.ToInt32(txtsure.Text);
            f.vizyontarihi = Convert.ToDateTime(dttarih.Text);
            f.fiyat = Convert.ToDouble(txtfiyat.Text);
            f.stok = Convert.ToInt32(txtstok.Text);

            ctx.SaveChanges();
           dataGridViewFilm.DataSource=ctx.filmlers.ToList();
        }

        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtarama.Text;
            var filmara = from f in ctx.filmlers
                          where f.filmad.Contains(aranan)
                          select f;
           dataGridViewFilm.DataSource = filmara.ToList();
        }
    }
}
