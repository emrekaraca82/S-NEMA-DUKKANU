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
    public partial class Fmsatıslar : Form
    {
        public Fmsatıslar()
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

        private void Fmsatıslar_Load(object sender, EventArgs e)
        {
            dataGridViewsatıs.DataSource = ctx.satıslar.ToList();

            cmbfilm.DataSource = ctx.filmlers.ToList();
            cmbfilm.DisplayMember = "filmad";
            cmbfilm.ValueMember = "filmid";

            cmbmusteri.DataSource = ctx.müsteriler.ToList();
            cmbmusteri.DisplayMember = "adsoyad";
            cmbmusteri.ValueMember = "müsid";
        }

        private void Btnekle_Click(object sender, EventArgs e)
        {
            int a;
            float b, c;

            a = Int32.Parse(txtadet.Text);
            b = float.Parse(txtfiyat.Text);
            c = a * b;
           txttutar.Text = c.ToString();

           satıslar sa = new satıslar();
           sa.müsid = Convert.ToInt32(cmbmusteri.SelectedValue);
           sa.filmid = Convert.ToInt32(cmbfilm.SelectedValue);
           sa.satıstarih = Convert.ToDateTime(dttarih.Text);
           sa.adet = Convert.ToInt32(txtadet.Text);
           sa.fiyat = Convert.ToDouble(txtfiyat.Text);
           sa.tutar = Convert.ToDouble(txttutar.Text);

           ctx.satıslar.Add(sa);
           ctx.SaveChanges();
           dataGridViewsatıs.DataSource = ctx.satıslar.ToList();
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {

        }
    }
}
