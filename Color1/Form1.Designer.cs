﻿namespace Color1
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.GSequal = new System.Windows.Forms.ToolStripMenuItem();
			this.GShdtv = new System.Windows.Forms.ToolStripMenuItem();
			this.GSdifference = new System.Windows.Forms.ToolStripMenuItem();
			this.GShistogram = new System.Windows.Forms.ToolStripMenuItem();
			this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.histogramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.grayscaleToolStripMenuItem,
            this.rGBToolStripMenuItem,
            this.hSVToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(476, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.openToolStripMenuItem.Text = "Open...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(12, 27);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(454, 385);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox.TabIndex = 2;
			this.pictureBox.TabStop = false;
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.saveToolStripMenuItem.Text = "Save...";
			// 
			// grayscaleToolStripMenuItem
			// 
			this.grayscaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GSequal,
            this.GShdtv,
            this.GSdifference,
            this.GShistogram});
			this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
			this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.grayscaleToolStripMenuItem.Text = "Grayscale";
			// 
			// rGBToolStripMenuItem
			// 
			this.rGBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.histogramToolStripMenuItem1});
			this.rGBToolStripMenuItem.Name = "rGBToolStripMenuItem";
			this.rGBToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
			this.rGBToolStripMenuItem.Text = "RGB";
			// 
			// hSVToolStripMenuItem
			// 
			this.hSVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToolStripMenuItem,
            this.editToolStripMenuItem});
			this.hSVToolStripMenuItem.Name = "hSVToolStripMenuItem";
			this.hSVToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
			this.hSVToolStripMenuItem.Text = "HSV";
			// 
			// GSequal
			// 
			this.GSequal.Name = "GSequal";
			this.GSequal.Size = new System.Drawing.Size(152, 22);
			this.GSequal.Text = "Equal";
			this.GSequal.Click += new System.EventHandler(this.GSequal_Click);
			// 
			// GShdtv
			// 
			this.GShdtv.Name = "GShdtv";
			this.GShdtv.Size = new System.Drawing.Size(152, 22);
			this.GShdtv.Text = "HDTV";
			this.GShdtv.Click += new System.EventHandler(this.GShdtv_Click);
			// 
			// GSdifference
			// 
			this.GSdifference.Name = "GSdifference";
			this.GSdifference.Size = new System.Drawing.Size(152, 22);
			this.GSdifference.Text = "Difference";
			this.GSdifference.Click += new System.EventHandler(this.GSdifference_Click);
			// 
			// GShistogram
			// 
			this.GShistogram.Name = "GShistogram";
			this.GShistogram.Size = new System.Drawing.Size(152, 22);
			this.GShistogram.Text = "Histogram";
			this.GShistogram.Click += new System.EventHandler(this.GShistogram_Click);
			// 
			// redToolStripMenuItem
			// 
			this.redToolStripMenuItem.Name = "redToolStripMenuItem";
			this.redToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.redToolStripMenuItem.Text = "Red";
			// 
			// greenToolStripMenuItem
			// 
			this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
			this.greenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.greenToolStripMenuItem.Text = "Green";
			// 
			// blueToolStripMenuItem
			// 
			this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
			this.blueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.blueToolStripMenuItem.Text = "Blue";
			// 
			// histogramToolStripMenuItem1
			// 
			this.histogramToolStripMenuItem1.Name = "histogramToolStripMenuItem1";
			this.histogramToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.histogramToolStripMenuItem1.Text = "Histogram";
			// 
			// convertToolStripMenuItem
			// 
			this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
			this.convertToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.convertToolStripMenuItem.Text = "Convert";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.editToolStripMenuItem.Text = "Edit...";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(476, 421);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem GSequal;
		private System.Windows.Forms.ToolStripMenuItem GShdtv;
		private System.Windows.Forms.ToolStripMenuItem GSdifference;
		private System.Windows.Forms.ToolStripMenuItem GShistogram;
		private System.Windows.Forms.ToolStripMenuItem rGBToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem hSVToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
	}
}

