using System;

namespace TransaksiLibrary
{
    public class TransaksiUser
    {
        public static int TambahSaldo(int saldoAwal, int penambahanSaldo) 
        {
            return saldoAwal + penambahanSaldo;
        }

        public static int AmbilSaldo (int saldo, int ambil)
        {
            return saldo - ambil;
        }

    }
}
