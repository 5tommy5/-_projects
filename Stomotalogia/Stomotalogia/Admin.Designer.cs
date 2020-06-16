namespace Stomotalogia
{
    partial class Admin
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
            this.phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelname = new System.Windows.Forms.Label();
            this.labelsurname = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.patid = new System.Windows.Forms.Label();
            this.patsur = new System.Windows.Forms.Label();
            this.patname = new System.Windows.Forms.Label();
            this.errorlabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phonebox = new System.Windows.Forms.TextBox();
            this.surbox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sucsses = new System.Windows.Forms.Label();
            this.errornewpatient = new System.Windows.Forms.Label();
            this.newus = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pat_id_box = new System.Windows.Forms.TextBox();
            this.doc_id_box = new System.Windows.Forms.TextBox();
            this.date_box = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.time_box = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.error_talon = new System.Windows.Forms.Label();
            this.success_talon = new System.Windows.Forms.Label();
            this.no_time = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(29, 42);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(153, 22);
            this.phone.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск по телефону клиента";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(199, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Искать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(32, 82);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(106, 17);
            this.labelname.TabIndex = 3;
            this.labelname.Text = "Имя пациента:";
            // 
            // labelsurname
            // 
            this.labelsurname.AutoSize = true;
            this.labelsurname.Location = new System.Drawing.Point(32, 99);
            this.labelsurname.Name = "labelsurname";
            this.labelsurname.Size = new System.Drawing.Size(145, 17);
            this.labelsurname.TabIndex = 4;
            this.labelsurname.Text = "Фамилия пациента: ";
            this.labelsurname.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(32, 116);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(29, 17);
            this.labelid.TabIndex = 5;
            this.labelid.Text = "ID :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.patid);
            this.panel1.Controls.Add(this.patsur);
            this.panel1.Controls.Add(this.patname);
            this.panel1.Controls.Add(this.labelid);
            this.panel1.Controls.Add(this.labelsurname);
            this.panel1.Controls.Add(this.labelname);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.phone);
            this.panel1.Location = new System.Drawing.Point(18, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 154);
            this.panel1.TabIndex = 6;
            // 
            // patid
            // 
            this.patid.AutoSize = true;
            this.patid.Location = new System.Drawing.Point(196, 116);
            this.patid.Name = "patid";
            this.patid.Size = new System.Drawing.Size(16, 17);
            this.patid.TabIndex = 8;
            this.patid.Text = "3";
            // 
            // patsur
            // 
            this.patsur.AutoSize = true;
            this.patsur.Location = new System.Drawing.Point(196, 99);
            this.patsur.Name = "patsur";
            this.patsur.Size = new System.Drawing.Size(16, 17);
            this.patsur.TabIndex = 7;
            this.patsur.Text = "2";
            // 
            // patname
            // 
            this.patname.AutoSize = true;
            this.patname.Location = new System.Drawing.Point(196, 82);
            this.patname.Name = "patname";
            this.patname.Size = new System.Drawing.Size(16, 17);
            this.patname.TabIndex = 6;
            this.patname.Text = "1";
            this.patname.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.BackColor = System.Drawing.Color.Red;
            this.errorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorlabel.Location = new System.Drawing.Point(96, 166);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(156, 29);
            this.errorlabel.TabIndex = 7;
            this.errorlabel.Text = "Не найдено!";
            this.errorlabel.Visible = false;
            this.errorlabel.Click += new System.EventHandler(this.errorlabel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.newus);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.phonebox);
            this.panel2.Controls.Add(this.surbox);
            this.panel2.Controls.Add(this.namebox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(383, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 217);
            this.panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя";
            // 
            // phonebox
            // 
            this.phonebox.Location = new System.Drawing.Point(117, 146);
            this.phonebox.Name = "phonebox";
            this.phonebox.Size = new System.Drawing.Size(152, 22);
            this.phonebox.TabIndex = 3;
            // 
            // surbox
            // 
            this.surbox.Location = new System.Drawing.Point(117, 96);
            this.surbox.Name = "surbox";
            this.surbox.Size = new System.Drawing.Size(152, 22);
            this.surbox.TabIndex = 2;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(117, 47);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(152, 22);
            this.namebox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(79, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Добавить клиента";
            // 
            // sucsses
            // 
            this.sucsses.AutoSize = true;
            this.sucsses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sucsses.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sucsses.Location = new System.Drawing.Point(328, 229);
            this.sucsses.Name = "sucsses";
            this.sucsses.Size = new System.Drawing.Size(415, 29);
            this.sucsses.TabIndex = 7;
            this.sucsses.Text = "Пациент успешно добавлен в базу";
            this.sucsses.Visible = false;
            this.sucsses.Click += new System.EventHandler(this.sucsses_Click);
            // 
            // errornewpatient
            // 
            this.errornewpatient.AutoSize = true;
            this.errornewpatient.BackColor = System.Drawing.Color.Red;
            this.errornewpatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errornewpatient.Location = new System.Drawing.Point(474, 229);
            this.errornewpatient.Name = "errornewpatient";
            this.errornewpatient.Size = new System.Drawing.Size(112, 29);
            this.errornewpatient.TabIndex = 9;
            this.errornewpatient.Text = "Ошибка!";
            this.errornewpatient.Visible = false;
            this.errornewpatient.Click += new System.EventHandler(this.errornewpatient_Click);
            // 
            // newus
            // 
            this.newus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newus.Location = new System.Drawing.Point(117, 182);
            this.newus.Name = "newus";
            this.newus.Size = new System.Drawing.Size(152, 32);
            this.newus.TabIndex = 7;
            this.newus.Text = "Добавить";
            this.newus.UseVisualStyleBackColor = true;
            this.newus.Click += new System.EventHandler(this.newus_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.no_time);
            this.panel3.Controls.Add(this.success_talon);
            this.panel3.Controls.Add(this.error_talon);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.time_box);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.date_box);
            this.panel3.Controls.Add(this.doc_id_box);
            this.panel3.Controls.Add(this.pat_id_box);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(18, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(725, 148);
            this.panel3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(29, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Записать на прием";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "ID пациента";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "ID доктора";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pat_id_box
            // 
            this.pat_id_box.Location = new System.Drawing.Point(143, 51);
            this.pat_id_box.Name = "pat_id_box";
            this.pat_id_box.Size = new System.Drawing.Size(58, 22);
            this.pat_id_box.TabIndex = 3;
            // 
            // doc_id_box
            // 
            this.doc_id_box.Location = new System.Drawing.Point(143, 87);
            this.doc_id_box.Name = "doc_id_box";
            this.doc_id_box.Size = new System.Drawing.Size(58, 22);
            this.doc_id_box.TabIndex = 4;
            // 
            // date_box
            // 
            this.date_box.Location = new System.Drawing.Point(253, 51);
            this.date_box.Name = "date_box";
            this.date_box.Size = new System.Drawing.Size(174, 22);
            this.date_box.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Дата приема";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(502, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Время приема";
            // 
            // time_box
            // 
            this.time_box.Location = new System.Drawing.Point(505, 51);
            this.time_box.Name = "time_box";
            this.time_box.Size = new System.Drawing.Size(100, 22);
            this.time_box.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(253, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(352, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Записать на прием";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // error_talon
            // 
            this.error_talon.AutoSize = true;
            this.error_talon.BackColor = System.Drawing.Color.Red;
            this.error_talon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_talon.Location = new System.Drawing.Point(376, 112);
            this.error_talon.Name = "error_talon";
            this.error_talon.Size = new System.Drawing.Size(106, 29);
            this.error_talon.TabIndex = 10;
            this.error_talon.Text = "Ошибка";
            this.error_talon.Visible = false;
            this.error_talon.Click += new System.EventHandler(this.error_talon_Click);
            // 
            // success_talon
            // 
            this.success_talon.AutoSize = true;
            this.success_talon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.success_talon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.success_talon.Location = new System.Drawing.Point(332, 119);
            this.success_talon.Name = "success_talon";
            this.success_talon.Size = new System.Drawing.Size(200, 29);
            this.success_talon.TabIndex = 11;
            this.success_talon.Text = "Запись принята";
            this.success_talon.Visible = false;
            this.success_talon.Click += new System.EventHandler(this.success_talon_Click);
            // 
            // no_time
            // 
            this.no_time.AutoSize = true;
            this.no_time.BackColor = System.Drawing.Color.Red;
            this.no_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.no_time.Location = new System.Drawing.Point(332, 80);
            this.no_time.Name = "no_time";
            this.no_time.Size = new System.Drawing.Size(184, 29);
            this.no_time.TabIndex = 12;
            this.no_time.Text = "Время Занято!";
            this.no_time.Visible = false;
            this.no_time.Click += new System.EventHandler(this.no_time_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(777, 430);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.errornewpatient);
            this.Controls.Add(this.sucsses);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Admin";
            this.Text = "Панель администратора";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelsurname;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label patname;
        private System.Windows.Forms.Label patid;
        private System.Windows.Forms.Label patsur;
        private System.Windows.Forms.Label errorlabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phonebox;
        private System.Windows.Forms.TextBox surbox;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sucsses;
        private System.Windows.Forms.Label errornewpatient;
        private System.Windows.Forms.Button newus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox time_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker date_box;
        private System.Windows.Forms.TextBox doc_id_box;
        private System.Windows.Forms.TextBox pat_id_box;
        private System.Windows.Forms.Label success_talon;
        private System.Windows.Forms.Label error_talon;
        private System.Windows.Forms.Label no_time;
    }
}