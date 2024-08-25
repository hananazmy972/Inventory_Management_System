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
            btnSearch = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)CategoryGridView).BeginInit();
            SuspendLayout();
            // 
            // CategoryGridView
            // 
            CategoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryGridView.Location = new Point(638, 192);
            CategoryGridView.Name = "CategoryGridView";
            CategoryGridView.RowHeadersWidth = 51;
            CategoryGridView.Size = new Size(389, 273);
            CategoryGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Andalus", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(398, 31);
            label1.Name = "label1";
            label1.Size = new Size(358, 52);
            label1.TabIndex = 1;
            label1.Text = "Category Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 221);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 2;
            label2.Text = "Category ID : ";
            // 
            // CategoryIDtxtBox
            // 
            CategoryIDtxtBox.Location = new Point(205, 218);
            CategoryIDtxtBox.Name = "CategoryIDtxtBox";
            CategoryIDtxtBox.ReadOnly = true;
            CategoryIDtxtBox.Size = new Size(182, 27);
            CategoryIDtxtBox.TabIndex = 3;
            CategoryIDtxtBox.TextChanged += CategoryIDtxtBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 308);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 4;
            label3.Text = "Category Name : ";
            // 
            // CategoryNametxtBox
            // 
            CategoryNametxtBox.Location = new Point(205, 301);
            CategoryNametxtBox.Name = "CategoryNametxtBox";
            CategoryNametxtBox.Size = new Size(182, 27);
            CategoryNametxtBox.TabIndex = 5;
            CategoryNametxtBox.TextChanged += CategoryNametxtBox_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(105, 418);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 47);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(248, 418);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 47);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // SearchName
            // 
            SearchName.Location = new Point(869, 146);
            SearchName.Name = "SearchName";
            SearchName.Size = new Size(131, 27);
            SearchName.TabIndex = 33;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name.Location = new Point(776, 146);
            Name.Name = "Name";
            Name.Size = new Size(77, 25);
            Name.TabIndex = 32;
            Name.Text = " Name :";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.SeaShell;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.TopLeft;
            btnSearch.Location = new Point(723, 143);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(33, 32);
            btnSearch.TabIndex = 31;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(607, 144);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 29);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "ADD ";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 538);
            Controls.Add(SearchName);
            Controls.Add(Name);
            Controls.Add(btnSearch);
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
        private Button btnSearch;
        private Button btnAdd;
    }
}