namespace Cinema
{
    partial class Otdelkad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Otdelkad));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.otdelkadrovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataSet = new Cinema.CinemaDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDHRdepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Post = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dolzhnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateOfAcceptanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberoftheemploymentcontractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofdissmisalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_reason_for_dismissal = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.prichinayvolnenyaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdel_kadrovTableAdapter = new Cinema.CinemaDataSetTableAdapters.Otdel_kadrovTableAdapter();
            this.dolzhnostTableAdapter = new Cinema.CinemaDataSetTableAdapters.DolzhnostTableAdapter();
            this.prichina_yvolnenyaTableAdapter = new Cinema.CinemaDataSetTableAdapters.Prichina_yvolnenyaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otdelkadrovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolzhnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prichinayvolnenyaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.otdelkadrovBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripTextBox1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(103, 450);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(98, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // otdelkadrovBindingSource
            // 
            this.otdelkadrovBindingSource.DataMember = "Otdel_kadrov";
            this.otdelkadrovBindingSource.DataSource = this.cinemaDataSet;
            // 
            // cinemaDataSet
            // 
            this.cinemaDataSet.DataSetName = "CinemaDataSet";
            this.cinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(98, 25);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(98, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(98, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(98, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(98, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(98, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(98, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(98, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(98, 6);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(98, 28);
            this.toolStripButton1.Text = "Обновление";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(98, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(94, 31);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отдел кадров";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDHRdepartmentDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.ID_Post,
            this.dateOfAcceptanceDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.numberoftheemploymentcontractDataGridViewTextBoxColumn,
            this.dateofdissmisalDataGridViewTextBoxColumn,
            this.ID_reason_for_dismissal});
            this.dataGridView1.DataSource = this.otdelkadrovBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(193, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(949, 319);
            this.dataGridView1.TabIndex = 2;
            // 
            // iDHRdepartmentDataGridViewTextBoxColumn
            // 
            this.iDHRdepartmentDataGridViewTextBoxColumn.DataPropertyName = "ID_HR_department";
            this.iDHRdepartmentDataGridViewTextBoxColumn.HeaderText = "ИД отдел кадров";
            this.iDHRdepartmentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDHRdepartmentDataGridViewTextBoxColumn.Name = "iDHRdepartmentDataGridViewTextBoxColumn";
            this.iDHRdepartmentDataGridViewTextBoxColumn.Width = 150;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО:";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО:";
            this.фИОDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.Width = 150;
            // 
            // ID_Post
            // 
            this.ID_Post.DataPropertyName = "ID_Post";
            this.ID_Post.DataSource = this.dolzhnostBindingSource;
            this.ID_Post.DisplayMember = "name_of_post";
            this.ID_Post.HeaderText = "должность";
            this.ID_Post.MinimumWidth = 8;
            this.ID_Post.Name = "ID_Post";
            this.ID_Post.ValueMember = "ID_Post";
            this.ID_Post.Width = 150;
            // 
            // dolzhnostBindingSource
            // 
            this.dolzhnostBindingSource.DataMember = "Dolzhnost";
            this.dolzhnostBindingSource.DataSource = this.cinemaDataSet;
            // 
            // dateOfAcceptanceDataGridViewTextBoxColumn
            // 
            this.dateOfAcceptanceDataGridViewTextBoxColumn.DataPropertyName = "date of acceptance";
            this.dateOfAcceptanceDataGridViewTextBoxColumn.HeaderText = "дата принятия";
            this.dateOfAcceptanceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateOfAcceptanceDataGridViewTextBoxColumn.Name = "dateOfAcceptanceDataGridViewTextBoxColumn";
            this.dateOfAcceptanceDataGridViewTextBoxColumn.Width = 90;
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "стаж";
            this.experienceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            this.experienceDataGridViewTextBoxColumn.Width = 60;
            // 
            // numberoftheemploymentcontractDataGridViewTextBoxColumn
            // 
            this.numberoftheemploymentcontractDataGridViewTextBoxColumn.DataPropertyName = "number_of_the_employment_contract";
            this.numberoftheemploymentcontractDataGridViewTextBoxColumn.HeaderText = "номер тд";
            this.numberoftheemploymentcontractDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberoftheemploymentcontractDataGridViewTextBoxColumn.Name = "numberoftheemploymentcontractDataGridViewTextBoxColumn";
            this.numberoftheemploymentcontractDataGridViewTextBoxColumn.Width = 80;
            // 
            // dateofdissmisalDataGridViewTextBoxColumn
            // 
            this.dateofdissmisalDataGridViewTextBoxColumn.DataPropertyName = "date_of_dissmisal";
            this.dateofdissmisalDataGridViewTextBoxColumn.HeaderText = "дата увольнения";
            this.dateofdissmisalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateofdissmisalDataGridViewTextBoxColumn.Name = "dateofdissmisalDataGridViewTextBoxColumn";
            this.dateofdissmisalDataGridViewTextBoxColumn.Width = 150;
            // 
            // ID_reason_for_dismissal
            // 
            this.ID_reason_for_dismissal.DataPropertyName = "ID_reason_for_dismissal";
            this.ID_reason_for_dismissal.DataSource = this.prichinayvolnenyaBindingSource;
            this.ID_reason_for_dismissal.DisplayMember = "reason";
            this.ID_reason_for_dismissal.HeaderText = "причина увольнения";
            this.ID_reason_for_dismissal.MinimumWidth = 8;
            this.ID_reason_for_dismissal.Name = "ID_reason_for_dismissal";
            this.ID_reason_for_dismissal.ValueMember = "ID_reason_for_dismissal";
            this.ID_reason_for_dismissal.Width = 150;
            // 
            // prichinayvolnenyaBindingSource
            // 
            this.prichinayvolnenyaBindingSource.DataMember = "Prichina_yvolnenya";
            this.prichinayvolnenyaBindingSource.DataSource = this.cinemaDataSet;
            // 
            // otdel_kadrovTableAdapter
            // 
            this.otdel_kadrovTableAdapter.ClearBeforeFill = true;
            // 
            // dolzhnostTableAdapter
            // 
            this.dolzhnostTableAdapter.ClearBeforeFill = true;
            // 
            // prichina_yvolnenyaTableAdapter
            // 
            this.prichina_yvolnenyaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(193, 374);
            this.button1.MaximumSize = new System.Drawing.Size(201, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "Дополнительные данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Otdelkad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1194, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindingNavigator1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Otdelkad";
            this.Text = "Отдел кадров";
            this.Load += new System.EventHandler(this.Otdelkad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otdelkadrovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolzhnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prichinayvolnenyaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CinemaDataSet cinemaDataSet;
        private System.Windows.Forms.BindingSource otdelkadrovBindingSource;
        private CinemaDataSetTableAdapters.Otdel_kadrovTableAdapter otdel_kadrovTableAdapter;
        private System.Windows.Forms.BindingSource dolzhnostBindingSource;
        private CinemaDataSetTableAdapters.DolzhnostTableAdapter dolzhnostTableAdapter;
        private System.Windows.Forms.BindingSource prichinayvolnenyaBindingSource;
        private CinemaDataSetTableAdapters.Prichina_yvolnenyaTableAdapter prichina_yvolnenyaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHRdepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfAcceptanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberoftheemploymentcontractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofdissmisalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_reason_for_dismissal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}