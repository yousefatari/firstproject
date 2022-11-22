namespace firstapplication
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnwelcome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(61, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(267, 23);
            this.txtName.TabIndex = 1;
            // 
            // btnwelcome
            // 
            this.btnwelcome.Location = new System.Drawing.Point(156, 120);
            this.btnwelcome.Name = "btnwelcome";
            this.btnwelcome.Size = new System.Drawing.Size(146, 104);
            this.btnwelcome.TabIndex = 2;
            this.btnwelcome.Text = "welcome";
            this.btnwelcome.UseVisualStyleBackColor = true;
            this.btnwelcome.Click += new System.EventHandler(this.btnwelcome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 402);
            this.Controls.Add(this.btnwelcome);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "first application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Button btnwelcome;
    }
}