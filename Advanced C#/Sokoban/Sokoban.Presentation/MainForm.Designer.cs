namespace Sokoban.Presentation
{
    partial class MainForm
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
            this.startMenu = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topRankingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.levelLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pointsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.newGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLevelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionMenu = new System.Windows.Forms.ToolStrip();
            this.restartButton = new System.Windows.Forms.ToolStripButton();
            this.undoButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.drawingArea = new System.Windows.Forms.PictureBox();
            this.startMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.actionMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // startMenu
            // 
            this.startMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.levelSelectionToolStripMenuItem,
            this.topRankingMenuItem});
            this.startMenu.Location = new System.Drawing.Point(0, 0);
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(695, 24);
            this.startMenu.TabIndex = 1;
            this.startMenu.Text = "StartMenu";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameMenuItem,
            this.changeLevelMenuItem,
            this.exitMenuItem});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // levelSelectionToolStripMenuItem
            // 
            this.levelSelectionToolStripMenuItem.Name = "levelSelectionToolStripMenuItem";
            this.levelSelectionToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.levelSelectionToolStripMenuItem.Text = "Level selection";
            this.levelSelectionToolStripMenuItem.Click += new System.EventHandler(this.levelSelectionToolStripMenuItem_Click);
            // 
            // topRankingMenuItem
            // 
            this.topRankingMenuItem.Name = "topRankingMenuItem";
            this.topRankingMenuItem.Size = new System.Drawing.Size(55, 20);
            this.topRankingMenuItem.Text = "Top 10";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.statusLabel,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.levelLabel,
            this.toolStripStatusLabel6,
            this.timerLabel,
            this.toolStripStatusLabel8,
            this.pointsLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(695, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(350, 17);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel2.Text = "Status:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel3.Text = "Level:";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(0, 17);
            // 
            // levelLabel
            // 
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(13, 17);
            this.levelLabel.Text = "1";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel6.Text = "Time:";
            // 
            // timerLabel
            // 
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(34, 17);
            this.timerLabel.Text = "00:00";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel8.Text = "Points:";
            // 
            // pointsLabel
            // 
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(19, 17);
            this.pointsLabel.Text = "20";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(69, 17);
            this.statusLabel.Text = "Not playing";
            // 
            // newGameMenuItem
            // 
            this.newGameMenuItem.Name = "newGameMenuItem";
            this.newGameMenuItem.Size = new System.Drawing.Size(142, 22);
            this.newGameMenuItem.Text = "New game";
            // 
            // changeLevelMenuItem
            // 
            this.changeLevelMenuItem.Name = "changeLevelMenuItem";
            this.changeLevelMenuItem.Size = new System.Drawing.Size(142, 22);
            this.changeLevelMenuItem.Text = "Change level";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exitMenuItem.Text = "Exit";
            // 
            // actionMenu
            // 
            this.actionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartButton,
            this.undoButton});
            this.actionMenu.Location = new System.Drawing.Point(0, 24);
            this.actionMenu.Name = "actionMenu";
            this.actionMenu.Size = new System.Drawing.Size(695, 25);
            this.actionMenu.TabIndex = 6;
            this.actionMenu.Text = "toolStrip1";
            // 
            // restartButton
            // 
            this.restartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.restartButton.Image = global::Sokoban.Presentation.Properties.Resources.restart;
            this.restartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(23, 22);
            this.restartButton.Text = "restartButton";
            // 
            // undoButton
            // 
            this.undoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoButton.Image = global::Sokoban.Presentation.Properties.Resources.undo;
            this.undoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(23, 22);
            this.undoButton.Text = "undoButton";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.drawingArea);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 487);
            this.panel1.TabIndex = 7;
            // 
            // drawingArea
            // 
            this.drawingArea.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.drawingArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drawingArea.Location = new System.Drawing.Point(0, 0);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(438, 358);
            this.drawingArea.TabIndex = 0;
            this.drawingArea.TabStop = false;
            this.drawingArea.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.actionMenu);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.startMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.startMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOKOBAN";
            this.startMenu.ResumeLayout(false);
            this.startMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.actionMenu.ResumeLayout(false);
            this.actionMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawingArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip startMenu;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topRankingMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel levelLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel timerLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel pointsLabel;
        private System.Windows.Forms.ToolStripMenuItem newGameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLevelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStrip actionMenu;
        private System.Windows.Forms.ToolStripButton restartButton;
        private System.Windows.Forms.ToolStripButton undoButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox drawingArea;
    }
}

