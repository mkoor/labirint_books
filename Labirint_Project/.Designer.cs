namespace Labirint_Project
{
    partial class Labirint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Labirint));
            this.buttonAutho = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAutho
            // 
            this.buttonAutho.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAutho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAutho.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAutho.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAutho.Location = new System.Drawing.Point(321, 161);
            this.buttonAutho.Name = "buttonAutho";
            this.buttonAutho.Size = new System.Drawing.Size(219, 69);
            this.buttonAutho.TabIndex = 0;
            this.buttonAutho.Text = "Администратор";
            this.buttonAutho.UseVisualStyleBackColor = false;
            this.buttonAutho.Click += new System.EventHandler(this.button1_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::Labirint_Project.Properties.Resources.logo_v1;
            this.Logo.Location = new System.Drawing.Point(90, 7);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(408, 82);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(43, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 69);
            this.button1.TabIndex = 2;
            this.button1.Text = "Клиент";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelWelcome.Location = new System.Drawing.Point(24, 91);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(529, 22);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "Добро пожаловать в информационную систему \"Лабиринт\"!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(178, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите пользователя:";
            // 
            // Labirint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(575, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.buttonAutho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Labirint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабиринт";
            this.Load += new System.EventHandler(this.Labirint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAutho;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label label1;
    }
}

