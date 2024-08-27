namespace Inventory_Management__System
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            BackHomePictureBox = new PictureBox();
            SearchName = new TextBox();
            Name = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ProductNametxtBox = new TextBox();
            label3 = new Label();
            ProductIDtxtBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ProductGridView = new DataGridView();
            label4 = new Label();
            PriceUpDownBox = new NumericUpDown();
            label5 = new Label();
            CategoryComboBox = new ComboBox();
            DescriptionTextBox = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BackHomePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceUpDownBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BackHomePictureBox
            // 
            BackHomePictureBox.Image = (Image)resources.GetObject("BackHomePictureBox.Image");
            BackHomePictureBox.Location = new Point(23, 12);
            BackHomePictureBox.Name = "BackHomePictureBox";
            BackHomePictureBox.Size = new Size(62, 62);
            BackHomePictureBox.TabIndex = 46;
            BackHomePictureBox.TabStop = false;
            BackHomePictureBox.Click += BackHomePictureBox_Click;
            // 
            // SearchName
            // 
            SearchName.Location = new Point(723, 113);
            SearchName.Name = "SearchName";
            SearchName.Size = new Size(131, 27);
            SearchName.TabIndex = 45;
            SearchName.TextChanged += SearchName_TextChanged;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name.ForeColor = Color.MidnightBlue;
            Name.Location = new Point(640, 115);
            Name.Name = "Name";
            Name.Size = new Size(77, 25);
            Name.TabIndex = 44;
            Name.Text = " Name :";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.PowderBlue;
            btnAdd.Font = new Font("Andalus", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.MidnightBlue;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(1004, 82);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 58);
            btnAdd.TabIndex = 43;
            btnAdd.Text = "Add";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.PowderBlue;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.MidnightBlue;
            btnUpdate.Location = new Point(188, 556);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 47);
            btnUpdate.TabIndex = 42;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.PowderBlue;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Crimson;
            btnDelete.Location = new Point(327, 556);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 47);
            btnDelete.TabIndex = 41;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // ProductNametxtBox
            // 
            ProductNametxtBox.Location = new Point(251, 224);
            ProductNametxtBox.Name = "ProductNametxtBox";
            ProductNametxtBox.Size = new Size(182, 27);
            ProductNametxtBox.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(95, 220);
            label3.Name = "label3";
            label3.Size = new Size(160, 31);
            label3.TabIndex = 39;
            label3.Text = "Product Name : ";
            // 
            // ProductIDtxtBox
            // 
            ProductIDtxtBox.Location = new Point(251, 152);
            ProductIDtxtBox.Name = "ProductIDtxtBox";
            ProductIDtxtBox.ReadOnly = true;
            ProductIDtxtBox.Size = new Size(182, 27);
            ProductIDtxtBox.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(95, 152);
            label2.Name = "label2";
            label2.Size = new Size(130, 31);
            label2.TabIndex = 37;
            label2.Text = "Product ID : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCyan;
            label1.Font = new Font("Elephant", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(372, 31);
            label1.Name = "label1";
            label1.Size = new Size(387, 43);
            label1.TabIndex = 36;
            label1.Text = "Product Management";
            // 
            // ProductGridView
            // 
            ProductGridView.BackgroundColor = SystemColors.ButtonHighlight;
            ProductGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGridView.Location = new Point(604, 152);
            ProductGridView.Name = "ProductGridView";
            ProductGridView.RowHeadersWidth = 51;
            ProductGridView.Size = new Size(515, 359);
            ProductGridView.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(95, 285);
            label4.Name = "label4";
            label4.Size = new Size(144, 31);
            label4.TabIndex = 47;
            label4.Text = "Selling Price : ";
            // 
            // PriceUpDownBox
            // 
            PriceUpDownBox.Location = new Point(251, 285);
            PriceUpDownBox.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            PriceUpDownBox.Name = "PriceUpDownBox";
            PriceUpDownBox.Size = new Size(182, 27);
            PriceUpDownBox.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(95, 349);
            label5.Name = "label5";
            label5.Size = new Size(112, 31);
            label5.TabIndex = 49;
            label5.Text = "Category : ";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(251, 349);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(182, 28);
            CategoryComboBox.TabIndex = 50;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(251, 417);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(244, 88);
            DescriptionTextBox.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(95, 413);
            label6.Name = "label6";
            label6.Size = new Size(131, 31);
            label6.TabIndex = 52;
            label6.Text = "Description :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(604, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 28);
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1156, 637);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(DescriptionTextBox);
            Controls.Add(CategoryComboBox);
            Controls.Add(label5);
            Controls.Add(PriceUpDownBox);
            Controls.Add(label4);
            Controls.Add(BackHomePictureBox);
            Controls.Add(SearchName);
            Controls.Add(Name);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(ProductNametxtBox);
            Controls.Add(label3);
            Controls.Add(ProductIDtxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ProductGridView);
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)BackHomePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceUpDownBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BackHomePictureBox;
        private TextBox SearchName;
        private Label Name;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox ProductNametxtBox;
        private Label label3;
        private TextBox ProductIDtxtBox;
        private Label label2;
        private Label label1;
        private DataGridView ProductGridView;
        private Label label4;
        private NumericUpDown PriceUpDownBox;
        private Label label5;
        private ComboBox CategoryComboBox;
        private TextBox DescriptionTextBox;
        private Label label6;
        private PictureBox pictureBox1;
    }
}