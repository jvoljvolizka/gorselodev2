namespace odev2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.başlatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sıcaklıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.başlatToolStripMenuItem,
            this.sıcaklıkToolStripMenuItem,
            this.nemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // başlatToolStripMenuItem
            // 
            this.başlatToolStripMenuItem.Name = "başlatToolStripMenuItem";
            this.başlatToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.başlatToolStripMenuItem.Text = "başlat";
            // 
            // sıcaklıkToolStripMenuItem
            // 
            this.sıcaklıkToolStripMenuItem.Name = "sıcaklıkToolStripMenuItem";
            this.sıcaklıkToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sıcaklıkToolStripMenuItem.Text = "Sıcaklık";
            this.sıcaklıkToolStripMenuItem.Click += new System.EventHandler(this.sıcaklıkToolStripMenuItem_Click);
            // 
            // nemToolStripMenuItem
            // 
            this.nemToolStripMenuItem.Name = "nemToolStripMenuItem";
            this.nemToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.nemToolStripMenuItem.Text = "Nem";
            this.nemToolStripMenuItem.Click += new System.EventHandler(this.nemToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem başlatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sıcaklıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nemToolStripMenuItem;
    }
}

