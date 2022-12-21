using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeHastane
{
    internal class Hasta
    {
        private int Hastaid;
        private string HastaAd;
        private string HastaSoyad;
        private int HastaTC;
        private int HastaTelefon;
        private string HastaSifre;
        private string HastaCinsiyet;

        public Hasta(int hastaid, string hastaAd, string hastaSoyad, int hastaTC, int hastaTelefon, string hastaSifre,string hastaCinsiyet)
        {
            this.Hastaid = hastaid;
            this.HastaAd = hastaAd;
            this.HastaSoyad = hastaSoyad;
            this.HastaTC = hastaTC;
            this.HastaTelefon = hastaTelefon;
            this.HastaSifre = hastaSifre;
            this.HastaCinsiyet = hastaCinsiyet;
        }
        public void setHastaid(int hastaid)
        {
            this.Hastaid = hastaid;
        }
        public int getHastaid()
        {
            return this.Hastaid;
        }
        public void setHastaAd(string hastaAd)
        {
            this.HastaAd = hastaAd;
        }
        public string getHastaAd()
        {
            return this.HastaAd;
        }
        public void setHastaSoyad(string hastaSoyad)
        {
            this.HastaSoyad = hastaSoyad;
        }
        public string getHastaSoyad()
        {
            return this.HastaSoyad;
        }
        public void setHastaTC(int hastaTC)
        {
            this.HastaTC = hastaTC;
        }
        public int getHastaTC()
        {
            return this.HastaTC;
        }
        public void setHastaTelefon(int hastaTelefon)
        {
            this.HastaTelefon = hastaTelefon;
        }
        public int getHastaTelefon()
        {
            return this.HastaTelefon;
        }
        public void setHastaSifre(string hastaSifre)
        {
            this.HastaAd = hastaSifre;
        }
        public string getHastaSifre()
        {
            return this.HastaAd;
        }
        public void setHastaCinsiyet(string hastaCinsiyet)
        {
            this.HastaAd = hastaCinsiyet;
        }
        public string getHastaCinsiyet()
        {
            return this.HastaAd;
        }

    }
}
