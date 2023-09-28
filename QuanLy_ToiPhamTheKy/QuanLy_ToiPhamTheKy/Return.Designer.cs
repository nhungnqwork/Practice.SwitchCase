namespace QuanLy_ToiPhamTheKy
{
    partial class Return
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
            this.ReturnDTGV = new System.Windows.Forms.DataGridView();
            this.RentDTGV = new System.Windows.Forms.DataGridView();
            this.MaPNCb = new System.Windows.Forms.ComboBox();
            this.MaPhongGiamCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IdKATb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateNV = new System.Windows.Forms.DateTimePicker();
            this.DeplayTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FineTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yearTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnDTGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentDTGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnDTGV
            // 
            this.ReturnDTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnDTGV.Location = new System.Drawing.Point(278, 391);
            this.ReturnDTGV.Name = "ReturnDTGV";
            this.ReturnDTGV.RowHeadersWidth = 51;
            this.ReturnDTGV.RowTemplate.Height = 24;
            this.ReturnDTGV.Size = new System.Drawing.Size(1031, 264);
            this.ReturnDTGV.TabIndex = 0;
            // 
            // RentDTGV
            // 
            this.RentDTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentDTGV.Location = new System.Drawing.Point(372, 56);
            this.RentDTGV.Name = "RentDTGV";
            this.RentDTGV.RowHeadersWidth = 51;
            this.RentDTGV.RowTemplate.Height = 24;
            this.RentDTGV.Size = new System.Drawing.Size(892, 315);
            this.RentDTGV.TabIndex = 1;
            this.RentDTGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentDTGV_CellClick);
            this.RentDTGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentDTGV_CellContentClick);
            // 
            // MaPNCb
            // 
            this.MaPNCb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MaPNCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaPNCb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaPNCb.FormattingEnabled = true;
            this.MaPNCb.Items.AddRange(new object[] {
            "YES",
            "NO",
            "WAITING"});
            this.MaPNCb.Location = new System.Drawing.Point(40, 206);
            this.MaPNCb.Name = "MaPNCb";
            this.MaPNCb.Size = new System.Drawing.Size(257, 30);
            this.MaPNCb.TabIndex = 72;
            // 
            // MaPhongGiamCb
            // 
            this.MaPhongGiamCb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MaPhongGiamCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaPhongGiamCb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaPhongGiamCb.FormattingEnabled = true;
            this.MaPhongGiamCb.Location = new System.Drawing.Point(40, 134);
            this.MaPhongGiamCb.Name = "MaPhongGiamCb";
            this.MaPhongGiamCb.Size = new System.Drawing.Size(257, 26);
            this.MaPhongGiamCb.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 22);
            this.label5.TabIndex = 70;
            this.label5.Text = "Mã Phạm Nhân";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 22);
            this.label6.TabIndex = 69;
            this.label6.Text = "Mã Phòng Giam";
            // 
            // IdKATb
            // 
            this.IdKATb.BackColor = System.Drawing.SystemColors.InfoText;
            this.IdKATb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdKATb.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.IdKATb.Location = new System.Drawing.Point(36, 59);
            this.IdKATb.Multiline = true;
            this.IdKATb.Name = "IdKATb";
            this.IdKATb.Size = new System.Drawing.Size(261, 32);
            this.IdKATb.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 67;
            this.label2.Text = "Mã Số Kết Án";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(36, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 73;
            this.label1.Text = "Ngày Về";
            // 
            // dateNV
            // 
            this.dateNV.Location = new System.Drawing.Point(40, 283);
            this.dateNV.Name = "dateNV";
            this.dateNV.Size = new System.Drawing.Size(257, 22);
            this.dateNV.TabIndex = 74;
            // 
            // DeplayTb
            // 
            this.DeplayTb.BackColor = System.Drawing.SystemColors.InfoText;
            this.DeplayTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeplayTb.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.DeplayTb.Location = new System.Drawing.Point(35, 344);
            this.DeplayTb.Multiline = true;
            this.DeplayTb.Name = "DeplayTb";
            this.DeplayTb.Size = new System.Drawing.Size(189, 32);
            this.DeplayTb.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 22);
            this.label3.TabIndex = 75;
            this.label3.Text = "Còn bao nhiêu ngày";
            // 
            // FineTb
            // 
            this.FineTb.BackColor = System.Drawing.SystemColors.InfoText;
            this.FineTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FineTb.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.FineTb.Location = new System.Drawing.Point(35, 423);
            this.FineTb.Multiline = true;
            this.FineTb.Name = "FineTb";
            this.FineTb.Size = new System.Drawing.Size(196, 32);
            this.FineTb.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 22);
            this.label4.TabIndex = 77;
            this.label4.Text = "Còn bao nhiêu tháng";
            // 
            // yearTb
            // 
            this.yearTb.BackColor = System.Drawing.SystemColors.InfoText;
            this.yearTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTb.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.yearTb.Location = new System.Drawing.Point(35, 505);
            this.yearTb.Multiline = true;
            this.yearTb.Name = "yearTb";
            this.yearTb.Size = new System.Drawing.Size(196, 32);
            this.yearTb.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 22);
            this.label7.TabIndex = 79;
            this.label7.Text = "Còn bao nhiêu năm";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(30, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 53);
            this.button1.TabIndex = 81;
            this.button1.Text = "THÊM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1332, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 683);
            this.panel1.TabIndex = 82;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 673);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1332, 10);
            this.flowLayoutPanel1.TabIndex = 83;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 673);
            this.panel2.TabIndex = 84;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(12, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1320, 14);
            this.panel3.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1286, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 42);
            this.label8.TabIndex = 86;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(30, 609);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 53);
            this.button2.TabIndex = 87;
            this.button2.Text = "CONFIRM";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 683);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yearTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FineTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeplayTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaPNCb);
            this.Controls.Add(this.MaPhongGiamCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IdKATb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RentDTGV);
            this.Controls.Add(this.ReturnDTGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReturnDTGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentDTGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReturnDTGV;
        private System.Windows.Forms.DataGridView RentDTGV;
        private System.Windows.Forms.ComboBox MaPNCb;
        private System.Windows.Forms.ComboBox MaPhongGiamCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdKATb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateNV;
        private System.Windows.Forms.TextBox DeplayTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FineTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yearTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}