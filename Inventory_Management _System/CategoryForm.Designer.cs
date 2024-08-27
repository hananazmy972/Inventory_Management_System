namespace Inventory_Management__System
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            CategoryGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            CategoryIDtxtBox = new TextBox();
            label3 = new Label();
            CategoryNametxtBox = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            SearchName = new TextBox();
            Name = new Label();
            btnAdd = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CategoryGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // CategoryGridView
            // 
            CategoryGridView.BackgroundColor = SystemColors.ButtonHighlight;
            CategoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryGridView.Location = new Point(661, 169);
            CategoryGridView.Name = "CategoryGridView";
            CategoryGridView.RowHeadersWidth = 51;
            CategoryGridView.Size = new Size(293, 266);
            CategoryGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCyan;
            label1.Font = new Font("Elephant", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(353, 28);
            label1.Name = "label1";
            label1.Size = new Size(398, 43);
            label1.TabIndex = 1;
            label1.Text = "Category Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(132, 214);
            label2.Name = "label2";
            label2.Size = new Size(140, 31);
            label2.TabIndex = 2;
            label2.Text = "Category ID : ";
            // 
            // CategoryIDtxtBox
            // 
            CategoryIDtxtBox.Location = new Point(294, 216);
            CategoryIDtxtBox.Name = "CategoryIDtxtBox";
            CategoryIDtxtBox.ReadOnly = true;
            CategoryIDtxtBox.Size = new Size(182, 27);
            CategoryIDtxtBox.TabIndex = 3;
            CategoryIDtxtBox.TextChanged += CategoryIDtxtBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Andalus", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(119, 299);
            label3.Name = "label3";
            label3.Size = new Size(170, 31);
            label3.TabIndex = 4;
            label3.Text = "Category Name : ";
            // 
            // CategoryNametxtBox
            // 
            CategoryNametxtBox.Location = new Point(295, 299);
            CategoryNametxtBox.Name = "CategoryNametxtBox";
            CategoryNametxtBox.Size = new Size(182, 27);
            CategoryNametxtBox.TabIndex = 5;
            CategoryNametxtBox.TextChanged += CategoryNametxtBox_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.PowderBlue;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Crimson;
            btnDelete.Location = new Point(401, 388);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 47);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.PowderBlue;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.MidnightBlue;
            btnUpdate.Location = new Point(248, 388);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 47);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // SearchName
            // 
            SearchName.Location = new Point(785, 123);
            SearchName.Name = "SearchName";
            SearchName.Size = new Size(131, 27);
            SearchName.TabIndex = 33;
            SearchName.TextChanged += SearchName_TextChanged;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.BackColor = Color.Transparent;
            Name.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name.ForeColor = Color.MidnightBlue;
            Name.ImageAlign = ContentAlignment.TopLeft;
            Name.Location = new Point(702, 125);
            Name.Name = "Name";
            Name.Size = new Size(77, 25);
            Name.TabIndex = 32;
            Name.Text = " Name :";
            Name.TextAlign = ContentAlignment.TopRight;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.PowderBlue;
            btnAdd.Font = new Font("Andalus", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.MidnightBlue;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(143, 116);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 58);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "Add";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 62);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(675, 123);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 34);
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1156, 536);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(SearchName);
            Controls.Add(Name);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(CategoryNametxtBox);
            Controls.Add(label3);
            Controls.Add(CategoryIDtxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CategoryGridView);
            Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)CategoryGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CategoryGridView;
        private Label label1;
        private Label label2;
        private TextBox CategoryIDtxtBox;
        private Label label3;
        private TextBox CategoryNametxtBox;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox SearchName;
        private Label Name;
        private Button btnAdd;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}