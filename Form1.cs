//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Threading;

//namespace MatrixAnimation
//{
//    public partial class Form1 : Form
//    {
//        public int m_width;  // Width of the grid cell

//        public int m_height;  // The height of the Cell

//        public int m_NoOfRows;  // The Number of Rows

//        public int m_NoOfCols;  // The Number of Columns

//        public int m_XOffset;  // Offset from which drawing start

//        private void btnStart_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}




using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixAnimation
{
    public partial class Form1 : Form
    {
        private const int Rows = 4; // Number of rows in the matrix
        private const int Cols = 4; // Number of columns in the matrix
        private int currentNumber = 2; // Starting number for animation
        private int[,] matrix; // The matrix grid
        private bool isAnimating = false; // Animation state
        private bool isPaused = false; // Pause state

        public Form1()
        {
            InitializeComponent();
            InitializeMatrix();
        }

        private void InitializeMatrix()
        {
            matrix = new int[Rows, Cols];
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isAnimating)
            {
                isAnimating = true;
                isPaused = false; // Ensure animation is not paused
                Task.Run(() => StartAnimation());
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (isAnimating)
            {
                isPaused = !isPaused; // Toggle pause state
                btnPause.Text = isPaused ? "Resume" : "Pause"; // Update button text
            }
        }

        private void StartAnimation()
        {
            while (isAnimating)
            {
                if (isPaused)
                {
                    Thread.Sleep(100); // Check the pause state periodically
                    continue;
                }

                // Update the matrix with the current number
                UpdateMatrix(currentNumber);

                // Increment the number and loop back to 2 after 8
                currentNumber++;
                if (currentNumber > 8)
                {
                    currentNumber = 2;
                }

                // Redraw the grid
                panelGrid.Invoke(new Action(() =>
                {
                    panelGrid.Refresh(); // Trigger a repaint of the panel
                }));

                Thread.Sleep(200); // Adjust speed of animation
            }
        }

        private void UpdateMatrix(int number)
        {
            Random rand = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    matrix[i, j] = (rand.Next(2, 9) == number) ? number : 0;
                }
            }
        }

        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    // Stop the animation when the form is closing
        //    isAnimating = false;
        //    base.OnFormClosing(e);
        //}

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int cellWidth = panelGrid.Width / Cols;
            int cellHeight = panelGrid.Height / Rows;

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    int x = j * cellWidth;
                    int y = i * cellHeight;

                    // Draw cell borders
                    g.DrawRectangle(Pens.Black, x, y, cellWidth, cellHeight);

                    // Draw the number in the cell
                    if (matrix[i, j] != 0)
                    {
                        string text = matrix[i, j].ToString();
                        var size = g.MeasureString(text, this.Font);
                        g.DrawString(text, this.Font, Brushes.Green,
                            x + (cellWidth - size.Width) / 2,
                            y + (cellHeight - size.Height) / 2);
                    }
                    // Draw active cells
                    //if (matrix[i, j] == 1)
                    //{
                    //    g.FillRectangle(Brushes.Green, x, y, cellWidth, cellHeight);
                    //}
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isAnimating = false;
        }
    }
}
