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
    public partial class FRM_REPORT : Form
    {
        string state;
        int ID;
        // instance to CAT 
        BL.CLS_CAT BLCAT = new BL.CLS_CAT();

        // instance to book
        BL.CLS_BOOK BLBOOK = new BL.CLS_BOOK();

        // instance to student 
        BL.CLS_ST BLST = new BL.CLS_ST();

        // instance to sell 
        BL.CLS_SELL BLSELL = new BL.CLS_SELL();

        // instanc to BOR
        BL.CLS_BOR BLBOR = new BL.CLS_BOR();

        // instan to user
        BL.CLS_USER BLUSER = new BL.CLS_USER();
        public FRM_REPORT()
        {
            InitializeComponent();
        }

        private void FRM_REPORT_Load(object sender, EventArgs e)
        {
            FRM_MAIN home = new FRM_MAIN();
            lbl_Name.Text = home.lblName.Text;
            lbl_Prem.Text = home.lblPrem.Text;
            lblDate.Text = DateTime.Now.ToString();

            // for check number 
            // number books 
            try
            {
                // LOAD DATA BOOK
                DataTable dt = new DataTable();
                dt = BLBOOK.LOAD();
                lblBook.Text = dt.Rows.Count.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // number student
            try
            {
                // LOAD DATA ST
                DataTable dt = new DataTable();
                dt = BLST.LOAD();
                lblST.Text = dt.Rows.Count.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // nuber sell

            try
            {
                // LOAD DATA SELL
                DataTable dt = new DataTable();
                dt = BLSELL.LOAD();
                lblSell.Text = dt.Rows.Count.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // number BOR 
            try
            {
                // LOAD DATA BOOK
                DataTable dt = new DataTable();
                dt = BLBOR.LOAD();
                
                lblBor.Text = dt.Rows.Count.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            // number cat 

            try
            {

                // LOAD DATA CAT
                DataTable dt = new DataTable();
                dt = BLCAT.LOAD();
                lblCat.Text = dt.Rows.Count.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // number users 

            try
            {
                // LOAD DATA BOOK
                DataTable dt = new DataTable();
                dt = BLUSER.LOAD();
                lblUser.Text = dt.Rows.Count.ToString();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap image = new Bitmap(panel1.Width,panel1.Height);
            panel1.DrawToBitmap(image, new Rectangle(Point.Empty, panel1.Size));
            e.Graphics.DrawImage(image, 0, 0);
        }
    }
}
