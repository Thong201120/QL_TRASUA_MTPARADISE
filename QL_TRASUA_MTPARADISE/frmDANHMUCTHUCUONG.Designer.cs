namespace QL_TRASUA_MTPARADISE
{
    partial class frmDANHMUCTHUCUONG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDANHMUCTHUCUONG));
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtIDDanhMuc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.btnXemDM = new System.Windows.Forms.Button();
            this.btnSuaDM = new System.Windows.Forms.Button();
            this.btnThemDM = new System.Windows.Forms.Button();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drinklistname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Teal;
            this.panel13.Location = new System.Drawing.Point(311, 500);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(150, 2);
            this.panel13.TabIndex = 10;
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.BackColor = System.Drawing.Color.Azure;
            this.txtTenDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDanhMuc.Location = new System.Drawing.Point(277, 508);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(229, 24);
            this.txtTenDanhMuc.TabIndex = 9;
            this.txtTenDanhMuc.TextChanged += new System.EventHandler(this.txtTenDanhMuc_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(327, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tên Danh Mục:";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Teal;
            this.panel14.Location = new System.Drawing.Point(38, 500);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(150, 2);
            this.panel14.TabIndex = 7;
            // 
            // txtIDDanhMuc
            // 
            this.txtIDDanhMuc.BackColor = System.Drawing.Color.Azure;
            this.txtIDDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDDanhMuc.Location = new System.Drawing.Point(0, 508);
            this.txtIDDanhMuc.Name = "txtIDDanhMuc";
            this.txtIDDanhMuc.ReadOnly = true;
            this.txtIDDanhMuc.Size = new System.Drawing.Size(229, 24);
            this.txtIDDanhMuc.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(61, 477);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "ID Danh Mục:";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.panel13);
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.dgvDanhMuc);
            this.panel15.Controls.Add(this.txtTenDanhMuc);
            this.panel15.Controls.Add(this.txtIDDanhMuc);
            this.panel15.Controls.Add(this.label12);
            this.panel15.Controls.Add(this.label11);
            this.panel15.Controls.Add(this.panel14);
            this.panel15.Location = new System.Drawing.Point(3, 12);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(513, 595);
            this.panel15.TabIndex = 10;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.btnXoaDM);
            this.panel16.Controls.Add(this.btnXemDM);
            this.panel16.Controls.Add(this.btnSuaDM);
            this.panel16.Controls.Add(this.btnThemDM);
            this.panel16.Location = new System.Drawing.Point(-3, 538);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(513, 44);
            this.panel16.TabIndex = 9;
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.BackColor = System.Drawing.Color.Teal;
            this.btnXoaDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDM.ForeColor = System.Drawing.Color.White;
            this.btnXoaDM.Location = new System.Drawing.Point(391, 3);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(119, 38);
            this.btnXoaDM.TabIndex = 3;
            this.btnXoaDM.Text = "Xóa";
            this.btnXoaDM.UseVisualStyleBackColor = false;
            this.btnXoaDM.Click += new System.EventHandler(this.btnXoaDM_Click);
            // 
            // btnXemDM
            // 
            this.btnXemDM.BackColor = System.Drawing.Color.Teal;
            this.btnXemDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDM.ForeColor = System.Drawing.Color.White;
            this.btnXemDM.Location = new System.Drawing.Point(263, 3);
            this.btnXemDM.Name = "btnXemDM";
            this.btnXemDM.Size = new System.Drawing.Size(119, 38);
            this.btnXemDM.TabIndex = 2;
            this.btnXemDM.Text = "Xem";
            this.btnXemDM.UseVisualStyleBackColor = false;
            this.btnXemDM.Click += new System.EventHandler(this.btnXemDM_Click);
            // 
            // btnSuaDM
            // 
            this.btnSuaDM.BackColor = System.Drawing.Color.Teal;
            this.btnSuaDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDM.ForeColor = System.Drawing.Color.White;
            this.btnSuaDM.Location = new System.Drawing.Point(133, 3);
            this.btnSuaDM.Name = "btnSuaDM";
            this.btnSuaDM.Size = new System.Drawing.Size(119, 38);
            this.btnSuaDM.TabIndex = 1;
            this.btnSuaDM.Text = "Sửa";
            this.btnSuaDM.UseVisualStyleBackColor = false;
            this.btnSuaDM.Click += new System.EventHandler(this.btnSuaDM_Click);
            // 
            // btnThemDM
            // 
            this.btnThemDM.BackColor = System.Drawing.Color.Teal;
            this.btnThemDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDM.ForeColor = System.Drawing.Color.White;
            this.btnThemDM.Location = new System.Drawing.Point(4, 3);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(119, 38);
            this.btnThemDM.TabIndex = 0;
            this.btnThemDM.Text = "Thêm";
            this.btnThemDM.UseVisualStyleBackColor = false;
            this.btnThemDM.Click += new System.EventHandler(this.btnThemDM_Click);
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.drinklistname});
            this.dgvDanhMuc.Location = new System.Drawing.Point(2, 0);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.RowHeadersWidth = 51;
            this.dgvDanhMuc.RowTemplate.Height = 24;
            this.dgvDanhMuc.Size = new System.Drawing.Size(509, 464);
            this.dgvDanhMuc.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID DANH MỤC";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // drinklistname
            // 
            this.drinklistname.DataPropertyName = "drinklistname";
            this.drinklistname.HeaderText = "TÊN DANH MỤC";
            this.drinklistname.MinimumWidth = 6;
            this.drinklistname.Name = "drinklistname";
            this.drinklistname.Width = 300;
            // 
            // frmDANHMUCTHUCUONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(517, 603);
            this.Controls.Add(this.panel15);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDANHMUCTHUCUONG";
            this.Text = "Quản Lí Danh Mục";
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txtIDDanhMuc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnXemDM;
        private System.Windows.Forms.Button btnSuaDM;
        private System.Windows.Forms.Button btnThemDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn drinklistname;
    }
}