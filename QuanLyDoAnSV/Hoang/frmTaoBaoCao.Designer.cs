
namespace QuanLyDoAnSV.Hoang
{
    partial class frmTaoBaoCao
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
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comCrit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comDetail = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnTH = new Guna.UI2.WinForms.Guna2Button();
            this.btnCT = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo báo cáo";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(64, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiêu thức";
            // 
            // comCrit
            // 
            this.comCrit.BackColor = System.Drawing.Color.Transparent;
            this.comCrit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comCrit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comCrit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comCrit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comCrit.FocusedState.Parent = this.comCrit;
            this.comCrit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comCrit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comCrit.HoverState.Parent = this.comCrit;
            this.comCrit.ItemHeight = 30;
            this.comCrit.ItemsAppearance.Parent = this.comCrit;
            this.comCrit.Location = new System.Drawing.Point(64, 160);
            this.comCrit.Name = "comCrit";
            this.comCrit.ShadowDecoration.Parent = this.comCrit;
            this.comCrit.Size = new System.Drawing.Size(184, 36);
            this.comCrit.TabIndex = 2;
            this.comCrit.SelectedIndexChanged += new System.EventHandler(this.comCrit_SelectedIndexChanged);
            this.comCrit.SelectionChangeCommitted += new System.EventHandler(this.comCrit_SelectionChangeCommitted);
            // 
            // comDetail
            // 
            this.comDetail.BackColor = System.Drawing.Color.Transparent;
            this.comDetail.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comDetail.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comDetail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comDetail.FocusedState.Parent = this.comDetail;
            this.comDetail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comDetail.HoverState.Parent = this.comDetail;
            this.comDetail.ItemHeight = 30;
            this.comDetail.ItemsAppearance.Parent = this.comDetail;
            this.comDetail.Location = new System.Drawing.Point(280, 160);
            this.comDetail.Name = "comDetail";
            this.comDetail.ShadowDecoration.Parent = this.comDetail;
            this.comDetail.Size = new System.Drawing.Size(184, 36);
            this.comDetail.TabIndex = 3;
            this.comDetail.SelectionChangeCommitted += new System.EventHandler(this.comDetail_SelectionChangeCommitted);
            // 
            // btnTH
            // 
            this.btnTH.CheckedState.Parent = this.btnTH;
            this.btnTH.CustomImages.Parent = this.btnTH;
            this.btnTH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTH.DisabledState.Parent = this.btnTH;
            this.btnTH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTH.ForeColor = System.Drawing.Color.White;
            this.btnTH.HoverState.Parent = this.btnTH;
            this.btnTH.Location = new System.Drawing.Point(64, 248);
            this.btnTH.Name = "btnTH";
            this.btnTH.ShadowDecoration.Parent = this.btnTH;
            this.btnTH.Size = new System.Drawing.Size(180, 45);
            this.btnTH.TabIndex = 4;
            this.btnTH.Text = "Báo cáo tổng hợp";
            this.btnTH.Click += new System.EventHandler(this.btnTH_Click);
            // 
            // btnCT
            // 
            this.btnCT.CheckedState.Parent = this.btnCT;
            this.btnCT.CustomImages.Parent = this.btnCT;
            this.btnCT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCT.DisabledState.Parent = this.btnCT;
            this.btnCT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCT.ForeColor = System.Drawing.Color.White;
            this.btnCT.HoverState.Parent = this.btnCT;
            this.btnCT.Location = new System.Drawing.Point(280, 248);
            this.btnCT.Name = "btnCT";
            this.btnCT.ShadowDecoration.Parent = this.btnCT;
            this.btnCT.Size = new System.Drawing.Size(180, 45);
            this.btnCT.TabIndex = 5;
            this.btnCT.Text = "Báo cáo chi tiết";
            this.btnCT.Click += new System.EventHandler(this.btnCT_Click);
            // 
            // frmTaoBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1087, 683);
            this.ControlBox = false;
            this.Controls.Add(this.btnCT);
            this.Controls.Add(this.btnTH);
            this.Controls.Add(this.comDetail);
            this.Controls.Add(this.comCrit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTaoBaoCao";
            this.Text = "frmTaoBaoCao";
            this.Load += new System.EventHandler(this.frmTaoBaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel label2;
        private Guna.UI2.WinForms.Guna2ComboBox comCrit;
        private Guna.UI2.WinForms.Guna2ComboBox comDetail;
        private Guna.UI2.WinForms.Guna2Button btnTH;
        private Guna.UI2.WinForms.Guna2Button btnCT;
    }
}