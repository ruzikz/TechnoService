namespace techno
{
    partial class applicationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(applicationForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewApp = new System.Windows.Forms.DataGridView();
            this.applicationDBDataSet = new techno.ApplicationDBDataSet();
            this.repairRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairRequestsTableAdapter = new techno.ApplicationDBDataSetTableAdapters.RepairRequestsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idequipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faulttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairRequestsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(768, 298);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(768, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(768, 146);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(768, 84);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(768, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewApp
            // 
            this.dataGridViewApp.AutoGenerateColumns = false;
            this.dataGridViewApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.iduserDataGridViewTextBoxColumn,
            this.idequipmentDataGridViewTextBoxColumn,
            this.faulttypeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.idemployeeDataGridViewTextBoxColumn});
            this.dataGridViewApp.DataSource = this.repairRequestsBindingSource;
            this.dataGridViewApp.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewApp.Name = "dataGridViewApp";
            this.dataGridViewApp.Size = new System.Drawing.Size(756, 383);
            this.dataGridViewApp.TabIndex = 16;
            // 
            // applicationDBDataSet
            // 
            this.applicationDBDataSet.DataSetName = "ApplicationDBDataSet";
            this.applicationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repairRequestsBindingSource
            // 
            this.repairRequestsBindingSource.DataMember = "RepairRequests";
            this.repairRequestsBindingSource.DataSource = this.applicationDBDataSet;
            // 
            // repairRequestsTableAdapter
            // 
            this.repairRequestsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idDataGridViewTextBoxColumn.HeaderText = "Код";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // iduserDataGridViewTextBoxColumn
            // 
            this.iduserDataGridViewTextBoxColumn.DataPropertyName = "id_user";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iduserDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.iduserDataGridViewTextBoxColumn.HeaderText = "Код пользователя";
            this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
            this.iduserDataGridViewTextBoxColumn.Width = 125;
            // 
            // idequipmentDataGridViewTextBoxColumn
            // 
            this.idequipmentDataGridViewTextBoxColumn.DataPropertyName = "id_equipment";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idequipmentDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.idequipmentDataGridViewTextBoxColumn.HeaderText = "Код устройства";
            this.idequipmentDataGridViewTextBoxColumn.Name = "idequipmentDataGridViewTextBoxColumn";
            this.idequipmentDataGridViewTextBoxColumn.Width = 113;
            // 
            // faulttypeDataGridViewTextBoxColumn
            // 
            this.faulttypeDataGridViewTextBoxColumn.DataPropertyName = "faulttype";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.faulttypeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.faulttypeDataGridViewTextBoxColumn.HeaderText = "Неисправность";
            this.faulttypeDataGridViewTextBoxColumn.Name = "faulttypeDataGridViewTextBoxColumn";
            this.faulttypeDataGridViewTextBoxColumn.Width = 110;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Заметка";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 110;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 90;
            // 
            // idemployeeDataGridViewTextBoxColumn
            // 
            this.idemployeeDataGridViewTextBoxColumn.DataPropertyName = "id_employee";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idemployeeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.idemployeeDataGridViewTextBoxColumn.HeaderText = "Код сотрудника";
            this.idemployeeDataGridViewTextBoxColumn.Name = "idemployeeDataGridViewTextBoxColumn";
            this.idemployeeDataGridViewTextBoxColumn.Width = 115;
            // 
            // applicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 383);
            this.Controls.Add(this.dataGridViewApp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(875, 422);
            this.MinimumSize = new System.Drawing.Size(875, 422);
            this.Name = "applicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявки";
            this.Load += new System.EventHandler(this.applicationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairRequestsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewApp;
        private ApplicationDBDataSet applicationDBDataSet;
        private System.Windows.Forms.BindingSource repairRequestsBindingSource;
        private ApplicationDBDataSetTableAdapters.RepairRequestsTableAdapter repairRequestsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idequipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faulttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idemployeeDataGridViewTextBoxColumn;
    }
}