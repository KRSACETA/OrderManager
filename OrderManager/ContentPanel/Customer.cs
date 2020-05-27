using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace OrderManager.ContentPanel
{
    public partial class Customer : UserControl
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void BTNadd_Click(object sender, EventArgs e)
        {
            ((DataTable)DGVproduct.DataSource).Rows.Add();
              

            DGVproduct.Rows[DGVproduct.RowCount - 1].DefaultCellStyle.BackColor = Color.Pink;
        }

        private void BTNsearch_Click(object sender, EventArgs e)
        {
            readDatabase();
        }

        private void readDatabase()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FristDB"].ConnectionString);
            SqlCommand cmd = new SqlCommand("dbo.SP_SEARCH_CUSTOMER_INFO", connection);

            cmd.CommandType = CommandType.StoredProcedure;
           
            connection.Open();

            var table = new DataTable();
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(table);
            }
            connection.Close();

            DGVproduct.DataSource = table;
        }

      

 

        private void updateData(DataTable dt)
        {
            SqlConnection connection = new SqlConnection(@"Server=LAPTOP-KEGOV3F0; uid = tomas; pwd = 0000; database=FristDB;");
            string query = "    Update TB_CUSTOMER_INFO" +
                           "    SET CUSTOMER_ADRESS = @ADRESS" +
                           "    ,CUSTOEMR_NAME = @CUSTOMERNAME" +
                           "    ,ARRIVAL_DATE = @REGISTEREDDATE" +
                           "    ,MONEYSPENT = @MONEYSPENT" +
                           "    ,ARRIVAL_DATE = @ARRIVALDATE " +
                           "    ,EMAIL = @EMAIL" +
                           "    WHERE CUSTOMER_ID = @CUSTOMERID";

            connection.Open();

            foreach (DataRow dr in dt.Rows)
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CUSTOMERID", dr["CUSTOMER_ID"].ToString());
                    command.Parameters.AddWithValue("@CUSTOMERNAME", dr["CUSTOMER_NAME"].ToString());
                    command.Parameters.AddWithValue("@REGISTEREDDATE", dr["REGISTERED_DATE"]);
                    command.Parameters.AddWithValue("@MONEYSPENT", dr["MONEY_SPENT"].ToString());
                    command.Parameters.AddWithValue("@EMAIL", dr["EMAIL"].ToString());
                    command.Parameters.AddWithValue("@ADRESS", dr["CUSTOMER_ADRESS"].ToString());

                    command.ExecuteNonQuery();
                }
            }

            connection.Close();
        }


        private void insertData(DataTable dt)
        {
            dt.Columns.Remove(dt.Columns["REGISTERED_DATE"]);
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FristDB"].ConnectionString);
            SqlCommand cmd = new SqlCommand("dbo.SP_INSERT_CUSTOMER_INFO_TABLE", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter ("@INSERTTABLE", dt));

            connection.Open();


            cmd.ExecuteNonQuery();

            connection.Close();
        }


     


        private void deleteDataFromCustomerInfo(DataTable dt)
        {
            SqlConnection connection = new SqlConnection(@"Server=LAPTOP-KEGOV3F0; uid = tomas; pwd = 0000; database=FristDB;");
            string query = "    delete from TB_CUSTOMER_INFO" +
                           "    where CUSTOMER_ID = @CUSTOMER_ID ";

            connection.Open();

            foreach (DataRow dr in dt.Rows)
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@CUSTOMER_ID", dr["CUSTOMER_ID", DataRowVersion.Original].ToString());

                    command.ExecuteNonQuery();
                }

            }
            connection.Close();
        }


        private void BTNsave_Click_1(object sender, EventArgs e)
        {
            if ((DGVproduct.DataSource as DataTable).GetChanges(DataRowState.Modified) != null ||
             (DGVproduct.DataSource as DataTable).GetChanges(DataRowState.Added) != null ||
                  (DGVproduct.DataSource as DataTable).GetChanges(DataRowState.Deleted) != null)
            {
                DataTable updatedt = new DataTable();
                updatedt = (DGVproduct.DataSource as DataTable).GetChanges(DataRowState.Modified);
                DataTable insertdt = new DataTable();
                insertdt = (DGVproduct.DataSource as DataTable).GetChanges(DataRowState.Added);
                DataTable deletedt = new DataTable();
                deletedt = (DGVproduct.DataSource as DataTable).GetChanges(DataRowState.Deleted);

                if (updatedt != null && updatedt.Rows.Count > 0)
                    updateData(updatedt);

                if (insertdt != null && insertdt.Rows.Count > 0)
                    insertData(insertdt);
                if (deletedt != null && deletedt.Rows.Count > 0)
                    deleteDataFromCustomerInfo(deletedt);
            }

            readDatabase();
        }

        private void BTNdelete_Click_1(object sender, EventArgs e)
        {
            //delete process

            for (int rowIndex = DGVproduct.RowCount - 1; rowIndex >= 0; rowIndex--)
            {
                var selected = DGVproduct.Rows[rowIndex].Cells["SELECTED"].Value;
                if (selected != null && selected.Equals("true"))
                {
                    ((DataTable)DGVproduct.DataSource).Rows[rowIndex].Delete();
                }
            }
        }

        private void DGVproduct_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DatePicker datepicker = new DatePicker();


            if (e.ColumnIndex == DGVproduct.Columns["REGISTERED_DATE"].Index)
            {


                if (DGVproduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "")
                {
                    datepicker.date = DateTime.Today.Date;
                }
                else
                {
                    datepicker.date = ((DataTable)DGVproduct.DataSource).Rows[e.RowIndex].Field<DateTime>("REGISTERED_DATE");
                }

                datepicker.ShowDialog();
                DGVproduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = datepicker.date;
                datepicker.Dispose();
            }
        }
    }
}
