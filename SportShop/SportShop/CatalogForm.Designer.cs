namespace SportShop
{
    partial class CatalogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogForm));
            this.upPanel = new System.Windows.Forms.Panel();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterCombo = new System.Windows.Forms.ComboBox();
            this.basketBtn = new System.Windows.Forms.Button();
            this.prodCountLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.downPanel = new System.Windows.Forms.Panel();
            this.infoLabel = new System.Windows.Forms.Panel();
            this.nameProdLabel1 = new System.Windows.Forms.Label();
            this.priceLabel1 = new System.Windows.Forms.Label();
            this.manufactLabel1 = new System.Windows.Forms.Label();
            this.discriptionLabel1 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.manufactLabel = new System.Windows.Forms.Label();
            this.discriptionLabel = new System.Windows.Forms.Label();
            this.nameProdLabel = new System.Windows.Forms.Label();
            this.countPanel = new System.Windows.Forms.Panel();
            this.discountLabel = new System.Windows.Forms.Label();
            this.panelForPhoto = new System.Windows.Forms.Panel();
            this.prodPic = new System.Windows.Forms.PictureBox();
            this.prodData = new System.Windows.Forms.DataGridView();
            this.артикульDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скидкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.производительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.максимальнаяСкидкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terna_SportShopDataSet = new SportShop.Terna_SportShopDataSet();
            this.productViewTableAdapter = new SportShop.Terna_SportShopDataSetTableAdapters.ProductViewTableAdapter();
            this.upPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.downPanel.SuspendLayout();
            this.infoLabel.SuspendLayout();
            this.countPanel.SuspendLayout();
            this.panelForPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_SportShopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // upPanel
            // 
            this.upPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.upPanel.Controls.Add(this.logoPic);
            this.upPanel.Controls.Add(this.searchLabel);
            this.upPanel.Controls.Add(this.searchTxt);
            this.upPanel.Controls.Add(this.filterLabel);
            this.upPanel.Controls.Add(this.filterCombo);
            this.upPanel.Controls.Add(this.basketBtn);
            this.upPanel.Controls.Add(this.prodCountLabel);
            this.upPanel.Controls.Add(this.backBtn);
            this.upPanel.Controls.Add(this.lblname);
            this.upPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upPanel.Location = new System.Drawing.Point(0, 0);
            this.upPanel.Name = "upPanel";
            this.upPanel.Size = new System.Drawing.Size(847, 140);
            this.upPanel.TabIndex = 4;
            // 
            // logoPic
            // 
            this.logoPic.Image = ((System.Drawing.Image)(resources.GetObject("logoPic.Image")));
            this.logoPic.Location = new System.Drawing.Point(711, 11);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(123, 108);
            this.logoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPic.TabIndex = 9;
            this.logoPic.TabStop = false;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchLabel.Location = new System.Drawing.Point(17, 74);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(59, 20);
            this.searchLabel.TabIndex = 15;
            this.searchLabel.Text = "Поиск:";
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTxt.Location = new System.Drawing.Point(21, 98);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(137, 26);
            this.searchTxt.TabIndex = 14;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterLabel.Location = new System.Drawing.Point(179, 74);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(85, 20);
            this.filterLabel.TabIndex = 13;
            this.filterLabel.Text = "Фильтры:";
            // 
            // filterCombo
            // 
            this.filterCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterCombo.FormattingEnabled = true;
            this.filterCombo.Items.AddRange(new object[] {
            "Выберите скидку:",
            "0-9.99%",
            "10-14.99%",
            "15% и больше"});
            this.filterCombo.Location = new System.Drawing.Point(183, 97);
            this.filterCombo.Name = "filterCombo";
            this.filterCombo.Size = new System.Drawing.Size(121, 28);
            this.filterCombo.TabIndex = 12;
            // 
            // basketBtn
            // 
            this.basketBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.basketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.basketBtn.Location = new System.Drawing.Point(583, 11);
            this.basketBtn.Name = "basketBtn";
            this.basketBtn.Size = new System.Drawing.Size(122, 48);
            this.basketBtn.TabIndex = 11;
            this.basketBtn.Text = "Просмотреть корзину";
            this.basketBtn.UseVisualStyleBackColor = false;
            // 
            // prodCountLabel
            // 
            this.prodCountLabel.AutoSize = true;
            this.prodCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prodCountLabel.Location = new System.Drawing.Point(310, 101);
            this.prodCountLabel.Name = "prodCountLabel";
            this.prodCountLabel.Size = new System.Drawing.Size(244, 20);
            this.prodCountLabel.TabIndex = 9;
            this.prodCountLabel.Text = "37/37 продуктов показывается";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.Location = new System.Drawing.Point(12, 8);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(79, 29);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblname.Location = new System.Drawing.Point(322, 8);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(229, 18);
            this.lblname.TabIndex = 7;
            this.lblname.Text = "ООО \"Спортивный магазин\"";
            // 
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.downPanel.Controls.Add(this.infoLabel);
            this.downPanel.Controls.Add(this.countPanel);
            this.downPanel.Controls.Add(this.panelForPhoto);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 427);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(847, 140);
            this.downPanel.TabIndex = 8;
            // 
            // infoLabel
            // 
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoLabel.Controls.Add(this.nameProdLabel1);
            this.infoLabel.Controls.Add(this.priceLabel1);
            this.infoLabel.Controls.Add(this.manufactLabel1);
            this.infoLabel.Controls.Add(this.discriptionLabel1);
            this.infoLabel.Controls.Add(this.priceLabel);
            this.infoLabel.Controls.Add(this.manufactLabel);
            this.infoLabel.Controls.Add(this.discriptionLabel);
            this.infoLabel.Controls.Add(this.nameProdLabel);
            this.infoLabel.Location = new System.Drawing.Point(236, 8);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(420, 118);
            this.infoLabel.TabIndex = 10;
            // 
            // nameProdLabel1
            // 
            this.nameProdLabel1.AutoSize = true;
            this.nameProdLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameProdLabel1.Location = new System.Drawing.Point(164, 0);
            this.nameProdLabel1.Name = "nameProdLabel1";
            this.nameProdLabel1.Size = new System.Drawing.Size(54, 20);
            this.nameProdLabel1.TabIndex = 9;
            this.nameProdLabel1.Text = "Товар";
            // 
            // priceLabel1
            // 
            this.priceLabel1.AutoSize = true;
            this.priceLabel1.Location = new System.Drawing.Point(56, 89);
            this.priceLabel1.Name = "priceLabel1";
            this.priceLabel1.Size = new System.Drawing.Size(33, 13);
            this.priceLabel1.TabIndex = 7;
            this.priceLabel1.Text = "Цена";
            // 
            // manufactLabel1
            // 
            this.manufactLabel1.AutoSize = true;
            this.manufactLabel1.Location = new System.Drawing.Point(108, 61);
            this.manufactLabel1.Name = "manufactLabel1";
            this.manufactLabel1.Size = new System.Drawing.Size(86, 13);
            this.manufactLabel1.TabIndex = 6;
            this.manufactLabel1.Text = "Производитель";
            // 
            // discriptionLabel1
            // 
            this.discriptionLabel1.AutoSize = true;
            this.discriptionLabel1.Location = new System.Drawing.Point(118, 36);
            this.discriptionLabel1.Name = "discriptionLabel1";
            this.discriptionLabel1.Size = new System.Drawing.Size(57, 13);
            this.discriptionLabel1.TabIndex = 5;
            this.discriptionLabel1.Text = "Описание";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(14, 89);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(36, 13);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Цена:";
            // 
            // manufactLabel
            // 
            this.manufactLabel.AutoSize = true;
            this.manufactLabel.Location = new System.Drawing.Point(14, 61);
            this.manufactLabel.Name = "manufactLabel";
            this.manufactLabel.Size = new System.Drawing.Size(89, 13);
            this.manufactLabel.TabIndex = 2;
            this.manufactLabel.Text = "Производитель:";
            // 
            // discriptionLabel
            // 
            this.discriptionLabel.AutoSize = true;
            this.discriptionLabel.Location = new System.Drawing.Point(14, 36);
            this.discriptionLabel.Name = "discriptionLabel";
            this.discriptionLabel.Size = new System.Drawing.Size(98, 13);
            this.discriptionLabel.TabIndex = 1;
            this.discriptionLabel.Text = "Описание товара:";
            // 
            // nameProdLabel
            // 
            this.nameProdLabel.AutoSize = true;
            this.nameProdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameProdLabel.Location = new System.Drawing.Point(13, 0);
            this.nameProdLabel.Name = "nameProdLabel";
            this.nameProdLabel.Size = new System.Drawing.Size(145, 20);
            this.nameProdLabel.TabIndex = 0;
            this.nameProdLabel.Text = "Название товара:";
            // 
            // countPanel
            // 
            this.countPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countPanel.Controls.Add(this.discountLabel);
            this.countPanel.Location = new System.Drawing.Point(686, 8);
            this.countPanel.Name = "countPanel";
            this.countPanel.Size = new System.Drawing.Size(148, 118);
            this.countPanel.TabIndex = 9;
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountLabel.Location = new System.Drawing.Point(62, 45);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(18, 20);
            this.discountLabel.TabIndex = 8;
            this.discountLabel.Text = "0";
            // 
            // panelForPhoto
            // 
            this.panelForPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelForPhoto.Controls.Add(this.prodPic);
            this.panelForPhoto.Location = new System.Drawing.Point(31, 8);
            this.panelForPhoto.Name = "panelForPhoto";
            this.panelForPhoto.Size = new System.Drawing.Size(148, 118);
            this.panelForPhoto.TabIndex = 8;
            // 
            // prodPic
            // 
            this.prodPic.Location = new System.Drawing.Point(-2, -1);
            this.prodPic.Name = "prodPic";
            this.prodPic.Size = new System.Drawing.Size(148, 117);
            this.prodPic.TabIndex = 0;
            this.prodPic.TabStop = false;
            // 
            // prodData
            // 
            this.prodData.AllowUserToAddRows = false;
            this.prodData.AllowUserToDeleteRows = false;
            this.prodData.AutoGenerateColumns = false;
            this.prodData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.prodData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.артикульDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.скидкаDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.производительDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.максимальнаяСкидкаDataGridViewTextBoxColumn,
            this.фотоDataGridViewTextBoxColumn});
            this.prodData.DataSource = this.productViewBindingSource;
            this.prodData.Location = new System.Drawing.Point(1, 137);
            this.prodData.Name = "prodData";
            this.prodData.ReadOnly = true;
            this.prodData.Size = new System.Drawing.Size(846, 294);
            this.prodData.TabIndex = 9;
            this.prodData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodData_CellClick);
            // 
            // артикульDataGridViewTextBoxColumn
            // 
            this.артикульDataGridViewTextBoxColumn.DataPropertyName = "Артикуль";
            this.артикульDataGridViewTextBoxColumn.HeaderText = "Артикуль";
            this.артикульDataGridViewTextBoxColumn.Name = "артикульDataGridViewTextBoxColumn";
            this.артикульDataGridViewTextBoxColumn.ReadOnly = true;
            this.артикульDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // скидкаDataGridViewTextBoxColumn
            // 
            this.скидкаDataGridViewTextBoxColumn.DataPropertyName = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.HeaderText = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.Name = "скидкаDataGridViewTextBoxColumn";
            this.скидкаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // производительDataGridViewTextBoxColumn
            // 
            this.производительDataGridViewTextBoxColumn.DataPropertyName = "Производитель";
            this.производительDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.производительDataGridViewTextBoxColumn.Name = "производительDataGridViewTextBoxColumn";
            this.производительDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // максимальнаяСкидкаDataGridViewTextBoxColumn
            // 
            this.максимальнаяСкидкаDataGridViewTextBoxColumn.DataPropertyName = "Максимальная скидка";
            this.максимальнаяСкидкаDataGridViewTextBoxColumn.HeaderText = "Максимальная скидка";
            this.максимальнаяСкидкаDataGridViewTextBoxColumn.Name = "максимальнаяСкидкаDataGridViewTextBoxColumn";
            this.максимальнаяСкидкаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фотоDataGridViewTextBoxColumn
            // 
            this.фотоDataGridViewTextBoxColumn.DataPropertyName = "Фото";
            this.фотоDataGridViewTextBoxColumn.HeaderText = "Фото";
            this.фотоDataGridViewTextBoxColumn.Name = "фотоDataGridViewTextBoxColumn";
            this.фотоDataGridViewTextBoxColumn.ReadOnly = true;
            this.фотоDataGridViewTextBoxColumn.Visible = false;
            // 
            // productViewBindingSource
            // 
            this.productViewBindingSource.DataMember = "ProductView";
            this.productViewBindingSource.DataSource = this.terna_SportShopDataSet;
            // 
            // terna_SportShopDataSet
            // 
            this.terna_SportShopDataSet.DataSetName = "Terna_SportShopDataSet";
            this.terna_SportShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productViewTableAdapter
            // 
            this.productViewTableAdapter.ClearBeforeFill = true;
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 567);
            this.Controls.Add(this.prodData);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.upPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Спортивный магазин\"";
            this.Load += new System.EventHandler(this.Catalog_Form_Load);
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.downPanel.ResumeLayout(false);
            this.infoLabel.ResumeLayout(false);
            this.infoLabel.PerformLayout();
            this.countPanel.ResumeLayout(false);
            this.countPanel.PerformLayout();
            this.panelForPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prodPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terna_SportShopDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Panel countPanel;
        private System.Windows.Forms.Panel panelForPhoto;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel infoLabel;
        private System.Windows.Forms.Label priceLabel1;
        private System.Windows.Forms.Label manufactLabel1;
        private System.Windows.Forms.Label discriptionLabel1;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label manufactLabel;
        private System.Windows.Forms.Label discriptionLabel;
        private System.Windows.Forms.Label nameProdLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.PictureBox prodPic;
        private System.Windows.Forms.DataGridView prodData;
        private System.Windows.Forms.Button basketBtn;
        private System.Windows.Forms.Label prodCountLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.ComboBox filterCombo;
        private System.Windows.Forms.PictureBox logoPic;
        private System.Windows.Forms.Label nameProdLabel1;
        private Terna_SportShopDataSet terna_SportShopDataSet;
        private System.Windows.Forms.BindingSource productViewBindingSource;
        private Terna_SportShopDataSetTableAdapters.ProductViewTableAdapter productViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикульDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скидкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn производительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn максимальнаяСкидкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фотоDataGridViewTextBoxColumn;
    }
}