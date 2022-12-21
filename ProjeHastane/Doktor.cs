using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeHastane
{
    internal class Doktor
    {
        private int Doktorid;
        private string DoktorAd;
        private string DoktorSoyad;
        private Brans brans;
        private int DoktorTC;
        private string DoktorSifre;
        public Doktor(int doktorid, string doktorAd, string doktorSoyad, Brans brans, int doktorTC, string doktorSifre)
        {
            this.Doktorid = doktorid;
            this.DoktorAd = doktorAd;
            this.DoktorSoyad = doktorSoyad;
            this.brans = brans;
            this.DoktorTC = doktorTC;
            this.DoktorSifre = doktorSifre;
        }
        public void setDoktorid(int doktorid)
        {
            this.Doktorid = doktorid;
        }
        public int getDoktorid()
        {
            return this.Doktorid;
        }
        public void setDoktorAd(string doktorAd)
        {
            this.DoktorAd = doktorAd;
        }
        public string getDoktorAd()
        {
            return this.DoktorAd;
        }
        public void setDoktorSoyad(string doktorSoyad)
        {
            this.DoktorSoyad = doktorSoyad;
        }
        public string getDoktorSoyad()
        {
            return this.DoktorSoyad;
        }
        public void setDoktorTC(int doktorTC)
        {
            this.DoktorTC = doktorTC;
        }
        public int getDoktorTC()
        {
            return this.DoktorTC;
        }
        public void setDoktorSifre(string doktorSifre)
        {
            this.DoktorSifre = doktorSifre;
        }
        public string getDoktorSifre()
        {
            return this.DoktorSifre;
        }

    }
}
