using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeHastane
{
    internal class Randevu
    {
        private int Randevuid;
        private int RandevuTarih;
        private int RandevuSaat;
        private Brans RandevuBrans;
        private string RandevuDoktorAd;
        private int RandevuDurum; //default:0 bit
        private int HastaTc;

        public Randevu(int randevuid,int randevuTarih,int randevuSaat,Brans RandevuBrans,string randevuDoktorAd,int randevuDurum,int hastaTc)
        {
            this.Randevuid = randevuid;
            this.RandevuTarih = randevuTarih;
            this.RandevuSaat = randevuSaat;
            this.RandevuBrans = RandevuBrans;
            this.RandevuDoktorAd = randevuDoktorAd;
            this.RandevuDurum = randevuDurum;
            this.HastaTc = hastaTc;
        }
        public void setRandevuid(int randevuid)
        {
            this.Randevuid = randevuid;
        }
        public int getRandevuid()
        {
            return this.Randevuid;
        }
        public void setRandevuTarih(int randevuTarih)
        {
            this.RandevuTarih = randevuTarih;
        }
        public int getRandevuTarih()
        {
            return this.RandevuTarih;
        }
        public void setRandevuSaat(int randevuSaat)
        {
            this.RandevuSaat = randevuSaat;
        }
        public int getRandevuSaat()
        {
            return this.RandevuSaat;
        }
        public void setRandevuDoktorAd(string randevuDoktorAd)
        {
            this.RandevuDoktorAd = randevuDoktorAd;
        }
        public string getRandevuDoktorAd()
        {
            return this.RandevuDoktorAd;
        }
        public void setRandevuDurum(int randevuDurum)
        {
            this.RandevuDurum = randevuDurum;
        }
        public int getRandevuDurum()
        {
            return this.RandevuDurum;
        }
        public void setHastaTc(int hastaTc)
        {
            this.HastaTc = hastaTc;
        }
        public int getHastaTc()
        {
            return this.HastaTc;
        }
    }
}
