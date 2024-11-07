namespace dataGridView_Shamilova_variant_4
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TotalCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurchargesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WiFiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfVacationerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfNightsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHeader = new System.Windows.Forms.MenuStrip();
            this.CostVacationerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTours = new System.Windows.Forms.DataGridView();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStripHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonDelete});
            this.toolStrip2.Location = new System.Drawing.Point(0, 30);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1306, 31);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = global::dataGridView_Shamilova_variant_4.Properties.Resources.add;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonAdd.Text = "Добавить";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit.Image = global::dataGridView_Shamilova_variant_4.Properties.Resources.edit;
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonEdit.Text = "Редактировать";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = global::dataGridView_Shamilova_variant_4.Properties.Resources.delete;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonDelete.Text = "Удалить";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(111, 28);
            this.toolStripLabel4.Text = "toolStripLabel4";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(111, 28);
            this.toolStripLabel3.Text = "toolStripLabel3";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(111, 28);
            this.toolStripLabel2.Text = "toolStripLabel2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(111, 28);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 419);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1306, 31);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TotalCostColumn
            // 
            this.TotalCostColumn.DataPropertyName = "TotalCost";
            this.TotalCostColumn.HeaderText = "Общая стоимость";
            this.TotalCostColumn.MinimumWidth = 6;
            this.TotalCostColumn.Name = "TotalCostColumn";
            this.TotalCostColumn.Width = 125;
            // 
            // SurchargesColumn
            // 
            this.SurchargesColumn.DataPropertyName = "Surcharges";
            this.SurchargesColumn.HeaderText = "Доплаты (руб)";
            this.SurchargesColumn.MinimumWidth = 6;
            this.SurchargesColumn.Name = "SurchargesColumn";
            this.SurchargesColumn.Width = 125;
            // 
            // WiFiColumn
            // 
            this.WiFiColumn.DataPropertyName = "WiFi";
            this.WiFiColumn.HeaderText = "Наличие WiFi";
            this.WiFiColumn.MinimumWidth = 6;
            this.WiFiColumn.Name = "WiFiColumn";
            this.WiFiColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.WiFiColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WiFiColumn.Width = 125;
            // 
            // NumberOfVacationerColumn
            // 
            this.NumberOfVacationerColumn.DataPropertyName = "NumberOfVacationer";
            this.NumberOfVacationerColumn.HeaderText = "Количество отдыющих";
            this.NumberOfVacationerColumn.MinimumWidth = 6;
            this.NumberOfVacationerColumn.Name = "NumberOfVacationerColumn";
            this.NumberOfVacationerColumn.Width = 125;
            // 
            // NumberOfNightsColumn
            // 
            this.NumberOfNightsColumn.DataPropertyName = "NumberOfNights";
            this.NumberOfNightsColumn.HeaderText = "Количество ночей";
            this.NumberOfNightsColumn.MinimumWidth = 6;
            this.NumberOfNightsColumn.Name = "NumberOfNightsColumn";
            this.NumberOfNightsColumn.Width = 125;
            // 
            // DepartureDateColumn
            // 
            this.DepartureDateColumn.DataPropertyName = "DepartureDate";
            this.DepartureDateColumn.HeaderText = "Дата вылета";
            this.DepartureDateColumn.MinimumWidth = 6;
            this.DepartureDateColumn.Name = "DepartureDateColumn";
            this.DepartureDateColumn.Width = 125;
            // 
            // DirectionColumn
            // 
            this.DirectionColumn.DataPropertyName = "Direction";
            this.DirectionColumn.HeaderText = "Направление";
            this.DirectionColumn.MinimumWidth = 6;
            this.DirectionColumn.Name = "DirectionColumn";
            this.DirectionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DirectionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DirectionColumn.Width = 125;
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(96, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(86, 26);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // menuStripHeader
            // 
            this.menuStripHeader.BackColor = System.Drawing.Color.Lavender;
            this.menuStripHeader.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripHeader.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStripHeader.Location = new System.Drawing.Point(0, 0);
            this.menuStripHeader.Name = "menuStripHeader";
            this.menuStripHeader.Size = new System.Drawing.Size(1306, 30);
            this.menuStripHeader.TabIndex = 4;
            this.menuStripHeader.Text = "menuStrip1";
            // 
            // CostVacationerColumn
            // 
            this.CostVacationerColumn.DataPropertyName = "CostVacationer";
            this.CostVacationerColumn.HeaderText = "Стоимость за отдыхающего";
            this.CostVacationerColumn.MinimumWidth = 6;
            this.CostVacationerColumn.Name = "CostVacationerColumn";
            this.CostVacationerColumn.Width = 125;
            // 
            // dataGridViewTours
            // 
            this.dataGridViewTours.AllowUserToAddRows = false;
            this.dataGridViewTours.AllowUserToDeleteRows = false;
            this.dataGridViewTours.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridViewTours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DirectionColumn,
            this.DepartureDateColumn,
            this.NumberOfNightsColumn,
            this.CostVacationerColumn,
            this.NumberOfVacationerColumn,
            this.WiFiColumn,
            this.SurchargesColumn,
            this.TotalCostColumn});
            this.dataGridViewTours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTours.Location = new System.Drawing.Point(0, 61);
            this.dataGridViewTours.Name = "dataGridViewTours";
            this.dataGridViewTours.RowHeadersWidth = 51;
            this.dataGridViewTours.RowTemplate.Height = 24;
            this.dataGridViewTours.Size = new System.Drawing.Size(1306, 358);
            this.dataGridViewTours.TabIndex = 5;
            this.dataGridViewTours.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewTours_CellFormatting);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 450);
            this.Controls.Add(this.dataGridViewTours);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStripHeader);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Горящие туры";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStripHeader.ResumeLayout(false);
            this.menuStripHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurchargesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WiFiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfVacationerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfNightsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectionColumn;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostVacationerColumn;
        private System.Windows.Forms.DataGridView dataGridViewTours;
    }
}

