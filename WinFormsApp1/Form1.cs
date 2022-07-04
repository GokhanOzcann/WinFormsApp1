using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
            sifre.PasswordChar = '*';
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kadi.Text == "mehmet" && sifre.Text == "1234")
            {
                MessageBox.Show("Gİriş Başarılı");
                Form2 f2 = new Form2();
                f2.Show();
            }
            else if (kadi.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı giriniz.");
            }
            
            else if (sifre.Text == "")
            {
                MessageBox.Show("Şifre giriniz");
            }
            else
            {
                MessageBox.Show("Giriş Hatalı");
            }
        }
    }
}
