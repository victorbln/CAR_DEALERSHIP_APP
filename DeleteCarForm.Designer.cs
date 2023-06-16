namespace CarDealership
{
    partial class DeleteCarForm
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
            vinLabel = new Label();
            vinDeleteCar = new TextBox();
            title = new Label();
            deleteCar = new Button();
            cancelButtonDeleteForm = new Button();
            SuspendLayout();
            // 
            // vinLabel
            // 
            vinLabel.AutoSize = true;
            vinLabel.BackColor = Color.FromArgb(255, 224, 192);
            vinLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            vinLabel.Location = new Point(32, 101);
            vinLabel.Name = "vinLabel";
            vinLabel.Size = new Size(295, 30);
            vinLabel.TabIndex = 0;
            vinLabel.Text = "Vegicle identification number";
            vinLabel.Click += vinLabel_Click;
            // 
            // vinDeleteCar
            // 
            vinDeleteCar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            vinDeleteCar.Location = new Point(344, 101);
            vinDeleteCar.Multiline = true;
            vinDeleteCar.Name = "vinDeleteCar";
            vinDeleteCar.Size = new Size(212, 30);
            vinDeleteCar.TabIndex = 1;
            // 
            // title
            // 
            title.BackColor = Color.FromArgb(255, 255, 192);
            title.Dock = DockStyle.Top;
            title.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(0, 0);
            title.Name = "title";
            title.Size = new Size(800, 37);
            title.TabIndex = 17;
            title.Text = "Insert the VIN of the vehicle to delete";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deleteCar
            // 
            deleteCar.AutoSize = true;
            deleteCar.BackColor = Color.FromArgb(192, 255, 192);
            deleteCar.Location = new Point(32, 168);
            deleteCar.Name = "deleteCar";
            deleteCar.Size = new Size(122, 42);
            deleteCar.TabIndex = 18;
            deleteCar.Text = "Delete";
            deleteCar.UseVisualStyleBackColor = false;
            deleteCar.Click += deleteCar_Click;
            // 
            // cancelButtonDeleteForm
            // 
            cancelButtonDeleteForm.AutoSize = true;
            cancelButtonDeleteForm.BackColor = Color.FromArgb(192, 255, 192);
            cancelButtonDeleteForm.Location = new Point(205, 168);
            cancelButtonDeleteForm.Name = "cancelButtonDeleteForm";
            cancelButtonDeleteForm.Size = new Size(122, 42);
            cancelButtonDeleteForm.TabIndex = 19;
            cancelButtonDeleteForm.Text = "Cancel";
            cancelButtonDeleteForm.UseVisualStyleBackColor = false;
            // 
            // DeleteCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(deleteCar);
            Controls.Add(cancelButtonDeleteForm);
            Controls.Add(title);
            Controls.Add(vinDeleteCar);
            Controls.Add(vinLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label vinLabel;
        private TextBox vinDeleteCar;
        private Label title;
        private Button deleteCar;
        private Button cancelButtonDeleteForm;
    }
}