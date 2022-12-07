namespace custom_user_control
{
    partial class ucContry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUC = new System.Windows.Forms.Label();
            this.cboContrys = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblUC
            // 
            this.lblUC.AutoSize = true;
            this.lblUC.Location = new System.Drawing.Point(5, 11);
            this.lblUC.Name = "lblUC";
            this.lblUC.Size = new System.Drawing.Size(51, 15);
            this.lblUC.TabIndex = 0;
            this.lblUC.Text = "Contry:";
            // 
            // cboContrys
            // 
            this.cboContrys.FormattingEnabled = true;
            this.cboContrys.Location = new System.Drawing.Point(62, 8);
            this.cboContrys.Name = "cboContrys";
            this.cboContrys.Size = new System.Drawing.Size(285, 23);
            this.cboContrys.TabIndex = 1;
            // 
            // ucContry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboContrys);
            this.Controls.Add(this.lblUC);
            this.Name = "ucContry";
            this.Size = new System.Drawing.Size(360, 39);
            this.Load += new System.EventHandler(this.ucState_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUC;
        private ComboBox cboContrys;
    }
}
