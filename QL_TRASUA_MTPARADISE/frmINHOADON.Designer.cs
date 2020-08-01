namespace QL_TRASUA_MTPARADISE
{
    partial class frmINHOADON
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
            this.crvInHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvInHoaDon
            // 
            this.crvInHoaDon.ActiveViewIndex = -1;
            this.crvInHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInHoaDon.Location = new System.Drawing.Point(0, 0);
            this.crvInHoaDon.Name = "crvInHoaDon";
            this.crvInHoaDon.Size = new System.Drawing.Size(800, 450);
            this.crvInHoaDon.TabIndex = 0;
            // 
            // frmINHOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvInHoaDon);
            this.MaximizeBox = false;
            this.Name = "frmINHOADON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmINHOADON";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmINHOADON_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInHoaDon;
    }
}