namespace QuanLy_ToiPhamTheKy
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            this.MyProgress = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.percent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // MyProgress
            // 
            this.MyProgress.BackColor = System.Drawing.Color.Black;
            this.MyProgress.Location = new System.Drawing.Point(1, 30);
            this.MyProgress.Name = "MyProgress";
            this.MyProgress.Size = new System.Drawing.Size(215, 27);
            this.MyProgress.TabIndex = 0;
            this.MyProgress.Click += new System.EventHandler(this.MyProgress_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.BackColor = System.Drawing.SystemColors.Control;
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.percent.Location = new System.Drawing.Point(221, 41);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(59, 16);
            this.percent.TabIndex = 1;
            this.percent.Text = "percent";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 88);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.MyProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar MyProgress;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.Timer timer1;
    }
}