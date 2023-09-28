namespace QuanLy_ToiPhamTheKy
{
    partial class Management_Criminal
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
            this.NgayVedtgv = new System.Windows.Forms.DataGridView();
            this.QuanLydtgv = new System.Windows.Forms.DataGridView();
            this.phongDTGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.StatusCb = new System.Windows.Forms.ComboBox();
            this.LevelTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ActionTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdKATb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NgayVedtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLydtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongDTGV)).BeginInit();
            this.SuspendLayout();
            // 
            // NgayVedtgv
            // 
            this.NgayVedtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NgayVedtgv.Location = new System.Drawing.Point(15, 8);
            this.NgayVedtgv.Name = "NgayVedtgv";
            this.NgayVedtgv.RowHeadersWidth = 51;
            this.NgayVedtgv.RowTemplate.Height = 24;
            this.NgayVedtgv.Size = new System.Drawing.Size(555, 363);
            this.NgayVedtgv.TabIndex = 0;
            // 
            // QuanLydtgv
            // 
            this.QuanLydtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuanLydtgv.Location = new System.Drawing.Point(591, 8);
            this.QuanLydtgv.Name = "QuanLydtgv";
            this.QuanLydtgv.RowHeadersWidth = 51;
            this.QuanLydtgv.RowTemplate.Height = 24;
            this.QuanLydtgv.Size = new System.Drawing.Size(615, 363);
            this.QuanLydtgv.TabIndex = 1;
            // 
            // phongDTGV
            // 
            this.phongDTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phongDTGV.Location = new System.Drawing.Point(15, 396);
            this.phongDTGV.Name = "phongDTGV";
            this.phongDTGV.RowHeadersWidth = 51;
            this.phongDTGV.RowTemplate.Height = 24;
            this.phongDTGV.Size = new System.Drawing.Size(555, 330);
            this.phongDTGV.TabIndex = 2;
            this.phongDTGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.phongDTGV_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1002, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 155);
            this.button1.TabIndex = 3;
            this.button1.Text = "DUYỆT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StatusCb
            // 
            this.StatusCb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StatusCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusCb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StatusCb.FormattingEnabled = true;
            this.StatusCb.Items.AddRange(new object[] {
            "NO",
            "WAITING"});
            this.StatusCb.Location = new System.Drawing.Point(812, 581);
            this.StatusCb.Name = "StatusCb";
            this.StatusCb.Size = new System.Drawing.Size(172, 33);
            this.StatusCb.TabIndex = 22;
            // 
            // LevelTb
            // 
            this.LevelTb.BackColor = System.Drawing.SystemColors.InfoText;
            this.LevelTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelTb.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.LevelTb.Location = new System.Drawing.Point(814, 635);
            this.LevelTb.Multiline = true;
            this.LevelTb.Name = "LevelTb";
            this.LevelTb.Size = new System.Drawing.Size(172, 32);
            this.LevelTb.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(602, 640);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mức Độ Phạm Tội";
            // 
            // ActionTb
            // 
            this.ActionTb.BackColor = System.Drawing.SystemColors.InfoText;
            this.ActionTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionTb.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ActionTb.Location = new System.Drawing.Point(812, 462);
            this.ActionTb.Multiline = true;
            this.ActionTb.Name = "ActionTb";
            this.ActionTb.Size = new System.Drawing.Size(172, 90);
            this.ActionTb.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(598, 588);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tình Trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(602, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Hành Vi Phạm Tội";
            // 
            // IdKATb
            // 
            this.IdKATb.BackColor = System.Drawing.SystemColors.InfoText;
            this.IdKATb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdKATb.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.IdKATb.Location = new System.Drawing.Point(812, 408);
            this.IdKATb.Multiline = true;
            this.IdKATb.Name = "IdKATb";
            this.IdKATb.Size = new System.Drawing.Size(172, 32);
            this.IdKATb.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(602, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã Số Phòng";
            // 
            // Management_Criminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 738);
            this.Controls.Add(this.StatusCb);
            this.Controls.Add(this.LevelTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ActionTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdKATb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phongDTGV);
            this.Controls.Add(this.QuanLydtgv);
            this.Controls.Add(this.NgayVedtgv);
            this.Name = "Management_Criminal";
            this.Text = "Management_Criminal";
            this.Load += new System.EventHandler(this.Management_Criminal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NgayVedtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLydtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongDTGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NgayVedtgv;
        private System.Windows.Forms.DataGridView QuanLydtgv;
        private System.Windows.Forms.DataGridView phongDTGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox StatusCb;
        private System.Windows.Forms.TextBox LevelTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ActionTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdKATb;
        private System.Windows.Forms.Label label2;
    }
}