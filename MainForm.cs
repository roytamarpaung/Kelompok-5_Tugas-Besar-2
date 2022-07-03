using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace APL
{
    public partial class MainForm : Form
    {
        public static LoginForm LoginForm { get; set; }
        public static pengguna user { get; set; }

        public static string loginedUser;

        public MainForm()
        {
            InitializeComponent();
            //title window
            Text = "Aplikasi Pengatur Keuanganmu!";
            // ukuran window
            Size = new Size(800, 600);
            StartPosition = FormStartPosition.CenterScreen; // posisi window di tengah layar
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false; //disable maximize button
            //info login
            label1.Text = pengguna.getUsername(loginedUser);
            label2.Text = pengguna.getFullName(loginedUser);
            label3.Text = pengguna.getEmail(loginedUser);
            label10.Text = pengguna.getSaldo(loginedUser);
            label11.Text = pengguna.getPengeluaran(loginedUser);
            label12.Text = pengguna.getPemasukan(loginedUser);
            //parsing configurasi dari file json
            if (cfg.lang == "id")
            {
                groupBox1.Text = langID.main.label_user_info;
                label4.Text = langID.main.label_user_name;
                label5.Text = langID.main.label_fullname;
                label6.Text = langID.main.label_user_email;
                groupBox2.Text = langID.main.label_user_balance;
                label7.Text = langID.main.label_saldo;
                label8.Text = langID.main.label_pengeluaran;
                label9.Text = langID.main.label_pemasukan;
                label13.Text = langID.main.label_withdraw;
                label14.Text = langID.main.label_deposit;
                button1.Text = langID.main.topup_button;
                button2.Text = langID.main.withdraw_button;
                button3.Text = langID.main.logout_button;
            }
            else
            {
                groupBox1.Text = langEN.main.label_user_info;
                label4.Text = langEN.main.label_user_name;
                label5.Text = langEN.main.label_fullname;
                label6.Text = langEN.main.label_user_email;
                groupBox2.Text = langEN.main.label_user_balance;
                label7.Text = langEN.main.label_saldo;
                label8.Text = langEN.main.label_pengeluaran;
                label9.Text = langEN.main.label_pemasukan;
                label13.Text = langEN.main.label_withdraw;
                label14.Text = langEN.main.label_deposit;
                button1.Text = langEN.main.topup_button;
                button2.Text = langEN.main.withdraw_button;
                button3.Text = langEN.main.logout_button;
            }
        }

        // load json
        static string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        static string cfgjson = File.ReadAllText(path + "\\TugasBesar_Kelompok5/Config.json");
        static string cfglangID = File.ReadAllText(path + "\\TugasBesar_Kelompok5/langID.json"); //lokasi cfg bahasa indonesia
        static string cfglangEN = File.ReadAllText(path + "\\TugasBesar_Kelompok5/langEN.json"); //lokasi cfg bahasa inggris
        //deserialize json
        dynamic cfg = JsonConvert.DeserializeObject(cfgjson);
        dynamic langID = JsonConvert.DeserializeObject(cfglangID);
        dynamic langEN = JsonConvert.DeserializeObject(cfglangEN);

        private void label4_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e) //deposit saldo
        {
            var inputDeposit = Convert.ToInt32(textBox1.Text);
            var saldo = Convert.ToInt32(label10.Text);
            var pemasukan = Convert.ToInt32(pengguna.getPemasukan(loginedUser));
            //design by contract
            try
            {
                if (inputDeposit < 9999 || inputDeposit == 0)
                {
                    throw new Exception("Minimum deposit is Rp. 10.000, and can't be empty");
                }
            }
            catch (Exception ex)
            {
                //change input to null
                inputDeposit = 0;
                MessageBox.Show(ex.Message);
            }
            //calculate
            var newPemasukan = Count.Math.pertambahan(pemasukan, inputDeposit);
            var newSaldo = Count.Math.pertambahan(saldo,inputDeposit);
            //update saldo
            pengguna.setSaldo(loginedUser, newSaldo.ToString());
            //update pemasukan
            pengguna.setPemasukan(loginedUser, Convert.ToString(newPemasukan));
            MessageBox.Show("Saldo anda telah ditambahkan sebesar " + inputDeposit + ".");
            //refresh saldo dan pemasukan
            label10.Text = pengguna.getSaldo(loginedUser);
            label12.Text = pengguna.getPemasukan(loginedUser);
            //clear textbox1.text
            textBox1.Text = "";
        }
        
        private void button2_Click(object sender, EventArgs e) //withdraw saldo
        {
            var inputWithdraw = Convert.ToInt32(textBox2.Text);
            var saldo = Convert.ToInt32(label10.Text);
            var pengeluaran = Convert.ToInt32(pengguna.getPengeluaran(loginedUser));
            //design by contract
            try
            {
                if (inputWithdraw < 9999 || inputWithdraw == 0)
                {
                    throw new Exception("Minimum withdraw is Rp. 10.000, and can't be empty");
                }
            }
            catch (Exception ex)
            {
                inputWithdraw = 0;
                MessageBox.Show(ex.Message);
            }
            //calculate
            var newPengeluaran = Count.Math.pertambahan(pengeluaran, inputWithdraw);
            var newSaldo = Convert.ToString(Count.Math.pengurangan(saldo, inputWithdraw));
            //update saldo
            pengguna.setSaldo(loginedUser, newSaldo);
            //update pengeluaran
            pengguna.setPengeluaran(loginedUser, Convert.ToString(newPengeluaran));
            MessageBox.Show("Saldo anda telah dikurangi sebesar " + inputWithdraw + ".");
            //refresh saldo dan pengeluaran
            label10.Text = pengguna.getSaldo(loginedUser);
            label11.Text = pengguna.getPengeluaran(loginedUser);
            //clear textbox2.text
            textBox2.Text = "";
        }

        private void label14_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            //ini textbox deposit
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            //ini textbox withdraw
        }

        private void label11_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e) // logout
        {
            MessageBox.Show("You have successfully logged out.");
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}