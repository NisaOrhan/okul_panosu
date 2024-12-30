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
   
    public partial class Duyurular : Form
    {
        private DataTable duyuruTable;
        public Duyurular()
        {
            InitializeComponent();
            InitializeDataTable();
        }
        private void InitializeDataTable()
        {
            
            duyuruTable = new DataTable();
            duyuruTable.Columns.Add("ID", typeof(int));
            duyuruTable.Columns.Add("Baslik", typeof(string));
            duyuruTable.Columns.Add("Icerik", typeof(string));
            duyuruTable.Columns.Add("BaslangicTarihi", typeof(DateTime));
            duyuruTable.Columns.Add("BitisTarihi", typeof(DateTime));

            dataGridView1.DataSource = duyuruTable;
        }
        private void Duyurular_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'duyurularData.Duyurular' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.duyurularTableAdapter.Fill(this.duyurularData.Duyurular);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string baslik = Microsoft.VisualBasic.Interaction.InputBox("Duyuru Başlığı", "Başlık Girin");
            string icerik = Microsoft.VisualBasic.Interaction.InputBox("Duyuru İçeriği", "İçerik Girin");
            DateTime baslangicTarihi = DateTime.Now; 
            DateTime bitisTarihi = DateTime.Now.AddDays(1);   

             
            DataRow row = duyuruTable.NewRow();
            row["ID"] = duyuruTable.Rows.Count + 1;   
            row["Baslik"] = baslik;
            row["Icerik"] = icerik;
            row["BaslangicTarihi"] = baslangicTarihi;
            row["BitisTarihi"] = bitisTarihi;

            duyuruTable.Rows.Add(row);
        }
    }
}
