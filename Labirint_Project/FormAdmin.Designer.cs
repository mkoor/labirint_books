namespace Labirint_Project
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = global::Labirint_Project.Properties.Resources.logo_v1;
            this.Logo.Location = new System.Drawing.Point(22, 7);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(310, 82);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // buttonBook
            // 
            this.buttonBook.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBook.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBook.Location = new System.Drawing.Point(48, 130);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(256, 54);
            this.buttonBook.TabIndex = 6;
            this.buttonBook.Text = "Данные о книгах";
            this.buttonBook.UseVisualStyleBackColor = false;
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClient.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClient.Location = new System.Drawing.Point(48, 203);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(256, 54);
            this.buttonClient.TabIndex = 7;
            this.buttonClient.Text = "Данные о клиентах";
            this.buttonClient.UseVisualStyleBackColor = false;
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrder.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOrder.Location = new System.Drawing.Point(48, 276);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(256, 54);
            this.buttonOrder.TabIndex = 8;
            this.buttonOrder.Text = "Данные о заказах";
            this.buttonOrder.UseVisualStyleBackColor = false;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHello.Location = new System.Drawing.Point(95, 92);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(109, 18);
            this.labelHello.TabIndex = 9;
            this.labelHello.Text = "Здравствуйте, ";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(355, 352);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.Logo);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Label labelHello;
    }
}