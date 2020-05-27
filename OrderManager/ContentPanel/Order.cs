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

namespace OrderManager.ContentPanel
{
    public partial class Order : UserControl
    {
        public Order()
        {
            InitializeComponent();
        }

       


        private void searchData()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FristDB"].ConnectionString);
            SqlCommand cmd = new SqlCommand("dbo.SP_SEARCH_ORDER", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            connection.Open();

            var table = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(table);
            }

            connection.Close();

            DGVorderinfo.DataSource = table;
        }

      

        private void btnADD_Click(object sender, EventArgs e)
        {
            (DGVorderinfo.DataSource as DataTable).Rows.Add();
        }




        private void deleteData(DataTable dt)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FristDB"].ConnectionString);


            connection.Open();

            foreach (DataRow dr in dt.Rows)
            {
                using (SqlCommand command = new SqlCommand("dbo.SP_DELETE_ORDER_INFO", connection))
                {

                    command.Parameters.AddWithValue("@ORDER_ID", dr["ORDER_ID", DataRowVersion.Original].ToString());

                    command.ExecuteNonQuery();
                }

            }
            connection.Close();
        }

        private void updateData(DataTable dt)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FristDB"].ConnectionString);



            connection.Open();

            foreach (DataRow dr in dt.Rows)
            {
                using (SqlCommand command = new SqlCommand("dbo.SP_UPDATE_ORDER_INFO", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@ORDER_ID", dr["ORDER_ID"].ToString());
                    command.Parameters.AddWithValue("@CUSTOMER_ID", dr["CUSTOMER_ID"].ToString());
                    command.Parameters.AddWithValue("@PRODUCT_ID", dr["PRODUCT_ID"].ToString());
                    command.Parameters.AddWithValue("@ORDER_DATE", dr["ORDER_DATE"]);
                    command.Parameters.AddWithValue("@QUANTITY", dr["QUANTITY"]);
                    command.Parameters.AddWithValue("@PAY_TYPE", dr["PAY_TYPE"].ToString());
                    command.Parameters.AddWithValue("@TOTAL_PRICE", dr["TOTAL_PRICE"]);
                    command.Parameters.AddWithValue("@ORDERED_ADDRESS", dr["ORDERED_ADDRESS"].ToString());

                    command.ExecuteNonQuery();
                }
            }

            connection.Close();
        }


        private void insertData(DataTable dt)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FristDB"].ConnectionString);



            connection.Open();

            foreach (DataRow dr in dt.Rows)
            {
                using (SqlCommand command = new SqlCommand("dbo.SP_INSERT_ORDER_INFO", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@ORDERID", dr["ORDER_ID"].ToString());
                    command.Parameters.AddWithValue("@CUSTOMERID", dr["CUSTOMER_ID"].ToString());
                    command.Parameters.AddWithValue("@PRODUCTID", dr["PRODUCT_ID"].ToString());
                    command.Parameters.AddWithValue("@ORDERDATE", dr["ORDER_DATE"]);
                    command.Parameters.AddWithValue("@QUANTITY", dr["QUANTITY"]);
                    command.Parameters.AddWithValue("@PAYTYPE", dr["PAY_TYPE"].ToString());
                    command.Parameters.AddWithValue("@TOTALPRICE", dr["TOTAL_PRICE"]);
                    command.Parameters.AddWithValue("@ORDEREDADRESS", dr["ORDERED_ADDRESS"].ToString());

                    command.ExecuteNonQuery();
                }
            }

            connection.Close();
        }

  

        private void btnSAVE_Click_1(object sender, EventArgs e)
        {
            if ((DGVorderinfo.DataSource as DataTable).GetChanges(DataRowState.Modified) != null ||
             (DGVorderinfo.DataSource as DataTable).GetChanges(DataRowState.Added) != null ||
                  (DGVorderinfo.DataSource as DataTable).GetChanges(DataRowState.Deleted) != null)
            {
                DataTable updatedt = new DataTable();
                updatedt = (DGVorderinfo.DataSource as DataTable).GetChanges(DataRowState.Modified);
                DataTable insertdt = new DataTable();
                insertdt = (DGVorderinfo.DataSource as DataTable).GetChanges(DataRowState.Added);
                DataTable deletedt = new DataTable();
                deletedt = (DGVorderinfo.DataSource as DataTable).GetChanges(DataRowState.Deleted);

                if (updatedt != null && updatedt.Rows.Count > 0)
                    updateData(updatedt);

                if (insertdt != null && insertdt.Rows.Count > 0)
                    insertData(insertdt);
                if (deletedt != null && deletedt.Rows.Count > 0)
                    deleteData(deletedt);
            }

            searchData();
        }

        private void btnDELETE_Click_1(object sender, EventArgs e)
        {
            for (int rowIndex = DGVorderinfo.RowCount - 1; rowIndex >= 0; rowIndex--)
            {
                var selected = DGVorderinfo.Rows[rowIndex].Cells["SELECTED"].Value;

                if (selected != null && selected.Equals("true"))
                {
                    ((DataTable)DGVorderinfo.DataSource).Rows[rowIndex].Delete();
                }
            }
        }

        private void BTNSEARCH_Click(object sender, EventArgs e)
        {
            searchData();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            this.tB_CODE_MSTTableAdapter.Fill(this.getPayType.TB_CODE_MST);
        }

        private void DGVorderinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DatePicker datepicker = new DatePicker();


            if (e.ColumnIndex == DGVorderinfo.Columns["ORDER_DATE"].Index)
            {


                if (DGVorderinfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "")
                {
                    datepicker.date = DateTime.Today.Date;
                }
                else
                {
                    datepicker.date = ((DataTable)DGVorderinfo.DataSource).Rows[e.RowIndex].Field<DateTime>("ORDER_DATE");
                }

                datepicker.ShowDialog();
                DGVorderinfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = datepicker.date;
                datepicker.Dispose();
            }
        }
    }
}
