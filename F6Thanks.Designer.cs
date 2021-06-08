
namespace CCWFA
{
    partial class F6Thanks
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
            this.lbThanks = new System.Windows.Forms.Label();
            this.pbQR = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // lbThanks
            // 
            this.lbThanks.AutoSize = true;
            this.lbThanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbThanks.Location = new System.Drawing.Point(280, 38);
            this.lbThanks.Name = "lbThanks";
            this.lbThanks.Size = new System.Drawing.Size(218, 39);
            this.lbThanks.TabIndex = 0;
            this.lbThanks.Text = "Terima Kasih";
            // 
            // pbQR
            // 
            this.pbQR.Location = new System.Drawing.Point(287, 174);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(222, 204);
            this.pbQR.TabIndex = 1;
            this.pbQR.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 417);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 22);
            this.textBox1.TabIndex = 2;
            // 
            // F6Thanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pbQR);
            this.Controls.Add(this.lbThanks);
            this.Name = "F6Thanks";
            this.Text = "F6Thanks";
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbThanks;
        private System.Windows.Forms.PictureBox pbQR;
        private System.Windows.Forms.TextBox textBox1;
    }
}