namespace Inventory_Management__System
{
    partial class TransactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            label1 = new Label();
            TransactionGridView = new DataGridView();
            BackHomePictureBox = new PictureBox();
            btnSale = new Button();
            btnPurchase = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)TransactionGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackHomePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCyan;
            label1.Font = new Font("Elephant", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(319, 30);
            label1.Name = "label1";
            label1.Size = new Size(242, 43);
            label1.TabIndex = 3;
            label1.Text = "Transactions";
            // 
            // TransactionGridView
            // 
            TransactionGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TransactionGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TransactionGridView.BackgroundColor = SystemColors.ButtonFace;
            TransactionGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransactionGridView.Location = new Point(86, 121);
            TransactionGridView.Name = "TransactionGridView";
            TransactionGridView.RowHeadersWidth = 51;
            TransactionGridView.Size = new Size(766, 227);
            TransactionGridView.TabIndex = 4;
            // 
            // BackHomePictureBox
            // 
            BackHomePictureBox.Image = (Image)resources.GetObject("BackHomePictureBox.Image");
            BackHomePictureBox.Location = new Point(28, 11);
            BackHomePictureBox.Name = "BackHomePictureBox";
            BackHomePictureBox.Size = new Size(62, 62);
            BackHomePictureBox.TabIndex = 47;
            BackHomePictureBox.TabStop = false;
            BackHomePictureBox.Click += BackHomePictureBox_Click;
            // 
            // btnSale
            // 
            btnSale.BackColor = Color.PowderBlue;
            btnSale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSale.ForeColor = Color.MidnightBlue;
            btnSale.Location = new Point(288, 373);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(115, 55);
            btnSale.TabIndex = 48;
            btnSale.Text = "Sale";
            btnSale.UseVisualStyleBackColor = false;
            btnSale.Click += btnSale_Click;
            // 
            // btnPurchase
            // 
            btnPurchase.BackColor = Color.PowderBlue;
            btnPurchase.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPurchase.ForeColor = Color.MidnightBlue;
            btnPurchase.Location = new Point(505, 373);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(115, 55);
            btnPurchase.TabIndex = 49;
            btnPurchase.Text = "Purchase";
            btnPurchase.UseVisualStyleBackColor = false;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(240, 373);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 60);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(968, 489);
            Controls.Add(pictureBox1);
            Controls.Add(btnPurchase);
            Controls.Add(btnSale);
            Controls.Add(BackHomePictureBox);
            Controls.Add(TransactionGridView);
            Controls.Add(label1);
            Name = "TransactionForm";
            Text = "TransactionForm";
            ((System.ComponentModel.ISupportInitialize)TransactionGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackHomePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView TransactionGridView;
        private PictureBox BackHomePictureBox;
        private Button btnSale;
        private Button btnPurchase;
        private PictureBox pictureBox1;
    }
}