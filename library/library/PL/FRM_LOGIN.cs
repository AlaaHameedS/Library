using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace library.PL
{
    public partial class FRM_LOGIN : Form
    {
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                BL.CLS_USER BLUS = new BL.CLS_USER();
                DataTable dt = new DataTable();
                dt = BLUS.LOGIN(txtUser.Text, txtPss.Text);
                if (dt.Rows.Count > 0)
                {
                    BLUS.UPDATELOGIN(txtUser.Text, txtPss.Text);
                    PL.FRM_MAIN frmain = new FRM_MAIN();
                    object lbname = dt.Rows[0]["cname"];
                    object lbprem = dt.Rows[0]["cprem"];
                    frmain.lblName.Text = lbname.ToString();
                    frmain.lblPrem.Text = lbprem.ToString();
                    frmain.Show();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("خطأ في عملية تسجيل الدخول");
                MessageBox.Show(ex.Message);

            }
                
            
        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
