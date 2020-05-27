namespace OrderManager.ContentPanel
{
    partial class Product
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNdelete = new System.Windows.Forms.Button();
            this.BTNsearch = new System.Windows.Forms.Button();
            this.BTNsave = new System.Windows.Forms.Button();
            this.BTNadd = new System.Windows.Forms.Button();
            this.DGVproduct = new System.Windows.Forms.DataGridView();
            this.fristDBDataSet = new OrderManager.FristDBDataSet();
            this.tBPRODUCTINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_PRODUCT_INFOTableAdapter = new OrderManager.FristDBDataSetTableAdapters.TB_PRODUCT_INFOTableAdapter();
            this.fristDBDataSet2 = new OrderManager.FristDBDataSet2();
            this.tBCODEMSTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_CODE_MSTTableAdapter = new OrderManager.FristDBDataSet2TableAdapters.TB_CODE_MSTTableAdapter();
            this.SELECTED = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PRODUCT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORY_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PRODUCT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_ORIGIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARRIVAL_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fristDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPRODUCTINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fristDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCODEMSTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTNdelete);
            this.panel1.Controls.Add(this.BTNsearch);
            this.panel1.Controls.Add(this.BTNsave);
            this.panel1.Controls.Add(this.BTNadd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 132);
            this.panel1.TabIndex = 1;
            // 
            // BTNdelete
            // 
            this.BTNdelete.Location = new System.Drawing.Point(831, 102);
            this.BTNdelete.Name = "BTNdelete";
            this.BTNdelete.Size = new System.Drawing.Size(75, 23);
            this.BTNdelete.TabIndex = 20;
            this.BTNdelete.Text = "Delete";
            this.BTNdelete.UseVisualStyleBackColor = true;
            this.BTNdelete.Click += new System.EventHandler(this.BTNdelete_Click);
            // 
            // BTNsearch
            // 
            this.BTNsearch.Location = new System.Drawing.Point(831, 73);
            this.BTNsearch.Name = "BTNsearch";
            this.BTNsearch.Size = new System.Drawing.Size(75, 23);
            this.BTNsearch.TabIndex = 18;
            this.BTNsearch.Text = "Search";
            this.BTNsearch.UseVisualStyleBackColor = true;
            this.BTNsearch.Click += new System.EventHandler(this.BTNsearch_Click);
            // 
            // BTNsave
            // 
            this.BTNsave.Location = new System.Drawing.Point(749, 103);
            this.BTNsave.Name = "BTNsave";
            this.BTNsave.Size = new System.Drawing.Size(75, 23);
            this.BTNsave.TabIndex = 1;
            this.BTNsave.Text = "Save";
            this.BTNsave.UseVisualStyleBackColor = true;
            this.BTNsave.Click += new System.EventHandler(this.BTNsave_Click);
            // 
            // BTNadd
            // 
            this.BTNadd.Location = new System.Drawing.Point(749, 74);
            this.BTNadd.Name = "BTNadd";
            this.BTNadd.Size = new System.Drawing.Size(75, 23);
            this.BTNadd.TabIndex = 0;
            this.BTNadd.Text = "Add";
            this.BTNadd.UseVisualStyleBackColor = true;
            this.BTNadd.Click += new System.EventHandler(this.BTNadd_Click);
            // 
            // DGVproduct
            // 
            this.DGVproduct.AllowUserToAddRows = false;
            this.DGVproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVproduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECTED,
            this.PRODUCT_ID,
            this.CATEGORY_ID,
            this.PRODUCT_NAME,
            this.PRODUCT_ORIGIN,
            this.ARRIVAL_DATE,
            this.PRODUCT_PRICE,
            this.QUANTITY});
            this.DGVproduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVproduct.Location = new System.Drawing.Point(0, 132);
            this.DGVproduct.Name = "DGVproduct";
            this.DGVproduct.RowHeadersWidth = 51;
            this.DGVproduct.RowTemplate.Height = 27;
            this.DGVproduct.Size = new System.Drawing.Size(1188, 337);
            this.DGVproduct.TabIndex = 2;
            this.DGVproduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVproduct_CellClick_1);
            // 
            // fristDBDataSet
            // 
            this.fristDBDataSet.DataSetName = "FristDBDataSet";
            this.fristDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBPRODUCTINFOBindingSource
            // 
            this.tBPRODUCTINFOBindingSource.DataMember = "TB_PRODUCT_INFO";
            this.tBPRODUCTINFOBindingSource.DataSource = this.fristDBDataSet;
            // 
            // tB_PRODUCT_INFOTableAdapter
            // 
            this.tB_PRODUCT_INFOTableAdapter.ClearBeforeFill = true;
            // 
            // fristDBDataSet2
            // 
            this.fristDBDataSet2.DataSetName = "FristDBDataSet2";
            this.fristDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBCODEMSTBindingSource
            // 
            this.tBCODEMSTBindingSource.DataMember = "TB_CODE_MST";
            this.tBCODEMSTBindingSource.DataSource = this.fristDBDataSet2;
            // 
            // tB_CODE_MSTTableAdapter
            // 
            this.tB_CODE_MSTTableAdapter.ClearBeforeFill = true;
            // 
            // SELECTED
            // 
            this.SELECTED.DataPropertyName = "SELECTED";
            this.SELECTED.FalseValue = "false";
            this.SELECTED.HeaderText = "";
            this.SELECTED.IndeterminateValue = "false";
            this.SELECTED.MinimumWidth = 6;
            this.SELECTED.Name = "SELECTED";
            this.SELECTED.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SELECTED.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SELECTED.TrueValue = "true";
            this.SELECTED.Width = 125;
            // 
            // PRODUCT_ID
            // 
            this.PRODUCT_ID.DataPropertyName = "PRODUCT_ID";
            this.PRODUCT_ID.HeaderText = "Product ID";
            this.PRODUCT_ID.MinimumWidth = 6;
            this.PRODUCT_ID.Name = "PRODUCT_ID";
            this.PRODUCT_ID.Width = 125;
            // 
            // CATEGORY_ID
            // 
            this.CATEGORY_ID.DataPropertyName = "CATEGORY_ID";
            this.CATEGORY_ID.HeaderText = "Category";
            this.CATEGORY_ID.MinimumWidth = 6;
            this.CATEGORY_ID.Name = "CATEGORY_ID";
            this.CATEGORY_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CATEGORY_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CATEGORY_ID.Width = 125;
            // 
            // PRODUCT_NAME
            // 
            this.PRODUCT_NAME.DataPropertyName = "PRODUCT_NAME";
            this.PRODUCT_NAME.HeaderText = "Product Name";
            this.PRODUCT_NAME.MinimumWidth = 6;
            this.PRODUCT_NAME.Name = "PRODUCT_NAME";
            this.PRODUCT_NAME.Width = 125;
            // 
            // PRODUCT_ORIGIN
            // 
            this.PRODUCT_ORIGIN.DataPropertyName = "PRODUCT_ORIGIN";
            this.PRODUCT_ORIGIN.HeaderText = "Product Origin";
            this.PRODUCT_ORIGIN.MinimumWidth = 6;
            this.PRODUCT_ORIGIN.Name = "PRODUCT_ORIGIN";
            this.PRODUCT_ORIGIN.Width = 125;
            // 
            // ARRIVAL_DATE
            // 
            this.ARRIVAL_DATE.DataPropertyName = "ARRIVAL_DATE";
            this.ARRIVAL_DATE.HeaderText = "Arrival Date";
            this.ARRIVAL_DATE.MinimumWidth = 6;
            this.ARRIVAL_DATE.Name = "ARRIVAL_DATE";
            this.ARRIVAL_DATE.Width = 125;
            // 
            // PRODUCT_PRICE
            // 
            this.PRODUCT_PRICE.DataPropertyName = "PRICE";
            this.PRODUCT_PRICE.HeaderText = "Price";
            this.PRODUCT_PRICE.MinimumWidth = 6;
            this.PRODUCT_PRICE.Name = "PRODUCT_PRICE";
            this.PRODUCT_PRICE.Width = 125;
            // 
            // QUANTITY
            // 
            this.QUANTITY.DataPropertyName = "QUANTITY";
            this.QUANTITY.HeaderText = "Qty";
            this.QUANTITY.MinimumWidth = 6;
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.Width = 125;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DGVproduct);
            this.Controls.Add(this.panel1);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(1188, 469);
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fristDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPRODUCTINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fristDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCODEMSTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNdelete;
        private System.Windows.Forms.Button BTNsearch;
        private System.Windows.Forms.Button BTNsave;
        private System.Windows.Forms.Button BTNadd;
        private System.Windows.Forms.DataGridView DGVproduct;
        private System.Windows.Forms.BindingSource tBPRODUCTINFOBindingSource;
        private FristDBDataSet fristDBDataSet;
        private FristDBDataSetTableAdapters.TB_PRODUCT_INFOTableAdapter tB_PRODUCT_INFOTableAdapter;
        private System.Windows.Forms.BindingSource tBCODEMSTBindingSource;
        private FristDBDataSet2 fristDBDataSet2;
        private FristDBDataSet2TableAdapters.TB_CODE_MSTTableAdapter tB_CODE_MSTTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECTED;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn CATEGORY_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_ORIGIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARRIVAL_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
    }
}
