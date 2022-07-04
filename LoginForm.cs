using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace APL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            // Mengatur judul window.
            Text = "Aplikasi Pengatur Keuanganmu!";
            // Menginisisasikan dan mengatur ukuran dari window.
            Size = new Size(800, 600);
            // Memposisikan window/tampilan berada tengah layar saat dilakukan runing.
            StartPosition = FormStartPosition.CenterScreen; 
            checkBox1.Checked = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            // Disable maximize button.
            MaximizeBox = false; 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Membaca file konfigurasi.
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string cfgjson = File.ReadAllText(path + "\\TugasBesar_Kelompok5/Config.json");
            string cfglangID = File.ReadAllText(path + "\\TugasBesar_Kelompok5/langID.json");
            string cfglangEN = File.ReadAllText(path + "\\TugasBesar_Kelompok5/langEN.json");

            //Deserialisasi json menjadi objek.
            dynamic cfg = JsonConvert.DeserializeObject(cfgjson);
            dynamic langID = JsonConvert.DeserializeObject(cfglangID);
            dynamic langEN = JsonConvert.DeserializeObject(cfglangEN);
            //Penampung configuration.
            if (cfg.lang == "id")
            { 
                label1.Text = langID.login.label_email;
                label2.Text = langID.login.label_password;
                label3.Text = langID.login.label_login_first;
                label4.Text = langID.login.label_select_lang;
                button1.Text = langID.login.login_button;
                button2.Text = langID.login.swlang_button;
                checkBox1.Text = langID.login.hide_password;
                label5.Text = langID.login.label_register;
            }
            else
            {
                label1.Text = langEN.login.label_email;
                label2.Text = langEN.login.label_password;
                label3.Text = langEN.login.label_login_first;
                label4.Text = langEN.login.label_select_lang;
                button1.Text = langEN.login.login_button;
                button2.Text = langEN.login.swlang_button;
                checkBox1.Text = langEN.login.hide_password;
                label5.Text = langEN.login.label_register;
            }
        }
        public MainForm mainForm;

        //Button login.
        private void button1_Click(object sender, EventArgs e) 
        {
            if (textBox2.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Email atau Password tidak boleh kosong!");
            }
            //secure code for login
            if (textBox2.Text.Contains("*") || textBox2.Text.Contains("?") || textBox2.Text.Contains("!") ||
                textBox2.Text.Contains("#") || textBox2.Text.Contains("$") || textBox2.Text.Contains("%") || textBox2.Text.Contains("^") ||
                textBox2.Text.Contains("&") || textBox2.Text.Contains("(") || textBox2.Text.Contains(")") || textBox2.Text.Contains("-") ||
                textBox2.Text.Contains("_") || textBox2.Text.Contains("+") || textBox2.Text.Contains("=") || textBox2.Text.Contains("[") ||
                textBox2.Text.Contains("]") || textBox2.Text.Contains("{") || textBox2.Text.Contains("}") || textBox2.Text.Contains("|") ||
                textBox2.Text.Contains(";") || textBox2.Text.Contains(":") || textBox2.Text.Contains("'") || textBox2.Text.Contains("\"") ||
                textBox2.Text.Contains("`") || textBox2.Text.Contains("~") || textBox2.Text.Contains("<") || textBox2.Text.Contains(">") ||
                textBox2.Text.Contains("?") || textBox2.Text.Contains("/..") || textBox2.Text.Contains("..\\"))
            {
                MessageBox.Show("Login Failed (Email not secure)");
            }
            try
            {
                if (textBox2.Text == pengguna.verifEmail(textBox2.Text) && textBox1.Text == pengguna.verifPassword(textBox1.Text))
                {
                    var ResultCheck_True = "Login Success";
                    MessageBox.Show(ResultCheck_True);
                    Hide();
                    MainForm main = new MainForm();
                    main.Show();
                }
            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button2_Click(object sender, EventArgs e) //ubah bahasa
        {
            //serealize json to change lang
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string cfgjson = File.ReadAllText(path + "\\TugasBesar_Kelompok5/Config.json");
            dynamic cfg = JsonConvert.DeserializeObject(cfgjson);
            if (cfg.lang == "id")
            {
                cfg.lang = "en";
                string cfgjsonnew = JsonConvert.SerializeObject(cfg);
                File.WriteAllText(path + "\\TugasBesar_Kelompok5/Config.json", cfgjsonnew);
            }
            else
            {
                cfg.lang = "id";
                string cfgjsonnew = JsonConvert.SerializeObject(cfg);
                File.WriteAllText(path + "\\TugasBesar_Kelompok5/Config.json", cfgjsonnew);
            }
            //reload form with new lang
            MessageBox.Show("Succesfully changed language!");
            Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        //Link to RegisterForm
        private void label5_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm register = new RegisterForm();
            register.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //texbox2 - password

        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textbox1 - email             
        }
        
        //Checkbox - show password
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.UseSystemPasswordChar = true;
            }
            else
            {
                textBox1.UseSystemPasswordChar = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}