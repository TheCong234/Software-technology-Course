namespace Buoi1
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bàiTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bàiTậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bàiTậpToolStripMenuItem
            // 
            this.bàiTậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bai1,
            this.bai2});
            this.bàiTậpToolStripMenuItem.Name = "bàiTậpToolStripMenuItem";
            this.bàiTậpToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.bàiTậpToolStripMenuItem.Text = "Bài Tập";
            // 
            // bai1
            // 
            this.bai1.Name = "bai1";
            this.bai1.Size = new System.Drawing.Size(224, 26);
            this.bai1.Text = "Bài 1";
            this.bai1.Click += new System.EventHandler(this.bai1_Click);
            // 
            // bai2
            // 
            this.bai2.Name = "bai2";
            this.bai2.Size = new System.Drawing.Size(224, 26);
            this.bai2.Text = "Bài 2";
            this.bai2.Click += new System.EventHandler(this.bai2_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Main Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bàiTậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bai1;
        private System.Windows.Forms.ToolStripMenuItem bai2;
    }
}

