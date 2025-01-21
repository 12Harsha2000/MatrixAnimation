//namespace MatrixAnimation
//{
//    partial class Form1
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
//            this.panelGrid = new System.Windows.Forms.Panel();
//            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
//            this.animationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
//            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
//            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
//            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
//            this.menuStrip1.SuspendLayout();
//            this.toolStrip1.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // panelGrid
//            // 
//            this.panelGrid.Location = new System.Drawing.Point(298, 80);
//            this.panelGrid.Name = "panelGrid";
//            this.panelGrid.Size = new System.Drawing.Size(200, 200);
//            this.panelGrid.TabIndex = 0;
//            this.panelGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrid_Paint);
//            // 
//            // menuStrip1
//            // 
//            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
//            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.animationToolStripMenuItem,
//            this.startToolStripMenuItem,
//            this.pauseToolStripMenuItem,
//            this.stopToolStripMenuItem});
//            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
//            this.menuStrip1.Name = "menuStrip1";
//            this.menuStrip1.Size = new System.Drawing.Size(785, 28);
//            this.menuStrip1.TabIndex = 1;
//            this.menuStrip1.Text = "menuStrip1";
//            // 
//            // animationToolStripMenuItem
//            // 
//            this.animationToolStripMenuItem.Name = "animationToolStripMenuItem";
//            this.animationToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
//            this.animationToolStripMenuItem.Text = "Animation";
//            // 
//            // startToolStripMenuItem
//            // 
//            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
//            this.startToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
//            this.startToolStripMenuItem.Text = "Start";
//            // 
//            // pauseToolStripMenuItem
//            // 
//            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
//            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
//            this.pauseToolStripMenuItem.Text = "Pause";
//            // 
//            // stopToolStripMenuItem
//            // 
//            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
//            this.stopToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
//            this.stopToolStripMenuItem.Text = "Stop";
//            // 
//            // toolStrip1
//            // 
//            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
//            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.toolStripButton1,
//            this.toolStripButton2,
//            this.toolStripButton3});
//            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
//            this.toolStrip1.Name = "toolStrip1";
//            this.toolStrip1.Size = new System.Drawing.Size(785, 27);
//            this.toolStrip1.TabIndex = 2;
//            this.toolStrip1.Text = "toolStrip1";
//            // 
//            // toolStripButton1
//            // 
//            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
//            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
//            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this.toolStripButton1.Name = "toolStripButton1";
//            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
//            this.toolStripButton1.Text = "tar";
//            // 
//            // toolStripButton2
//            // 
//            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
//            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
//            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this.toolStripButton2.Name = "toolStripButton2";
//            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
//            this.toolStripButton2.Text = "toolStripButton2";
//            // 
//            // toolStripButton3
//            // 
//            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
//            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
//            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this.toolStripButton3.Name = "toolStripButton3";
//            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
//            this.toolStripButton3.Text = "toolStripButton3";
//            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
//            // 
//            // Form1
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(785, 513);
//            this.Controls.Add(this.toolStrip1);
//            this.Controls.Add(this.panelGrid);
//            this.Controls.Add(this.menuStrip1);
//            this.Name = "Form1";
//            this.Text = "Form1";
//            this.menuStrip1.ResumeLayout(false);
//            this.menuStrip1.PerformLayout();
//            this.toolStrip1.ResumeLayout(false);
//            this.toolStrip1.PerformLayout();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Panel panelGrid;
//        private System.Windows.Forms.MenuStrip menuStrip1;
//        private System.Windows.Forms.ToolStripMenuItem animationToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
//        private System.Windows.Forms.ToolStrip toolStrip1;
//        private System.Windows.Forms.ToolStripButton toolStripButton1;
//        private System.Windows.Forms.ToolStripButton toolStripButton2;
//        private System.Windows.Forms.ToolStripButton toolStripButton3;
//    }
//}

using System.Drawing;
using System.Windows.Forms;
using System;

namespace MatrixAnimation
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox comboBoxGridSize;
        private Panel panelGrid;
        private MenuStrip menuStrip;
        private ToolStrip toolStrip;
        private ToolStripButton startToolStripButton;
        private ToolStripButton pauseResumeToolStripButton;
        private ToolStripButton stopToolStripButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxGridSize = new System.Windows.Forms.ComboBox();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.startToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pauseResumeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stopToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.startMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseResumeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxGridSize
            // 
            this.comboBoxGridSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGridSize.Location = new System.Drawing.Point(12, 31);
            this.comboBoxGridSize.Name = "comboBoxGridSize";
            this.comboBoxGridSize.Size = new System.Drawing.Size(142, 24);
            this.comboBoxGridSize.TabIndex = 0;
            // 
            // panelGrid
            // 
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Location = new System.Drawing.Point(10, 75);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(200, 200);
            this.panelGrid.TabIndex = 1;
            this.panelGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrid_Paint);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 27);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 2;
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripButton,
            this.pauseResumeToolStripButton,
            this.stopToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 27);
            this.toolStrip.TabIndex = 3;
            // 
            // startToolStripButton
            // 
            this.startToolStripButton.Name = "startToolStripButton";
            this.startToolStripButton.Size = new System.Drawing.Size(44, 24);
            this.startToolStripButton.Text = "Start";
            this.startToolStripButton.Click += new System.EventHandler(this.Start_Click);
            // 
            // pauseResumeToolStripButton
            // 
            this.pauseResumeToolStripButton.Name = "pauseResumeToolStripButton";
            this.pauseResumeToolStripButton.Size = new System.Drawing.Size(50, 24);
            this.pauseResumeToolStripButton.Text = "Pause";
            this.pauseResumeToolStripButton.Click += new System.EventHandler(this.PauseResume_Click);
            // 
            // stopToolStripButton
            // 
            this.stopToolStripButton.Name = "stopToolStripButton";
            this.stopToolStripButton.Size = new System.Drawing.Size(44, 24);
            this.stopToolStripButton.Text = "Stop";
            this.stopToolStripButton.Click += new System.EventHandler(this.Stop_Click);
            // 
            // startMenuItem
            // 
            this.startMenuItem.Name = "startMenuItem";
            this.startMenuItem.Size = new System.Drawing.Size(224, 26);
            this.startMenuItem.Text = "Start";
            this.startMenuItem.Click += new System.EventHandler(this.Start_Click);
            // 
            // pauseResumeMenuItem
            // 
            this.pauseResumeMenuItem.Name = "pauseResumeMenuItem";
            this.pauseResumeMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pauseResumeMenuItem.Text = "Pause";
            this.pauseResumeMenuItem.Click += new System.EventHandler(this.PauseResume_Click);
            // 
            // stopMenuItem
            // 
            this.stopMenuItem.Name = "stopMenuItem";
            this.stopMenuItem.Size = new System.Drawing.Size(224, 26);
            this.stopMenuItem.Text = "Stop";
            this.stopMenuItem.Click += new System.EventHandler(this.Stop_Click);
            // 
            // actionsMenuItem
            // 
            this.actionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startMenuItem,
            this.pauseResumeMenuItem,
            this.stopMenuItem});
            this.actionsMenuItem.Name = "actionsMenuItem";
            this.actionsMenuItem.Size = new System.Drawing.Size(72, 24);
            this.actionsMenuItem.Text = "Actions";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.comboBoxGridSize);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.toolStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Matrix Animation";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ToolStripMenuItem actionsMenuItem;
        private ToolStripMenuItem startMenuItem;
        private ToolStripMenuItem pauseResumeMenuItem;
        private ToolStripMenuItem stopMenuItem;
    }
}

