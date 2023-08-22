namespace Okra
{
    partial class FrmProforma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProforma));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyName = new DevExpress.XtraEditors.TextEdit();
            this.cmbFabricColors = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbFabrics = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbFootColors = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbFeet = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbProductColors = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbCategories = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbProducts = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiscount = new System.Windows.Forms.NumericUpDown();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new System.Windows.Forms.NumericUpDown();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFabricColors.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFabrics.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFootColors.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFeet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductColors.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategories.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtPrice);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.txtCompanyName);
            this.groupControl1.Controls.Add(this.cmbFabricColors);
            this.groupControl1.Controls.Add(this.cmbFabrics);
            this.groupControl1.Controls.Add(this.cmbFootColors);
            this.groupControl1.Controls.Add(this.cmbFeet);
            this.groupControl1.Controls.Add(this.cmbProductColors);
            this.groupControl1.Controls.Add(this.cmbCategories);
            this.groupControl1.Controls.Add(this.cmbProducts);
            this.groupControl1.Controls.Add(this.btnClear);
            this.groupControl1.Controls.Add(this.btnUpdateProduct);
            this.groupControl1.Controls.Add(this.btnDeleteProduct);
            this.groupControl1.Controls.Add(this.btnAddProduct);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtDiscount);
            this.groupControl1.Controls.Add(this.txtAmount);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(4, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(976, 155);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "İŞLEMLER";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(700, 45);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(48, 20);
            this.txtPrice.TabIndex = 11;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(700, 26);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(48, 18);
            this.labelControl12.TabIndex = 10;
            this.labelControl12.Text = "FİYAT:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(32, 45);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(55, 20);
            this.txtCompanyName.TabIndex = 9;
            // 
            // cmbFabricColors
            // 
            this.cmbFabricColors.Location = new System.Drawing.Point(593, 45);
            this.cmbFabricColors.Name = "cmbFabricColors";
            this.cmbFabricColors.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFabricColors.Size = new System.Drawing.Size(101, 20);
            this.cmbFabricColors.TabIndex = 8;
            // 
            // cmbFabrics
            // 
            this.cmbFabrics.Location = new System.Drawing.Point(534, 45);
            this.cmbFabrics.Name = "cmbFabrics";
            this.cmbFabrics.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFabrics.Size = new System.Drawing.Size(53, 20);
            this.cmbFabrics.TabIndex = 8;
            // 
            // cmbFootColors
            // 
            this.cmbFootColors.Location = new System.Drawing.Point(438, 45);
            this.cmbFootColors.Name = "cmbFootColors";
            this.cmbFootColors.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFootColors.Size = new System.Drawing.Size(90, 20);
            this.cmbFootColors.TabIndex = 8;
            // 
            // cmbFeet
            // 
            this.cmbFeet.Location = new System.Drawing.Point(390, 45);
            this.cmbFeet.Name = "cmbFeet";
            this.cmbFeet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFeet.Size = new System.Drawing.Size(42, 20);
            this.cmbFeet.TabIndex = 8;
            // 
            // cmbProductColors
            // 
            this.cmbProductColors.Location = new System.Drawing.Point(292, 45);
            this.cmbProductColors.Name = "cmbProductColors";
            this.cmbProductColors.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProductColors.Size = new System.Drawing.Size(92, 20);
            this.cmbProductColors.TabIndex = 8;
            // 
            // cmbCategories
            // 
            this.cmbCategories.Location = new System.Drawing.Point(159, 45);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCategories.Size = new System.Drawing.Size(77, 20);
            this.cmbCategories.TabIndex = 8;
            // 
            // cmbProducts
            // 
            this.cmbProducts.Location = new System.Drawing.Point(242, 45);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProducts.Size = new System.Drawing.Size(44, 20);
            this.cmbProducts.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.Image")));
            this.btnClear.Location = new System.Drawing.Point(852, 71);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 35);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "TEMİZLE";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnUpdateProduct.Appearance.Options.UseFont = true;
            this.btnUpdateProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateProduct.ImageOptions.Image")));
            this.btnUpdateProduct.Location = new System.Drawing.Point(727, 71);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(119, 35);
            this.btnUpdateProduct.TabIndex = 6;
            this.btnUpdateProduct.Text = "GÜNCELLE";
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnDeleteProduct.Appearance.Options.UseFont = true;
            this.btnDeleteProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteProduct.ImageOptions.Image")));
            this.btnDeleteProduct.Location = new System.Drawing.Point(852, 112);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(119, 35);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "SİL";
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnAddProduct.Appearance.Options.UseFont = true;
            this.btnAddProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.ImageOptions.Image")));
            this.btnAddProduct.Location = new System.Drawing.Point(593, 71);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(119, 35);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "KAYDET";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(534, 26);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(53, 18);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "KUMAŞ:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(754, 46);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(70, 21);
            this.txtDiscount.TabIndex = 3;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(93, 44);
            this.txtAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(60, 21);
            this.txtAmount.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(390, 26);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 18);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "AYAK:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(768, 123);
            this.txtId.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(68, 21);
            this.txtId.TabIndex = 3;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(159, 26);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(77, 18);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "KATEGORİ:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(593, 26);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(101, 18);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "KUMAŞ RENGİ:";
            this.labelControl7.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(242, 26);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 18);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "ÜRÜN:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(438, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "AYAK RENGİ:";
            this.labelControl3.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(754, 26);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(70, 18);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "İSKONTO:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(32, 26);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(55, 18);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "ŞİRKET:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(93, 26);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 18);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "MİKTAR:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(292, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(92, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "ÜRÜN RENGİ:";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(741, 123);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(4, 166);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(976, 483);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // FrmProforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "FrmProforma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proforma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProforma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFabricColors.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFabrics.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFootColors.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFeet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductColors.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategories.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnUpdateProduct;
        private DevExpress.XtraEditors.SimpleButton btnDeleteProduct;
        private DevExpress.XtraEditors.SimpleButton btnAddProduct;
        private System.Windows.Forms.NumericUpDown txtId;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cmbProducts;
        private DevExpress.XtraEditors.ComboBoxEdit cmbFabricColors;
        private DevExpress.XtraEditors.ComboBoxEdit cmbFabrics;
        private DevExpress.XtraEditors.ComboBoxEdit cmbFootColors;
        private DevExpress.XtraEditors.ComboBoxEdit cmbFeet;
        private DevExpress.XtraEditors.ComboBoxEdit cmbProductColors;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCategories;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtCompanyName;
        private System.Windows.Forms.NumericUpDown txtDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl11;
    }
}