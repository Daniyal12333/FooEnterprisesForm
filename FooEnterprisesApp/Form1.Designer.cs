namespace FooEnterprisesApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.saleCost = new System.Windows.Forms.TextBox();
            this.wholeSaleCost = new System.Windows.Forms.TextBox();
            this.customerProductId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.customerProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fooEnterprisesDataSet1 = new FooEnterprisesApp.FooEnterprisesDataSet1();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fooEnterprisesDataSet = new FooEnterprisesApp.FooEnterprisesDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fooEnterprisesDataSet2 = new FooEnterprisesApp.FooEnterprisesDataSet2();
            this.customerTableAdapter = new FooEnterprisesApp.FooEnterprisesDataSetTableAdapters.CustomerTableAdapter();
            this.customerProductTableAdapter = new FooEnterprisesApp.FooEnterprisesDataSet1TableAdapters.CustomerProductTableAdapter();
            this.productTableAdapter = new FooEnterprisesApp.FooEnterprisesDataSet2TableAdapters.ProductTableAdapter();
            this.searchingTabControl = new System.Windows.Forms.TabControl();
            this.SCustomer = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SProduct = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search = new System.Windows.Forms.Button();
            this.SearchCustomerId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TPCustomer = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TPCustomerProduct = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCFooEnterprises = new System.Windows.Forms.TabControl();
            this.TPProduct = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fooEnterprisesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fooEnterprisesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fooEnterprisesDataSet2)).BeginInit();
            this.searchingTabControl.SuspendLayout();
            this.SCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.TPCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TPCustomerProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.TCFooEnterprises.SuspendLayout();
            this.TPProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sale Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Whole Sale Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Customer Product ID";
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(164, 25);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(161, 26);
            this.firstName.TabIndex = 6;
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(164, 71);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(161, 26);
            this.lastName.TabIndex = 7;
            // 
            // productName
            // 
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(164, 116);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(161, 26);
            this.productName.TabIndex = 8;
            // 
            // saleCost
            // 
            this.saleCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleCost.Location = new System.Drawing.Point(164, 156);
            this.saleCost.Name = "saleCost";
            this.saleCost.Size = new System.Drawing.Size(161, 26);
            this.saleCost.TabIndex = 9;
            // 
            // wholeSaleCost
            // 
            this.wholeSaleCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wholeSaleCost.Location = new System.Drawing.Point(164, 199);
            this.wholeSaleCost.Name = "wholeSaleCost";
            this.wholeSaleCost.Size = new System.Drawing.Size(161, 26);
            this.wholeSaleCost.TabIndex = 10;
            // 
            // customerProductId
            // 
            this.customerProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerProductId.Location = new System.Drawing.Point(164, 249);
            this.customerProductId.Name = "customerProductId";
            this.customerProductId.Size = new System.Drawing.Size(161, 26);
            this.customerProductId.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(374, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAdd);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(374, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnUpdate);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(374, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 30);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnDelete);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(374, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 30);
            this.button4.TabIndex = 15;
            this.button4.Text = "Show";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnShow);
            // 
            // customerProductBindingSource
            // 
            this.customerProductBindingSource.DataMember = "CustomerProduct";
            this.customerProductBindingSource.DataSource = this.fooEnterprisesDataSet1;
            // 
            // fooEnterprisesDataSet1
            // 
            this.fooEnterprisesDataSet1.DataSetName = "FooEnterprisesDataSet1";
            this.fooEnterprisesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.fooEnterprisesDataSet;
            // 
            // fooEnterprisesDataSet
            // 
            this.fooEnterprisesDataSet.DataSetName = "FooEnterprisesDataSet";
            this.fooEnterprisesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.fooEnterprisesDataSet2;
            // 
            // fooEnterprisesDataSet2
            // 
            this.fooEnterprisesDataSet2.DataSetName = "FooEnterprisesDataSet2";
            this.fooEnterprisesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerProductTableAdapter
            // 
            this.customerProductTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // searchingTabControl
            // 
            this.searchingTabControl.Controls.Add(this.SCustomer);
            this.searchingTabControl.Controls.Add(this.SProduct);
            this.searchingTabControl.Location = new System.Drawing.Point(534, 74);
            this.searchingTabControl.Name = "searchingTabControl";
            this.searchingTabControl.SelectedIndex = 0;
            this.searchingTabControl.Size = new System.Drawing.Size(433, 257);
            this.searchingTabControl.TabIndex = 17;
            // 
            // SCustomer
            // 
            this.SCustomer.Controls.Add(this.dataGridView4);
            this.SCustomer.Location = new System.Drawing.Point(4, 22);
            this.SCustomer.Name = "SCustomer";
            this.SCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.SCustomer.Size = new System.Drawing.Size(425, 231);
            this.SCustomer.TabIndex = 0;
            this.SCustomer.Text = "Customer";
            this.SCustomer.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(419, 225);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClkEvent);
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CustomerId";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "FirstName";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "LastName";
            this.Column3.Name = "Column3";
            // 
            // SProduct
            // 
            this.SProduct.Controls.Add(this.dataGridView6);
            this.SProduct.Location = new System.Drawing.Point(4, 22);
            this.SProduct.Name = "SProduct";
            this.SProduct.Padding = new System.Windows.Forms.Padding(3);
            this.SProduct.Size = new System.Drawing.Size(425, 231);
            this.SProduct.TabIndex = 2;
            this.SProduct.Text = "Product";
            this.SProduct.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView6.Location = new System.Drawing.Point(3, 3);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(419, 225);
            this.dataGridView6.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ProdutcId";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ProductName";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "WholeSaleCost";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "SaleCost";
            this.Column10.Name = "Column10";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(822, 22);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(85, 30);
            this.Search.TabIndex = 18;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.SearchData);
            // 
            // SearchCustomerId
            // 
            this.SearchCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCustomerId.Location = new System.Drawing.Point(611, 22);
            this.SearchCustomerId.Name = "SearchCustomerId";
            this.SearchCustomerId.Size = new System.Drawing.Size(176, 26);
            this.SearchCustomerId.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(413, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Search By Customer ID";
            // 
            // TPCustomer
            // 
            this.TPCustomer.Controls.Add(this.dataGridView1);
            this.TPCustomer.Location = new System.Drawing.Point(4, 22);
            this.TPCustomer.Name = "TPCustomer";
            this.TPCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.TPCustomer.Size = new System.Drawing.Size(411, 231);
            this.TPCustomer.TabIndex = 3;
            this.TPCustomer.Text = "Customer";
            this.TPCustomer.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "CustomerId";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "FirstName";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "LastName";
            this.Column13.Name = "Column13";
            // 
            // TPCustomerProduct
            // 
            this.TPCustomerProduct.Controls.Add(this.dataGridView2);
            this.TPCustomerProduct.Location = new System.Drawing.Point(4, 22);
            this.TPCustomerProduct.Name = "TPCustomerProduct";
            this.TPCustomerProduct.Padding = new System.Windows.Forms.Padding(3);
            this.TPCustomerProduct.Size = new System.Drawing.Size(411, 231);
            this.TPCustomerProduct.TabIndex = 1;
            this.TPCustomerProduct.Text = "CustomerProduct";
            this.TPCustomerProduct.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column14,
            this.Column15,
            this.Column16});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(405, 225);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "CustomerProductId";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "CustomerId";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "ProductId";
            this.Column16.Name = "Column16";
            // 
            // TCFooEnterprises
            // 
            this.TCFooEnterprises.Controls.Add(this.TPCustomerProduct);
            this.TCFooEnterprises.Controls.Add(this.TPCustomer);
            this.TCFooEnterprises.Controls.Add(this.TPProduct);
            this.TCFooEnterprises.Location = new System.Drawing.Point(29, 416);
            this.TCFooEnterprises.Name = "TCFooEnterprises";
            this.TCFooEnterprises.SelectedIndex = 0;
            this.TCFooEnterprises.Size = new System.Drawing.Size(419, 257);
            this.TCFooEnterprises.TabIndex = 16;
            // 
            // TPProduct
            // 
            this.TPProduct.Controls.Add(this.dataGridView3);
            this.TPProduct.Location = new System.Drawing.Point(4, 22);
            this.TPProduct.Name = "TPProduct";
            this.TPProduct.Padding = new System.Windows.Forms.Padding(3);
            this.TPProduct.Size = new System.Drawing.Size(411, 231);
            this.TPProduct.TabIndex = 4;
            this.TPProduct.Text = "Product";
            this.TPProduct.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(405, 225);
            this.dataGridView3.TabIndex = 0;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "ProductId";
            this.Column17.Name = "Column17";
            // 
            // Column18
            // 
            this.Column18.HeaderText = "ProductName";
            this.Column18.Name = "Column18";
            // 
            // Column19
            // 
            this.Column19.HeaderText = "WholeSaleCost";
            this.Column19.Name = "Column19";
            // 
            // Column20
            // 
            this.Column20.HeaderText = "SaleCost";
            this.Column20.Name = "Column20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 696);
            this.Controls.Add(this.SearchCustomerId);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.searchingTabControl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TCFooEnterprises);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customerProductId);
            this.Controls.Add(this.wholeSaleCost);
            this.Controls.Add(this.saleCost);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fooEnterprisesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fooEnterprisesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fooEnterprisesDataSet2)).EndInit();
            this.searchingTabControl.ResumeLayout(false);
            this.SCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.SProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.TPCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TPCustomerProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.TCFooEnterprises.ResumeLayout(false);
            this.TPProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox saleCost;
        private System.Windows.Forms.TextBox wholeSaleCost;
        private System.Windows.Forms.TextBox customerProductId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private FooEnterprisesDataSet fooEnterprisesDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private FooEnterprisesDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private FooEnterprisesDataSet1 fooEnterprisesDataSet1;
        private System.Windows.Forms.BindingSource customerProductBindingSource;
        private FooEnterprisesDataSet1TableAdapters.CustomerProductTableAdapter customerProductTableAdapter;
        private FooEnterprisesDataSet2 fooEnterprisesDataSet2;
        private System.Windows.Forms.BindingSource productBindingSource;
        private FooEnterprisesDataSet2TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.TabControl searchingTabControl;
        private System.Windows.Forms.TabPage SCustomer;
        private System.Windows.Forms.TabPage SProduct;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.TextBox SearchCustomerId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage TPCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.TabPage TPCustomerProduct;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.TabControl TCFooEnterprises;
        private System.Windows.Forms.TabPage TPProduct;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
    }
}

