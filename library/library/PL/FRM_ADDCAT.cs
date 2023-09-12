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
    public partial class FRM_ADDCAT : Form
    {
        public int ID;
        public FRM_ADDCAT()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(txtCATNAME.Text ==string.Empty)
            {
                PL.FRM_DERORR FERORR = new FRM_DERORR();
                FERORR.Show();
            }
            else
            { 
                if(ID== 0 )
                { // ADD CAT
                    BL.CLS_CAT BLCLSCAT = new BL.CLS_CAT();
                    BLCLSCAT.Insert(txtCATNAME.Text);
                    PL.FRM_DADD FADD = new FRM_DADD();
                    FADD.Show();
                    this.Close();
                }
                else
                {
                    BL.CLS_CAT BLCLSCAT = new BL.CLS_CAT();
                    BLCLSCAT.Update(txtCATNAME.Text, ID);
                    PL.FRM_DEDITE FEDITE = new FRM_DEDITE();
                    FEDITE.Show();
                    this.Close();
                }

                
            }
            
        }

        private void FRM_ADDCAT_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
