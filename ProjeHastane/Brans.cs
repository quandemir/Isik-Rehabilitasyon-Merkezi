using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeHastane
{
    internal class Brans
    {
        private int Bransid;
        private string BransAd;

        public Brans(int bransid, string bransAd)
        {
            this.Bransid = bransid;
            this.BransAd = bransAd;
        }
        //private string Bransid; // field

        //public string Brans_id   // property
        //{
        //    get { return Bransid; }   // get method
        //    set { Bransid = value; }  // set method
        //}
        public void setBransid(int bransid)
        {
            this.Bransid = bransid;
        }
        public int getBransid()
        {
            return this.Bransid;
        }
        public void setBransAd(string bransAd)
        {
            this.BransAd = bransAd;
        }
        public string getBransAd()
        {
            return this.BransAd;
        }


    }
}
