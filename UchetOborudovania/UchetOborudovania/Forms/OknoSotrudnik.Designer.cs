namespace UchetOborudovania
{
    partial class OknoSotrudnik
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNazad = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uchetOborudovaniaDataSet4 = new UchetOborudovania.UchetOborudovaniaDataSet4();
            this.oborudovanieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oborudovanieTableAdapter = new UchetOborudovania.UchetOborudovaniaDataSet4TableAdapters.OborudovanieTableAdapter();
            this.idOborudovaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.seriyniyNomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerKabinetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSotrudnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetOborudovaniaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(633, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сотрудник";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(540, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Окно.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Шилов Вольдемар Степанович";
            // 
            // buttonNazad
            // 
            this.buttonNazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.buttonNazad.Location = new System.Drawing.Point(12, 617);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(149, 57);
            this.buttonNazad.TabIndex = 9;
            this.buttonNazad.Text = "Назад";
            this.buttonNazad.UseVisualStyleBackColor = false;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::UchetOborudovania.Properties.Resources.Федоров;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(12, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 207);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::UchetOborudovania.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(391, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 113);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Оборудование:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOborudovaniaDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn,
            this.seriyniyNomerDataGridViewTextBoxColumn,
            this.naimenovanieDataGridViewTextBoxColumn,
            this.opisanieDataGridViewTextBoxColumn,
            this.nomerKabinetaDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.idSotrudnikaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oborudovanieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(275, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(834, 399);
            this.dataGridView1.TabIndex = 11;
            // 
            // uchetOborudovaniaDataSet4
            // 
            this.uchetOborudovaniaDataSet4.DataSetName = "UchetOborudovaniaDataSet4";
            this.uchetOborudovaniaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oborudovanieBindingSource
            // 
            this.oborudovanieBindingSource.DataMember = "Oborudovanie";
            this.oborudovanieBindingSource.DataSource = this.uchetOborudovaniaDataSet4;
            // 
            // oborudovanieTableAdapter
            // 
            this.oborudovanieTableAdapter.ClearBeforeFill = true;
            // 
            // idOborudovaniaDataGridViewTextBoxColumn
            // 
            this.idOborudovaniaDataGridViewTextBoxColumn.DataPropertyName = "idOborudovania";
            this.idOborudovaniaDataGridViewTextBoxColumn.HeaderText = "idOborudovania";
            this.idOborudovaniaDataGridViewTextBoxColumn.Name = "idOborudovaniaDataGridViewTextBoxColumn";
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "foto";
            this.fotoDataGridViewImageColumn.HeaderText = "foto";
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            // 
            // seriyniyNomerDataGridViewTextBoxColumn
            // 
            this.seriyniyNomerDataGridViewTextBoxColumn.DataPropertyName = "seriyniyNomer";
            this.seriyniyNomerDataGridViewTextBoxColumn.HeaderText = "seriyniyNomer";
            this.seriyniyNomerDataGridViewTextBoxColumn.Name = "seriyniyNomerDataGridViewTextBoxColumn";
            // 
            // naimenovanieDataGridViewTextBoxColumn
            // 
            this.naimenovanieDataGridViewTextBoxColumn.DataPropertyName = "naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.HeaderText = "naimenovanie";
            this.naimenovanieDataGridViewTextBoxColumn.Name = "naimenovanieDataGridViewTextBoxColumn";
            // 
            // opisanieDataGridViewTextBoxColumn
            // 
            this.opisanieDataGridViewTextBoxColumn.DataPropertyName = "opisanie";
            this.opisanieDataGridViewTextBoxColumn.HeaderText = "opisanie";
            this.opisanieDataGridViewTextBoxColumn.Name = "opisanieDataGridViewTextBoxColumn";
            // 
            // nomerKabinetaDataGridViewTextBoxColumn
            // 
            this.nomerKabinetaDataGridViewTextBoxColumn.DataPropertyName = "nomerKabineta";
            this.nomerKabinetaDataGridViewTextBoxColumn.HeaderText = "nomerKabineta";
            this.nomerKabinetaDataGridViewTextBoxColumn.Name = "nomerKabinetaDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // idSotrudnikaDataGridViewTextBoxColumn
            // 
            this.idSotrudnikaDataGridViewTextBoxColumn.DataPropertyName = "idSotrudnika";
            this.idSotrudnikaDataGridViewTextBoxColumn.HeaderText = "idSotrudnika";
            this.idSotrudnikaDataGridViewTextBoxColumn.Name = "idSotrudnikaDataGridViewTextBoxColumn";
            // 
            // OknoSotrudnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 700);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OknoSotrudnik";
            this.Text = "Окно. Сотрудник";
            this.Load += new System.EventHandler(this.OknoSotrudnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetOborudovaniaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonNazad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UchetOborudovaniaDataSet4 uchetOborudovaniaDataSet4;
        private System.Windows.Forms.BindingSource oborudovanieBindingSource;
        private UchetOborudovaniaDataSet4TableAdapters.OborudovanieTableAdapter oborudovanieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOborudovaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriyniyNomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerKabinetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSotrudnikaDataGridViewTextBoxColumn;
    }
}