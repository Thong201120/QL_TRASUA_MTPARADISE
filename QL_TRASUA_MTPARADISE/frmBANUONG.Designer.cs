namespace QL_TRASUA_MTPARADISE
{
    partial class frmBANUONG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBANUONG));
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.txtIDBan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBAN = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablestatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXemBan = new System.Windows.Forms.Button();
            this.btnSuaBan = new System.Windows.Forms.Button();
            this.btnThemBan = new System.Windows.Forms.Button();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBAN)).BeginInit();
            this.panel22.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.BackColor = System.Drawing.Color.Azure;
            this.txtTrangthai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangthai.Location = new System.Drawing.Point(368, 538);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(141, 24);
            this.txtTrangthai.TabIndex = 14;
            this.txtTrangthai.TextChanged += new System.EventHandler(this.txtTrangthai_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(391, 509);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Trạng Thái:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtTenBan
            // 
            this.txtTenBan.BackColor = System.Drawing.Color.Azure;
            this.txtTenBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBan.Location = new System.Drawing.Point(141, 538);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(213, 24);
            this.txtTenBan.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(218, 509);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 18);
            this.label13.TabIndex = 8;
            this.label13.Text = "Tên Bàn:";
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.Teal;
            this.panel20.Location = new System.Drawing.Point(21, 531);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(75, 1);
            this.panel20.TabIndex = 7;
            // 
            // txtIDBan
            // 
            this.txtIDBan.BackColor = System.Drawing.Color.Azure;
            this.txtIDBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDBan.Location = new System.Drawing.Point(2, 538);
            this.txtIDBan.Name = "txtIDBan";
            this.txtIDBan.Size = new System.Drawing.Size(119, 24);
            this.txtIDBan.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(30, 506);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "ID Bàn:";
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.panel2);
            this.panel21.Controls.Add(this.dgvBAN);
            this.panel21.Controls.Add(this.txtTrangthai);
            this.panel21.Controls.Add(this.panel20);
            this.panel21.Controls.Add(this.panel3);
            this.panel21.Controls.Add(this.label14);
            this.panel21.Controls.Add(this.panel1);
            this.panel21.Controls.Add(this.txtIDBan);
            this.panel21.Controls.Add(this.label10);
            this.panel21.Controls.Add(this.label13);
            this.panel21.Controls.Add(this.txtTenBan);
            this.panel21.Controls.Add(this.panel22);
            this.panel21.Controls.Add(this.panel19);
            this.panel21.Location = new System.Drawing.Point(12, 12);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(513, 624);
            this.panel21.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(282, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 1);
            this.panel2.TabIndex = 13;
            // 
            // dgvBAN
            // 
            this.dgvBAN.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvBAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBAN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tablename,
            this.tablestatus});
            this.dgvBAN.GridColor = System.Drawing.Color.MintCream;
            this.dgvBAN.Location = new System.Drawing.Point(4, 4);
            this.dgvBAN.Name = "dgvBAN";
            this.dgvBAN.RowHeadersWidth = 51;
            this.dgvBAN.RowTemplate.Height = 24;
            this.dgvBAN.Size = new System.Drawing.Size(509, 498);
            this.dgvBAN.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID BÀN";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // tablename
            // 
            this.tablename.DataPropertyName = "tablename";
            this.tablename.HeaderText = "TÊN BÀN";
            this.tablename.MinimumWidth = 6;
            this.tablename.Name = "tablename";
            this.tablename.Width = 125;
            // 
            // tablestatus
            // 
            this.tablestatus.DataPropertyName = "tablestatus";
            this.tablestatus.HeaderText = "TRẠNG THÁI";
            this.tablestatus.MinimumWidth = 6;
            this.tablestatus.Name = "tablestatus";
            this.tablestatus.Width = 125;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Location = new System.Drawing.Point(389, 531);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(103, 1);
            this.panel3.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(204, 530);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 1);
            this.panel1.TabIndex = 11;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.btnXoa);
            this.panel22.Controls.Add(this.btnXemBan);
            this.panel22.Controls.Add(this.btnSuaBan);
            this.panel22.Controls.Add(this.btnThemBan);
            this.panel22.Location = new System.Drawing.Point(-2, 568);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(513, 44);
            this.panel22.TabIndex = 9;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Teal;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(391, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 38);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXemBan
            // 
            this.btnXemBan.BackColor = System.Drawing.Color.Teal;
            this.btnXemBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBan.ForeColor = System.Drawing.Color.White;
            this.btnXemBan.Location = new System.Drawing.Point(263, 3);
            this.btnXemBan.Name = "btnXemBan";
            this.btnXemBan.Size = new System.Drawing.Size(119, 38);
            this.btnXemBan.TabIndex = 2;
            this.btnXemBan.Text = "Xem";
            this.btnXemBan.UseVisualStyleBackColor = false;
            this.btnXemBan.Click += new System.EventHandler(this.btnXemBan_Click);
            // 
            // btnSuaBan
            // 
            this.btnSuaBan.BackColor = System.Drawing.Color.Teal;
            this.btnSuaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaBan.ForeColor = System.Drawing.Color.White;
            this.btnSuaBan.Location = new System.Drawing.Point(133, 3);
            this.btnSuaBan.Name = "btnSuaBan";
            this.btnSuaBan.Size = new System.Drawing.Size(119, 38);
            this.btnSuaBan.TabIndex = 1;
            this.btnSuaBan.Text = "Sửa";
            this.btnSuaBan.UseVisualStyleBackColor = false;
            this.btnSuaBan.Click += new System.EventHandler(this.btnSuaBan_Click);
            // 
            // btnThemBan
            // 
            this.btnThemBan.BackColor = System.Drawing.Color.Teal;
            this.btnThemBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemBan.ForeColor = System.Drawing.Color.White;
            this.btnThemBan.Location = new System.Drawing.Point(3, 3);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Size = new System.Drawing.Size(119, 38);
            this.btnThemBan.TabIndex = 0;
            this.btnThemBan.Text = "Thêm";
            this.btnThemBan.UseVisualStyleBackColor = false;
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Teal;
            this.panel19.Location = new System.Drawing.Point(141, 479);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(36, 1);
            this.panel19.TabIndex = 10;
            // 
            // frmBANUONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(536, 637);
            this.Controls.Add(this.panel21);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBANUONG";
            this.Text = "Quản lí bàn";
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBAN)).EndInit();
            this.panel22.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TextBox txtIDBan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.DataGridView dgvBAN;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXemBan;
        private System.Windows.Forms.Button btnSuaBan;
        private System.Windows.Forms.Button btnThemBan;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablename;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablestatus;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}