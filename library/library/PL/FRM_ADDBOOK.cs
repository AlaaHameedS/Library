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
    public partial class FRM_ADDBOOK : Form
    {
        public int ID;
        public FRM_ADDBOOK()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtCover.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void FRM_ADDBOOK_Load(object sender, EventArgs e)
        {
            try
            {
                BL.CLS_BOOK BLBOOK = new BL.CLS_BOOK();
                DataTable dt = new DataTable();
                dt = BLBOOK.LOADCAT();
                object[] obj = new object[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    obj[i] = dt.Rows[i]["CAT_NAME"];
                }

                cboCAT.Items.AddRange(obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FRM_ADDCAT FCAT = new FRM_ADDCAT();
            FCAT.btnADD.ButtonText = "اضافة";
            FCAT.ID = 0;
            FCAT.Show();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {

            if (txtBookName.Text == string.Empty || txtAuthorName.Text == string.Empty || txtPrice.Text == string.Empty)
            {
                PL.FRM_DERORR FERORR = new FRM_DERORR();
                FERORR.Show();
            }
            else
            {
                if (ID == 0)
                { // ADD BOOK
                    MemoryStream ma = new MemoryStream();
                    txtCover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);


                    BL.CLS_BOOK BLBOOK = new BL.CLS_BOOK();
                    BLBOOK.Insert(txtBookName.Text, txtAuthorName.Text, cboCAT.Text, txtPrice.Text, txtDateTime.Value, txtRate.Value, ma);
                    PL.FRM_DADD FADD = new FRM_DADD();
                    FADD.Show();
                    this.Close();
                }
                else
                {
                    // update book 
                    MemoryStream ma = new MemoryStream();
                    txtCover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    Image image = Image.FromStream(ma);

                    BL.CLS_BOOK BLBOOK = new BL.CLS_BOOK();
                    BLBOOK.EDITE(txtBookName.Text, txtAuthorName.Text, cboCAT.Text, txtPrice.Text, txtDateTime.Value, txtRate.Value, ma,ID);
                    PL.FRM_DEDITE FADD = new FRM_DEDITE();
                    FADD.Show();
                    this.Close();
                }

            }
        }
    }
}
