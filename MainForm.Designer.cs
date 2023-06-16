namespace CarDealership
{
    partial class MainForm
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
            monthComboBox = new ComboBox();
            yearComboBox = new ComboBox();
            salesGridView = new DataGridView();
            filterButton = new Button();
            buttonMeniu = new Panel();
            viewAllSales = new Button();
            updateButton = new Button();
            seeInventoryButton = new Button();
            deleteButton = new Button();
            sellCarButton = new Button();
            addCarButton = new Button();
            appContent = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)salesGridView).BeginInit();
            buttonMeniu.SuspendLayout();
            SuspendLayout();
            // 
            // monthComboBox
            // 
            monthComboBox.Location = new Point(0, 0);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(121, 23);
            monthComboBox.TabIndex = 0;
            // 
            // yearComboBox
            // 
            yearComboBox.Location = new Point(0, 0);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(121, 23);
            yearComboBox.TabIndex = 0;
            // 
            // salesGridView
            // 
            salesGridView.Location = new Point(0, 0);
            salesGridView.Name = "salesGridView";
            salesGridView.Size = new Size(240, 150);
            salesGridView.TabIndex = 0;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(0, 0);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(75, 23);
            filterButton.TabIndex = 0;
            // 
            // buttonMeniu
            // 
            buttonMeniu.BackColor = Color.FromArgb(192, 255, 255);
            buttonMeniu.Controls.Add(viewAllSales);
            buttonMeniu.Controls.Add(updateButton);
            buttonMeniu.Controls.Add(seeInventoryButton);
            buttonMeniu.Controls.Add(deleteButton);
            buttonMeniu.Controls.Add(sellCarButton);
            buttonMeniu.Controls.Add(addCarButton);
            buttonMeniu.Dock = DockStyle.Left;
            buttonMeniu.Location = new Point(0, 0);
            buttonMeniu.Name = "buttonMeniu";
            buttonMeniu.Size = new Size(181, 661);
            buttonMeniu.TabIndex = 0;
            // 
            // viewAllSales
            // 
            viewAllSales.BackColor = Color.FromArgb(192, 255, 192);
            viewAllSales.Location = new Point(15, 287);
            viewAllSales.Name = "viewAllSales";
            viewAllSales.Size = new Size(151, 33);
            viewAllSales.TabIndex = 8;
            viewAllSales.Text = "View All Sales";
            viewAllSales.UseVisualStyleBackColor = false;
            viewAllSales.Click += viewAllSales_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(192, 255, 192);
            updateButton.Location = new Point(15, 248);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(151, 33);
            updateButton.TabIndex = 6;
            updateButton.Text = "Update Car";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click_1;
            // 
            // seeInventoryButton
            // 
            seeInventoryButton.BackColor = Color.FromArgb(192, 255, 192);
            seeInventoryButton.Location = new Point(15, 170);
            seeInventoryButton.Name = "seeInventoryButton";
            seeInventoryButton.Size = new Size(151, 33);
            seeInventoryButton.TabIndex = 5;
            seeInventoryButton.Text = "See inventory";
            seeInventoryButton.UseVisualStyleBackColor = false;
            seeInventoryButton.Click += seeInventoryButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(192, 255, 192);
            deleteButton.Location = new Point(15, 209);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(151, 33);
            deleteButton.TabIndex = 4;
            deleteButton.Text = " Delete Car";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click_1;
            // 
            // sellCarButton
            // 
            sellCarButton.BackColor = Color.FromArgb(192, 255, 192);
            sellCarButton.Location = new Point(15, 131);
            sellCarButton.Name = "sellCarButton";
            sellCarButton.Size = new Size(151, 33);
            sellCarButton.TabIndex = 3;
            sellCarButton.Text = "Sell car";
            sellCarButton.UseVisualStyleBackColor = false;
            sellCarButton.Click += sellCarButton_Click;
            // 
            // addCarButton
            // 
            addCarButton.BackColor = Color.FromArgb(192, 255, 192);
            addCarButton.Location = new Point(15, 92);
            addCarButton.Name = "addCarButton";
            addCarButton.Size = new Size(151, 33);
            addCarButton.TabIndex = 0;
            addCarButton.Text = "Add car";
            addCarButton.UseVisualStyleBackColor = false;
            addCarButton.Click += addCarButton_Click;
            // 
            // appContent
            // 
            appContent.Dock = DockStyle.Fill;
            appContent.Location = new Point(181, 0);
            appContent.Name = "appContent";
            appContent.Size = new Size(903, 661);
            appContent.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1084, 661);
            Controls.Add(appContent);
            Controls.Add(buttonMeniu);
            MinimumSize = new Size(1100, 700);
            Name = "MainForm";
            Text = "Car Dealership";
            ((System.ComponentModel.ISupportInitialize)salesGridView).EndInit();
            buttonMeniu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel buttonMeniu;
        private Button seeInventoryButton;
        private Button deleteButton;
        private Button sellCarButton;
        private Button addCarButton;
        private Button updateButton;
        private Button viewAllSales;
        private Panel appContent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
