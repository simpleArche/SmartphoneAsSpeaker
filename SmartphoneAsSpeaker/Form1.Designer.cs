namespace SmartphoneAsSpeaker
{
    partial class Form1
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
            this.picQRcode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQRcode)).BeginInit();
            this.SuspendLayout();
            // 
            // picQRcode
            // 
            this.picQRcode.BackColor = System.Drawing.SystemColors.Window;
            this.picQRcode.Location = new System.Drawing.Point(12, 12);
            this.picQRcode.Name = "picQRcode";
            this.picQRcode.Size = new System.Drawing.Size(300, 300);
            this.picQRcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQRcode.TabIndex = 0;
            this.picQRcode.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(327, 325);
            this.Controls.Add(this.picQRcode);
            this.Name = "Form1";
            this.Text = "smartphoneAsSpeaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQRcode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picQRcode;
    }
}

