namespace Lab_4_5_6
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
            this.groupBox_Baza = new System.Windows.Forms.GroupBox();
            this.groupBoxHome = new System.Windows.Forms.GroupBox();
            this.radioButton_Intercom = new System.Windows.Forms.RadioButton();
            this.radioButton_Repair = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_Surname = new System.Windows.Forms.Button();
            this.button_Baza = new System.Windows.Forms.Button();
            this.comboBox_Surname = new System.Windows.Forms.ComboBox();
            this.label_Surname = new System.Windows.Forms.Label();
            this.groupBoxWater = new System.Windows.Forms.GroupBox();
            this.checkBox_Intercom = new System.Windows.Forms.CheckBox();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.trackBar_Filter = new System.Windows.Forms.TrackBar();
            this.checkBox_Repair = new System.Windows.Forms.CheckBox();
            this.listBox_Filter = new System.Windows.Forms.ListBox();
            this.button_Filter = new System.Windows.Forms.Button();
            this.listBox_Home = new System.Windows.Forms.ListBox();
            this.button_Sum = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.groupBox_Home = new System.Windows.Forms.GroupBox();
            this.trackBar_Home = new System.Windows.Forms.TrackBar();
            this.textBox_Sum = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Baza.SuspendLayout();
            this.groupBoxHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxWater.SuspendLayout();
            this.groupBox_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Filter)).BeginInit();
            this.groupBox_Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Baza
            // 
            this.groupBox_Baza.Controls.Add(this.groupBoxHome);
            this.groupBox_Baza.Controls.Add(this.button_Surname);
            this.groupBox_Baza.Controls.Add(this.button_Baza);
            this.groupBox_Baza.Controls.Add(this.comboBox_Surname);
            this.groupBox_Baza.Controls.Add(this.label_Surname);
            this.groupBox_Baza.Location = new System.Drawing.Point(8, 11);
            this.groupBox_Baza.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox_Baza.Name = "groupBox_Baza";
            this.groupBox_Baza.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox_Baza.Size = new System.Drawing.Size(435, 401);
            this.groupBox_Baza.TabIndex = 0;
            this.groupBox_Baza.TabStop = false;
            this.groupBox_Baza.Text = "Заполнение данных";
            // 
            // groupBoxHome
            // 
            this.groupBoxHome.Controls.Add(this.radioButton_Intercom);
            this.groupBoxHome.Controls.Add(this.radioButton_Repair);
            this.groupBoxHome.Controls.Add(this.textBox4);
            this.groupBoxHome.Controls.Add(this.numericUpDown1);
            this.groupBoxHome.Controls.Add(this.textBox3);
            this.groupBoxHome.Location = new System.Drawing.Point(27, 155);
            this.groupBoxHome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxHome.Name = "groupBoxHome";
            this.groupBoxHome.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxHome.Size = new System.Drawing.Size(353, 181);
            this.groupBoxHome.TabIndex = 6;
            this.groupBoxHome.TabStop = false;
            this.groupBoxHome.Text = "Виды платежа";
            // 
            // radioButton_Intercom
            // 
            this.radioButton_Intercom.AutoSize = true;
            this.radioButton_Intercom.Location = new System.Drawing.Point(5, 105);
            this.radioButton_Intercom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton_Intercom.Name = "radioButton_Intercom";
            this.radioButton_Intercom.Size = new System.Drawing.Size(163, 28);
            this.radioButton_Intercom.TabIndex = 5;
            this.radioButton_Intercom.TabStop = true;
            this.radioButton_Intercom.Text = "Электроэнэргия";
            this.radioButton_Intercom.UseVisualStyleBackColor = true;
            this.radioButton_Intercom.CheckedChanged += new System.EventHandler(this.RadioButton_Intercom_CheckedChanged);
            // 
            // radioButton_Repair
            // 
            this.radioButton_Repair.AutoSize = true;
            this.radioButton_Repair.Location = new System.Drawing.Point(5, 49);
            this.radioButton_Repair.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButton_Repair.Name = "radioButton_Repair";
            this.radioButton_Repair.Size = new System.Drawing.Size(206, 28);
            this.radioButton_Repair.TabIndex = 2;
            this.radioButton_Repair.TabStop = true;
            this.radioButton_Repair.Text = "Капитальный ремонт";
            this.radioButton_Repair.UseVisualStyleBackColor = true;
            this.radioButton_Repair.CheckedChanged += new System.EventHandler(this.RadioButton_Repair_CheckedChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(171, 139);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(160, 30);
            this.textBox4.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(231, 47);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 30);
            this.numericUpDown1.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(171, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 30);
            this.textBox3.TabIndex = 4;
            // 
            // button_Surname
            // 
            this.button_Surname.Location = new System.Drawing.Point(123, 95);
            this.button_Surname.Name = "button_Surname";
            this.button_Surname.Size = new System.Drawing.Size(137, 32);
            this.button_Surname.TabIndex = 9;
            this.button_Surname.Text = "Добавить";
            this.toolTip1.SetToolTip(this.button_Surname, "Добавление фамилии ");
            this.button_Surname.UseVisualStyleBackColor = true;
            this.button_Surname.Click += new System.EventHandler(this.Button_Surname_Click);
            // 
            // button_Baza
            // 
            this.button_Baza.Location = new System.Drawing.Point(123, 351);
            this.button_Baza.Name = "button_Baza";
            this.button_Baza.Size = new System.Drawing.Size(155, 29);
            this.button_Baza.TabIndex = 8;
            this.button_Baza.Text = "Занести в базу";
            this.toolTip1.SetToolTip(this.button_Baza, "отображение платежей в базе");
            this.button_Baza.UseVisualStyleBackColor = true;
            this.button_Baza.Click += new System.EventHandler(this.Button_Baza_Click);
            // 
            // comboBox_Surname
            // 
            this.comboBox_Surname.FormattingEnabled = true;
            this.comboBox_Surname.Items.AddRange(new object[] {
            "Иванов",
            "Петров",
            "Ларькин",
            "Яманаева",
            "Шиляева"});
            this.comboBox_Surname.Location = new System.Drawing.Point(151, 36);
            this.comboBox_Surname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox_Surname.Name = "comboBox_Surname";
            this.comboBox_Surname.Size = new System.Drawing.Size(229, 32);
            this.comboBox_Surname.TabIndex = 1;
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Location = new System.Drawing.Point(43, 39);
            this.label_Surname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(85, 24);
            this.label_Surname.TabIndex = 0;
            this.label_Surname.Text = "Фамилия";
            // 
            // groupBoxWater
            // 
            this.groupBoxWater.Controls.Add(this.checkBox_Intercom);
            this.groupBoxWater.Controls.Add(this.groupBox_Filter);
            this.groupBoxWater.Controls.Add(this.checkBox_Repair);
            this.groupBoxWater.Controls.Add(this.listBox_Filter);
            this.groupBoxWater.Controls.Add(this.button_Filter);
            this.groupBoxWater.Location = new System.Drawing.Point(35, 418);
            this.groupBoxWater.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxWater.Name = "groupBoxWater";
            this.groupBoxWater.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxWater.Size = new System.Drawing.Size(953, 279);
            this.groupBoxWater.TabIndex = 7;
            this.groupBoxWater.TabStop = false;
            this.groupBoxWater.Text = "Фильтр платежей";
            // 
            // checkBox_Intercom
            // 
            this.checkBox_Intercom.AutoSize = true;
            this.checkBox_Intercom.Location = new System.Drawing.Point(13, 95);
            this.checkBox_Intercom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_Intercom.Name = "checkBox_Intercom";
            this.checkBox_Intercom.Size = new System.Drawing.Size(164, 28);
            this.checkBox_Intercom.TabIndex = 1;
            this.checkBox_Intercom.Text = "Электроэнэргия";
            this.toolTip1.SetToolTip(this.checkBox_Intercom, "Добавление фамилии ");
            this.checkBox_Intercom.UseVisualStyleBackColor = true;
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.Controls.Add(this.trackBar_Filter);
            this.groupBox_Filter.Location = new System.Drawing.Point(5, 173);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(419, 93);
            this.groupBox_Filter.TabIndex = 9;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Размер шрифта";
            // 
            // trackBar_Filter
            // 
            this.trackBar_Filter.Location = new System.Drawing.Point(17, 28);
            this.trackBar_Filter.Name = "trackBar_Filter";
            this.trackBar_Filter.Size = new System.Drawing.Size(386, 56);
            this.trackBar_Filter.TabIndex = 0;
            this.trackBar_Filter.Scroll += new System.EventHandler(this.TrackBar_Filter_Scroll);
            // 
            // checkBox_Repair
            // 
            this.checkBox_Repair.AutoSize = true;
            this.checkBox_Repair.Location = new System.Drawing.Point(13, 46);
            this.checkBox_Repair.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_Repair.Name = "checkBox_Repair";
            this.checkBox_Repair.Size = new System.Drawing.Size(207, 28);
            this.checkBox_Repair.TabIndex = 0;
            this.checkBox_Repair.Text = "Капитальный ремонт";
            this.checkBox_Repair.UseVisualStyleBackColor = true;
            // 
            // listBox_Filter
            // 
            this.listBox_Filter.FormattingEnabled = true;
            this.listBox_Filter.ItemHeight = 24;
            this.listBox_Filter.Location = new System.Drawing.Point(443, 22);
            this.listBox_Filter.Name = "listBox_Filter";
            this.listBox_Filter.Size = new System.Drawing.Size(505, 244);
            this.listBox_Filter.TabIndex = 2;
            // 
            // button_Filter
            // 
            this.button_Filter.Location = new System.Drawing.Point(257, 69);
            this.button_Filter.Name = "button_Filter";
            this.button_Filter.Size = new System.Drawing.Size(131, 33);
            this.button_Filter.TabIndex = 4;
            this.button_Filter.Text = "Отобразить";
            this.toolTip1.SetToolTip(this.button_Filter, "отобразить выбранные виды платежа");
            this.button_Filter.UseVisualStyleBackColor = true;
            this.button_Filter.Click += new System.EventHandler(this.Button_Filter_Click);
            // 
            // listBox_Home
            // 
            this.listBox_Home.FormattingEnabled = true;
            this.listBox_Home.ItemHeight = 24;
            this.listBox_Home.Location = new System.Drawing.Point(473, 62);
            this.listBox_Home.Name = "listBox_Home";
            this.listBox_Home.Size = new System.Drawing.Size(510, 244);
            this.listBox_Home.TabIndex = 1;
            // 
            // button_Sum
            // 
            this.button_Sum.Location = new System.Drawing.Point(292, 723);
            this.button_Sum.Name = "button_Sum";
            this.button_Sum.Size = new System.Drawing.Size(88, 37);
            this.button_Sum.TabIndex = 5;
            this.button_Sum.Text = "Сумма";
            this.toolTip1.SetToolTip(this.button_Sum, "вычисление суммы");
            this.button_Sum.UseVisualStyleBackColor = true;
            this.button_Sum.Click += new System.EventHandler(this.Button_Sum_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(8, 723);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(103, 37);
            this.button_Exit.TabIndex = 6;
            this.button_Exit.Text = "Выход";
            this.toolTip1.SetToolTip(this.button_Exit, "выход из программы");
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // groupBox_Home
            // 
            this.groupBox_Home.Controls.Add(this.trackBar_Home);
            this.groupBox_Home.Location = new System.Drawing.Point(478, 312);
            this.groupBox_Home.Name = "groupBox_Home";
            this.groupBox_Home.Size = new System.Drawing.Size(510, 83);
            this.groupBox_Home.TabIndex = 7;
            this.groupBox_Home.TabStop = false;
            this.groupBox_Home.Text = "Размер шрифта";
            // 
            // trackBar_Home
            // 
            this.trackBar_Home.Location = new System.Drawing.Point(17, 21);
            this.trackBar_Home.Name = "trackBar_Home";
            this.trackBar_Home.Size = new System.Drawing.Size(476, 56);
            this.trackBar_Home.TabIndex = 0;
            this.trackBar_Home.Scroll += new System.EventHandler(this.TrackBar_Home_Scroll);
            // 
            // textBox_Sum
            // 
            this.textBox_Sum.Location = new System.Drawing.Point(401, 730);
            this.textBox_Sum.Name = "textBox_Sum";
            this.textBox_Sum.Size = new System.Drawing.Size(212, 30);
            this.textBox_Sum.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Список всех платежей";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1000, 772);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxWater);
            this.Controls.Add(this.textBox_Sum);
            this.Controls.Add(this.groupBox_Home);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Sum);
            this.Controls.Add(this.listBox_Home);
            this.Controls.Add(this.groupBox_Baza);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Жилищные услуги";
            this.groupBox_Baza.ResumeLayout(false);
            this.groupBox_Baza.PerformLayout();
            this.groupBoxHome.ResumeLayout(false);
            this.groupBoxHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxWater.ResumeLayout(false);
            this.groupBoxWater.PerformLayout();
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Filter)).EndInit();
            this.groupBox_Home.ResumeLayout(false);
            this.groupBox_Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Baza;
        private System.Windows.Forms.ComboBox comboBox_Surname;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.GroupBox groupBoxWater;
        private System.Windows.Forms.CheckBox checkBox_Repair;
        private System.Windows.Forms.CheckBox checkBox_Intercom;
        private System.Windows.Forms.Button button_Baza;
        private System.Windows.Forms.ListBox listBox_Home;
        private System.Windows.Forms.ListBox listBox_Filter;
        private System.Windows.Forms.Button button_Filter;
        private System.Windows.Forms.Button button_Sum;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.GroupBox groupBox_Home;
        private System.Windows.Forms.TextBox textBox_Sum;
        private System.Windows.Forms.Button button_Surname;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.TrackBar trackBar_Filter;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBoxHome;
        private System.Windows.Forms.RadioButton radioButton_Intercom;
        private System.Windows.Forms.RadioButton radioButton_Repair;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TrackBar trackBar_Home;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
    }
}

