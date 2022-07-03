using System;
using System.Collections.Generic;

namespace APL
{
    public class pengguna : keuangan
    {
        private List<keuangan> dataKeuangan;
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string username { get; set; }
        private string password { get; set; }
        private string email { get; set; }
        private static string foundEmail { get; set; }
        private static string foundPassword { get; set; }
        
        private static int countUser;

        public MainForm mainForm { get; set; }

        public static void sendLoginedUser(string inEmail)
        {
            MainForm.loginedUser = inEmail;
        }

        public pengguna(String firstName, String lastName, String username, String password, String email,
            List<keuangan> listKeuangan) : base(0, 0, 0)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.password = password;
            this.email = email;
            dataKeuangan = listKeuangan;
        }

        //array of pengguna
        static pengguna[] user = new pengguna[100];

        static pengguna()
        {
            user[0] = new pengguna("Marin", "Kitagawa", "marinktgw", "mari123", "marin@gmail.com",
                new List<keuangan>());
            user[1] = new pengguna("Albedo", "Redfall", "albedo", "albedo123", "albedo@gmail.com",
                new List<keuangan>());
            addKeuangan(data1, 0);
            addKeuangan(data2, 1);
        }
        
        //add New User
        public static void addUser(String firstName, String lastName, String username, String password, String email)
        {
            int i = 0;
            while (user[i] != null)
            {
                i++;
                countUser = 0+i;
            }

            user[i] = new pengguna(firstName, lastName, username, password, email, new List<keuangan>());
        }
        
        //getCount User
        public static int getCount()
        {
            return countUser;
        }
        
        
        //add keuangan to array of pengguna
        public static void addKeuangan(keuangan keuangan, int index)
        {
            user[index].dataKeuangan.Add(keuangan);
        }

        static keuangan data1 = new keuangan(10000, 0, 0);
        static keuangan data2 = new keuangan(20000, 0, 0);

        public static string verifEmail(string inEmail)
        {
            int i = 0;
            while (i < user.Length)
            {
                if (user[i].email == inEmail)
                {
                    foundEmail = user[i].email;
                    sendLoginedUser(foundEmail);
                    return foundEmail;
                }

                i++;
            }

            return null;
        }

        public static string verifPassword(string inPassword)
        {
            int i = 0;
            while (i < user.Length)
            {
                if (user[i].password == inPassword)
                {
                    foundPassword = user[i].password;
                    return foundPassword;
                }

                i++;
            }

            return null;
        }

        public static string getUsername(string inEmail)
        {
            int i = 0;
            while (i < user.Length)
            {
                if (user[i].email == inEmail)
                {
                    return user[i].username;
                }

                i++;
            }

            return null;
        }

        public static string getFullName(string inEmail)
        {
            int i = 0;
            string foundFullName = "";
            while (i < user.Length)
            {
                if (user[i].email == inEmail)
                {
                    foundFullName = user[i].firstName + " " + user[i].lastName;
                    return foundFullName;
                }

                i++;
            }

            return null;
        }

        public static string getEmail(string inEmail)
        {
            int i = 0;
            string foundEmail1 = "";
            while (i < user.Length)
            {
                if (user[i].email == inEmail)
                {
                    foundEmail1 = user[i].email;
                    return foundEmail1;
                }

                i++;
            }

            return null;
        }

        public static string getSaldo(string inEmail)
        {
            int i = 0;
            while (i < user.Length)
            {
                if (user[i].email == inEmail)
                {
                    return user[i].dataKeuangan[0].getSaldo();
                }

                i++;
            }

            return "0";
        }
        
        public static string setSaldo(string inEmail, string inSaldo)
        {
            int i = 0;
            while (i < user.Length)
            {
                if (user[i].email == inEmail)
                {
                    user[i].dataKeuangan[0].setSaldo(inSaldo);
                    return user[i].dataKeuangan[0].getSaldo();
                }

                i++;
            }

            return "0";
        }

        public static string getPemasukan(string loginedUser)
        {
            int i = 0;
            while (i < user.Length)
            {
                if (user[i].email == loginedUser)
                {
                    return user[i].dataKeuangan[0].getPemasukan();
                }
                i++;
            }
            return null;
        }

        public static string setPemasukan(string loginedUser, string inSaldo)
        {
            int i = 0;
            while (i < user.Length)
            {
                if (user[i].email == loginedUser)
                {
                    return user[i].dataKeuangan[0].setPemasukan(inSaldo);
                }
                i++;
            }
            return null;
        }
        
        public static string setPengeluaran(string loginedUser, string inSaldo)
        {
            int i = 0;
            while (i < user.Length)
            {
                if (user[i].email == loginedUser)
                {
                    return user[i].dataKeuangan[0].setPengeluaran(inSaldo);
                }
                i++;
            }
            return null;
        }

        public static string getPengeluaran(string loginedUser)
        {
            int i = 0;
            while (i < user.Length)
            {
                if (user[i].email == loginedUser)
                {
                    return (string) user[i].dataKeuangan[0].getPengeluaran();
                }
                i++;
            }
            return null;
        }
    }
}   