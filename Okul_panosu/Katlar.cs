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
    public partial class Katlar : Form
    {
        private DataTable katlarTable;
      
        public Katlar()
        {
            InitializeComponent();
            ////InitializeKatlarTable();
           

        }
        private void InitializeKatlarTable()
        {
            //katlarTable = new DataTable();
            //katlarTable.Columns.Add("KatID", typeof(int));
            //katlarTable.Columns.Add("KatAdi", typeof(string));

            //dataGridView1.DataSource = katlarTable;

        }
        private void Katlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'okulPanoDataSet.Katlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            
            this.katlarTableAdapter.Fill(this.okulPanoDataSet.Katlar);

        



        }
        private void LoadKatlarFromDatabase()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataRow yeniKat = okulPanoDataSet.Katlar.NewRow();
            yeniKat["KatAdi"] = "Yeni Kat"; // Varsayılan bir isim, burayı değiştirebilirsiniz  
            okulPanoDataSet.Katlar.Rows.Add(yeniKat);
            katlarTableAdapter.Update(okulPanoDataSet.Katlar);
            katlarTableAdapter.Fill(okulPanoDataSet.Katlar);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int katID = Convert.ToInt32(selectedRow.Cells[0].Value);

                DataRow katRow = okulPanoDataSet.Katlar.FindByKatID(katID);
                if (katRow != null)
                {
                    katRow["KatAdi"] = "Güncellenmiş Kat"; // Burayı istediğiniz isimle değiştirin  
                    katlarTableAdapter.Update(okulPanoDataSet.Katlar);
                    katlarTableAdapter.Fill(okulPanoDataSet.Katlar);
                }
            }
            else
            {
                MessageBox.Show("Güncellemek için bir kat seçin.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //    {

            //        dataGridView1.Rows.RemoveAt(row.Index);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Silmek için bir kat seçin.");
            //}
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //  DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            //   DataRow row = ((DataRowView)selectedRow.DataBoundItem).Row;
            //   row.Delete(); // Seçili satırı sil  

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int katID = Convert.ToInt32(selectedRow.Cells[0].Value);

                DataRow katRow = okulPanoDataSet.Katlar.FindByKatID(katID);
                if (katRow != null)
                {
                    katRow.Delete();
                    katlarTableAdapter.Update(okulPanoDataSet.Katlar);
                    katlarTableAdapter.Fill(okulPanoDataSet.Katlar);
                }
            }
            else
            {
                MessageBox.Show("Silmek için bir kat seçin.");
            }

        }
    }
}
