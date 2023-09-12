using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace library.PL
{
    public partial class FRM_START : Form
    {
        public FRM_START()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BL.CLS_USER BLUS = new BL.CLS_USER();
            DataTable dt = new DataTable();
            dt = BLUS.STARTLOAD();
            if(dt.Rows.Count>0)
            {
                PL.FRM_MAIN frmain = new FRM_MAIN();
                object lbname = dt.Rows[0]["cname"];
                object lbprem = dt.Rows[0]["cprem"];
                frmain.lblName.Text = lbname.ToString();
                frmain.lblPrem.Text = lbprem.ToString();
                frmain.Show();
                this.Hide();
                timer1.Enabled = false;
            }
            else
            {
                PL.FRM_LOGIN PLLOG = new FRM_LOGIN();
                PLLOG.Show();
                this.Hide();
                timer1.Enabled = false;
            }
        }
    }
}
