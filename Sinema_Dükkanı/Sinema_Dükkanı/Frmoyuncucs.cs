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
    public partial class Frmoyuncucs : Form
    {
        public Frmoyuncucs()
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

        private void Btnekle_Click(object sender, EventArgs e)
        {
            oyuncular o = new oyuncular();
            o.adısoyadı = txtad.Text;
            o.dogumtarihi = Convert.ToDateTime(dttarih.Text);
            o.memleket = txtmemleket.Text;

            ctx.oyunculars.Add(o);
            ctx.SaveChanges();
            dataGridViewoyuncu.DataSource = ctx.oyunculars.ToList();
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
          
            int id=(int)dataGridViewoyuncu.CurrentRow.Cells["oyuncuid"].Value;
            oyuncular o = ctx.oyunculars.FirstOrDefault(x => x.oyuncuid == id);

            ctx.oyunculars.Remove(o);
            ctx.SaveChanges();
            dataGridViewoyuncu.DataSource = ctx.oyunculars.ToList();

        }

        private void dataGridViewoyuncu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewoyuncu.CurrentRow;

            txtad.Tag = row.Cells["oyuncuid"].Value;
            txtad.Text = row.Cells["adısoyadı"].Value.ToString();
            dttarih.Text = row.Cells["dogumtarihi"].Value.ToString();
            txtmemleket.Text = row.Cells["memleket"].Value.ToString();

        }

        private void Btngün_Click(object sender, EventArgs e)
        {
            int id = (int)txtad.Tag;
            oyuncular o = ctx.oyunculars.FirstOrDefault(x => x.oyuncuid == id);
            o.adısoyadı = txtad.Text;
            o.dogumtarihi = Convert.ToDateTime(dttarih.Text);
            o.memleket = txtmemleket.Text;

            ctx.SaveChanges();
            ctx.oyunculars.ToList();
        }

        private void txtmemleket_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtara.Text;
            var oyuncuara = from o in ctx.oyunculars
                          where o.adısoyadı.Contains(aranan)
                          select o;
            dataGridViewoyuncu.DataSource = ctx.oyunculars.ToList();
        }

        private void Frmoyuncucs_Load(object sender, EventArgs e)
        {
            dataGridViewoyuncu.DataSource = ctx.oyunculars.ToList();
        }

        private void dataGridViewoyuncu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
