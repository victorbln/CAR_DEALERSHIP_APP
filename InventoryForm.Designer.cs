namespace CarDealership
{
    partial class InventoryForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            carBindingSource = new BindingSource(components);
            carBindingSource1 = new BindingSource(components);
            inventoryDataGrid = new DataGridView();
            makeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            colorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mileageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vINDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // carBindingSource
            // 
            carBindingSource.DataSource = typeof(Car);
            // 
            // carBindingSource1
            // 
            carBindingSource1.DataSource = typeof(Car);
            // 
            // inventoryDataGrid
            // 
            inventoryDataGrid.AllowUserToAddRows = false;
            inventoryDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 192);
            inventoryDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            inventoryDataGrid.AutoGenerateColumns = false;
            inventoryDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            inventoryDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            inventoryDataGrid.BackgroundColor = Color.FromArgb(255, 255, 192);
            inventoryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryDataGrid.Columns.AddRange(new DataGridViewColumn[] { makeDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, yearDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, colorDataGridViewTextBoxColumn, mileageDataGridViewTextBoxColumn, vINDataGridViewTextBoxColumn });
            inventoryDataGrid.DataSource = carBindingSource2;
            inventoryDataGrid.Dock = DockStyle.Fill;
            inventoryDataGrid.GridColor = Color.FromArgb(255, 192, 128);
            inventoryDataGrid.Location = new Point(0, 0);
            inventoryDataGrid.Name = "inventoryDataGrid";
            inventoryDataGrid.ReadOnly = true;
            inventoryDataGrid.RightToLeft = RightToLeft.No;
            inventoryDataGrid.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            inventoryDataGrid.RowTemplate.Height = 25;
            inventoryDataGrid.ShowCellErrors = false;
            inventoryDataGrid.Size = new Size(800, 450);
            inventoryDataGrid.TabIndex = 0;
            inventoryDataGrid.CellContentClick += inventoryDataGrid_CellContentClick;
            // 
            // makeDataGridViewTextBoxColumn
            // 
            makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            makeDataGridViewTextBoxColumn.HeaderText = "Make";
            makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            makeDataGridViewTextBoxColumn.ReadOnly = true;
            makeDataGridViewTextBoxColumn.Width = 61;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            modelDataGridViewTextBoxColumn.HeaderText = "Model";
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            modelDataGridViewTextBoxColumn.ReadOnly = true;
            modelDataGridViewTextBoxColumn.Width = 66;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            yearDataGridViewTextBoxColumn.HeaderText = "Year";
            yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            yearDataGridViewTextBoxColumn.ReadOnly = true;
            yearDataGridViewTextBoxColumn.Width = 54;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 58;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            colorDataGridViewTextBoxColumn.HeaderText = "Color";
            colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            colorDataGridViewTextBoxColumn.ReadOnly = true;
            colorDataGridViewTextBoxColumn.Width = 61;
            // 
            // mileageDataGridViewTextBoxColumn
            // 
            mileageDataGridViewTextBoxColumn.DataPropertyName = "Mileage";
            mileageDataGridViewTextBoxColumn.HeaderText = "Mileage";
            mileageDataGridViewTextBoxColumn.Name = "mileageDataGridViewTextBoxColumn";
            mileageDataGridViewTextBoxColumn.ReadOnly = true;
            mileageDataGridViewTextBoxColumn.Width = 74;
            // 
            // vINDataGridViewTextBoxColumn
            // 
            vINDataGridViewTextBoxColumn.DataPropertyName = "VIN";
            vINDataGridViewTextBoxColumn.HeaderText = "VIN";
            vINDataGridViewTextBoxColumn.Name = "vINDataGridViewTextBoxColumn";
            vINDataGridViewTextBoxColumn.ReadOnly = true;
            vINDataGridViewTextBoxColumn.Width = 51;
            // 
            // carBindingSource2
            // 
            carBindingSource2.DataSource = typeof(Car);
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(inventoryDataGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventoryForm";
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource carBindingSource;
        private BindingSource carBindingSource1;
        private DataGridView inventoryDataGrid;
        private DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mileageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vINDataGridViewTextBoxColumn;
        private BindingSource carBindingSource2;
    }
}