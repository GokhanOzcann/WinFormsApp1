namespace WinFormsApp1
{
    partial class Form2
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bbbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cccccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Profilim = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.Profilim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaaToolStripMenuItem,
            this.bbbToolStripMenuItem,
            this.cccccToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // aaaToolStripMenuItem
            // 
            this.aaaToolStripMenuItem.Name = "aaaToolStripMenuItem";
            this.aaaToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.aaaToolStripMenuItem.Text = "Hesabım";
            this.aaaToolStripMenuItem.Click += new System.EventHandler(this.aaaToolStripMenuItem_Click);
            // 
            // bbbToolStripMenuItem
            // 
            this.bbbToolStripMenuItem.Name = "bbbToolStripMenuItem";
            this.bbbToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.bbbToolStripMenuItem.Text = "Siparişler";
            this.bbbToolStripMenuItem.Click += new System.EventHandler(this.bbbToolStripMenuItem_Click);
            // 
            // cccccToolStripMenuItem
            // 
            this.cccccToolStripMenuItem.Name = "cccccToolStripMenuItem";
            this.cccccToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.cccccToolStripMenuItem.Text = "Bakiye";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(286, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // Profilim
            // 
            this.Profilim.BackColor = System.Drawing.Color.RosyBrown;
            this.Profilim.Controls.Add(this.pictureBox1);
            this.Profilim.Location = new System.Drawing.Point(248, 73);
            this.Profilim.Name = "Profilim";
            this.Profilim.Size = new System.Drawing.Size(306, 278);
            this.Profilim.TabIndex = 2;
            this.Profilim.TabStop = false;
            this.Profilim.Text = "Profilim";
            this.Profilim.Enter += new System.EventHandler(this.aaaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(193, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 154);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Profilim);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Hoşgeldiniz...";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Profilim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem aaaToolStripMenuItem;
        private ToolStripMenuItem bbbToolStripMenuItem;
        private ToolStripMenuItem cccccToolStripMenuItem;
        private DateTimePicker dateTimePicker1;
        private GroupBox Profilim;
        private PictureBox pictureBox1;
    }
}