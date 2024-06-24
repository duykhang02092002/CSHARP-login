namespace CSHARP_login
{
    partial class FrmMain
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
            this.lsb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btntinh = new System.Windows.Forms.Button();
            this.txtnhapso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lsb
            // 
            this.lsb.FormattingEnabled = true;
            this.lsb.Location = new System.Drawing.Point(160, 233);
            this.lsb.Name = "lsb";
            this.lsb.Size = new System.Drawing.Size(190, 95);
            this.lsb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nhập số";
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(260, 156);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 2;
            this.btntinh.Text = "tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // txtnhapso
            // 
            this.txtnhapso.Location = new System.Drawing.Point(240, 98);
            this.txtnhapso.Name = "txtnhapso";
            this.txtnhapso.Size = new System.Drawing.Size(100, 20);
            this.txtnhapso.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnhapso);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsb);
            this.Name = "FrmMain";
            this.Text = "tính";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.TextBox txtnhapso;
    }
}