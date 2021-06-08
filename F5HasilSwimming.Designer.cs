
namespace CCWFA
{
    partial class F5HasilSwimming
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
            this.lbRecommendation = new System.Windows.Forms.Label();
            this.lbActivity = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRecommendation
            // 
            this.lbRecommendation.AutoSize = true;
            this.lbRecommendation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbRecommendation.Location = new System.Drawing.Point(65, 160);
            this.lbRecommendation.Name = "lbRecommendation";
            this.lbRecommendation.Size = new System.Drawing.Size(70, 26);
            this.lbRecommendation.TabIndex = 5;
            this.lbRecommendation.Text = "label2";
            // 
            // lbActivity
            // 
            this.lbActivity.AutoSize = true;
            this.lbActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbActivity.Location = new System.Drawing.Point(65, 58);
            this.lbActivity.Name = "lbActivity";
            this.lbActivity.Size = new System.Drawing.Size(70, 26);
            this.lbActivity.TabIndex = 4;
            this.lbActivity.Text = "label1";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnNext.Location = new System.Drawing.Point(915, 329);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 44);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // F5HasilSwimming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 385);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbRecommendation);
            this.Controls.Add(this.lbActivity);
            this.Name = "F5HasilSwimming";
            this.Text = "F5HasilSwimming";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRecommendation;
        private System.Windows.Forms.Label lbActivity;
        private System.Windows.Forms.Button btnNext;
    }
}