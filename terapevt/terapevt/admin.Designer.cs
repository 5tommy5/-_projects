namespace terapevt
{
    partial class admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phone_box1 = new System.Windows.Forms.TextBox();
            this.doctor_box = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phone_box2 = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.Surname_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.TextBox();
            this.date_pick = new System.Windows.Forms.MonthCalendar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.date_pick);
            this.panel1.Controls.Add(this.comment);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Surname_box);
            this.panel1.Controls.Add(this.name_box);
            this.panel1.Controls.Add(this.phone_box2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.doctor_box);
            this.panel1.Controls.Add(this.phone_box1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 545);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Записать на прием";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер телефона пациента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Доктор";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(559, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Фамилия";
            // 
            // phone_box1
            // 
            this.phone_box1.Location = new System.Drawing.Point(261, 72);
            this.phone_box1.Name = "phone_box1";
            this.phone_box1.Size = new System.Drawing.Size(145, 22);
            this.phone_box1.TabIndex = 6;
            // 
            // doctor_box
            // 
            this.doctor_box.FormattingEnabled = true;
            this.doctor_box.Location = new System.Drawing.Point(261, 108);
            this.doctor_box.Name = "doctor_box";
            this.doctor_box.Size = new System.Drawing.Size(145, 24);
            this.doctor_box.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(35, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(317, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Добавить пациента в базу";
            // 
            // phone_box2
            // 
            this.phone_box2.Location = new System.Drawing.Point(40, 464);
            this.phone_box2.Name = "phone_box2";
            this.phone_box2.Size = new System.Drawing.Size(152, 22);
            this.phone_box2.TabIndex = 9;
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(308, 464);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(158, 22);
            this.name_box.TabIndex = 10;
            // 
            // Surname_box
            // 
            this.Surname_box.Location = new System.Drawing.Point(562, 464);
            this.Surname_box.Name = "Surname_box";
            this.Surname_box.Size = new System.Drawing.Size(140, 22);
            this.Surname_box.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Записать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Комментарий";
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(40, 173);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(233, 22);
            this.comment.TabIndex = 15;
            // 
            // date_pick
            // 
            this.date_pick.Location = new System.Drawing.Point(510, 54);
            this.date_pick.Name = "date_pick";
            this.date_pick.TabIndex = 16;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 570);
            this.Controls.Add(this.panel1);
            this.Name = "admin";
            this.Text = "admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Surname_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox phone_box2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox doctor_box;
        private System.Windows.Forms.TextBox phone_box1;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MonthCalendar date_pick;
    }
}