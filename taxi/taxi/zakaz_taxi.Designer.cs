namespace taxi
{
    partial class auto_zakaz
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
            this.from_box = new System.Windows.Forms.ComboBox();
            this.to_box = new System.Windows.Forms.ComboBox();
            this.car_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // from_box
            // 
            this.from_box.FormattingEnabled = true;
            this.from_box.Location = new System.Drawing.Point(60, 74);
            this.from_box.Name = "from_box";
            this.from_box.Size = new System.Drawing.Size(121, 24);
            this.from_box.TabIndex = 0;
            // 
            // to_box
            // 
            this.to_box.FormattingEnabled = true;
            this.to_box.Location = new System.Drawing.Point(268, 74);
            this.to_box.Name = "to_box";
            this.to_box.Size = new System.Drawing.Size(121, 24);
            this.to_box.TabIndex = 1;
            // 
            // car_box
            // 
            this.car_box.FormattingEnabled = true;
            this.car_box.Location = new System.Drawing.Point(60, 259);
            this.car_box.Name = "car_box";
            this.car_box.Size = new System.Drawing.Size(121, 24);
            this.car_box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Откуда вас забрать?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Куда направляетесь?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цена";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(119, 172);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(0, 17);
            this.price.TabIndex = 6;
            this.price.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.car_box);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.from_box);
            this.panel1.Controls.Add(this.to_box);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 361);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Заказать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Автомобили в вашем районе";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Поиск авто";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // auto_zakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 385);
            this.Controls.Add(this.panel1);
            this.Name = "auto_zakaz";
            this.Text = "Заказать такси";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox from_box;
        private System.Windows.Forms.ComboBox to_box;
        private System.Windows.Forms.ComboBox car_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}