using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban.Presentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.undoButton.Click += undoButton_Click;
            this.restartButton.Click += restartButton_Click;
            this.newGameMenuItem.Click += newGameMenuItem_Click;
            this.changeLevelMenuItem.Click += changeLevelMenuItem_Click;
            this.exitMenuItem.Click += exitMenuItem_Click;
            this.topRankingMenuItem.Click += topRankingMenuItem_Click;
            this.drawingArea.Paint += drawingArea_Paint;
            this.KeyDown += MainForm_KeyDown;
            this.Load += MainForm_Load;
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        void drawingArea_Paint(object sender, PaintEventArgs e)
        {
            
        }

        void topRankingMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        void exitMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        void changeLevelMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        void newGameMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        void restartButton_Click(object sender, EventArgs e)
        {

        }

        void undoButton_Click(object sender, EventArgs e)
        {

        }

        private void GoToLevel(int levelNumber)
        {

        }

        private void levelSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevelSelectionForm levelSelectionForm = new LevelSelectionForm();
            if (levelSelectionForm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
