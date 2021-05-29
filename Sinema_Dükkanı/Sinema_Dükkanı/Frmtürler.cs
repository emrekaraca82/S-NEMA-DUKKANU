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
    public partial class Frmtürler : Form
    {
        public Frmtürler()
        {
            InitializeComponent();
        }
        sinema_dükkanıEntities1 ctx = new sinema_dükkanıEntities1();
        private void Frmtürler_Load(object sender, EventArgs e)
        {
            dataGridViewtürler.DataSource = ctx.türler.ToList();
        }

      

        private void Btngeri_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }

        private void Btnekle_Click(object sender, EventArgs e)
        {
            türler t = new türler();
            t.türad = txtad.Text;

            ctx.türler.Add(t);
            ctx.SaveChanges();
            dataGridViewtürler.DataSource = ctx.türler.ToList();
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewtürler.CurrentRow.Cells["türid"].Value;
            türler t = ctx.türler.FirstOrDefault(x => x.türid == id);

            ctx.türler.Remove(t);
            ctx.SaveChanges();
            dataGridViewtürler.DataSource = ctx.türler.ToList(); 
        }

        private void dataGridViewtürler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewtürler.CurrentRow;

            txtad.Tag = row.Cells["türid"].Value;
            txtad.Text = row.Cells["türad"].Value.ToString();
        }

        private void Btngün_Click(object sender, EventArgs e)
        {
            int id = (int)txtad.Tag;
            türler t = ctx.türler.FirstOrDefault(x => x.türid == id);
            t.türad = txtad.Text;

            ctx.SaveChanges();
            dataGridViewtürler.DataSource = ctx.türler.ToList();
        }

        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtarama.Text;
            var türara = from t in ctx.türler
                          where t.türad.Contains(aranan)
                          select t;
            dataGridViewtürler.DataSource = türara.ToList();
        }
    }
}
