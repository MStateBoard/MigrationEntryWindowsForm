using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        //Verification2022Entities db = new Verification2022Entities();
        SSC_Verification_2022Entities ssc_db = new SSC_Verification_2022Entities();
        HSC_Verification_2022Entities1 hsc_db = new HSC_Verification_2022Entities1();
        public Form2()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Seat_No = "";
            if (textBox1.Text.Length==7)
            {
                 Seat_No = textBox1.Text;
                textBox1.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                textBox1.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Please Enter valid Seat No");
                return;
            }
            

            string UniquetxID = "", Unique_ID_Seat_No = "", Pre_Ref_ID = "", Div_Code = "";
            int Result = 0;

            var tbl_SSC_Migration_Pri = ssc_db.Tbl_Migration_Pri.Where(x => x.Seat_No == Seat_No).FirstOrDefault();
            
            var tbl_SSC_Migration = ssc_db.Tbl_Migration.Where(x => x.Seat_No == Seat_No).FirstOrDefault();

            var tbl_SSC_Payment = ssc_db.Tbl_Payment.Where(x => x.clientTxnId == tbl_SSC_Migration_Pri.Unique_ID_Payment).FirstOrDefault();

            if (tbl_SSC_Payment==null)
            {
                MessageBox.Show("Enter Record Into Payment Table!");
                return;
            }
            UniquetxID = tbl_SSC_Payment.clientTxnId;
            Unique_ID_Seat_No = tbl_SSC_Payment.udf20;
            Pre_Ref_ID = tbl_SSC_Payment.udf18.ToString();
            Div_Code = tbl_SSC_Payment.udf17.ToString();

            
            if (tbl_SSC_Migration_Pri != null && tbl_SSC_Migration == null)
            {
                try
                {
                    var sqlParameterOut = new SqlParameter
                    {
                        ParameterName = "@RESULT",
                        DbType = DbType.Int32,
                        Direction = ParameterDirection.Output
                    };

                    var ss = ssc_db.Database.ExecuteSqlCommand("dbo.SP_INSERT_STUDENT_MIGRATION @ACTION,@Seat_No,@Div_code,@Unique_ID_Payment,@Unique_ID_Seat_No,@Pre_Ref_ID,@RESULT OUT",
                                                                new SqlParameter("@ACTION", "INSERT"),
                                                                new SqlParameter("@Seat_No", Seat_No),
                                                                new SqlParameter("@Div_code", Int32.Parse(Div_Code)),
                                                                new SqlParameter("@Unique_ID_Payment", UniquetxID),
                                                                new SqlParameter("@Unique_ID_Seat_No", Unique_ID_Seat_No),
                                                                new SqlParameter("@Pre_Ref_ID", Pre_Ref_ID),
                                                                sqlParameterOut);

                    Result = Convert.ToInt32(sqlParameterOut.Value);

                }
                catch(Exception ex)
                {

                }
            }

            if (Result > 0)
            {
                MessageBox.Show("Record Updated");
            }
            else
            {
                MessageBox.Show("Error");
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 7)
            {
                HSC_Validation_Label.ForeColor = Color.Red;
                HSC_Validation_Label.Text = "Please Enter Valid Seat No";
            }
            else
            {
                HSC_Validation_Label.Text = "";
            }
        }

        private void HSCLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>7)
            {
                SSC_Validation_Label.ForeColor = Color.Red;
                SSC_Validation_Label.Text = "Please Enter Valid Seat No";
            }
            else
            {
                SSC_Validation_Label.Text = " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Seat_No = textBox2.Text.ToString();

           
            string UniquetxID = "", Unique_ID_Seat_No = "", Pre_Ref_ID = "", Div_Code = "";
            int Result = 0;
            var tbl_HSC_Migration_Pre = hsc_db.Tbl_Migration_Pri.Where(x => x.Seat_No == Seat_No).FirstOrDefault();

            var tbl_HSC_Migration = hsc_db.Tbl_Migration.Where(x => x.Seat_No == Seat_No).FirstOrDefault();

            var tbl_HSC_Payment = hsc_db.Tbl_Payment.Where(x => x.clientTxnId == tbl_HSC_Migration_Pre.Unique_ID_Payment).FirstOrDefault();

            if (tbl_HSC_Payment == null)
            {
                MessageBox.Show("Enter Record Into Payment Table!");
                return;
            }
            UniquetxID = tbl_HSC_Payment.clientTxnId;
            Unique_ID_Seat_No = tbl_HSC_Payment.udf20;
            Pre_Ref_ID = tbl_HSC_Payment.udf18.ToString();
            Div_Code = tbl_HSC_Payment.udf17.ToString();


            if (tbl_HSC_Migration_Pre != null && tbl_HSC_Migration == null)
            {
                try
                {
                    var sqlParameterOut = new SqlParameter
                    {
                        ParameterName = "@RESULT",
                        DbType = DbType.Int32,
                        Direction = ParameterDirection.Output
                    };

                    var ss = hsc_db.Database.ExecuteSqlCommand("dbo.SP_INSERT_STUDENT_MIGRATION @ACTION,@Seat_No,@Div_code,@Unique_ID_Payment,@Unique_ID_Seat_No,@Pre_Ref_ID,@RESULT OUT",
                                                                new SqlParameter("@ACTION", "INSERT"),
                                                                new SqlParameter("@Seat_No", Seat_No),
                                                                new SqlParameter("@Div_code", Int32.Parse(Div_Code)),
                                                                new SqlParameter("@Unique_ID_Payment",UniquetxID),
                                                                new SqlParameter("@Unique_ID_Seat_No",Unique_ID_Seat_No),
                                                                new SqlParameter("@Pre_Ref_ID", Pre_Ref_ID),
                                                                sqlParameterOut);

                    Result = Convert.ToInt32(sqlParameterOut.Value);

                }
                catch (Exception ex)
                {

                }
            }

            if (Result > 0)
            {
                MessageBox.Show("Record Updated");
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
       
        private void Label_Insert_Payment_Click(object sender, EventArgs e)
        {
            PaymentEntry paymentEntry = new PaymentEntry();
            paymentEntry.Show();
            this.Hide();

        }
    }
}
