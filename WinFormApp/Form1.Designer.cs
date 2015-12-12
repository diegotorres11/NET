namespace WinFormApp
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
            this.btnOpenSecondForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenSecondForm
            // 
            this.btnOpenSecondForm.Location = new System.Drawing.Point(47, 22);
            this.btnOpenSecondForm.Name = "btnOpenSecondForm";
            this.btnOpenSecondForm.Size = new System.Drawing.Size(110, 28);
            this.btnOpenSecondForm.TabIndex = 0;
            this.btnOpenSecondForm.Text = "Open Second Form";
            this.btnOpenSecondForm.UseVisualStyleBackColor = true;
            this.btnOpenSecondForm.Click += new System.EventHandler(this.btnOpenSecondForm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Change Form2 Label";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChangeLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 294);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenSecondForm);
            this.Name = "btnChangeLabel";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenSecondForm;
        private System.Windows.Forms.Button button1;
    }
}

