namespace OrderManager.ContentPanel
{
    partial class Order
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
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.BTNSEARCH = new System.Windows.Forms.Button();
            this.DGVorderinfo = new System.Windows.Forms.DataGridView();
            this.SELECTED = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ORDER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDER_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAY_TYPE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TOTAL_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDERED_ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBCODEMSTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getPayType = new OrderManager.getPayType();
            this.tB_CODE_MSTTableAdapter = new OrderManager.getPayTypeTableAdapters.TB_CODE_MSTTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVorderinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCODEMSTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPayType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDELETE);
            this.panel1.Controls.Add(this.btnSAVE);
            this.panel1.Controls.Add(this.btnADD);
            this.panel1.Controls.Add(this.BTNSEARCH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 80);
            this.panel1.TabIndex = 2;
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(1073, 41);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(75, 23);
            this.btnDELETE.TabIndex = 3;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click_1);
            // 
            // btnSAVE
            // 
            this.btnSAVE.Location = new System.Drawing.Point(1155, 42);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(75, 23);
            this.btnSAVE.TabIndex = 2;
            this.btnSAVE.Text = "SAVE";
            this.btnSAVE.UseVisualStyleBackColor = true;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click_1);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(1074, 12);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 23);
            this.btnADD.TabIndex = 1;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // BTNSEARCH
            // 
            this.BTNSEARCH.Location = new System.Drawing.Point(1155, 13);
            this.BTNSEARCH.Name = "BTNSEARCH";
            this.BTNSEARCH.Size = new System.Drawing.Size(75, 23);
            this.BTNSEARCH.TabIndex = 0;
            this.BTNSEARCH.Text = "Search";
            this.BTNSEARCH.UseVisualStyleBackColor = true;
            this.BTNSEARCH.Click += new System.EventHandler(this.BTNSEARCH_Click);
            // 
            // DGVorderinfo
            // 
            this.DGVorderinfo.AllowUserToAddRows = false;
            this.DGVorderinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVorderinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECTED,
            this.ORDER_ID,
            this.CUSTOMER_ID,
            this.PRODUCT_ID,
            this.ORDER_DATE,
            this.QUANTITY,
            this.PAY_TYPE,
            this.TOTAL_PRICE,
            this.ORDERED_ADDRESS});
            this.DGVorderinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVorderinfo.Location = new System.Drawing.Point(0, 80);
            this.DGVorderinfo.Name = "DGVorderinfo";
            this.DGVorderinfo.RowHeadersWidth = 51;
            this.DGVorderinfo.RowTemplate.Height = 27;
            this.DGVorderinfo.Size = new System.Drawing.Size(1305, 442);
            this.DGVorderinfo.TabIndex = 3;
            this.DGVorderinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVorderinfo_CellClick);

            // 
            // SELECTED
            // 
            this.SELECTED.FalseValue = "false";
            this.SELECTED.HeaderText = "";
            this.SELECTED.IndeterminateValue = "false";
            this.SELECTED.MinimumWidth = 6;
            this.SELECTED.Name = "SELECTED";
            this.SELECTED.TrueValue = "true";
            this.SELECTED.Width = 125;
            // 
            // ORDER_ID
            // 
            this.ORDER_ID.DataPropertyName = "ORDER_ID";
            this.ORDER_ID.HeaderText = "ID";
            this.ORDER_ID.MinimumWidth = 6;
            this.ORDER_ID.Name = "ORDER_ID";
            this.ORDER_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ORDER_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ORDER_ID.Width = 125;
            // 
            // CUSTOMER_ID
            // 
            this.CUSTOMER_ID.DataPropertyName = "CUSTOMER_ID";
            this.CUSTOMER_ID.HeaderText = "Customer";
            this.CUSTOMER_ID.MinimumWidth = 6;
            this.CUSTOMER_ID.Name = "CUSTOMER_ID";
            this.CUSTOMER_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CUSTOMER_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CUSTOMER_ID.Width = 125;
            // 
            // PRODUCT_ID
            // 
            this.PRODUCT_ID.DataPropertyName = "PRODUCT_ID";
            this.PRODUCT_ID.HeaderText = "PRODUCT";
            this.PRODUCT_ID.MinimumWidth = 6;
            this.PRODUCT_ID.Name = "PRODUCT_ID";
            this.PRODUCT_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PRODUCT_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PRODUCT_ID.Width = 125;
            // 
            // ORDER_DATE
            // 
            this.ORDER_DATE.DataPropertyName = "ORDER_DATE";
            this.ORDER_DATE.HeaderText = "DATE";
            this.ORDER_DATE.MinimumWidth = 6;
            this.ORDER_DATE.Name = "ORDER_DATE";
            this.ORDER_DATE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ORDER_DATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ORDER_DATE.Width = 125;
            // 
            // QUANTITY
            // 
            this.QUANTITY.DataPropertyName = "QUANTITY";
            this.QUANTITY.HeaderText = "Quantity";
            this.QUANTITY.MinimumWidth = 6;
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QUANTITY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.QUANTITY.Width = 125;
            // 
            // PAY_TYPE
            // 
            this.PAY_TYPE.DataPropertyName = "PAY_TYPE";
            this.PAY_TYPE.DataSource = this.tBCODEMSTBindingSource;
            this.PAY_TYPE.DisplayMember = "CODE_DESCR";
            this.PAY_TYPE.HeaderText = "Pay Type";
            this.PAY_TYPE.MinimumWidth = 6;
            this.PAY_TYPE.Name = "PAY_TYPE";
            this.PAY_TYPE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PAY_TYPE.ValueMember = "CODE_ID";
            this.PAY_TYPE.Width = 125;
            // 
            // TOTAL_PRICE
            // 
            this.TOTAL_PRICE.DataPropertyName = "TOTAL_PRICE";
            this.TOTAL_PRICE.HeaderText = "Price";
            this.TOTAL_PRICE.MinimumWidth = 6;
            this.TOTAL_PRICE.Name = "TOTAL_PRICE";
            this.TOTAL_PRICE.Width = 125;
            // 
            // ORDERED_ADDRESS
            // 
            this.ORDERED_ADDRESS.DataPropertyName = "ORDERED_ADDRESS";
            this.ORDERED_ADDRESS.HeaderText = "Adress";
            this.ORDERED_ADDRESS.MinimumWidth = 6;
            this.ORDERED_ADDRESS.Name = "ORDERED_ADDRESS";
            this.ORDERED_ADDRESS.Width = 125;
            // 
            // tBCODEMSTBindingSource
            // 
            this.tBCODEMSTBindingSource.DataMember = "TB_CODE_MST";
            this.tBCODEMSTBindingSource.DataSource = this.getPayType;
            // 
            // getPayType
            // 
            this.getPayType.DataSetName = "getPayType";
            this.getPayType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_CODE_MSTTableAdapter
            // 
            this.tB_CODE_MSTTableAdapter.ClearBeforeFill = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DGVorderinfo);
            this.Controls.Add(this.panel1);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(1305, 522);
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVorderinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCODEMSTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPayType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button BTNSEARCH;
        private System.Windows.Forms.DataGridView DGVorderinfo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECTED;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewComboBoxColumn PAY_TYPE;
        private System.Windows.Forms.BindingSource tBCODEMSTBindingSource;
        private getPayType getPayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDERED_ADDRESS;
        private getPayTypeTableAdapters.TB_CODE_MSTTableAdapter tB_CODE_MSTTableAdapter;
    }
}
