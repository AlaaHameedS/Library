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
    public partial class FRM_ADDSELL: Form
    {
        public int ID;
        public FRM_ADDSELL()
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

            if (txtStudentName.Text == string.Empty || txtLocation.Text == string.Empty || txtEmail.Text == string.Empty)
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


                    BL.CLS_ST BLST = new BL.CLS_ST();
                    BLST.Insert(txtStudentName.Text, txtLocation.Text, txtPhone.Text, txtEmail.Text, txtSchool.Text,txtDep.Text, ma);
                    PL.FRM_DADD FADD = new FRM_DADD();
                    FADD.Show();
                    this.Close();
                }
                else
                {
                    // update student 
                    MemoryStream ma = new MemoryStream();
                    txtCover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);


                    BL.CLS_ST BLST = new BL.CLS_ST();
                    BLST.Edite(txtStudentName.Text, txtLocation.Text, txtPhone.Text, txtEmail.Text, txtSchool.Text, txtDep.Text, ma,ID);
                    PL.FRM_DEDITE FEDITE = new FRM_DEDITE();
                    FEDITE.Show();
                    this.Close();
                }

            }
        }
    }
}
