namespace Inventory_Management__System
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            CategoryIcon = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)CategoryIcon).BeginInit();
            SuspendLayout();
            // 
            // CategoryIcon
            // 
            CategoryIcon.BackColor = Color.Transparent;
            CategoryIcon.Image = (Image)resources.GetObject("CategoryIcon.Image");
            CategoryIcon.Location = new Point(76, 62);
            CategoryIcon.Name = "CategoryIcon";
            CategoryIcon.Size = new Size(148, 155);
            CategoryIcon.TabIndex = 0;
            CategoryIcon.TabStop = false;
            CategoryIcon.Click += CategoryIcon_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Andalus", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(76, 231);
            label1.Name = "label1";
            label1.Size = new Size(148, 36);
            label1.TabIndex = 1;
            label1.Text = "Categories";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1212, 538);
            Controls.Add(label1);
            Controls.Add(CategoryIcon);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)CategoryIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox CategoryIcon;
        private Label label1;
    }
}
