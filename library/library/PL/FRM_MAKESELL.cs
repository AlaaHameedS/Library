using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace library.PL
{
    public partial class FRM_MAKESELL: Form
    {
        public int ID;
        public FRM_MAKESELL()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void FRM_ADDBOOK_Load(object sender, EventArgs e)
        {
            BL.CLS_SELL BLSELL = new BL.CLS_SELL();
            DataTable dt1 = new DataTable();
            dt1 = BLSELL.LOADBOOK();
            DGVBOOK.DataSource = dt1;
            DataTable dt2 = new DataTable();
            dt2 = BLSELL.LOADSTUDENT();
            DGVST.DataSource = dt2;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text == string.Empty)
            {
                PL.FRM_DERORR PLERROR = new FRM_DERORR();
                PLERROR.Show();
            }
            else
            {
                if (ID == 0)
                { // ADD BOOK



                    BL.CLS_SELL BLSELL = new BL.CLS_SELL();

                    BLSELL.Insert(Convert.ToString(DGVST.CurrentRow.Cells[1].Value), Convert.ToString(DGVBOOK.CurrentRow.Cells[1].Value), Convert.ToInt16(txtPrice.Text), txtDateTime.Value);
                    PL.FRM_DADD FADD = new FRM_DADD();
                    FADD.Show();
                    this.Close();
                }

                else
                {
                    BL.CLS_SELL BLSELL = new BL.CLS_SELL();

                    BLSELL.EDITE(Convert.ToString(DGVST.CurrentRow.Cells[1].Value), Convert.ToString(DGVBOOK.CurrentRow.Cells[1].Value), Convert.ToInt16(txtPrice.Text), txtDateTime.Value,ID);
                    PL.FRM_DEDITE FEDITE = new FRM_DEDITE();
                    FEDITE.Show();
                    this.Close();
                }
            }
        }

        private void DGVST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
