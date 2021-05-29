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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void filmlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmfilm fm = new frmfilm();
            
            fm.Show();
            this.Hide();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

          
        }

        private void oyuncularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmoyuncucs fmo = new Frmoyuncucs();
          
            fmo.Show();
            this.Hide();

           
        }

        private void müsterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmyönetmen fmy = new Frmyönetmen();
           
            fmy.Show();
            this.Hide();
           
        }

        private void satışlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmtürler fmt = new Frmtürler();
          
            fmt.Show();
            this.Hide();
          
        }

        private void türlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmmüsteri fmm = new Fmmüsteri();
       
            fmm.Show();
            this.Hide();
           
        }

        private void yönetmenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmsatıslar fms = new Fmsatıslar();
            
            fms.Show();
            this.Hide();
          
        }

        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmrapor fmr = new Fmrapor();
         
            fmr.Show();
            this.Hide();
           
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmhakkımızdacs fmh = new Fmhakkımızdacs();
         
            fmh.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Çıkmak İstediğinizden Eminmisiniz?", "Çıkış Mesajı", MessageBoxButtons.YesNo);
            Application.Exit();
        }
    }
}
