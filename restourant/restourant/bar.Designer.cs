namespace restourant
{
    partial class bar
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
            this.ready = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zakaz_box = new System.Windows.Forms.RichTextBox();
            this.num_box = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ready
            // 
            this.ready.Enabled = false;
            this.ready.Location = new System.Drawing.Point(12, 253);
            this.ready.Name = "ready";
            this.ready.Size = new System.Drawing.Size(202, 23);
            this.ready.TabIndex = 9;
            this.ready.Text = "Готов";
            this.ready.UseVisualStyleBackColor = true;
            this.ready.Click += new System.EventHandler(this.ready_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Заказ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Номер заказа";
            // 
            // zakaz_box
            // 
            this.zakaz_box.Location = new System.Drawing.Point(238, 34);
            this.zakaz_box.Name = "zakaz_box";
            this.zakaz_box.Size = new System.Drawing.Size(202, 212);
            this.zakaz_box.TabIndex = 6;
            this.zakaz_box.Text = "";
            // 
            // num_box
            // 
            this.num_box.FormattingEnabled = true;
            this.num_box.ItemHeight = 16;
            this.num_box.Location = new System.Drawing.Point(12, 34);
            this.num_box.Name = "num_box";
            this.num_box.Size = new System.Drawing.Size(202, 212);
            this.num_box.TabIndex = 5;
            // 
            // bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 288);
            this.Controls.Add(this.ready);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zakaz_box);
            this.Controls.Add(this.num_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "bar";
            this.Text = "Бар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ready;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox zakaz_box;
        private System.Windows.Forms.ListBox num_box;
    }
}