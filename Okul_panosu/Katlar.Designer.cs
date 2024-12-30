namespace Okul_panosu
{
    partial class Katlar
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.katIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.okulPanoDataSet = new Okul_panosu.OkulPanoDataSet();
            this.katlarTableAdapter = new Okul_panosu.OkulPanoDataSetTableAdapters.KatlarTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulPanoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.katIDDataGridViewTextBoxColumn,
            this.katAdiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.katlarBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 254);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // katIDDataGridViewTextBoxColumn
            // 
            this.katIDDataGridViewTextBoxColumn.DataPropertyName = "KatID";
            this.katIDDataGridViewTextBoxColumn.HeaderText = "KatID";
            this.katIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.katIDDataGridViewTextBoxColumn.Name = "katIDDataGridViewTextBoxColumn";
            this.katIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.katIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // katAdiDataGridViewTextBoxColumn
            // 
            this.katAdiDataGridViewTextBoxColumn.DataPropertyName = "KatAdi";
            this.katAdiDataGridViewTextBoxColumn.HeaderText = "KatAdi";
            this.katAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.katAdiDataGridViewTextBoxColumn.Name = "katAdiDataGridViewTextBoxColumn";
            this.katAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // katlarBindingSource
            // 
            this.katlarBindingSource.DataMember = "Katlar";
            this.katlarBindingSource.DataSource = this.okulPanoDataSet;
            // 
            // okulPanoDataSet
            // 
            this.okulPanoDataSet.DataSetName = "OkulPanoDataSet";
            this.okulPanoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // katlarTableAdapter
            // 
            this.katlarTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(50, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(468, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Katlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 348);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Katlar";
            this.Text = "Katlar";
            this.Load += new System.EventHandler(this.Katlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulPanoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private OkulPanoDataSet okulPanoDataSet;
        private System.Windows.Forms.BindingSource katlarBindingSource;
        private OkulPanoDataSetTableAdapters.KatlarTableAdapter katlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn katIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}