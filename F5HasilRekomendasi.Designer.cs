
namespace CCWFA
{
    partial class F5HasilRekomendasi
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
            this.lbShowBMI = new System.Windows.Forms.Label();
            this.lbShowBMR = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbShowBMI
            // 
            this.lbShowBMI.AutoSize = true;
            this.lbShowBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbShowBMI.Location = new System.Drawing.Point(70, 43);
            this.lbShowBMI.Name = "lbShowBMI";
            this.lbShowBMI.Size = new System.Drawing.Size(70, 26);
            this.lbShowBMI.TabIndex = 0;
            this.lbShowBMI.Text = "label1";
            // 
            // lbShowBMR
            // 
            this.lbShowBMR.AutoSize = true;
            this.lbShowBMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbShowBMR.Location = new System.Drawing.Point(70, 264);
            this.lbShowBMR.Name = "lbShowBMR";
            this.lbShowBMR.Size = new System.Drawing.Size(70, 26);
            this.lbShowBMR.TabIndex = 1;
            this.lbShowBMR.Text = "label2";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnNext.Location = new System.Drawing.Point(944, 454);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 44);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // F5HasilRekomendasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 510);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbShowBMR);
            this.Controls.Add(this.lbShowBMI);
            this.Name = "F5HasilRekomendasi";
            this.Text = "F5HasilRekomendasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbShowBMI;
        private System.Windows.Forms.Label lbShowBMR;
        private System.Windows.Forms.Button btnNext;
    }
}