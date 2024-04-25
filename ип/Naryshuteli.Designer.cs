
namespace ип
{
    partial class Naryshuteli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Naryshuteli));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.parking_LotDataSet = new ип.Parking_LotDataSet();
            this.intrudersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intrudersTableAdapter = new ип.Parking_LotDataSetTableAdapters.IntrudersTableAdapter();
            this.intrudersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfLastViolationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfLastViolationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parking_LotDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrudersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrudersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.typeOfLastViolationDataGridViewTextBoxColumn,
            this.dateOfLastViolationDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.intrudersBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 661);
            this.dataGridView1.TabIndex = 0;
            // 
            // parking_LotDataSet
            // 
            this.parking_LotDataSet.DataSetName = "Parking_LotDataSet";
            this.parking_LotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // intrudersBindingSource
            // 
            this.intrudersBindingSource.DataMember = "Intruders";
            this.intrudersBindingSource.DataSource = this.parking_LotDataSet;
            // 
            // intrudersTableAdapter
            // 
            this.intrudersTableAdapter.ClearBeforeFill = true;
            // 
            // intrudersBindingSource1
            // 
            this.intrudersBindingSource1.DataMember = "Intruders";
            this.intrudersBindingSource1.DataSource = this.parking_LotDataSet;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "№п/п";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeOfLastViolationDataGridViewTextBoxColumn
            // 
            this.typeOfLastViolationDataGridViewTextBoxColumn.DataPropertyName = "TypeOfLastViolation";
            this.typeOfLastViolationDataGridViewTextBoxColumn.HeaderText = "Тип последнего нарушения";
            this.typeOfLastViolationDataGridViewTextBoxColumn.Name = "typeOfLastViolationDataGridViewTextBoxColumn";
            // 
            // dateOfLastViolationDataGridViewTextBoxColumn
            // 
            this.dateOfLastViolationDataGridViewTextBoxColumn.DataPropertyName = "DateOfLastViolation";
            this.dateOfLastViolationDataGridViewTextBoxColumn.HeaderText = "Дата последнего нарушения";
            this.dateOfLastViolationDataGridViewTextBoxColumn.Name = "dateOfLastViolationDataGridViewTextBoxColumn";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "Пользователи";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // Naryshuteli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 661);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Naryshuteli";
            this.Text = "Нарушители";
            this.Load += new System.EventHandler(this.Naryshuteli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parking_LotDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrudersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrudersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Parking_LotDataSet parking_LotDataSet;
        private System.Windows.Forms.BindingSource intrudersBindingSource;
        private Parking_LotDataSetTableAdapters.IntrudersTableAdapter intrudersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfLastViolationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfLastViolationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource intrudersBindingSource1;
    }
}