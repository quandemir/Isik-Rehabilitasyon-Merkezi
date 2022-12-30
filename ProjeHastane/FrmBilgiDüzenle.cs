using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ProjeHastane
{
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }
        public string Tcno;
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = Tcno;
        }
    }
}
