namespace WindowsApplication1
{
    partial class TrafficLightView
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnTL = new System.Windows.Forms.Panel();
            this.pnGreen = new System.Windows.Forms.Panel();
            this.pnYellow = new System.Windows.Forms.Panel();
            this.pnRed = new System.Windows.Forms.Panel();
            this.tbRed = new System.Windows.Forms.TextBox();
            this.tbYellow = new System.Windows.Forms.TextBox();
            this.tbGreen = new System.Windows.Forms.TextBox();
            this.lRed = new System.Windows.Forms.Label();
            this.lYellow = new System.Windows.Forms.Label();
            this.lGreen = new System.Windows.Forms.Label();
            this.btnSetInt = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.pnTL.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            // 
            // pnTL
            // 
            this.pnTL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnTL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTL.Controls.Add(this.pnGreen);
            this.pnTL.Controls.Add(this.pnYellow);
            this.pnTL.Controls.Add(this.pnRed);
            this.pnTL.Location = new System.Drawing.Point(39, 34);
            this.pnTL.Margin = new System.Windows.Forms.Padding(4);
            this.pnTL.Name = "pnTL";
            this.pnTL.Size = new System.Drawing.Size(87, 114);
            this.pnTL.TabIndex = 0;
            // 
            // pnGreen
            // 
            this.pnGreen.BackColor = System.Drawing.SystemColors.WindowText;
            this.pnGreen.Location = new System.Drawing.Point(4, 78);
            this.pnGreen.Margin = new System.Windows.Forms.Padding(4);
            this.pnGreen.Name = "pnGreen";
            this.pnGreen.Size = new System.Drawing.Size(76, 30);
            this.pnGreen.TabIndex = 2;
            // 
            // pnYellow
            // 
            this.pnYellow.BackColor = System.Drawing.SystemColors.WindowText;
            this.pnYellow.Location = new System.Drawing.Point(4, 41);
            this.pnYellow.Margin = new System.Windows.Forms.Padding(4);
            this.pnYellow.Name = "pnYellow";
            this.pnYellow.Size = new System.Drawing.Size(76, 30);
            this.pnYellow.TabIndex = 2;
            // 
            // pnRed
            // 
            this.pnRed.BackColor = System.Drawing.SystemColors.WindowText;
            this.pnRed.Location = new System.Drawing.Point(4, 4);
            this.pnRed.Margin = new System.Windows.Forms.Padding(4);
            this.pnRed.Name = "pnRed";
            this.pnRed.Size = new System.Drawing.Size(76, 30);
            this.pnRed.TabIndex = 1;
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(240, 42);
            this.tbRed.Margin = new System.Windows.Forms.Padding(4);
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(132, 22);
            this.tbRed.TabIndex = 1;
            this.tbRed.Text = "1";
            // 
            // tbYellow
            // 
            this.tbYellow.Location = new System.Drawing.Point(240, 78);
            this.tbYellow.Margin = new System.Windows.Forms.Padding(4);
            this.tbYellow.Name = "tbYellow";
            this.tbYellow.Size = new System.Drawing.Size(132, 22);
            this.tbYellow.TabIndex = 2;
            this.tbYellow.Text = "1";
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(240, 116);
            this.tbGreen.Margin = new System.Windows.Forms.Padding(4);
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(132, 22);
            this.tbGreen.TabIndex = 3;
            this.tbGreen.Text = "1";
            // 
            // lRed
            // 
            this.lRed.AutoSize = true;
            this.lRed.Location = new System.Drawing.Point(163, 46);
            this.lRed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRed.Name = "lRed";
            this.lRed.Size = new System.Drawing.Size(66, 17);
            this.lRed.TabIndex = 4;
            this.lRed.Text = "Красный";
            // 
            // lYellow
            // 
            this.lYellow.AutoSize = true;
            this.lYellow.Location = new System.Drawing.Point(163, 82);
            this.lYellow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lYellow.Name = "lYellow";
            this.lYellow.Size = new System.Drawing.Size(62, 17);
            this.lYellow.TabIndex = 5;
            this.lYellow.Text = "Желтый";
            // 
            // lGreen
            // 
            this.lGreen.AutoSize = true;
            this.lGreen.Location = new System.Drawing.Point(163, 119);
            this.lGreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lGreen.Name = "lGreen";
            this.lGreen.Size = new System.Drawing.Size(67, 17);
            this.lGreen.TabIndex = 6;
            this.lGreen.Text = "Зеленый";
            // 
            // btnSetInt
            // 
            this.btnSetInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetInt.Location = new System.Drawing.Point(167, 158);
            this.btnSetInt.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetInt.Name = "btnSetInt";
            this.btnSetInt.Size = new System.Drawing.Size(206, 28);
            this.btnSetInt.TabIndex = 7;
            this.btnSetInt.Text = "Установить интервалы";
            this.btnSetInt.UseVisualStyleBackColor = true;
            this.btnSetInt.Click += new System.EventHandler(this.btnSetInt_Click);
            // 
            // btnOn
            // 
            this.btnOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOn.Location = new System.Drawing.Point(39, 158);
            this.btnOn.Margin = new System.Windows.Forms.Padding(4);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(88, 28);
            this.btnOn.TabIndex = 8;
            this.btnOn.Text = "Включить";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff.Location = new System.Drawing.Point(25, 194);
            this.btnOff.Margin = new System.Windows.Forms.Padding(4);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(115, 28);
            this.btnOff.TabIndex = 9;
            this.btnOff.Text = "Выключить";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // TrafficLightView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 233);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.btnSetInt);
            this.Controls.Add(this.lGreen);
            this.Controls.Add(this.lYellow);
            this.Controls.Add(this.lRed);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbYellow);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.pnTL);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TrafficLightView";
            this.Text = "ПЕРВЫЙ ВИД";
            this.pnTL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnTL;
        private System.Windows.Forms.Panel pnYellow;
        private System.Windows.Forms.Panel pnGreen;
        private System.Windows.Forms.Panel pnRed;
        private System.Windows.Forms.TextBox tbRed;
        private System.Windows.Forms.TextBox tbYellow;
        private System.Windows.Forms.TextBox tbGreen;
        private System.Windows.Forms.Label lRed;
        private System.Windows.Forms.Label lYellow;
        private System.Windows.Forms.Label lGreen;
        private System.Windows.Forms.Button btnSetInt;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
    }
}

