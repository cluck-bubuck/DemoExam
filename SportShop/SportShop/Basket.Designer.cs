namespace SportShop
{
    partial class Basket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Basket));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pointLabel = new System.Windows.Forms.Label();
            this.basketLabel = new System.Windows.Forms.Label();
            this.pointCombo = new System.Windows.Forms.ComboBox();
            this.basketTxt = new System.Windows.Forms.ListBox();
            this.orderBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.logoLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.mainPanel.Controls.Add(this.pointLabel);
            this.mainPanel.Controls.Add(this.basketLabel);
            this.mainPanel.Controls.Add(this.pointCombo);
            this.mainPanel.Controls.Add(this.basketTxt);
            this.mainPanel.Controls.Add(this.orderBtn);
            this.mainPanel.Controls.Add(this.backBtn);
            this.mainPanel.Controls.Add(this.logoPic);
            this.mainPanel.Controls.Add(this.logoLabel);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(430, 451);
            this.mainPanel.TabIndex = 4;
            // 
            // pointLabel
            // 
            this.pointLabel.AutoSize = true;
            this.pointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointLabel.Location = new System.Drawing.Point(11, 316);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(188, 20);
            this.pointLabel.TabIndex = 14;
            this.pointLabel.Text = "Выбрать пункт выдачи:";
            // 
            // basketLabel
            // 
            this.basketLabel.AutoSize = true;
            this.basketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.basketLabel.Location = new System.Drawing.Point(12, 107);
            this.basketLabel.Name = "basketLabel";
            this.basketLabel.Size = new System.Drawing.Size(76, 20);
            this.basketLabel.TabIndex = 13;
            this.basketLabel.Text = "Корзина:";
            // 
            // pointCombo
            // 
            this.pointCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointCombo.FormattingEnabled = true;
            this.pointCombo.Location = new System.Drawing.Point(12, 339);
            this.pointCombo.Name = "pointCombo";
            this.pointCombo.Size = new System.Drawing.Size(387, 28);
            this.pointCombo.TabIndex = 12;
            // 
            // basketTxt
            // 
            this.basketTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.basketTxt.FormattingEnabled = true;
            this.basketTxt.ItemHeight = 20;
            this.basketTxt.Location = new System.Drawing.Point(12, 131);
            this.basketTxt.Name = "basketTxt";
            this.basketTxt.Size = new System.Drawing.Size(387, 164);
            this.basketTxt.TabIndex = 11;
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.orderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderBtn.Location = new System.Drawing.Point(151, 391);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(90, 46);
            this.orderBtn.TabIndex = 10;
            this.orderBtn.Text = "Заказать";
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.Location = new System.Drawing.Point(3, 419);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(79, 29);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // logoPic
            // 
            this.logoPic.Image = ((System.Drawing.Image)(resources.GetObject("logoPic.Image")));
            this.logoPic.Location = new System.Drawing.Point(276, 12);
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
            this.logoLabel.Location = new System.Drawing.Point(41, 12);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(229, 18);
            this.logoLabel.TabIndex = 7;
            this.logoLabel.Text = "ООО \"Спортивный магазин\"";
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 449);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Basket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Спортивный магазин\"";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox logoPic;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox pointCombo;
        private System.Windows.Forms.ListBox basketTxt;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.Label basketLabel;
    }
}