namespace TickTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTNA1 = new System.Windows.Forms.Button();
            this.BTNA2 = new System.Windows.Forms.Button();
            this.BTNA3 = new System.Windows.Forms.Button();
            this.BTNB1 = new System.Windows.Forms.Button();
            this.BTNB2 = new System.Windows.Forms.Button();
            this.BTNB3 = new System.Windows.Forms.Button();
            this.BTNC2 = new System.Windows.Forms.Button();
            this.BTNC1 = new System.Windows.Forms.Button();
            this.BTNC3 = new System.Windows.Forms.Button();
            this.WM_background = new System.ComponentModel.BackgroundWorker();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // BTNA1
            // 
            this.BTNA1.BackColor = System.Drawing.Color.LightGray;
            this.BTNA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNA1.Location = new System.Drawing.Point(135, 143);
            this.BTNA1.Name = "BTNA1";
            this.BTNA1.Size = new System.Drawing.Size(75, 75);
            this.BTNA1.TabIndex = 1;
            this.BTNA1.TabStop = false;
            this.BTNA1.UseVisualStyleBackColor = false;
            this.BTNA1.Click += new System.EventHandler(this.BTNClicked);
            this.BTNA1.MouseEnter += new System.EventHandler(this.BTN_Enter);
            this.BTNA1.MouseLeave += new System.EventHandler(this.BTN_Leave);
            // 
            // BTNA2
            // 
            this.BTNA2.BackColor = System.Drawing.Color.LightGray;
            this.BTNA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNA2.Location = new System.Drawing.Point(216, 143);
            this.BTNA2.Name = "BTNA2";
            this.BTNA2.Size = new System.Drawing.Size(75, 75);
            this.BTNA2.TabIndex = 2;
            this.BTNA2.TabStop = false;
            this.BTNA2.UseVisualStyleBackColor = false;
            this.BTNA2.Click += new System.EventHandler(this.BTNClicked);
            this.BTNA2.MouseEnter += new System.EventHandler(this.BTN_Enter);
            this.BTNA2.MouseLeave += new System.EventHandler(this.BTN_Leave);
            // 
            // BTNA3
            // 
            this.BTNA3.BackColor = System.Drawing.Color.LightGray;
            this.BTNA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNA3.Location = new System.Drawing.Point(297, 143);
            this.BTNA3.Name = "BTNA3";
            this.BTNA3.Size = new System.Drawing.Size(75, 75);
            this.BTNA3.TabIndex = 3;
            this.BTNA3.TabStop = false;
            this.BTNA3.UseVisualStyleBackColor = false;
            this.BTNA3.Click += new System.EventHandler(this.BTNClicked);
            this.BTNA3.MouseEnter += new System.EventHandler(this.BTN_Enter);
            this.BTNA3.MouseLeave += new System.EventHandler(this.BTN_Leave);
            // 
            // BTNB1
            // 
            this.BTNB1.BackColor = System.Drawing.Color.LightGray;
            this.BTNB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNB1.Location = new System.Drawing.Point(135, 224);
            this.BTNB1.Name = "BTNB1";
            this.BTNB1.Size = new System.Drawing.Size(75, 75);
            this.BTNB1.TabIndex = 4;
            this.BTNB1.TabStop = false;
            this.BTNB1.UseVisualStyleBackColor = false;
            this.BTNB1.Click += new System.EventHandler(this.BTNClicked);
            this.BTNB1.MouseEnter += new System.EventHandler(this.BTN_Enter);
            this.BTNB1.MouseLeave += new System.EventHandler(this.BTN_Leave);
            // 
            // BTNB2
            // 
            this.BTNB2.BackColor = System.Drawing.Color.LightGray;
            this.BTNB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNB2.Location = new System.Drawing.Point(218, 224);
            this.BTNB2.Name = "BTNB2";
            this.BTNB2.Size = new System.Drawing.Size(75, 75);
            this.BTNB2.TabIndex = 5;
            this.BTNB2.TabStop = false;
            this.BTNB2.UseVisualStyleBackColor = false;
            this.BTNB2.Click += new System.EventHandler(this.BTNClicked);
            this.BTNB2.MouseEnter += new System.EventHandler(this.BTN_Enter);
            this.BTNB2.MouseLeave += new System.EventHandler(this.BTN_Leave);
            // 
            // BTNB3
            // 
            this.BTNB3.BackColor = System.Drawing.Color.LightGray;
            this.BTNB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNB3.Location = new System.Drawing.Point(297, 224);
            this.BTNB3.Name = "BTNB3";
            this.BTNB3.Size = new System.Drawing.Size(75, 75);
            this.BTNB3.TabIndex = 6;
            this.BTNB3.TabStop = false;
            this.BTNB3.UseVisualStyleBackColor = false;
            this.BTNB3.Click += new System.EventHandler(this.BTNClicked);
            this.BTNB3.MouseEnter += new System.EventHandler(this.BTN_Enter);
            this.BTNB3.MouseLeave += new System.EventHandler(this.BTN_Leave);
            // 
            // BTNC2
            // 
            this.BTNC2.BackColor = System.Drawing.Color.LightGray;
            this.BTNC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNC2.Location = new System.Drawing.Point(216, 305);
            this.BTNC2.Name = "BTNC2";
            this.BTNC2.Size = new System.Drawing.Size(75, 75);
            this.BTNC2.TabIndex = 7;
            this.BTNC2.TabStop = false;
            this.BTNC2.UseVisualStyleBackColor = false;
            this.BTNC2.Click += new System.EventHandler(this.BTNClicked);
            this.BTNC2.MouseEnter += new System.EventHandler(this.BTN_Enter);
            this.BTNC2.MouseLeave += new System.EventHandler(this.BTN_Leave);
            // 
            // BTNC1
            // 
            this.BTNC1.BackColor = System.Drawing.Color.LightGray;
            this.BTNC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNC1.Location = new System.Drawing.Point(135, 305);
            this.BTNC1.Name = "BTNC1";
            this.BTNC1.Size = new System.Drawing.Size(75, 75);
            this.BTNC1.TabIndex = 8;
            this.BTNC1.TabStop = false;
            this.BTNC1.UseVisualStyleBackColor = false;
            this.BTNC1.Click += new System.EventHandler(this.BTNClicked);
            this.BTNC1.MouseEnter += new System.EventHandler(this.BTN_Enter);
            this.BTNC1.MouseLeave += new System.EventHandler(this.BTN_Leave);
            // 
            // BTNC3
            // 
            this.BTNC3.BackColor = System.Drawing.Color.LightGray;
            this.BTNC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNC3.Location = new System.Drawing.Point(297, 305);
            this.BTNC3.Name = "BTNC3";
            this.BTNC3.Size = new System.Drawing.Size(75, 75);
            this.BTNC3.TabIndex = 9;
            this.BTNC3.TabStop = false;
            this.BTNC3.UseVisualStyleBackColor = false;
            this.BTNC3.Click += new System.EventHandler(this.BTNClicked);
            this.BTNC3.MouseEnter += new System.EventHandler(this.BTN_Enter);
            this.BTNC3.MouseLeave += new System.EventHandler(this.BTN_Leave);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(414, 444);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 10;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(517, 511);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.BTNC3);
            this.Controls.Add(this.BTNC1);
            this.Controls.Add(this.BTNC2);
            this.Controls.Add(this.BTNB3);
            this.Controls.Add(this.BTNB2);
            this.Controls.Add(this.BTNB1);
            this.Controls.Add(this.BTNA3);
            this.Controls.Add(this.BTNA2);
            this.Controls.Add(this.BTNA1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button BTNA1;
        private System.Windows.Forms.Button BTNA2;
        private System.Windows.Forms.Button BTNA3;
        private System.Windows.Forms.Button BTNB1;
        private System.Windows.Forms.Button BTNB2;
        private System.Windows.Forms.Button BTNB3;
        private System.Windows.Forms.Button BTNC2;
        private System.Windows.Forms.Button BTNC1;
        private System.Windows.Forms.Button BTNC3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker WM_background;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

