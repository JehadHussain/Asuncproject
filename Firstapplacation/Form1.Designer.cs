
namespace Firstapplacation
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
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnwelcome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(81, 69);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(33, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(134, 66);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(306, 20);
            this.txtname.TabIndex = 1;
            // 
            // btnwelcome
            // 
            this.btnwelcome.Location = new System.Drawing.Point(152, 143);
            this.btnwelcome.Name = "btnwelcome";
            this.btnwelcome.Size = new System.Drawing.Size(114, 49);
            this.btnwelcome.TabIndex = 2;
            this.btnwelcome.Text = "welcome";
            this.btnwelcome.UseVisualStyleBackColor = true;
            this.btnwelcome.Click += new System.EventHandler(this.btnwelcome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnwelcome);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnwelcome;
    }
}

