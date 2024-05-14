namespace UchetOborudovania
{
    partial class OknoRucovoditel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idOborudovaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.seriyniyNomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerKabinetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSotrudnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oborudovanieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchetOborudovaniaDataSet2 = new UchetOborudovania.UchetOborudovaniaDataSet2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idSotrudnikaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerTelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotrudnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchetOborudovaniaDataSet3 = new UchetOborudovania.UchetOborudovaniaDataSet3();
            this.buttonNazad = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.oborudovanieTableAdapter = new UchetOborudovania.UchetOborudovaniaDataSet2TableAdapters.OborudovanieTableAdapter();
            this.sotrudnikiTableAdapter = new UchetOborudovania.UchetOborudovaniaDataSet3TableAdapters.SotrudnikiTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetOborudovaniaDataSet2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetOborudovaniaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(633, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Руководитель";
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
            this.label3.Size = new System.Drawing.Size(173, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Архипов Валентин Богуславович";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(235, 170);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(853, 518);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(845, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Оборудование";
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
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(832, 370);
            this.dataGridView1.TabIndex = 0;
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
            // oborudovanieBindingSource
            // 
            this.oborudovanieBindingSource.DataMember = "Oborudovanie";
            this.oborudovanieBindingSource.DataSource = this.uchetOborudovaniaDataSet2;
            // 
            // uchetOborudovaniaDataSet2
            // 
            this.uchetOborudovaniaDataSet2.DataSetName = "UchetOborudovaniaDataSet2";
            this.uchetOborudovaniaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(845, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сотрудники";
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSotrudnikaDataGridViewTextBoxColumn1,
            this.fIODataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.rolDataGridViewTextBoxColumn,
            this.nomerTelefonaDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.sotrudnikiBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(7, 7);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(832, 318);
            this.dataGridView3.TabIndex = 0;
            // 
            // idSotrudnikaDataGridViewTextBoxColumn1
            // 
            this.idSotrudnikaDataGridViewTextBoxColumn1.DataPropertyName = "idSotrudnika";
            this.idSotrudnikaDataGridViewTextBoxColumn1.HeaderText = "idSotrudnika";
            this.idSotrudnikaDataGridViewTextBoxColumn1.Name = "idSotrudnikaDataGridViewTextBoxColumn1";
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // rolDataGridViewTextBoxColumn
            // 
            this.rolDataGridViewTextBoxColumn.DataPropertyName = "rol";
            this.rolDataGridViewTextBoxColumn.HeaderText = "rol";
            this.rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
            // 
            // nomerTelefonaDataGridViewTextBoxColumn
            // 
            this.nomerTelefonaDataGridViewTextBoxColumn.DataPropertyName = "nomerTelefona";
            this.nomerTelefonaDataGridViewTextBoxColumn.HeaderText = "nomerTelefona";
            this.nomerTelefonaDataGridViewTextBoxColumn.Name = "nomerTelefonaDataGridViewTextBoxColumn";
            // 
            // sotrudnikiBindingSource
            // 
            this.sotrudnikiBindingSource.DataMember = "Sotrudniki";
            this.sotrudnikiBindingSource.DataSource = this.uchetOborudovaniaDataSet3;
            // 
            // uchetOborudovaniaDataSet3
            // 
            this.uchetOborudovaniaDataSet3.DataSetName = "UchetOborudovaniaDataSet3";
            this.uchetOborudovaniaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // oborudovanieTableAdapter
            // 
            this.oborudovanieTableAdapter.ClearBeforeFill = true;
            // 
            // sotrudnikiTableAdapter
            // 
            this.sotrudnikiTableAdapter.ClearBeforeFill = true;
            // 
            // OknoRucovoditel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 700);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OknoRucovoditel";
            this.Text = "Окно. Руководитель";
            this.Load += new System.EventHandler(this.OknoRucovoditel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborudovanieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetOborudovaniaDataSet2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetOborudovaniaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonNazad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private UchetOborudovaniaDataSet2 uchetOborudovaniaDataSet2;
        private System.Windows.Forms.BindingSource oborudovanieBindingSource;
        private UchetOborudovaniaDataSet2TableAdapters.OborudovanieTableAdapter oborudovanieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOborudovaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriyniyNomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerKabinetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSotrudnikaDataGridViewTextBoxColumn;
        private UchetOborudovaniaDataSet3 uchetOborudovaniaDataSet3;
        private System.Windows.Forms.BindingSource sotrudnikiBindingSource;
        private UchetOborudovaniaDataSet3TableAdapters.SotrudnikiTableAdapter sotrudnikiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSotrudnikaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerTelefonaDataGridViewTextBoxColumn;
    }
}