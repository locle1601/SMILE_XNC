namespace SMILE_XNC
{
    partial class FMain
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
            this.dataGridViewSML = new System.Windows.Forms.DataGridView();
            this.txtkhaibao = new System.Windows.Forms.Label();
            this.txtFdate = new System.Windows.Forms.Label();
            this.txtTDate = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateFDate = new System.Windows.Forms.DateTimePicker();
            this.DateToD = new System.Windows.Forms.DateTimePicker();
            this.lbGuest = new System.Windows.Forms.Label();
            this.cbGuest = new System.Windows.Forms.ComboBox();
            this.btloaddata = new System.Windows.Forms.Button();
            this.btSaveXML = new System.Windows.Forms.Button();
            this.btExcel = new System.Windows.Forms.Button();
            this.sMILE_FODataSet = new SMILE_XNC.SMILE_FODataSet();
            this.sMILEFODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMILE_FODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMILEFODataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSML
            // 
            this.dataGridViewSML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSML.Location = new System.Drawing.Point(12, 181);
            this.dataGridViewSML.Name = "dataGridViewSML";
            this.dataGridViewSML.Size = new System.Drawing.Size(1240, 470);
            this.dataGridViewSML.TabIndex = 0;
            // 
            // txtkhaibao
            // 
            this.txtkhaibao.AutoSize = true;
            this.txtkhaibao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkhaibao.Location = new System.Drawing.Point(30, 28);
            this.txtkhaibao.Name = "txtkhaibao";
            this.txtkhaibao.Size = new System.Drawing.Size(86, 15);
            this.txtkhaibao.TabIndex = 1;
            this.txtkhaibao.Text = "Chọn khai báo";
            this.txtkhaibao.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFdate
            // 
            this.txtFdate.AutoSize = true;
            this.txtFdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFdate.Location = new System.Drawing.Point(30, 64);
            this.txtFdate.Name = "txtFdate";
            this.txtFdate.Size = new System.Drawing.Size(50, 15);
            this.txtFdate.TabIndex = 2;
            this.txtFdate.Text = "Từ ngày";
            // 
            // txtTDate
            // 
            this.txtTDate.AutoSize = true;
            this.txtTDate.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txtTDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDate.Location = new System.Drawing.Point(30, 97);
            this.txtTDate.Name = "txtTDate";
            this.txtTDate.Size = new System.Drawing.Size(59, 15);
            this.txtTDate.TabIndex = 3;
            this.txtTDate.Text = "Đến ngày";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SpLuuTru",
            "SpXNC"});
            this.comboBox1.Location = new System.Drawing.Point(121, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateFDate
            // 
            this.dateFDate.CustomFormat = "dd/MM/yyyy";
            this.dateFDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFDate.Location = new System.Drawing.Point(121, 64);
            this.dateFDate.Name = "dateFDate";
            this.dateFDate.Size = new System.Drawing.Size(121, 20);
            this.dateFDate.TabIndex = 5;
            // 
            // DateToD
            // 
            this.DateToD.CustomFormat = "dd/MM/yyyy";
            this.DateToD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateToD.Location = new System.Drawing.Point(121, 97);
            this.DateToD.Name = "DateToD";
            this.DateToD.Size = new System.Drawing.Size(121, 20);
            this.DateToD.TabIndex = 6;
            // 
            // lbGuest
            // 
            this.lbGuest.AutoSize = true;
            this.lbGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuest.Location = new System.Drawing.Point(380, 29);
            this.lbGuest.Name = "lbGuest";
            this.lbGuest.Size = new System.Drawing.Size(39, 15);
            this.lbGuest.TabIndex = 7;
            this.lbGuest.Text = "Guest";
            // 
            // cbGuest
            // 
            this.cbGuest.FormattingEnabled = true;
            this.cbGuest.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbGuest.Location = new System.Drawing.Point(421, 29);
            this.cbGuest.Name = "cbGuest";
            this.cbGuest.Size = new System.Drawing.Size(121, 21);
            this.cbGuest.TabIndex = 8;
            this.cbGuest.SelectedIndexChanged += new System.EventHandler(this.cbGuest_SelectedIndexChanged);
            // 
            // btloaddata
            // 
            this.btloaddata.Location = new System.Drawing.Point(587, 26);
            this.btloaddata.Name = "btloaddata";
            this.btloaddata.Size = new System.Drawing.Size(98, 51);
            this.btloaddata.TabIndex = 9;
            this.btloaddata.Text = "LOAD DATA";
            this.btloaddata.UseVisualStyleBackColor = true;
            this.btloaddata.Click += new System.EventHandler(this.btloaddata_Click);
            // 
            // btSaveXML
            // 
            this.btSaveXML.Location = new System.Drawing.Point(725, 26);
            this.btSaveXML.Name = "btSaveXML";
            this.btSaveXML.Size = new System.Drawing.Size(98, 51);
            this.btSaveXML.TabIndex = 10;
            this.btSaveXML.Text = "SAVE .XML";
            this.btSaveXML.UseVisualStyleBackColor = true;
            this.btSaveXML.Click += new System.EventHandler(this.btSaveXML_Click);
            // 
            // btExcel
            // 
            this.btExcel.Location = new System.Drawing.Point(860, 26);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(98, 51);
            this.btExcel.TabIndex = 11;
            this.btExcel.Text = "SAVE EXCEL";
            this.btExcel.UseVisualStyleBackColor = true;
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            // 
            // sMILE_FODataSet
            // 
            this.sMILE_FODataSet.DataSetName = "SMILE_FODataSet";
            this.sMILE_FODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sMILEFODataSetBindingSource
            // 
            this.sMILEFODataSetBindingSource.DataSource = this.sMILE_FODataSet;
            this.sMILEFODataSetBindingSource.Position = 0;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 705);
            this.Controls.Add(this.btExcel);
            this.Controls.Add(this.btSaveXML);
            this.Controls.Add(this.btloaddata);
            this.Controls.Add(this.cbGuest);
            this.Controls.Add(this.lbGuest);
            this.Controls.Add(this.DateToD);
            this.Controls.Add(this.dateFDate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtTDate);
            this.Controls.Add(this.txtFdate);
            this.Controls.Add(this.txtkhaibao);
            this.Controls.Add(this.dataGridViewSML);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EXPORT_SMILE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMain_FormClosing);
            this.Load += new System.EventHandler(this.FMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMILE_FODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMILEFODataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSML;
        private System.Windows.Forms.Label txtkhaibao;
        private System.Windows.Forms.Label txtFdate;
        private System.Windows.Forms.Label txtTDate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateFDate;
        private System.Windows.Forms.DateTimePicker DateToD;
        private System.Windows.Forms.Label lbGuest;
        private System.Windows.Forms.ComboBox cbGuest;
        private System.Windows.Forms.Button btloaddata;
        private System.Windows.Forms.Button btSaveXML;
        private System.Windows.Forms.Button btExcel;
        private System.Windows.Forms.BindingSource sMILEFODataSetBindingSource;
        private SMILE_FODataSet sMILE_FODataSet;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}