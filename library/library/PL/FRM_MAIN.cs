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
    public partial class FRM_MAIN : Form
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
        public FRM_MAIN()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {

                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            if(P_MB.Size.Width == 175 )
            {
                P_MB.Width = 50;
                button1.RightToLeft = RightToLeft.Yes;
                button2.RightToLeft = RightToLeft.Yes;
                button3.RightToLeft = RightToLeft.Yes;
                button4.RightToLeft = RightToLeft.Yes;
                button5.RightToLeft = RightToLeft.Yes;
                button6.RightToLeft = RightToLeft.Yes;
                button7.RightToLeft = RightToLeft.Yes;
                lblName.Visible = false;
                lblPrem.Visible = false;
            }

            else
            {
                P_MB.Width = 175;
                button1.RightToLeft = RightToLeft.No;
                button2.RightToLeft = RightToLeft.No;
                button3.RightToLeft = RightToLeft.No;
                button4.RightToLeft = RightToLeft.No;
                button5.RightToLeft = RightToLeft.No;
                button6.RightToLeft = RightToLeft.No;
                button7.RightToLeft = RightToLeft.No;
                lblName.Visible = true;
                lblPrem.Visible = true;
            }
        }

        private void P_MB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (state == "CAT")
            {
                PL.FRM_ADDCAT FCAT = new FRM_ADDCAT();
                FCAT.btnADD.ButtonText = "تعديل";
                FCAT.txtCATNAME.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                FCAT.ID= Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                bunifuTransition1.Show(FCAT);

            }

            else 
                if(state =="ST")
            {
               
                    PL.FRM_ADDST FST = new FRM_ADDST();
                    FST.btnADD.ButtonText = "تعديل";
                    FST.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);

                    DataTable dt = new DataTable();
                    dt = BLST.LOADEDITE(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    object obj1 = dt.Rows[0]["name"];
                    object obj2 = dt.Rows[0]["stlocation"];
                    object obj3 = dt.Rows[0]["phone"];
                    object obj4 = dt.Rows[0]["email"];
                    object obj5 = dt.Rows[0]["school"];
                    object obj6 = dt.Rows[0]["dep"];
                    object obj7 = dt.Rows[0]["cover"];
                    FST.txtStudentName.Text = obj1.ToString();
                    FST.txtLocation.Text = obj2.ToString();
                    FST.txtPhone.Text = obj3.ToString();
                    FST.txtEmail.Text = obj4.ToString();
                    FST.txtSchool.Text = obj5.ToString();
                    FST.txtDep.Text = obj6.ToString();
                    // load image
                     byte[] ob = (byte[])obj7;
                    MemoryStream ma = new MemoryStream(ob);
                     FST.txtCover.Image = Image.FromStream(ma);

                    bunifuTransition1.ShowSync(FST);
                
               

            }

            else
                if (state == "BOOK")
            {

                PL.FRM_ADDBOOK FBOOK = new FRM_ADDBOOK();
                FBOOK.btnADD.ButtonText = "تعديل";
                FBOOK.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);

                DataTable dt = new DataTable();
                dt = BLBOOK.LOADEDITE(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                object obj1 = dt.Rows[0]["title"];
                object obj2 = dt.Rows[0]["author"];
                object obj3 = dt.Rows[0]["cat"];
                object obj4 = dt.Rows[0]["price"];
                object obj5 = dt.Rows[0]["bdate"];
                object obj6 = dt.Rows[0]["rate"];
                object obj7 = dt.Rows[0]["cover"];
                FBOOK.txtBookName.Text = obj1.ToString();
                FBOOK.txtAuthorName.Text = obj2.ToString();
                FBOOK.cboCAT.Text = obj3.ToString();
                FBOOK.txtPrice.Text = obj4.ToString();
                FBOOK.txtDateTime.Value = (DateTime)obj5;
                FBOOK.txtRate.Value = (int)obj6;
                // load image
                byte[] ob = (byte[])obj7;
                MemoryStream ma = new MemoryStream(ob);
                FBOOK.txtCover.Image = Image.FromStream(ma);

                bunifuTransition1.ShowSync(FBOOK);



            }
            else
                if (state == "SELL")
            {

                PL.FRM_MAKESELL FSELL = new FRM_MAKESELL();
                FSELL.btnADD.ButtonText = "تعديل";
                FSELL.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);


                bunifuTransition1.ShowSync(FSELL);



            }
            else
                if (state == "BOR")
            {

                PL.FRM_BOR FBOR = new FRM_BOR();
                FBOR.btnADD.ButtonText = "تعديل";
                FBOR.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);


                bunifuTransition1.ShowSync(FBOR);



            }

            else
                if (state == "USER")
            {

                PL.FRM_ADDUSER FUSER = new FRM_ADDUSER();
                FUSER.btnADD.ButtonText = "تعديل";
                FUSER.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                DataTable dt = new DataTable();
                dt = BLUSER.LOADEDITE(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                object obj1 = dt.Rows[0]["cname"];
                object obj2 = dt.Rows[0]["cuser"];
                object obj3 = dt.Rows[0]["cpassword"];
                object obj4 = dt.Rows[0]["cprem"];

                FUSER.txtName.Text = obj1.ToString();
                FUSER.txtUserName.Text = obj2.ToString();
                FUSER.txtPass.Text = obj3.ToString();
                FUSER.txtCbo.Text = obj4.ToString();
                
                bunifuTransition1.ShowSync(FUSER);



            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                state = "CAT";
                LB_Title.Text = "الاصناف";
                // LOAD DATA CAT
                DataTable dt = new DataTable();
                dt = BLCAT.LOAD();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "التسلسل";
                dataGridView1.Columns[1].HeaderText = "اسم الصنف";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            P_HOME.Visible = true;
            P_MAIN.Visible = false;
            LB_Title.Text = "الرئيسة";
        }

        private void P_TB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //ADD category
            if(state=="CAT")
            {
                PL.FRM_ADDCAT FCAT = new FRM_ADDCAT();
                FCAT.btnADD.ButtonText = "اضافة";
                FCAT.ID = 0;
                bunifuTransition1.Show(FCAT);

            }

            // ADD BOOK 
            if(state=="BOOK")
            {
                PL.FRM_ADDBOOK FBOOK = new FRM_ADDBOOK();
                FBOOK.btnADD.ButtonText = "اضافة";
                FBOOK.ID = 0;
                bunifuTransition1.ShowSync(FBOOK);

            }

            if(state == "ST")
            {
                PL.FRM_ADDST PLST = new FRM_ADDST();
                PLST.btnADD.ButtonText = "اضافة";
                PLST.ID = 0;
                bunifuTransition1.ShowSync(PLST);
            }
            if (state == "SELL")
            {
                PL.FRM_MAKESELL PLSELL = new FRM_MAKESELL();
                PLSELL.btnADD.ButtonText = "اضافة";
                PLSELL.ID = 0;
                bunifuTransition1.ShowSync(PLSELL);
            }
            if (state == "BOR")
            {
                PL.FRM_BOR PLBOR = new FRM_BOR();
                PLBOR.btnADD.ButtonText = "اضافة";
                PLBOR.ID = 0;
                bunifuTransition1.ShowSync(PLBOR);
            }
            if (state == "USER")
            {
                PL.FRM_ADDUSER PLUSER = new FRM_ADDUSER();
                PLUSER.btnADD.ButtonText = "اضافة";
                PLUSER.ID = 0;
                bunifuTransition1.ShowSync(PLUSER);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FRM_MAIN_Activated(object sender, EventArgs e)
        {
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

            if (lblPrem.Text=="مدير")
            {
                button6.Enabled = true;
                bunifuThinButton23.Enabled = true;
            }
            else
            {
                button6.Enabled = false;
                bunifuThinButton23.Enabled = false;
            }

            if (state == "CAT")
            {
                // load data cat 
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLCAT.LOAD();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "التسلسل";
                    dataGridView1.Columns[1].HeaderText = "اسم الصنف";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (state == "BOOK")
            {

                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                bunifuThinButton24.Visible = true;
                state = "BOOK";
                LB_Title.Text = "الكتب";
                try
                {
                    // LOAD DATA BOOK
                    DataTable dt = new DataTable();
                    dt = BLBOOK.LOAD();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "التسلسل";
                    dataGridView1.Columns[1].HeaderText = "اسم الكتاب";
                    dataGridView1.Columns[2].HeaderText = " المؤلف ";
                    dataGridView1.Columns[3].HeaderText = " التصنيف";
                    dataGridView1.Columns[4].HeaderText = "السعر";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (state == "ST")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                bunifuThinButton24.Visible = true;
                state = "ST";
                LB_Title.Text = "الطلاب";
                try
                {
                    // LOAD DATA BOOK
                    DataTable dt = new DataTable();
                    dt = BLST.LOAD();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "التسلسل";
                    dataGridView1.Columns[1].HeaderText = "اسم الطالب";
                    dataGridView1.Columns[2].HeaderText = " السكن ";
                    dataGridView1.Columns[3].HeaderText = " رقم الهاتف";
                    dataGridView1.Columns[4].HeaderText = "الايميل";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            else if (state== "SELL")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                bunifuThinButton24.Visible = true;
                state = "SELL";
                LB_Title.Text = "البيع";
                try
                {
                    // LOAD DATA BOOK
                    DataTable dt = new DataTable();
                    dt = BLSELL.LOAD();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "التسلسل";
                    dataGridView1.Columns[1].HeaderText = "اسم الطالب";
                    dataGridView1.Columns[2].HeaderText = " اسم الكتاب ";
                    dataGridView1.Columns[3].HeaderText = " السعر";
                    dataGridView1.Columns[4].HeaderText = "التاريخ";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (state == "BOR")
            {

                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                bunifuThinButton24.Visible = false;
                state = "BOR";
                LB_Title.Text = "الاستعارة";
                try
                {
                    // LOAD DATA BOOK
                    DataTable dt = new DataTable();
                    dt = BLBOR.LOAD();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "التسلسل";
                    dataGridView1.Columns[1].HeaderText = "اسم الطالب";
                    dataGridView1.Columns[2].HeaderText = " اسم الكتاب ";
                    dataGridView1.Columns[3].HeaderText = " بداية الاستعارة";
                    dataGridView1.Columns[4].HeaderText = "نهاية الاستعارة";
                    dataGridView1.Columns[5].HeaderText = "السعر";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (state=="USER")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                bunifuThinButton24.Visible = false;
                state = "USER";
                LB_Title.Text = "المستخدمين";
                try
                {
                    // LOAD DATA BOOK
                    DataTable dt = new DataTable();
                    dt = BLUSER.LOAD();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "التسلسل";
                    dataGridView1.Columns[1].HeaderText = "الاسم الكامل";
                    dataGridView1.Columns[2].HeaderText = " اسم المستخدم ";
                    dataGridView1.Columns[3].HeaderText = " كلمة السر ";
                    dataGridView1.Columns[4].HeaderText = "الصلاحية";

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (state == "CAT")
            {
                BLCAT.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fdelete = new FRM_DDELETE();
                fdelete.Show();
            }
               else if(state == "BOOK")
            {
                BLBOOK.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fddelete = new FRM_DDELETE();
                fddelete.Show();
                
            }
            else if (state =="ST")
            {
                BLST.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fddelete = new FRM_DDELETE();
                fddelete.Show();
            }
            else if (state == "SELL")
            {
                BLSELL.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fddelete = new FRM_DDELETE();
                fddelete.Show();
            }
            else if (state == "BOR")
            {
                BLBOR.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fddelete = new FRM_DDELETE();
                fddelete.Show();
            }

            else if (state == "USER")
            {
                BLUSER.Delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fddelete = new FRM_DDELETE();
                fddelete.Show();
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if(state=="CAT")
            {
                DataTable dt = new DataTable();
                dt= BLCAT.Search(bunifuMaterialTextbox1.Text);
                dataGridView1.DataSource = dt;
                
            }
            // search books 
            if (state == "BOOK")
            {
                DataTable dt = new DataTable();
                dt = BLBOOK.Search(bunifuMaterialTextbox1.Text);
                dataGridView1.DataSource = dt;

            }
            if (state == "ST")
            {
                DataTable dt = new DataTable();
                dt = BLST.Search(bunifuMaterialTextbox1.Text);
                dataGridView1.DataSource = dt;

            }

            if (state == "SELL")
            {
                DataTable dt = new DataTable();
                dt = BLSELL.Search(bunifuMaterialTextbox1.Text);
                dataGridView1.DataSource = dt;

            }
            if (state == "BOR")
            {
                DataTable dt = new DataTable();
                dt = BLBOR.Search(bunifuMaterialTextbox1.Text);
                dataGridView1.DataSource = dt;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            bunifuThinButton24.Visible = true;
            state = "BOOK";
            LB_Title.Text = "الكتب";
            try
            {
                // LOAD DATA BOOK
                DataTable dt = new DataTable();
                dt = BLBOOK.LOAD();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "التسلسل";
                dataGridView1.Columns[1].HeaderText = "اسم الكتاب";
                dataGridView1.Columns[2].HeaderText = " المؤلف ";
                dataGridView1.Columns[3].HeaderText = " التصنيف";
                dataGridView1.Columns[4].HeaderText = "السعر";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            // detealis book 

            if (state == "BOOK")
            {  
              
                DataTable dt = new DataTable();
                dt = BLBOOK.LOADEDITE(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                object obj1 = dt.Rows[0]["title"];
                object obj2 = dt.Rows[0]["author"];
                object obj3 = dt.Rows[0]["cat"];
                object obj4 = dt.Rows[0]["price"];
                object obj5 = dt.Rows[0]["bdate"];
                object obj6 = dt.Rows[0]["rate"];
                object obj7 = dt.Rows[0]["cover"];
                PL.FRM_DETBOOK DEBOOK = new FRM_DETBOOK();
                DEBOOK.txtBookName.Text = obj1.ToString();
                DEBOOK.txtAuthorName.Text = obj2.ToString();
                DEBOOK.cboCAT.Text = obj3.ToString();
                DEBOOK.txtPrice.Text = obj4.ToString();
                DEBOOK.txtDateTime.Value = (DateTime)obj5;
                DEBOOK.txtRate.Value = (int)obj6;
                // load image
                byte[] ob = (byte[])obj7;
                MemoryStream ma = new MemoryStream(ob);
                DEBOOK.txtCover.Image = Image.FromStream(ma);

                bunifuTransition1.ShowSync(DEBOOK);



            }

            else
                if (state == "ST")
            {

                PL.FRM_DETSTUDENT FDEST = new FRM_DETSTUDENT();
               
               
                DataTable dt = new DataTable();
                dt = BLST.LOADEDITE(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                object obj1 = dt.Rows[0]["name"];
                object obj2 = dt.Rows[0]["stlocation"];
                object obj3 = dt.Rows[0]["phone"];
                object obj4 = dt.Rows[0]["email"];
                object obj5 = dt.Rows[0]["school"];
                object obj6 = dt.Rows[0]["dep"];
                object obj7 = dt.Rows[0]["cover"];
                FDEST.txtStudentName.Text = obj1.ToString();
                FDEST.txtLocation.Text = obj2.ToString();
                FDEST.txtPhone.Text = obj3.ToString();
                FDEST.txtEmail.Text = obj4.ToString();
                FDEST.txtShool.Text = obj5.ToString();
                FDEST.txtDep.Text = obj6.ToString();
                // load image
                byte[] ob = (byte[])obj7;
                MemoryStream ma = new MemoryStream(ob);
                FDEST.txtCover.Image = Image.FromStream(ma);

                bunifuTransition1.ShowSync(FDEST);



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            bunifuThinButton24.Visible = true;
            state = "ST";
            LB_Title.Text = "الطلاب";
            try
            {
                // LOAD DATA ST
                DataTable dt = new DataTable();
                dt = BLST.LOAD();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "التسلسل";
                dataGridView1.Columns[1].HeaderText = "اسم الطالب";
                dataGridView1.Columns[2].HeaderText = " السكن ";
                dataGridView1.Columns[3].HeaderText = " رقم الهاتف";
                dataGridView1.Columns[4].HeaderText = "الايميل";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            bunifuThinButton24.Visible = false;
            state = "SELL";
            LB_Title.Text = "البيع";
            try
            {
                // LOAD DATA SELL
                DataTable dt = new DataTable();
                dt = BLSELL.LOAD();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "التسلسل";
                dataGridView1.Columns[1].HeaderText = "اسم الطالب";
                dataGridView1.Columns[2].HeaderText = " اسم الكتاب ";
                dataGridView1.Columns[3].HeaderText = " السعر";
                dataGridView1.Columns[4].HeaderText = "التاريخ";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            bunifuThinButton24.Visible = false;
            state = "BOR";
            LB_Title.Text = "الاستعارة";
            try
            {
                // LOAD DATA BOOK
                DataTable dt = new DataTable();
                dt = BLBOR.LOAD();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "التسلسل";
                dataGridView1.Columns[1].HeaderText = "اسم الطالب";
                dataGridView1.Columns[2].HeaderText = " اسم الكتاب ";
                dataGridView1.Columns[3].HeaderText = " بداية الاستعارة";
                dataGridView1.Columns[4].HeaderText = "نهاية الاستعارة";
                dataGridView1.Columns[5].HeaderText = "السعر";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = false;
            P_MAIN.Visible = true;
            bunifuThinButton24.Visible = false;
            state = "USER";
            LB_Title.Text = "المستخدمين";
            try
            {
                // LOAD DATA BOOK
                DataTable dt = new DataTable();
                dt = BLUSER.LOAD();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "التسلسل";
                dataGridView1.Columns[1].HeaderText = "الاسم الكامل";
                dataGridView1.Columns[2].HeaderText = " اسم المستخدم ";
                dataGridView1.Columns[3].HeaderText = " كلمة السر ";
                dataGridView1.Columns[4].HeaderText = "الصلاحية";
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            FRM_LOGIN LOG = new FRM_LOGIN();
            BLUSER.LOGOUT();
            this.Hide();
            LOG.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            P_HOME.Visible = true;
            P_MAIN.Visible = false;
            LB_Title.Text = "الرئيسة";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (state == "CAT")
            {
                PL.FRM_ADDCAT FCAT = new FRM_ADDCAT();
                FCAT.btnADD.ButtonText = "اضافة";
                FCAT.ID = 0;
                bunifuTransition1.Show(FCAT);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // ADD BOOK 
            if (state == "BOOK")
            {
                PL.FRM_ADDBOOK FBOOK = new FRM_ADDBOOK();
                FBOOK.btnADD.ButtonText = "اضافة";
                FBOOK.ID = 0;
                bunifuTransition1.ShowSync(FBOOK);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (state == "ST")
            {
                PL.FRM_ADDST PLST = new FRM_ADDST();
                PLST.btnADD.ButtonText = "اضافة";
                PLST.ID = 0;
                bunifuTransition1.ShowSync(PLST);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (state == "SELL")
            {
                PL.FRM_MAKESELL PLSELL = new FRM_MAKESELL();
                PLSELL.btnADD.ButtonText = "اضافة";
                PLSELL.ID = 0;
                bunifuTransition1.ShowSync(PLSELL);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (state == "BOR")
            {
                PL.FRM_BOR PLBOR = new FRM_BOR();
                PLBOR.btnADD.ButtonText = "اضافة";
                PLBOR.ID = 0;
                bunifuTransition1.ShowSync(PLBOR);
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            PL.FRM_REPORT REPO = new FRM_REPORT();
            REPO.Show();
        }
    }
    }

