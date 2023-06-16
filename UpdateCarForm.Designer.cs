namespace CarDealership
{
    partial class UpdateCarForm
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
            mileageLabel = new Label();
            mileageTextBox = new TextBox();
            updateButton = new Button();
            cancelButtonUpdateForm = new Button();
            makeTextBox = new TextBox();
            makeLabel = new Label();
            modelTextBox = new TextBox();
            modelLabel = new Label();
            priceTextBox = new TextBox();
            priceLabel = new Label();
            vinTextBox = new TextBox();
            vinLabel = new Label();
            yearTextBox = new TextBox();
            yearLabel = new Label();
            colorTextBox = new TextBox();
            colorLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // mileageLabel
            // 
            mileageLabel.BackColor = Color.FromArgb(255, 224, 192);
            mileageLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            mileageLabel.Location = new Point(39, 337);
            mileageLabel.Name = "mileageLabel";
            mileageLabel.Size = new Size(113, 35);
            mileageLabel.TabIndex = 31;
            mileageLabel.Text = "Mileage:";
            // 
            // mileageTextBox
            // 
            mileageTextBox.Location = new Point(164, 335);
            mileageTextBox.Multiline = true;
            mileageTextBox.Name = "mileageTextBox";
            mileageTextBox.Size = new Size(200, 37);
            mileageTextBox.TabIndex = 30;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(192, 255, 192);
            updateButton.Location = new Point(391, 113);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(124, 35);
            updateButton.TabIndex = 16;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // cancelButtonUpdateForm
            // 
            cancelButtonUpdateForm.BackColor = Color.FromArgb(192, 255, 192);
            cancelButtonUpdateForm.Location = new Point(391, 163);
            cancelButtonUpdateForm.Name = "cancelButtonUpdateForm";
            cancelButtonUpdateForm.Size = new Size(124, 35);
            cancelButtonUpdateForm.TabIndex = 17;
            cancelButtonUpdateForm.Text = "Cancel";
            cancelButtonUpdateForm.UseVisualStyleBackColor = false;
            cancelButtonUpdateForm.Click += cancelButtonUpdateForm_Click;
            // 
            // makeTextBox
            // 
            makeTextBox.Location = new Point(164, 113);
            makeTextBox.Multiline = true;
            makeTextBox.Name = "makeTextBox";
            makeTextBox.Size = new Size(200, 35);
            makeTextBox.TabIndex = 18;
            // 
            // makeLabel
            // 
            makeLabel.BackColor = Color.FromArgb(255, 224, 192);
            makeLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            makeLabel.Location = new Point(39, 113);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new Size(113, 35);
            makeLabel.TabIndex = 19;
            makeLabel.Text = "Make: ";
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(164, 161);
            modelTextBox.Multiline = true;
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(200, 34);
            modelTextBox.TabIndex = 20;
            // 
            // modelLabel
            // 
            modelLabel.BackColor = Color.FromArgb(255, 224, 192);
            modelLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            modelLabel.Location = new Point(39, 161);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(113, 34);
            modelLabel.TabIndex = 21;
            modelLabel.Text = "Model: ";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(164, 294);
            priceTextBox.Multiline = true;
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(200, 35);
            priceTextBox.TabIndex = 22;
            // 
            // priceLabel
            // 
            priceLabel.BackColor = Color.FromArgb(255, 224, 192);
            priceLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(39, 294);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(113, 35);
            priceLabel.TabIndex = 23;
            priceLabel.Text = "Price: ";
            // 
            // vinTextBox
            // 
            vinTextBox.Location = new Point(287, 18);
            vinTextBox.Multiline = true;
            vinTextBox.Name = "vinTextBox";
            vinTextBox.Size = new Size(200, 37);
            vinTextBox.TabIndex = 24;
            // 
            // vinLabel
            // 
            vinLabel.BackColor = Color.FromArgb(255, 224, 192);
            vinLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            vinLabel.Location = new Point(38, 18);
            vinLabel.Name = "vinLabel";
            vinLabel.Size = new Size(220, 35);
            vinLabel.TabIndex = 25;
            vinLabel.Text = "VIN of car to update:";
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(164, 205);
            yearTextBox.Multiline = true;
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(200, 35);
            yearTextBox.TabIndex = 26;
            // 
            // yearLabel
            // 
            yearLabel.BackColor = Color.FromArgb(255, 224, 192);
            yearLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            yearLabel.Location = new Point(39, 205);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(113, 35);
            yearLabel.TabIndex = 27;
            yearLabel.Text = "Year: ";
            // 
            // colorTextBox
            // 
            colorTextBox.Location = new Point(164, 251);
            colorTextBox.Multiline = true;
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(200, 35);
            colorTextBox.TabIndex = 28;
            // 
            // colorLabel
            // 
            colorLabel.BackColor = Color.FromArgb(255, 224, 192);
            colorLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            colorLabel.Location = new Point(39, 251);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(113, 35);
            colorLabel.TabIndex = 29;
            colorLabel.Text = "Color";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 71);
            label1.Name = "label1";
            label1.Size = new Size(160, 30);
            label1.TabIndex = 32;
            label1.Text = "New car details";
            // 
            // UpdateCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(mileageLabel);
            Controls.Add(mileageTextBox);
            Controls.Add(updateButton);
            Controls.Add(cancelButtonUpdateForm);
            Controls.Add(makeTextBox);
            Controls.Add(makeLabel);
            Controls.Add(modelTextBox);
            Controls.Add(modelLabel);
            Controls.Add(priceTextBox);
            Controls.Add(priceLabel);
            Controls.Add(vinTextBox);
            Controls.Add(vinLabel);
            Controls.Add(yearTextBox);
            Controls.Add(yearLabel);
            Controls.Add(colorTextBox);
            Controls.Add(colorLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateCarForm";
            Text = "UpdateCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mileageLabel;
        private TextBox mileageTextBox;
        private Button updateButton;
        private Button cancelButtonUpdateForm;
        private TextBox makeTextBox;
        private Label makeLabel;
        private TextBox modelTextBox;
        private Label modelLabel;
        private TextBox priceTextBox;
        private Label priceLabel;
        private TextBox vinTextBox;
        private Label vinLabel;
        private TextBox yearTextBox;
        private Label yearLabel;
        private TextBox colorTextBox;
        private Label colorLabel;
        private Label label1;
    }
}