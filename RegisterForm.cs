using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace APL
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            //centerdisplay form 
            CenterToScreen();
            Text = "Aplikasi Pengatur Keuanganmu!";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false; //disable maximize button
            // load json
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string cfgjson = File.ReadAllText(path + "\\TugasBesar_Kelompok5/Config.json");
            string cfglangID =
                File.ReadAllText(path + "\\TugasBesar_Kelompok5/langID.json"); //lokasi cfg bahasa indonesia
            string cfglangEN =
                File.ReadAllText(path + "\\TugasBesar_Kelompok5/langEN.json"); //lokasi cfg bahasa inggris
            //deserialize json
            dynamic cfg = JsonConvert.DeserializeObject(cfgjson);
            dynamic langID = JsonConvert.DeserializeObject(cfglangID);
            dynamic langEN = JsonConvert.DeserializeObject(cfglangEN);
            //set label
            if (cfg.lang == "id")
            {
                label1.Text = langID.register.label_firstname;
                label2.Text = langID.register.label_lastname;
                label3.Text = langID.register.label_email;
                label4.Text = langID.register.label_password;
                label5.Text = langID.register.label_confirmpassword;
                button1.Text = langID.register.button_register;
                label6.Text = langID.register.label_register;
            }
            else
            {
                label1.Text = langEN.register.label_firstname;
                label2.Text = langEN.register.label_lastname;
                label3.Text = langEN.register.label_email;
                label4.Text = langEN.register.label_password;
                label5.Text = langEN.register.label_confirmpassword;
                button1.Text = langEN.register.button_register;
                label6.Text = langEN.register.label_register;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //username variable random
            try
            {
                string username = new Random().Next(1, 99999).ToString();
                if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 ||
                    textBox4.Text.Length == 0 || textBox5.Text.Length == 0)
                {
                    throw new Exception("Please fill all the fields!");
                }
                if (textBox4.Text != textBox5.Text)
                {
                    throw new Exception("Password doesn't match!");
                }
                pengguna.addUser(textBox1.Text, textBox2.Text, username, textBox4.Text, textBox3.Text);
                //add saldo -default
                keuangan data = new keuangan(0, 0, 0);
                int count = pengguna.getCount(); //count user yang ada
                Console.WriteLine(count);
                pengguna.addKeuangan(data, count); //menambahkan saldo default ke user terbaru
                MessageBox.Show("Register Success");
                Close();
                //show login form
                LoginForm login = new LoginForm();
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //hide
            textBox4.UseSystemPasswordChar = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //hide
            textBox5.UseSystemPasswordChar = true;
        }
    }
}