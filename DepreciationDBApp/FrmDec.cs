using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepreciationDBApp.Forms
{
    public partial class FrmDec : Form
    {
        


        public FrmDec()
        {
            InitializeComponent();
        }

        private void btnActivo_Click(object sender, EventArgs e)
        {
            FrmAsset frmasset = new FrmAsset();


            this.Hide();


            frmasset.Show();





        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
                    }
    }
}
