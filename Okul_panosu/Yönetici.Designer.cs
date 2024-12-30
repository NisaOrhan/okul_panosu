namespace Okul_panosu
{
    partial class Yönetici
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
            this.button_duyurular = new System.Windows.Forms.Button();
            this.button_katlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_duyurular
            // 
            this.button_duyurular.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_duyurular.Location = new System.Drawing.Point(26, 78);
            this.button_duyurular.Name = "button_duyurular";
            this.button_duyurular.Size = new System.Drawing.Size(116, 39);
            this.button_duyurular.TabIndex = 0;
            this.button_duyurular.Text = "DUYURULAR";
            this.button_duyurular.UseVisualStyleBackColor = true;
            this.button_duyurular.Click += new System.EventHandler(this.button_duyurular_Click);
            // 
            // button_katlar
            // 
            this.button_katlar.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_katlar.Location = new System.Drawing.Point(162, 78);
            this.button_katlar.Name = "button_katlar";
            this.button_katlar.Size = new System.Drawing.Size(97, 39);
            this.button_katlar.TabIndex = 1;
            this.button_katlar.Text = "KATLAR";
            this.button_katlar.UseVisualStyleBackColor = true;
            this.button_katlar.Click += new System.EventHandler(this.button_katlar_Click);
            // 
            // Yönetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 210);
            this.Controls.Add(this.button_katlar);
            this.Controls.Add(this.button_duyurular);
            this.Name = "Yönetici";
            this.Text = "Yönetici";
            this.Load += new System.EventHandler(this.Yönetici_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_duyurular;
        private System.Windows.Forms.Button button_katlar;
    }
}