namespace QL_TRASUA_MTPARADISE
{
    partial class INTHONGKE
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
            this.crvINTHONGKE = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvINTHONGKE
            // 
            this.crvINTHONGKE.ActiveViewIndex = -1;
            this.crvINTHONGKE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvINTHONGKE.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvINTHONGKE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvINTHONGKE.Location = new System.Drawing.Point(0, 0);
            this.crvINTHONGKE.Name = "crvINTHONGKE";
            this.crvINTHONGKE.Size = new System.Drawing.Size(800, 450);
            this.crvINTHONGKE.TabIndex = 0;
            // 
            // INTHONGKE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvINTHONGKE);
            this.Name = "INTHONGKE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INTHONGKE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmINTHONGKE_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvINTHONGKE;
    }
}