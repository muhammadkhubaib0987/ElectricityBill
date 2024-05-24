using ModelLyr;
using MySqlConnector;
using System;
using BusinessLyr;
//using System.Data;
using System.Collections.Generic;
using System.ComponentModel;

using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricityBill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password='';database=bill");

        private void LblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void BtnInsertNewStudent_Click(object sender, EventArgs e)
        {
            BillModel model = new BillModel()
            {
                CustomerName = TxtCustomerName.Text,
                MeterNo = TxtMeterNo.Text,
                ReadingMonthName = TxtReadingMonthName.Text,
                Amount = TxtAmount.Text,
                AverageOfBillAtTheEndOfYear = TxtAverageOfBillAtTheEndOfYear.Text
            };
            BillBusiness billBusiness = new BillBusiness();
           billBusiness.AddBillBusiness(model);
            MessageBox.Show("New Customer data Inserted Successflly");



            /*1T  try
            {
                con.Open();
                MessageBox.Show("connection open successfully");
             
                string query = "INSERT INTO electricitybill(CustomerName,MeterNo,ReadingMonthName,Amount,AverageOfBillsAtEndOfYear) VALUES(@CustomerName,@MeterNo,@ReadingMonthName,@Amount,@AverageOfBillsAtEndOfYear)";

               MySqlCommand cmd = new MySqlCommand(query,con);
               // MySqlCommand cmd = new MySqlCommand("AddBill", con);
               // cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CustomerName", TxtCustomerName.Text);
                cmd.Parameters.AddWithValue("MeterNo", TxtCustomerName.Text);  
                cmd.Parameters.AddWithValue("ReadingMonthName", TxtReadingMonthName.Text);
                cmd.Parameters.AddWithValue("Amount", TxtAmount.Text);
                cmd.Parameters.AddWithValue("AverageOfBillsAtEndOfYear" ,TxtAverageOfBillAtTheEndOfYear.Text);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Customer data Inserted Successflly");
                con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("error",Ex.Message);
            }
        }*/


        }
    }
    }

    
