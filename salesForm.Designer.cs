namespace CarDealership
{
    partial class salesForm
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
            saleBindingSource = new BindingSource(components);
            salesDataGrid = new DataGridView();
            carVINDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerEmailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerPhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saleDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saleDTOBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // saleBindingSource
            // 
            saleBindingSource.DataSource = typeof(Sale);
            // 
            // salesDataGrid
            // 
            salesDataGrid.AllowUserToAddRows = false;
            salesDataGrid.AllowUserToDeleteRows = false;
            salesDataGrid.AutoGenerateColumns = false;
            salesDataGrid.BackgroundColor = Color.FromArgb(255, 255, 192);
            salesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesDataGrid.Columns.AddRange(new DataGridViewColumn[] { carVINDataGridViewTextBoxColumn, customerNameDataGridViewTextBoxColumn, customerEmailDataGridViewTextBoxColumn, customerPhoneDataGridViewTextBoxColumn, saleDateDataGridViewTextBoxColumn });
            salesDataGrid.DataSource = saleDTOBindingSource;
            salesDataGrid.Dock = DockStyle.Fill;
            salesDataGrid.GridColor = Color.FromArgb(255, 192, 128);
            salesDataGrid.Location = new Point(0, 0);
            salesDataGrid.Name = "salesDataGrid";
            salesDataGrid.ReadOnly = true;
            salesDataGrid.RowTemplate.Height = 25;
            salesDataGrid.Size = new Size(800, 450);
            salesDataGrid.TabIndex = 0;
            // 
            // carVINDataGridViewTextBoxColumn
            // 
            carVINDataGridViewTextBoxColumn.DataPropertyName = "CarVIN";
            carVINDataGridViewTextBoxColumn.HeaderText = "CarVIN";
            carVINDataGridViewTextBoxColumn.Name = "carVINDataGridViewTextBoxColumn";
            carVINDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerEmailDataGridViewTextBoxColumn
            // 
            customerEmailDataGridViewTextBoxColumn.DataPropertyName = "CustomerEmail";
            customerEmailDataGridViewTextBoxColumn.HeaderText = "CustomerEmail";
            customerEmailDataGridViewTextBoxColumn.Name = "customerEmailDataGridViewTextBoxColumn";
            customerEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerPhoneDataGridViewTextBoxColumn
            // 
            customerPhoneDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhone";
            customerPhoneDataGridViewTextBoxColumn.HeaderText = "CustomerPhone";
            customerPhoneDataGridViewTextBoxColumn.Name = "customerPhoneDataGridViewTextBoxColumn";
            customerPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            saleDateDataGridViewTextBoxColumn.HeaderText = "SaleDate";
            saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            saleDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleDTOBindingSource
            // 
            saleDTOBindingSource.DataSource = typeof(SaleDTO);
            // 
            // salesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(salesDataGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "salesForm";
            Text = "salesForm";
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleDTOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource saleBindingSource;
        private DataGridView salesDataGrid;
        private DataGridViewTextBoxColumn carVINDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerEmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private BindingSource saleDTOBindingSource;
    }
}