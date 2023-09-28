namespace QuanLy_ToiPhamTheKy
{
    partial class InfoDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.NguyennhanTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.infodetailDTGV = new System.Windows.Forms.DataGridView();
            this.FullNameTb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infodetailDTGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Họ Và Tên";
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(367, 60);
            this.NameTb.Multiline = true;
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(228, 29);
            this.NameTb.TabIndex = 1;
            this.NameTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NguyennhanTb
            // 
            this.NguyennhanTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NguyennhanTb.Location = new System.Drawing.Point(13, 549);
            this.NguyennhanTb.Multiline = true;
            this.NguyennhanTb.Name = "NguyennhanTb";
            this.NguyennhanTb.Size = new System.Drawing.Size(1168, 127);
            this.NguyennhanTb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(27, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toàn Bộ Thông Tin";
            // 
            // infodetailDTGV
            // 
            this.infodetailDTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infodetailDTGV.Location = new System.Drawing.Point(13, 105);
            this.infodetailDTGV.Name = "infodetailDTGV";
            this.infodetailDTGV.RowHeadersWidth = 51;
            this.infodetailDTGV.RowTemplate.Height = 24;
            this.infodetailDTGV.Size = new System.Drawing.Size(582, 373);
            this.infodetailDTGV.TabIndex = 5;
            this.infodetailDTGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.infodetailDTGV_CellClick);
            // 
            // FullNameTb
            // 
            this.FullNameTb.Location = new System.Drawing.Point(367, 22);
            this.FullNameTb.Multiline = true;
            this.FullNameTb.Name = "FullNameTb";
            this.FullNameTb.Size = new System.Drawing.Size(232, 29);
            this.FullNameTb.TabIndex = 6;
            this.FullNameTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(500, 494);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 44);
            this.button4.TabIndex = 28;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1137, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 42);
            this.label3.TabIndex = 29;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Có Thể Xem Ảnh Từ MPN";
            // 
            // InfoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 702);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.FullNameTb);
            this.Controls.Add(this.infodetailDTGV);
            this.Controls.Add(this.NguyennhanTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoDetail";
            this.Load += new System.EventHandler(this.InfoDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infodetailDTGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.TextBox NguyennhanTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView infodetailDTGV;
        private System.Windows.Forms.TextBox FullNameTb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}