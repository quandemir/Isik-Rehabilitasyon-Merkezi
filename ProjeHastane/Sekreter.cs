using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeHastane
{
    internal class Sekreter
    {
        private int Sekreterid;
        private string SekreterAdSoyad;
        private int SekreterTc;
        private string SekreterSifre;

        public Sekreter(int bransid, string sekreterAdSoyad, int sekreterTc, string sekreterSifre)
        {
            this.Sekreterid = bransid;
            this.SekreterAdSoyad = sekreterAdSoyad;
            this.SekreterTc = sekreterTc;
            this.SekreterSifre = sekreterSifre;
        }


        public void setSekreterid(int bransid)
        {
            this.Sekreterid = bransid;
        }
        public int getSekreterid()
        {
            return this.Sekreterid;
        }
        public void setSekreterAdSoyad(string sekreterAdSoyad)
        {
            this.SekreterAdSoyad = sekreterAdSoyad;
        }
        public string getSekreterAdSoyad()
        {
            return this.SekreterAdSoyad;
        }
        public void setSekreterTc(int sekreterTc)
        {
            this.SekreterTc = sekreterTc;
        }
        public int getSekreterTc()
        {
            return this.SekreterTc;
        }
        public void setSekreterSifre(string sekreterSifre)
        {
            this.SekreterSifre = sekreterSifre;
        }
        public string getSekreterSifre()
        {
            return this.SekreterSifre;
        }

    }
}
