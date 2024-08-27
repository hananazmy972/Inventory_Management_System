namespace Inventory_Management__System
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            StockGridView = new DataGridView();
            label1 = new Label();
            CategoryComboBox = new ComboBox();
            label2 = new Label();
            btnRefresh = new Button();
            btnSort = new Button();
            btnLowStock = new Button();
            BackHomePictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)StockGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackHomePictureBox).BeginInit();
            SuspendLayout();
            // 
            // StockGridView
            // 
            StockGridView.BackgroundColor = SystemColors.ButtonFace;
            StockGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StockGridView.Location = new Point(141, 190);
            StockGridView.Name = "StockGridView";
            StockGridView.RowHeadersWidth = 51;
            StockGridView.Size = new Size(553, 285);
            StockGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCyan;
            label1.Font = new Font("Elephant", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(263, 40);
            label1.Name = "label1";
            label1.Size = new Size(301, 43);
            label1.TabIndex = 2;
            label1.Text = "Inventory Status";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(231, 146);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(151, 28);
            CategoryComboBox.TabIndex = 3;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(141, 147);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 4;
            label2.Text = "Category";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.PowderBlue;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.MidnightBlue;
            btnRefresh.Location = new Point(433, 140);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(116, 39);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.PowderBlue;
            btnSort.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSort.ForeColor = Color.MidnightBlue;
            btnSort.Location = new Point(177, 498);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(118, 42);
            btnSort.TabIndex = 6;
            btnSort.Text = "Sort Desc";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // btnLowStock
            // 
            btnLowStock.BackColor = Color.PowderBlue;
            btnLowStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLowStock.ForeColor = Color.Red;
            btnLowStock.Location = new Point(344, 498);
            btnLowStock.Name = "btnLowStock";
            btnLowStock.Size = new Size(205, 42);
            btnLowStock.TabIndex = 7;
            btnLowStock.Text = "View Low Stock";
            btnLowStock.UseVisualStyleBackColor = false;
            btnLowStock.Click += btnLowStock_Click;
            // 
            // BackHomePictureBox
            // 
            BackHomePictureBox.Image = (Image)resources.GetObject("BackHomePictureBox.Image");
            BackHomePictureBox.Location = new Point(24, 12);
            BackHomePictureBox.Name = "BackHomePictureBox";
            BackHomePictureBox.Size = new Size(62, 62);
            BackHomePictureBox.TabIndex = 47;
            BackHomePictureBox.TabStop = false;
            BackHomePictureBox.Click += BackHomePictureBox_Click;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(860, 605);
            Controls.Add(BackHomePictureBox);
            Controls.Add(btnLowStock);
            Controls.Add(btnSort);
            Controls.Add(btnRefresh);
            Controls.Add(label2);
            Controls.Add(CategoryComboBox);
            Controls.Add(label1);
            Controls.Add(StockGridView);
            Name = "InventoryForm";
            Text = "InventoryForm";
            ((System.ComponentModel.ISupportInitialize)StockGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackHomePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView StockGridView;
        private Label label1;
        private ComboBox CategoryComboBox;
        private Label label2;
        private Button btnRefresh;
        private Button btnSort;
        private Button btnLowStock;
        private PictureBox BackHomePictureBox;
    }
}