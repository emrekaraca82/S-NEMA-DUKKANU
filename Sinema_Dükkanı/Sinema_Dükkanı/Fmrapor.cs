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
    public partial class Fmrapor : Form
    {
        public Fmrapor()
        {
            InitializeComponent();
        }

        private void Fmrapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinema_dükkanıDataSet.satıslar' table. You can move, or remove it, as needed.
            this.satıslarTableAdapter.Fill(this.sinema_dükkanıDataSet.satıslar);

            this.reportViewer1.RefreshReport();
        }
    }
}
