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
    public partial class Frmyönetmen : Form
    {
        public Frmyönetmen()
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

        private void Frmyönetmen_Load(object sender, EventArgs e)
        {
            dataGridViewYöntemen.DataSource = ctx.yöntemenler.ToList(); 
        }

        private void Btnekle_Click(object sender, EventArgs e)
        {
            yöntemenler y = new yöntemenler();
            y.adsoyad = txtad.Text;

            ctx.yöntemenler.Add(y);
            ctx.SaveChanges();
            dataGridViewYöntemen.DataSource = ctx.yöntemenler.ToList();
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewYöntemen.CurrentRow.Cells["yönetmenid"].Value;
            yöntemenler y = ctx.yöntemenler.FirstOrDefault(x => x.yönetmenid == id);

            ctx.yöntemenler.Remove(y);
            ctx.SaveChanges();
            dataGridViewYöntemen.DataSource = ctx.yöntemenler.ToList();
        }

        private void dataGridViewYöntemen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewYöntemen.CurrentRow;

            txtad.Tag = row.Cells["yönetmenid"].Value;
            txtad.Text = row.Cells["adsoyad"].Value.ToString();
        }

        private void Btngün_Click(object sender, EventArgs e)
        {
            int id = (int)txtad.Tag;
            yöntemenler y = ctx.yöntemenler.FirstOrDefault(x => x.yönetmenid == id);
            y.adsoyad = txtad.Text;

            ctx.SaveChanges();
            dataGridViewYöntemen.DataSource=ctx.yöntemenler.ToList();

        }

        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtarama.Text;
            var yontemenara = from y in ctx.yöntemenler
                          where y.adsoyad.Contains(aranan)
                          select y;
            dataGridViewYöntemen.DataSource= yontemenara.ToList();
        }
    }
}
