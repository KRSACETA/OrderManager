namespace OrderManager.ContentPanel
{
    partial class Customer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNdelete = new System.Windows.Forms.Button();
            this.BTNsearch = new System.Windows.Forms.Button();
            this.BTNsave = new System.Windows.Forms.Button();
            this.BTNadd = new System.Windows.Forms.Button();
            this.CUSTOMER_ADRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONEY_SPENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REGISTERED_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOEMR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELECTED = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGVproduct = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVproduct)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1416, 132);
            this.panel1.TabIndex = 3;
            // 
            // BTNdelete
            // 
            this.BTNdelete.Location = new System.Drawing.Point(831, 102);
            this.BTNdelete.Name = "BTNdelete";
            this.BTNdelete.Size = new System.Drawing.Size(75, 23);
            this.BTNdelete.TabIndex = 20;
            this.BTNdelete.Text = "Delete";
            this.BTNdelete.UseVisualStyleBackColor = true;
            this.BTNdelete.Click += new System.EventHandler(this.BTNdelete_Click_1);
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
            this.BTNsave.Click += new System.EventHandler(this.BTNsave_Click_1);
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
            // CUSTOMER_ADRESS
            // 
            this.CUSTOMER_ADRESS.DataPropertyName = "CUSTOMER_ADRESS";
            this.CUSTOMER_ADRESS.HeaderText = "CUSTOMER ADRESS";
            this.CUSTOMER_ADRESS.MinimumWidth = 6;
            this.CUSTOMER_ADRESS.Name = "CUSTOMER_ADRESS";
            this.CUSTOMER_ADRESS.Width = 125;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Width = 125;
            // 
            // MONEY_SPENT
            // 
            this.MONEY_SPENT.DataPropertyName = "MONEY_SPENT";
            this.MONEY_SPENT.HeaderText = "MONEY SPENT";
            this.MONEY_SPENT.MinimumWidth = 6;
            this.MONEY_SPENT.Name = "MONEY_SPENT";
            this.MONEY_SPENT.Width = 125;
            // 
            // REGISTERED_DATE
            // 
            this.REGISTERED_DATE.DataPropertyName = "REGISTERED_DATE";
            this.REGISTERED_DATE.HeaderText = "REGISTERED DATE";
            this.REGISTERED_DATE.MinimumWidth = 6;
            this.REGISTERED_DATE.Name = "REGISTERED_DATE";
            this.REGISTERED_DATE.Width = 125;
            // 
            // CUSTOMER_NAME
            // 
            this.CUSTOMER_NAME.DataPropertyName = "CUSTOMER_NAME";
            this.CUSTOMER_NAME.HeaderText = "CUSTOMER NAME";
            this.CUSTOMER_NAME.MinimumWidth = 6;
            this.CUSTOMER_NAME.Name = "CUSTOMER_NAME";
            this.CUSTOMER_NAME.Width = 125;
            // 
            // CUSTOEMR_ID
            // 
            this.CUSTOEMR_ID.DataPropertyName = "CUSTOMER_ID";
            this.CUSTOEMR_ID.HeaderText = "CUSTOMER ID";
            this.CUSTOEMR_ID.MinimumWidth = 6;
            this.CUSTOEMR_ID.Name = "CUSTOEMR_ID";
            this.CUSTOEMR_ID.Width = 125;
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
            // DGVproduct
            // 
            this.DGVproduct.AllowUserToAddRows = false;
            this.DGVproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVproduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECTED,
            this.CUSTOEMR_ID,
            this.CUSTOMER_NAME,
            this.REGISTERED_DATE,
            this.MONEY_SPENT,
            this.EMAIL,
            this.CUSTOMER_ADRESS});
            this.DGVproduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVproduct.Location = new System.Drawing.Point(0, 132);
            this.DGVproduct.Name = "DGVproduct";
            this.DGVproduct.RowHeadersWidth = 51;
            this.DGVproduct.RowTemplate.Height = 27;
            this.DGVproduct.Size = new System.Drawing.Size(1416, 406);
            this.DGVproduct.TabIndex = 4;
            this.DGVproduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVproduct_CellClick_1);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DGVproduct);
            this.Controls.Add(this.panel1);
            this.Name = "Customer";
            this.Size = new System.Drawing.Size(1416, 538);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVproduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNdelete;
        private System.Windows.Forms.Button BTNsearch;
        private System.Windows.Forms.Button BTNsave;
        private System.Windows.Forms.Button BTNadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_ADRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONEY_SPENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGISTERED_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOEMR_ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECTED;
        private System.Windows.Forms.DataGridView DGVproduct;
    }
}
