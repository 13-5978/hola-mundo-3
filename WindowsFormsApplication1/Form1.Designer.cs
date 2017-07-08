namespace WindowsFormsApplication1
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
            this.Holamundo3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Holamundo3
            // 
            this.Holamundo3.AutoSize = true;
            this.Holamundo3.Location = new System.Drawing.Point(55, 31);
            this.Holamundo3.Name = "Holamundo3";
            this.Holamundo3.Size = new System.Drawing.Size(59, 13);
            this.Holamundo3.TabIndex = 0;
            this.Holamundo3.Text = "holamudo3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 261);
            this.Controls.Add(this.Holamundo3);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Holamundo3;
    }
}

