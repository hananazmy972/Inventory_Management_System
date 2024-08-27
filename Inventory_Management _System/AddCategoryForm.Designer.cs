namespace Inventory_Management__System
{
    partial class AddCategoryForm
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
            CategoryNametxtBox = new TextBox();
            label3 = new Label();
            CategoryIDtxtBox = new TextBox();
            label2 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // CategoryNametxtBox
            // 
            CategoryNametxtBox.Location = new Point(198, 193);
            CategoryNametxtBox.Name = "CategoryNametxtBox";
            CategoryNametxtBox.Size = new Size(182, 27);
            CategoryNametxtBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 200);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 8;
            label3.Text = "Category Name : ";
            // 
            // CategoryIDtxtBox
            // 
            CategoryIDtxtBox.Location = new Point(198, 110);
            CategoryIDtxtBox.Name = "CategoryIDtxtBox";
            CategoryIDtxtBox.ReadOnly = true;
            CategoryIDtxtBox.Size = new Size(182, 27);
            CategoryIDtxtBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 113);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 6;
            label2.Text = "Category ID : ";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.PowderBlue;
            btnSave.Location = new Point(155, 273);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(167, 36);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(464, 345);
            Controls.Add(btnSave);
            Controls.Add(CategoryNametxtBox);
            Controls.Add(label3);
            Controls.Add(CategoryIDtxtBox);
            Controls.Add(label2);
            Name = "AddCategoryForm";
            Text = "AddCategoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CategoryNametxtBox;
        private Label label3;
        private TextBox CategoryIDtxtBox;
        private Label label2;
        private Button btnSave;
    }
}