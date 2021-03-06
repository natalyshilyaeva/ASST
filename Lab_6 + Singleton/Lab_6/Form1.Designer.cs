namespace Lab_6
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
            this.button_background = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxFoto = new System.Windows.Forms.ListBox();
            this.labelFoto = new System.Windows.Forms.Label();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.buttonFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // button_background
            // 
            this.button_background.BackColor = System.Drawing.Color.Plum;
            this.button_background.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_background.Location = new System.Drawing.Point(406, 520);
            this.button_background.Name = "button_background";
            this.button_background.Size = new System.Drawing.Size(245, 79);
            this.button_background.TabIndex = 0;
            this.button_background.Text = "Изменение фона";
            this.button_background.UseVisualStyleBackColor = false;
            this.button_background.Click += new System.EventHandler(this.Button_background_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 603);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // listBoxFoto
            // 
            this.listBoxFoto.FormattingEnabled = true;
            this.listBoxFoto.ItemHeight = 16;
            this.listBoxFoto.Location = new System.Drawing.Point(12, 74);
            this.listBoxFoto.Name = "listBoxFoto";
            this.listBoxFoto.Size = new System.Drawing.Size(312, 404);
            this.listBoxFoto.TabIndex = 2;
            this.listBoxFoto.SelectedIndexChanged += new System.EventHandler(this.ListBoxFoto_SelectedIndexChanged);
            // 
            // labelFoto
            // 
            this.labelFoto.AutoSize = true;
            this.labelFoto.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFoto.Location = new System.Drawing.Point(12, 26);
            this.labelFoto.Name = "labelFoto";
            this.labelFoto.Size = new System.Drawing.Size(92, 24);
            this.labelFoto.TabIndex = 3;
            this.labelFoto.Text = "Картинки";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(349, 74);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(358, 404);
            this.pictureBoxFoto.TabIndex = 4;
            this.pictureBoxFoto.TabStop = false;
            // 
            // buttonFoto
            // 
            this.buttonFoto.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonFoto.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFoto.Location = new System.Drawing.Point(78, 498);
            this.buttonFoto.Name = "buttonFoto";
            this.buttonFoto.Size = new System.Drawing.Size(175, 59);
            this.buttonFoto.TabIndex = 5;
            this.buttonFoto.Text = "Выбор папки с фотографиями";
            this.buttonFoto.UseVisualStyleBackColor = false;
            this.buttonFoto.Click += new System.EventHandler(this.ButtonFoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 647);
            this.Controls.Add(this.buttonFoto);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.labelFoto);
            this.Controls.Add(this.listBoxFoto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_background);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_background;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxFoto;
        private System.Windows.Forms.Label labelFoto;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Button buttonFoto;
    }
}

