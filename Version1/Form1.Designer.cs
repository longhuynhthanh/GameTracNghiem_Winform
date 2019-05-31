namespace Version1
{
    partial class Form1
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
            this.gbCauHoi = new System.Windows.Forms.GroupBox();
            this.txtCauHoi = new System.Windows.Forms.TextBox();
            this.gbDapAn = new System.Windows.Forms.GroupBox();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.tmThoiGian = new System.Windows.Forms.Timer(this.components);
            this.lblDongHo = new System.Windows.Forms.Label();
            this.tmDem = new System.Windows.Forms.Timer(this.components);
            this.lblDem = new System.Windows.Forms.Label();
            this.gbCauHoi.SuspendLayout();
            this.gbDapAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCauHoi
            // 
            this.gbCauHoi.Controls.Add(this.txtCauHoi);
            this.gbCauHoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCauHoi.Location = new System.Drawing.Point(114, 60);
            this.gbCauHoi.Name = "gbCauHoi";
            this.gbCauHoi.Size = new System.Drawing.Size(503, 147);
            this.gbCauHoi.TabIndex = 0;
            this.gbCauHoi.TabStop = false;
            this.gbCauHoi.Text = "Câu Hỏi";
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCauHoi.Location = new System.Drawing.Point(6, 19);
            this.txtCauHoi.Multiline = true;
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.ReadOnly = true;
            this.txtCauHoi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCauHoi.Size = new System.Drawing.Size(497, 122);
            this.txtCauHoi.TabIndex = 0;
            // 
            // gbDapAn
            // 
            this.gbDapAn.Controls.Add(this.rdbD);
            this.gbDapAn.Controls.Add(this.rdbC);
            this.gbDapAn.Controls.Add(this.rdbB);
            this.gbDapAn.Controls.Add(this.rdbA);
            this.gbDapAn.Controls.Add(this.txtD);
            this.gbDapAn.Controls.Add(this.txtC);
            this.gbDapAn.Controls.Add(this.txtB);
            this.gbDapAn.Controls.Add(this.txtA);
            this.gbDapAn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDapAn.Location = new System.Drawing.Point(120, 213);
            this.gbDapAn.Name = "gbDapAn";
            this.gbDapAn.Size = new System.Drawing.Size(497, 289);
            this.gbDapAn.TabIndex = 1;
            this.gbDapAn.TabStop = false;
            this.gbDapAn.Text = "Đáp Án";
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Location = new System.Drawing.Point(6, 230);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(42, 26);
            this.rdbD.TabIndex = 11;
            this.rdbD.TabStop = true;
            this.rdbD.Text = "D";
            this.rdbD.UseVisualStyleBackColor = true;
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Location = new System.Drawing.Point(6, 174);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(42, 26);
            this.rdbC.TabIndex = 10;
            this.rdbC.TabStop = true;
            this.rdbC.Text = "C";
            this.rdbC.UseVisualStyleBackColor = true;
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Location = new System.Drawing.Point(6, 111);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(41, 26);
            this.rdbB.TabIndex = 9;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "B";
            this.rdbB.UseVisualStyleBackColor = true;
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Location = new System.Drawing.Point(6, 45);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(41, 26);
            this.rdbA.TabIndex = 8;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "A";
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(45, 216);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtD.Size = new System.Drawing.Size(446, 56);
            this.txtD.TabIndex = 7;
            this.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(45, 152);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.ReadOnly = true;
            this.txtC.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtC.Size = new System.Drawing.Size(446, 58);
            this.txtC.TabIndex = 6;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(45, 87);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.ReadOnly = true;
            this.txtB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtB.Size = new System.Drawing.Size(446, 59);
            this.txtB.TabIndex = 5;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(45, 26);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.ReadOnly = true;
            this.txtA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtA.Size = new System.Drawing.Size(446, 55);
            this.txtA.TabIndex = 4;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmThoiGian
            // 
            this.tmThoiGian.Interval = 1000;
            this.tmThoiGian.Tick += new System.EventHandler(this.tmThoiGian_Tick);
            // 
            // lblDongHo
            // 
            this.lblDongHo.AutoSize = true;
            this.lblDongHo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDongHo.Location = new System.Drawing.Point(27, 60);
            this.lblDongHo.Name = "lblDongHo";
            this.lblDongHo.Size = new System.Drawing.Size(55, 22);
            this.lblDongHo.TabIndex = 2;
            this.lblDongHo.Text = "00:00";
            // 
            // tmDem
            // 
            this.tmDem.Interval = 1000;
            this.tmDem.Tick += new System.EventHandler(this.tmDem_Tick);
            // 
            // lblDem
            // 
            this.lblDem.AutoSize = true;
            this.lblDem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDem.Location = new System.Drawing.Point(309, 35);
            this.lblDem.Name = "lblDem";
            this.lblDem.Size = new System.Drawing.Size(30, 22);
            this.lblDem.TabIndex = 3;
            this.lblDem.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.lblDem);
            this.Controls.Add(this.lblDongHo);
            this.Controls.Add(this.gbDapAn);
            this.Controls.Add(this.gbCauHoi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCauHoi.ResumeLayout(false);
            this.gbCauHoi.PerformLayout();
            this.gbDapAn.ResumeLayout(false);
            this.gbDapAn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCauHoi;
        private System.Windows.Forms.TextBox txtCauHoi;
        private System.Windows.Forms.GroupBox gbDapAn;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.RadioButton rdbD;
        private System.Windows.Forms.RadioButton rdbC;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.Timer tmThoiGian;
        private System.Windows.Forms.Label lblDongHo;
        private System.Windows.Forms.Timer tmDem;
        private System.Windows.Forms.Label lblDem;
    }
}

