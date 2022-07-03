namespace APL
{
    public class keuangan
    {
        private int saldo;
        private int pengeluaran;
        private int pemasukan;
        
        //constructor
        public keuangan(int inSaldo, int inPengeluaran, int inPemasukan)
        {
            saldo = inSaldo;
            pengeluaran = inPengeluaran;
            pemasukan = inPemasukan;
        }

        //get saldo return to string
        public string getSaldo()
        {
            return saldo.ToString();
        }

        public void setSaldo(string inSaldo)
        {
            saldo = int.Parse(inSaldo);
        }

        public string setPemasukan(string inSaldo)
        {
            return (pemasukan = int.Parse(inSaldo)).ToString();
        }

        public string getPemasukan()
        {
            return pemasukan.ToString();
        }

        public object getPengeluaran()
        {
            return pengeluaran.ToString();
        }

        public string setPengeluaran(string toString)
        {
            return (pengeluaran = int.Parse(toString)).ToString();
        }
    }
}