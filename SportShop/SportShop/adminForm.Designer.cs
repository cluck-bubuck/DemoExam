namespace SportShop
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.greenPanel = new System.Windows.Forms.Panel();
            this.prodGroup = new System.Windows.Forms.GroupBox();
            this.addTxt = new System.Windows.Forms.Button();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.logoLabel = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.maxDiscTxt = new System.Windows.Forms.TextBox();
            this.providerTxt = new System.Windows.Forms.TextBox();
            this.discountTxt = new System.Windows.Forms.TextBox();
            this.manufactTxt = new System.Windows.Forms.TextBox();
            this.countTxt = new System.Windows.Forms.TextBox();
            this.imageTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.discriptTxt = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.greenPanel.SuspendLayout();
            this.prodGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // greenPanel
            // 
            this.greenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.greenPanel.Controls.Add(this.prodGroup);
            this.greenPanel.Controls.Add(this.backBtn);
            this.greenPanel.Controls.Add(this.logoLabel);
            this.greenPanel.Location = new System.Drawing.Point(0, 0);
            this.greenPanel.Name = "greenPanel";
            this.greenPanel.Size = new System.Drawing.Size(580, 530);
            this.greenPanel.TabIndex = 5;
            // 
            // prodGroup
            // 
            this.prodGroup.Controls.Add(this.label9);
            this.prodGroup.Controls.Add(this.discriptTxt);
            this.prodGroup.Controls.Add(this.label8);
            this.prodGroup.Controls.Add(this.categoryCombo);
            this.prodGroup.Controls.Add(this.label7);
            this.prodGroup.Controls.Add(this.label6);
            this.prodGroup.Controls.Add(this.label5);
            this.prodGroup.Controls.Add(this.label4);
            this.prodGroup.Controls.Add(this.label3);
            this.prodGroup.Controls.Add(this.label2);
            this.prodGroup.Controls.Add(this.label1);
            this.prodGroup.Controls.Add(this.imageTxt);
            this.prodGroup.Controls.Add(this.countTxt);
            this.prodGroup.Controls.Add(this.manufactTxt);
            this.prodGroup.Controls.Add(this.discountTxt);
            this.prodGroup.Controls.Add(this.providerTxt);
            this.prodGroup.Controls.Add(this.maxDiscTxt);
            this.prodGroup.Controls.Add(this.priceTxt);
            this.prodGroup.Controls.Add(this.addTxt);
            this.prodGroup.Controls.Add(this.nameTxt);
            this.prodGroup.Controls.Add(this.logoPic);
            this.prodGroup.Controls.Add(this.nameLabel);
            this.prodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prodGroup.Location = new System.Drawing.Point(3, 38);
            this.prodGroup.Name = "prodGroup";
            this.prodGroup.Size = new System.Drawing.Size(614, 489);
            this.prodGroup.TabIndex = 15;
            this.prodGroup.TabStop = false;
            this.prodGroup.Text = "Добавление Товара";
            // 
            // addTxt
            // 
            this.addTxt.Location = new System.Drawing.Point(255, 439);
            this.addTxt.Name = "addTxt";
            this.addTxt.Size = new System.Drawing.Size(100, 35);
            this.addTxt.TabIndex = 14;
            this.addTxt.Text = "Добавить";
            this.addTxt.UseVisualStyleBackColor = true;
            this.addTxt.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(57, 49);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(151, 26);
            this.nameTxt.TabIndex = 11;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(82, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(87, 20);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Название:";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.Location = new System.Drawing.Point(3, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(79, 29);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // logoPic
            // 
            this.logoPic.Image = ((System.Drawing.Image)(resources.GetObject("logoPic.Image")));
            this.logoPic.Location = new System.Drawing.Point(448, 25);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(123, 108);
            this.logoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPic.TabIndex = 8;
            this.logoPic.TabStop = false;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoLabel.Location = new System.Drawing.Point(345, 3);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(229, 18);
            this.logoLabel.TabIndex = 7;
            this.logoLabel.Text = "ООО \"Спортивный магазин\"";
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(57, 117);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(151, 26);
            this.priceTxt.TabIndex = 15;
            // 
            // maxDiscTxt
            // 
            this.maxDiscTxt.Location = new System.Drawing.Point(57, 182);
            this.maxDiscTxt.Name = "maxDiscTxt";
            this.maxDiscTxt.Size = new System.Drawing.Size(151, 26);
            this.maxDiscTxt.TabIndex = 16;
            // 
            // providerTxt
            // 
            this.providerTxt.Location = new System.Drawing.Point(268, 49);
            this.providerTxt.Name = "providerTxt";
            this.providerTxt.Size = new System.Drawing.Size(151, 26);
            this.providerTxt.TabIndex = 17;
            // 
            // discountTxt
            // 
            this.discountTxt.Location = new System.Drawing.Point(268, 182);
            this.discountTxt.Name = "discountTxt";
            this.discountTxt.Size = new System.Drawing.Size(151, 26);
            this.discountTxt.TabIndex = 19;
            // 
            // manufactTxt
            // 
            this.manufactTxt.Location = new System.Drawing.Point(57, 246);
            this.manufactTxt.Name = "manufactTxt";
            this.manufactTxt.Size = new System.Drawing.Size(151, 26);
            this.manufactTxt.TabIndex = 20;
            // 
            // countTxt
            // 
            this.countTxt.Location = new System.Drawing.Point(268, 246);
            this.countTxt.Name = "countTxt";
            this.countTxt.Size = new System.Drawing.Size(151, 26);
            this.countTxt.TabIndex = 21;
            // 
            // imageTxt
            // 
            this.imageTxt.Location = new System.Drawing.Point(268, 306);
            this.imageTxt.Name = "imageTxt";
            this.imageTxt.Size = new System.Drawing.Size(151, 26);
            this.imageTxt.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Цена без скидки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Макс. возможная скидка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Производитель:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Поставщик:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Категория:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Текущая скидка:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Количество на складе:";
            // 
            // categoryCombo
            // 
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Items.AddRange(new object[] {
            "Выберите категорию:",
            "Одежда",
            "Спортивный инвентарь"});
            this.categoryCombo.Location = new System.Drawing.Point(268, 117);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(151, 28);
            this.categoryCombo.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Описание:";
            // 
            // discriptTxt
            // 
            this.discriptTxt.Location = new System.Drawing.Point(6, 306);
            this.discriptTxt.Name = "discriptTxt";
            this.discriptTxt.Size = new System.Drawing.Size(229, 168);
            this.discriptTxt.TabIndex = 35;
            this.discriptTxt.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Название изображения";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 528);
            this.Controls.Add(this.greenPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Спортивный магазин\"";
            this.greenPanel.ResumeLayout(false);
            this.greenPanel.PerformLayout();
            this.prodGroup.ResumeLayout(false);
            this.prodGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel greenPanel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.PictureBox logoPic;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Button addTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox prodGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imageTxt;
        private System.Windows.Forms.TextBox countTxt;
        private System.Windows.Forms.TextBox manufactTxt;
        private System.Windows.Forms.TextBox discountTxt;
        private System.Windows.Forms.TextBox providerTxt;
        private System.Windows.Forms.TextBox maxDiscTxt;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox discriptTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox categoryCombo;
    }
}