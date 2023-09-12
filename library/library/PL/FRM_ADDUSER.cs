using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace library.PL
{
    public partial class FRM_ADDUSER : Form
    {
        public int ID;
        public FRM_ADDUSER()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTimer.Text = DateTime.Now.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtUserName.Text == string.Empty || txtPass.Text == string.Empty)
            {
                PL.FRM_DERORR FERORR = new FRM_DERORR();
                FERORR.Show();
            }
            else
            {
                if (ID == 0)
                { 



                    BL.CLS_USER BLUSER = new BL.CLS_USER();
                    BLUSER.Insert(txtName.Text,txtUserName.Text,txtPass.Text,txtCbo.Text,"False");
                    PL.FRM_DADD FADD = new FRM_DADD();
                    FADD.Show();
                    this.Close();
                }
                else
                {


                    BL.CLS_USER BLUSER = new BL.CLS_USER();
                    BLUSER.EDITE(txtName.Text, txtUserName.Text, txtPass.Text, txtCbo.Text,ID);
                    PL.FRM_DEDITE FADD = new FRM_DEDITE();
                    FADD.Show();
                    this.Close();
                }

            }
        }
    }
}
