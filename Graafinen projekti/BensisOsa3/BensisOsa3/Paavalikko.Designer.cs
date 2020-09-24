namespace BensisOsa3
{
    partial class Paavalikko
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paavalikko));
            this.button1 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vALIKKOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinnastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tankitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sammutaOhjelmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(183, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 146);
            this.button1.TabIndex = 1;
            this.button1.Text = "TERVETULOA! ALOITA TANKKAUS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vALIKKOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vALIKKOToolStripMenuItem
            // 
            this.vALIKKOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinnastoToolStripMenuItem,
            this.tankitToolStripMenuItem,
            this.sammutaOhjelmaToolStripMenuItem});
            this.vALIKKOToolStripMenuItem.Name = "vALIKKOToolStripMenuItem";
            this.vALIKKOToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.vALIKKOToolStripMenuItem.Text = "Valikko";
            // 
            // hinnastoToolStripMenuItem
            // 
            this.hinnastoToolStripMenuItem.Name = "hinnastoToolStripMenuItem";
            this.hinnastoToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.hinnastoToolStripMenuItem.Text = "Hinnasto";
            this.hinnastoToolStripMenuItem.Click += new System.EventHandler(this.HinnastoToolStripMenuItem_Click);
            // 
            // tankitToolStripMenuItem
            // 
            this.tankitToolStripMenuItem.Name = "tankitToolStripMenuItem";
            this.tankitToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.tankitToolStripMenuItem.Text = "Tankit";
            this.tankitToolStripMenuItem.Click += new System.EventHandler(this.TankitToolStripMenuItem_Click);
            // 
            // sammutaOhjelmaToolStripMenuItem
            // 
            this.sammutaOhjelmaToolStripMenuItem.Name = "sammutaOhjelmaToolStripMenuItem";
            this.sammutaOhjelmaToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.sammutaOhjelmaToolStripMenuItem.Text = "Sammuta ohjelma";
            this.sammutaOhjelmaToolStripMenuItem.Click += new System.EventHandler(this.SammutaOhjelmaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 53);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // Paavalikko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Paavalikko";
            this.Text = "PÄÄVALIKKO";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vALIKKOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinnastoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tankitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sammutaOhjelmaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}