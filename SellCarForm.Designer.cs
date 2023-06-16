namespace CarDealership
{
    partial class SellCarForm
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
            title = new Label();
            yearLabel = new Label();
            priceLabel = new Label();
            customerEmailTextBox = new TextBox();
            customerPhoneTextBox = new TextBox();
            sellBCar = new Button();
            cancelButtonSellForm = new Button();
            makeLabel = new Label();
            modelLabel = new Label();
            vinTextBox = new TextBox();
            customerNameTextBox = new TextBox();
            SuspendLayout();
            // 
            // title
            // 
            title.BackColor = Color.FromArgb(255, 255, 192);
            title.Dock = DockStyle.Top;
            title.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(0, 0);
            title.Name = "title";
            title.Size = new Size(800, 37);
            title.TabIndex = 27;
            title.Text = "Insert sale details";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.BackColor = Color.FromArgb(255, 224, 192);
            yearLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            yearLabel.Location = new Point(115, 267);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(165, 30);
            yearLabel.TabIndex = 26;
            yearLabel.Text = "Customer email";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = Color.FromArgb(255, 224, 192);
            priceLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(115, 314);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(175, 30);
            priceLabel.TabIndex = 25;
            priceLabel.Text = "Customer phone";
            // 
            // customerEmailTextBox
            // 
            customerEmailTextBox.Location = new Point(341, 267);
            customerEmailTextBox.Multiline = true;
            customerEmailTextBox.Name = "customerEmailTextBox";
            customerEmailTextBox.Size = new Size(215, 30);
            customerEmailTextBox.TabIndex = 24;
            // 
            // customerPhoneTextBox
            // 
            customerPhoneTextBox.Location = new Point(341, 314);
            customerPhoneTextBox.Multiline = true;
            customerPhoneTextBox.Name = "customerPhoneTextBox";
            customerPhoneTextBox.Size = new Size(215, 30);
            customerPhoneTextBox.TabIndex = 23;
            // 
            // sellBCar
            // 
            sellBCar.AutoSize = true;
            sellBCar.BackColor = Color.FromArgb(192, 255, 192);
            sellBCar.Location = new Point(574, 169);
            sellBCar.Name = "sellBCar";
            sellBCar.Size = new Size(122, 42);
            sellBCar.TabIndex = 17;
            sellBCar.Text = "Sell";
            sellBCar.UseMnemonic = false;
            sellBCar.UseVisualStyleBackColor = false;
            sellBCar.Click += sellBCar_Click;
            // 
            // cancelButtonSellForm
            // 
            cancelButtonSellForm.AutoSize = true;
            cancelButtonSellForm.BackColor = Color.FromArgb(192, 255, 192);
            cancelButtonSellForm.Location = new Point(574, 302);
            cancelButtonSellForm.Name = "cancelButtonSellForm";
            cancelButtonSellForm.Size = new Size(122, 42);
            cancelButtonSellForm.TabIndex = 18;
            cancelButtonSellForm.Text = "Cancel";
            cancelButtonSellForm.UseVisualStyleBackColor = false;
            cancelButtonSellForm.Click += cancelButtonSellForm_Click;
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.BackColor = Color.FromArgb(255, 224, 192);
            makeLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            makeLabel.Location = new Point(115, 169);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new Size(157, 30);
            makeLabel.TabIndex = 19;
            makeLabel.Text = "Car to sale VIN";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.BackColor = Color.FromArgb(255, 224, 192);
            modelLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            modelLabel.Location = new Point(115, 218);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(167, 30);
            modelLabel.TabIndex = 20;
            modelLabel.Text = "Customer name";
            modelLabel.Click += modelLabel_Click;
            // 
            // vinTextBox
            // 
            vinTextBox.Location = new Point(341, 169);
            vinTextBox.Multiline = true;
            vinTextBox.Name = "vinTextBox";
            vinTextBox.Size = new Size(215, 30);
            vinTextBox.TabIndex = 21;
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Location = new Point(341, 218);
            customerNameTextBox.Multiline = true;
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.Size = new Size(215, 30);
            customerNameTextBox.TabIndex = 22;
            // 
            // SellCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(title);
            Controls.Add(yearLabel);
            Controls.Add(priceLabel);
            Controls.Add(customerEmailTextBox);
            Controls.Add(customerPhoneTextBox);
            Controls.Add(sellBCar);
            Controls.Add(cancelButtonSellForm);
            Controls.Add(makeLabel);
            Controls.Add(modelLabel);
            Controls.Add(vinTextBox);
            Controls.Add(customerNameTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SellCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label yearLabel;
        private Label priceLabel;
        private TextBox customerEmailTextBox;
        private TextBox customerPhoneTextBox;
        private Button sellBCar;
        private Button cancelButtonSellForm;
        private Label makeLabel;
        private Label modelLabel;
        private TextBox vinTextBox;
        private TextBox customerNameTextBox;
    }
}