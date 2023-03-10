using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class PaymentEntry : Form
    {
        //Verification2022Entities db = new Verification2022Entities();
        SSC_Verification_2022Entities ssc_db = new SSC_Verification_2022Entities();
        HSC_Verification_2022Entities1 hsc_db = new HSC_Verification_2022Entities1();
        public PaymentEntry()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 7)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Please Enter Valid Seat No";
            }
            else
            {
                label1.Text = "";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Seat_No = "";
            if (textBox1.Text.Length == 7)
            {
                Seat_No = textBox1.Text;
                //textBox1.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                MessageBox.Show("Please Enter Valid Seat No");
                return;
            }
       

            
            string PaymentMode = Payment_Mode.Text;
            string clientTxnId = "", firstName = "", email = "",  spRespStatus="", udf17="", udf18 = "", udf20="",udf19="";
            int Result = 0;
              

            if(PaymentMode == "SSC")
            {
                var tbl_SSC_Migration_Pri = ssc_db.Tbl_Migration_Pri.Where(x => x.Seat_No == Seat_No || x.Unique_ID_Payment == Seat_No).FirstOrDefault();
                clientTxnId = tbl_SSC_Migration_Pri.Unique_ID_Payment;
                firstName = tbl_SSC_Migration_Pri.Name + "" + tbl_SSC_Migration_Pri.Mother_Name + "" + tbl_SSC_Migration_Pri.Surname;
                email = tbl_SSC_Migration_Pri.Email_ID;
                spRespStatus = "Success";
                udf17 = tbl_SSC_Migration_Pri.Div_Code.ToString();
                udf18 = tbl_SSC_Migration_Pri.ID.ToString();
                udf20 = tbl_SSC_Migration_Pri.Unique_ID_Seat_No;
                udf19 = tbl_SSC_Migration_Pri.Seat_No.ToString();
                //ssc_db.Fun_Sp_Payment_Entry(clientTxnId, firstName, email, spRespStatus, udf17, udf18, udf20, udf19); ;
            }
            else
            {
                var tbl_HSC_Migration_Pri = hsc_db.Tbl_Migration_Pri.Where(x => x.Seat_No == Seat_No || x.Unique_ID_Payment == Seat_No).FirstOrDefault();
                clientTxnId = tbl_HSC_Migration_Pri.Unique_ID_Payment;
                //firstName = tbl_HSC_Migration_Pri.First_Name + "" + tbl_HSC_Migration_Pri.Mother_Name + "" + tbl_HSC_Migration_Pri.Last_Name;
                email = tbl_HSC_Migration_Pri.Email_ID;
                spRespStatus = "Success";
                udf17 = tbl_HSC_Migration_Pri.Div_Code.ToString();
                udf18 = tbl_HSC_Migration_Pri.ID.ToString();
                udf20 = tbl_HSC_Migration_Pri.Unique_ID_Seat_No;
                udf19 = tbl_HSC_Migration_Pri.Seat_No.ToString();
                hsc_db.Fun_Sp_HSC_Payment_Entry(clientTxnId, firstName, email, spRespStatus, udf17, udf18, udf20, udf19); ;
            }
           

        //    UniquetxID = tbl_SSC_Payment.clientTxnId;
        //    Unique_ID_Seat_No = tbl_SSC_Payment.udf20;
        //    Pre_Ref_ID = tbl_SSC_Payment.udf18.ToString();
        //    Div_Code = tbl_SSC_Payment.udf17.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Mode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
