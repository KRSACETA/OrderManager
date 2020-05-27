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
    public partial class Product : UserControl
    {
        


        public Product()
        {
            InitializeComponent();
        }

        private void BTNsearch_Click(object sender, EventArgs e)
        {
            readDatabase();
        }


        private void readDatabase()
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FristDB"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT *
                                    From TB_PRODUCT_INFO";

            cmd.Connection = connection;


            connection.Open();

            var table = new DataTable();
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(table);
            }
               connection.Close();

            DGVproduct.DataSource = table;
        }

        private void insertData(DataTable dt)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FristDB"].ConnectionString);
            SqlCommand cmd = new SqlCommand("dbo.SP_INSERT_PRODUCT_INFO_TABLE", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@INSERTTABLE",dt));

            connection.Open();

            cmd.ExecuteNonQuery();
                                     
            connection.Close();
        }

        private void updateData(DataTable dt)
        {
          /*  SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FristDB"].ConnectionString);
           

            connection.Open();

            foreach (DataRow dr in dt.Rows)
            {
                using (SqlCommand command = new SqlCommand("dbo.SP_UPDATE_PRODUCT_INFO", connection))
                {
                    command.Parameters.AddWithValue("@PRODUCTNAME", dr["PRODUCT_NAME"].ToString());
                    command.Parameters.AddWithValue("@CATEGORY", dr["CATEGORY_ID"].ToString());
                    command.Parameters.AddWithValue("@PRICE", dr["PRICE"].ToString());
                    command.Parameters.AddWithValue("@QUANTITY", dr["QUANTITY"].ToString());
                    command.Parameters.AddWithValue("@ARRIVALDATE", dr["ARRIVAL_DATE"]);
                    command.Parameters.AddWithValue("@ORIGIN", dr["PRODUCT_ORIGIN"].ToString());
                    command.Parameters.AddWithValue("@PRODUCTID", dr["PRODUCT_ID"].ToString());

                    command.ExecuteNonQuery();
                }
            }

            connection.Close();


    */


            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FristDB"].ConnectionString);
            SqlCommand cmd = new SqlCommand("dbo.SP_UPDATE_PRODUCT_INFO_TABLE", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@INSERTTABLE", dt));

            connection.Open();

            cmd.ExecuteNonQuery();

            connection.Close();
        }


        private void deleteData(DataTable dt)
        {
            /*  SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FristDB"].ConnectionString);


              connection.Open();

              foreach (DataRow dr in dt.Rows)
              {
                  using (SqlCommand command = new SqlCommand("SP_DELETE_SELECTED_PRODUCTID", connection))
                  {

                      command.Parameters.AddWithValue("@PRODUCT_ID", dr["PRODUCT_ID", DataRowVersion.Original].ToString());

                      command.ExecuteNonQuery();
                  }

              }
              connection.Close();
              */
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FristDB"].ConnectionString);

            SqlCommand cmd = new SqlCommand("dbo.SP_DELETE_PRODUCT_INFO_TABLE", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable deleteTable = new DataTable();
            deleteTable.Columns.Add("ID");

            foreach(DataRow dr in dt.Rows)
            {
                deleteTable.Rows.Add(dr["PRODUCT_ID", DataRowVersion.Original]);
            }
            cmd.Parameters.Add(new SqlParameter("@INSERTTABLE", deleteTable));

            connection.Open();

            cmd.ExecuteNonQuery();

            connection.Close();

        }

        private void DGVproduct_CellClick(object sender, DataGridViewCellEventArgs e)
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




        private void Product_Load(object sender, EventArgs e)
        {
            defaultSetting();
        }


        private void defaultSetting()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FristDB"].ConnectionString);
            SqlCommand cmd = new SqlCommand("dbo.SP_SEARCH_PRODUCT_CODE_MST", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            connection.Open();

            var comboData = new DataTable();
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(comboData);
            }

            connection.Close();

            (DGVproduct.Columns["CATEGORY_ID"] as DataGridViewComboBoxColumn).DataSource = comboData;
            (DGVproduct.Columns["CATEGORY_ID"] as DataGridViewComboBoxColumn).ValueMember = "CODE_ID";
            (DGVproduct.Columns["CATEGORY_ID"] as DataGridViewComboBoxColumn).DisplayMember = "CODE_DESCR";
          
        }

        private void BTNadd_Click(object sender, EventArgs e)
        {
            (DGVproduct.DataSource as DataTable).Rows.Add();

            DGVproduct.Rows[DGVproduct.RowCount - 1].DefaultCellStyle.BackColor = Color.Pink;
        }

        private void BTNsave_Click(object sender, EventArgs e)
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
                    deleteData(deletedt);
            }

            readDatabase();
        }

        private void BTNdelete_Click(object sender, EventArgs e)
        {

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


            if (e.ColumnIndex == DGVproduct.Columns["ARRIVAL_DATE"].Index)
            {


                if (DGVproduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "")
                {
                    datepicker.date = DateTime.Today.Date;
                }
                else
                {
                    datepicker.date = ((DataTable)DGVproduct.DataSource).Rows[e.RowIndex].Field<DateTime>("ARRIVAL_DATE");
                }

                datepicker.ShowDialog();
                DGVproduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = datepicker.date;
                datepicker.Dispose();
            }
        }
    }
}
