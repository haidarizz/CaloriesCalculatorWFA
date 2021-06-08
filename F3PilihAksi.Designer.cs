
namespace CCWFA
{
    partial class F3PilihAksi
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lbAtas = new System.Windows.Forms.Label();
            this.btCS = new System.Windows.Forms.Button();
            this.btCJ = new System.Windows.Forms.Button();
            this.btHKR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBack.Location = new System.Drawing.Point(12, 397);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 41);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbAtas
            // 
            this.lbAtas.AutoSize = true;
            this.lbAtas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbAtas.Location = new System.Drawing.Point(221, 21);
            this.lbAtas.Name = "lbAtas";
            this.lbAtas.Size = new System.Drawing.Size(356, 29);
            this.lbAtas.TabIndex = 8;
            this.lbAtas.Text = "Apa yang ingin Anda lakukan?";
            // 
            // btCS
            // 
            this.btCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btCS.Location = new System.Drawing.Point(135, 284);
            this.btCS.Name = "btCS";
            this.btCS.Size = new System.Drawing.Size(524, 62);
            this.btCS.TabIndex = 7;
            this.btCS.Text = "Menghitung Kalori setelah Berenang";
            this.btCS.UseVisualStyleBackColor = true;
            this.btCS.Click += new System.EventHandler(this.btCS_Click);
            // 
            // btCJ
            // 
            this.btCJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btCJ.Location = new System.Drawing.Point(135, 189);
            this.btCJ.Name = "btCJ";
            this.btCJ.Size = new System.Drawing.Size(524, 62);
            this.btCJ.TabIndex = 6;
            this.btCJ.Text = "Menghitung Kalori setelah Jogging";
            this.btCJ.UseVisualStyleBackColor = true;
            this.btCJ.Click += new System.EventHandler(this.btCJ_Click);
            // 
            // btHKR
            // 
            this.btHKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btHKR.Location = new System.Drawing.Point(135, 92);
            this.btHKR.Name = "btHKR";
            this.btHKR.Size = new System.Drawing.Size(524, 62);
            this.btHKR.TabIndex = 5;
            this.btHKR.Text = "Hasil Kebugaran dan Rekomendasi";
            this.btHKR.UseVisualStyleBackColor = true;
            this.btHKR.Click += new System.EventHandler(this.btHKR_Click);
            // 
            // F3PilihAksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbAtas);
            this.Controls.Add(this.btCS);
            this.Controls.Add(this.btCJ);
            this.Controls.Add(this.btHKR);
            this.Name = "F3PilihAksi";
            this.Text = "F3PilihAksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbAtas;
        private System.Windows.Forms.Button btCS;
        private System.Windows.Forms.Button btCJ;
        private System.Windows.Forms.Button btHKR;
    }
}