using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul_panosu
{
    public partial class Yönetici : Form
    {
        public Yönetici()
        {
            InitializeComponent();
        }

        private void Yönetici_Load(object sender, EventArgs e)
        {
            
        }

        private void button_duyurular_Click(object sender, EventArgs e)
        {
            this.Hide();
            Duyurular form3 = new Duyurular();
            form3.ShowDialog();
            this.Show();
        }

        private void button_katlar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Katlar form4 = new Katlar();
            form4.ShowDialog();
            this.Show();
        }
    }
}
