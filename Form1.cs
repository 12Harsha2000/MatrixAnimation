﻿//using System;
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




//using System;
//using System.Drawing;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace MatrixAnimation
//{
//    public partial class Form1 : Form
//    {
//        private int gridSize = 2; // Initial grid size
//        private bool isAnimating = false; // Animation state
//        private bool isPaused = false; // Pause state

//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void btnStart_Click(object sender, EventArgs e)
//        {
//            if (!isAnimating)
//            {
//                isAnimating = true;
//                isPaused = false;
//                Task.Run(() => StartAnimation());
//            }
//        }

//        private void btnPause_Click(object sender, EventArgs e)
//        {
//            if (isAnimating)
//            {
//                isPaused = !isPaused; // Toggle pause state
//                btnPause.Text = isPaused ? "Resume" : "Pause";
//            }
//        }

//        private void btnStop_Click(object sender, EventArgs e)
//        {
//            isAnimating = false;
//            panelGrid.Invoke(new Action(() => panelGrid.Refresh())); // Clear grid
//        }

//        private void StartAnimation()
//        {
//            while (isAnimating)
//            {
//                if (isPaused)
//                {
//                    Thread.Sleep(100); // Check pause state periodically
//                    continue;
//                }

//                // Refresh the grid
//                panelGrid.Invoke(new Action(() =>
//                {
//                    panelGrid.Refresh(); // Trigger a repaint of the panel
//                }));

//                Thread.Sleep(1200); // Duration for each grid size

//                // Increment grid size
//                gridSize++;
//                if (gridSize > 8)
//                {
//                    gridSize = 2; // Loop back to 2x2
//                }
//            }
//        }

//        private void panelGrid_Paint(object sender, PaintEventArgs e)
//        {
//            Graphics g = e.Graphics;
//            int cellWidth = panelGrid.Width / gridSize;
//            int cellHeight = panelGrid.Height / gridSize;

//            Pen greenPen = new Pen(Color.Green, 2); // Green border for the grid

//            for (int i = 0; i < gridSize; i++)
//            {
//                for (int j = 0; j < gridSize; j++)
//                {
//                    int x = j * cellWidth;
//                    int y = i * cellHeight;

//                    // Draw grid cell borders in green
//                    g.DrawRectangle(greenPen, x, y, cellWidth, cellHeight);
//                }
//            }

//            greenPen.Dispose(); // Clean up resources
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
        private int gridSize = 2; // Default grid size
        private bool isAnimating = false; // Animation state
        private bool isPaused = false; // Pause state

        public Form1()
        {
            InitializeComponent();
            PopulateGridSizeDropdown(); // Add grid sizes to the dropdown
        }

        // Populate the dropdown with grid sizes
        private void PopulateGridSizeDropdown()
        {
            for (int i = 3; i <= 8; i++) // 3x3 to 8x8
            {
                comboBoxGridSize.Items.Add($"{i}x{i}");
            }
            comboBoxGridSize.SelectedIndex = 0; // Default selection
        }

        private void StartAnimation()
        {
            while (isAnimating)
            {
                if (isPaused)
                {
                    Thread.Sleep(100); // Wait while paused
                    continue;
                }

                // Refresh the grid
                panelGrid.Invoke(new Action(() =>
                {
                    panelGrid.Refresh(); // Trigger a repaint of the panel
                }));

                Thread.Sleep(1200); // Duration for each grid size

                // Increment grid size for animation
                gridSize++;
                if (gridSize > 8)
                {
                    gridSize = 2; // Reset to 2x2
                }
            }
        }

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int cellWidth = panelGrid.Width / gridSize;
            int cellHeight = panelGrid.Height / gridSize;

            Pen greenPen = new Pen(Color.Green, 2); // Green border for the grid

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    int x = j * cellWidth;
                    int y = i * cellHeight;

                    // Draw grid cell borders in green
                    g.DrawRectangle(greenPen, x, y, cellWidth, cellHeight);
                }
            }

            greenPen.Dispose(); // Clean up resources
        }

        // Menu and Toolbar Event Handlers
        private void Start_Click(object sender, EventArgs e)
        {
            if (!isAnimating)
            {
                isAnimating = true;
                isPaused = false;

                if (comboBoxGridSize.SelectedItem != null)
                {
                    string[] gridParts = comboBoxGridSize.SelectedItem.ToString().Split('x');
                    gridSize = int.Parse(gridParts[0]); // Set grid size from dropdown
                }

                Task.Run(() => StartAnimation());
            }
        }

        private void PauseResume_Click(object sender, EventArgs e)
        {
            if (isAnimating)
            {
                isPaused = !isPaused; // Toggle pause state
                pauseResumeMenuItem.Text = isPaused ? "Resume" : "Pause";
                pauseResumeToolStripButton.Text = isPaused ? "Resume" : "Pause";
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            isAnimating = false;
            panelGrid.Invoke(new Action(() => panelGrid.Refresh())); // Clear grid
            pauseResumeMenuItem.Text = "Pause"; // Reset menu text
            pauseResumeToolStripButton.Text = "Pause"; // Reset toolbar text
        }
    }
}

