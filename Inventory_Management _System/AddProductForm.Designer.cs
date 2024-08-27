namespace Inventory_Management__System
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            label6 = new Label();
            DescriptionTextBox = new TextBox();
            CategoryComboBox = new ComboBox();
            label5 = new Label();
            PriceUpDownBox = new NumericUpDown();
            label4 = new Label();
            ProductNametxtBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)PriceUpDownBox).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(199, 400);
            label6.Name = "label6";
            label6.Size = new Size(131, 31);
            label6.TabIndex = 62;
            label6.Text = "Description :";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(359, 413);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(244, 88);
            DescriptionTextBox.TabIndex = 61;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(388, 324);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(182, 28);
            CategoryComboBox.TabIndex = 60;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(200, 320);
            label5.Name = "label5";
            label5.Size = new Size(112, 31);
            label5.TabIndex = 59;
            label5.Text = "Category : ";
            // 
            // PriceUpDownBox
            // 
            PriceUpDownBox.Location = new Point(388, 246);
            PriceUpDownBox.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            PriceUpDownBox.Name = "PriceUpDownBox";
            PriceUpDownBox.Size = new Size(182, 27);
            PriceUpDownBox.TabIndex = 58;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(200, 241);
            label4.Name = "label4";
            label4.Size = new Size(144, 31);
            label4.TabIndex = 57;
            label4.Text = "Selling Price : ";
            // 
            // ProductNametxtBox
            // 
            ProductNametxtBox.Location = new Point(388, 174);
            ProductNametxtBox.Name = "ProductNametxtBox";
            ProductNametxtBox.Size = new Size(182, 27);
            ProductNametxtBox.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(199, 170);
            label3.Name = "label3";
            label3.Size = new Size(160, 31);
            label3.TabIndex = 55;
            label3.Text = "Product Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Elephant", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(296, 39);
            label1.Name = "label1";
            label1.Size = new Size(233, 43);
            label1.TabIndex = 63;
            label1.Text = "Add Product";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            btnSave.Font = new Font("Andalus", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.MidnightBlue;
            btnSave.Location = new Point(275, 555);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(216, 47);
            btnSave.TabIndex = 64;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 651);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(DescriptionTextBox);
            Controls.Add(CategoryComboBox);
            Controls.Add(label5);
            Controls.Add(PriceUpDownBox);
            Controls.Add(label4);
            Controls.Add(ProductNametxtBox);
            Controls.Add(label3);
            Name = "AddProductForm";
            Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)PriceUpDownBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox DescriptionTextBox;
        private ComboBox CategoryComboBox;
        private Label label5;
        private NumericUpDown PriceUpDownBox;
        private Label label4;
        private TextBox ProductNametxtBox;
        private Label label3;
        private Label label1;
        private Button btnSave;
    }
}