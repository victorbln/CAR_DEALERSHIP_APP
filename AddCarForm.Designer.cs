namespace CarDealership
{
    partial class AddCarForm
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
            addBCar = new Button();
            cancelButtonAddForm = new Button();
            makeLabel = new Label();
            modelLabel = new Label();
            makeTextBox = new TextBox();
            modelTextBox = new TextBox();
            colorTextBox = new TextBox();
            priceTextBox = new TextBox();
            yearTextBox = new TextBox();
            colorLabel = new Label();
            priceLabel = new Label();
            yearLabel = new Label();
            vinTextBox = new TextBox();
            mileageTextBox = new TextBox();
            vinLabel = new Label();
            mileageLabel = new Label();
            title = new Label();
            SuspendLayout();
            // 
            // addBCar
            // 
            addBCar.AutoSize = true;
            addBCar.BackColor = Color.FromArgb(192, 255, 192);
            addBCar.Location = new Point(431, 63);
            addBCar.Name = "addBCar";
            addBCar.Size = new Size(122, 42);
            addBCar.TabIndex = 0;
            addBCar.Text = "Add";
            addBCar.UseVisualStyleBackColor = false;
            addBCar.Click += AddButton_Click;
            // 
            // cancelButtonAddForm
            // 
            cancelButtonAddForm.AutoSize = true;
            cancelButtonAddForm.BackColor = Color.FromArgb(192, 255, 192);
            cancelButtonAddForm.Location = new Point(431, 112);
            cancelButtonAddForm.Name = "cancelButtonAddForm";
            cancelButtonAddForm.Size = new Size(122, 42);
            cancelButtonAddForm.TabIndex = 1;
            cancelButtonAddForm.Text = "Cancel";
            cancelButtonAddForm.UseVisualStyleBackColor = false;
            cancelButtonAddForm.Click += CancelButton_Click;
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.BackColor = Color.FromArgb(255, 224, 192);
            makeLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            makeLabel.Location = new Point(115, 63);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new Size(67, 30);
            makeLabel.TabIndex = 2;
            makeLabel.Text = "Make";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.BackColor = Color.FromArgb(255, 224, 192);
            modelLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            modelLabel.Location = new Point(115, 112);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(76, 30);
            modelLabel.TabIndex = 3;
            modelLabel.Text = "Model";
            modelLabel.Click += modelLabel_Click;
            // 
            // makeTextBox
            // 
            makeTextBox.Location = new Point(237, 63);
            makeTextBox.Multiline = true;
            makeTextBox.Name = "makeTextBox";
            makeTextBox.Size = new Size(157, 30);
            makeTextBox.TabIndex = 4;
            makeTextBox.TextChanged += makeTextBox_TextChanged;
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(237, 112);
            modelTextBox.Multiline = true;
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(157, 30);
            modelTextBox.TabIndex = 5;
            // 
            // colorTextBox
            // 
            colorTextBox.Location = new Point(237, 253);
            colorTextBox.Multiline = true;
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(157, 30);
            colorTextBox.TabIndex = 6;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(237, 208);
            priceTextBox.Multiline = true;
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(157, 30);
            priceTextBox.TabIndex = 7;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(237, 161);
            yearTextBox.Multiline = true;
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(157, 30);
            yearTextBox.TabIndex = 8;
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.BackColor = Color.FromArgb(255, 224, 192);
            colorLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            colorLabel.Location = new Point(115, 253);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(66, 30);
            colorLabel.TabIndex = 9;
            colorLabel.Text = "Color";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = Color.FromArgb(255, 224, 192);
            priceLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(115, 208);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(60, 30);
            priceLabel.TabIndex = 10;
            priceLabel.Text = "Price";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.BackColor = Color.FromArgb(255, 224, 192);
            yearLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            yearLabel.Location = new Point(115, 161);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(54, 30);
            yearLabel.TabIndex = 11;
            yearLabel.Text = "Year";
            // 
            // vinTextBox
            // 
            vinTextBox.Location = new Point(237, 346);
            vinTextBox.Multiline = true;
            vinTextBox.Name = "vinTextBox";
            vinTextBox.Size = new Size(157, 30);
            vinTextBox.TabIndex = 12;
            vinTextBox.TextChanged += vinTextBox_TextChanged;
            // 
            // mileageTextBox
            // 
            mileageTextBox.Location = new Point(237, 300);
            mileageTextBox.Multiline = true;
            mileageTextBox.Name = "mileageTextBox";
            mileageTextBox.Size = new Size(157, 30);
            mileageTextBox.TabIndex = 13;
            // 
            // vinLabel
            // 
            vinLabel.AutoSize = true;
            vinLabel.BackColor = Color.FromArgb(255, 224, 192);
            vinLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            vinLabel.Location = new Point(115, 346);
            vinLabel.Name = "vinLabel";
            vinLabel.Size = new Size(49, 30);
            vinLabel.TabIndex = 14;
            vinLabel.Text = "VIN";
            // 
            // mileageLabel
            // 
            mileageLabel.AutoSize = true;
            mileageLabel.BackColor = Color.FromArgb(255, 224, 192);
            mileageLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            mileageLabel.Location = new Point(115, 300);
            mileageLabel.Name = "mileageLabel";
            mileageLabel.Size = new Size(91, 30);
            mileageLabel.TabIndex = 15;
            mileageLabel.Text = "Mileage";
            // 
            // title
            // 
            title.BackColor = Color.FromArgb(255, 255, 192);
            title.Dock = DockStyle.Top;
            title.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(0, 0);
            title.Name = "title";
            title.Size = new Size(792, 37);
            title.TabIndex = 16;
            title.Text = "Insert car details";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(792, 447);
            ControlBox = false;
            Controls.Add(title);
            Controls.Add(mileageLabel);
            Controls.Add(vinLabel);
            Controls.Add(mileageTextBox);
            Controls.Add(vinTextBox);
            Controls.Add(yearLabel);
            Controls.Add(priceLabel);
            Controls.Add(colorLabel);
            Controls.Add(yearTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(colorTextBox);
            Controls.Add(addBCar);
            Controls.Add(cancelButtonAddForm);
            Controls.Add(makeLabel);
            Controls.Add(modelLabel);
            Controls.Add(makeTextBox);
            Controls.Add(modelTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox colorTextBox;
        private TextBox priceTextBox;
        private TextBox yearTextBox;
        private Label colorLabel;
        private Label priceLabel;
        private Label yearLabel;
        private TextBox vinTextBox;
        private TextBox mileageTextBox;
        private Label vinLabel;
        private Label mileageLabel;
        private Label title;
    }
}
