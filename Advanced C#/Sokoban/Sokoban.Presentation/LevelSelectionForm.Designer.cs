namespace Sokoban.Presentation
{
    partial class LevelSelectionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.levelSelectionGrid = new System.Windows.Forms.DataGridView();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelPreview = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.levelSelectionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // levelSelectionGrid
            // 
            this.levelSelectionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.levelSelectionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Level});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.levelSelectionGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.levelSelectionGrid.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.levelSelectionGrid.Location = new System.Drawing.Point(13, 13);
            this.levelSelectionGrid.Name = "levelSelectionGrid";
            this.levelSelectionGrid.ReadOnly = true;
            this.levelSelectionGrid.RowHeadersVisible = false;
            this.levelSelectionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.levelSelectionGrid.Size = new System.Drawing.Size(243, 236);
            this.levelSelectionGrid.TabIndex = 0;
            // 
            // Level
            // 
            this.Level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            // 
            // levelPreview
            // 
            this.levelPreview.BackColor = System.Drawing.Color.Gray;
            this.levelPreview.Location = new System.Drawing.Point(263, 13);
            this.levelPreview.Name = "levelPreview";
            this.levelPreview.Size = new System.Drawing.Size(248, 236);
            this.levelPreview.TabIndex = 1;
            this.levelPreview.TabStop = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(355, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(436, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LevelSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 299);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.levelPreview);
            this.Controls.Add(this.levelSelectionGrid);
            this.Name = "LevelSelectionForm";
            this.Text = "LevelSelectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.levelSelectionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView levelSelectionGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.PictureBox levelPreview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}