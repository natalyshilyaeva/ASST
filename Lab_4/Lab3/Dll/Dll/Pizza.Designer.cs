namespace Dll
{
    partial class Pizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pizza));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Info = new System.Windows.Forms.ToolStripSplitButton();
            this.видыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяСозданияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton_Close = new System.Windows.Forms.ToolStripSplitButton();
            this.dataGridView_Pizza = new System.Windows.Forms.DataGridView();
            this.label_Pizza = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pizza)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Info,
            this.toolStripButton_Close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1250, 29);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Info
            // 
            this.toolStripButton_Info.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видыToolStripMenuItem,
            this.историяСозданияToolStripMenuItem});
            this.toolStripButton_Info.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton_Info.ForeColor = System.Drawing.Color.White;
            this.toolStripButton_Info.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Info.Image")));
            this.toolStripButton_Info.Name = "toolStripButton_Info";
            this.toolStripButton_Info.Size = new System.Drawing.Size(173, 26);
            this.toolStripButton_Info.Text = "Информация";
            // 
            // видыToolStripMenuItem
            // 
            this.видыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("видыToolStripMenuItem.Image")));
            this.видыToolStripMenuItem.Name = "видыToolStripMenuItem";
            this.видыToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.видыToolStripMenuItem.Text = "Средние размеры";
            this.видыToolStripMenuItem.Click += new System.EventHandler(this.ВидыToolStripMenuItem_Click);
            // 
            // историяСозданияToolStripMenuItem
            // 
            this.историяСозданияToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("историяСозданияToolStripMenuItem.Image")));
            this.историяСозданияToolStripMenuItem.Name = "историяСозданияToolStripMenuItem";
            this.историяСозданияToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.историяСозданияToolStripMenuItem.Text = "История создания";
            this.историяСозданияToolStripMenuItem.Click += new System.EventHandler(this.ИсторияСозданияToolStripMenuItem_Click);
            // 
            // toolStripButton_Close
            // 
            this.toolStripButton_Close.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton_Close.ForeColor = System.Drawing.Color.White;
            this.toolStripButton_Close.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Close.Image")));
            this.toolStripButton_Close.Name = "toolStripButton_Close";
            this.toolStripButton_Close.Size = new System.Drawing.Size(131, 26);
            this.toolStripButton_Close.Text = "Закрыть";
            this.toolStripButton_Close.ButtonClick += new System.EventHandler(this.ToolStripButton_Close_ButtonClick);
            // 
            // dataGridView_Pizza
            // 
            this.dataGridView_Pizza.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView_Pizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Pizza.ColumnHeadersVisible = false;
            this.dataGridView_Pizza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView_Pizza.Location = new System.Drawing.Point(17, 49);
            this.dataGridView_Pizza.Name = "dataGridView_Pizza";
            this.dataGridView_Pizza.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_Pizza.RowTemplate.Height = 24;
            this.dataGridView_Pizza.Size = new System.Drawing.Size(445, 150);
            this.dataGridView_Pizza.TabIndex = 1;
            this.dataGridView_Pizza.Visible = false;
            // 
            // label_Pizza
            // 
            this.label_Pizza.BackColor = System.Drawing.Color.PeachPuff;
            this.label_Pizza.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Pizza.ForeColor = System.Drawing.Color.Black;
            this.label_Pizza.Location = new System.Drawing.Point(12, 258);
            this.label_Pizza.Name = "label_Pizza";
            this.label_Pizza.Size = new System.Drawing.Size(1021, 239);
            this.label_Pizza.TabIndex = 2;
            this.label_Pizza.Text = resources.GetString("label_Pizza.Text");
            this.label_Pizza.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1250, 649);
            this.Controls.Add(this.label_Pizza);
            this.Controls.Add(this.dataGridView_Pizza);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pizza";
            this.Text = "Pizza";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Pizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton_Info;
        private System.Windows.Forms.ToolStripMenuItem видыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяСозданияToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton_Close;
        private System.Windows.Forms.DataGridView dataGridView_Pizza;
        private System.Windows.Forms.Label label_Pizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}