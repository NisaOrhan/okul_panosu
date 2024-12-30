using System;
using System.Drawing;
using System.Windows.Forms;

namespace Okul_panosu
{
    public partial class kullanici : Form
    {
        public kullanici()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Left(object sender, EventArgs e)
        {

        }

        private void MouseLeave(object sender, EventArgs e)
        {

        }

        private void kullanici_Load(object sender, EventArgs e)
        {
            textBox1_kullanici.Text = "Kullanıcı Adı";
            textBox1_kullanici.ForeColor = Color.Gray; 

            textBox_sifre.Text = "Şifre";
            textBox_sifre.ForeColor = Color.Gray; 
            textBox_sifre.UseSystemPasswordChar = false;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1_kullanici.Text == "nisa" && textBox_sifre.Text == "1908")
           {
               this.Hide();
               Yönetici form2 = new Yönetici();
              form2.ShowDialog();
              this.Show();
            }
           else
            {
               MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
            
        }

        private void textBox1_kullanici_Enter(object sender, EventArgs e)
        {
            if (textBox1_kullanici.Text == "Kullanıcı Adı")
            {
                textBox1_kullanici.Text = "";
                textBox1_kullanici.ForeColor = Color.Black; 
            }
        }

        private void textBox1_kullanici_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1_kullanici.Text))
            {
                textBox1_kullanici.Text = "Kullanıcı Adı";
                textBox1_kullanici.ForeColor = Color.Gray; 
            }
        }

        private void textBox_sifre_Enter(object sender, EventArgs e)
        {
            if (textBox_sifre.Text == "Şifre")
            {
                textBox_sifre.Text = "";
                textBox_sifre.ForeColor = Color.Black;
                textBox_sifre.UseSystemPasswordChar = true;  
            }
        }

        private void textBox_sifre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_sifre.Text))
            {
                textBox_sifre.Text = "Şifre";
                textBox_sifre.ForeColor = Color.Gray;   
                textBox_sifre.UseSystemPasswordChar = false;  
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Şifre sıfırlama bağlantısı gönderildi.");

        }
    }
}
