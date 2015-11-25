namespace GraphicsPathApp
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
            this.btnDrawPath = new System.Windows.Forms.Button();
            this.btnFillpath = new System.Windows.Forms.Button();
            this.btnDrawBitmap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDrawPath
            // 
            this.btnDrawPath.Location = new System.Drawing.Point(465, 22);
            this.btnDrawPath.Name = "btnDrawPath";
            this.btnDrawPath.Size = new System.Drawing.Size(75, 23);
            this.btnDrawPath.TabIndex = 0;
            this.btnDrawPath.Text = "Draw Path";
            this.btnDrawPath.UseVisualStyleBackColor = true;
            this.btnDrawPath.Click += new System.EventHandler(this.btnDrawPath_Click);
            // 
            // btnFillpath
            // 
            this.btnFillpath.Location = new System.Drawing.Point(465, 63);
            this.btnFillpath.Name = "btnFillpath";
            this.btnFillpath.Size = new System.Drawing.Size(75, 23);
            this.btnFillpath.TabIndex = 1;
            this.btnFillpath.Text = "Fill Path";
            this.btnFillpath.UseVisualStyleBackColor = true;
            this.btnFillpath.Click += new System.EventHandler(this.btnFillpath_Click);
            // 
            // btnDrawBitmap
            // 
            this.btnDrawBitmap.Location = new System.Drawing.Point(466, 103);
            this.btnDrawBitmap.Name = "btnDrawBitmap";
            this.btnDrawBitmap.Size = new System.Drawing.Size(75, 23);
            this.btnDrawBitmap.TabIndex = 2;
            this.btnDrawBitmap.Text = "Image";
            this.btnDrawBitmap.UseVisualStyleBackColor = true;
            this.btnDrawBitmap.Click += new System.EventHandler(this.btnDrawBitmap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 347);
            this.Controls.Add(this.btnDrawBitmap);
            this.Controls.Add(this.btnFillpath);
            this.Controls.Add(this.btnDrawPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDrawPath;
        private System.Windows.Forms.Button btnFillpath;
        private System.Windows.Forms.Button btnDrawBitmap;
    }
}

