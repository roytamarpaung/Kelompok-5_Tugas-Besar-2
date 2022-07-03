namespace APL
{
    public class keuangan
    {
        private int saldo;
        private int pengeluaran;
        private int pemasukan;
        
        public keuangan(int inSaldo, int inPengeluaran, int inPemasukan)
        {
            saldo = inSaldo;
            pengeluaran = inPengeluaran;
            pemasukan = inPemasukan;
        }

        public string getSaldo()
        {
            return saldo.ToString();
        }

        public void setSaldo(string inSaldo)
        {
            saldo = int.Parse(inSaldo);
        }
        public string getPemasukan()
        {
            return pemasukan.ToString();
        }

        public string setPemasukan(string inSaldo)
        {
            return (pemasukan = int.Parse(inSaldo)).ToString();
        }

        public object getPengeluaran()
        {
            return pengeluaran.ToString();
        }

        public string setPengeluaran(string outSaldo)
        {
            return (pengeluaran = int.Parse(outSaldo)).ToString();
        }
    }
}