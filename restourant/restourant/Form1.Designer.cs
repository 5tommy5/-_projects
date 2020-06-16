namespace restourant
{
    partial class offic
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
            this.type_box = new System.Windows.Forms.ComboBox();
            this.table_box = new System.Windows.Forms.ComboBox();
            this.num_list = new System.Windows.Forms.ListBox();
            this.table_list = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.zakaz_box = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pay = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.TextBox();
            this.Цена = new System.Windows.Forms.Label();
            this.loading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // type_box
            // 
            this.type_box.FormattingEnabled = true;
            this.type_box.Location = new System.Drawing.Point(47, 49);
            this.type_box.Name = "type_box";
            this.type_box.Size = new System.Drawing.Size(121, 24);
            this.type_box.TabIndex = 0;
            // 
            // table_box
            // 
            this.table_box.FormattingEnabled = true;
            this.table_box.Location = new System.Drawing.Point(192, 49);
            this.table_box.Name = "table_box";
            this.table_box.Size = new System.Drawing.Size(121, 24);
            this.table_box.TabIndex = 1;
            // 
            // num_list
            // 
            this.num_list.FormattingEnabled = true;
            this.num_list.ItemHeight = 16;
            this.num_list.Location = new System.Drawing.Point(259, 171);
            this.num_list.Name = "num_list";
            this.num_list.Size = new System.Drawing.Size(121, 164);
            this.num_list.TabIndex = 3;
            this.num_list.Visible = false;
            // 
            // table_list
            // 
            this.table_list.FormattingEnabled = true;
            this.table_list.ItemHeight = 16;
            this.table_list.Location = new System.Drawing.Point(386, 171);
            this.table_list.Name = "table_list";
            this.table_list.Size = new System.Drawing.Size(120, 164);
            this.table_list.TabIndex = 4;
            this.table_list.Visible = false;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(50, 355);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(121, 23);
            this.add.TabIndex = 5;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // zakaz_box
            // 
            this.zakaz_box.Location = new System.Drawing.Point(50, 128);
            this.zakaz_box.Name = "zakaz_box";
            this.zakaz_box.Size = new System.Drawing.Size(121, 168);
            this.zakaz_box.TabIndex = 7;
            this.zakaz_box.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Тип";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Столик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Номер заказа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Столик";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Готовые";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Заказ";
            // 
            // pay
            // 
            this.pay.Location = new System.Drawing.Point(387, 342);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(119, 23);
            this.pay.TabIndex = 15;
            this.pay.Text = "Оплачен";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(50, 327);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(118, 22);
            this.price.TabIndex = 16;
            // 
            // Цена
            // 
            this.Цена.AutoSize = true;
            this.Цена.Location = new System.Drawing.Point(47, 307);
            this.Цена.Name = "Цена";
            this.Цена.Size = new System.Drawing.Size(43, 17);
            this.Цена.TabIndex = 17;
            this.Цена.Text = "Цена";
            // 
            // loading
            // 
            this.loading.AutoSize = true;
            this.loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loading.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.loading.Location = new System.Drawing.Point(272, 227);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(211, 29);
            this.loading.TabIndex = 18;
            this.loading.Text = "Идет загрузка...";
            // 
            // offic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 408);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.Цена);
            this.Controls.Add(this.price);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zakaz_box);
            this.Controls.Add(this.add);
            this.Controls.Add(this.table_list);
            this.Controls.Add(this.num_list);
            this.Controls.Add(this.table_box);
            this.Controls.Add(this.type_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "offic";
            this.Text = "Официант";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox type_box;
        private System.Windows.Forms.ComboBox table_box;
        private System.Windows.Forms.ListBox num_list;
        private System.Windows.Forms.ListBox table_list;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.RichTextBox zakaz_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label Цена;
        private System.Windows.Forms.Label loading;
    }
}

