namespace Frames
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Зерномучные");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Фрукты, овощи");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Кондитерские изделия");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Мясо и мясные");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Рыбная продукция");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Молочные продукты");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Напитки");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Продукты", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Водоснабжение");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Газоснабжение");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Электричество");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Телефон");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("ЖКХ", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Аренда");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Кредиты");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Налоги");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Постоянные затраты", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Бензин");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Автомобиль", new System.Windows.Forms.TreeNode[] {
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Общественный транспорт");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Транспорт", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Незапланированные затраты");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.деревоРасходовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКатегориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКатегориюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКатегориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.конкретныеРасходыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьРасходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьРасходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSum = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonCategory = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonCost = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCansel = new System.Windows.Forms.Button();
            this.labelCost = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.OldLace;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.Location = new System.Drawing.Point(12, 31);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел1";
            treeNode1.Text = "Зерномучные";
            treeNode2.Name = "Узел2";
            treeNode2.Text = "Фрукты, овощи";
            treeNode3.Name = "Узел4";
            treeNode3.Text = "Кондитерские изделия";
            treeNode4.Name = "Узел5";
            treeNode4.Text = "Мясо и мясные";
            treeNode5.Name = "Узел6";
            treeNode5.Text = "Рыбная продукция";
            treeNode6.Name = "Узел7";
            treeNode6.Text = "Молочные продукты";
            treeNode7.Name = "Узел8";
            treeNode7.Text = "Напитки";
            treeNode8.Name = "Узел0";
            treeNode8.Text = "Продукты";
            treeNode9.Name = "Узел10";
            treeNode9.Text = "Водоснабжение";
            treeNode10.Name = "Узел11";
            treeNode10.Text = "Газоснабжение";
            treeNode11.Name = "Узел12";
            treeNode11.Text = "Электричество";
            treeNode12.Name = "Узел13";
            treeNode12.Text = "Телефон";
            treeNode13.Name = "Узел9";
            treeNode13.Text = "ЖКХ";
            treeNode14.Name = "Узел15";
            treeNode14.Text = "Аренда";
            treeNode15.Name = "Узел16";
            treeNode15.Text = "Кредиты";
            treeNode16.Name = "Узел17";
            treeNode16.Text = "Налоги";
            treeNode17.Name = "Узел14";
            treeNode17.Text = "Постоянные затраты";
            treeNode18.Name = "Узел21";
            treeNode18.Text = "Бензин";
            treeNode19.Name = "Узел20";
            treeNode19.Text = "Автомобиль";
            treeNode20.Name = "Узел22";
            treeNode20.Text = "Общественный транспорт";
            treeNode21.Name = "Узел19";
            treeNode21.Text = "Транспорт";
            treeNode22.Name = "Узел23";
            treeNode22.Text = "Незапланированные затраты";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode13,
            treeNode17,
            treeNode21,
            treeNode22});
            this.treeView1.Size = new System.Drawing.Size(304, 404);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.деревоРасходовToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // деревоРасходовToolStripMenuItem
            // 
            this.деревоРасходовToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.деревоРасходовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКатегориюToolStripMenuItem,
            this.конкретныеРасходыToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.деревоРасходовToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.деревоРасходовToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.деревоРасходовToolStripMenuItem.Name = "деревоРасходовToolStripMenuItem";
            this.деревоРасходовToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.деревоРасходовToolStripMenuItem.Text = "Дерево расходов";
            // 
            // добавитьКатегориюToolStripMenuItem
            // 
            this.добавитьКатегориюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКатегориюToolStripMenuItem1,
            this.удалитьКатегориюToolStripMenuItem});
            this.добавитьКатегориюToolStripMenuItem.Name = "добавитьКатегориюToolStripMenuItem";
            this.добавитьКатегориюToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.добавитьКатегориюToolStripMenuItem.Text = "Категория расходов";
            // 
            // добавитьКатегориюToolStripMenuItem1
            // 
            this.добавитьКатегориюToolStripMenuItem1.Name = "добавитьКатегориюToolStripMenuItem1";
            this.добавитьКатегориюToolStripMenuItem1.Size = new System.Drawing.Size(256, 26);
            this.добавитьКатегориюToolStripMenuItem1.Text = "Добавить категорию";
            this.добавитьКатегориюToolStripMenuItem1.Click += new System.EventHandler(this.добавитьКатегориюToolStripMenuItem1_Click);
            // 
            // удалитьКатегориюToolStripMenuItem
            // 
            this.удалитьКатегориюToolStripMenuItem.Name = "удалитьКатегориюToolStripMenuItem";
            this.удалитьКатегориюToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.удалитьКатегориюToolStripMenuItem.Text = "Удалить категорию";
            this.удалитьКатегориюToolStripMenuItem.Click += new System.EventHandler(this.удалитьКатегориюToolStripMenuItem_Click);
            // 
            // конкретныеРасходыToolStripMenuItem
            // 
            this.конкретныеРасходыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьРасходToolStripMenuItem,
            this.удалитьРасходToolStripMenuItem});
            this.конкретныеРасходыToolStripMenuItem.Name = "конкретныеРасходыToolStripMenuItem";
            this.конкретныеРасходыToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.конкретныеРасходыToolStripMenuItem.Text = "Конкретные расходы";
            // 
            // добавитьРасходToolStripMenuItem
            // 
            this.добавитьРасходToolStripMenuItem.Name = "добавитьРасходToolStripMenuItem";
            this.добавитьРасходToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.добавитьРасходToolStripMenuItem.Text = "Добавить расход";
            this.добавитьРасходToolStripMenuItem.Click += new System.EventHandler(this.добавитьРасходToolStripMenuItem_Click);
            // 
            // удалитьРасходToolStripMenuItem
            // 
            this.удалитьРасходToolStripMenuItem.Name = "удалитьРасходToolStripMenuItem";
            this.удалитьРасходToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.удалитьРасходToolStripMenuItem.Text = "Удалить расход";
            this.удалитьРасходToolStripMenuItem.Click += new System.EventHandler(this.удалитьРасходToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.оПрограммеToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.оПрограммеToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.OldLace;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(322, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(493, 183);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 111;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Сумма расхода";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Процент от всех расходов";
            this.columnHeader3.Width = 241;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 580);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 22);
            this.textBox1.TabIndex = 3;
            // 
            // buttonSum
            // 
            this.buttonSum.BackColor = System.Drawing.Color.Red;
            this.buttonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSum.ForeColor = System.Drawing.Color.White;
            this.buttonSum.Location = new System.Drawing.Point(34, 570);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(125, 40);
            this.buttonSum.TabIndex = 4;
            this.buttonSum.Text = "Итог";
            this.buttonSum.UseVisualStyleBackColor = false;
            this.buttonSum.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(238, 467);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 22);
            this.textBox2.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightPink;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(144, 505);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(132, 40);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(639, 515);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 22);
            this.textBox3.TabIndex = 7;
            // 
            // buttonCategory
            // 
            this.buttonCategory.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCategory.Location = new System.Drawing.Point(394, 505);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Size = new System.Drawing.Size(228, 40);
            this.buttonCategory.TabIndex = 8;
            this.buttonCategory.Text = "Добавить категорию";
            this.buttonCategory.UseVisualStyleBackColor = false;
            this.buttonCategory.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(639, 580);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(176, 22);
            this.textBox4.TabIndex = 9;
            // 
            // buttonCost
            // 
            this.buttonCost.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCost.Location = new System.Drawing.Point(424, 570);
            this.buttonCost.Name = "buttonCost";
            this.buttonCost.Size = new System.Drawing.Size(198, 40);
            this.buttonCost.TabIndex = 10;
            this.buttonCost.Text = "Добавить расход";
            this.buttonCost.UseVisualStyleBackColor = false;
            this.buttonCost.Click += new System.EventHandler(this.button4_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.OldLace;
            this.richTextBox1.Location = new System.Drawing.Point(322, 220);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(493, 215);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            this.richTextBox1.Enter += new System.EventHandler(this.richTexBox1_Enter);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(671, 441);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(117, 46);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCansel
            // 
            this.buttonCansel.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonCansel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCansel.ForeColor = System.Drawing.Color.White;
            this.buttonCansel.Location = new System.Drawing.Point(549, 443);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(102, 44);
            this.buttonCansel.TabIndex = 13;
            this.buttonCansel.Text = "Отмена";
            this.buttonCansel.UseVisualStyleBackColor = false;
            this.buttonCansel.Click += new System.EventHandler(this.ButtonCansel_Click);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.BackColor = System.Drawing.Color.OldLace;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCost.ForeColor = System.Drawing.Color.Black;
            this.labelCost.Location = new System.Drawing.Point(8, 467);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(213, 24);
            this.labelCost.TabIndex = 14;
            this.labelCost.Text = "Введите стоимость:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(861, 634);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.buttonCansel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonCost);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.buttonCategory);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Планер расходов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem деревоРасходовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКатегориюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКатегориюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьКатегориюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonCategory;
        private System.Windows.Forms.ToolStripMenuItem конкретныеРасходыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьРасходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьРасходToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonCost;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCansel;
        private System.Windows.Forms.Label labelCost;
    }
}

