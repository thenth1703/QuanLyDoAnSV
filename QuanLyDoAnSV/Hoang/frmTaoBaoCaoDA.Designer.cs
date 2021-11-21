
namespace QuanLyDoAnSV.Hoang
{
    partial class frmTaoBaoCaoDA
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.comCrit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comDetail = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCT = new Guna.UI2.WinForms.Guna2Button();
            this.btnTH = new Guna.UI2.WinForms.Guna2Button();
            this.panelView = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.comCrit);
            this.guna2Panel1.Controls.Add(this.comDetail);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1071, 69);
            this.guna2Panel1.TabIndex = 7;
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
            this.comCrit.Location = new System.Drawing.Point(16, 16);
            this.comCrit.Name = "comCrit";
            this.comCrit.ShadowDecoration.Parent = this.comCrit;
            this.comCrit.Size = new System.Drawing.Size(128, 36);
            this.comCrit.TabIndex = 10;
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
            this.comDetail.Location = new System.Drawing.Point(160, 16);
            this.comDetail.Name = "comDetail";
            this.comDetail.ShadowDecoration.Parent = this.comDetail;
            this.comDetail.Size = new System.Drawing.Size(288, 36);
            this.comDetail.TabIndex = 11;
            this.comDetail.SelectedIndexChanged += new System.EventHandler(this.comDetail_SelectedIndexChanged);
            this.comDetail.SelectionChangeCommitted += new System.EventHandler(this.comDetail_SelectionChangeCommitted);
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
            this.btnCT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCT.ForeColor = System.Drawing.Color.White;
            this.btnCT.HoverState.Parent = this.btnCT;
            this.btnCT.Location = new System.Drawing.Point(464, 16);
            this.btnCT.Name = "btnCT";
            this.btnCT.ShadowDecoration.Parent = this.btnCT;
            this.btnCT.Size = new System.Drawing.Size(128, 36);
            this.btnCT.TabIndex = 13;
            this.btnCT.Text = "Báo cáo chi tiết";
            this.btnCT.Click += new System.EventHandler(this.btnCT_Click);
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
            this.btnTH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTH.ForeColor = System.Drawing.Color.White;
            this.btnTH.HoverState.Parent = this.btnTH;
            this.btnTH.Location = new System.Drawing.Point(608, 16);
            this.btnTH.Name = "btnTH";
            this.btnTH.ShadowDecoration.Parent = this.btnTH;
            this.btnTH.Size = new System.Drawing.Size(128, 36);
            this.btnTH.TabIndex = 12;
            this.btnTH.Text = "Báo cáo tổng hợp";
            this.btnTH.Click += new System.EventHandler(this.btnTH_Click);
            // 
            // panelView
            // 
            this.panelView.Location = new System.Drawing.Point(8, 72);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1072, 600);
            this.panelView.TabIndex = 14;
            // 
            // frmTaoBaoCaoDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1071, 644);
            this.ControlBox = false;
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.btnCT);
            this.Controls.Add(this.btnTH);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTaoBaoCaoDA";
            this.Text = "frmTaoBaoCaoDA";
            this.Load += new System.EventHandler(this.frmTaoBaoCaoDA_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnCT;
        private Guna.UI2.WinForms.Guna2Button btnTH;
        private Guna.UI2.WinForms.Guna2ComboBox comDetail;
        private Guna.UI2.WinForms.Guna2ComboBox comCrit;
        private System.Windows.Forms.Panel panelView;
    }
}