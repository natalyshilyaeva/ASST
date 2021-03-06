namespace Lab_3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.заказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пиццаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.фамилияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сушиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фамилияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.суммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Pizza = new System.Windows.Forms.Label();
            this.label_Sushi = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказToolStripMenuItem,
            this.суммаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(995, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // заказToolStripMenuItem
            // 
            this.заказToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пиццаToolStripMenuItem1,
            this.сушиToolStripMenuItem});
            this.заказToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.заказToolStripMenuItem.Name = "заказToolStripMenuItem";
            this.заказToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.заказToolStripMenuItem.Text = "Заказ";
            // 
            // пиццаToolStripMenuItem1
            // 
            this.пиццаToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фамилияToolStripMenuItem,
            this.данныеToolStripMenuItem});
            this.пиццаToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("пиццаToolStripMenuItem1.Image")));
            this.пиццаToolStripMenuItem1.Name = "пиццаToolStripMenuItem1";
            this.пиццаToolStripMenuItem1.Size = new System.Drawing.Size(138, 26);
            this.пиццаToolStripMenuItem1.Text = "Пицца";
            // 
            // фамилияToolStripMenuItem
            // 
            this.фамилияToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("фамилияToolStripMenuItem.Image")));
            this.фамилияToolStripMenuItem.Name = "фамилияToolStripMenuItem";
            this.фамилияToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.фамилияToolStripMenuItem.Text = "Фамилия";
            this.фамилияToolStripMenuItem.Click += new System.EventHandler(this.ФамилияToolStripMenuItem_Click);
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("данныеToolStripMenuItem.Image")));
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.данныеToolStripMenuItem.Text = "Данные";
            this.данныеToolStripMenuItem.Click += new System.EventHandler(this.ДанныеToolStripMenuItem_Click);
            // 
            // сушиToolStripMenuItem
            // 
            this.сушиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фамилияToolStripMenuItem1,
            this.данныеToolStripMenuItem1});
            this.сушиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сушиToolStripMenuItem.Image")));
            this.сушиToolStripMenuItem.Name = "сушиToolStripMenuItem";
            this.сушиToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.сушиToolStripMenuItem.Text = "Суши";
            // 
            // фамилияToolStripMenuItem1
            // 
            this.фамилияToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("фамилияToolStripMenuItem1.Image")));
            this.фамилияToolStripMenuItem1.Name = "фамилияToolStripMenuItem1";
            this.фамилияToolStripMenuItem1.Size = new System.Drawing.Size(156, 26);
            this.фамилияToolStripMenuItem1.Text = "Фамилия";
            this.фамилияToolStripMenuItem1.Click += new System.EventHandler(this.ФамилияToolStripMenuItem1_Click);
            // 
            // данныеToolStripMenuItem1
            // 
            this.данныеToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("данныеToolStripMenuItem1.Image")));
            this.данныеToolStripMenuItem1.Name = "данныеToolStripMenuItem1";
            this.данныеToolStripMenuItem1.Size = new System.Drawing.Size(156, 26);
            this.данныеToolStripMenuItem1.Text = "Данные";
            this.данныеToolStripMenuItem1.Click += new System.EventHandler(this.ДанныеToolStripMenuItem1_Click);
            // 
            // суммаToolStripMenuItem
            // 
            this.суммаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.суммаToolStripMenuItem.Name = "суммаToolStripMenuItem";
            this.суммаToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.суммаToolStripMenuItem.Text = "Сумма";
            this.суммаToolStripMenuItem.Click += new System.EventHandler(this.СуммаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(995, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Фамилия";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Ввод данных по пицце";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Вод данных по суши";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(13, 128);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(474, 378);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Фамилия";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Количество";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Width = 140;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Сумма заказа";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 140;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column8,
            this.Column3});
            this.dataGridView2.Location = new System.Drawing.Point(511, 128);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(473, 378);
            this.dataGridView2.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Фамилия";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 105;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Кол-во суши";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 105;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Кол-во соусов";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.Width = 105;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Сумма заказа";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 105;
            // 
            // label_Pizza
            // 
            this.label_Pizza.AutoSize = true;
            this.label_Pizza.BackColor = System.Drawing.Color.Transparent;
            this.label_Pizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Pizza.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Pizza.ForeColor = System.Drawing.Color.White;
            this.label_Pizza.Location = new System.Drawing.Point(159, 85);
            this.label_Pizza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Pizza.Name = "label_Pizza";
            this.label_Pizza.Size = new System.Drawing.Size(110, 34);
            this.label_Pizza.TabIndex = 4;
            this.label_Pizza.Text = "Пицца";
            this.toolTip1.SetToolTip(this.label_Pizza, "Дополнительная информация");
            this.label_Pizza.Click += new System.EventHandler(this.Label_Pizza_Click);
            // 
            // label_Sushi
            // 
            this.label_Sushi.AutoSize = true;
            this.label_Sushi.BackColor = System.Drawing.Color.Transparent;
            this.label_Sushi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Sushi.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Sushi.ForeColor = System.Drawing.Color.White;
            this.label_Sushi.Location = new System.Drawing.Point(632, 85);
            this.label_Sushi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Sushi.Name = "label_Sushi";
            this.label_Sushi.Size = new System.Drawing.Size(208, 34);
            this.label_Sushi.TabIndex = 5;
            this.label_Sushi.Text = "Суши-роллы";
            this.toolTip1.SetToolTip(this.label_Sushi, "Дополнительная информация");
            this.label_Sushi.Click += new System.EventHandler(this.Label_Sushi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(995, 573);
            this.Controls.Add(this.label_Sushi);
            this.Controls.Add(this.label_Pizza);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "КАФЕ (Предпочтения постоянных клиентов)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem заказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пиццаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem фамилияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сушиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фамилияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem суммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label_Pizza;
        private System.Windows.Forms.Label label_Sushi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

