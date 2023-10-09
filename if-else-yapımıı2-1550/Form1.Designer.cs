namespace if_else_yapımıı2_1550
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
            this.cbYesil = new System.Windows.Forms.CheckBox();
            this.cbkirmizi = new System.Windows.Forms.CheckBox();
            this.cbMavi = new System.Windows.Forms.CheckBox();
            this.cbSari = new System.Windows.Forms.CheckBox();
            this.cbMor = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbYesil
            // 
            this.cbYesil.AutoSize = true;
            this.cbYesil.Location = new System.Drawing.Point(67, 38);
            this.cbYesil.Name = "cbYesil";
            this.cbYesil.Size = new System.Drawing.Size(46, 17);
            this.cbYesil.TabIndex = 0;
            this.cbYesil.Text = "yeşil";
            this.cbYesil.UseVisualStyleBackColor = true;
            this.cbYesil.CheckedChanged += new System.EventHandler(this.cbYesil_CheckedChanged);
            // 
            // cbkirmizi
            // 
            this.cbkirmizi.AutoSize = true;
            this.cbkirmizi.Location = new System.Drawing.Point(67, 90);
            this.cbkirmizi.Name = "cbkirmizi";
            this.cbkirmizi.Size = new System.Drawing.Size(54, 17);
            this.cbkirmizi.TabIndex = 1;
            this.cbkirmizi.Text = "kırmızı";
            this.cbkirmizi.UseVisualStyleBackColor = true;
            this.cbkirmizi.CheckedChanged += new System.EventHandler(this.cbkirmizi_CheckedChanged);
            // 
            // cbMavi
            // 
            this.cbMavi.AutoSize = true;
            this.cbMavi.Location = new System.Drawing.Point(67, 144);
            this.cbMavi.Name = "cbMavi";
            this.cbMavi.Size = new System.Drawing.Size(48, 17);
            this.cbMavi.TabIndex = 2;
            this.cbMavi.Text = "mavi";
            this.cbMavi.UseVisualStyleBackColor = true;
            this.cbMavi.CheckedChanged += new System.EventHandler(this.cbMavi_CheckedChanged);
            // 
            // cbSari
            // 
            this.cbSari.AutoSize = true;
            this.cbSari.Location = new System.Drawing.Point(67, 211);
            this.cbSari.Name = "cbSari";
            this.cbSari.Size = new System.Drawing.Size(42, 17);
            this.cbSari.TabIndex = 3;
            this.cbSari.Text = "sari";
            this.cbSari.UseVisualStyleBackColor = true;
            this.cbSari.CheckedChanged += new System.EventHandler(this.cbSari_CheckedChanged);
            // 
            // cbMor
            // 
            this.cbMor.AutoSize = true;
            this.cbMor.Location = new System.Drawing.Point(67, 276);
            this.cbMor.Name = "cbMor";
            this.cbMor.Size = new System.Drawing.Size(43, 17);
            this.cbMor.TabIndex = 4;
            this.cbMor.Text = "mor";
            this.cbMor.UseVisualStyleBackColor = true;
            this.cbMor.CheckedChanged += new System.EventHandler(this.cbMor_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbMor);
            this.Controls.Add(this.cbSari);
            this.Controls.Add(this.cbMavi);
            this.Controls.Add(this.cbkirmizi);
            this.Controls.Add(this.cbYesil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbYesil;
        private System.Windows.Forms.CheckBox cbkirmizi;
        private System.Windows.Forms.CheckBox cbMavi;
        private System.Windows.Forms.CheckBox cbSari;
        private System.Windows.Forms.CheckBox cbMor;
    }
}

