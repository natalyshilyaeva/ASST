namespace KursGeneticAlgorithm
{
    partial class EnglishInformation
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.translate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(661, 491);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // translate
            // 
            this.translate.BackColor = System.Drawing.Color.RoyalBlue;
            this.translate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.translate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.translate.ForeColor = System.Drawing.Color.White;
            this.translate.Location = new System.Drawing.Point(12, 509);
            this.translate.Name = "translate";
            this.translate.Size = new System.Drawing.Size(129, 36);
            this.translate.TabIndex = 3;
            this.translate.Text = "Перевести";
            this.translate.UseVisualStyleBackColor = false;
            this.translate.Click += new System.EventHandler(this.translate_Click);
            // 
            // EnglishInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(680, 557);
            this.Controls.Add(this.translate);
            this.Controls.Add(this.richTextBox1);
            this.Name = "EnglishInformation";
            this.Text = "EnglishInformation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button translate;
    }
}