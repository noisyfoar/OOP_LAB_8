namespace OOP_LAB_4
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxTriangle = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button_setColor = new System.Windows.Forms.Button();
            this.pictureBox_color = new System.Windows.Forms.PictureBox();
            this.button_group = new System.Windows.Forms.Button();
            this.button_ungroup = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.treeView = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_color)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.shapesToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1582, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // shapesToolStripMenuItem
            // 
            this.shapesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxCircle,
            this.toolStripTextBoxRectangle,
            this.toolStripTextBoxTriangle});
            this.shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            this.shapesToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.shapesToolStripMenuItem.Text = "Shape";
            // 
            // toolStripTextBoxCircle
            // 
            this.toolStripTextBoxCircle.Name = "toolStripTextBoxCircle";
            this.toolStripTextBoxCircle.Size = new System.Drawing.Size(158, 26);
            this.toolStripTextBoxCircle.Text = "Circle";
            this.toolStripTextBoxCircle.Click += new System.EventHandler(this.toolStripTextBoxCircle_Click);
            // 
            // toolStripTextBoxRectangle
            // 
            this.toolStripTextBoxRectangle.Name = "toolStripTextBoxRectangle";
            this.toolStripTextBoxRectangle.Size = new System.Drawing.Size(158, 26);
            this.toolStripTextBoxRectangle.Text = "Rectangle";
            this.toolStripTextBoxRectangle.Click += new System.EventHandler(this.toolStripTextBoxRectangle_Click);
            // 
            // toolStripTextBoxTriangle
            // 
            this.toolStripTextBoxTriangle.Name = "toolStripTextBoxTriangle";
            this.toolStripTextBoxTriangle.Size = new System.Drawing.Size(158, 26);
            this.toolStripTextBoxTriangle.Text = "Triangle";
            this.toolStripTextBoxTriangle.Click += new System.EventHandler(this.toolStripTextBoxTriangle_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // button_setColor
            // 
            this.button_setColor.Location = new System.Drawing.Point(14, 36);
            this.button_setColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_setColor.Name = "button_setColor";
            this.button_setColor.Size = new System.Drawing.Size(192, 31);
            this.button_setColor.TabIndex = 2;
            this.button_setColor.Text = "Set color to selected shapes";
            this.button_setColor.UseVisualStyleBackColor = true;
            this.button_setColor.Click += new System.EventHandler(this.button_setColor_Click);
            // 
            // pictureBox_color
            // 
            this.pictureBox_color.Location = new System.Drawing.Point(213, 36);
            this.pictureBox_color.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_color.Name = "pictureBox_color";
            this.pictureBox_color.Size = new System.Drawing.Size(25, 31);
            this.pictureBox_color.TabIndex = 3;
            this.pictureBox_color.TabStop = false;
            this.pictureBox_color.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_color_Paint);
            // 
            // button_group
            // 
            this.button_group.Location = new System.Drawing.Point(245, 36);
            this.button_group.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_group.Name = "button_group";
            this.button_group.Size = new System.Drawing.Size(185, 31);
            this.button_group.TabIndex = 4;
            this.button_group.Text = "Group up selected shapes";
            this.button_group.UseVisualStyleBackColor = true;
            this.button_group.Click += new System.EventHandler(this.button_group_Click);
            // 
            // button_ungroup
            // 
            this.button_ungroup.Location = new System.Drawing.Point(437, 36);
            this.button_ungroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ungroup.Name = "button_ungroup";
            this.button_ungroup.Size = new System.Drawing.Size(185, 31);
            this.button_ungroup.TabIndex = 5;
            this.button_ungroup.Text = "Ungroup selected shapes";
            this.button_ungroup.UseVisualStyleBackColor = true;
            this.button_ungroup.Click += new System.EventHandler(this.button_ungroup_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 778);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // treeView
            // 
            this.treeView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.treeView.Location = new System.Drawing.Point(1319, 75);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(251, 766);
            this.treeView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.button_setColor);
            this.Controls.Add(this.button_ungroup);
            this.Controls.Add(this.button_group);
            this.Controls.Add(this.pictureBox_color);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_color)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem shapesToolStripMenuItem;
        private ToolStripMenuItem toolStripTextBoxCircle;
        private ToolStripMenuItem toolStripTextBoxRectangle;
        private ToolStripMenuItem toolStripTextBoxTriangle;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ColorDialog colorDialog1;
        private Button button_setColor;
        private PictureBox pictureBox_color;
        private Button button_group;
        private Button button_ungroup;
        private Panel panel1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private TreeView treeView;
    }
}