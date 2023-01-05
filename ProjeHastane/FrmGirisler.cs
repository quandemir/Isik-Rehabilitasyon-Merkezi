using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeHastane
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            // hasta girişi için
            FrmHastaGiris fr = new FrmHastaGiris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //doktor girişi için
            FrmDoktorGiris fr=new FrmDoktorGiris();
            fr.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sekreter girşi için
            FrmSekreterGiris fr =new FrmSekreterGiris();
            fr.Show();
            this.Hide();
        }
    }
}
