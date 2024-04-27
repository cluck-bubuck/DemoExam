namespace SportShop
{
    partial class LogForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.logTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.upPanel = new System.Windows.Forms.Panel();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.logoLabel = new System.Windows.Forms.Label();
            this.downPanel = new System.Windows.Forms.Panel();
            this.guestBtn = new System.Windows.Forms.Button();
            this.logLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.capchaTxt = new System.Windows.Forms.TextBox();
            this.capchaBtn = new System.Windows.Forms.Button();
            this.capchaPic = new System.Windows.Forms.PictureBox();
            this.blockTimer = new System.Windows.Forms.Timer(this.components);
            this.waitLabel = new System.Windows.Forms.Label();
            this.upPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.downPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capchaPic)).BeginInit();
            this.SuspendLayout();
            // 
            // logTxt
            // 
            this.logTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.logTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logTxt.Location = new System.Drawing.Point(144, 150);
            this.logTxt.Name = "logTxt";
            this.logTxt.Size = new System.Drawing.Size(170, 26);
            this.logTxt.TabIndex = 0;
            // 
            // passTxt
            // 
            this.passTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.passTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTxt.Location = new System.Drawing.Point(144, 204);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(170, 26);
            this.passTxt.TabIndex = 1;
            // 
            // enterBtn
            // 
            this.enterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.enterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterBtn.Location = new System.Drawing.Point(172, 3);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(86, 42);
            this.enterBtn.TabIndex = 2;
            this.enterBtn.Text = "Войти";
            this.enterBtn.UseVisualStyleBackColor = false;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // upPanel
            // 
            this.upPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.upPanel.Controls.Add(this.logoPic);
            this.upPanel.Controls.Add(this.logoLabel);
            this.upPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upPanel.Location = new System.Drawing.Point(0, 0);
            this.upPanel.Name = "upPanel";
            this.upPanel.Size = new System.Drawing.Size(411, 114);
            this.upPanel.TabIndex = 3;
            // 
            // logoPic
            // 
            this.logoPic.Image = ((System.Drawing.Image)(resources.GetObject("logoPic.Image")));
            this.logoPic.Location = new System.Drawing.Point(288, 3);
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
            this.logoLabel.Location = new System.Drawing.Point(14, 36);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(229, 18);
            this.logoLabel.TabIndex = 7;
            this.logoLabel.Text = "ООО \"Спортивный магазин\"";
            // 
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.downPanel.Controls.Add(this.guestBtn);
            this.downPanel.Controls.Add(this.enterBtn);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 344);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(411, 114);
            this.downPanel.TabIndex = 4;
            // 
            // guestBtn
            // 
            this.guestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.guestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestBtn.Location = new System.Drawing.Point(146, 51);
            this.guestBtn.Name = "guestBtn";
            this.guestBtn.Size = new System.Drawing.Size(140, 33);
            this.guestBtn.TabIndex = 3;
            this.guestBtn.Text = "Войти как гость";
            this.guestBtn.UseVisualStyleBackColor = false;
            this.guestBtn.Click += new System.EventHandler(this.guestBtn_Click);
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logLabel.Location = new System.Drawing.Point(83, 153);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(55, 20);
            this.logLabel.TabIndex = 5;
            this.logLabel.Text = "Логин";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.Location = new System.Drawing.Point(71, 207);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(67, 20);
            this.passLabel.TabIndex = 6;
            this.passLabel.Text = "Пароль";
            // 
            // capchaTxt
            // 
            this.capchaTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.capchaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capchaTxt.Location = new System.Drawing.Point(293, 274);
            this.capchaTxt.Name = "capchaTxt";
            this.capchaTxt.Size = new System.Drawing.Size(106, 26);
            this.capchaTxt.TabIndex = 7;
            // 
            // capchaBtn
            // 
            this.capchaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.capchaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capchaBtn.Location = new System.Drawing.Point(293, 311);
            this.capchaBtn.Name = "capchaBtn";
            this.capchaBtn.Size = new System.Drawing.Size(106, 27);
            this.capchaBtn.TabIndex = 4;
            this.capchaBtn.Text = "Ввод";
            this.capchaBtn.UseVisualStyleBackColor = false;
            // 
            // capchaPic
            // 
            this.capchaPic.Location = new System.Drawing.Point(117, 274);
            this.capchaPic.Name = "capchaPic";
            this.capchaPic.Size = new System.Drawing.Size(170, 64);
            this.capchaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.capchaPic.TabIndex = 9;
            this.capchaPic.TabStop = false;
            // 
            // blockTimer
            // 
            this.blockTimer.Tick += new System.EventHandler(this.blockTimer_Tick);
            // 
            // waitLabel
            // 
            this.waitLabel.AutoSize = true;
            this.waitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waitLabel.Location = new System.Drawing.Point(158, 233);
            this.waitLabel.Name = "waitLabel";
            this.waitLabel.Size = new System.Drawing.Size(113, 20);
            this.waitLabel.TabIndex = 10;
            this.waitLabel.Text = "Подождите ()";
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(411, 458);
            this.Controls.Add(this.waitLabel);
            this.Controls.Add(this.capchaPic);
            this.Controls.Add(this.capchaBtn);
            this.Controls.Add(this.capchaTxt);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.logTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Спортивный магазин\"";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.downPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.capchaPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Button guestBtn;
        private System.Windows.Forms.PictureBox logoPic;
        private System.Windows.Forms.TextBox capchaTxt;
        private System.Windows.Forms.Button capchaBtn;
        private System.Windows.Forms.PictureBox capchaPic;
        private System.Windows.Forms.Timer blockTimer;
        private System.Windows.Forms.Label waitLabel;
    }
}

