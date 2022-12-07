namespace custom_user_control
{
    partial class frmUserControl
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucContry1 = new custom_user_control.ucContry();
            this.btnContries = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucContry1
            // 
            this.ucContry1.Location = new System.Drawing.Point(59, 12);
            this.ucContry1.Name = "ucContry1";
            this.ucContry1.Size = new System.Drawing.Size(360, 39);
            this.ucContry1.TabIndex = 0;
            // 
            // btnContries
            // 
            this.btnContries.Location = new System.Drawing.Point(187, 71);
            this.btnContries.Name = "btnContries";
            this.btnContries.Size = new System.Drawing.Size(75, 23);
            this.btnContries.TabIndex = 1;
            this.btnContries.Text = "View";
            this.btnContries.UseVisualStyleBackColor = true;
            this.btnContries.Click += new System.EventHandler(this.btnContries_Click);
            // 
            // frmUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 122);
            this.Controls.Add(this.btnContries);
            this.Controls.Add(this.ucContry1);
            this.Name = "frmUserControl";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ucContry ucContry1;
        private Button btnContries;
    }
}